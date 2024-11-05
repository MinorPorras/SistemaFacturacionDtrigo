Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop.Access
Imports System.Configuration
Module Md_BackupDB
    ' Lista de tablas a procesar
    Dim tablas As List(Of String) = New List(Of String) From {"productos", "clientes", "pedidos"}
    Dim DBActual As String = ".\bd\dbSistemaFacturación.accdb"
#Region "exportar"
    Friend Sub exportarDB()
        ' Define the paths
        Dim fechaActual As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        ' Acceder a la ruta de acceso desde el archivo App.config
        Dim backupDir As String = ConfigurationManager.AppSettings("DirectorioRespaldo")
        Dim respaldo As String = backupDir & "DBSistemaFact_" & fechaActual & ".accdb"

        ' Create the backup directory if it doesn't exist
        If Not Directory.Exists(backupDir) Then
            Directory.CreateDirectory(backupDir)
        End If

        ' Create a new Access application
        Dim accessApp As New Application()

        ' Check if backupFile exists, if not, create it
        If Not File.Exists(respaldo) Then
            Try
                accessApp.NewCurrentDatabase(respaldo)
                Console.WriteLine("Nuevo archivo creado exitosamente: " & respaldo)
            Catch ex As Exception
                Console.WriteLine("Error al crear el nuevo archivo: " & ex.Message)
                MsgBox("Error al generar el archivo de respaldo" + vbCrLf + ex.Message, vbOKOnly + vbCritical, "Error de generación")
            Finally
                ' Close the application
                accessApp.Quit()
                accessApp = Nothing
            End Try
        End If

        ' Copy the original database to the new file
        Try
            File.Copy(DBActual, respaldo, True)
            Console.WriteLine("Copia de seguridad creada exitosamente: " & respaldo)
            MsgBox("Archivo de respaldo de la base de datos generado correctamente", vbOK, "Respaldo generado")
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "importar"
    Friend Sub importarDB(respaldo As String)
        ' Copy the original database to the new file
        Try
            File.Copy(respaldo, DBActual, True)
            Console.WriteLine("Importación de la base de datos realizada correctamente: " & respaldo)
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
        End Try
    End Sub

    Friend Sub impDBCombinar(conexionStringRespaldo As String)
        Using connActual As New OleDbConnection(DBActual),
              connRespaldo As New OleDbConnection(conexionStringRespaldo)

            Try
                ' Abrir ambas conexiones
                connActual.Open()
                connRespaldo.Open()

                ' Leer datos de la base de datos de respaldo
                Dim cmdSelect As New OleDbCommand("SELECT * FROM productos", connRespaldo)
                Dim reader As OleDbDataReader = cmdSelect.ExecuteReader()

                'SE DEBE DE AGREGAR EL MISMO PROCESO CON CADA TABLA ASI COMO AGREGAR CADA UNON DE LOS CAMPOS DE ESTA


                ' Procesar cada registro
                While reader.Read()
                    ' Aquí debes ajustar las columnas según tu tabla
                    Dim id As Integer = reader("ID")
                    Dim nombre As String = reader("nombre")
                    ' ...otros campos...

                    ' Verificar si el registro ya existe en la base de datos actual
                    Dim cmdCheck As New OleDbCommand("SELECT COUNT(*) FROM productos WHERE ID = @ID", connActual)
                    cmdCheck.Parameters.AddWithValue("@ID", id)

                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

                    If count > 0 Then
                        ' Si existe, actualiza el registro
                        Dim cmdUpdate As New OleDbCommand("UPDATE productos SET nombre = @nombre WHERE ID = @ID", connActual)
                        cmdUpdate.Parameters.AddWithValue("@nombre", nombre)
                        cmdUpdate.Parameters.AddWithValue("@ID", id)
                        cmdUpdate.ExecuteNonQuery()
                    Else
                        ' Si no existe, inserta el registro
                        Dim cmdInsert As New OleDbCommand("INSERT INTO productos (ID, nombre) VALUES (@ID, @nombre)", connActual)
                        cmdInsert.Parameters.AddWithValue("@ID", id)
                        cmdInsert.Parameters.AddWithValue("@nombre", nombre)
                        cmdInsert.ExecuteNonQuery()
                    End If
                End While
                reader.Close()

                Console.WriteLine("Datos importados exitosamente.")
            Catch ex As Exception
                Console.WriteLine("Error al importar datos: " & ex.Message)
            End Try
        End Using
    End Sub
#End Region


    Friend Sub cambiarDB()
        modConexionString("")
    End Sub
End Module
