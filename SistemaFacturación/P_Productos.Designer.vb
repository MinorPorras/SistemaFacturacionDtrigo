<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Productos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Productos))
        Me.BTN_NProd = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDB_BuscarNombre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_BuscarCodigo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LSV_Prod = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.precio_base = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.porcentaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ganancia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.precio_venta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Categoría = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.categoria = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Marca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.marca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID_Proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.proveedor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.favorito = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarProd = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CKB_Marca = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CKB_Proveedor = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.CKB_Categoria = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.TXT_BuscarMarca = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_BuscarProv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_BuscarCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MNU_CONTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_NProd
        '
        Me.BTN_NProd.BorderColor = System.Drawing.Color.Red
        Me.BTN_NProd.BorderRadius = 25
        Me.BTN_NProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NProd.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NProd.ForeColor = System.Drawing.Color.White
        Me.BTN_NProd.Image = CType(resources.GetObject("BTN_NProd.Image"), System.Drawing.Image)
        Me.BTN_NProd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NProd.Location = New System.Drawing.Point(771, 584)
        Me.BTN_NProd.Name = "BTN_NProd"
        Me.BTN_NProd.Size = New System.Drawing.Size(464, 57)
        Me.BTN_NProd.TabIndex = 51
        Me.BTN_NProd.Text = "Agregar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarNombre)
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarCodigo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(1037, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(122, 63)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de busqueda"
        '
        'RDB_BuscarNombre
        '
        Me.RDB_BuscarNombre.AutoSize = True
        Me.RDB_BuscarNombre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarNombre.CheckedState.BorderThickness = 0
        Me.RDB_BuscarNombre.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarNombre.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_BuscarNombre.CheckedState.InnerOffset = -4
        Me.RDB_BuscarNombre.ForeColor = System.Drawing.Color.White
        Me.RDB_BuscarNombre.Location = New System.Drawing.Point(29, 19)
        Me.RDB_BuscarNombre.Name = "RDB_BuscarNombre"
        Me.RDB_BuscarNombre.Size = New System.Drawing.Size(62, 17)
        Me.RDB_BuscarNombre.TabIndex = 36
        Me.RDB_BuscarNombre.Text = "Nombre"
        Me.RDB_BuscarNombre.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_BuscarNombre.UncheckedState.BorderThickness = 2
        Me.RDB_BuscarNombre.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_BuscarNombre.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'RDB_BuscarCodigo
        '
        Me.RDB_BuscarCodigo.AutoSize = True
        Me.RDB_BuscarCodigo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarCodigo.CheckedState.BorderThickness = 0
        Me.RDB_BuscarCodigo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarCodigo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_BuscarCodigo.CheckedState.InnerOffset = -4
        Me.RDB_BuscarCodigo.ForeColor = System.Drawing.Color.White
        Me.RDB_BuscarCodigo.Location = New System.Drawing.Point(29, 42)
        Me.RDB_BuscarCodigo.Name = "RDB_BuscarCodigo"
        Me.RDB_BuscarCodigo.Size = New System.Drawing.Size(58, 17)
        Me.RDB_BuscarCodigo.TabIndex = 37
        Me.RDB_BuscarCodigo.Text = "Codigo"
        Me.RDB_BuscarCodigo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_BuscarCodigo.UncheckedState.BorderThickness = 2
        Me.RDB_BuscarCodigo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_BuscarCodigo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'LSV_Prod
        '
        Me.LSV_Prod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Prod.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.codigo, Me.nombre, Me.descripcion, Me.precio_base, Me.porcentaje, Me.ganancia, Me.precio_venta, Me.ID_Categoría, Me.categoria, Me.ID_Marca, Me.marca, Me.ID_Proveedor, Me.proveedor, Me.favorito})
        Me.LSV_Prod.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Prod.FullRowSelect = True
        Me.LSV_Prod.GridLines = True
        Me.LSV_Prod.HideSelection = False
        Me.LSV_Prod.Location = New System.Drawing.Point(7, 175)
        Me.LSV_Prod.MultiSelect = False
        Me.LSV_Prod.Name = "LSV_Prod"
        Me.LSV_Prod.Size = New System.Drawing.Size(1256, 387)
        Me.LSV_Prod.TabIndex = 49
        Me.LSV_Prod.UseCompatibleStateImageBehavior = False
        Me.LSV_Prod.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'codigo
        '
        Me.codigo.Text = "Codigo"
        Me.codigo.Width = 53
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        '
        'descripcion
        '
        Me.descripcion.Text = "Descripción"
        Me.descripcion.Width = 292
        '
        'precio_base
        '
        Me.precio_base.Text = "Precio base"
        Me.precio_base.Width = 102
        '
        'porcentaje
        '
        Me.porcentaje.Text = "Impuesto"
        '
        'ganancia
        '
        Me.ganancia.Text = "Ganancia"
        '
        'precio_venta
        '
        Me.precio_venta.Text = "Precio de venta"
        Me.precio_venta.Width = 111
        '
        'ID_Categoría
        '
        Me.ID_Categoría.Text = "ID_Categoría"
        Me.ID_Categoría.Width = 88
        '
        'categoria
        '
        Me.categoria.Text = "Categoria"
        Me.categoria.Width = 117
        '
        'ID_Marca
        '
        Me.ID_Marca.Text = "ID_Marca"
        Me.ID_Marca.Width = 72
        '
        'marca
        '
        Me.marca.Text = "Marca"
        Me.marca.Width = 107
        '
        'ID_Proveedor
        '
        Me.ID_Proveedor.Text = "ID_Proveedor"
        Me.ID_Proveedor.Width = 107
        '
        'proveedor
        '
        Me.proveedor.Text = "Proveedor"
        Me.proveedor.Width = 125
        '
        'favorito
        '
        Me.favorito.Text = "Favorito"
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_MODIFICAR, Me.MNU_ELIMINAR})
        Me.MNU_CONTX.Name = "MNU_CONTX"
        Me.MNU_CONTX.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.ColorTable = Nothing
        Me.MNU_CONTX.RenderStyle.RoundedEdges = True
        Me.MNU_CONTX.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MNU_CONTX.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MNU_CONTX.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.MNU_CONTX.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.MNU_CONTX.Size = New System.Drawing.Size(126, 48)
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(125, 22)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(125, 22)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
        '
        'BTN_RegresarProd
        '
        Me.BTN_RegresarProd.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarProd.BorderRadius = 25
        Me.BTN_RegresarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarProd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarProd.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarProd.Image = CType(resources.GetObject("BTN_RegresarProd.Image"), System.Drawing.Image)
        Me.BTN_RegresarProd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarProd.Location = New System.Drawing.Point(42, 584)
        Me.BTN_RegresarProd.Name = "BTN_RegresarProd"
        Me.BTN_RegresarProd.Size = New System.Drawing.Size(458, 57)
        Me.BTN_RegresarProd.TabIndex = 48
        Me.BTN_RegresarProd.Text = "Regresar"
        '
        'TXT_BuscarProd
        '
        Me.TXT_BuscarProd.BorderRadius = 20
        Me.TXT_BuscarProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProd.DefaultText = ""
        Me.TXT_BuscarProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProd.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.IconRight = CType(resources.GetObject("TXT_BuscarProd.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarProd.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarProd.Location = New System.Drawing.Point(42, 21)
        Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
        Me.TXT_BuscarProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProd.PlaceholderText = "Buscar producto"
        Me.TXT_BuscarProd.SelectedText = ""
        Me.TXT_BuscarProd.Size = New System.Drawing.Size(989, 42)
        Me.TXT_BuscarProd.TabIndex = 47
        '
        'CerrarApp
        '
        Me.CerrarApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarApp.FillColor = System.Drawing.Color.SandyBrown
        Me.CerrarApp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CerrarApp.ForeColor = System.Drawing.Color.White
        Me.CerrarApp.Image = CType(resources.GetObject("CerrarApp.Image"), System.Drawing.Image)
        Me.CerrarApp.ImageSize = New System.Drawing.Size(90, 90)
        Me.CerrarApp.Location = New System.Drawing.Point(1197, 11)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 45
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(425, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 23)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Proveedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(854, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Categoría:"
        '
        'CKB_Marca
        '
        Me.CKB_Marca.AutoSize = True
        Me.CKB_Marca.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Marca.CheckedState.BorderRadius = 0
        Me.CKB_Marca.CheckedState.BorderThickness = 0
        Me.CKB_Marca.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Marca.ForeColor = System.Drawing.Color.White
        Me.CKB_Marca.Location = New System.Drawing.Point(129, 128)
        Me.CKB_Marca.Name = "CKB_Marca"
        Me.CKB_Marca.Size = New System.Drawing.Size(159, 17)
        Me.CKB_Marca.TabIndex = 62
        Me.CKB_Marca.Text = "Activar busqueda por marca"
        Me.CKB_Marca.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CKB_Marca.UncheckedState.BorderRadius = 0
        Me.CKB_Marca.UncheckedState.BorderThickness = 0
        Me.CKB_Marca.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CKB_Proveedor
        '
        Me.CKB_Proveedor.AutoSize = True
        Me.CKB_Proveedor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Proveedor.CheckedState.BorderRadius = 0
        Me.CKB_Proveedor.CheckedState.BorderThickness = 0
        Me.CKB_Proveedor.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Proveedor.ForeColor = System.Drawing.Color.White
        Me.CKB_Proveedor.Location = New System.Drawing.Point(551, 128)
        Me.CKB_Proveedor.Name = "CKB_Proveedor"
        Me.CKB_Proveedor.Size = New System.Drawing.Size(178, 17)
        Me.CKB_Proveedor.TabIndex = 63
        Me.CKB_Proveedor.Text = "Activar busqueda por proveedor"
        Me.CKB_Proveedor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CKB_Proveedor.UncheckedState.BorderRadius = 0
        Me.CKB_Proveedor.UncheckedState.BorderThickness = 0
        Me.CKB_Proveedor.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'CKB_Categoria
        '
        Me.CKB_Categoria.AutoSize = True
        Me.CKB_Categoria.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Categoria.CheckedState.BorderRadius = 0
        Me.CKB_Categoria.CheckedState.BorderThickness = 0
        Me.CKB_Categoria.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Categoria.ForeColor = System.Drawing.Color.White
        Me.CKB_Categoria.Location = New System.Drawing.Point(983, 128)
        Me.CKB_Categoria.Name = "CKB_Categoria"
        Me.CKB_Categoria.Size = New System.Drawing.Size(176, 17)
        Me.CKB_Categoria.TabIndex = 64
        Me.CKB_Categoria.Text = "Activar busqueda por categoría"
        Me.CKB_Categoria.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CKB_Categoria.UncheckedState.BorderRadius = 0
        Me.CKB_Categoria.UncheckedState.BorderThickness = 0
        Me.CKB_Categoria.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'TXT_BuscarMarca
        '
        Me.TXT_BuscarMarca.BorderRadius = 20
        Me.TXT_BuscarMarca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarMarca.DefaultText = ""
        Me.TXT_BuscarMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarMarca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarMarca.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarMarca.Location = New System.Drawing.Point(116, 80)
        Me.TXT_BuscarMarca.Name = "TXT_BuscarMarca"
        Me.TXT_BuscarMarca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarMarca.PlaceholderText = "Buscar marca"
        Me.TXT_BuscarMarca.SelectedText = ""
        Me.TXT_BuscarMarca.Size = New System.Drawing.Size(257, 42)
        Me.TXT_BuscarMarca.TabIndex = 65
        '
        'TXT_BuscarProv
        '
        Me.TXT_BuscarProv.BorderRadius = 20
        Me.TXT_BuscarProv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProv.DefaultText = ""
        Me.TXT_BuscarProv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProv.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProv.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProv.Location = New System.Drawing.Point(540, 80)
        Me.TXT_BuscarProv.Name = "TXT_BuscarProv"
        Me.TXT_BuscarProv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProv.PlaceholderText = "Buscar proveedor"
        Me.TXT_BuscarProv.SelectedText = ""
        Me.TXT_BuscarProv.Size = New System.Drawing.Size(256, 42)
        Me.TXT_BuscarProv.TabIndex = 66
        '
        'TXT_BuscarCat
        '
        Me.TXT_BuscarCat.BorderRadius = 20
        Me.TXT_BuscarCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarCat.DefaultText = ""
        Me.TXT_BuscarCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCat.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarCat.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCat.Location = New System.Drawing.Point(965, 80)
        Me.TXT_BuscarCat.Name = "TXT_BuscarCat"
        Me.TXT_BuscarCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarCat.PlaceholderText = "Buscar categoría"
        Me.TXT_BuscarCat.SelectedText = ""
        Me.TXT_BuscarCat.Size = New System.Drawing.Size(234, 42)
        Me.TXT_BuscarCat.TabIndex = 67
        '
        'P_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarProd
        Me.ClientSize = New System.Drawing.Size(1280, 665)
        Me.Controls.Add(Me.TXT_BuscarCat)
        Me.Controls.Add(Me.TXT_BuscarProv)
        Me.Controls.Add(Me.TXT_BuscarMarca)
        Me.Controls.Add(Me.CKB_Categoria)
        Me.Controls.Add(Me.CKB_Proveedor)
        Me.Controls.Add(Me.CKB_Marca)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_NProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LSV_Prod)
        Me.Controls.Add(Me.BTN_RegresarProd)
        Me.Controls.Add(Me.TXT_BuscarProd)
        Me.Controls.Add(Me.CerrarApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_NProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_BuscarNombre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_BuscarCodigo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LSV_Prod As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents descripcion As ColumnHeader
    Friend WithEvents precio_base As ColumnHeader
    Friend WithEvents BTN_RegresarProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents porcentaje As ColumnHeader
    Friend WithEvents precio_venta As ColumnHeader
    Friend WithEvents ID_Marca As ColumnHeader
    Friend WithEvents marca As ColumnHeader
    Friend WithEvents ID_Proveedor As ColumnHeader
    Friend WithEvents proveedor As ColumnHeader
    Friend WithEvents ID_Categoría As ColumnHeader
    Friend WithEvents categoria As ColumnHeader
    Friend WithEvents favorito As ColumnHeader
    Friend WithEvents CKB_Categoria As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CKB_Proveedor As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents CKB_Marca As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents TXT_BuscarMarca As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_BuscarCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_BuscarProv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ganancia As ColumnHeader
End Class
