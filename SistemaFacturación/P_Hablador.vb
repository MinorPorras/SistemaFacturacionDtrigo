Imports System.Drawing.Printing

Public Class P_Hablador
    Private searchTimer As Timer
    Private productos As New List(Of String)()
    Private precioVenta As New List(Of String)()
    Private cantidad As New List(Of Integer)()

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer With {
            .Interval = 100
        }
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub
    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         SQL = "SELECT p.ID, p.codigo as 'Código', p.nombre as 'Nombre', v.precio_venta as 'Precio'" &
                                 " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                                 " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%' OR p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' ORDER BY p.codigo ASC;"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource With {
                                            .DataSource = T.Tables(0)
                                        }
                                        DGV_BProd.DataSource = bin
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_BProd.DataSource = Nothing
                                    End If
                                    TXT_BuscarProd.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_BProd.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            msgError("Error al cargar la lista de clientes: " & ex.Message)
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub

    Private Sub DGV_BProd_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BProd.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_BProd.Columns.Count - 1
                DGV_BProd.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BProd.Columns(i).Width = 50
                    Case 2
                        DGV_BProd.Columns(i).Width = 200
                    Case 3
                        DGV_BProd.Columns(i).Width = 70
                End Select
            Next
            DGV_BProd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BProd.GridColor = Color.DarkGray
            DGV_BProd.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub P_Hablador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
    End Sub

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
        P_Productos.Show()
        P_Productos.Select()
        Me.Close()
    End Sub

    Private Sub MNU_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles MNU_SELECCIONAR.Click
        Dim id As Integer = Convert.ToInt32(DGV_BProd.SelectedRows(0).Cells(0).Value)
        Dim codigo As String = DGV_BProd.SelectedRows(0).Cells(1).Value.ToString()
        Dim nombre As String = DGV_BProd.SelectedRows(0).Cells(2).Value.ToString()
        Dim precio As Double = Convert.ToDouble(DGV_BProd.SelectedRows(0).Cells(3).Value)
        DGV_Hablador.Rows.Add(id, codigo, nombre, precio, 1)
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        DGV_Hablador.Rows.RemoveAt(DGV_Hablador.SelectedRows(0).Index)
    End Sub

    Private Sub BTN_Imprimir_Click(sender As Object, e As EventArgs) Handles BTN_Imprimir.Click
        productos.Clear()
        precioVenta.Clear()
        cantidad.Clear()
        If DGV_Hablador.Rows.Count > 0 Then
            For i As Integer = 0 To DGV_Hablador.Rows.Count - 1
                productos.Add(DGV_Hablador.Rows(i).Cells(2).Value.ToString())
                precioVenta.Add(DGV_Hablador.Rows(i).Cells(3).Value.ToString())
                cantidad.Add(Convert.ToInt32(DGV_Hablador.Rows(i).Cells(4).Value))
            Next
            CREAR_HABLADORES(productos, precioVenta, cantidad)
        End If
    End Sub

    Friend Sub CREAR_HABLADORES(productos As List(Of String), precios As List(Of String), cant As List(Of Integer))
        Dim printDoc As New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument_PrintPage
        printDoc.DocumentName = "Habladores de Productos"

        ' Configurar el tamaño de papel personalizado en pulgadas
        Dim customPaperSize As New PaperSize("Custom", CInt(72 * 3.937), CInt(297 * 3.937))
        printDoc.DefaultPageSettings.PaperSize = customPaperSize

        ' Configurar márgenes a cero
        printDoc.DefaultPageSettings.Margins = New Margins(0, 0, 0, 0)

        ' Imprimir el documento
        Dim printDialog As New PrintDialog With {
            .Document = printDoc
        }

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDoc.Print()
        End If
        DGV_Hablador.Rows.Clear()
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim font As New Font("Arial", 12)
        Dim fontProds As New Font("Arial", 12, FontStyle.Bold)
        Dim fontPrices As New Font("Arial", 12, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.Black)
        Dim stringFormatLeft As New StringFormat() With {
            .Alignment = StringAlignment.Near,
            .LineAlignment = StringAlignment.Near
        }

        ' Establecer el tamaño del papel
        Dim totalWidth As Single = 72 * 3.78
        Dim leftMargin As Single = e.MarginBounds.Left
        Dim topMargin As Single = e.MarginBounds.Top
        Dim yPos As Single = topMargin

        ' Recorrer cada producto y crear habladores según la cantidad especificada
        For i As Integer = 0 To productos.Count - 1
            For j As Integer = 1 To cantidad(i)
                ' Dibujar la primera fila alineada a la izquierda con líneas
                Dim lines As New String("-"c, 30) ' Ajustar el número de caracteres según sea necesario
                e.Graphics.DrawString(lines, font, brush, leftMargin, yPos, stringFormatLeft)
                yPos += e.Graphics.MeasureString(lines, font).Height + 5

                ' Añadir una línea adicional antes de escribir la información del producto
                yPos += e.Graphics.MeasureString(" ", font).Height

                ' Dibujar el nombre del producto alineado a la izquierda
                Dim productName As String = productos(i)
                Dim productRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                Dim productSize As SizeF = e.Graphics.MeasureString(productName, fontProds, totalWidth, stringFormatLeft)

                ' Calcular el tamaño del rectángulo para ajustar el texto en varias líneas si es necesario
                productRect.Height = productSize.Height
                e.Graphics.DrawString(productName, fontProds, brush, productRect, stringFormatLeft)
                yPos += productRect.Height + 5

                ' Dibujar el precio alineado a la izquierda
                Dim productPrice As String = "₡" & precioVenta(i)
                Dim priceRect As New RectangleF(leftMargin, yPos, totalWidth, 0)
                e.Graphics.DrawString(productPrice, fontProds, brush, priceRect, stringFormatLeft)
                yPos += e.Graphics.MeasureString(productPrice, fontPrices).Height + 20 ' Espacio adicional después de cada hablador

                ' Verificar si se necesita una nueva página
                If yPos + e.Graphics.MeasureString(productPrice, fontProds).Height > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    Return
                End If
            Next
        Next
    End Sub
End Class