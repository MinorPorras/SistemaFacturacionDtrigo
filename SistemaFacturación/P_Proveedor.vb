Public Class P_Proveedor
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Prov.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarProv.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT p.ID, p.codigo, p.nombre, c.correo, T.telefono" +
                    "FROM proveedor p LEFT JOIN proveedor_correo c ON C.ID_Proveedor = p.ID " +
                    "LEFT JOIN proveedor_telefono t ON t.ID_Proveedor = p.ID  where codigo LIKE '%" & TXT_BuscarProv.Text & "%';"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT p.ID, p.codigo, p.nombre, c.correo, T.telefono " +
                    "FROM proveedor p LEFT JOIN proveedor_correo c ON C.ID_Proveedor = p.ID " +
                    "LEFT JOIN proveedor_telefono t ON t.ID_Proveedor = p.ID where nombre LIKE '%" & TXT_BuscarProv.Text & "%';"
                End If
            Else
                SQL = "SELECT p.ID, p.codigo, p.nombre, c.correo, t.telefono " +
                        "FROM ((proveedor AS p " +
                        "LEFT JOIN proveedor_correo AS c ON c.ID_Proveedor = p.ID) " +
                        "LEFT JOIN proveedor_telefono AS t ON t.ID_Proveedor = p.ID);"

            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item(0).ToString())
                    For j As Integer = 1 To 4
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Prov.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Prov.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Prov.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Prov.Columns(0).Width = 0
            TXT_BuscarProv.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        E_NuevoProveedor.ModProv = False
        E_NuevoProveedor.Show()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoProveedor.idProv = LSV_Prov.SelectedItems.Item(0).Text
            E_NuevoProveedor.TXT_CodProv.Text = LSV_Prov.SelectedItems(0).SubItems(1).Text
            E_NuevoProveedor.TXT_NombreProv.Text = LSV_Prov.SelectedItems(0).SubItems(2).Text

            If Not String.IsNullOrEmpty(LSV_Prov.SelectedItems(0).SubItems(3).Text) Then
                E_NuevoProveedor.TXT_CorreoProv.Text = LSV_Prov.SelectedItems(0).SubItems(3).Text
            Else
                E_NuevoProveedor.TXT_CorreoProv.Text = ""
            End If

            If Not String.IsNullOrEmpty(LSV_Prov.SelectedItems(0).SubItems(4).Text) Then
                E_NuevoProveedor.TXT_TelProv.Text = LSV_Prov.SelectedItems(0).SubItems(4).Text
            Else
                E_NuevoProveedor.TXT_TelProv.Text = ""
            End If

            T.Tables.Clear()
            SQL = "SELECT p.ID_Proveedor, p.dia_pedido FROM proveedor_diaPedido p WHERE p.ID_Proveedor = " & LSV_Prov.SelectedItems(0).SubItems(0).Text
            Cargar_Tabla(T, SQL)
            T1.Tables.Clear()
            SQL = "SELECT r.ID_Proveedor, r.dia_recibido FROM proveedor_recibirPedido r WHERE r.ID_Proveedor = " & LSV_Prov.SelectedItems(0).SubItems(0).Text
            Cargar_Tabla(T1, SQL)
            If T.Tables(0).Rows.Count > 0 Or T1.Tables(0).Rows.Count > 0 Then
                Dim maxcont As Integer
                If T.Tables(0).Rows.Count >= T1.Tables(0).Rows.Count Then
                    maxcont = T.Tables(0).Rows.Count - 1
                Else
                    maxcont = T1.Tables(0).Rows.Count - 1
                End If
                For i As Integer = 0 To maxcont
                    E_NuevoProveedor.LHacerPed.Add(If(IsDBNull(T.Tables(0).Rows(i).Item(1)), " ", T.Tables(0).Rows(i).Item(1).ToString()))
                    E_NuevoProveedor.LRebPed.Add(If(IsDBNull(T1.Tables(0).Rows(i).Item(1)), " ", T1.Tables(0).Rows(i).Item(1).ToString()))
                Next
            End If

            E_NuevoProveedor.ModProv = True
            E_NuevoProveedor.CodigoPreMod = LSV_Prov.SelectedItems(0).SubItems(1).Text
            E_NuevoProveedor.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        T2.Tables.Clear()
        T3.Tables.Clear()
        T4.Tables.Clear()
        Try
            If LSV_Prov.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el proveedor: " & LSV_Prov.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(LSV_Prov.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM proveedor WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE * FROM proveedor_correo WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_telefono WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_diaPedido WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_recibirPedido WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM producto_proveedor WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM proveedor WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)

                        REFRESCAR()
                        MsgBox("El proveedor fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El proveedor no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un proveedor para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el proveedor: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
End Class