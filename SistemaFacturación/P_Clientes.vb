Imports System.Threading.Tasks

Public Class P_Clientes
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 100
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub
    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         MNU_ELIMINAR.Visible = False
                         MNU_MODIFICAR.Visible = False
                         T.Tables.Clear()
                         SQL = "SELECT c.ID, c.codigo as [Código], c.nombre as [Nombre], cc.cedula as [Cédula], ct.telefono as [Teléfono]," &
                                 " co.correo as [Correo] FROM (((clientes c" + " 
                        LEFT JOIN cliente_cedula cc ON cc.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_correo co ON co.ID_Cliente = c.ID)" + "
                        LEFT JOIN cliente_telefono ct ON CT.ID_Cliente = C.ID) where c.codigo LIKE '%" & TXT_BuscarCliente.Text & "%' OR" &
                                     " c.nombre LIKE '%" & TXT_BuscarCliente.Text & "%' ORDER BY Val(c.codigo) ASC;"
                         Invoke(Sub()
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Cliente.DataSource = bin
                                        If T.Tables(0).Rows.Count > 0 Then
                                            MNU_ELIMINAR.Visible = True
                                            MNU_MODIFICAR.Visible = True
                                        End If
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Cliente.DataSource = Nothing
                                    End If
                                    TXT_BuscarCliente.Select()
                                End Sub)
                     Catch ex As Exception
                         Invoke(Sub()
                                    If DGV_Cliente.IsHandleCreated Then
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            ' Mostrar un mensaje de error genérico
                                            MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End If
                                End Sub)
                     End Try
                 End Sub)
    End Sub
    Private Sub DGV_Cliente_DataBindingComplete_1(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Cliente.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Cliente.Columns.Count - 1
                DGV_Cliente.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Cliente.Columns(i).Width = 50
                    Case 2
                        DGV_Cliente.Columns(i).Width = 200
                    Case 3
                        DGV_Cliente.Columns(i).Width = 100
                    Case 4
                        DGV_Cliente.Columns(i).Width = 100
                    Case 5
                        DGV_Cliente.Columns(i).Width = 300
                End Select
            Next
            DGV_Cliente.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Cliente.GridColor = Color.DarkGray
            DGV_Cliente.Columns(0).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCliente.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub P_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        TXT_BuscarCliente.Focus()
        REFRESCAR()
    End Sub

    Private Sub TXT_BuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoCliente.idCliente = DGV_Cliente.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoCliente.TXT_CodCliente.Text = DGV_Cliente.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoCliente.CodigoPreMod = DGV_Cliente.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoCliente.txtNombreCliente.Text = DGV_Cliente.SelectedRows(0).Cells(2).Value.ToString()

            If String.IsNullOrEmpty(DGV_Cliente.SelectedRows(0).Cells(3).Value.ToString()) Then
                E_NuevoCliente.TXT_CedCliente.Text = ""
            Else
                E_NuevoCliente.TXT_CedCliente.Text = DGV_Cliente.SelectedRows(0).Cells(3).Value.ToString()
            End If

            If String.IsNullOrEmpty(DGV_Cliente.SelectedRows(0).Cells(4).Value.ToString()) Then
                E_NuevoCliente.TXT_TelCliente.Text = ""
            Else
                E_NuevoCliente.TXT_TelCliente.Text = DGV_Cliente.SelectedRows(0).Cells(4).Value.ToString()
            End If

            If String.IsNullOrEmpty(DGV_Cliente.SelectedRows(0).Cells(5).Value.ToString()) Then
                E_NuevoCliente.TXT_CorreoCliente.Text = ""
            Else
                E_NuevoCliente.TXT_CorreoCliente.Text = DGV_Cliente.SelectedRows(0).Cells(5).Value.ToString()
            End If

            E_NuevoCliente.ModCLi = True
            E_NuevoCliente.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Cliente.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el cliente: " & DGV_Cliente.SelectedRows(0).Cells(3).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Cliente.SelectedRows(0).Cells(0).Value.ToString())
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM clientes WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM cliente_cedula WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM cliente_correo WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM cliente_telefono WHERE ID_Cliente = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM clientes WHERE ID = " & idEliminar
                        EJECUTAR(SQL)

                        REFRESCAR()
                        MsgBox("El cliente fue eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El cliente no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un cliente para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el cliente: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub P_Clientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            BTN_NCliente.PerformClick()
        End If
    End Sub

    Private Sub BTN_NCliente_Click_1(sender As Object, e As EventArgs) Handles BTN_NCliente.Click
        E_NuevoCliente.ModCLi = False
        E_NuevoCliente.Show()
    End Sub
End Class