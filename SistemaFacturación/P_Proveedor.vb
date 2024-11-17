Public Class P_Proveedor
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_RegresarCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
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
                SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], c.correo as [Correo], t.telefono as [Teléfono] " +
                    "FROM ((proveedor AS p " +
                    "LEFT JOIN proveedor_correo AS c ON c.ID_Proveedor = p.ID) " +
                    "LEFT JOIN proveedor_telefono AS t ON t.ID_Proveedor = p.ID) where p.codigo LIKE '%" & TXT_BuscarProv.Text & "%' ORDER BY Val(p.codigo) ASC;"
            Else
                SQL = "SELECT p.ID, p.codigo as [Código], p.nombre as [Nombre], c.correo as [Correo], t.telefono as [Teléfono] " +
                        "FROM ((proveedor AS p " +
                        "LEFT JOIN proveedor_correo AS c ON c.ID_Proveedor = p.ID) " +
                        "LEFT JOIN proveedor_telefono AS t ON t.ID_Proveedor = p.ID) where p.nombre LIKE '%" & TXT_BuscarProv.Text & "%' ORDER BY Val(p.codigo) ASC;"
            End If

            Cargar_Tabla(T, SQL)
            Dim bin As New BindingSource
            bin.DataSource = T.Tables(0)
            DGV_Prov.DataSource = bin
            If T.Tables(0).Rows.Count > 0 Then
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            TXT_BuscarProv.Select()
            ' Manejar el evento DataBindingComplete para ocultar las columnas
            AddHandler DGV_Prov.DataBindingComplete, AddressOf DGV_Prov_DataBindingComplete
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_Prov_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Prov.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Prov.Columns.Count - 1
                DGV_Prov.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Prov.Columns(i).Width = 50
                    Case 2
                        DGV_Prov.Columns(i).Width = 200
                    Case 3
                        DGV_Prov.Columns(i).Width = 270
                    Case 4
                        DGV_Prov.Columns(i).Width = 110

                End Select
            Next
            DGV_Prov.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Prov.GridColor = Color.DarkGray
            DGV_Prov.Columns(0).Visible = False

        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        REFRESCAR()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        E_NuevoProveedor.ModProv = False
        E_NuevoProveedor.Show()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoProveedor.idProv = DGV_Prov.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoProveedor.TXT_CodigoProv.Text = DGV_Prov.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProveedor.TXT_NombreProv.Text = DGV_Prov.SelectedRows(0).Cells(2).Value.ToString()

            If Not String.IsNullOrEmpty(DGV_Prov.SelectedRows(0).Cells(3).Value.ToString()) Then
                E_NuevoProveedor.TXT_CorreoProv.Text = DGV_Prov.SelectedRows(0).Cells(3).Value.ToString()
            Else
                E_NuevoProveedor.TXT_CorreoProv.Text = ""
            End If

            If Not String.IsNullOrEmpty(DGV_Prov.SelectedRows(0).Cells(4).Value.ToString()) Then
                E_NuevoProveedor.TXT_TelProv.Text = DGV_Prov.SelectedRows(0).Cells(4).Value.ToString()
            Else
                E_NuevoProveedor.TXT_TelProv.Text = ""
            End If

            T.Tables.Clear()
            SQL = "SELECT p.ID_Proveedor, p.dia_pedido FROM proveedor_diaPedido p WHERE p.ID_Proveedor = " & DGV_Prov.SelectedRows(0).Cells(0).Value.ToString()
            Cargar_Tabla(T, SQL)
            T1.Tables.Clear()
            SQL = "SELECT r.ID_Proveedor, r.dia_recibido FROM proveedor_recibirPedido r WHERE r.ID_Proveedor = " & DGV_Prov.SelectedRows(0).Cells(0).Value.ToString()
            Cargar_Tabla(T1, SQL)
            If T.Tables(0).Rows.Count > 0 Or T1.Tables(0).Rows.Count > 0 Then
                Dim maxcont As Integer
                If T.Tables(0).Rows.Count >= T1.Tables(0).Rows.Count Then
                    maxcont = T.Tables(0).Rows.Count - 1
                Else
                    maxcont = T1.Tables(0).Rows.Count - 1
                End If
                For i As Integer = 0 To maxcont
                    E_NuevoProveedor.LHacerPed.Add(If(IsDBNull(T.Tables(0).Rows(i).Item(1)), " ", T.Tables(0).Rows(i).Item(1).ToString()))
                    E_NuevoProveedor.LRebPed.Add(If(IsDBNull(T1.Tables(0).Rows(i).Item(1)), " ", T1.Tables(0).Rows(i).Item(1).ToString()))
                Next
            End If

            E_NuevoProveedor.ModProv = True
            E_NuevoProveedor.CodigoPreMod = DGV_Prov.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProveedor.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        Try
            If DGV_Prov.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el proveedor: " & DGV_Prov.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(DGV_Prov.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM proveedor WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE * FROM proveedor_correo WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_telefono WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_diaPedido WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM proveedor_recibirPedido WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE * FROM producto_proveedor WHERE ID_Proveedor = " & idSucEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM proveedor WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)

                        REFRESCAR()
                        MsgBox("El proveedor fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El proveedor no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un proveedor para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el proveedor: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarProv.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarProv.Focus()
    End Sub
End Class