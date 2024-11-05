<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_NuevoProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoProducto))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TXT_Cod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_Nombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Desc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CKB_Fav = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.TXT_PrecioBase = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_Impuesto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_Marca = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Proveedor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Categoria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_Ganancia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_PrecioVenta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BTN_RegresarProv = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NProv = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_IDMarca = New System.Windows.Forms.Label()
        Me.LBL_Prov = New System.Windows.Forms.Label()
        Me.LBL_IDCat = New System.Windows.Forms.Label()
        Me.pBar_guardar = New Guna.UI2.WinForms.Guna2ProgressBar()
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
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(295, -94)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(409, 361)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 62
        Me.Guna2PictureBox2.TabStop = False
        '
        'TXT_Cod
        '
        Me.TXT_Cod.AutoRoundedCorners = True
        Me.TXT_Cod.BorderRadius = 14
        Me.TXT_Cod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Cod.DefaultText = ""
        Me.TXT_Cod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Cod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Cod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Cod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Cod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Cod.Location = New System.Drawing.Point(122, 190)
        Me.TXT_Cod.Name = "TXT_Cod"
        Me.TXT_Cod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Cod.PlaceholderText = ""
        Me.TXT_Cod.SelectedText = ""
        Me.TXT_Cod.Size = New System.Drawing.Size(212, 31)
        Me.TXT_Cod.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(37, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Codigo:"
        '
        'TXT_Nombre
        '
        Me.TXT_Nombre.AutoRoundedCorners = True
        Me.TXT_Nombre.BorderRadius = 14
        Me.TXT_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Nombre.DefaultText = ""
        Me.TXT_Nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Location = New System.Drawing.Point(122, 240)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Nombre.PlaceholderText = ""
        Me.TXT_Nombre.SelectedText = ""
        Me.TXT_Nombre.Size = New System.Drawing.Size(503, 31)
        Me.TXT_Nombre.TabIndex = 68
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 23)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Nombre:"
        '
        'TXT_Desc
        '
        Me.TXT_Desc.BorderRadius = 14
        Me.TXT_Desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Desc.DefaultText = ""
        Me.TXT_Desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc.Location = New System.Drawing.Point(123, 287)
        Me.TXT_Desc.Multiline = True
        Me.TXT_Desc.Name = "TXT_Desc"
        Me.TXT_Desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Desc.PlaceholderText = ""
        Me.TXT_Desc.SelectedText = ""
        Me.TXT_Desc.Size = New System.Drawing.Size(502, 120)
        Me.TXT_Desc.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(-8, 336)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 23)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Descripción:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(672, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(635, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Proveedor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(639, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 23)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Categoría:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(639, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Favorito:"
        '
        'CKB_Fav
        '
        Me.CKB_Fav.AutoSize = True
        Me.CKB_Fav.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Fav.CheckedState.BorderRadius = 0
        Me.CKB_Fav.CheckedState.BorderThickness = 0
        Me.CKB_Fav.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CKB_Fav.Location = New System.Drawing.Point(735, 341)
        Me.CKB_Fav.Name = "CKB_Fav"
        Me.CKB_Fav.Size = New System.Drawing.Size(15, 14)
        Me.CKB_Fav.TabIndex = 78
        Me.CKB_Fav.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CKB_Fav.UncheckedState.BorderRadius = 0
        Me.CKB_Fav.UncheckedState.BorderThickness = 0
        Me.CKB_Fav.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'TXT_PrecioBase
        '
        Me.TXT_PrecioBase.AutoRoundedCorners = True
        Me.TXT_PrecioBase.BorderRadius = 14
        Me.TXT_PrecioBase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PrecioBase.DefaultText = "0"
        Me.TXT_PrecioBase.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PrecioBase.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PrecioBase.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioBase.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioBase.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioBase.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PrecioBase.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioBase.Location = New System.Drawing.Point(122, 422)
        Me.TXT_PrecioBase.Name = "TXT_PrecioBase"
        Me.TXT_PrecioBase.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PrecioBase.PlaceholderText = ""
        Me.TXT_PrecioBase.SelectedText = ""
        Me.TXT_PrecioBase.Size = New System.Drawing.Size(165, 31)
        Me.TXT_PrecioBase.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(-7, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 23)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Precio base:"
        '
        'TXT_Impuesto
        '
        Me.TXT_Impuesto.AutoRoundedCorners = True
        Me.TXT_Impuesto.BorderRadius = 14
        Me.TXT_Impuesto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Impuesto.DefaultText = "0"
        Me.TXT_Impuesto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Impuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Impuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Impuesto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Impuesto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Impuesto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Impuesto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Impuesto.Location = New System.Drawing.Point(462, 422)
        Me.TXT_Impuesto.Name = "TXT_Impuesto"
        Me.TXT_Impuesto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Impuesto.PlaceholderText = ""
        Me.TXT_Impuesto.SelectedText = ""
        Me.TXT_Impuesto.Size = New System.Drawing.Size(163, 31)
        Me.TXT_Impuesto.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(355, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 23)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Impuesto:"
        '
        'TXT_Marca
        '
        Me.TXT_Marca.AutoRoundedCorners = True
        Me.TXT_Marca.BorderRadius = 14
        Me.TXT_Marca.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Marca.DefaultText = ""
        Me.TXT_Marca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Marca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Marca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Marca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Marca.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Marca.Location = New System.Drawing.Point(750, 190)
        Me.TXT_Marca.Name = "TXT_Marca"
        Me.TXT_Marca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Marca.PlaceholderText = ""
        Me.TXT_Marca.SelectedText = ""
        Me.TXT_Marca.Size = New System.Drawing.Size(204, 31)
        Me.TXT_Marca.TabIndex = 83
        '
        'TXT_Proveedor
        '
        Me.TXT_Proveedor.AutoRoundedCorners = True
        Me.TXT_Proveedor.BorderRadius = 14
        Me.TXT_Proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Proveedor.DefaultText = ""
        Me.TXT_Proveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Proveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Proveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Proveedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Proveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Proveedor.Location = New System.Drawing.Point(750, 240)
        Me.TXT_Proveedor.Name = "TXT_Proveedor"
        Me.TXT_Proveedor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Proveedor.PlaceholderText = ""
        Me.TXT_Proveedor.SelectedText = ""
        Me.TXT_Proveedor.Size = New System.Drawing.Size(204, 31)
        Me.TXT_Proveedor.TabIndex = 84
        '
        'TXT_Categoria
        '
        Me.TXT_Categoria.AutoRoundedCorners = True
        Me.TXT_Categoria.BorderRadius = 14
        Me.TXT_Categoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Categoria.DefaultText = ""
        Me.TXT_Categoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Categoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Categoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Categoria.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Categoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Categoria.Location = New System.Drawing.Point(750, 287)
        Me.TXT_Categoria.Name = "TXT_Categoria"
        Me.TXT_Categoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Categoria.PlaceholderText = ""
        Me.TXT_Categoria.SelectedText = ""
        Me.TXT_Categoria.Size = New System.Drawing.Size(204, 31)
        Me.TXT_Categoria.TabIndex = 85
        '
        'TXT_Ganancia
        '
        Me.TXT_Ganancia.AutoRoundedCorners = True
        Me.TXT_Ganancia.BorderRadius = 14
        Me.TXT_Ganancia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Ganancia.DefaultText = "0"
        Me.TXT_Ganancia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Ganancia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Ganancia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ganancia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Ganancia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ganancia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Ganancia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Ganancia.Location = New System.Drawing.Point(122, 469)
        Me.TXT_Ganancia.Name = "TXT_Ganancia"
        Me.TXT_Ganancia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Ganancia.PlaceholderText = ""
        Me.TXT_Ganancia.SelectedText = ""
        Me.TXT_Ganancia.Size = New System.Drawing.Size(165, 31)
        Me.TXT_Ganancia.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 473)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 23)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Ganancia:"
        '
        'TXT_PrecioVenta
        '
        Me.TXT_PrecioVenta.AutoRoundedCorners = True
        Me.TXT_PrecioVenta.BorderRadius = 14
        Me.TXT_PrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_PrecioVenta.DefaultText = "0"
        Me.TXT_PrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_PrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioVenta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_PrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_PrecioVenta.Location = New System.Drawing.Point(462, 469)
        Me.TXT_PrecioVenta.Name = "TXT_PrecioVenta"
        Me.TXT_PrecioVenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_PrecioVenta.PlaceholderText = ""
        Me.TXT_PrecioVenta.SelectedText = ""
        Me.TXT_PrecioVenta.Size = New System.Drawing.Size(163, 31)
        Me.TXT_PrecioVenta.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(299, 473)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 23)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Precio de venta:"
        '
        'BTN_RegresarProv
        '
        Me.BTN_RegresarProv.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarProv.BorderRadius = 25
        Me.BTN_RegresarProv.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarProv.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarProv.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarProv.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarProv.Image = CType(resources.GetObject("BTN_RegresarProv.Image"), System.Drawing.Image)
        Me.BTN_RegresarProv.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarProv.Location = New System.Drawing.Point(685, 448)
        Me.BTN_RegresarProv.Name = "BTN_RegresarProv"
        Me.BTN_RegresarProv.Size = New System.Drawing.Size(285, 70)
        Me.BTN_RegresarProv.TabIndex = 91
        Me.BTN_RegresarProv.Text = "Regresar"
        '
        'BTN_NProv
        '
        Me.BTN_NProv.BorderColor = System.Drawing.Color.Red
        Me.BTN_NProv.BorderRadius = 25
        Me.BTN_NProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NProv.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NProv.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NProv.ForeColor = System.Drawing.Color.White
        Me.BTN_NProv.Image = CType(resources.GetObject("BTN_NProv.Image"), System.Drawing.Image)
        Me.BTN_NProv.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NProv.Location = New System.Drawing.Point(685, 371)
        Me.BTN_NProv.Name = "BTN_NProv"
        Me.BTN_NProv.Size = New System.Drawing.Size(285, 71)
        Me.BTN_NProv.TabIndex = 90
        Me.BTN_NProv.Text = "Guardar"
        '
        'LBL_IDMarca
        '
        Me.LBL_IDMarca.AutoSize = True
        Me.LBL_IDMarca.ForeColor = System.Drawing.Color.Cornsilk
        Me.LBL_IDMarca.Location = New System.Drawing.Point(857, 48)
        Me.LBL_IDMarca.Name = "LBL_IDMarca"
        Me.LBL_IDMarca.Size = New System.Drawing.Size(45, 13)
        Me.LBL_IDMarca.TabIndex = 92
        Me.LBL_IDMarca.Text = "idMarca"
        Me.LBL_IDMarca.Visible = False
        '
        'LBL_Prov
        '
        Me.LBL_Prov.AutoSize = True
        Me.LBL_Prov.ForeColor = System.Drawing.Color.Cornsilk
        Me.LBL_Prov.Location = New System.Drawing.Point(857, 74)
        Me.LBL_Prov.Name = "LBL_Prov"
        Me.LBL_Prov.Size = New System.Drawing.Size(37, 13)
        Me.LBL_Prov.TabIndex = 93
        Me.LBL_Prov.Text = "idProv"
        Me.LBL_Prov.Visible = False
        '
        'LBL_IDCat
        '
        Me.LBL_IDCat.AutoSize = True
        Me.LBL_IDCat.ForeColor = System.Drawing.Color.Cornsilk
        Me.LBL_IDCat.Location = New System.Drawing.Point(857, 97)
        Me.LBL_IDCat.Name = "LBL_IDCat"
        Me.LBL_IDCat.Size = New System.Drawing.Size(31, 13)
        Me.LBL_IDCat.TabIndex = 94
        Me.LBL_IDCat.Text = "idCat"
        Me.LBL_IDCat.Visible = False
        '
        'pBar_guardar
        '
        Me.pBar_guardar.BorderColor = System.Drawing.Color.White
        Me.pBar_guardar.BorderThickness = 1
        Me.pBar_guardar.FillColor = System.Drawing.Color.Transparent
        Me.pBar_guardar.Location = New System.Drawing.Point(12, 528)
        Me.pBar_guardar.Name = "pBar_guardar"
        Me.pBar_guardar.Size = New System.Drawing.Size(942, 30)
        Me.pBar_guardar.TabIndex = 95
        Me.pBar_guardar.Text = "Guna2ProgressBar1"
        Me.pBar_guardar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'E_NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(980, 570)
        Me.Controls.Add(Me.pBar_guardar)
        Me.Controls.Add(Me.LBL_IDCat)
        Me.Controls.Add(Me.LBL_Prov)
        Me.Controls.Add(Me.LBL_IDMarca)
        Me.Controls.Add(Me.BTN_RegresarProv)
        Me.Controls.Add(Me.BTN_NProv)
        Me.Controls.Add(Me.TXT_PrecioVenta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXT_Ganancia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT_Categoria)
        Me.Controls.Add(Me.TXT_Proveedor)
        Me.Controls.Add(Me.TXT_Marca)
        Me.Controls.Add(Me.TXT_Impuesto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_PrecioBase)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CKB_Fav)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_Desc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_Cod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E_NuevoProducto"
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TXT_Cod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Desc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Nombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CKB_Fav As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_Impuesto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_PrecioBase As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_Categoria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Proveedor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_Marca As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_PrecioVenta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_Ganancia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BTN_RegresarProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_IDMarca As Label
    Friend WithEvents LBL_IDCat As Label
    Friend WithEvents LBL_Prov As Label
    Friend WithEvents pBar_guardar As Guna.UI2.WinForms.Guna2ProgressBar
End Class
