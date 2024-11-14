Imports System.Drawing.Printing

Public Class P_ReimprimirFact
    Friend encabezadoFactura As String
    Friend encabezadoProds As String
    Friend facturaContenido As List(Of String) = New List(Of String)()
    Friend finFactura As String
    Private Sub P_ReimprimirFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        Try
            LSV_Factura.Items.Clear()
            MNU_REIMPRIMIR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarFact.Text <> "" Then
                SQL = "SELECT f.ID, f.num_factura, f.fecha_emision, c.nombre, u.usuario, fc.comentario, f.total, f.entrega_cliente, f.vuelto, f.tipo_venta, f.cobrada " &
                    " FROM (((factura f LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE) " &
                    " LEFT JOIN usuario u ON u.ID = f.ID_USUARIO) " &
                    " LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID) where f.num_factura LIKE '%" & TXT_BuscarFact.Text & "%' ORDER BY Val(f.num_factura) DESC;"
            Else
                SQL = "SELECT f.ID, f.num_factura, f.fecha_emision, c.nombre, u.usuario, fc.comentario, f.total, f.entrega_cliente, f.vuelto, f.tipo_venta, f.cobrada " &
                    " FROM (((factura f LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE) " &
                    " LEFT JOIN usuario u ON u.ID = f.ID_USUARIO) " &
                    " LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID) ORDER BY Val(f.num_factura) DESC;"

            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item(0).ToString())
                    For j As Integer = 1 To 10
                        Select Case j
                            Case 1
                                Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), " ", CInt(T.Tables(0).Rows(i).Item(j)).ToString("D15"))
                                item.SubItems.Add(subItem)
                            Case 9
                                Dim tipoVenta As Integer = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), 1, Convert.ToInt32(T.Tables(0).Rows(i).Item(j)))
                                Dim strVenta As String
                                Select Case tipoVenta
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
                                item.SubItems.Add(strVenta)
                            Case Else
                                Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                                item.SubItems.Add(subItem)
                        End Select
                    Next
                    LSV_Factura.Items.Add(item)
                Next
                MNU_REIMPRIMIR.Visible = True
            End If
            LSV_Factura.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Factura.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Factura.Columns(0).Width = 0
            TXT_BuscarFact.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de facturas: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_ImpReciente_Click(sender As Object, e As EventArgs) Handles BTN_ImpReciente.Click
        encabezadoFactura = ""
        For i As Integer = facturaContenido.Count - 1 To 0 Step -1
            facturaContenido.RemoveAt(i)
        Next

        finFactura = ""
        T.Tables.Clear()
        SQL = "SELECT TOP 1 num_factura FROM factura ORDER BY Val(num_factura) DESC;"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count() > 0 Then
            Dim idFact As String = T.Tables(0).Rows(0).Item(0).ToString()
            CREAR_FACTURA(idFact, encabezadoFactura, facturaContenido, finFactura, True)
            ImprimirFactura()
        End If
    End Sub

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
        printDoc.Print()

    End Sub

    Private Sub BTN_RegresarFact_Click(sender As Object, e As EventArgs) Handles BTN_RegresarFact.Click
        P_Caja.Show()
        Me.Close()
    End Sub

    Private Sub MNU_REIMPRIMIR_Click(sender As Object, e As EventArgs) Handles MNU_REIMPRIMIR.Click
        encabezadoFactura = ""
        For Each line As Integer In facturaContenido
            facturaContenido.Remove(line)
        Next

        finFactura = ""
        CREAR_FACTURA(LSV_Factura.SelectedItems(0).SubItems(0).Text, encabezadoFactura, facturaContenido, finFactura, True)
        ImprimirFactura()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub TXT_BuscarFact_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarFact.TextChanged
        REFRESCAR()
    End Sub
End Class