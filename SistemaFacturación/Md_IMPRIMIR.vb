﻿Module Md_IMPRIMIR
    Dim sucursal As String
    Dim numFact As String
    Dim nomCajero As String
    Dim ced_juridica As String
    Dim direccion As String
    Dim telefono As String
    Dim email As String
    Dim fecha As String
    Dim cliente As String
    Dim comentario As String
    Dim total As String
    Dim eCliente As String
    Dim tCliente As String
    Dim vuelto As String
    Dim tventa As String

    Public Sub CREAR_FACTURA(id_factura As Integer, reimprimir As Boolean)


        T.Tables.Clear()
        SQL = "SELECT f.ID, f.fecha_emision, c.nombre, f.num_factura, f.total, f.efectivo_cliente, f.tarjeta_cliente, f.vuelto, f.tipo_venta, u.usuario" &
            " FROM (factura f LEFT JOIN clientes c ON c.ID =f.ID_Cliente) LEFT JOIN usuario u ON u.ID = f.ID_Usuario WHERE f.ID = " & id_factura
        Cargar_Tabla(T, SQL)
        fecha = If(IsDBNull(T.Tables(0).Rows(0).Item(1)), " ", T.Tables(0).Rows(0).Item(1))
        cliente = If(IsDBNull(T.Tables(0).Rows(0).Item(2)), " ", T.Tables(0).Rows(0).Item(2))
        numFact = If(IsDBNull(T.Tables(0).Rows(0).Item(3)), " ", CInt(T.Tables(0).Rows(0).Item(3)).ToString("D15"))
        total = If(IsDBNull(T.Tables(0).Rows(0).Item(4)), " ", T.Tables(0).Rows(0).Item(4))
        eCliente = If(IsDBNull(T.Tables(0).Rows(0).Item(5)), " ", T.Tables(0).Rows(0).Item(5))
        tCliente = If(IsDBNull(T.Tables(0).Rows(0).Item(6)), " ", T.Tables(0).Rows(0).Item(6))
        vuelto = If(IsDBNull(T.Tables(0).Rows(0).Item(7)), " ", T.Tables(0).Rows(0).Item(7))
        tventa = If(IsDBNull(T.Tables(0).Rows(0).Item(8)), " ", T.Tables(0).Rows(0).Item(8))
        Dim strVenta As String
        Select Case tventa
            Case 0
                strVenta = "Efectivo"
            Case 1
                strVenta = "Tarjeta"
            Case 2
                strVenta = "Sinpe"
            Case 3
                strVenta = "Depósito"
            Case 4
                strVenta = "Mixto"
            Case Else
                strVenta = "Efectivo"
        End Select
        nomCajero = If(IsDBNull(T.Tables(0).Rows(0).Item(9)), " ", T.Tables(0).Rows(0).Item(9))


        T1.Tables.Clear()
        SQL = "SELECT comentario FROM factura_comentario WHERE ID_Factura = " & id_factura
        Cargar_Tabla(T1, SQL)
        If T1.Tables(0).Rows.Count > 0 Then
            comentario = If(IsDBNull(T1.Tables(0).Rows(0).Item(0)), " ", T1.Tables(0).Rows(0).Item(0))
        End If


        T2.Tables.Clear()
        SQL = "SELECT nombre, direccion, ced_juridica, telefono, email FROM sucursal"
        Cargar_Tabla(T2, SQL)
        sucursal = If(IsDBNull(T2.Tables(0).Rows(0).Item(0)), " ", T2.Tables(0).Rows(0).Item(0))
        direccion = If(IsDBNull(T2.Tables(0).Rows(0).Item(1)), " ", T2.Tables(0).Rows(0).Item(1))
        ced_juridica = If(IsDBNull(T2.Tables(0).Rows(0).Item(2)), " ", T2.Tables(0).Rows(0).Item(2))
        telefono = If(IsDBNull(T2.Tables(0).Rows(0).Item(3)), " ", T2.Tables(0).Rows(0).Item(3))
        email = If(IsDBNull(T2.Tables(0).Rows(0).Item(4)), " ", T2.Tables(0).Rows(0).Item(4))

        Dim direccionsplit() As String = direccion.Split(","c)
        direccion = ""
        For i As Integer = 0 To direccionsplit.Length - 1
            If i <> 1 Then
                direccion = direccion & direccionsplit(i) & ","
            Else
                direccion = direccion & vbCrLf & direccionsplit(i)
            End If
        Next

        If Not reimprimir Then
            ' Definir el contenido de la factura
            P_TerminarVenta.encabezadoFactura = "-------------------------------------------" & vbCrLf &
                                "        FACTURA DE VENTA" & vbCrLf & vbCrLf &
                                "------------ " & sucursal & " -------------" & vbCrLf & vbCrLf &
                                "Nº de Factura: " & numFact & vbCrLf &
                                "Cajero: " & nomCajero & vbCrLf &
                                "Ced. Jurídica:" & ced_juridica & vbCrLf &
                                "Dirección:" & direccion & vbCrLf &
                                "Teléfono: " & telefono & vbCrLf &
                                "Email: " & email & vbCrLf &
                                "Fecha: " & fecha & vbCrLf &
                                vbCrLf &
                                "Cliente:" & cliente & vbCrLf &
                                vbCrLf &
                                "-------------------------------------------" & vbCrLf &
                                "Descripción de Productos" & vbCrLf &
                                "-------------------------------------------" & vbCrLf
            P_TerminarVenta.encabezadoProds = "Cant     Descripción        Precio       Total" & vbCrLf &
                                                     "--------------------------------------------------" & vbCrLf
            cargarProds(id_factura, reimprimir)

            P_TerminarVenta.finFactura = "-------------------------------------------" & vbCrLf &
                      "Total de la venta: ₡ " & total & vbCrLf &
                      vbCrLf
            If tventa <> 4 Then
                P_TerminarVenta.finFactura += "Pago del cliente: ₡ " & eCliente & vbCrLf &
                      vbCrLf &
                      "Vuelto: ₡ " & vuelto & vbCrLf &
                      vbCrLf &
                      "Tipo de pago: " & strVenta & vbCrLf &
                      vbCrLf &
                      "Comentario: " & comentario & vbCrLf & " " & vbCrLf &
                      "-------------------------------------------" & vbCrLf

            Else
                P_TerminarVenta.finFactura += "Pago en efectivo: ₡ " & eCliente & vbCrLf &
                    vbCrLf &
                     "Pago en tarjeta: ₡ " & tCliente & vbCrLf &
                      vbCrLf &
                      "Vuelto: ₡ " & vuelto & vbCrLf &
                      vbCrLf &
                      "Tipo de pago: " & strVenta & vbCrLf &
                      vbCrLf &
                      "Comentario: " & comentario & vbCrLf & " " & vbCrLf &
                      "-------------------------------------------" & vbCrLf
            End If
        Else
            ' Definir el contenido de la factura
            P_ReimprimirFact.encabezadoFactura = "-------------------------------------------" & vbCrLf &
                                "        FACTURA DE VENTA" & vbCrLf & vbCrLf &
                                "------------ " & sucursal & " -------------" & vbCrLf & vbCrLf &
                                "Nº de Factura: " & numFact & vbCrLf &
                                "Cajero: " & nomCajero & vbCrLf &
                                "Ced. Jurídica:" & ced_juridica & vbCrLf &
                                "Dirección:" & direccion & vbCrLf &
                                "Teléfono: " & telefono & vbCrLf &
                                "Email: " & email & vbCrLf &
                                "Fecha: " & fecha & vbCrLf &
                                vbCrLf &
                                "Cliente:" & cliente & vbCrLf &
                                vbCrLf &
                                "-------------------------------------------" & vbCrLf &
                                "Descripción de Productos" & vbCrLf &
                                "-------------------------------------------" & vbCrLf
            P_ReimprimirFact.encabezadoProds = "Cant  Descripción            Precio       Total" & vbCrLf &
                                                     "--------------------------------------------------" & vbCrLf
            cargarProds(id_factura, reimprimir)

            P_ReimprimirFact.finFactura = "-------------------------------------------" & vbCrLf &
                      "Total de la venta: ₡ " & total & vbCrLf &
                      vbCrLf

            If tventa <> 4 Then
                P_ReimprimirFact.finFactura += "Pago del cliente: ₡ " & eCliente & vbCrLf &
                      vbCrLf &
                      "Vuelto: ₡ " & vuelto & vbCrLf &
                      vbCrLf &
                      "Tipo de pago: " & strVenta & vbCrLf &
                      vbCrLf &
                      "Comentario: " & comentario & vbCrLf & " " & vbCrLf &
                      "-------------------------------------------" & vbCrLf

            Else
                P_ReimprimirFact.finFactura += "Pago en efectivo: ₡ " & eCliente & vbCrLf &
                     "Pago en tarjeta: ₡ " & tCliente & vbCrLf &
                      vbCrLf &
                      "Vuelto: ₡ " & vuelto & vbCrLf &
                      vbCrLf &
                      "Tipo de pago: " & strVenta & vbCrLf &
                      vbCrLf &
                      "Comentario: " & comentario & vbCrLf & " " & vbCrLf &
                      "-------------------------------------------" & vbCrLf
            End If
        End If

        comentario = String.Empty
    End Sub

    Private Sub CargarProds(idfact As Integer, reimprimir As Boolean)
        T.Tables.Clear()
        SQL = "SELECT f.cant, p.nombre, f.precio_venta FROM ((factura_producto f LEFT JOIN producto p ON p.ID = f.ID_Producto)" &
            " LEFT JOIN Producto_precioVenta v ON p.ID = v.ID_Producto) WHERE ID_Factura = " & idfact
        Cargar_Tabla(T, SQL)
        Dim prods As String
        If T.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                prods = T.Tables(0).Rows(i).Item(0) & "." &
                                  T.Tables(0).Rows(i).Item(1) & "." &
                                  T.Tables(0).Rows(i).Item(2) & "." &
                                  Convert.ToDouble(T.Tables(0).Rows(i).Item(0)) * Convert.ToDouble(T.Tables(0).Rows(i).Item(2)) & vbCrLf
                If Not reimprimir Then
                    P_TerminarVenta.facturaContenido.Add(prods)
                Else
                    P_ReimprimirFact.facturaContenido.Add(prods)
                End If
            Next
        End If
    End Sub
End Module
