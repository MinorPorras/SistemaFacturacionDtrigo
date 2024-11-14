Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class E_NuevoProducto
    Friend idProd As String
    Friend ModProd As Boolean = False
    Friend CodigoPreMod As String
    Friend precioBase As Double
    Friend impuesto As Double
    Friend ganancia As Double
    Friend precioVenta As Double
    Friend Inicializando As Boolean = True
    Dim actpVenta As Boolean = False
    Dim actGan = False
    Private Sub BTN_RegresarProv_Click(sender As Object, e As EventArgs) Handles BTN_RegresarProv.Click
        ModProd = False
        Me.Close()
    End Sub

    Private Sub E_NuevoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ModProd = False Then
            idProd = OBTENERPK("producto", "ID")
        End If

    End Sub

    Private Sub VALIDAR()
        ' Si el texto no está vacío en el textbox habilita el botón de guardar/agregar
        If TXT_Cod.Text <> "" And TXT_Nombre.Text <> "" And TXT_PrecioVenta.Text <> "" Then
            BTN_NProv.Enabled = True
        Else
            BTN_NProv.Enabled = False
        End If

    End Sub

    Private Sub TXT_Marca_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Marca.MouseDoubleClick
        B_Marca.caso = "NProd"
        B_Marca.Show()
    End Sub

    Private Sub TXT_Proveedor_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Proveedor.MouseDoubleClick
        B_Proveedor.caso = "NProd"
        B_Proveedor.Show()
    End Sub

    Private Sub TXT_Categoria_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Categoria.MouseDoubleClick
        B_Categoria.caso = "NProd"
        B_Categoria.Show()
    End Sub

    Private Sub TXT_Impuesto_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TXT_Impuesto.MouseDoubleClick
        B_Impuesto.caso = "NProd"
        B_Impuesto.Show()
    End Sub

    Private Sub BTN_NProv_Click(sender As Object, e As EventArgs) Handles BTN_NProv.Click
        If TXT_Cod.Text <> "" And TXT_Nombre.Text <> "" And TXT_PrecioVenta.Text <> "" Then
            Try
                T.Tables.Clear()
                If ModProd = False Then
                    SQL = "SELECT ID " &
                            "FROM producto " &
                            "WHERE codigo = '" & TXT_Cod.Text + "'"
                Else
                    If TXT_Cod.Text = CodigoPreMod Then
                        SQL = "SELECT ID FROM producto WHERE ID = 0"
                    Else
                        SQL = "SELECT ID " &
                              "FROM producto " &
                              "WHERE codigo = '" & TXT_Cod.Text + "'"
                    End If
                End If
                Cargar_Tabla(T, SQL)
                If T.Tables(0).Rows.Count = 0 Then
                    ActualizarProgressBar(10)
                    ' Comprobación de que se quiere modificar la información en la base de datos por parte del usuario
                    If MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ActualizarProgressBar(10)
                        Try
                            If ModProd = False Then
                                ' Si la PK que esté guardada en IdCat no existe en la base de datos en esa tabla...
                                If EXISTEPK("producto", "ID", idProd) = False Then ' Si no se ha guardado la categoría
                                    ' Guarda la PK almacenada en IdCat dentro de la Base de datos en la tabla y PK indicado
                                    GUARDAR_PK("producto", "ID", idProd)
                                End If
                            End If
                            ActualizarProgressBar(10)

                            ' Actualizar los campos en la base de datos
                            GUARDAR_STR("producto", "codigo", TXT_Cod.Text, "ID", idProd)

                            GUARDAR_STR("producto", "nombre", TXT_Nombre.Text, "ID", idProd)

                            If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                                Dim precioB = Replace(TXT_PrecioBase.Text, ",", ".")
                                GUARDAR_DOUBLE("producto", "precio_base", precioB, "ID", idProd)
                            Else
                                GUARDAR_DOUBLE("producto", "precio_base", 0, "ID", idProd)
                            End If
                            ActualizarProgressBar(10)

                            If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                                Dim impP = Replace(TXT_Impuesto.Text, ",", ".")

                                GUARDAR_DOUBLE("producto", "porc_impuesto", impP, "ID", idProd)
                            Else
                                GUARDAR_DOUBLE("producto", "porc_impuesto", 0, "ID", idProd)
                            End If

                            If CKB_variable.Checked = True Then
                                GUARDAR_INT("producto", "variable", 1, "ID", idProd)
                            Else
                                GUARDAR_INT("producto", "variable", 0, "ID", idProd)
                            End If

                            T.Tables.Clear()
                            SQL = "SELECT ID_Producto FROM producto_precioVenta WHERE ID_Producto = " + idProd
                            Cargar_Tabla(T, SQL)
                            If T.Tables(0).Rows.Count <= 0 Then
                                GUARDAR_VarCompuestasDouble("producto_precioVenta", idProd, 0R)
                            Else
                                Dim precioV As String
                                If String.IsNullOrEmpty(TXT_PrecioVenta.Text) Then
                                    precioV = 0
                                Else
                                    precioV = Replace(TXT_PrecioVenta.Text, ",", ".")
                                End If
                                GUARDAR_DOUBLE("producto_precioVenta", "precio_venta", precioV, "ID_Producto", idProd)

                            End If

                            ActualizarProgressBar(10)

                            If Not String.IsNullOrEmpty(TXT_Ganancia.Text) Then
                                Dim ganancia = Replace(TXT_Ganancia.Text, ",", ".")
                                GUARDAR_DOUBLE("producto", "ganancia", ganancia, "ID", idProd)
                            Else
                                GUARDAR_DOUBLE("producto", "ganancia", 0, "ID", idProd)
                            End If

                            If CKB_Fav.Checked = True Then
                                GUARDAR_STR("producto", "favorito", "Si", "ID", idProd)
                            Else
                                GUARDAR_STR("producto", "favorito", "No", "ID", idProd)
                            End If
                            ActualizarProgressBar(10)
                            'Se agregan los campos en las tablas relacionadas en caso de ser necesario


                            ActualizarProgressBar(10)

                            If Not String.IsNullOrEmpty(TXT_Desc.Text) Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Producto FROM producto_desc WHERE ID_Producto = " + idProd
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    GUARDAR_VarCompuestas("producto_desc", idProd, TXT_Desc.Text)
                                Else
                                    GUARDAR_STR("producto_desc", "descripcion", TXT_Desc.Text, "ID_Producto", idProd)
                                End If
                            End If

                            If Not String.IsNullOrEmpty(LBL_IDCat.Text) And LBL_IDCat.Text <> "idCat" Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Producto FROM producto_categoria WHERE ID_Producto = " + idProd
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    Dim idCat As Integer
                                    If Integer.TryParse(LBL_IDCat.Text, idCat) Then
                                        GUARDAR_VarComp2Int("producto_categoria", idProd, idCat)
                                    Else
                                        MsgBox("No se logró almacenar la categoría, vuelva a intentarlo", vbInformation + vbOKOnly, "Proveedor no guardads")
                                    End If
                                Else
                                    GUARDAR_STR("producto_categoria", "ID_Categoria", LBL_IDCat.Text, "ID_Producto", idProd)
                                End If
                            End If

                            ActualizarProgressBar(10)

                            If Not String.IsNullOrEmpty(LBL_IDMarca.Text) And LBL_IDMarca.Text <> "idMarca" Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Producto FROM producto_marca WHERE ID_Producto = " + idProd
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    Dim idMarca As Integer
                                    If Integer.TryParse(LBL_IDMarca.Text, idMarca) Then
                                        GUARDAR_VarComp2Int("producto_marca", idProd, idMarca)
                                    Else
                                        MsgBox("No se logró almacenar la marca, vuelva a intentarlo", vbInformation + vbOKOnly, "Marca no guardada")
                                    End If
                                Else
                                    GUARDAR_STR("producto_marca", "ID_Marca", LBL_IDMarca.Text, "ID_Producto", idProd)
                                End If
                            End If

                            If Not String.IsNullOrEmpty(LBL_Prov.Text) And LBL_Prov.Text <> "idProv" Then
                                T.Tables.Clear()
                                SQL = "SELECT ID_Producto FROM producto_proveedor WHERE ID_Producto = " + idProd
                                Cargar_Tabla(T, SQL)
                                If T.Tables(0).Rows.Count <= 0 Then
                                    Dim idProv As Integer
                                    If Integer.TryParse(LBL_Prov.Text, idProv) Then
                                        GUARDAR_VarComp2Int("producto_proveedor", idProd, idProv)
                                    Else
                                        MsgBox("No se logró almacenar el proveedor, vuelva a intentarlo", vbInformation + vbOKOnly, "Proveedor no guardads")
                                    End If
                                Else
                                    GUARDAR_STR("producto_proveedor", "ID_Proveedor", LBL_Prov.Text, "ID_Producto", idProd)
                                End If
                            End If

                            ActualizarProgressBar(20)

                            LIMPIAR()
                            MsgBox("Datos almacenados satisfactoriamente", vbInformation + vbOKOnly, "Transacción exitosa")
                            ' Muestra y refresca la pantalla del list view de Sucursales y cierra esta
                            P_Productos.Show()
                            P_Productos.REFRESCAR()
                            pBar_guardar.Value = 100
                            Me.Close()
                        Catch ex As Exception
                            MsgBox("Error al actualizar los datos: " & ex.Message, vbCritical + vbOKOnly, "Error")
                        End Try
                    End If
                Else
                    MsgBox("El código " + TXT_Cod.Text + " ya existe, coloque un código distinto", vbCritical + vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
            pBar_guardar.Value = 0
            ModProd = False
        End If
    End Sub
    Private Sub ActualizarProgressBar(paso As Integer)
        If pBar_guardar.Value + paso <= pBar_guardar.Maximum Then
            pBar_guardar.Value += paso
        Else
            pBar_guardar.Value = pBar_guardar.Maximum
        End If
    End Sub


    Private Sub LIMPIAR()
        TXT_PrecioBase.Text = "0"
        TXT_Impuesto.Text = "0"
        TXT_Ganancia.Text = "0"
        TXT_PrecioVenta.Text = "0"
        TXT_Cod.Clear()
        TXT_Nombre.Clear()
        TXT_Desc.Clear()
        TXT_Marca.Clear()
        TXT_Proveedor.Clear()
        TXT_Categoria.Clear()
        LBL_IDCat.Text = "idCat"
        LBL_IDMarca.Text = "idMarca"
        LBL_Prov.Text = "idProv"
        pBar_guardar.Value = 0
    End Sub

    Private Sub TXT_Cod_TextChanged(sender As Object, e As EventArgs) Handles TXT_Cod.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_CodBarra_TextChanged(sender As Object, e As EventArgs)
        VALIDAR()
    End Sub

    Private Sub TXT_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TXT_Nombre.TextChanged
        VALIDAR()
    End Sub

    Private Sub TXT_PrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioVenta.TextChanged
        If CKB_variable.Checked = False Then
            VALIDAR()
            If actpVenta Then
                actGan = False
                Try
                    Dim precioB As Double = 0
                    Dim precioV As Double = 0
                    Dim impP As Double = 0

                    If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                        precioB = Convert.ToDouble(TXT_PrecioBase.Text)
                    End If

                    If Not String.IsNullOrEmpty(TXT_PrecioVenta.Text) Then
                        precioV = Convert.ToDouble(TXT_PrecioVenta.Text)
                    End If

                    If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                        impP = Convert.ToDouble(TXT_Impuesto.Text)
                    End If

                    ' Calcular el impuesto como un porcentaje del precio base
                    Dim impuesto As Double = precioB * (impP / 100)
                    Dim BaseImp As Double = precioB + impuesto

                    ' Calcular el porcentaje de ganancia
                    If BaseImp <> 0 Then
                        TXT_Ganancia.Text = (((precioV - BaseImp) / BaseImp) * 100).ToString("F2")
                    Else
                        TXT_Ganancia.Text = "0"
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
                End Try
                actGan = True
            End If
        End If
    End Sub

    Private Sub TXT_PrecioBase_TextChanged(sender As Object, e As EventArgs) Handles TXT_PrecioBase.TextChanged
        VALIDAR()
        calculoPrecioVenta()

    End Sub

    Private Sub TXT_Impuesto_TextChanged(sender As Object, e As EventArgs) Handles TXT_Impuesto.TextChanged
        VALIDAR()
        calculoPrecioVenta()
    End Sub

    Private Sub TXT_Ganan1cia_TextChanged(sender As Object, e As EventArgs) Handles TXT_Ganancia.TextChanged
        VALIDAR()
        If actGan Then
            calculoPrecioVenta()
        End If
    End Sub

    Private Sub calculoPrecioVenta()
        If CKB_variable.Checked = False Then
            actpVenta = False
            Try
                Dim precioB As Double = 0
                Dim ganP As Double = 0
                Dim impP As Double = 0

                If Not String.IsNullOrEmpty(TXT_PrecioBase.Text) Then
                    precioB = Convert.ToDouble(TXT_PrecioBase.Text)
                End If

                If Not String.IsNullOrEmpty(TXT_Ganancia.Text) Then
                    ganP = Convert.ToDouble(TXT_Ganancia.Text)
                End If

                If Not String.IsNullOrEmpty(TXT_Impuesto.Text) Then
                    impP = Convert.ToDouble(TXT_Impuesto.Text)
                End If

                ' Calcular la ganancia y el impuesto correctamente
                Dim ganancia As Double = precioB * (ganP / 100)
                Dim impuesto As Double = precioB * (impP / 100) ' Era necesario calcular el impuesto como porcentaje del precio base

                ' Calcular el precio de venta
                TXT_PrecioVenta.Text = (precioB + ganancia + impuesto).ToString("F2") ' "F2" para mostrar dos decimales
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, vbCritical + vbOKOnly, "Error")
            End Try
            actpVenta = True
        End If
    End Sub
    Private Sub CKB_Fav_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_Fav.CheckedChanged
        If CKB_Fav.Checked = True Then
            SQL = "SELECT COUNT(ID) FROM producto WHERE favorito = 'Si'"
            If ModProd Then
                SQL += " AND ID <> " + idProd
            End If
            T.Tables.Clear()
            Cargar_Tabla(T, SQL)
            If T.Tables(0).Rows(0).Item(0) >= 8 Then
                MsgBox("Solo puede tener un máximo de 10 productos en favorito" + vbCrLf + "Elimine el favorito de otro producto para agregar este", vbCritical + vbOKOnly, "Limite de favoritos alcanzado")
                CKB_Fav.Checked = False
            End If
        End If
    End Sub

    Private Sub CKB_variable_CheckedChanged(sender As Object, e As EventArgs) Handles CKB_variable.CheckedChanged
        If CKB_variable.Checked = True Then
            TXT_PrecioVenta.Enabled = False
            TXT_Ganancia.Enabled = False
            TXT_Impuesto.Enabled = False
            TXT_PrecioVenta.Text = "0,00"
            TXT_Ganancia.Text = "0"
            TXT_Impuesto.Text = "0"
        Else
            TXT_PrecioVenta.Enabled = True
            TXT_Ganancia.Enabled = True
            TXT_Impuesto.Enabled = True
        End If
    End Sub
End Class