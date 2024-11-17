Imports System.Configuration
Public Class M_Inicio
    Dim LArray As String()
    Dim MArray As String()
    Dim XArray As String()
    Dim JArray As String()
    Dim VArray As String()
    Dim SArray As String()
    Dim DArray As String()

    Dim Lcont As Integer
    Dim Mcont As Integer
    Dim Xcont As Integer
    Dim Jcont As Integer
    Dim Vcont As Integer
    Dim Scont As Integer
    Dim Dcont As Integer

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Md_Inicializacion.main()
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR()
        LBL_Sucursal.Text = "Sucursal: " + ConfigurationManager.AppSettings("Empresa").ToString()
        LBL_Telefono.Text = "Telefono: " + ConfigurationManager.AppSettings("Telefono").ToString()
        LBL_Email.Text = "Email: " + ConfigurationManager.AppSettings("Correo").ToString()
        PIC_Logo.Image = Image.FromFile(ConfigurationManager.AppSettings("Logo").ToString())
        LBL_Version.Text = "Ver. " + ConfigurationManager.AppSettings("AppVer").ToString()
        cargarCalProveedores("dia_pedido", "proveedor_diaPedido")
        cargarCalProveedores("dia_recibido", "proveedor_recibirPedido")
    End Sub


    Friend Sub cargarCalProveedores(tipoPed As String, tabla As String)
        Try

            T.Tables.Clear()
            SQL = "SELECT p.ID, p.nombre, d." & tipoPed & " FROM proveedor p INNER JOIN " & tabla & " d ON p.ID = d.ID_Proveedor;"
            Cargar_Tabla(T, SQL)

            'Se actualizan los campos de los array para ser del tamaño máximo posible
            ReDim LArray(0)
            ReDim MArray(0)
            ReDim XArray(0)
            ReDim JArray(0)
            ReDim VArray(0)
            ReDim SArray(0)
            ReDim DArray(0)

            'Se ponen todos los contadores a 0
            Lcont = 0
            Mcont = 0
            Xcont = 0
            Jcont = 0
            Vcont = 0
            Scont = 0
            Dcont = 0
            'Dependiendo del tamaño de la tabla obtenida se hace un ciclo for
            'En este por cada fila se obtiene el día en la fila 2 y dependiendo del que sea se agrega al array respectivo
            For i As Integer = 0 To T.Tables(0).Rows().Count - 1
                Dim dia As String = T.Tables(0).Rows(i).Item(2).ToString()

                Select Case dia
                    Case "Lunes"
                        ReDim Preserve LArray(Lcont)
                        LArray(Lcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Lcont += 1
                    Case "Martes"
                        ReDim Preserve MArray(Mcont)
                        MArray(Mcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Mcont += 1
                    Case "Miércoles"
                        ReDim Preserve XArray(Xcont)
                        XArray(Xcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Xcont += 1
                    Case "Jueves"
                        ReDim Preserve JArray(Jcont)
                        JArray(Jcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Jcont += 1
                    Case "Viernes"
                        ReDim Preserve VArray(Vcont)
                        VArray(Vcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Vcont += 1
                    Case "Sábado"
                        ReDim Preserve SArray(Scont)
                        SArray(Scont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Scont += 1
                    Case "Domingo"
                        ReDim Preserve DArray(Dcont)
                        DArray(Dcont) = T.Tables(0).Rows(i).Item(1).ToString()
                        Dcont += 1
                End Select
            Next

            'Se encuentra el array más largo de los 7
            Dim arraymas As String()
            Dim Arraymascont As Integer = 0

            For Each arr As String() In {LArray, MArray, XArray, JArray, VArray, SArray, DArray}
                If arr.Length > Arraymascont Then
                    arraymas = arr
                    Arraymascont = arr.Length
                End If
            Next

            'Se redimensionan todos los array al del mas grande para que tengan el mismo lenght
            ReDim Preserve LArray(Arraymascont - 1)
            ReDim Preserve MArray(Arraymascont - 1)
            ReDim Preserve XArray(Arraymascont - 1)
            ReDim Preserve JArray(Arraymascont - 1)
            ReDim Preserve VArray(Arraymascont - 1)
            ReDim Preserve SArray(Arraymascont - 1)
            ReDim Preserve DArray(Arraymascont - 1)

            'Se limpian los items del list view correspondiente
            If tabla = "proveedor_diaPedido" Then
                DGV_LHacerPed.Rows.Clear()
            ElseIf tabla = "proveedor_recibirPedido" Then
                DGV_LRebPed.Rows.Clear()
            End If

            'Se añaden los items a list view corre
            For i As Integer = 0 To Arraymascont - 1
                If tabla = "proveedor_diaPedido" Then
                    DGV_LHacerPed.Rows.Add(If(LArray(i) Is Nothing, "", LArray(i)), If(MArray(i) Is Nothing, "", MArray(i)),
                                           If(XArray(i) Is Nothing, "", XArray(i)), If(JArray(i) Is Nothing, "", JArray(i)),
                                           If(VArray(i) Is Nothing, "", VArray(i)), If(SArray(i) Is Nothing, "", SArray(i)),
                                           If(DArray(i) Is Nothing, "", DArray(i)))

                ElseIf tabla = "proveedor_recibirPedido" Then
                    DGV_LRebPed.Rows.Add(If(LArray(i) Is Nothing, "", LArray(i)), If(MArray(i) Is Nothing, "", MArray(i)),
                                         If(XArray(i) Is Nothing, "", XArray(i)), If(JArray(i) Is Nothing, "", JArray(i)),
                                         If(VArray(i) Is Nothing, "", VArray(i)), If(SArray(i) Is Nothing, "", SArray(i)),
                                         If(DArray(i) Is Nothing, "", DArray(i)))
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub BTN_Mantenimiento_Click(sender As Object, e As EventArgs) Handles BTN_Mantenimiento.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub BTN_Reporte_Click(sender As Object, e As EventArgs) Handles BTN_Reporte.Click

    End Sub

    Private Sub Inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "1"c Then
            BTN_Mantenimiento.PerformClick()
        ElseIf e.KeyChar = "2"c Then
            BTN_Reporte.PerformClick()
        ElseIf e.KeyChar = "3"c Then
            BTN_CajaVenta.PerformClick()
        End If
    End Sub

    Private Sub BTN_Config_Click(sender As Object, e As EventArgs) Handles BTN_Config.Click
        ConfigGeneral.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_CajaVenta_Click_1(sender As Object, e As EventArgs) Handles BTN_CajaVenta.Click
        P_Caja.Show()
        P_Caja.LBL_Usu.Text = LBL_Usu.Text
        P_Caja.idUsu = LBL_IDCuenta.Text
        Me.Close()
    End Sub

    Private Sub BTN_LogOut_Click(sender As Object, e As EventArgs) Handles BTN_LogOut.Click
        LBL_IDCuenta.Text = "0"
        LBL_Usu.Text = ""
        P_SelectUsu.Show()
        Me.Close()

    End Sub
End Class
