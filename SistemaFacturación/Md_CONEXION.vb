Imports System.Configuration
Imports System.Data.OleDb
Module Md_CONEXION
    'Se crea el objeto de conexión
    Public conexionString As String = ConfigurationManager.ConnectionStrings("DbConnectionString").ConnectionString
    Public Db As New OleDbConnection(conexionString)
    'Se le envía la ruta del archivo .udl para que realicé la conexión
    Friend Sub CONECTAR()
        Try
            inicializarDB()
            Db.Open()
            Exit Sub
        Catch ex As Exception
            MsgBox("Error al conectarse a la base de datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    'Se desconecta de la base de datos
    Friend Sub DESCONECTAR()
        Try
            Db.Close()
        Catch ex As Exception
            MsgBox("Error al desconectarse a la base de datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub inicializarDB()
        Dim Db As New OleDbConnection(conexionString)
    End Sub

    Friend Sub modConexionString(rutaNueva As String)
        ' Modificar App.config para actualizar la cadena de conexión
        Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.ConnectionStrings.ConnectionStrings("DbConnectionString").ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaNueva
        config.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("connectionStrings")

        ' Actualizar la variable conexiónString
        conexionString = config.ConnectionStrings.ConnectionStrings("DbConnectionString").ConnectionString
    End Sub
End Module
