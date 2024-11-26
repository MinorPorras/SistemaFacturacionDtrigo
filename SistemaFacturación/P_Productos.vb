Imports System.Threading.Tasks
Public Class P_Productos
    Private stringConsultaBase As String = "SELECT p.ID AS [ID], p.codigo AS [Código], p.nombre AS [Producto], d.descripcion AS [Descripción], " &
                          "p.precio_base AS [Precio base], p.porc_impuesto AS [Impuesto], p.ganancia AS [Ganancia], " &
                          "pv.precio_venta AS [P Venta], " &
                          "IIf(p.variable=1, 'Si', 'No') AS [Var], " &
                          "c.ID_Categoria AS [ID_cat], cat.nombre AS [Categoría], " &
                          "pm.ID_Marca AS [ID_Marca], m.Nombre AS [Marca], pp.ID_Proveedor AS [ID_Prov], " &
                          "pr.nombre AS [Proveedor], p.inventario as [Existencias], p.favorito AS [Fav] " &
                          "FROM ((((((((producto p " &
                          "LEFT JOIN producto_categoria c ON p.ID = c.ID_Producto) " &
                          "LEFT JOIN categoria cat ON c.ID_Categoria = cat.ID) " &
                          "LEFT JOIN producto_marca pm ON p.ID = pm.ID_Producto) " &
                          "LEFT JOIN marca m ON m.ID = pm.ID_Marca) " &
                          "LEFT JOIN producto_proveedor pp ON p.ID = pp.ID_Producto) " &
                          "LEFT JOIN proveedor pr ON pp.ID_Proveedor = pr.ID) " &
                          "LEFT JOIN producto_desc d ON p.ID = d.ID_Producto) " &
                          "LEFT JOIN producto_precioVenta pv ON pv.ID_Producto = p.ID)"
    Private searchTimer As Timer

    ' Método para inicializar el temporizador y otros componentes necesarios
    Private Sub InicializarComponentes()
        ' Inicializar el temporizador
        searchTimer = New Timer()
        searchTimer.Interval = 300
        ' Medio segundo
        AddHandler searchTimer.Tick, AddressOf OnSearchTimerTick
    End Sub

    Private Sub OnSearchTimerTick(sender As Object, e As EventArgs)
        ' Detener el temporizador y ejecutar la búsqueda
        searchTimer.Stop()
        REFRESCAR()
    End Sub

    Private Sub P_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InicializarComponentes()
        cargarPestaña()
    End Sub

    Friend Sub cargarPestaña()
        CKB_Categoria.Checked = False
        CKB_Marca.Checked = False
        CKB_Proveedor.Checked = False
        TXT_BuscarMarca.Enabled = False
        TXT_BuscarCat.Enabled = False
        TXT_BuscarProv.Enabled = False
        REFRESCAR()
    End Sub

    Public Sub REFRESCAR()
        Task.Run(Sub()
                     Try
                         Dim selectedRowIndex As Integer = -1
                         If DGV_Prods.SelectedRows.Count > 0 Then
                             selectedRowIndex = DGV_Prods.SelectedRows(0).Index
                         End If
                         ' Se vuelven invisibles el menú contextual en caso de que no haya nada en la tabla
                         Invoke(Sub()
                                    MNU_ELIMINAR.Visible = False
                                    MNU_MODIFICAR.Visible = False
                                End Sub)
                         ' Se limpia todo en la tabla
                         T.Tables.Clear()

                         ' Declaración de variables para búsqueda con el query
                         Dim cat As String = ""
                         Dim Prov As String = ""
                         Dim Marca As String = ""

                         ' Se verifica que el checkbox de buscar por categoría esté seleccionado
                         If CKB_Categoria.Checked = True AndAlso TXT_BuscarCat.Text <> "" Then
                             cat = "AND cat.nombre LIKE '%" & TXT_BuscarCat.Text & "%' "
                         End If

                         ' Se verifica que el checkbox de buscar por marca esté seleccionado
                         If CKB_Marca.Checked = True AndAlso TXT_BuscarMarca.Text <> "" Then
                             Marca = "AND m.nombre LIKE '%" & TXT_BuscarMarca.Text & "%' "
                         End If

                         ' Se verifica que el checkbox de buscar por proveedor esté seleccionado
                         If CKB_Proveedor.Checked = True AndAlso TXT_BuscarProv.Text <> "" Then
                             Prov = "AND pr.nombre LIKE '%" & TXT_BuscarProv.Text & "%' "
                         End If

                         ' Construcción del query basado en si se busca por código o por nombre
                         SQL = stringConsultaBase + " WHERE (p.nombre LIKE '%" & TXT_BuscarProd.Text & "%' OR p.codigo LIKE '%" & TXT_BuscarProd.Text & "%') " & cat & Marca & Prov & " ORDER BY Val(p.codigo) ASC;"

                         ' Luego de cargar los datos, actualizar la interfaz de usuario de manera segura 
                         Invoke(Sub()
                                    ' Cargar los datos en la tabla
                                    Cargar_Tabla(T, SQL)
                                    If T.Tables.Count > 0 AndAlso T.Tables(0).Rows.Count > 0 Then
                                        DGV_Prods.Columns.Clear()
                                        Dim bin As New BindingSource
                                        bin.DataSource = T.Tables(0)
                                        DGV_Prods.DataSource = bin
                                        If selectedRowIndex >= 0 AndAlso selectedRowIndex < DGV_Prods.Rows.Count Then
                                            DGV_Prods.Rows(selectedRowIndex).Selected = True
                                            DGV_Prods.FirstDisplayedScrollingRowIndex = selectedRowIndex
                                        End If
                                        If T.Tables(0).Rows.Count > 0 Then
                                            MNU_ELIMINAR.Visible = True
                                            MNU_MODIFICAR.Visible = True
                                        End If
                                        AddHandler DGV_Prods.DataBindingComplete, AddressOf DGV_Prods_DataBindingComplete
                                    Else ' Limpiar la fuente de datos si no se cargaron datos
                                        DGV_Prods.DataSource = Nothing
                                    End If
                                    TXT_BuscarProd.Select()
                                End Sub)
                     Catch ex As Exception
                         If DGV_Prods.IsHandleCreated Then
                             Invoke(Sub()
                                        If ex.Message <> "InvalidArgument=El valor de '0' no es válido para 'index'." & vbCrLf & "Nombre del parámetro: index" Then
                                            MsgBox("Error al cargar la lista de productos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                                        End If
                                    End Sub)
                         End If
                     End Try
                 End Sub)
    End Sub


    ' Método para manejar el evento DataBindingComplete
    Private Sub DGV_Prods_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_Prods.DataBindingComplete
        Try
            For i As Integer = 0 To DGV_Prods.Columns.Count - 1
                DGV_Prods.Columns(i).ReadOnly = True
                Select Case i
                    Case 1
                        DGV_Prods.Columns(i).Width = 80
                    Case 2
                        DGV_Prods.Columns(i).Width = 200
                    Case 3
                        DGV_Prods.Columns(i).Width = 350
                    Case 4
                        DGV_Prods.Columns(i).Width = 60
                    Case 6
                        DGV_Prods.Columns(i).Width = 30
                    Case 8
                        DGV_Prods.Columns(i).Width = 45
                    Case 10
                        DGV_Prods.Columns(i).Width = 70
                    Case 12
                        DGV_Prods.Columns(i).Width = 70
                    Case 14
                        DGV_Prods.Columns(i).Width = 70
                    Case 15
                        DGV_Prods.Columns(i).Width = 70
                    Case 16
                        DGV_Prods.Columns(i).Width = 30
                End Select
            Next
            DGV_Prods.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DGV_Prods.AutoResizeColumn(DataGridViewAutoSizeColumnMode.DisplayedCells)
            DGV_Prods.Columns(4).DefaultCellStyle.Format = "#,##"
            DGV_Prods.Columns(7).DefaultCellStyle.Format = "#,##"
            DGV_Prods.GridColor = Color.DarkGray
            DGV_Prods.Columns(0).Visible = False
            DGV_Prods.Columns(5).Visible = False
            DGV_Prods.Columns(6).Visible = False
            DGV_Prods.Columns(9).Visible = False
            DGV_Prods.Columns(11).Visible = False
            DGV_Prods.Columns(13).Visible = False
        Catch ex As Exception
            ' Manejar el error si alguna columna no existe
            Console.WriteLine("Error al ocultar las columnas: " & ex.Message)
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
            TXT_BuscarMarca.Select()
            TXT_BuscarMarca.Enabled = True
        End If
    End Sub

    Private Sub CKB_Proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Proveedor.CheckedChanged
        If CKB_Proveedor.Checked = False Then
            TXT_BuscarProv.Text = ""
            TXT_BuscarProv.Enabled = False
        Else
            TXT_BuscarProv.Enabled = True
            TXT_BuscarProv.Select()
        End If
    End Sub

    Private Sub CKB_Categoria_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Categoria.CheckedChanged
        If CKB_Categoria.Checked = False Then
            TXT_BuscarCat.Text = ""
            TXT_BuscarCat.Enabled = False
        Else
            TXT_BuscarCat.Enabled = True
            TXT_BuscarCat.Select()
        End If
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

    Private Sub MNU_MODIFICAR_Click(sender As Object, e As EventArgs) Handles MNU_MODIFICAR.Click
        Try
            E_NuevoProducto.ModProd = True
            E_NuevoProducto.idProd = DGV_Prods.SelectedRows(0).Cells(0).Value.ToString()
            E_NuevoProducto.TXT_Cod.Text = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProducto.TXT_Nombre.Text = DGV_Prods.SelectedRows(0).Cells(2).Value.ToString()
            E_NuevoProducto.TXT_Desc.Text = DGV_Prods.SelectedRows(0).Cells(3).Value.ToString()
            E_NuevoProducto.TXT_PrecioBase.Text = DGV_Prods.SelectedRows(0).Cells(4).Value.ToString()
            E_NuevoProducto.TXT_Impuesto.Text = DGV_Prods.SelectedRows(0).Cells(5).Value.ToString()
            E_NuevoProducto.TXT_Ganancia.Text = DGV_Prods.SelectedRows(0).Cells(6).Value.ToString()
            If DGV_Prods.SelectedRows(0).Cells(8).Value.ToString() = "Si" Then
                E_NuevoProducto.CKB_variable.Checked = True
            Else
                E_NuevoProducto.CKB_variable.Checked = False
            End If
            E_NuevoProducto.TXT_PrecioVenta.Text = DGV_Prods.SelectedRows(0).Cells(7).Value.ToString()
            E_NuevoProducto.LBL_IDCat.Text = DGV_Prods.SelectedRows(0).Cells(9).Value.ToString()
            E_NuevoProducto.TXT_Categoria.Text = DGV_Prods.SelectedRows(0).Cells(10).Value.ToString()
            E_NuevoProducto.LBL_IDMarca.Text = DGV_Prods.SelectedRows(0).Cells(11).Value.ToString()
            E_NuevoProducto.TXT_Marca.Text = DGV_Prods.SelectedRows(0).Cells(12).Value.ToString()
            E_NuevoProducto.LBL_Prov.Text = DGV_Prods.SelectedRows(0).Cells(13).Value.ToString()
            E_NuevoProducto.TXT_Proveedor.Text = DGV_Prods.SelectedRows(0).Cells(14).Value.ToString()
            If DGV_Prods.SelectedRows(0).Cells(16).Value.ToString() = "Si" Then
                E_NuevoProducto.CKB_Fav.Checked = True
            Else
                E_NuevoProducto.CKB_Fav.Checked = False
            End If
            If Not String.IsNullOrEmpty(DGV_Prods.SelectedRows(0).Cells(15).Value.ToString()) Then
                E_NuevoProducto.NUD_Inv.Value = DGV_Prods.SelectedRows(0).Cells(15).Value.ToString()
            Else
                E_NuevoProducto.NUD_Inv.Value = 0
            End If
            E_NuevoProducto.ModProd = True
            E_NuevoProducto.CodigoPreMod = DGV_Prods.SelectedRows(0).Cells(1).Value.ToString()
            E_NuevoProducto.Show()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub MNU_ELIMINAR_Click(sender As Object, e As EventArgs) Handles MNU_ELIMINAR.Click
        T.Tables.Clear()
        T1.Tables.Clear()
        Try
            If DGV_Prods.SelectedRows.Count > 0 Then
                ' Se pregunta una confirmación para eliminar el tema
                If MsgBox("¿Desea eliminar el producto: " & DGV_Prods.SelectedRows(0).Cells(2).Value.ToString() & "?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    Dim idEliminar As Integer = Convert.ToInt32(DGV_Prods.SelectedRows(0).Cells(0).Value.ToString())
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


                        SQL = "DELETE FROM producto_precioVenta WHERE ID_Producto = " & idEliminar
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
        TXT_BuscarProd.SelectAll()
    End Sub

    Private Sub MNU_HABLADOR_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TXT_BuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProd.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarProv_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarProv.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarMarca.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub TXT_BuscarCat_TextChanged(sender As Object, e As EventArgs) Handles TXT_BuscarCat.TextChanged
        If searchTimer IsNot Nothing Then
            ' Reiniciar el temporizador cada vez que se cambia el texto
            searchTimer.Stop()
            searchTimer.Start()
        End If
    End Sub

    Private Sub BTN_Hablador_Click(sender As Object, e As EventArgs) Handles BTN_Hablador.Click
        P_Hablador.Show()
        P_Hablador.Select()
        Me.Close()
    End Sub
End Class