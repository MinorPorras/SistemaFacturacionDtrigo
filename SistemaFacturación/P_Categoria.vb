Public Class P_Categoria
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            Dim red As Integer
            Dim green As Integer
            Dim blue As Integer
            LSV_Cat.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarCat.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre, color FROM categoria where codigo LIKE '%" & TXT_BuscarCat.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre, color FROM categoria where nombre LIKE '%" & TXT_BuscarCat.Text & "%'"
                End If
            Else
                SQL = "SELECT ID, codigo, nombre, color FROM categoria"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 3
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Cat.Items.Add(item)
                    LSV_Cat.Items(i).SubItems(3).BackColor = Color.FromArgb(red, green, blue)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Cat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Cat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Cat.Columns(0).Width = 0
            TXT_BuscarCat.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles LSV_Cat.DrawItem

    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles LSV_Cat.DrawSubItem
        If e.ColumnIndex = 3 Then ' Cambia este índice según tus necesidades
            ' Supongamos que has recuperado el string RGB de la base de datos
            Dim rgbString As String = e.SubItem.Text ' El valor RGB está en el texto del subitem
            Dim rgbValues() As String = rgbString.Split(",")

            If rgbValues.Length = 3 Then
                Dim red As Integer = Convert.ToInt32(rgbValues(0))
                Dim green As Integer = Convert.ToInt32(rgbValues(1))
                Dim blue As Integer = Convert.ToInt32(rgbValues(2))

                ' Crea un color a partir de los valores RGB
                Dim backColor As Color = Color.FromArgb(red, green, blue)

                ' Dibuja el fondo de la celda con el color especificado
                e.Graphics.FillRectangle(New SolidBrush(backColor), e.Bounds)
                e.Graphics.DrawString(e.SubItem.Text, LSV_Cat.Font, Brushes.Black, e.Bounds)
            Else
                e.DrawDefault = True
            End If
        Else
            e.DrawDefault = True
        End If
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles LSV_Cat.DrawColumnHeader
        ' Establece el color del texto del encabezado
        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NCat.Click
        E_NuevaCategoria.ModCat = False
        E_NuevaCategoria.Show()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevaCategoria.idCat = LSV_Cat.SelectedItems.Item(0).Text
            E_NuevaCategoria.TXT_CodCat.Text = LSV_Cat.SelectedItems(0).SubItems(1).Text
            E_NuevaCategoria.TXT_NombreCat.Text = LSV_Cat.SelectedItems(0).SubItems(2).Text
            Dim rgbValues() = LSV_Cat.SelectedItems(0).SubItems(3).Text.Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevaCategoria.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevaCategoria.ColorCat = LSV_Cat.SelectedItems(0).SubItems(3).Text
            E_NuevaCategoria.ModCat = True
            E_NuevaCategoria.CodigoPreMod = LSV_Cat.SelectedItems(0).SubItems(1).Text
            E_NuevaCategoria.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            E_NuevaCategoria.Show()
        End Try

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Cat.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar la categoria: " & LSV_Cat.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(LSV_Cat.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM categoria WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM categoria WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("La categoria fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("La categoria no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione una categoria para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar la categoria: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
End Class