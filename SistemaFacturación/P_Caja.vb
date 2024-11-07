Imports System.ComponentModel
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
        Buscar_DatosProd(TXT_BuscarProducto, False)
    End Sub

    Friend Sub Buscar_DatosProd(txtCodProd As Guna.UI2.WinForms.Guna2TextBox, buscado As Boolean)
        Try
            T.Tables.Clear()
            SQL = "SELECT ID, nombre, precio_venta FROM producto WHERE codigo = '" & txtCodProd.Text & "'"
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


    Private Sub agregarProd(ID As String, codigo As String, nombre As String, precioVenta As String, cant As String)
        Dim item As New ListViewItem(ID)
        item.SubItems.Add(codigo)
        item.SubItems.Add(nombre)
        item.SubItems.Add(precioVenta)
        item.SubItems.Add(cant)
        Dim Subtotal As Double = cant * Convert.ToInt32(precioVenta)
        item.SubItems.Add(Subtotal)
        LSV_Factura.Items.Add(item)
        LSV_Factura.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        LSV_Factura.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        LSV_Factura.Columns(0).Width = 0
        TXT_BuscarProducto.Clear()
        validadListView()
        TXT_BuscarProducto.Focus()
        cargarTotal()

    End Sub

    Friend Sub cargarTotal()
        Dim total As Double = 0
        For i As Integer = 0 To LSV_Factura.Items.Count - 1
            total += Convert.ToDouble(LSV_Factura.Items(i).SubItems(5).Text)
        Next
        TXT_Total.Text = "₡ " + total.ToString()
    End Sub

    Private Sub agregarProdFav(btnFav As Guna.UI2.WinForms.Guna2Button)
        If Not String.IsNullOrWhiteSpace(btnFav.Tag) Then
            T.Tables.Clear()
            SQL = "SELECT codigo, precio_venta FROM producto WHERE ID = " + btnFav.Tag.ToString()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                agregarProd(btnFav.Tag.ToString(), T.Tables(0).Rows(0).Item(0), btnFav.Text, T.Tables(0).Rows(0).Item(1), 1)
            Else
                MsgBox("El código que colocó está mal escrito o no existe", vbCritical + vbOKOnly, "Código incorrecto")
            End If
        End If
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
        LSV_Factura.Items.Clear()
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

    Private Sub P_Caja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.F1)
                BTN_Conteo.PerformClick()
            Case ChrW(Keys.F2)
                BTN_Reprint.PerformClick()
            Case ChrW(Keys.F3)
                BTN_RegresarCliente.PerformClick()
            Case ChrW(Keys.F4)
                BTN_DelFactura.PerformClick()
            Case ChrW(Keys.F5)
                BTN_CuentaCobrar.PerformClick()
            Case ChrW(Keys.F6)
                BTN_GuardarCuenta.PerformClick()
            Case ChrW(Keys.F7)
                BTN_TVenta.PerformClick()
        End Select
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
        If LSV_Factura.Items.Count > 0 Then

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
        itemCount = LSV_Factura.Items.Count
        If itemCount > 0 Then
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
        B_Producto.LBL_IDProd.Text = LSV_Factura.SelectedItems(0).SubItems(0).Text
        B_Producto.TXT_codigo.Text = LSV_Factura.SelectedItems(0).SubItems(1).Text
        B_Producto.TXT_Nombre.Text = LSV_Factura.SelectedItems(0).SubItems(2).Text
        B_Producto.TXT_Precio.Text = LSV_Factura.SelectedItems(0).SubItems(3).Text
        B_Producto.TXT_CantProd.Text = LSV_Factura.SelectedItems(0).SubItems(4).Text
        B_Producto.ModProd = True
        B_Producto.Show()
        validadListView()
        cargarTotal()

    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        LSV_Factura.Items.RemoveAt(LSV_Factura.SelectedIndices.Count - 1)
        validadListView()
        cargarTotal()

    End Sub

    Private Sub BTN_Reprint_Click(sender As Object, e As EventArgs) Handles BTN_Reprint.Click
        P_ReimprimirFact.Show()
        Me.Hide()
    End Sub


    'Private Sub LSV_Factura_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LSV_Factura.MouseDoubleClick
    '    ' Determinar qué ítem y subítem fue clickeado
    '    Dim hitTestInfo As ListViewHitTestInfo = LSV_Factura.HitTest(e.Location)
    '    editingItem = hitTestInfo.Item
    '    editingSubItemIndex = hitTestInfo.Item.SubItems.IndexOf(hitTestInfo.SubItem)

    '    ' Permitir la edición solo si la fila es la quinta
    '    If editingItem IsNot Nothing AndAlso editingSubItemIndex >= 0 AndAlso LSV_Factura.Items.IndexOf(editingItem) = 4 Then
    '        With TXT_ModCant
    '            .Bounds = hitTestInfo.SubItem.Bounds
    '            .Text = hitTestInfo.SubItem.Text
    '            .Visible = True
    '            .Focus()
    '        End With
    '    End If
    'End Sub

    'Private Sub TXT_ModCant_Leave(sender As Object, e As EventArgs) Handles TXT_ModCant.Leave
    '    ' Guardar el valor editado de vuelta en el ListView
    '    If editingItem IsNot Nothing AndAlso editingSubItemIndex >= 0 Then
    '        ' Convertir el texto a número y sumarlo al valor de la fila 4
    '        Dim Cant As Integer
    '        Dim pUnitario As Integer
    '        If Integer.TryParse(TXT_ModCant.Text, Cant) AndAlso Integer.TryParse(LSV_Factura.Items(3).SubItems(editingSubItemIndex).Text, pUnitario) Then
    '            LSV_Factura.Items(editingItem.Index).SubItems(editingSubItemIndex).Text = TXT_ModCant.Text
    '            Dim sum As Integer = Cant * pUnitario
    '            LSV_Factura.Items(5).SubItems(editingSubItemIndex).Text = sum.ToString()
    '        End If
    '        TXT_ModCant.Visible = False
    '    End If
    'End Sub

    'Private Sub TXT_ModCant_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ModCant.KeyDown
    '    ' Guardar el valor al presionar la tecla Enter
    '    If e.KeyCode = Keys.Enter Then
    '        TXT_ModCant_Leave(sender, e)
    '        e.Handled = True
    '        e.SuppressKeyPress = True
    '    End If
    'End Sub
End Class