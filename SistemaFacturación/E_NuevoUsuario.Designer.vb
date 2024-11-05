<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_NuevoUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_NuevoUsuario))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NombreUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CodUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_ClaveUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BTN_Color = New Guna.UI2.WinForms.Guna2TileButton()
        Me.BTN_RegresarUsu = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.CBK_NoClaveUsu = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, -89)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(409, 361)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo:"
        '
        'TXT_NombreUsuario
        '
        Me.TXT_NombreUsuario.AutoRoundedCorners = True
        Me.TXT_NombreUsuario.BorderRadius = 14
        Me.TXT_NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NombreUsuario.DefaultText = ""
        Me.TXT_NombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_NombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.TXT_NombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NombreUsuario.Location = New System.Drawing.Point(121, 245)
        Me.TXT_NombreUsuario.Name = "TXT_NombreUsuario"
        Me.TXT_NombreUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NombreUsuario.PlaceholderText = ""
        Me.TXT_NombreUsuario.SelectedText = ""
        Me.TXT_NombreUsuario.Size = New System.Drawing.Size(309, 31)
        Me.TXT_NombreUsuario.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Usuario:"
        '
        'TXT_CodUsuario
        '
        Me.TXT_CodUsuario.AutoRoundedCorners = True
        Me.TXT_CodUsuario.BorderRadius = 14
        Me.TXT_CodUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CodUsuario.DefaultText = ""
        Me.TXT_CodUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CodUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CodUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CodUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CodUsuario.ForeColor = System.Drawing.Color.Black
        Me.TXT_CodUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CodUsuario.Location = New System.Drawing.Point(121, 199)
        Me.TXT_CodUsuario.Name = "TXT_CodUsuario"
        Me.TXT_CodUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CodUsuario.PlaceholderText = ""
        Me.TXT_CodUsuario.SelectedText = ""
        Me.TXT_CodUsuario.Size = New System.Drawing.Size(175, 31)
        Me.TXT_CodUsuario.TabIndex = 18
        '
        'TXT_ClaveUsuario
        '
        Me.TXT_ClaveUsuario.AutoRoundedCorners = True
        Me.TXT_ClaveUsuario.BorderRadius = 14
        Me.TXT_ClaveUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_ClaveUsuario.DefaultText = ""
        Me.TXT_ClaveUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_ClaveUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_ClaveUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ClaveUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_ClaveUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ClaveUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_ClaveUsuario.ForeColor = System.Drawing.Color.Black
        Me.TXT_ClaveUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_ClaveUsuario.Location = New System.Drawing.Point(121, 291)
        Me.TXT_ClaveUsuario.Name = "TXT_ClaveUsuario"
        Me.TXT_ClaveUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_ClaveUsuario.PlaceholderText = ""
        Me.TXT_ClaveUsuario.SelectedText = ""
        Me.TXT_ClaveUsuario.Size = New System.Drawing.Size(309, 31)
        Me.TXT_ClaveUsuario.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Clave:"
        '
        'BTN_Color
        '
        Me.BTN_Color.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Color.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Color.FillColor = System.Drawing.Color.White
        Me.BTN_Color.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_Color.ForeColor = System.Drawing.Color.Black
        Me.BTN_Color.Location = New System.Drawing.Point(132, 339)
        Me.BTN_Color.Name = "BTN_Color"
        Me.BTN_Color.Size = New System.Drawing.Size(180, 100)
        Me.BTN_Color.TabIndex = 25
        Me.BTN_Color.Text = "Seleccione un color"
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
        Me.BTN_RegresarUsu.Location = New System.Drawing.Point(12, 456)
        Me.BTN_RegresarUsu.Name = "BTN_RegresarUsu"
        Me.BTN_RegresarUsu.Size = New System.Drawing.Size(215, 57)
        Me.BTN_RegresarUsu.TabIndex = 30
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
        Me.BTN_NUsuario.Location = New System.Drawing.Point(233, 456)
        Me.BTN_NUsuario.Name = "BTN_NUsuario"
        Me.BTN_NUsuario.Size = New System.Drawing.Size(213, 57)
        Me.BTN_NUsuario.TabIndex = 29
        Me.BTN_NUsuario.Text = "Guardar"
        '
        'CBK_NoClaveUsu
        '
        Me.CBK_NoClaveUsu.AutoSize = True
        Me.CBK_NoClaveUsu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBK_NoClaveUsu.CheckedState.BorderRadius = 0
        Me.CBK_NoClaveUsu.CheckedState.BorderThickness = 0
        Me.CBK_NoClaveUsu.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBK_NoClaveUsu.ForeColor = System.Drawing.SystemColors.Control
        Me.CBK_NoClaveUsu.Location = New System.Drawing.Point(333, 328)
        Me.CBK_NoClaveUsu.Name = "CBK_NoClaveUsu"
        Me.CBK_NoClaveUsu.Size = New System.Drawing.Size(97, 17)
        Me.CBK_NoClaveUsu.TabIndex = 31
        Me.CBK_NoClaveUsu.Text = "Sin contraseña"
        Me.CBK_NoClaveUsu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CBK_NoClaveUsu.UncheckedState.BorderRadius = 0
        Me.CBK_NoClaveUsu.UncheckedState.BorderThickness = 0
        Me.CBK_NoClaveUsu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'E_NuevoUsuario
        '
        Me.AcceptButton = Me.BTN_NUsuario
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarUsu
        Me.ClientSize = New System.Drawing.Size(458, 546)
        Me.Controls.Add(Me.CBK_NoClaveUsu)
        Me.Controls.Add(Me.BTN_RegresarUsu)
        Me.Controls.Add(Me.BTN_NUsuario)
        Me.Controls.Add(Me.BTN_Color)
        Me.Controls.Add(Me.TXT_ClaveUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_NombreUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_CodUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_NuevoUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_ClaveUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_NombreUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CodUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BTN_Color As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents BTN_RegresarUsu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CBK_NoClaveUsu As Guna.UI2.WinForms.Guna2CheckBox
End Class
