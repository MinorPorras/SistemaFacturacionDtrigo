Imports System.Reflection
Imports Microsoft.VisualBasic.Devices

Public Class E_NuevoImpuesto
    Friend idImpuesto As String
    Friend ModImp As Boolean = False
    Friend CodigoPreMod As String
    Private Sub BTN_RegresarUsu_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImp.Click
        Me.Close()
    End Sub

    Private Sub BTN_NUsuario_Click(sender As Object, e As EventArgs) Handles BTN_NImpuesto.Click
        Try
            T.Tables.Clear()
            If ModImp = False Then
                SQL = "SELECT codigo FROM impuestos WHERE codigo = '" + TXT_CodImpuesto.Text + "'"
            Else
                If TXT_CodImpuesto.Text = CodigoPreMod Then
                    SQL = "SELECT ID FROM impuestos WHERE ID = 0"
                Else
                    SQL = "SELECT codigo FROM impuestos WHERE codigo = '" + TXT_CodImpuesto.Text + "'"
                End If
            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count = 0 Then
                ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        If ModImp = False Then
                            ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                            If EXISTEPK("impuestos", "ID", idImpuesto) = False Then ' Si no se ha guardado la categoría
                                ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                GUARDAR_PK("impuestos", "ID", idImpuesto)
                            End If
                        End If
                        ' Actualizar los campos en la base de datos
                        GUARDAR_STR("impuestos", "codigo", TXT_CodImpuesto.Text, "ID", idImpuesto)
                        GUARDAR_STR("impuestos", "descripcion", TXT_DescImpuesto.Text, "ID", idImpuesto)
                        GUARDAR_INT("impuestos", "porcentaje", NUD_Porc.Value, "ID", idImpuesto)
                        LIMPIAR()
                        MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                        ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                        P_Impuestos.Show()
                        P_Impuestos.REFRESCAR()
                        Me.Close()
                    Catch ex As Exception
                        MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                    End Try
                End If
            Else

                MsgBox("El código " + TXT_CodImpuesto.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Friend Sub LIMPIAR()
        TXT_DescImpuesto.Clear()
        TXT_CodImpuesto.Clear()
        NUD_Porc.Value = 0.00
    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_CodImpuesto.Text <> "" And TXT_DescImpuesto.Text <> "" Then
            BTN_NImpuesto.Enabled = True
        Else
            BTN_NImpuesto.Enabled = False
        End If
    End Sub

    Private Sub TXT_CodImpuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_CodImpuesto.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_DescImpuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_DescImpuesto.TextChanged
        VALIDAR()
    End Sub

    Private Sub E_NuevoImpuesto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ModImp = False Then
            idImpuesto = OBTENERPK("impuestos", "ID")
        End If
        VALIDAR()
    End Sub
End Class