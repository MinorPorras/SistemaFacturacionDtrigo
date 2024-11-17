﻿Imports System.ComponentModel
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class P_Caja
    Friend idCliente As Integer
    Private editingItem As ListViewItem
    Private editingSubItemIndex As Integer
    Private itemCount As Integer
    Private NumFactura As Integer
    Friend StrNumFactura As String
    Friend cantProd As Integer = 1
    Friend idUsu As Integer
    Private Sub P_Caja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se desabilitan los botones con funciones que aún no se van a utlizar
        BTN_Conteo.Enabled = False
        BTN_CuentaCobrar.Enabled = False
        BTN_GuardarCuenta.Enabled = False

        'Se desabilitann botones que tiene activaciones condicionales
        BTN_TVenta.Enabled = False
        MNU_CONTX.Enabled = True

        'Se cargan los productos favoritos
        cargarBTNFav()

        'Se carga el último número de factura que se haya agregado, que va a ser el mas alto
        cargarNumFactura()

        TXT_BuscarCliente.Text = "0001"
        DGV_Caja.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0)
        DGV_Caja.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 120, 30)
        DGV_Caja.Font = New Font("Arial", 12)
        DGV_Caja.ColumnHeadersHeight = 25
        DGV_Caja.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True
        DGV_Caja.Columns(1).Width = 50
        DGV_Caja.Columns(2).Width = 270
        DGV_Caja.Columns(3).Width = 45
        DGV_Caja.Columns(4).Width = 35
        DGV_Caja.Columns(5).Width = 60

        idCliente = 1

        'Se coloca la imagen y los datos de la fecha y el día y se inicia el contador para que los vaya actualizando
        PIC_Logo.ImageLocation = ConfigurationManager.AppSettings("Logo").ToString()
        LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
        LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Timer1.Start()
    End Sub

    Private Sub cargarBTNFav()
        T.Tables.Clear()
        SQL = "SELECT ID, nombre FROM producto WHERE favorito = 'Si'"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                Select Case i
                    Case 0
                        BTN_Fav1.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav1.Text = T.Tables(0).Rows(i).Item(1)
                    Case 1
                        BTN_Fav2.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav2.Text = T.Tables(0).Rows(i).Item(1)
                    Case 2
                        BTN_Fav3.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav3.Text = T.Tables(0).Rows(i).Item(1)
                    Case 3
                        BTN_Fav4.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav4.Text = T.Tables(0).Rows(i).Item(1)
                    Case 4
                        BTN_Fav5.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav5.Text = T.Tables(0).Rows(i).Item(1)
                    Case 5
                        BTN_Fav6.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav6.Text = T.Tables(0).Rows(i).Item(1)
                    Case 6
                        BTN_Fav7.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav7.Text = T.Tables(0).Rows(i).Item(1)
                    Case 7
                        BTN_Fav8.Tag = T.Tables(0).Rows(i).Item(0)
                        BTN_Fav8.Text = T.Tables(0).Rows(i).Item(1)
                End Select
            Next
        End If
    End Sub

    Friend Sub cargarNumFactura()
        Try
            T.Tables.Clear()
            SQL = "SELECT TOP 1 num_factura FROM factura ORDER BY Val(num_factura) DESC;"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                NumFactura = If(IsDBNull(T.Tables(0).Rows(0).Item(0)), 1, Convert.ToInt32(T.Tables(0).Rows(0).Item(0)))
                NumFactura += 1
                StrNumFactura = NumFactura.ToString("D15")
            End If
        Catch ex As Exception
            MsgBox("Error al cargar el número de factura." + vbCrLf + "Error: " + ex.Message, vbOK + vbQuestion, "Cerrar sistema")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        LBL_Hora.Text = DateTime.Now.ToString("hh:mm:ss tt")
        LBL_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub BTN_RegresarCliente_Click(sender As Object, e As EventArgs) Handles BTN_RegresarCliente.Click
        Timer1.Stop()
        P_SelectUsu.Show()
        Me.Close()
    End Sub

    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub TXT_BuscarCliente_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarCliente.DoubleClick
        B_Cliente.Show()
    End Sub

    Private Sub TXT_BuscarProducto_DoubleClick(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.DoubleClick
        B_Producto.LIMPIAR()
        B_Producto.Show()
    End Sub

    Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
        T.Tables.Clear()
        SQL = "SELECT p.ID, p.variable, v.precio_venta, p.nombre FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                " WHERE p.codigo = '" & TXT_BuscarProducto.Text & "';"
        Cargar_Tabla(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            If T.Tables(0).Rows(0).Item(1) = 0 Then
                Buscar_DatosProd(TXT_BuscarProducto, False)
            Else
                E_ProductoVariable.LBL_Cod.Text = TXT_BuscarProducto.Text
                E_ProductoVariable.LBL_Producto.Text = T.Tables(0).Rows(0).Item(3)
                E_ProductoVariable.LBL_ID.Text = T.Tables(0).Rows(0).Item(0)
                E_ProductoVariable.Show()
            End If

        Else
            MsgBox("El código que colocó está mal escrito o no existe", vbCritical + vbOKOnly, "Código incorrecto")
        End If
    End Sub

    Friend Sub Buscar_DatosProd(txtCodProd As Guna.UI2.WinForms.Guna2TextBox, buscado As Boolean)
        Try
            T.Tables.Clear()
            SQL = "SELECT p.ID, pnombre, pv.precio_venta, p.variable FROM producto p LEFT JOIN producto_precioVenta pv ON p.ID = pv.ID_Producto" +
                " WHERE p.codigo = '" & txtCodProd.Text & "'"
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                If Not buscado Then
                    cantProd = 1
                End If
                agregarProd(T.Tables(0).Rows(0).Item(0).ToString(), txtCodProd.Text, T.Tables(0).Rows(0).Item(1).ToString(), T.Tables(0).Rows(0).Item(2).ToString(), cantProd)
                cantProd = 1
            Else
                MsgBox("El código que colocó está mal escrito o no existe", vbCritical + vbOKOnly, "Código incorrecto")
            End If

        Catch ex As Exception
            MsgBox("El código que colocó está mal escrito o no existe" + ex.Message, vbCritical + vbOKOnly, "Código incorrecto")
        End Try
    End Sub


    Friend Sub agregarProd(ID As String, codigo As String, nombre As String, precioVenta As String, cant As String)
        Dim Subtotal As Double = cant * Convert.ToInt32(precioVenta)
        Dim row As String() = {ID, codigo, nombre, precioVenta, cant, Subtotal}
        DGV_Caja.Columns(0).Visible = False
        DGV_Caja.Rows.Add(row)
        TXT_BuscarProducto.Clear()
        validadListView()
        TXT_BuscarProducto.Focus()
        cargarTotal()

    End Sub

    Friend Sub cargarTotal()
        Dim total As Double = 0
        For i As Integer = 0 To DGV_Caja.Rows.Count - 2
            total += Convert.ToDouble(DGV_Caja.Rows(i).Cells(5).Value)
        Next
        TXT_Total.Text = "₡ " + total.ToString()
    End Sub

    Private Sub agregarProdFav(btnFav As Guna.UI2.WinForms.Guna2Button)
        If Not String.IsNullOrWhiteSpace(btnFav.Tag) Then
            T.Tables.Clear()
            SQL = "SELECT p.codigo, p.variable, v.precio_venta FROM producto p LEFT JOIN producto_precioVenta v ON p.ID = v.ID_Producto" +
                " WHERE p.ID = " + btnFav.Tag.ToString()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                If T.Tables(0).Rows(0).Item(1) = 0 Then
                    agregarProd(btnFav.Tag.ToString(), T.Tables(0).Rows(0).Item(0), btnFav.Text, T.Tables(0).Rows(0).Item(2), 1)
                Else
                    E_ProductoVariable.LBL_Cod.Text = T.Tables(0).Rows(0).Item(0)
                    E_ProductoVariable.LBL_Producto.Text = btnFav.Text
                    E_ProductoVariable.LBL_ID.Text = btnFav.Tag
                    E_ProductoVariable.Show()
                End If

            Else
                MsgBox("El código que colocó está mal escrito o no existe", vbCritical + vbOKOnly, "Código incorrecto")
            End If
        End If
    End Sub

    Private Sub agregarProdVariable()

    End Sub

    Private Sub BTN_Fav1_Click(sender As Object, e As EventArgs) Handles BTN_Fav1.Click
        agregarProdFav(BTN_Fav1)
    End Sub

    Private Sub BTN_Fav2_Click(sender As Object, e As EventArgs) Handles BTN_Fav2.Click
        agregarProdFav(BTN_Fav2)
    End Sub

    Private Sub BTN_Fav3_Click(sender As Object, e As EventArgs) Handles BTN_Fav3.Click
        agregarProdFav(BTN_Fav3)
    End Sub

    Private Sub BTN_Fav4_Click(sender As Object, e As EventArgs) Handles BTN_Fav4.Click
        agregarProdFav(BTN_Fav4)
    End Sub

    Private Sub BTN_Fav5_Click(sender As Object, e As EventArgs) Handles BTN_Fav5.Click
        agregarProdFav(BTN_Fav5)
    End Sub

    Private Sub BTN_Fav6_Click(sender As Object, e As EventArgs) Handles BTN_Fav6.Click
        agregarProdFav(BTN_Fav6)
    End Sub

    Private Sub BTN_Fav7_Click(sender As Object, e As EventArgs) Handles BTN_Fav7.Click
        agregarProdFav(BTN_Fav7)
    End Sub

    Private Sub BTN_Fav8_Click(sender As Object, e As EventArgs) Handles BTN_Fav8.Click
        agregarProdFav(BTN_Fav8)
    End Sub

    Private Sub BTN_DelFactura_Click(sender As Object, e As EventArgs) Handles BTN_DelFactura.Click
        DGV_Caja.Rows.Clear()
        TXT_BuscarProducto.Clear()
        validadListView()
        cargarTotal()
    End Sub

    Private Sub TXT_BuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProducto.TextChanged
        If Not String.IsNullOrEmpty(TXT_BuscarProducto.Text) Then
            BTN_NProd.Enabled = True
        Else
            BTN_NProd.Enabled = False
        End If
    End Sub

    Private Sub BTN_TVenta_Click(sender As Object, e As EventArgs) Handles BTN_TVenta.Click
        P_TerminarVenta.TXT_ECliente.Text = "0"
        P_TerminarVenta.TXT_EVuelto.Text = "0"

        P_TerminarVenta.TXT_TCliente.Text = "0"
        P_TerminarVenta.TXT_TVuelto.Text = "0"

        P_TerminarVenta.TXT_SCliente.Text = "0"
        P_TerminarVenta.TXT_SVuelto.Text = "0"

        P_TerminarVenta.TXT_DCliente.Text = "0"
        P_TerminarVenta.TXT_DVuelto.Text = "0"

        P_TerminarVenta.TXT_PagoEfectivo.Text = "0"
        P_TerminarVenta.TXT_PagoTarjeta.Text = "0"
        P_TerminarVenta.TXT_MVuelto.Text = "0"

        Dim precio As String() = TXT_Total.Text.Split(" "c)
        If DGV_Caja.Rows.Count > 1 Then

            P_TerminarVenta.total = If(Double.TryParse(precio(1), P_TerminarVenta.total), Convert.ToDouble(precio(1)), Convert.ToDouble(0))
            P_TerminarVenta.TXT_ETotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_TTotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_STotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_DTotal.Text = TXT_Total.Text
            P_TerminarVenta.TXT_MTotal.Text = TXT_Total.Text
            P_TerminarVenta.NumFactura = NumFactura
            P_TerminarVenta.idCLiente = idCliente
            P_TerminarVenta.Show()
        End If
    End Sub

    Friend Sub validadListView()
        itemCount = DGV_Caja.Rows.Count
        If itemCount > 1 Then
            BTN_TVenta.Enabled = True
            MNU_MODIFICAR.Visible = True
            MNU_ELIMINAR.Visible = True
        Else
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False
            BTN_TVenta.Enabled = False

        End If
    End Sub

    Friend Sub LIMPIAR()
        'Se desabilitan los botones con funciones que aún no se van a utlizar
        BTN_Conteo.Enabled = False
        BTN_CuentaCobrar.Enabled = False
        BTN_GuardarCuenta.Enabled = False

        'Se desabilitann botones que tiene activaciones condicionales
        BTN_TVenta.Enabled = False

        BTN_DelFactura.PerformClick()
        TXT_BuscarProducto.Clear()
        TXT_Total.Clear()
        TXT_BuscarCliente.Text = "0001"
        idCliente = 1
        StrNumFactura = ""

        'Se carga el último número de factura que se haya agregado, que va a ser el mas alto
        cargarNumFactura()

    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        B_Producto.LBL_IDProd.Text = DGV_Caja.SelectedRows(0).Cells(0).Value
        B_Producto.idModProd = DGV_Caja.SelectedRows(0).Cells(0).Value
        B_Producto.TXT_codigo.Text = DGV_Caja.SelectedRows(0).Cells(1).Value
        B_Producto.TXT_Nombre.Text = DGV_Caja.SelectedRows(0).Cells(2).Value
        B_Producto.TXT_BuscarProd.Text = DGV_Caja.SelectedRows(0).Cells(2).Value
        B_Producto.TXT_Precio.Text = DGV_Caja.SelectedRows(0).Cells(3).Value
        B_Producto.TXT_CantProd.Text = DGV_Caja.SelectedRows(0).Cells(4).Value
        B_Producto.ModProd = True
        B_Producto.Show()
        validadListView()
        cargarTotal()

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        DGV_Caja.Rows.RemoveAt(DGV_Caja.SelectedRows(0).Index)
        validadListView()
        cargarTotal()

    End Sub

    Private Sub BTN_Reprint_Click(sender As Object, e As EventArgs) Handles BTN_Reprint.Click
        P_ReimprimirFact.Show()
        Me.Hide()
    End Sub

    Private Sub P_Caja_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                BTN_Conteo.PerformClick()
            Case Keys.F2
                BTN_Reprint.PerformClick()
            Case Keys.F3
                BTN_RegresarCliente.PerformClick()
            Case Keys.F4
                BTN_DelFactura.PerformClick()
            Case Keys.F5
                BTN_CuentaCobrar.PerformClick()
            Case Keys.F6
                BTN_GuardarCuenta.PerformClick()
            Case Keys.F7
                BTN_TVenta.PerformClick()
        End Select
    End Sub

    Private Sub DGV_Caja_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Caja.CellValueChanged
        If DGV_Caja.Rows.Count > 1 Then
            Dim cant As Double = Convert.ToDouble(DGV_Caja.SelectedRows(0).Cells(4).Value)
            Dim precioVenta As Double = Convert.ToDouble(DGV_Caja.SelectedRows(0).Cells(3).Value)
            DGV_Caja.SelectedRows(0).Cells(5).Value = precioVenta * cant
        End If
        cargarTotal()
    End Sub
End Class