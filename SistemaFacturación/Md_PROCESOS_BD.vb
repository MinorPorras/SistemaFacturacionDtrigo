Imports System.Data.OleDb
Imports System.IO
Module Md_PROCESOS_BD
    'Se crea en primer lugar un registro en la BD con una llave primario encontrada por la función OBTENERPK
    Friend Sub GUARDAR_PK(ByVal TABLA As String, ByVal ATRIBUTO_PK As String, ByVal DATO_PK As Integer)
        Sql = "INSERT INTO " & TABLA & "(" & ATRIBUTO_PK & ") VALUES " & "(" & DATO_PK & ")"
        EJECUTAR(Sql)
    End Sub

    'Se guarda cada uno de ls valores por medio de las siguientes subs de guardar
    'Este primero es solo para guardar los objetos de tipo int
    Friend Sub GUARDAR_INT(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As Integer, ByVal PK As String, ByVal VALORPK As Integer)
        SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = (" & CONTENIDO & ") WHERE " & PK & " = " & VALORPK & ";"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    Friend Sub GUARDAR_DOUBLE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As String, ByVal PK As String, ByVal VALORPK As Integer)
        SQL = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = (" & CONTENIDO & ") WHERE " & PK & " = " & VALORPK & ";"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_INTNoPK(ByVal TABLA As String, ByVal CONTENIDO As Integer, ByVal CONTENIDO2 As Integer, ByVal CONTENIDO3 As Integer)
        Sql = "INSERT INTO " & TABLA & " VALUES " & "(" & CONTENIDO & ", " & CONTENIDO2 & ", " & CONTENIDO3 & ")"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    Friend Sub GUARDAR_VarCompuestas(ByVal TABLA As String, ByVal CONTENIDO As Integer, ByVal CONTENIDO2 As String)
        SQL = "INSERT INTO " & TABLA & " VALUES " & "(" & CONTENIDO & ", '" & CONTENIDO2 + "')"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_VarCompInt3(ByVal TABLA As String, ByVal CONTENIDO As Integer, ByVal CONTENIDO2 As String, ByVal CONTENIDO3 As String)
        SQL = "INSERT INTO " & TABLA & " VALUES " & "(" & CONTENIDO & ", " & CONTENIDO2 & ", " & CONTENIDO3 & ")"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(SQL)
    End Sub

    Friend Sub GUARDAR_VarComp2Int(ByVal TABLA As String, ByVal CONTENIDO As Integer, ByVal CONTENIDO2 As Integer)
        CONTENIDO = Convert.ToInt32(CONTENIDO)
        CONTENIDO2 = Convert.ToInt32(CONTENIDO2)
        SQL = "INSERT INTO " & TABLA & " VALUES " & "( " & CONTENIDO & ", " & CONTENIDO2 & " )"
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(SQL)
    End Sub

    'Guarda objetos de tipo string
    Friend Sub GUARDAR_STR(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As String, ByVal PK As String, ByVal VALORPK As Integer)
        Sql = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & CONTENIDO & "' WHERE " & PK & " = " & VALORPK
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    'Guarda objetos de tipo fecha (Date)
    Friend Sub GUARDAR_DATE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As Date, ByVal PK As String, ByVal VALORPK As Integer)
        Sql = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & Format(CONTENIDO, "yyyy/MM/dd") & "' WHERE " & PK & " = " & VALORPK
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    'Guarda objetos de tipo Hora (Time(7))
    Friend Sub GUARDAR_TIME(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As TimeSpan, ByVal PK As String, ByVal VALORPK As Integer)
        ' Convertir TimeSpan a String con formato HH:mm:ss.fffffff para TIME(7)
        Dim contenidoStr As String = CONTENIDO.ToString("hh\:mm\:ss")

        ' Crear la consulta SQL
        Sql = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = #" & contenidoStr & "# WHERE " & PK & " = " & VALORPK

        ' Actualiza en la tabla que se envió, en el atributo que se envió,
        ' el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    Friend Sub GUARDAR_TIMEACTUAL(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal PK As String, ByVal VALORPK As Integer)
        Sql = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = NOW() WHERE " & PK & " = " & VALORPK
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    Friend Sub GUARDAR_BYTE(ByVal TABLA As String, ByVal ATRIBUTOS As String, ByVal CONTENIDO As String, ByVal PK As String, ByVal VALORPK As Integer)
        Dim imageBytes As Byte() = File.ReadAllBytes(CONTENIDO)
        Dim ImagenString As String = System.Text.Encoding.Default.GetString(imageBytes)
        Sql = "UPDATE " & TABLA & " SET " & ATRIBUTOS & " = '" & ImagenString & "' WHERE " & PK & " = " & VALORPK
        'Actualiza en la tabla que se envió, en el atributo que se envió,
        'el contenido dado donde la PK sea igual que la que se mandó
        EJECUTAR(Sql)
    End Sub

    'Elimina un registro de la base de datos
    Friend Sub ELIMINAR(ByVal TABLA As String, ByVal PK As String, ByVal VALORPK As Integer)
        Sql = "DELETE FROM " & TABLA & " WHERE " & PK & " = " & VALORPK
        EJECUTAR(Sql)
    End Sub

    'Obtiene la Llave primaria más alta de la tabla
    Friend Function OBTENERPK(ByVal TABLA As String, ByVal PK As String) As Integer
        Try
            If EXISTE(TABLA, PK) = True Then
                T.Tables.Clear()
                Sql = "SELECT MAX (" & PK & ") FROM " & TABLA
                Cargar_Tabla(T, Sql)
                OBTENERPK = T.Tables(0).Rows(0).ItemArray(0) + 1
            Else
                OBTENERPK = 1
            End If
        Catch ex As Exception
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try

    End Function

    'Se fija si la PK existe ya en la tabla
    Friend Function EXISTE(ByVal TABLA As String, ByVal PK As String) As Boolean
        T.Tables.Clear()
        Sql = "SELECT " & PK & " From " & TABLA
        Cargar_Tabla(T, Sql)
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
            Sql = "SELECT " & PK & " From " & TABLA & " Where " & PK & " = " & DATO_PK
            Cargar_Tabla(T, Sql)
            If T.Tables(0).Rows.Count > 0 Then
                EXISTEPK = True
            Else
                EXISTEPK = False
            End If
        Catch ex As Exception
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
            MsgBox("Error al cargar los datos desde la base de datos" & vbCrLf & ex.ToString(), vbOKOnly, "Error")
        End Try

    End Function
End Module
