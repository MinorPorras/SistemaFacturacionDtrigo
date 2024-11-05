﻿Imports Guna.UI2.WinForms
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
        P_LoginCaja.LBL_Usu.Text = botonClicado.Text
        P_LoginCaja.idUsu = Convert.ToInt32(botonClicado.Tag)
        P_LoginCaja.TXT_Clave.Select()
        P_LoginCaja.Show()
        Me.Hide()

    End Sub


    Private Sub BTN_RegresarLogin_Click(sender As Object, e As EventArgs) Handles BTN_RegresarLogin.Click
        Me.Close()
        M_Inicio.Show()
    End Sub
End Class