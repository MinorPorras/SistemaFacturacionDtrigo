<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class B_Categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(B_Categoria))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Nombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_codigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDB_BuscarNombre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_BuscarCodigo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.LSV_Cat = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_RegresarCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_SelectCat = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(487, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Nombre:"
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
        Me.TXT_Nombre.ForeColor = System.Drawing.Color.Black
        Me.TXT_Nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Nombre.Location = New System.Drawing.Point(478, 365)
        Me.TXT_Nombre.Name = "TXT_Nombre"
        Me.TXT_Nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Nombre.PlaceholderText = ""
        Me.TXT_Nombre.ReadOnly = True
        Me.TXT_Nombre.SelectedText = ""
        Me.TXT_Nombre.Size = New System.Drawing.Size(210, 42)
        Me.TXT_Nombre.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(487, 229)
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
        Me.TXT_codigo.Location = New System.Drawing.Point(478, 256)
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
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarNombre)
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarCodigo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(559, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 63)
        Me.GroupBox1.TabIndex = 70
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
        'LSV_Cat
        '
        Me.LSV_Cat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Cat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.codigo, Me.nombre})
        Me.LSV_Cat.FullRowSelect = True
        Me.LSV_Cat.GridLines = True
        Me.LSV_Cat.HideSelection = False
        Me.LSV_Cat.Location = New System.Drawing.Point(34, 219)
        Me.LSV_Cat.MultiSelect = False
        Me.LSV_Cat.Name = "LSV_Cat"
        Me.LSV_Cat.Size = New System.Drawing.Size(425, 206)
        Me.LSV_Cat.TabIndex = 69
        Me.LSV_Cat.UseCompatibleStateImageBehavior = False
        Me.LSV_Cat.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'codigo
        '
        Me.codigo.Text = "Codigo"
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        '
        'BTN_RegresarCat
        '
        Me.BTN_RegresarCat.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarCat.BorderRadius = 25
        Me.BTN_RegresarCat.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCat.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarCat.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarCat.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarCat.Image = CType(resources.GetObject("BTN_RegresarCat.Image"), System.Drawing.Image)
        Me.BTN_RegresarCat.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarCat.Location = New System.Drawing.Point(50, 443)
        Me.BTN_RegresarCat.Name = "BTN_RegresarCat"
        Me.BTN_RegresarCat.Size = New System.Drawing.Size(289, 57)
        Me.BTN_RegresarCat.TabIndex = 68
        Me.BTN_RegresarCat.Text = "Regresar"
        '
        'BTN_SelectCat
        '
        Me.BTN_SelectCat.BorderColor = System.Drawing.Color.Red
        Me.BTN_SelectCat.BorderRadius = 25
        Me.BTN_SelectCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SelectCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SelectCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SelectCat.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_SelectCat.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_SelectCat.ForeColor = System.Drawing.Color.White
        Me.BTN_SelectCat.Image = CType(resources.GetObject("BTN_SelectCat.Image"), System.Drawing.Image)
        Me.BTN_SelectCat.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_SelectCat.Location = New System.Drawing.Point(361, 443)
        Me.BTN_SelectCat.Name = "BTN_SelectCat"
        Me.BTN_SelectCat.Size = New System.Drawing.Size(289, 57)
        Me.BTN_SelectCat.TabIndex = 67
        Me.BTN_SelectCat.Text = "Seleccionar"
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
        Me.TXT_BuscarCat.Location = New System.Drawing.Point(34, 159)
        Me.TXT_BuscarCat.Name = "TXT_BuscarCat"
        Me.TXT_BuscarCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarCat.PlaceholderText = "Buscar categoría"
        Me.TXT_BuscarCat.SelectedText = ""
        Me.TXT_BuscarCat.Size = New System.Drawing.Size(506, 42)
        Me.TXT_BuscarCat.TabIndex = 66
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(169, -96)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(371, 336)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 65
        Me.Guna2PictureBox2.TabStop = False
        '
        'B_Categoria
        '
        Me.AcceptButton = Me.BTN_SelectCat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.BTN_RegresarCat
        Me.ClientSize = New System.Drawing.Size(726, 530)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_codigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LSV_Cat)
        Me.Controls.Add(Me.BTN_RegresarCat)
        Me.Controls.Add(Me.BTN_SelectCat)
        Me.Controls.Add(Me.TXT_BuscarCat)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "B_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar categoría"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Nombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_codigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_BuscarNombre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_BuscarCodigo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents LSV_Cat As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents nombre As ColumnHeader
    Friend WithEvents BTN_RegresarCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_SelectCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
