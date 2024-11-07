<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class B_Impuesto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B_Impuesto))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Desc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_codigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDB_BuscarDesc = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_BuscarCodigo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LSV_Impuesto = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.porcentaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_RegresarImpuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_SelectImpuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarImp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_porcentaje = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(484, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Descripción:"
        '
        'TXT_Desc
        '
        Me.TXT_Desc.BorderRadius = 20
        Me.TXT_Desc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Desc.DefaultText = ""
        Me.TXT_Desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_Desc.ForeColor = System.Drawing.Color.Black
        Me.TXT_Desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Desc.Location = New System.Drawing.Point(475, 337)
        Me.TXT_Desc.Name = "TXT_Desc"
        Me.TXT_Desc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Desc.PlaceholderText = ""
        Me.TXT_Desc.ReadOnly = True
        Me.TXT_Desc.SelectedText = ""
        Me.TXT_Desc.Size = New System.Drawing.Size(210, 42)
        Me.TXT_Desc.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(484, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 72
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
        Me.TXT_codigo.ForeColor = System.Drawing.Color.Black
        Me.TXT_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_codigo.Location = New System.Drawing.Point(475, 256)
        Me.TXT_codigo.Name = "TXT_codigo"
        Me.TXT_codigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_codigo.PlaceholderText = ""
        Me.TXT_codigo.ReadOnly = True
        Me.TXT_codigo.SelectedText = ""
        Me.TXT_codigo.Size = New System.Drawing.Size(210, 42)
        Me.TXT_codigo.TabIndex = 71
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarDesc)
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarCodigo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(556, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 63)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros de busqueda"
        '
        'RDB_BuscarDesc
        '
        Me.RDB_BuscarDesc.AutoSize = True
        Me.RDB_BuscarDesc.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarDesc.CheckedState.BorderThickness = 0
        Me.RDB_BuscarDesc.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDB_BuscarDesc.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RDB_BuscarDesc.CheckedState.InnerOffset = -4
        Me.RDB_BuscarDesc.ForeColor = System.Drawing.Color.White
        Me.RDB_BuscarDesc.Location = New System.Drawing.Point(29, 19)
        Me.RDB_BuscarDesc.Name = "RDB_BuscarDesc"
        Me.RDB_BuscarDesc.Size = New System.Drawing.Size(81, 17)
        Me.RDB_BuscarDesc.TabIndex = 36
        Me.RDB_BuscarDesc.Text = "Descripción"
        Me.RDB_BuscarDesc.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RDB_BuscarDesc.UncheckedState.BorderThickness = 2
        Me.RDB_BuscarDesc.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RDB_BuscarDesc.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        'LSV_Impuesto
        '
        Me.LSV_Impuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Impuesto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.codigo, Me.descripcion, Me.porcentaje})
        Me.LSV_Impuesto.FullRowSelect = True
        Me.LSV_Impuesto.GridLines = True
        Me.LSV_Impuesto.HideSelection = False
        Me.LSV_Impuesto.Location = New System.Drawing.Point(31, 219)
        Me.LSV_Impuesto.MultiSelect = False
        Me.LSV_Impuesto.Name = "LSV_Impuesto"
        Me.LSV_Impuesto.Size = New System.Drawing.Size(425, 236)
        Me.LSV_Impuesto.TabIndex = 69
        Me.LSV_Impuesto.UseCompatibleStateImageBehavior = False
        Me.LSV_Impuesto.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'codigo
        '
        Me.codigo.Text = "Codigo"
        '
        'descripcion
        '
        Me.descripcion.Text = "Descripción"
        Me.descripcion.Width = 178
        '
        'porcentaje
        '
        Me.porcentaje.Text = "Porcentaje"
        Me.porcentaje.Width = 64
        '
        'BTN_RegresarImpuesto
        '
        Me.BTN_RegresarImpuesto.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarImpuesto.BorderRadius = 25
        Me.BTN_RegresarImpuesto.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarImpuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarImpuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarImpuesto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarImpuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarImpuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarImpuesto.Image = CType(resources.GetObject("BTN_RegresarImpuesto.Image"), System.Drawing.Image)
        Me.BTN_RegresarImpuesto.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarImpuesto.Location = New System.Drawing.Point(40, 484)
        Me.BTN_RegresarImpuesto.Name = "BTN_RegresarImpuesto"
        Me.BTN_RegresarImpuesto.Size = New System.Drawing.Size(273, 57)
        Me.BTN_RegresarImpuesto.TabIndex = 68
        Me.BTN_RegresarImpuesto.Text = "Regresar"
        '
        'BTN_SelectImpuesto
        '
        Me.BTN_SelectImpuesto.BorderColor = System.Drawing.Color.Red
        Me.BTN_SelectImpuesto.BorderRadius = 25
        Me.BTN_SelectImpuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectImpuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SelectImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SelectImpuesto.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_SelectImpuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SelectImpuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_SelectImpuesto.Image = CType(resources.GetObject("BTN_SelectImpuesto.Image"), System.Drawing.Image)
        Me.BTN_SelectImpuesto.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_SelectImpuesto.Location = New System.Drawing.Point(380, 484)
        Me.BTN_SelectImpuesto.Name = "BTN_SelectImpuesto"
        Me.BTN_SelectImpuesto.Size = New System.Drawing.Size(263, 57)
        Me.BTN_SelectImpuesto.TabIndex = 67
        Me.BTN_SelectImpuesto.Text = "Seleccionar"
        '
        'TXT_BuscarImp
        '
        Me.TXT_BuscarImp.BorderRadius = 20
        Me.TXT_BuscarImp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarImp.DefaultText = ""
        Me.TXT_BuscarImp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarImp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarImp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarImp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarImp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarImp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarImp.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarImp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarImp.IconRight = CType(resources.GetObject("TXT_BuscarImp.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarImp.IconRightSize = New System.Drawing.Size(35, 35)
        Me.TXT_BuscarImp.Location = New System.Drawing.Point(31, 159)
        Me.TXT_BuscarImp.Name = "TXT_BuscarImp"
        Me.TXT_BuscarImp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarImp.PlaceholderText = "Buscar impuesto"
        Me.TXT_BuscarImp.SelectedText = ""
        Me.TXT_BuscarImp.Size = New System.Drawing.Size(506, 42)
        Me.TXT_BuscarImp.TabIndex = 66
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(187, -61)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(329, 287)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 65
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(484, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Porcentaje:"
        '
        'TXT_porcentaje
        '
        Me.TXT_porcentaje.BorderRadius = 20
        Me.TXT_porcentaje.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_porcentaje.DefaultText = ""
        Me.TXT_porcentaje.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_porcentaje.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_porcentaje.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_porcentaje.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_porcentaje.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_porcentaje.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_porcentaje.ForeColor = System.Drawing.Color.Black
        Me.TXT_porcentaje.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_porcentaje.Location = New System.Drawing.Point(475, 418)
        Me.TXT_porcentaje.Name = "TXT_porcentaje"
        Me.TXT_porcentaje.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_porcentaje.PlaceholderText = ""
        Me.TXT_porcentaje.ReadOnly = True
        Me.TXT_porcentaje.SelectedText = ""
        Me.TXT_porcentaje.Size = New System.Drawing.Size(173, 42)
        Me.TXT_porcentaje.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(654, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 41)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "%"
        '
        'B_Impuesto
        '
        Me.AcceptButton = Me.BTN_SelectImpuesto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarImpuesto
        Me.ClientSize = New System.Drawing.Size(713, 553)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_porcentaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Desc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_codigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LSV_Impuesto)
        Me.Controls.Add(Me.BTN_RegresarImpuesto)
        Me.Controls.Add(Me.BTN_SelectImpuesto)
        Me.Controls.Add(Me.TXT_BuscarImp)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "B_Impuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar impuestos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Desc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_codigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_BuscarDesc As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_BuscarCodigo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LSV_Impuesto As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents descripcion As ColumnHeader
    Friend WithEvents BTN_RegresarImpuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_SelectImpuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarImp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_porcentaje As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents porcentaje As ColumnHeader
End Class
