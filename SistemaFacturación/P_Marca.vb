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
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            If RDB_BuscarCodigo.Checked = True Then
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM marca where codigo LIKE '%" & TXT_BuscarMarca.Text & "%' ORDER BY Val(codigo) ASC;"
            Else
                SQL = "SELECT ID, codigo as [Código], nombre as [Nombre] FROM marca where nombre LIKE '%" & TXT_BuscarMarca.Text & "%' ORDER BY Val(codigo) ASC;"
            End If

            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_Marca.DataSource = bin
            If T.Tables(0).Rows.Count > 0 Then
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_Marca.DataBindingComplete, AddressOf DGV_Marca_DataBindingComplete
            TXT_BuscarMarca.Select()
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_Marca_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Marca.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Marca.Columns.Count - 1
                DGV_Marca.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Marca.Columns(i).Width = 80
                    Case 2
                        DGV_Marca.Columns(i).Width = 345
                End Select
            Next
            DGV_Marca.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Marca.GridColor = Color.DarkGray
            DGV_Marca.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
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
            E_NuevaMarca.idMarca = DGV_Marca.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevaMarca.TXT_CodMarca.Text = DGV_Marca.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaMarca.TXT_NombreMarca.Text = DGV_Marca.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevaMarca.ModMarca = True
            E_NuevaMarca.CodigoPreMod = DGV_Marca.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevaMarca.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Marca.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar la marca: " & DGV_Marca.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(DGV_Marca.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM marca WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM producto_marca WHERE ID_Marca = " & idSucEliminar
                        EJECUTAR(SQL)

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
            Console.WriteLine(ex.Message)
            MsgBox("Error al eliminar la marca: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarMarca.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarMarca.Focus()
    End Sub
End Class