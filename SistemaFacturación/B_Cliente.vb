Public Class B_Cliente
    Private Sub B_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Cliente.Items.Clear()
            T.Tables.Clear()
            If TXT_BuscarCliente.Text <> "" Then
                If RDB_BuscarCodigo.Checked = True Then
                    SQL = "SELECT * FROM clientes where codigo LIKE '%" & TXT_BuscarCliente.Text & "%'"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    SQL = "SELECT * FROM clientes where nombre LIKE '%" & TXT_BuscarCliente.Text & "%'"
                End If
            Else
                SQL = "SELECT * FROM clientes"
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 2
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Cliente.Items.Add(item)
                Next
            End If
            LSV_Cliente.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Cliente.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Cliente.Columns(0).Width = 0
            TXT_BuscarCliente.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de clientes: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_RegresarBCLiente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarBCLiente.Click
        Me.Close()
    End Sub

    Private Sub BTN_SelectCliente_Click(sender As Object, e As EventArgs) Handles BTN_SelectCliente.Click
        P_Caja.idCliente = LSV_Cliente.SelectedItems(0).SubItems(0).Text
        P_Caja.TXT_BuscarCliente.Text = TXT_codigo.Text
        Me.Close()

    End Sub

    Private Sub LSV_Cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSV_Cliente.SelectedIndexChanged
        Try
            TXT_codigo.Text = LSV_Cliente.SelectedItems(0).SubItems(1).Text
            TXT_Nombre.Text = LSV_Cliente.SelectedItems(0).SubItems(2).Text
            LBL_IDCliente.Text = LSV_Cliente.SelectedItems(0).SubItems(0).Text
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub

    Private Sub TXT_BuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.TextChanged
        REFRESCAR()
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarCliente.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarCliente.Focus()
    End Sub
End Class