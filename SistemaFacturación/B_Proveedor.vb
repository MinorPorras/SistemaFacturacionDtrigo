Public Class B_Proveedor
    Friend caso As String
    Public Sub REFRESCAR()
        Try
            T.Tables.Clear()
            If RDB_BuscarCodigo.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM proveedor where codigo LIKE '%" & TXT_BuscarProv.Text & "%'"
            ElseIf RDB_BuscarNombre.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM proveedor where nombre LIKE '%" & TXT_BuscarProv.Text & "%'"
            End If
            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_BProv.DataSource = bin
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_BProv.DataBindingComplete, AddressOf DGV_BProv_DataBindingComplete
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

    Private Sub DGV_BProv_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Try
            For i As Integer = 0 To DGV_BProv.Columns.Count - 1
                DGV_BProv.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BProv.Columns(i).Width = 50
                    Case 2
                        DGV_BProv.Columns(i).Width = 200
                    Case 3
                        DGV_BProv.Columns(i).Width = 70
                End Select
            Next
            DGV_BProv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BProv.GridColor = Color.DarkGray
            DGV_BProv.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectProv.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarProv.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                Case "NProd"
                    E_NuevoProducto.TXT_Proveedor.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_Prov.Text = DGV_BProv.SelectedRows(0).Cells(0).Value.ToString()
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

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarProv.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarProv.Focus()
    End Sub

    Private Sub DGV_BProv_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BProv.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BProv.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BProv.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub
End Class