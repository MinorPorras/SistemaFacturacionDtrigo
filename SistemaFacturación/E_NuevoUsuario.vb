Public Class E_NuevoUsuario
    Friend ColorUsuario As String
    Friend idUsuario As String
    Friend ModUsu As Boolean = False
    Friend CodigoPreMod As String
    Private Sub E_NuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModUsu = False Then
            idUsuario = OBTENERPK("usuario", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodUsuario.Text <> "" And TXT_NombreUsuario.Text <> "" And ColorUsuario <> "" Then
            If TXT_ClaveUsuario.Text <> "" Or CBK_NoClaveUsu.Checked = True Then
                BTN_NUsuario.Enabled = True
            End If
        Else
            BTN_NUsuario.Enabled = False
        End If
    End Sub

    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarUsu.Click
        P_Usuarios.Show()
        P_Usuarios.REFRESCAR()
        Me.Close()
    End Sub

    Private Sub TXT_CodUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_NombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_ClaveUsuario_TextChanged(sender As Object, e As EventArgs) Handles TXT_ClaveUsuario.TextChanged
        VALIDAR()
    End Sub

    Private Sub CBX_Sucursal_SelectedIndexChanged(sender As Object, e As EventArgs)
        VALIDAR()
    End Sub

    Private Sub BTN_Color_Click(sender As Object, e As EventArgs) Handles BTN_Color.Click
        Try
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                BTN_Color.FillColor = ColorDialog1.Color
                ColorUsuario = Convert.ToString(ColorDialog1.Color.R) + "," + Convert.ToString(ColorDialog1.Color.G) + "," + Convert.ToString(ColorDialog1.Color.B)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
        VALIDAR()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NUsuario.Click
        Try
            T.Tables.Clear()
            If ModUsu = False Then
                SQL = "SELECT codigo FROM usuario WHERE codigo = '" + TXT_CodUsuario.Text + "'"
            Else
                If TXT_CodUsuario.Text = CodigoPreMod Then
                    SQL = "SELECT ID FROM usuario WHERE ID = 0"
                Else
                    SQL = "SELECT codigo FROM usuario WHERE codigo = '" + TXT_CodUsuario.Text + "'"
                End If
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count = 0 Then
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If ModUsu = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("usuario", "ID", idUsuario) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("usuario", "ID", idUsuario)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_STR("usuario", "codigo", TXT_CodUsuario.Text, "ID", idUsuario)
                        GUARDAR_STR("usuario", "usuario", TXT_NombreUsuario.Text, "ID", idUsuario)
                        If CBK_NoClaveUsu.Checked = True Then
                            GUARDAR_STR("usuario", "clave", "n", "ID", idUsuario)
                        Else
                            GUARDAR_STR("usuario", "clave", TXT_ClaveUsuario.Text, "ID", idUsuario)
                        End If

                        GUARDAR_STR("usuario", "color", ColorUsuario, "ID", idUsuario)
                        LIMPIAR()
                        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Usuarios.Show()
                        P_Usuarios.REFRESCAR()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                End If
            Else
                MsgBox("El código " + TXT_CodUsuario.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodUsuario.Clear()
        TXT_NombreUsuario.Clear()
        TXT_ClaveUsuario.Clear()
        BTN_Color.BackColor = Color.White
        ColorDialog1.Color = Color.White
    End Sub

    Private Sub CBK_NoClaveUsu_CheckedChanged(sender As Object, e As EventArgs) Handles CBK_NoClaveUsu.CheckedChanged
        VALIDAR()
    End Sub
End Class