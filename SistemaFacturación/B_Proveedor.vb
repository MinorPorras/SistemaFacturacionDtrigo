Public Class B_Proveedor
    Friend caso As String
    Public Sub REFRESCAR()
        Try
            LSV_Prov.Items.Clear()
            T.Tables.Clear()
            If TXT_BuscarProv.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre FROM proveedor where codigo LIKE '%" & TXT_BuscarProv.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT ID, codigo, nombre FROM proveedor where nombre LIKE '%" & TXT_BuscarProv.Text & "%'"
                End If
            Else
                SQL = "SELECT ID, codigo, nombre FROM proveedor"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 2
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Prov.Items.Add(item)
                Next
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


    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        REFRESCAR()
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectProv.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarProv.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                Case "NProd"
                    E_NuevoProducto.TXT_Proveedor.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_Prov.Text = LSV_Prov.SelectedItems(0).SubItems(0).Text
            End Select
            Me.Close()
        Catch ex As Exception
            P_Productos.TXT_BuscarProv.Text = ""
            P_Productos.REFRESCAR()
            Me.Close()
        End Try

    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        REFRESCAR()
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Private Sub LSV_Marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSV_Prov.SelectedIndexChanged
        Try
            TXT_codigo.Text = LSV_Prov.SelectedItems(0).SubItems(1).Text
            TXT_Nombre.Text = LSV_Prov.SelectedItems(0).SubItems(2).Text
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try

    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
    End Sub
End Class