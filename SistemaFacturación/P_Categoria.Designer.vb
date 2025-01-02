<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Categoria))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarCat = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NCat = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.DGV_Categoria = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(136, 56)
        '
        'MNU_MODIFICAR
        '
        Me.MNU_MODIFICAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_MODIFICAR.Image = CType(resources.GetObject("MNU_MODIFICAR.Image"), System.Drawing.Image)
        Me.MNU_MODIFICAR.Name = "MNU_MODIFICAR"
        Me.MNU_MODIFICAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_MODIFICAR.Text = "Modificar"
        Me.MNU_MODIFICAR.Visible = False
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MNU_ELIMINAR.Image = CType(resources.GetObject("MNU_ELIMINAR.Image"), System.Drawing.Image)
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(135, 26)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
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
        Me.BTN_RegresarCat.Location = New System.Drawing.Point(10, 431)
        Me.BTN_RegresarCat.Name = "BTN_RegresarCat"
        Me.BTN_RegresarCat.Size = New System.Drawing.Size(208, 57)
        Me.BTN_RegresarCat.TabIndex = 44
        Me.BTN_RegresarCat.Text = "Regresar"
        '
        'BTN_NCat
        '
        Me.BTN_NCat.BorderColor = System.Drawing.Color.Red
        Me.BTN_NCat.BorderRadius = 25
        Me.BTN_NCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NCat.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NCat.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NCat.ForeColor = System.Drawing.Color.White
        Me.BTN_NCat.Image = CType(resources.GetObject("BTN_NCat.Image"), System.Drawing.Image)
        Me.BTN_NCat.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NCat.Location = New System.Drawing.Point(230, 431)
        Me.BTN_NCat.Name = "BTN_NCat"
        Me.BTN_NCat.Size = New System.Drawing.Size(205, 57)
        Me.BTN_NCat.TabIndex = 43
        Me.BTN_NCat.Text = "Agregar"
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
        Me.TXT_BuscarCat.IconRight = CType(resources.GetObject("TXT_BuscarCat.IconRight"), System.Drawing.Image)
        Me.TXT_BuscarCat.IconRightSize = New System.Drawing.Size(40, 40)
        Me.TXT_BuscarCat.Location = New System.Drawing.Point(12, 165)
        Me.TXT_BuscarCat.Name = "TXT_BuscarCat"
        Me.TXT_BuscarCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarCat.PlaceholderText = "Buscar Categoría"
        Me.TXT_BuscarCat.SelectedText = ""
        Me.TXT_BuscarCat.Size = New System.Drawing.Size(420, 42)
        Me.TXT_BuscarCat.TabIndex = 42
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(50, -68)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(329, 287)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 41
        Me.Guna2PictureBox1.TabStop = False
        '
        'CerrarApp
        '
        Me.CerrarApp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarApp.FillColor = System.Drawing.Color.SandyBrown
        Me.CerrarApp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CerrarApp.ForeColor = System.Drawing.Color.White
        Me.CerrarApp.Image = CType(resources.GetObject("CerrarApp.Image"), System.Drawing.Image)
        Me.CerrarApp.ImageSize = New System.Drawing.Size(55, 55)
        Me.CerrarApp.Location = New System.Drawing.Point(392, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(40, 40)
        Me.CerrarApp.TabIndex = 40
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'DGV_Categoria
        '
        Me.DGV_Categoria.AllowUserToAddRows = False
        Me.DGV_Categoria.AllowUserToDeleteRows = False
        Me.DGV_Categoria.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Categoria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Categoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Categoria.ColumnHeadersHeight = 20
        Me.DGV_Categoria.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Categoria.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Categoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Categoria.Location = New System.Drawing.Point(7, 225)
        Me.DGV_Categoria.MultiSelect = False
        Me.DGV_Categoria.Name = "DGV_Categoria"
        Me.DGV_Categoria.ReadOnly = True
        Me.DGV_Categoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Categoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Categoria.RowHeadersVisible = False
        Me.DGV_Categoria.Size = New System.Drawing.Size(425, 197)
        Me.DGV_Categoria.TabIndex = 69
        Me.DGV_Categoria.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Categoria.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Categoria.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DGV_Categoria.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Categoria.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DGV_Categoria.ThemeStyle.HeaderStyle.Height = 20
        Me.DGV_Categoria.ThemeStyle.ReadOnly = True
        Me.DGV_Categoria.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Categoria.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Categoria.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Categoria.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Categoria.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Categoria.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BTN_Config
        '
        Me.BTN_Config.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_Config.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Config.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Config.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Config.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Config.FillColor = System.Drawing.Color.Transparent
        Me.BTN_Config.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Config.ForeColor = System.Drawing.Color.White
        Me.BTN_Config.Image = CType(resources.GetObject("BTN_Config.Image"), System.Drawing.Image)
        Me.BTN_Config.ImageSize = New System.Drawing.Size(50, 50)
        Me.BTN_Config.Location = New System.Drawing.Point(392, 58)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_Config.Size = New System.Drawing.Size(40, 40)
        Me.BTN_Config.TabIndex = 121
        '
        'P_Categoria
        '
        Me.AcceptButton = Me.BTN_NCat
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarCat
        Me.ClientSize = New System.Drawing.Size(444, 502)
        Me.Controls.Add(Me.BTN_Config)
        Me.Controls.Add(Me.DGV_Categoria)
        Me.Controls.Add(Me.BTN_RegresarCat)
        Me.Controls.Add(Me.BTN_NCat)
        Me.Controls.Add(Me.TXT_BuscarCat)
        Me.Controls.Add(Me.CerrarApp)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorías"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Categoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTN_RegresarCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NCat As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents DGV_Categoria As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2CircleButton
End Class
