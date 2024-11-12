Public Class P_Impuestos

    Private Sub P_Impuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Try
            LSV_Impuesto.Items.Clear()
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            T.Tables.Clear()
            SQL = "SELECT * FROM impuestos ORDER BY Val(Codigo) ASC;"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    For j As Integer = 1 To 3
                        Dim subItem As String = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Impuesto.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Impuesto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Impuesto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Impuesto.Columns(0).Width = 0
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de categorías: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try

    End Sub

    Private Sub BTN_RegresarImpuesto_Click(sender As Object, e As EventArgs) Handles BTN_RegresarImpuesto.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub BTN_NImpuesto_Click(sender As Object, e As EventArgs) Handles BTN_NImpuesto.Click
        E_NuevoImpuesto.ModImp = False
        E_NuevoImpuesto.Show()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoImpuesto.idImpuesto = LSV_Impuesto.SelectedItems.Item(0).Text
            E_NuevoImpuesto.TXT_CodImpuesto.Text = LSV_Impuesto.SelectedItems(0).SubItems(1).Text
            E_NuevoImpuesto.TXT_DescImpuesto.Text = LSV_Impuesto.SelectedItems(0).SubItems(2).Text
            E_NuevoImpuesto.NUD_Porc.Value = Convert.ToInt32(LSV_Impuesto.SelectedItems(0).SubItems(3).Text)
            E_NuevoImpuesto.ModImp = True
            E_NuevoImpuesto.CodigoPreMod = LSV_Impuesto.SelectedItems(0).SubItems(1).Text
            E_NuevoImpuesto.Show()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Impuesto.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el impuesto: " & LSV_Impuesto.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idSucEliminar As Integer = Convert.ToInt32(LSV_Impuesto.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM impuestos WHERE ID = " & idSucEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM impuestos WHERE ID = " & idSucEliminar
                        EJECUTAR(SQL)
                        REFRESCAR()
                        MsgBox("El impuesto fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El impuesto no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un impuesto para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el impuesto: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub
End Class