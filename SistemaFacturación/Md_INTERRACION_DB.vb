Imports System.Configuration
Imports System.Data.OleDb

Module Md_INTERRACION_DB
    'Usar nada más este a la hora de ejecutar SELECT en la base de datos
    Friend Sub Cargar_Tabla(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        Try
            ' Obtener la cadena de conexión desde app.config
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("DbConnectionString").ConnectionString
            ' Usar Using para asegurar que la conexión se cierre correctamente
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Using consulta As New OleDbCommand(Sql, connection)
                    Using da As New OleDbDataAdapter(consulta)
                        da.Fill(Tabla_Temporal)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al cargar la tabla desde la base de datos" & vbCrLf & ex.Message, vbOKOnly, "Error")
        End Try
    End Sub


    'Usar este cuando se utiliza cualquier otro tipo se instrucción en el query que no sea SELECT
    Friend Function EJECUTAR(ByVal Sql As String) As Boolean
        Try
            CONECTAR()
            Dim comando As New OleDb.OleDbCommand(Sql, Db)
            comando.ExecuteNonQuery()
            DESCONECTAR()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Error al ejecutar la consulta desde la base de datos" & vbCrLf & ex.Message, vbOKOnly, "Error")
            DESCONECTAR()
            Return False
        End Try
    End Function
End Module
