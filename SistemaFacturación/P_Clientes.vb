Public Class P_Clientes
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Cliente.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarCliente.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT c.ID, c.codigo, c.nombre, cc.cedula, ct.telefono, co.correo FROM (((clientes c" + " 
                        LEFT JOIN cliente_cedula cc ON cc.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_correo co ON co.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_telefono ct ON CT.ID_Cliente = C.ID) where c.codigo LIKE '%" & TXT_BuscarCliente.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT c.ID, c.codigo, c.nombre, cc.cedula, ct.telefono, co.correo FROM (((clientes c" + " 
                        LEFT JOIN cliente_cedula cc ON cc.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_correo co ON co.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_telefono ct ON CT.ID_Cliente = C.ID) where c.nombre LIKE '%" & TXT_BuscarCliente.Text & "%'"
                End If
            Else
                SQL = "SELECT c.ID, c.codigo, c.nombre, cc.cedula, ct.telefono, co.correo FROM (((clientes c" + " 
                        LEFT JOIN cliente_cedula cc ON cc.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_correo co ON co.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_telefono ct ON CT.ID_Cliente = C.ID);"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 5
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Cliente.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Cliente.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Cliente.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Cliente.Columns(0).Width = 0
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCliente.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        TXT_BuscarCliente.Focus()
    End Sub

    Private Sub TXT_BuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.TextChanged
        REFRESCAR()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoCliente.idCliente = LSV_Cliente.SelectedItems.Item(0).Text
            E_NuevoCliente.TXT_CodCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(1).Text
            E_NuevoCliente.CodigoPreMod = LSV_Cliente.SelectedItems(0).SubItems(1).Text
            E_NuevoCliente.txtNombreCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(2).Text

            If String.IsNullOrEmpty(LSV_Cliente.SelectedItems(0).SubItems(3).Text) Then
                E_NuevoCliente.TXT_CedCliente.Text = ""
            Else
                E_NuevoCliente.TXT_CedCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(3).Text
            End If

            If String.IsNullOrEmpty(LSV_Cliente.SelectedItems(0).SubItems(4).Text) Then
                E_NuevoCliente.TXT_TelCliente.Text = ""
            Else
                E_NuevoCliente.TXT_TelCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(4).Text
            End If

            If String.IsNullOrEmpty(LSV_Cliente.SelectedItems(0).SubItems(5).Text) Then
                E_NuevoCliente.TXT_CorreoCliente.Text = ""
            Else
                E_NuevoCliente.TXT_CorreoCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(5).Text
            End If

            E_NuevoCliente.ModCLi = True
            E_NuevoCliente.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Cliente.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el cliente: " & LSV_Cliente.SelectedItems(0).SubItems(3).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminar As Integer = Convert.ToInt32(LSV_Cliente.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM clientes WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM cliente_cedula WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM cliente_correo WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM cliente_telefono WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM clientes WHERE ID = " & idEliminar
                        EJECUTAR(SQL)

                        REFRESCAR()
                        MsgBox("El cliente fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El cliente no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un cliente para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el cliente: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_Clientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_NCliente.PerformClick()
        End If
    End Sub

    Private Sub BTN_NCliente_Click_1(sender As Object, e As EventArgs) Handles BTN_NCliente.Click
        E_NuevoCliente.ModCLi = False
        E_NuevoCliente.Show()
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
    End Sub
End Class