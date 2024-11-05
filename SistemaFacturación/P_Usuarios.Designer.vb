<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Usuarios))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.BTN_RegresarUsu = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.LSV_Usuario = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clave = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colorUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RDB_BuscarNombre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RDB_BuscarCodigo = New Guna.UI2.WinForms.Guna2RadioButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'BTN_RegresarUsu
        '
        Me.BTN_RegresarUsu.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarUsu.BorderRadius = 25
        Me.BTN_RegresarUsu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarUsu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarUsu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarUsu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarUsu.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarUsu.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarUsu.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarUsu.Image = CType(resources.GetObject("BTN_RegresarUsu.Image"), System.Drawing.Image)
        Me.BTN_RegresarUsu.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarUsu.Location = New System.Drawing.Point(46, 598)
        Me.BTN_RegresarUsu.Name = "BTN_RegresarUsu"
        Me.BTN_RegresarUsu.Size = New System.Drawing.Size(322, 57)
        Me.BTN_RegresarUsu.TabIndex = 28
        Me.BTN_RegresarUsu.Text = "Regresar"
        '
        'BTN_NUsuario
        '
        Me.BTN_NUsuario.BorderColor = System.Drawing.Color.Red
        Me.BTN_NUsuario.BorderRadius = 25
        Me.BTN_NUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NUsuario.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NUsuario.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NUsuario.ForeColor = System.Drawing.Color.White
        Me.BTN_NUsuario.Image = CType(resources.GetObject("BTN_NUsuario.Image"), System.Drawing.Image)
        Me.BTN_NUsuario.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NUsuario.Location = New System.Drawing.Point(496, 598)
        Me.BTN_NUsuario.Name = "BTN_NUsuario"
        Me.BTN_NUsuario.Size = New System.Drawing.Size(322, 57)
        Me.BTN_NUsuario.TabIndex = 27
        Me.BTN_NUsuario.Text = "Agregar"
        '
        'TXT_BuscarUsuario
        '
        Me.TXT_BuscarUsuario.BorderRadius = 20
        Me.TXT_BuscarUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarUsuario.DefaultText = ""
        Me.TXT_BuscarUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarUsuario.Location = New System.Drawing.Point(46, 191)
        Me.TXT_BuscarUsuario.Name = "TXT_BuscarUsuario"
        Me.TXT_BuscarUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarUsuario.PlaceholderText = "Buscar Usuario"
        Me.TXT_BuscarUsuario.SelectedText = ""
        Me.TXT_BuscarUsuario.Size = New System.Drawing.Size(638, 42)
        Me.TXT_BuscarUsuario.TabIndex = 25
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(173, -128)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 24
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
        Me.CerrarApp.ImageSize = New System.Drawing.Size(90, 90)
        Me.CerrarApp.Location = New System.Drawing.Point(783, 9)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 23
        '
        'LSV_Usuario
        '
        Me.LSV_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Usuario.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.usuario, Me.clave, Me.colorUsuario})
        Me.LSV_Usuario.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Usuario.FullRowSelect = True
        Me.LSV_Usuario.GridLines = True
        Me.LSV_Usuario.HideSelection = False
        Me.LSV_Usuario.Location = New System.Drawing.Point(46, 251)
        Me.LSV_Usuario.MultiSelect = False
        Me.LSV_Usuario.Name = "LSV_Usuario"
        Me.LSV_Usuario.OwnerDraw = True
        Me.LSV_Usuario.Size = New System.Drawing.Size(772, 324)
        Me.LSV_Usuario.TabIndex = 29
        Me.LSV_Usuario.UseCompatibleStateImageBehavior = False
        Me.LSV_Usuario.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Codigo"
        '
        'usuario
        '
        Me.usuario.Text = "Usuario"
        '
        'clave
        '
        Me.clave.Text = "Clave"
        '
        'colorUsuario
        '
        Me.colorUsuario.Text = "color"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarNombre)
        Me.GroupBox1.Controls.Add(Me.RDB_BuscarCodigo)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(690, 182)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 63)
        Me.GroupBox1.TabIndex = 39
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
        'P_Usuarios
        '
        Me.AcceptButton = Me.BTN_NUsuario
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarUsu
        Me.ClientSize = New System.Drawing.Size(865, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LSV_Usuario)
        Me.Controls.Add(Me.BTN_RegresarUsu)
        Me.Controls.Add(Me.BTN_NUsuario)
        Me.Controls.Add(Me.TXT_BuscarUsuario)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.CerrarApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_Usuarios"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents BTN_RegresarUsu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents LSV_Usuario As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents usuario As ColumnHeader
    Friend WithEvents clave As ColumnHeader
    Friend WithEvents colorUsuario As ColumnHeader
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_BuscarNombre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RDB_BuscarCodigo As Guna.UI2.WinForms.Guna2RadioButton
End Class
