Public Class B_Producto
    Friend ModProd As Boolean
    Dim cant As Integer
    Friend idModProd As Integer

    Private Sub B_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            T.Tables.Clear()
            If Not ModProd Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], v.precio_venta as [Precio de venta], p.variable as [Variable]" &
                        " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                        " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%'"
                Else
                    SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], v.precio_venta as [Precio de venta], p.variable as [Variable]" &
                        " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                            " where p.nombre LIKE '%" & TXT_BuscarProd.Text & "%'"
                End If
            Else
                SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], v.precio_venta as [Precio de venta], p.variable as [Variable]" &
                    " FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                    " where p.ID = " & idModProd
            End If

            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_BProd.DataSource = bin
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_BProd.DataBindingComplete, AddressOf DGV_BProd_DataBindingComplete
            TXT_BuscarProd.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de clientes: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub DGV_BProd_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
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
                    Case 4
                        DGV_BProd.Columns(i).Width = 45
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
        REFRESCAR()
    End Sub

    Private Sub BTN_RegresarPrd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPrd.Click
        Me.Close()
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarProd.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarProd.Focus()
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