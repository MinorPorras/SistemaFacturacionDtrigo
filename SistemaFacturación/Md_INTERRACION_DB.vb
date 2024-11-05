Imports System.Data.OleDb

Module Md_INTERRACION_DB
    'Usar nada más este a la hora de ejecutar SELECT en la base de datos
    Friend Sub Cargar_Tabla(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        Try
            CONECTAR()
            Dim consulta As New OleDbCommand(Sql, Db)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = consulta
            da.Fill(Tabla_Temporal)
            DESCONECTAR()
        Catch ex As Exception
            MsgBox("Error al cargar la tabla desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            DESCONECTAR()
        End Try
    End Sub


    'Usar este cuando se utiliza cualquier otro tipo se instrucción en el query que no sea SELECT
    Friend Sub EJECUTAR(ByVal Sql As String)
        Try
            CONECTAR()
            Dim comando As New OleDb.OleDbCommand(Sql, Db)
            comando.ExecuteNonQuery()
            DESCONECTAR()
        Catch ex As Exception
            MsgBox("Error al ejecutar la consulta desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            DESCONECTAR()
        End Try
    End Sub
End Module
