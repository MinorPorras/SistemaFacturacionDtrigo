Public Class E_NuevoProveedor
    Friend ColorProv As String
    Friend idProv As String
    Friend ModProv As Boolean = False
    Friend CodigoPreMod As String
    Friend LHacerPed As New List(Of String)()
    Friend LRebPed As New List(Of String)()

    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModProv = False Then
            idProv = OBTENERPK("proveedor", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodProv.Text <> "" And TXT_NombreProv.Text <> "" Then
            BTN_NProv.Enabled = True
            BTN_Pedidos.Enabled = True
        Else
            BTN_NProv.Enabled = False
            BTN_Pedidos.Enabled = False
        End If

    End Sub

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        Me.Close()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        Try
            T.Tables.Clear()
            If ModProv = False Then
                SQL = "SELECT codigo FROM proveedor WHERE codigo = '" + TXT_CodProv.Text + "'"
            Else
                If TXT_CodProv.Text = CodigoPreMod Then
                    SQL = "SELECT ID FROM proveedor WHERE ID = 0"
                Else
                    SQL = "SELECT codigo FROM proveedor WHERE codigo = '" + TXT_CodProv.Text + "'"
                End If
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count = 0 Then
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If ModProv = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("proveedor", "ID", idProv) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("proveedor", "ID", idProv)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_STR("proveedor", "codigo", TXT_CodProv.Text, "ID", idProv)
                        GUARDAR_STR("proveedor", "nombre", TXT_NombreProv.Text, "ID", idProv)

                        If Not String.IsNullOrEmpty(TXT_CorreoProv.Text) Then
                            T.Tables.Clear()
                            SQL = "SELECT ID_Proveedor FROM proveedor_correo WHERE ID_Proveedor = " + idProv
                            Cargar_Tabla(T, SQL)
                            If T.Tables(0).Rows.Count <= 0 Then
                                GUARDAR_VarCompuestas("proveedor_correo", idProv, TXT_CorreoProv.Text)
                            Else
                                GUARDAR_STR("proveedor_correo", "correo", TXT_CorreoProv.Text, "ID_Proveedor", idProv)
                            End If
                        End If

                        If Not String.IsNullOrEmpty(TXT_TelProv.Text) Then
                            T.Tables.Clear()
                            SQL = "SELECT ID_Proveedor FROM proveedor_telefono WHERE ID_Proveedor = " + idProv
                            Cargar_Tabla(T, SQL)
                            If T.Tables(0).Rows.Count <= 0 Then
                                GUARDAR_VarCompuestas("proveedor_telefono", idProv, TXT_TelProv.Text)
                            Else
                                GUARDAR_STR("proveedor_telefono", "telefono", TXT_TelProv.Text, "ID_Proveedor", idProv)
                            End If
                        End If

                        T.Tables.Clear()
                        SQL = "SELECT p.ID_Proveedor, p.dia_pedido FROM proveedor_diaPedido p WHERE p.ID_Proveedor = " & idProv
                        Cargar_Tabla(T, SQL)
                        If T.Tables(0).Rows.Count > 0 Then
                            SQL = "DELETE * FROM proveedor_diaPedido WHERE ID_Proveedor = " & idProv
                            EJECUTAR(SQL)
                        End If
                        For i As Integer = 0 To LHacerPed.Count - 1
                            GUARDAR_VarCompuestas("proveedor_diaPedido", idProv, LHacerPed(i))
                        Next

                        T.Tables.Clear()
                        SQL = "SELECT r.ID_Proveedor, r.dia_recibido FROM proveedor_recibirPedido r WHERE r.ID_Proveedor = " & idProv
                        Cargar_Tabla(T, SQL)
                        If T.Tables(0).Rows.Count > 0 Then
                            SQL = "DELETE * FROM proveedor_recibirPedido WHERE ID_Proveedor = " & idProv
                            EJECUTAR(SQL)
                        End If
                        For i As Integer = 0 To LRebPed.Count - 1
                            GUARDAR_VarCompuestas("proveedor_recibirPedido", idProv, LRebPed(i))
                        Next

                        LIMPIAR()
                        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Proveedor.Show()
                        P_Proveedor.REFRESCAR()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                End If
            Else
                MsgBox("El código " + TXT_CodProv.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodProv.Clear()
        TXT_NombreProv.Clear()
        TXT_CorreoProv.Clear()
        TXT_TelProv.Clear()
        LHacerPed.Clear()
        LRebPed.Clear()
    End Sub

    Private Sub TXT_NombreMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreProv.TextChanged
        VALIDAR()
    End Sub

    Private Sub BTN_Pedidos_Click(sender As Object, e As EventArgs) Handles BTN_Pedidos.Click
        E_ProveedorPedido.LBL_Proveedor.Text = TXT_NombreProv.Text
        E_ProveedorPedido.Show()

    End Sub
End Class