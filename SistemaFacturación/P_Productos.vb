Public Class P_Productos
    Private stringConsultaBase As String = "SELECT p.ID, p.codigo, p.nombre, d.descripcion, p.precio_base, p.porc_impuesto, p.ganancia, pv.precio_venta, p.variable, " +
                          "c.ID_Categoria, cat.nombre as 'Categoría', pm.ID_Marca, m.Nombre as 'Marca', pp.ID_Proveedor, pr.nombre as 'Proveedor', p.favorito " +
                          "FROM ((((((((producto p " +
                          "LEFT JOIN producto_categoria c ON p.ID = c.ID_Producto) " +
                          "LEFT JOIN categoria cat ON c.ID_Categoria = cat.ID) " +
                          "LEFT JOIN producto_marca pm ON p.ID = pm.ID_Producto) " +
                          "LEFT JOIN marca m ON m.ID = pm.ID_Marca) " +
                          "LEFT JOIN producto_proveedor pp ON p.ID = pp.ID_Producto) " +
                          "LEFT JOIN proveedor pr ON pp.ID_Proveedor = pr.ID) " +
                          "LEFT JOIN producto_desc d ON p.ID = d.ID_Producto) " +
                          "LEFT JOIN producto_precioVenta pv ON pv.ID_Producto= p.ID)"
    Private Sub P_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPestaña()
    End Sub

    Friend Sub cargarPestaña()
        RDB_BuscarNombre.Checked = True
        CKB_Categoria.Checked = False
        CKB_Marca.Checked = False
        CKB_Proveedor.Checked = False
        TXT_BuscarMarca.Enabled = False
        TXT_BuscarCat.Enabled = False
        TXT_BuscarProv.Enabled = False
        REFRESCAR()
    End Sub


    Private Sub CerrarApp_Click(sender As Object, e As EventArgs) Handles CerrarApp.Click
        If MsgBox("¿Desea cerra la aplicación?", vbOKCancel + vbQuestion, "Cerrar sistema") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If RDB_BuscarCodigo.Checked = True Then
            Dim num As Integer
            If Integer.TryParse(TXT_BuscarProd.Text, num) Then
                REFRESCAR()
            End If
        Else
            REFRESCAR()
        End If
    End Sub
    Public Sub REFRESCAR()
        Try
            'Se limpian todos los items del list viw
            LSV_Prod.Items.Clear()

            'Se vuelven invisibles el menu contextual en caso de que no haya nada en la tabla
            MNU_ELIMINAR.Visible = False
            MNU_MODIFICAR.Visible = False

            'Se limpia todo en la tabla
            T.Tables.Clear()

            'Declaración de variables para busqueda con el query
            Dim cat As String
            Dim Prov As String
            Dim Marca As String

            'Se  verifica que el chec box de buscar por categoría este seleccionado
            If CKB_Categoria.Checked = True Then
                'Que la selección no se -1
                If TXT_BuscarCat.Text <> "" Then
                    'Verifica el estado del textbox
                    If TXT_BuscarProd.Text <> "" Then
                        'Si tiene texto se agrega el AND al inicio y un espcio al final para que calce con el query
                        cat = "And cat.nombre Like '%" + TXT_BuscarCat.Text + "%' "
                    Else
                        'Si no tiene nada se agrega el espacio al inicio y el AND al final
                        cat = " cat.nombre Like '%" + TXT_BuscarCat.Text + "%' "
                    End If
                Else
                    'Si se tiene seleccionado el -1
                    cat = ""
                End If
            Else
                'Si no se tiene seleccionado el check box de categoria
                cat = ""
            End If

            'Se  verifica que el chec box de buscar por marca este seleccionado
            If CKB_Marca.Checked = True Then
                'Que la selección no se -1
                If TXT_BuscarMarca.Text <> "" Then
                    'Verifica el estado del textbox
                    If TXT_BuscarProd.Text <> "" Then
                        'Si tiene texto se agrega el AND al inicio y un espcio al final para que calce con el query
                        Marca = "And m.nombre Like '%" + TXT_BuscarMarca.Text + "%' "
                    Else
                        'Si no tiene nada se agrega el espacio al inicio y el AND al final
                        Marca = " m.nombre Like '%" + TXT_BuscarMarca.Text + "%' "
                    End If
                Else
                    'Si se tiene seleccionado el -1
                    Marca = ""
                End If
            Else
                'Si no se tiene seleccionado el check box de marca
                Marca = ""
            End If

            'Se  verifica que el chec box de buscar por proveedor este seleccionado
            If CKB_Proveedor.Checked = True Then
                'Que la selección no se -1
                If TXT_BuscarProv.Text <> "" Then
                    'Verifica el estado del textbox
                    If TXT_BuscarProd.Text <> "" Then
                        'Si tiene texto se agrega el AND al inicio y un espcio al final para que calce con el query
                        Prov = "And pr.nombre Like '%" + TXT_BuscarProv.Text + "%' "
                    Else
                        'Si no tiene nada se agrega el espacio al inicio y el AND al final
                        Prov = " pr.nombre Like '%" + TXT_BuscarProv.Text + "%' "
                    End If
                Else
                    'Si se tiene seleccionado el -1
                    Prov = ""
                End If
            Else
                'Si no se tiene seleccionado el check box de proveedor
                Prov = ""
            End If


            If TXT_BuscarProd.Text <> "" Then
                'Si el textbox tiene algo de texto
                If RDB_BuscarCodigo.Checked = True Then
                    'Si busca por codigo hace este query
                    SQL = stringConsultaBase + " where p.codigo Like '%" & TXT_BuscarProd.Text & "%' " + cat + Marca + Prov + " ORDER BY Val(p.codigo) ASC;"
                ElseIf RDB_BuscarNombre.Checked = True Then
                    'Si busca por nombre hace este query
                    SQL = stringConsultaBase + " where p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' " + cat + Marca + Prov + " ORDER BY Val(p.codigo) ASC;"
                End If
            Else
                'SXi el textbox esta vacio
                If cat = "" And Marca = "" And Prov = "" Then
                    'Si los valores de cat, marca y prov estan vacios hace este query
                    SQL = stringConsultaBase + ";"
                Else
                    'Si alguno de los 3 valores de cat, marca y prov tiene algo de texto
                    If cat <> "" And Marca <> "" And Prov <> "" Then
                        'Si las tres variables tiene un valor se agregan los AND en medio de cat y marca y en medio de marca y proveedor
                        cat = cat + " And "
                        Marca = Marca + " And "
                    ElseIf cat <> "" And Marca <> "" Then
                        'Si marca y cat tiene algun valor asociado se le agrega el and
                        'Significa que Hay una categoria que buscar y que hay una marca que buscar
                        ' va de primero la categoria por lo que se le agrega el and para que despues de esta venga la marca
                        cat = cat + " And "

                    ElseIf cat <> "" And Prov <> "" Then
                        'Si hay una categoria y un proveedor seleccionadas  se agrega el and despues de cat
                        cat = cat + " And "

                    ElseIf Marca <> "" And Prov <> "" Then
                        'Si hay una marca y un proveedor de agrega el AND despues de Marca
                        Marca = Marca + " And "
                    End If
                    SQL = stringConsultaBase + " WHERE " + cat + Marca + Prov + " ORDER BY Val(codigo) ASC;"
                End If

            End If
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To T.Tables(0).Rows.Count - 1
                    Dim item As New ListViewItem(T.Tables(0).Rows(i).Item("ID").ToString())
                    Dim subItem As String
                    For j As Integer = 1 To 15
                        If Not j = 8 Then
                            subItem = If(IsDBNull(T.Tables(0).Rows(i).Item(j)), "", T.Tables(0).Rows(i).Item(j).ToString())
                        Else
                            If Not IsDBNull(T.Tables(0).Rows(i).Item(j)) Then
                                If T.Tables(0).Rows(i).Item(j) = 1 Then
                                    subItem = "Si"
                                Else
                                    subItem = "No"
                                End If
                            Else
                                subItem = ""
                            End If
                        End If
                        item.SubItems.Add(subItem)
                    Next
                    LSV_Prod.Items.Add(item)
                Next
                MNU_ELIMINAR.Visible = True
                MNU_MODIFICAR.Visible = True
            End If
            LSV_Prod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            LSV_Prod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            LSV_Prod.Columns(0).Width = 0
            LSV_Prod.Columns(9).Width = 0
            LSV_Prod.Columns(11).Width = 0
            LSV_Prod.Columns(13).Width = 0
        Catch ex As Exception
            If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                ' Mostrar un mensaje de error genérico
                MsgBox("Error al cargar la lista de de productos: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End If
        End Try
    End Sub

    Private Sub BTN_NProd_Click(sender As Object, e As EventArgs) Handles BTN_NProd.Click
        E_NuevoProducto.Show()
    End Sub

    Private Sub BTN_RegresarProd_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProd.Click
        M_Mantenimiento.Show()
        Me.Close()
    End Sub

    Private Sub CKB_Marca_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Marca.CheckedChanged
        If CKB_Marca.Checked = False Then
            TXT_BuscarMarca.Text = ""
            TXT_BuscarMarca.Enabled = False
        Else
            TXT_BuscarMarca.Enabled = True
        End If
        REFRESCAR()
    End Sub

    Private Sub CKB_Proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Proveedor.CheckedChanged
        If CKB_Proveedor.Checked = False Then
            TXT_BuscarProv.Text = ""
            TXT_BuscarProv.Enabled = False
        Else
            TXT_BuscarProv.Enabled = True
        End If
        REFRESCAR()
    End Sub

    Private Sub CKB_Categoria_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Categoria.CheckedChanged
        If CKB_Categoria.Checked = False Then
            TXT_BuscarCat.Text = ""
            TXT_BuscarCat.Enabled = False
        Else
            TXT_BuscarCat.Enabled = True
        End If
        REFRESCAR()
    End Sub

    Private Sub TXT_BuscarMarca_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarMarca.MouseDoubleClick
        B_Marca.Show()
        B_Marca.caso = "Prod"
    End Sub

    Private Sub TXT_BuscarProv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarProv.MouseDoubleClick
        B_Proveedor.Show()
        B_Proveedor.caso = "Prod"
    End Sub

    Private Sub TXT_BuscarCat_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_BuscarCat.MouseDoubleClick
        B_Categoria.Show()
        B_Categoria.caso = "Prod"
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        REFRESCAR()
    End Sub

    Private Sub TXT_BuscarProv_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        REFRESCAR()
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        REFRESCAR()
    End Sub

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoProducto.ModProd = True
            E_NuevoProducto.idProd = LSV_Prod.SelectedItems(0).SubItems(0).Text
            E_NuevoProducto.TXT_Cod.Text = LSV_Prod.SelectedItems(0).SubItems(1).Text
            E_NuevoProducto.TXT_Nombre.Text = LSV_Prod.SelectedItems(0).SubItems(2).Text
            E_NuevoProducto.TXT_Desc.Text = LSV_Prod.SelectedItems(0).SubItems(3).Text
            E_NuevoProducto.TXT_PrecioBase.Text = LSV_Prod.SelectedItems(0).SubItems(4).Text
            E_NuevoProducto.TXT_Impuesto.Text = LSV_Prod.SelectedItems(0).SubItems(5).Text
            E_NuevoProducto.TXT_Ganancia.Text = LSV_Prod.SelectedItems(0).SubItems(6).Text
            If LSV_Prod.SelectedItems(0).SubItems(8).Text = "Si" Then
                E_NuevoProducto.CKB_variable.Checked = True
            Else
                E_NuevoProducto.CKB_variable.Checked = False
            End If
            E_NuevoProducto.TXT_PrecioVenta.Text = LSV_Prod.SelectedItems(0).SubItems(7).Text
            E_NuevoProducto.LBL_IDCat.Text = LSV_Prod.SelectedItems(0).SubItems(9).Text
            E_NuevoProducto.TXT_Categoria.Text = LSV_Prod.SelectedItems(0).SubItems(10).Text
            E_NuevoProducto.LBL_IDMarca.Text = LSV_Prod.SelectedItems(0).SubItems(11).Text
            E_NuevoProducto.TXT_Marca.Text = LSV_Prod.SelectedItems(0).SubItems(12).Text
            E_NuevoProducto.LBL_Prov.Text = LSV_Prod.SelectedItems(0).SubItems(13).Text
            E_NuevoProducto.TXT_Proveedor.Text = LSV_Prod.SelectedItems(0).SubItems(14).Text
            If LSV_Prod.SelectedItems(0).SubItems(15).Text = "Si" Then
                E_NuevoProducto.CKB_Fav.Checked = True
            Else
                E_NuevoProducto.CKB_Fav.Checked = False
            End If

            E_NuevoProducto.CodigoPreMod = LSV_Prod.SelectedItems(0).SubItems(1).Text
            E_NuevoProducto.Show()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If LSV_Prod.SelectedItems.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el producto: " & LSV_Prod.SelectedItems(0).SubItems(2).Text & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminar As Integer = Convert.ToInt32(LSV_Prod.SelectedItems(0).SubItems(0).Text)
                    ' Verificar si hay categorías asociadas
                    SQL = "SELECT COUNT(ID) FROM producto WHERE ID = " & idEliminar
                    Cargar_Tabla(T, SQL)

                    If T.Tables(0).Rows(0).Item(0) <> 0 Then
                        'Se elimina
                        SQL = "DELETE FROM producto_marca WHERE ID_Producto = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM producto_categoria WHERE ID_Producto = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM producto_proveedor WHERE ID_Producto = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM producto_desc WHERE ID_Producto = " & idEliminar
                        EJECUTAR(SQL)

                        SQL = "DELETE FROM producto WHERE ID = " & idEliminar
                        EJECUTAR(SQL)

                        REFRESCAR()
                        MsgBox("El producto fue eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminado")
                    Else
                        MsgBox("El producto no existe", vbExclamation, "Error")
                    End If
                End If
            Else
                MsgBox("Seleccione un producto para eliminar.", vbInformation + vbOKOnly, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error al eliminar el producto: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub RDB_BuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarNombre.CheckedChanged
        REFRESCAR()
        TXT_BuscarProd.Focus()
    End Sub

    Private Sub RDB_BuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RDB_BuscarCodigo.CheckedChanged
        REFRESCAR()
        TXT_BuscarProd.Focus()
    End Sub
End Class