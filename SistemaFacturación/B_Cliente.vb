Public Class B_Cliente
    Private Sub B_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarNombre.Checked = True
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            T.Tables.Clear()
            If RDB_BuscarCodigo.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM clientes where codigo LIKE '%" & TXT_BuscarCliente.Text & "%'"
            ElseIf RDB_BuscarNombre.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM clientes where nombre LIKE '%" & TXT_BuscarCliente.Text & "%'"
            End If

            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_BCliente.DataSource = bin
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_BCliente.DataBindingComplete, AddressOf DGV_BCliente_DataBindingComplete
            TXT_BuscarCliente.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de clientes: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub DGV_BCliente_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Try
            For i As Integer = 0 To DGV_BCliente.Columns.Count - 1
                DGV_BCliente.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BCliente.Columns(i).Width = 50
                    Case 2
                        DGV_BCliente.Columns(i).Width = 200
                    Case 3
                        DGV_BCliente.Columns(i).Width = 70
                End Select
            Next
            DGV_BCliente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BCliente.GridColor = Color.DarkGray
            DGV_BCliente.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarBCLiente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarBCLiente.Click
        Me.Close()
    End Sub

    Private Sub BTN_SelectCliente_Click(sender As Object, e As EventArgs) Handles BTN_SelectCliente.Click
        P_Caja.idCliente = DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
        P_Caja.TXT_BuscarCliente.Text = TXT_codigo.Text
        Me.Close()

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

    Private Sub DGV_BCliente_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BCliente.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BCliente.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BCliente.SelectedRows(0).Cells(2).Value.ToString()
            LBL_IDCliente.Text = DGV_BCliente.SelectedRows(0).Cells(0).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub
End Class