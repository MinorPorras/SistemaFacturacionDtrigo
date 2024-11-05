Public Class P_LoginCaja
    Friend idUsu As Integer
    Private Sub TXT_Clave_TextChanged(sender As Object, e As EventArgs) Handles TXT_Clave.TextChanged
        revisionClave()
    End Sub

    Private Sub P_LoginCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        revisionClave()
    End Sub

    Private Sub revisionClave()
        If TXT_Clave.Text <> "" Then
            BTN_Login.Enabled = True
        Else
            BTN_Login.Enabled = False
        End If
    End Sub

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        T.Tables.Clear()
        SQL = "SELECT clave FROM usuario WHERE ID = " & idUsu
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item(0) = TXT_Clave.Text Then
                P_Caja.Show()
                P_SelectUsu.Close()
                P_Caja.LBL_Usu.Text = LBL_Usu.Text
                P_Caja.idCliente = 1
                P_Caja.idUsu = idUsu
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