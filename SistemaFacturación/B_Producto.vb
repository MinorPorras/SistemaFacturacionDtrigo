Public Class B_Producto
    Friend ModProd As Boolean
    Dim cant As Integer

    Private Sub B_Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Producto.Items.Clear()
            T.Tables.Clear()
            If TXT_BuscarProd.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT p.ID, p.codigo, p.nombre, v.precio_venta, p.variable FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                        " where p.codigo LIKE '%" & TXT_BuscarProd.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT p.ID, p.codigo, p.nombre, v.precio_venta, p.variable FROM producto p p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                        " where p.nombre LIKE '%" & TXT_BuscarProd.Text & "%'"
                End If
            Else
                SQL = "SELECT p.ID, p.codigo, p.nombre, v.precio_venta, p.variable FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 4
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Producto.Items.Add(item)
                Next
            End If
            LSV_Producto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Producto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Producto.Columns(0).Width = 0
            TXT_BuscarProd.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de clientes: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
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

    Private Sub LSV_Producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSV_Producto.SelectedIndexChanged
        Try
            TXT_codigo.Text = LSV_Producto.SelectedItems(0).SubItems(1).Text
            TXT_Nombre.Text = LSV_Producto.SelectedItems(0).SubItems(2).Text
            If LSV_Producto.SelectedItems(0).SubItems(4).Text = 1 Then
                TXT_Precio.Text = "Variable"
            Else
                TXT_Precio.Text = LSV_Producto.SelectedItems(0).SubItems(3).Text
            End If
            LBL_IDProd.Text = LSV_Producto.SelectedItems(0).SubItems(0).Text
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
            TXT_Precio.Text = ""
        End Try
    End Sub

    Private Sub BTN_SelectProd_Click(sender As Object, e As EventArgs) Handles BTN_SelectProd.Click
        If Integer.TryParse(TXT_CantProd.Text, cant) Then
            If Not ModProd Then
                P_Caja.cantProd = Convert.ToInt32(TXT_CantProd.Text)
                If TXT_Precio.Text = "Variable" Then
                    E_ProductoVariable.LBL_Cod.Text = TXT_codigo.Text
                    E_ProductoVariable.LBL_Producto.Text = TXT_Nombre.Text
                    E_ProductoVariable.LBL_ID.Text = LSV_Producto.SelectedItems(0).SubItems(0).Text
                    E_ProductoVariable.Show()
                Else
                    P_Caja.Buscar_DatosProd(TXT_codigo, True)
                End If
                P_Caja.validadListView()
            Else
                P_Caja.DGV_Caja.SelectedRows(0).Cells(0).Value = LBL_IDProd.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(1).Value = TXT_codigo.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(2).Value = TXT_Nombre.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(3).Value = TXT_Precio.Text
                P_Caja.DGV_Caja.SelectedRows(0).Cells(4).Value = TXT_CantProd.Text
                Dim subtotal As Double = Convert.ToDouble(TXT_CantProd.Text) * Convert.ToDouble(TXT_Precio.Text)
                P_Caja.DGV_Caja.SelectedRows(0).Cells(5).Value = subtotal.ToString()
            End If
            ModProd = False
            LIMPIAR()
            P_Caja.cargarTotal()
            Me.Close()
        Else
            MsgBox("Error: La cantidad debe de ser un numero entero", vbCritical + vbOKOnly, "Error")
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
End Class