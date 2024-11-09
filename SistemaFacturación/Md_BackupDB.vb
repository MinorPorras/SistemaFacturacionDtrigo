Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop.Access
Imports System.Configuration

Module Md_BackupDB
    Dim DBActual As String
#Region "exportar"
    Friend Sub exportarDB()
        ' Define the paths
        Dim fechaActual As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim backupDir As String = ConfigurationManager.AppSettings("DirectorioRespaldo") & "RespaldosSF"
        Dim respaldo As String = System.IO.Path.Combine(backupDir, "DBSistemaFact_" & fechaActual & ".accdb")

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
            DBActual = ObtenerConnectionString("DbConnectionString")
            File.Copy(DBActual, respaldo, True)
            Console.WriteLine("Copia de seguridad creada exitosamente: " & respaldo)
            MsgBox("Archivo de respaldo de la base de datos generado correctamente en la ruta: " & vbCrLf & vbCrLf & respaldo, vbOK, "Respaldo generado")
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
        End Try
    End Sub
#End Region

#Region "importar"
    Friend Sub importarDB(respaldo As String)
        ' Copy the original database to the new file
        Try
            DBActual = ObtenerConnectionString("DbConnectionString")
            File.Copy(respaldo, DBActual, True)
            Console.WriteLine("Importación de la base de datos realizada correctamente: " & respaldo)
        Catch ex As Exception
            Console.WriteLine("Error al crear la copia de seguridad: " & ex.Message)
        End Try
    End Sub

#End Region
End Module
