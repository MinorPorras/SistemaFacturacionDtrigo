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
            MNU_REIMPRIMIR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarFact.Text <> "" Then
                SQL = "SELECT f.ID, f.num_factura as [Num factura], f.fecha_emision as [Fecha de emisión], c.nombre as [Cliente], u.usuario as [Cajero], fc.comentario as [Comentario]" &
                    ", f.total as [Total], f.entrega_cliente as [Pago cliente], f.vuelto as [Vuelto], " &
                      "IIf(f.tipo_venta=0, 'Efectivo', IIf(f.tipo_venta=1, 'Tarjeta', IIf(f.tipo_venta=2, 'Sinpe', IIf(f.tipo_venta=3, 'Depósito', IIf(f.tipo_venta=4, 'Mixto'," &
                      " 'Efectivo'))))) AS [Tipo venta], f.cobrada as [Cobrada] " &
                      "FROM (((factura f LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE) " &
                      "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO) " &
                      "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID) where f.num_factura Like '%" & TXT_BuscarFact.Text & "%' ORDER BY Val(f.num_factura) DESC;"
            Else
                SQL = "SELECT f.ID, f.num_factura as [Num factura], f.fecha_emision as [Fecha de emisión], c.nombre as [Nombre], u.usuario as [Cajero], fc.comentario as [Comentario]" &
                    ", f.total as [Total], f.entrega_cliente as [Pago cliente], f.vuelto as [Vuelto], " &
                      "IIf(f.tipo_venta=0, 'Efectivo', IIf(f.tipo_venta=1, 'Tarjeta', IIf(f.tipo_venta=2, 'Sinpe', IIf(f.tipo_venta=3, 'Depósito', IIf(f.tipo_venta=4, 'Mixto'," &
                      " 'Efectivo'))))) AS [Tipo venta], f.cobrada as [Cobrada] " &
                      "FROM (((factura f LEFT JOIN clientes c ON c.ID = f.ID_CLIENTE) " &
                      "LEFT JOIN usuario u ON u.ID = f.ID_USUARIO) " &
                      "LEFT JOIN factura_comentario fc ON fc.ID_Factura = f.ID) ORDER BY Val(f.num_factura) DESC;"

            End If
            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_ReimprimirFact.DataSource = bin
            If T.Tables(0).Rows.Count > 0 Then
                MNU_REIMPRIMIR.Visible = True
            End If
            TXT_BuscarFact.Select()
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_ReimprimirFact.DataBindingComplete, AddressOf DGV_ReimprimirFact_DataBindingComplete
            TXT_BuscarFact.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de facturas: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub DGV_ReimprimirFact_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_ReimprimirFact.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_ReimprimirFact.Columns.Count - 1
                DGV_ReimprimirFact.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_ReimprimirFact.Columns(i).Width = 60
                    Case 2
                        DGV_ReimprimirFact.Columns(i).Width = 60
                    Case 3
                        DGV_ReimprimirFact.Columns(i).Width = 70
                    Case 4
                        DGV_ReimprimirFact.Columns(i).Width = 70
                    Case 5
                        DGV_ReimprimirFact.Columns(i).Width = 100
                    Case 6
                        DGV_ReimprimirFact.Columns(i).Width = 40
                    Case 7
                        DGV_ReimprimirFact.Columns(i).Width = 40
                    Case 8
                        DGV_ReimprimirFact.Columns(i).Width = 30
                    Case 9
                        DGV_ReimprimirFact.Columns(i).Width = 40
                    Case 10
                        DGV_ReimprimirFact.Columns(i).Width = 50
                End Select
            Next

            ' Formatear los números en la columna 1 a un número de 15 dígitos
            For Each row As DataGridViewRow In DGV_ReimprimirFact.Rows
                If row.Cells(1).Value IsNot Nothing Then
                    Dim originalValue As Integer = Convert.ToInt32(row.Cells(1).Value)
                    row.Cells(1).Value = originalValue.ToString("D15") ' Formato de 15 dígitos
                End If
            Next

            DGV_ReimprimirFact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_ReimprimirFact.GridColor = Color.DarkGray
            DGV_ReimprimirFact.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
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
        CREAR_FACTURA(DGV_ReimprimirFact.SelectedRows(0).Cells(0).Value.ToString(), encabezadoFactura, facturaContenido, finFactura, True)
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