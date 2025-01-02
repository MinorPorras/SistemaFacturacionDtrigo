
Module Md_PROCESOS_BD
    Friend Sub GUARDAR_PK(ByVal tabla As String, ByVal atributoPK As String, ByVal datoPK As Integer)
        SQL = "INSERT INTO " & tabla & "(" & atributoPK & ") VALUES (" & datoPK & ")"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_INT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Integer, ByVal PK As String, ByVal valorPK As Integer)
        SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_TEXT(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
        SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
        EJECUTAR(SQL)
    End Sub
    Friend Sub GUARDAR_VarCompInt4(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Integer, ByVal value2 As Integer, ByVal value3 As Integer)
        SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ", " & value2 & ", " & value3 & ")"
        EJECUTAR(SQL)
    End Sub
    Friend Sub GUARDAR_VarCompuestas(ByVal tabla As String, ByVal PK As Integer, ByVal value As String)
        SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", '" & value & "')"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_VarCompuestasInt(ByVal tabla As String, ByVal PK As Integer, ByVal value As Integer)
        SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value & ")"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_VarCompNumeric(ByVal tabla As String, ByVal PK As Integer, ByVal value1 As Double)
        SQL = "INSERT INTO " & tabla & " VALUES (" & PK & ", " & value1 & ")"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_BLOB(ByVal tabla As String, ByVal atributos As String, ByVal contenido As String, ByVal PK As String, ByVal valorPK As Integer)
        SQL = "UPDATE " & tabla & " SET " & atributos & " = ('" & contenido & "') WHERE " & PK & " = " & valorPK & ";"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_NUMERIC(ByVal tabla As String, ByVal atributos As String, ByVal contenido As Double, ByVal PK As String, ByVal valorPK As Integer)
        SQL = "UPDATE " & tabla & " SET " & atributos & " = ( " & contenido & ") WHERE " & PK & " = " & valorPK & ";"
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_DATE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As Date, ByVal PK As String, ByVal VALORPK As Integer)
        ' Convertir la fecha a un formato estándar de SQLite (yyyy-MM-dd)
        Dim contenidoStr As String = Format(CONTENIDO, "yyyy-MM-dd")
        SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
        EJECUTAR(SQL)
    End Sub

    'Guarda objetos de tipo Hora (Time(7))
    Friend Sub GUARDAR_TIME(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As TimeSpan, ByVal PK As String, ByVal VALORPK As Integer)
        ' Convertir TimeSpan a String con formato HH:mm:ss para TIME
        Dim contenidoStr As String = CONTENIDO.ToString("hh\:mm\:ss")
        SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & contenidoStr & "' WHERE " & PK & " = " & VALORPK
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_TIMEACTUAL(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal PK As String, ByVal VALORPK As Integer)
        SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = datetime('now', 'localtime') WHERE " & PK & " = " & VALORPK
        EJECUTAR(SQL)
    End Sub

    'Elimina un registro de la base de datos
    Friend Sub ELIMINAR(ByVal TABLA As String, ByVal PK As String, ByVal VALORPK As Integer)
        SQL = "DELETE FROM " & TABLA & " WHERE " & PK & " = " & VALORPK
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_FACT(ByVal TABLA As String, ByVal DATOS As String)
        SQL = "INSERT INTO " & TABLA & " VALUES (" & DATOS & ")"
        EJECUTAR(SQL)
    End Sub

    Friend Function OBTENERPK(ByVal TABLA As String, ByVal PK As String) As Integer
        Try
            If EXISTE(TABLA, PK) = True Then
                T.Clear()
                SQL = "SELECT MAX(" & PK & ") FROM " & TABLA
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(T.Tables(0).Rows(0).Item(1)) Then
                    OBTENERPK = T.Tables(0).Rows(0).Item(1) + 1
                Else
                    OBTENERPK = 1
                End If
            Else
                OBTENERPK = 1
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
            OBTENERPK = 1
        End Try
    End Function


    'Se fija si la PK existe ya en la tabla
    Friend Function EXISTE(ByVal TABLA As String, ByVal PK As String) As Boolean
        T.Tables.Clear()
        SQL = "SELECT " & PK & " From " & TABLA
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            EXISTE = True
        Else
            EXISTE = False
        End If
    End Function

    'Se fija si la alguna PK igual que la que se mandó está en la tabla
    Friend Function EXISTEPK(ByVal TABLA As String, ByVal PK As String, ByVal DATO_PK As Integer) As Boolean
        Try
            T.Tables.Clear()
            SQL = "SELECT " & PK & " From " & TABLA & " Where " & PK & " = " & DATO_PK
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                EXISTEPK = True
            Else
                EXISTEPK = False
            End If
        Catch ex As Exception
            EXISTEPK = False
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Function

    Friend Function EXISTECOD(ByVal TABLA As String, ByVal cod As String, ByVal DATO As String) As Boolean
        Try
            T.Tables.Clear()
            SQL = "SELECT " & cod & " From " & TABLA & " WHERE " & cod & " = '" & DATO & "'"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                EXISTECOD = True
            Else
                EXISTECOD = False
            End If
        Catch ex As Exception
            EXISTECOD = False
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try
    End Function

    Friend Function Validar_Contenido_Tabla(ByVal TABLA As String) As Boolean
        Try
            T.Tables.Clear()
            Sql = "SELECT * FROM " & TABLA
            Cargar_Tabla(T, Sql)
            If T.Tables(0).Rows.Count > 0 Then
                Validar_Contenido_Tabla = True
            Else
                Validar_Contenido_Tabla = False
            End If
        Catch ex As Exception
            Validar_Contenido_Tabla = False
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try

    End Function

    Public Function ObtenerCodigosExistentes(tabla As String, atributo As String) As List(Of Integer)
        T.Tables.Clear()
        Dim codigos As New List(Of Integer)
        SQL = "SELECT " & atributo & " FROM " & tabla
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                Dim codigo As Integer
                If Integer.TryParse(T.Tables(0).Rows(i).Item(0).ToString(), codigo) Then
                    codigos.Add(codigo)
                End If
            Next
            Return codigos
        Else
            codigos.Add(1)
            Return codigos
        End If
    End Function
End Module
