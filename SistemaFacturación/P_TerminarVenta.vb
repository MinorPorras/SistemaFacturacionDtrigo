Imports System.Drawing.Printing

Public Class P_TerminarVenta
    Dim idFactura As Integer
    Friend total As Double
    Private vuelto As Double
    Private TipoPago As Integer
    Friend NumFactura As String
    Friend idCLiente As Integer

    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As List(Of String) = New List(Of String)()
    Friend finFactura As String
    Private Sub P_TerminarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idFactura = OBTENERPK("factura", "ID")
    End Sub

    Private Sub TXT_ECliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_ECliente.TextChanged
        calcVuelto(TXT_ECliente, TXT_EVuelto)
        VALIDAR(TXT_ECliente, TXT_ECliente, total, False)
    End Sub

    Private Sub TXT_TCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_TCliente.TextChanged
        calcVuelto(TXT_TCliente, TXT_TVuelto)
        VALIDAR(TXT_TCliente, TXT_TCliente, total, False)
    End Sub
    Private Sub TXT_SCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_SCliente.TextChanged
        calcVuelto(TXT_SCliente, TXT_SVuelto)
        VALIDAR(TXT_SCliente, TXT_SCliente, total, False)

    End Sub

    Private Sub TXT_DCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_DCliente.TextChanged
        calcVuelto(TXT_DCliente, TXT_DVuelto)
        VALIDAR(TXT_DCliente, TXT_DCliente, total, False)

    End Sub

    Private Sub TXT_PagoTarjeta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PagoTarjeta.TextChanged
        'Se pone cualquier textbox debido a que el calculo en este caso se hace solo
        calcVuelto(TXT_DCliente, TXT_MVuelto)
        VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)

    End Sub

    Private Sub TXT_PagoEfectivo_TextChanged(sender As Object, e As EventArgs) Handles TXT_PagoEfectivo.TextChanged
        'Se pone cualquier textbox debido a que el calculo en este caso se hace solo
        calcVuelto(TXT_DCliente, TXT_MVuelto)
        VALIDAR(TXT_PagoTarjeta, TXT_PagoEfectivo, total, True)

    End Sub

    Private Sub calcVuelto(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
        Dim eCliente As Double
        Dim eCliente2 As Double
        If Not TabControlTVenta.SelectedIndex = 4 Then
            If Double.TryParse(txtEntregaCliente.Text, eCliente) Then
                vuelto = eCliente - total
                If vuelto > 0 Then
                    txtVuelto.Text = vuelto.ToString()
                Else
                    txtVuelto.Text = "0"
                End If
            End If
        Else
            If Double.TryParse(TXT_PagoTarjeta.Text, eCliente) AndAlso Double.TryParse(TXT_PagoEfectivo.Text, eCliente2) Then
                Dim EntregaCliente As Double = eCliente + eCliente2
                vuelto = EntregaCliente - total
                If vuelto > 0 Then
                    txtVuelto.Text = vuelto.ToString()
                Else
                    txtVuelto.Text = "0"
                End If
            End If
        End If
    End Sub

    Private Sub VALIDAR(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente2 As Guna.UI2.WinForms.Guna2TextBox, Total As Double, mixto As Boolean)
        Try
            If String.IsNullOrEmpty(txtEntregaCliente.Text) Then
                txtEntregaCliente.Text = 0
            End If
            If mixto Then 'Si es mixto el pago

                If String.IsNullOrEmpty(txtEntregaCliente2.Text) Then
                    txtEntregaCliente2.Text = 0
                End If

                If Convert.ToDouble(txtEntregaCliente.Text) + Convert.ToDouble(txtEntregaCliente2.Text) >= Total Then
                    BTN_TVenta.Enabled = True
                Else
                    BTN_TVenta.Enabled = False
                End If
            Else

                If Convert.ToDouble(txtEntregaCliente.Text) >= Total Then
                    BTN_TVenta.Enabled = True
                Else
                    BTN_TVenta.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        TipoPago = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 'Efectivo
                guardarFactura(TXT_ETotal, TXT_ECliente, TXT_EVuelto)
            Case 1 'Tarjeta
                guardarFactura(TXT_TTotal, TXT_TCliente, TXT_TVuelto)
            Case 2 'Sinpe
                guardarFactura(TXT_STotal, TXT_SCliente, TXT_SVuelto)
            Case 3 'Depósito
                guardarFactura(TXT_DTotal, TXT_DCliente, TXT_DVuelto)
            Case 4 'Mixto
                guardarFactura(TXT_MTotal, TXT_ECliente, TXT_MVuelto)
        End Select
    End Sub

    Private Sub guardarFactura(txtTotal As Guna.UI2.WinForms.Guna2TextBox, txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox, txtVuelto As Guna.UI2.WinForms.Guna2TextBox)
        T.Tables.Clear()
        If MessageBox.Show("¿Desea terminar la venta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                If EXISTEPK("factura", "ID", idFactura) = False Then ' Si no se ha guardado la categoría
                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                    GUARDAR_PK("factura", "ID", idFactura)
                End If
                ' Actualizar los campos en la base de datos
                GUARDAR_TIMEACTUAL("factura", "fecha_emision", "ID", idFactura)
                GUARDAR_INT("factura", "ID_Cliente", idCLiente, "ID", idFactura)
                GUARDAR_INT("factura", "ID_Usuario", P_Caja.idUsu, "ID", idFactura)
                GUARDAR_STR("factura", "num_factura", NumFactura, "ID", idFactura)
                GUARDAR_DOUBLE("factura", "total", total, "ID", idFactura)
                Dim eCliente As Double
                If TipoPago = 4 Then
                    GUARDAR_DOUBLE("factura", "efectivo_cliente", Convert.ToDouble(TXT_PagoEfectivo.Text), "ID", idFactura)
                    GUARDAR_DOUBLE("factura", "tarjeta_cliente", Convert.ToDouble(TXT_PagoTarjeta.Text), "ID", idFactura)
                Else
                    eCliente = Convert.ToDouble(txtEntregaCliente.Text)
                    GUARDAR_DOUBLE("factura", "efectivo_cliente", eCliente, "ID", idFactura)
                    GUARDAR_DOUBLE("factura", "tarjeta_cliente", 0, "ID", idFactura)
                End If

                GUARDAR_DOUBLE("factura", "vuelto", vuelto, "ID", idFactura)
                GUARDAR_INT("factura", "tipo_venta", TipoPago, "ID", idFactura)
                GUARDAR_STR("factura", "cobrada", "Si", "ID", idFactura)
                For i As Integer = 0 To P_Caja.DGV_Caja.Rows.Count - 2
                    GUARDAR_VarCompInt4("factura_producto", idFactura, P_Caja.DGV_Caja.Rows(i).Cells(0).Value.ToString(), P_Caja.DGV_Caja.Rows(i).Cells(4).Value.ToString(), Convert.ToDouble(P_Caja.DGV_Caja.Rows(i).Cells(3).Value.ToString()))
                Next
                GUARDAR_VarCompuestas("factura_comentario", idFactura, TXT_Comentario.Text)

                If MessageBox.Show("Venta realizada con exito." + vbCrLf + "¿Desea imprimir la factura correspondiente?", "Venta existosa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    CREAR_FACTURA(idFactura, encabezadoFactura, facturaContenido, finFactura, False)
                    ImprimirFactura()

                    'crea el archivo y lo imprime, no muestra nada
                    MsgBox("Venta y factura completadas", vbOKOnly, "Buen Trabajo")
                End If

                P_Caja.LIMPIAR()
                P_Caja.cargarNumFactura()
                P_Caja.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If

    End Sub

    ' Manejar el evento PrintPage
    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Segoe UI", 9)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormat As New StringFormat() With {
        .Alignment = StringAlignment.Near,
        .LineAlignment = StringAlignment.Near
    }

        Dim totalWidth As Single = 72 * 3.78
        Dim cellWidth As Single = totalWidth / 4
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Dibujar el encabezado
        e.Graphics.DrawString(encabezadoFactura, font, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoFactura, font).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar el encabezado de la tabla de productos
        e.Graphics.DrawString(encabezadoProds, fontProds, brush, leftMargin, yPos, stringFormat)
        yPos += e.Graphics.MeasureString(encabezadoProds, fontProds).Height + 10 ' Espacio adicional después del encabezado

        ' Dibujar los productos
        For Each line As String In facturaContenido
            Dim columns() As String = line.Split(New Char() {"."c}, StringSplitOptions.RemoveEmptyEntries) ' Cambiar el delimitador si es necesario

            Dim maxHeight As Single = 0

            For colIndex As Integer = 0 To columns.Length - 1
                Dim rect As New RectangleF(leftMargin + (colIndex * cellWidth), yPos, cellWidth, 0)
                Dim size As SizeF = e.Graphics.MeasureString(columns(colIndex), fontProds, rect.Size, stringFormat)

                If size.Height > maxHeight Then
                    maxHeight = size.Height
                End If

                rect.Height = maxHeight
                e.Graphics.DrawString(columns(colIndex), fontProds, brush, rect, stringFormat)
            Next

            yPos += maxHeight + 5 ' Asegurar que el yPos se incremente para cada línea de productos
        Next

        yPos += 10 ' Espacio adicional después de los productos
        e.Graphics.DrawString(finFactura, font, brush, leftMargin, yPos, stringFormat)
    End Sub


    ' Método para iniciar la impresión
    Private Sub ImprimirFactura()
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf printDocument_PrintPage
        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = printDoc
        If PrintDialog.ShowDialog() = DialogResult.OK Then ' Si el usuario selecciona OK, procedemos a imprimir 
            printDoc.Print()
        End If
    End Sub


    Private Sub BTN_RegresarVenta_Click(sender As Object, e As EventArgs) Handles BTN_RegresarVenta.Click
        Me.Close()
    End Sub

    Private Sub TabControlTVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlTVenta.SelectedIndexChanged
        TipoPago = TabControlTVenta.SelectedIndex
        Select Case TipoPago
            Case 0 'Efectivo
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
            Case 1 'Tarjeta
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
            Case 2 'Sinpe
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
            Case 3 'Depósito
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Mixto
                TXT_PagoEfectivo.Text = "0"
                TXT_PagoTarjeta.Text = "0"
                TXT_MVuelto.Text = "0"
            Case 4 'Mixto
                'Efectivo
                TXT_EVuelto.Text = "0"
                TXT_ECliente.Text = "0"
                'Tarjeta
                TXT_TCliente.Text = "0"
                TXT_TVuelto.Text = "0"
                'Sinpe
                TXT_SCliente.Text = "0"
                TXT_SVuelto.Text = "0"
                'Depósito
                TXT_DCliente.Text = "0"
                TXT_DVuelto.Text = "0"
        End Select
    End Sub

    Private Sub BTN_EColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_EColocarTotal.Click
        colocarTotal(TXT_ECliente)
    End Sub

    Private Sub BTN_TColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_TColocarTotal.Click
        colocarTotal(TXT_TCliente)
    End Sub

    Private Sub BTN_SColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_SColocarTotal.Click
        colocarTotal(TXT_SCliente)
    End Sub
    Private Sub BTN_DColocarTotal_Click(sender As Object, e As EventArgs) Handles BTN_DColocarTotal.Click
        colocarTotal(TXT_DCliente)
    End Sub

    Private Sub colocarTotal(txtEntregaCliente As Guna.UI2.WinForms.Guna2TextBox)
        txtEntregaCliente.Text = total
    End Sub

    Private Function cargarRestante(efectivo As Boolean)
        If String.IsNullOrEmpty(TXT_PagoEfectivo.Text) Then
            TXT_PagoEfectivo.Text = 0
        End If
        If String.IsNullOrEmpty(TXT_PagoTarjeta.Text) Then
            TXT_PagoTarjeta.Text = 0
        End If
        Dim restante As Double
        Dim pEfectivo As Double = Convert.ToDouble(TXT_PagoEfectivo.Text)
        Dim pTarjeta As Double = Convert.ToDouble(TXT_PagoTarjeta.Text)
        If efectivo Then
            restante = total - pTarjeta
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        Else
            restante = total - pEfectivo
            If restante < 0 Then
                restante = 0
            End If
            Return restante
        End If

    End Function

    Private Sub BTN_RestanteTarjeta_Click(sender As Object, e As EventArgs) Handles BTN_RestanteTarjeta.Click
        TXT_PagoEfectivo.Text = cargarRestante(True)
        calcVuelto(TXT_DCliente, TXT_MVuelto)
    End Sub

    Private Sub BTN_RestanteEfectivo_Click(sender As Object, e As EventArgs) Handles BTN_RestanteEfectivo.Click
        TXT_PagoTarjeta.Text = cargarRestante(False)
        calcVuelto(TXT_DCliente, TXT_MVuelto)
    End Sub
End Class