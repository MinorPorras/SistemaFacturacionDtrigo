Imports System.Net.Mime.MediaTypeNames

Public Class B_Categoria
    Friend caso As String
    Public Sub REFRESCAR()
        Try
            T.Tables.Clear()
            SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] " &
                  "FROM categoria " &
                  "WHERE codigo LIKE '%" & TXT_BuscarCat.Text & "%' " &
                  "OR nombre LIKE '%" & TXT_BuscarCat.Text & "%'"
            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_BCat.DataSource = bin
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_BCat.DataBindingComplete, AddressOf DGV_BCat_DataBindingComplete
            TXT_BuscarCat.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_BCat_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs)
        Try
            For i As Integer = 0 To DGV_BCat.Columns.Count - 1
                DGV_BCat.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_BCat.Columns(i).Width = 50
                    Case 2
                        DGV_BCat.Columns(i).Width = 200
                    Case 3
                        DGV_BCat.Columns(i).Width = 70
                End Select
            Next
            DGV_BCat.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_BCat.GridColor = Color.DarkGray
            DGV_BCat.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub


    Private Sub BTN_RegresarMarca_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        REFRESCAR()
        Me.Close()
    End Sub

    Private Sub BTN_NMarca_Click(sender As Object, e As EventArgs) Handles BTN_SelectCat.Click
        Try
            Select Case caso
                Case "Prod"
                    P_Productos.TXT_BuscarCat.Text = TXT_Nombre.Text
                    P_Productos.REFRESCAR()
                Case "NProd"
                    E_NuevoProducto.TXT_Categoria.Text = TXT_Nombre.Text
                    E_NuevoProducto.LBL_IDCat.Text = DGV_BCat.SelectedRows(0).Cells(0).Value.ToString()
            End Select
            Me.Close()
        Catch ex As Exception
            P_Productos.TXT_BuscarCat.Text = ""
            P_Productos.REFRESCAR()
            Me.Close()
        End Try

    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        REFRESCAR()
    End Sub

    Private Sub B_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs)
        REFRESCAR()
        TXT_BuscarCat.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs)
        REFRESCAR()
        TXT_BuscarCat.Focus()
    End Sub

    Private Sub DGV_BCat_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_BCat.SelectionChanged
        Try
            TXT_codigo.Text = DGV_BCat.SelectedRows(0).Cells(1).Value.ToString()
            TXT_Nombre.Text = DGV_BCat.SelectedRows(0).Cells(2).Value.ToString()
        Catch ex As Exception
            TXT_codigo.Text = ""
            TXT_Nombre.Text = ""
        End Try
    End Sub
End Class