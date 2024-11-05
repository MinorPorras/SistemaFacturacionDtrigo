<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigGeneral))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_RspaldoDB = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Importar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_RegresarConfig = New Guna.UI2.WinForms.Guna2Button()
        Me.OFD_ImportarDB = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CerrarApp
        '
        Me.CerrarApp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CerrarApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarApp.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CerrarApp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CerrarApp.ForeColor = System.Drawing.Color.White
        Me.CerrarApp.Image = CType(resources.GetObject("CerrarApp.Image"), System.Drawing.Image)
        Me.CerrarApp.ImageSize = New System.Drawing.Size(90, 90)
        Me.CerrarApp.Location = New System.Drawing.Point(627, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 10
        '
        'BTN_RspaldoDB
        '
        Me.BTN_RspaldoDB.BorderRadius = 25
        Me.BTN_RspaldoDB.BorderThickness = 2
        Me.BTN_RspaldoDB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RspaldoDB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RspaldoDB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RspaldoDB.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_RspaldoDB.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_RspaldoDB.ForeColor = System.Drawing.Color.White
        Me.BTN_RspaldoDB.Image = CType(resources.GetObject("BTN_RspaldoDB.Image"), System.Drawing.Image)
        Me.BTN_RspaldoDB.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RspaldoDB.Location = New System.Drawing.Point(15, 151)
        Me.BTN_RspaldoDB.Name = "BTN_RspaldoDB"
        Me.BTN_RspaldoDB.Size = New System.Drawing.Size(339, 73)
        Me.BTN_RspaldoDB.TabIndex = 11
        Me.BTN_RspaldoDB.Text = "Exportar base de datos"
        '
        'BTN_Importar
        '
        Me.BTN_Importar.BorderRadius = 25
        Me.BTN_Importar.BorderThickness = 2
        Me.BTN_Importar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Importar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Importar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Importar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Importar.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Importar.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Importar.ForeColor = System.Drawing.Color.White
        Me.BTN_Importar.Image = CType(resources.GetObject("BTN_Importar.Image"), System.Drawing.Image)
        Me.BTN_Importar.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_Importar.Location = New System.Drawing.Point(15, 46)
        Me.BTN_Importar.Name = "BTN_Importar"
        Me.BTN_Importar.Size = New System.Drawing.Size(339, 73)
        Me.BTN_Importar.TabIndex = 12
        Me.BTN_Importar.Text = "Importar base de datos"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(135, -105)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(426, 377)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 13
        Me.Guna2PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTN_Importar)
        Me.GroupBox1.Controls.Add(Me.BTN_RspaldoDB)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(159, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(373, 256)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de base de datos"
        '
        'BTN_RegresarConfig
        '
        Me.BTN_RegresarConfig.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarConfig.BorderRadius = 25
        Me.BTN_RegresarConfig.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarConfig.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarConfig.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarConfig.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarConfig.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarConfig.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarConfig.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarConfig.Image = CType(resources.GetObject("BTN_RegresarConfig.Image"), System.Drawing.Image)
        Me.BTN_RegresarConfig.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarConfig.Location = New System.Drawing.Point(176, 453)
        Me.BTN_RegresarConfig.Name = "BTN_RegresarConfig"
        Me.BTN_RegresarConfig.Size = New System.Drawing.Size(322, 57)
        Me.BTN_RegresarConfig.TabIndex = 45
        Me.BTN_RegresarConfig.Text = "Regresar"
        '
        'OFD_ImportarDB
        '
        Me.OFD_ImportarDB.FileName = "OpenFileDialog1"
        '
        'ConfigGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(705, 522)
        Me.Controls.Add(Me.BTN_RegresarConfig)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.CerrarApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ConfigGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración general"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_Importar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RspaldoDB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_RegresarConfig As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OFD_ImportarDB As OpenFileDialog
End Class
