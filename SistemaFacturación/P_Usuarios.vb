
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class P_Usuarios
    Private Sub P_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub
    Public Sub REFRESCAR()
        Try
            Dim red As Integer
            Dim green As Integer
            Dim blue As Integer
            LSV_Usuario.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If TXT_BuscarUsuario.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT u.ID, u.codigo, u.usuario, u.clave, u.color FROM usuario u where u.codigo LIKE '%" & TXT_BuscarUsuario.Text & "%' ORDER BY Val( u.codigo) ASC;"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT u.ID, u.codigo, u.usuario, u.clave, u.color FROM usuario u where u.usuario LIKE '%" & TXT_BuscarUsuario.Text & "%' ORDER BY Val( u.codigo) ASC;"
                End If
            Else
                SQL = "SELECT u.ID, u.codigo, u.usuario, u.clave, u.color FROM usuario u ORDER BY Val( u.codigo) ASC;"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 4
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Usuario.Items.Add(item)
                    LSV_Usuario.Items(i).SubItems(4).BackColor = Color.FromArgb(red, green, blue)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Usuario.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Usuario.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Usuario.Columns(0).Width = 0
            LSV_Usuario.Columns(3).Width = 0
            TXT_BuscarUsuario.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsu.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NUsuario.Click
        E_NuevoUsuario.ModUsu = False
        E_NuevoUsuario.Show()
    End Sub

    Private Sub TXT_BuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarUsuario.TextChanged
        If RDB_BuscarCodigo.Checked = True Then
            Dim num As Integer
            If Integer.TryParse(TXT_BuscarUsuario.Text, num) Then
                REFRESCAR()
            End If
        End If
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs) Handles LSV_Usuario.DrawItem

    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles LSV_Usuario.DrawSubItem
        If e.ColumnIndex = 4 Then ' Cambia este índice según tus necesidades
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

                e.Graphics.DrawString(e.SubItem.Text, LSV_Usuario.Font, New SolidBrush(backColor), e.Bounds)
            Else
                e.DrawDefault = True
            End If
        Else
            e.DrawDefault = True
        End If
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles LSV_Usuario.DrawColumnHeader
        ' Establece el color del texto del encabezado
        TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.Black, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Usuario.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el usuario: " & LSV_Usuario.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(LSV_Usuario.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM usuario WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM usuario WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("El usuario fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El usuario no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un usuario para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar El usuario: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoUsuario.idUsuario = LSV_Usuario.SelectedItems.Item(0).Text
            E_NuevoUsuario.TXT_CodUsuario.Text = LSV_Usuario.SelectedItems(0).SubItems(1).Text
            E_NuevoUsuario.TXT_NombreUsuario.Text = LSV_Usuario.SelectedItems(0).SubItems(2).Text
            E_NuevoUsuario.TXT_ClaveUsuario.Text = LSV_Usuario.SelectedItems(0).SubItems(3).Text
            Dim rgbValues() = LSV_Usuario.SelectedItems(0).SubItems(4).Text.Split(",")
            Dim red As Integer = Convert.ToInt32(rgbValues(0))
            Dim green As Integer = Convert.ToInt32(rgbValues(1))
            Dim blue As Integer = Convert.ToInt32(rgbValues(2))
            E_NuevoUsuario.BTN_Color.FillColor = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorDialog1.Color = Color.FromArgb(red, green, blue)
            E_NuevoUsuario.ColorUsuario = LSV_Usuario.SelectedItems(0).SubItems(4).Text
            If String.IsNullOrEmpty(LSV_Usuario.SelectedItems(0).SubItems(3).Text) Then
                E_NuevoUsuario.CBK_NoClaveUsu.Checked = True
            Else
                E_NuevoUsuario.CBK_NoClaveUsu.Checked = False
            End If
            E_NuevoUsuario.ModUsu = True
            E_NuevoUsuario.CodigoPreMod = LSV_Usuario.SelectedItems(0).SubItems(1).Text
            E_NuevoUsuario.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarUsuario.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarUsuario.Focus()
    End Sub
End Class