Public Class E_NuevoCliente
    Friend idCliente As String
    Friend ModCLi As Boolean = False
    Friend CodigoPreMod As String
    Private Sub E_NuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModCLi = False Then
            idCliente = OBTENERPK("clientes", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodCliente.Text <> "" And txtNombreCliente.Text <> "" Then
            BTN_NCliente.Enabled = True
        Else
            BTN_NCliente.Enabled = False
        End If
    End Sub

    Private Sub BTN_NCliente_Click(sender As Object, e As EventArgs) Handles BTN_NCliente.Click
        If TXT_CodCliente.Text <> "" And txtNombreCliente.Text <> "" Then
            Try
                T.Tables.Clear()
                If ModCLi = False Then
                    SQL = "SELECT codigo FROM clientes WHERE codigo = '" + TXT_CodCliente.Text + "'"
                Else
                    If TXT_CodCliente.Text = CodigoPreMod Then
                        SQL = "SELECT ID FROM clientes WHERE ID = 0"
                    Else
                        SQL = "SELECT codigo FROM clientes WHERE codigo = '" + TXT_CodCliente.Text + "'"
                    End If
                End If
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count = 0 Then
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Try
                            If ModCLi = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("clientes", "ID", idCliente) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("clientes", "ID", idCliente)
                                End If
                            End If
                            ' Actualizar los campos en la base de datos
                            GUARDAR_STR("clientes", "codigo", TXT_CodCliente.Text, "ID", idCliente)
                            GUARDAR_STR("clientes", "nombre", txtNombreCliente.Text, "ID", idCliente)

                            If Not String.IsNullOrEmpty(TXT_CedCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_cedula WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_cedula", idCliente, TXT_CedCliente.Text)
                                Else
                                    GUARDAR_STR("cliente_cedula", "cedula", TXT_CedCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                GUARDAR_STR("cliente_cedula", "cedula", TXT_CedCliente.Text, "ID_Cliente", idCliente)
                            End If

                            If Not String.IsNullOrEmpty(TXT_CorreoCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_correo WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_correo", idCliente, TXT_CorreoCliente.Text)
                                Else
                                    GUARDAR_STR("cliente_correo", "correo", TXT_CorreoCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                GUARDAR_STR("cliente_correo", "correo", TXT_CorreoCliente.Text, "ID_Cliente", idCliente)
                            End If

                            If Not String.IsNullOrEmpty(TXT_TelCliente.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Cliente FROM cliente_telefono WHERE ID_Cliente = " + idCliente
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("cliente_telefono", idCliente, TXT_TelCliente.Text)
                                Else
                                    GUARDAR_STR("cliente_telefono", "telefono", TXT_TelCliente.Text, "ID_Cliente", idCliente)
                                End If
                            Else
                                GUARDAR_STR("cliente_telefono", "telefono", TXT_TelCliente.Text, "ID_Cliente", idCliente)
                            End If

                            LIMPIAR()
                            MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Clientes.Show()
                            P_Clientes.REFRESCAR()
                            P_Clientes.TXT_BuscarCliente.SelectAll()
                            Me.Close()
                        Catch ex As Exception
                            MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                        End Try
                    End If
                Else
                    MsgBox("El código " + TXT_CodCliente.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
                    TXT_CodCliente.SelectAll()
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodCliente.Clear()
        TXT_CedCliente.Clear()
        txtNombreCliente.Clear()
        TXT_TelCliente.Clear()
        TXT_CorreoCliente.Clear()
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCliente.Click
        P_Clientes.REFRESCAR()
        Me.Close()
        P_Clientes.TXT_BuscarCliente.SelectAll()
    End Sub

    Private Sub TXT_CodCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_TelCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_TelCliente.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CorreoCliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_CorreoCliente.TextChanged
        VALIDAR()
    End Sub
End Class