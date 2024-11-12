Public Class E_NuevaCategoria
    Friend ColorCat As String
    Friend idCat As String
    Friend ModCat As Boolean = False
    Friend CodigoPreMod As String
    Private Sub E_NuevaCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModCat = False Then
            idCat = OBTENERPK("categoria", "ID")
        End If
        VALIDAR()
    End Sub


    Private Sub BTN_Color_Click(sender As Object, e As EventArgs) Handles BTN_Color.Click
        Try
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                BTN_Color.FillColor = ColorDialog1.Color
                ColorCat = Convert.ToString(ColorDialog1.Color.R) + "," + Convert.ToString(ColorDialog1.Color.G) + "," + Convert.ToString(ColorDialog1.Color.B)
            End If
            VALIDAR()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodCat.Text <> "" And TXT_NombreCat.Text <> "" Then
            BTN_NCat.Enabled = True
        Else
            BTN_NCat.Enabled = False
        End If

    End Sub

    Private Sub BTN_RegresarNCat_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCat.Click
        Me.Close()
    End Sub

    Private Sub BTN_NCat_Click(sender As Object, e As EventArgs) Handles BTN_NCat.Click
        If Not String.IsNullOrEmpty(TXT_CodCat.Text) Or Not String.IsNullOrEmpty(TXT_NombreCat.Text) Then
            T.Tables.Clear()
            If ModCat = False Then
                SQL = "SELECT codigo FROM categoria WHERE codigo = '" + TXT_CodCat.Text + "'"
            Else
                If TXT_CodCat.Text = CodigoPreMod Then
                    SQL = "SELECT ID FROM categoria WHERE ID = 0"
                Else
                    SQL = "SELECT codigo FROM categoria WHERE codigo = '" + TXT_CodCat.Text + "'"
                End If
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count = 0 Then
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If ModCat = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("categoria", "ID", idCat) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("categoria", "ID", idCat)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_STR("categoria", "codigo", TXT_CodCat.Text, "ID", idCat)
                        GUARDAR_STR("categoria", "nombre", TXT_NombreCat.Text, "ID", idCat)
                        If String.IsNullOrEmpty(ColorCat) Then
                            GUARDAR_STR("categoria", "color", "0,0,0", "ID", idCat)

                        Else
                            GUARDAR_STR("categoria", "color", ColorCat, "ID", idCat)
                        End If
                        LIMPIAR()
                        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Categoria.Show()
                        P_Categoria.REFRESCAR()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                End If
            Else
                MsgBox("El código " + TXT_CodCat.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
            End If
        End If
    End Sub

    Friend Sub LIMPIAR()
        TXT_CodCat.Clear()
        TXT_NombreCat.Clear()
        BTN_Color.BackColor = Color.White
        ColorDialog1.Color = Color.White
    End Sub

End Class