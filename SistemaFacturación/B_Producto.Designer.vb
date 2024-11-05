<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class B_Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B_Producto))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.LBL_IDProd = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_codigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDB_BuscarNombre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_BuscarCodigo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LSV_Producto = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.precio_venta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_RegresarPrd = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_SelectProd = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_Nombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Precio = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_CantProd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_MenosCant = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_MasCant = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'LBL_IDProd
        '
        Me.LBL_IDProd.AutoSize = True
        Me.LBL_IDProd.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_IDProd.ForeColor = System.Drawing.Color.White
        Me.LBL_IDProd.Location = New System.Drawing.Point(842, 385)
        Me.LBL_IDProd.Name = "LBL_IDProd"
        Me.LBL_IDProd.Size = New System.Drawing.Size(16, 23)
        Me.LBL_IDProd.TabIndex = 96
        Me.LBL_IDProd.Text = " "
        Me.LBL_IDProd.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(530, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Codigo:"
        '
        'TXT_codigo
        '
        Me.TXT_codigo.BorderRadius = 20
        Me.TXT_codigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_codigo.DefaultText = ""
        Me.TXT_codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_codigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_codigo.Location = New System.Drawing.Point(615, 228)
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_codigo.PlaceholderText = ""
        Me.TXT_codigo.ReadOnly = True
        Me.TXT_codigo.SelectedText = ""
        Me.TXT_codigo.Size = New System.Drawing.Size(210, 42)
        Me.TXT_codigo.TabIndex = 92
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarNombre)
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarCodigo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(781, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 63)
        Me.GroupBox1.TabIndex = 91
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
        'LSV_Producto
        '
        Me.LSV_Producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Producto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.codigo, Me.nombre, Me.precio_venta})
        Me.LSV_Producto.FullRowSelect = True
        Me.LSV_Producto.GridLines = True
        Me.LSV_Producto.HideSelection = False
        Me.LSV_Producto.Location = New System.Drawing.Point(23, 212)
        Me.LSV_Producto.MultiSelect = False
        Me.LSV_Producto.Name = "LSV_Producto"
        Me.LSV_Producto.Size = New System.Drawing.Size(485, 311)
        Me.LSV_Producto.TabIndex = 90
        Me.LSV_Producto.UseCompatibleStateImageBehavior = False
        Me.LSV_Producto.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 24
        '
        'codigo
        '
        Me.codigo.Text = "Codigo"
        Me.codigo.Width = 64
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.Width = 242
        '
        'precio_venta
        '
        Me.precio_venta.Text = "Precio de venta"
        Me.precio_venta.Width = 99
        '
        'BTN_RegresarPrd
        '
        Me.BTN_RegresarPrd.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarPrd.BorderRadius = 25
        Me.BTN_RegresarPrd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarPrd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPrd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPrd.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarPrd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarPrd.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPrd.Image = CType(resources.GetObject("BTN_RegresarPrd.Image"), System.Drawing.Image)
        Me.BTN_RegresarPrd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarPrd.Location = New System.Drawing.Point(99, 545)
        Me.BTN_RegresarPrd.Name = "BTN_RegresarPrd"
        Me.BTN_RegresarPrd.Size = New System.Drawing.Size(309, 57)
        Me.BTN_RegresarPrd.TabIndex = 89
        Me.BTN_RegresarPrd.Text = "Regresar"
        '
        'BTN_SelectProd
        '
        Me.BTN_SelectProd.BorderColor = System.Drawing.Color.Red
        Me.BTN_SelectProd.BorderRadius = 25
        Me.BTN_SelectProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SelectProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SelectProd.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_SelectProd.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SelectProd.ForeColor = System.Drawing.Color.White
        Me.BTN_SelectProd.Image = CType(resources.GetObject("BTN_SelectProd.Image"), System.Drawing.Image)
        Me.BTN_SelectProd.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_SelectProd.Location = New System.Drawing.Point(535, 545)
        Me.BTN_SelectProd.Name = "BTN_SelectProd"
        Me.BTN_SelectProd.Size = New System.Drawing.Size(309, 57)
        Me.BTN_SelectProd.TabIndex = 88
        Me.BTN_SelectProd.Text = "Seleccionar"
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
        Me.TXT_BuscarProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProd.Location = New System.Drawing.Point(23, 152)
        Me.TXT_BuscarProd.Name = "TXT_BuscarProd"
        Me.TXT_BuscarProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProd.PlaceholderText = "Buscar cliente"
        Me.TXT_BuscarProd.SelectedText = ""
        Me.TXT_BuscarProd.Size = New System.Drawing.Size(748, 42)
        Me.TXT_BuscarProd.TabIndex = 87
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(311, -81)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(366, 316)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 86
        Me.Guna2PictureBox2.TabStop = False
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.BorderRadius = 20
        Me.TXT_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Nombre.DefaultText = ""
        Me.TXT_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Location = New System.Drawing.Point(615, 296)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Nombre.PlaceholderText = ""
        Me.TXT_Nombre.ReadOnly = True
        Me.TXT_Nombre.SelectedText = ""
        Me.TXT_Nombre.Size = New System.Drawing.Size(329, 42)
        Me.TXT_Nombre.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(522, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(535, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 23)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Precio:"
        '
        'TXT_Precio
        '
        Me.TXT_Precio.BorderRadius = 20
        Me.TXT_Precio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Precio.DefaultText = ""
        Me.TXT_Precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Precio.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Precio.Location = New System.Drawing.Point(615, 366)
        Me.TXT_Precio.Name = "TXT_Precio"
        Me.TXT_Precio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Precio.PlaceholderText = ""
        Me.TXT_Precio.ReadOnly = True
        Me.TXT_Precio.SelectedText = ""
        Me.TXT_Precio.Size = New System.Drawing.Size(210, 42)
        Me.TXT_Precio.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(670, 425)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Cantidad"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 20
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "0"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(1142, 902)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(390, 84)
        Me.Guna2TextBox1.TabIndex = 102
        '
        'TXT_CantProd
        '
        Me.TXT_CantProd.BorderRadius = 20
        Me.TXT_CantProd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CantProd.DefaultText = "1"
        Me.TXT_CantProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CantProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CantProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CantProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantProd.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CantProd.ForeColor = System.Drawing.Color.Black
        Me.TXT_CantProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CantProd.Location = New System.Drawing.Point(615, 454)
        Me.TXT_CantProd.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TXT_CantProd.Name = "TXT_CantProd"
        Me.TXT_CantProd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CantProd.PlaceholderText = ""
        Me.TXT_CantProd.SelectedText = ""
        Me.TXT_CantProd.Size = New System.Drawing.Size(208, 42)
        Me.TXT_CantProd.TabIndex = 103
        Me.TXT_CantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_MenosCant
        '
        Me.BTN_MenosCant.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_MenosCant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MenosCant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MenosCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MenosCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MenosCant.FillColor = System.Drawing.Color.White
        Me.BTN_MenosCant.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MenosCant.ForeColor = System.Drawing.Color.White
        Me.BTN_MenosCant.Image = CType(resources.GetObject("BTN_MenosCant.Image"), System.Drawing.Image)
        Me.BTN_MenosCant.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_MenosCant.Location = New System.Drawing.Point(556, 448)
        Me.BTN_MenosCant.Name = "BTN_MenosCant"
        Me.BTN_MenosCant.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_MenosCant.Size = New System.Drawing.Size(50, 50)
        Me.BTN_MenosCant.TabIndex = 104
        Me.BTN_MenosCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_MenosCant.TextOffset = New System.Drawing.Point(0, -5)
        '
        'BTN_MasCant
        '
        Me.BTN_MasCant.BackgroundImage = CType(resources.GetObject("BTN_MasCant.BackgroundImage"), System.Drawing.Image)
        Me.BTN_MasCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTN_MasCant.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_MasCant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MasCant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MasCant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MasCant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MasCant.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.BTN_MasCant.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MasCant.ForeColor = System.Drawing.Color.White
        Me.BTN_MasCant.Image = CType(resources.GetObject("BTN_MasCant.Image"), System.Drawing.Image)
        Me.BTN_MasCant.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_MasCant.Location = New System.Drawing.Point(832, 446)
        Me.BTN_MasCant.Name = "BTN_MasCant"
        Me.BTN_MasCant.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_MasCant.Size = New System.Drawing.Size(50, 50)
        Me.BTN_MasCant.TabIndex = 105
        Me.BTN_MasCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_MasCant.TextOffset = New System.Drawing.Point(-6, -5)
        '
        'B_Producto
        '
        Me.AcceptButton = Me.BTN_SelectProd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarPrd
        Me.ClientSize = New System.Drawing.Size(962, 614)
        Me.Controls.Add(Me.BTN_MasCant)
        Me.Controls.Add(Me.BTN_MenosCant)
        Me.Controls.Add(Me.TXT_CantProd)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Precio)
        Me.Controls.Add(Me.LBL_IDProd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_codigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LSV_Producto)
        Me.Controls.Add(Me.BTN_RegresarPrd)
        Me.Controls.Add(Me.BTN_SelectProd)
        Me.Controls.Add(Me.TXT_BuscarProd)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "B_Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B_Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents LBL_IDProd As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_codigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_BuscarNombre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_BuscarCodigo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LSV_Producto As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents BTN_RegresarPrd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_SelectProd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Precio As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Nombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents precio_venta As ColumnHeader
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_CantProd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_MenosCant As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_MasCant As Guna.UI2.WinForms.Guna2CircleButton
End Class
