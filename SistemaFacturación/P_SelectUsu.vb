Imports Guna.UI2.WinForms
Imports System.Deployment.Application
Public Class P_SelectUsu

    Private Sub P_LoginCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        T.Tables.Clear()
        SQL = "SELECT ID, usuario, color FROM usuario"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                agregarBoton(FlowLayoutPanel1, T.Tables(0).Rows(i).Item(1), T.Tables(0).Rows(i).Item(0), i + 1, T.Tables(0).Rows(i).Item(2))
            Next
        End If


    End Sub

    Private Sub agregarBoton(flowpanel As FlowLayoutPanel, nombre As String, tag As Integer, cont As Integer, colorT As String)
        Dim splitRGB() As String = colorT.Split(","c)
        Dim r As Integer = Convert.ToInt32(splitRGB(0))
        Dim b As Integer = Convert.ToInt32(splitRGB(1))
        Dim g As Integer = Convert.ToInt32(splitRGB(2))
        Dim nuevoBTN As New Guna2Button


        nuevoBTN.Size = New Drawing.Size(80, 60)
        nuevoBTN.Font = New Font("Britannic Bold", 16)
        nuevoBTN.Name = "BTN_Usu" & cont
        nuevoBTN.Text = nombre
        nuevoBTN.Tag = tag
        nuevoBTN.AutoSize = True
        nuevoBTN.FillColor = Color.FromArgb(r, b, g)
        nuevoBTN.Margin = New Padding(15, 15, 0, 0)

        AddHandler nuevoBTN.Click, AddressOf BotonUsu_Click

        FlowLayoutPanel1.Controls.Add(nuevoBTN)
    End Sub

    Private Sub BotonUsu_Click(sender As Object, e As EventArgs)
        Dim botonClicado As Guna2Button = CType(sender, Guna2Button)
        P_Login.LBL_Usu.Text = botonClicado.Text
        P_Login.idUsu = Convert.ToInt32(botonClicado.Tag)
        P_Login.TXT_Clave.Select()
        P_Login.Show()
        Me.Hide()
        P_Login.Select()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Public Sub CheckForUpdates()
        If ApplicationDeployment.IsNetworkDeployed Then
            Dim ad As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
            Try
                Dim info As UpdateCheckInfo = ad.CheckForDetailedUpdate()
                If info.UpdateAvailable Then
                    Dim doUpdate As Boolean = True
                    If Not info.IsUpdateRequired Then
                        Dim dr As DialogResult = MessageBox.Show("Hay una actualización disponible. ¿Deseas instalarla ahora?", "Actualización Disponible", MessageBoxButtons.YesNo)
                        doUpdate = (dr = DialogResult.Yes)
                        If doUpdate Then
                            MessageBox.Show("La aplicación se actualizará. Por favor, reiníciala para aplicar los cambios.")
                            Application.Restart()
                            ad.Update()
                        End If
                    End If
                End If
            Catch dde As DeploymentDownloadException
                MessageBox.Show("La nueva versión de la aplicación no puede ser descargada en este momento. Por favor, verifica tu conexión de red o inténtalo más tarde. Error: " & dde.Message)
            Catch ide As InvalidDeploymentException
                MessageBox.Show("No se puede comprobar una nueva versión de la aplicación. El despliegue ClickOnce está corrupto. Por favor, vuelve a desplegar la aplicación e inténtalo de nuevo. Error: " & ide.Message)
            Catch ioe As InvalidOperationException
                MessageBox.Show("Esta aplicación no puede ser actualizada. Probablemente no es una aplicación ClickOnce. Error: " & ioe.Message)
            End Try
        End If
    End Sub

End Class