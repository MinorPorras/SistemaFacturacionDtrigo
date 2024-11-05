Public Class P_Marca
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Marca.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarMarca.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre FROM marca where codigo LIKE '%" & TXT_BuscarMarca.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre FROM marca where nombre LIKE '%" & TXT_BuscarMarca.Text & "%'"
                End If
            Else
                SQL = "SELECT ID, codigo, nombre FROM marca"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 2
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Marca.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Marca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Marca.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Marca.Columns(0).Width = 0
            TXT_BuscarMarca.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NMarca.Click
        E_NuevaMarca.ModMarca = False
        E_NuevaMarca.Show()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevaMarca.idMarca = LSV_Marca.SelectedItems.Item(0).Text
            E_NuevaMarca.TXT_CodMarca.Text = LSV_Marca.SelectedItems(0).SubItems(1).Text
            E_NuevaMarca.TXT_NombreMarca.Text = LSV_Marca.SelectedItems(0).SubItems(2).Text
            E_NuevaMarca.ModMarca = True
            E_NuevaMarca.CodigoPreMod = LSV_Marca.SelectedItems(0).SubItems(1).Text
            E_NuevaMarca.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Marca.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar la marca: " & LSV_Marca.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(LSV_Marca.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM marca WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM marca WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("La marca fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("La marca no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una marca para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la marca: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
    End Sub
End Class