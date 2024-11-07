Public Class E_ProveedorPedido
    Private Sub BTN_RegresarPed_Click(sender As Object, e As EventArgs) Handles BTN_RegresarPed.Click
        Me.Close()
    End Sub

    Private Sub E_ProveedorPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
        VALIDAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Pedido.Items.Clear()
            MNU_ELIMINAR.Visible = False
            If E_NuevoProveedor.LHacerPed.Count > 0 Then
                For i As Integer = 0 To E_NuevoProveedor.LHacerPed.Count - 1
                    Dim item As New ListViewItem(E_NuevoProveedor.LHacerPed(i))
                    Dim subItem As String = E_NuevoProveedor.LRebPed(i)
                    item.SubItems.Add(subItem)
                    LSV_Pedido.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
            End If
            LSV_Pedido.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Pedido.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_NProv_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        If Not String.IsNullOrEmpty(CBX_DiaPedido.Text) Or Not String.IsNullOrEmpty(CBX_RecibirPedido.Text) Then
            E_NuevoProveedor.LHacerPed.Add(CBX_DiaPedido.Text)
            E_NuevoProveedor.LRebPed.Add(CBX_RecibirPedido.Text)
            LIMPIAR()
        End If
        REFRESCAR()
        VALIDAR()
    End Sub

    Private Sub LIMPIAR()
        CBX_DiaPedido.SelectedIndex = 0
        CBX_RecibirPedido.SelectedIndex = 0
    End Sub

    Private Sub VALIDAR()
        If CBX_DiaPedido.SelectedIndex <> -1 And CBX_RecibirPedido.SelectedIndex <> -1 And (Not String.IsNullOrEmpty(CBX_DiaPedido.Text) Or Not String.IsNullOrEmpty(CBX_RecibirPedido.Text)) Then
            BTN_NProv.Enabled = True
        Else
            BTN_NProv.Enabled = False
        End If
    End Sub

    Private Sub CBX_RecibirPedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_RecibirPedido.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub CBX_DiaPedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBX_DiaPedido.SelectedIndexChanged
        VALIDAR()
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        If LSV_Pedido.SelectedItems.Count > 0 Then
            E_NuevoProveedor.LHacerPed.RemoveAt(LSV_Pedido.SelectedIndices(0))
            E_NuevoProveedor.LRebPed.RemoveAt(LSV_Pedido.SelectedIndices(0))
            REFRESCAR()
            VALIDAR()
        Else
                MsgBox("Ninguna fila fue seleccionada", vbCritical + vbOKOnly, "Error")
        End If

    End Sub
End Class