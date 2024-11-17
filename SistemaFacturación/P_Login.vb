Public Class P_Login
    Friend idUsu As Integer

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        T.Tables.Clear()
        SQL = "SELECT nombre, telefono, email, logo FROM sucursal"
        Cargar_Tabla(T, SQL)
        If Not IsDBNull(T.Tables(0).Rows(0).Item(0)) Then
            If T.Tables(0).Rows.Count > 0 Then
                ActConfig("Empresa", T.Tables(0).Rows(0).Item(0).ToString())
                ActConfig("Telefono", T.Tables(0).Rows(0).Item(1).ToString())
                ActConfig("Correo", T.Tables(0).Rows(0).Item(2).ToString())
                ActConfig("Logo", T.Tables(0).Rows(0).Item(3).ToString())
                M_Inicio.REFRESCAR()
            End If
        End If
        T.Tables.Clear()
        SQL = "SELECT clave, tipo FROM usuario WHERE ID = " & idUsu
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item(0) = TXT_Clave.Text Then
                M_Inicio.LBL_Usu.Text = LBL_Usu.Text
                M_Inicio.LBL_IDCuenta.Text = idUsu
                If T.Tables(0).Rows(0).Item(1) = 0 Then
                    M_Inicio.BTN_Config.Enabled = False
                    M_Inicio.BTN_Mantenimiento.Enabled = False
                    M_Inicio.BTN_Reporte.Enabled = False
                Else
                    M_Inicio.BTN_Config.Enabled = True
                    M_Inicio.BTN_Mantenimiento.Enabled = True
                    M_Inicio.BTN_Reporte.Enabled = True
                End If
                M_Inicio.Show()
                P_SelectUsu.Close()
                Me.Close()
            Else
                MsgBox("Usuario o contraseña incorrecta", vbCritical + vbOKOnly, "Error")
            End If
        End If
    End Sub

    Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarLogin.Click
        P_SelectUsu.Show()
        Me.Close()
    End Sub
End Class