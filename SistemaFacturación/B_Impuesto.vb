Public Class B_Impuesto
    Friend caso As String
    Public Sub REFRESCAR()
        Try
            T.Tables.Clear()
            If RDB_BuscarCodigo.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], descripcion  as [Descripción], porcentaje  as [Porcentaje] FROM impuestos where codigo LIKE '%" & TXT_BuscarImp.Text & "%'"
            ElseIf RDB_BuscarDesc.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], descripcion  as [Descripción], porcentaje  as [Porcentaje] FROM impuestos where descripcion LIKE '%" & TXT_BuscarImp.Text & "%'"
            End If
            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_BImp.DataSource = bin
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_BImp.DataBindingComplete, AddressOf DGV_BImp_DataBindingComplete
            TXT_BuscarImp.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub DGV_BImp_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Try
            For i As Integer = 0 To DGV_BImp.Columns.Count - 1
                DGV_BImp.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BImp.Columns(i).Width = 50
                    Case 2
                        DGV_BImp.Columns(i).Width = 200
                    Case 3
                        DGV_BImp.Columns(i).Width = 70
                End Select
            Next
            DGV_BImp.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BImp.GridColor = Color.DarkGray
            DGV_BImp.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub


    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImpuesto.Click
        REFRESCAR()
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectImpuesto.Click
        Try
            E_NuevoProducto.TXT_Impuesto.Text = TXT_porcentaje.Text
            E_NuevoProducto.LBL_IDImp.Text = DGV_BImp.SelectedRows(0).Cells(0).Value.ToString()
            Me.Close()
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarImp.TextChanged
        REFRESCAR()
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RDB_BuscarDesc.Checked = True
        REFRESCAR()
    End Sub


    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarDesc.CheckedChanged
        REFRESCAR()
        TXT_BuscarImp.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarImp.Focus()
    End Sub

    Private Sub DGV_BImp_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BImp.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BImp.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Desc.Text = DGV_BImp.SelectedRows(0).Cells(2).Value.ToString()
            TXT_porcentaje.Text = DGV_BImp.SelectedRows(0).Cells(3).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Desc.Text = ""
            TXT_porcentaje.Text = ""
        End Try
    End Sub
End Class