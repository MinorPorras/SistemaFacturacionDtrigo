Public Class E_NuevaMarca
    Friend ColorMarca As String
    Friend idMarca As String
    Friend ModMarca As Boolean = False
    Friend CodigoPreMod As String
    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModMarca = False Then
            idMarca = OBTENERPK("marca", "ID")
        End If
        VALIDAR()
    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodMarca.Text <> "" And TXT_NombreMarca.Text <> "" Then
            BTN_NMarca.Enabled = True
        Else
            BTN_NMarca.Enabled = False
        End If

    End Sub

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarMarca.Click
        Me.Close()
        P_Marca.TXT_BuscarMarca.SelectAll()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NMarca.Click
        Try
            T.Tables.Clear()
            If ModMarca = False Then
                SQL = "SELECT codigo FROM marca WHERE codigo = '" + TXT_CodMarca.Text + "'"
            Else
                If TXT_CodMarca.Text = CodigoPreMod Then
                    SQL = "SELECT ID FROM marca WHERE ID = 0"
                Else
                    SQL = "SELECT codigo FROM marca WHERE codigo = '" + TXT_CodMarca.Text + "'"
                End If
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count = 0 Then
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If ModMarca = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("marca", "ID", idMarca) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("marca", "ID", idMarca)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_STR("marca", "codigo", TXT_CodMarca.Text, "ID", idMarca)
                        GUARDAR_STR("marca", "nombre", TXT_NombreMarca.Text, "ID", idMarca)
                        LIMPIAR()
                        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Marca.Show()
                        P_Marca.REFRESCAR()
                        P_Marca.TXT_BuscarMarca.SelectAll()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                End If
            Else
                MsgBox("El código " + TXT_CodMarca.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
                TXT_CodMarca.SelectAll()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodMarca.Clear()
        TXT_NombreMarca.Clear()
    End Sub

    Private Sub TXT_NombreMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_NombreMarca.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CodMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodMarca.TextChanged
        VALIDAR()
    End Sub
End Class