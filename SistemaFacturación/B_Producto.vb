Imports System.Threading.Tasks

Public Class B_Producto
    Friend ModProd As Boolean
    Dim cant As Integer
    Friend idModProd As Integer
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 100
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub B_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        REFRESCAR()
        If Not P_Caja.DGV_Caja.RowCount > 0 Then
            LBL_IDProd.Text = P_Caja.DGV_Caja.SelectedRows(0).Cells(0).Value
            idModProd = P_Caja.DGV_Caja.SelectedRows(0).Cells(0).Value
            TXT_BuscarProd.Text = P_Caja.DGV_Caja.SelectedRows(0).Cells(2).Value
        End If
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         T.Tables.Clear()
                         SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], v.precio_venta as [Precio de venta], p.variable as [Variable]" &
                           " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                           " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%' OR p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' ORDER BY Val(p.codigo) ASC;"
                         ' Asegúrate de que el control tiene un identificador de ventana antes de invocar
                         If DGV_BProd.IsHandleCreated Then
                             Invoke(Sub()
                                        Cargar_Tabla(T, SQL)
                                        If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                            Dim bin As New BindingSource
                                            bin.DataSource = T.Tables(0)
                                            DGV_BProd.DataSource = bin
                                        Else ' Limpiar la fuente de datos si no se cargaron datos
                                            DGV_BProd.DataSource = Nothing
                                        End If
                                        TXT_BuscarProd.Select()
                                    End Sub)
                         Else
                             ' Espera hasta que el control esté listo
                             Me.BeginInvoke(Sub() REFRESCAR())
                         End If
                     Catch ex As Exception
                         If DGV_BProd.IsHandleCreated Then
                             Invoke(Sub()
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            MsgBox("Error al cargar la lista de clientes: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End Sub)
                         End If
                     End Try
                 End Sub)
    End Sub


    Private Sub DGV_BProd_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_BProd.DataBindingComplete
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

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
        Me.Close()
        P_Caja.TXT_BuscarProducto.Select()
        P_Caja.TXT_BuscarProducto.SelectAll()
    End Sub

    Private Sub BTN_SelectProd_Click(sender As Object, e As EventArgs) Handles BTN_SelectProd.Click
        If Integer.TryParse(TXT_CantProd.Text, cant) Then
            If Not ModProd Then
                P_Caja.cantProd = Convert.ToInt32(TXT_CantProd.Text)
                If TXT_Precio.Text = "Variable" Then
                    E_ProductoVariable.LBL_Cod.Text = TXT_codigo.Text
                    E_ProductoVariable.LBL_Producto.Text = TXT_Nombre.Text
                    E_ProductoVariable.LBL_ID.Text = DGV_BProd.SelectedRows(0).Cells(0).Value.ToString()
                    E_ProductoVariable.Show()
                Else
                    P_Caja.Buscar_DatosProd(TXT_codigo, True)
                End If
                P_Caja.validadListView()
            Else
                P_Caja.DGV_Caja.SelectedRows(0).Cells(0).Value = LBL_IDProd.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(1).Value = TXT_codigo.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(2).Value = TXT_Nombre.Text
                If Not TXT_Precio.Text = "Variable" Then
                    P_Caja.DGV_Caja.SelectedRows(0).Cells(3).Value = TXT_Precio.Text
                Else
                    P_Caja.DGV_Caja.SelectedRows(0).Cells(3).Value = P_Caja.DGV_Caja.SelectedRows(0).Cells(3).Value
                End If
                P_Caja.DGV_Caja.SelectedRows(0).Cells(4).Value = TXT_CantProd.Text
                Dim subtotal As Double
                If Not TXT_Precio.Text = "Variable" Then
                    subtotal = Convert.ToDouble(TXT_CantProd.Text) * Convert.ToDouble(TXT_Precio.Text)
                Else
                    subtotal = Convert.ToDouble(TXT_CantProd.Text) * Convert.ToDouble(P_Caja.DGV_Caja.SelectedRows(0).Cells(3).Value)
                End If
                P_Caja.DGV_Caja.SelectedRows(0).Cells(5).Value = subtotal.ToString()
            End If
            ModProd = False
            LIMPIAR()
            P_Caja.cargarTotal()
            Me.Close()
            P_Caja.Show()
            P_Caja.TXT_BuscarProducto.Select()
            P_Caja.TXT_BuscarProducto.SelectAll()
        Else
            E_ProductoVariable.LBL_Cod.Text = TXT_codigo.Text
            E_ProductoVariable.LBL_Producto.Text = TXT_Nombre.Text
            E_ProductoVariable.LBL_ID.Text = DGV_BProd.SelectedRows(0).Cells(0).Value.ToString()
            E_ProductoVariable.Show()
        End If
    End Sub

    Private Sub BTN_MasCant_Click(sender As Object, e As EventArgs) Handles BTN_MasCant.Click
        Try
            cant = Convert.ToInt32(TXT_CantProd.Text)
            cant += 1
            TXT_CantProd.Text = cant
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BTN_MenosCant_Click(sender As Object, e As EventArgs) Handles BTN_MenosCant.Click
        Try
            cant = Convert.ToInt32(TXT_CantProd.Text)
            If cant >= 1 Then
                cant -= 1
                TXT_CantProd.Text = cant
            End If
        Catch ex As Exception

        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_BuscarProd.Clear()
        TXT_CantProd.Text = "1"
        TXT_codigo.Clear()
        TXT_Nombre.Clear()
        TXT_Precio.Clear()
    End Sub

    Private Sub DGV_BMarca_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BProd.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BProd.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BProd.SelectedRows(0).Cells(2).Value.ToString()
            If DGV_BProd.SelectedRows(0).Cells(4).Value.ToString() = 1 Then
                TXT_Precio.Text = "Variable"
            Else
                TXT_Precio.Text = DGV_BProd.SelectedRows(0).Cells(3).Value.ToString()
            End If
            LBL_IDProd.Text = DGV_BProd.SelectedRows(0).Cells(0).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
            TXT_Precio.Text = ""
        End Try
    End Sub
End Class