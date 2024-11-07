<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class M_Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Inicio))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LSV_RebPed = New System.Windows.Forms.ListView()
        Me.Lunes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Martes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Miercoles = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Jueves = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Viernes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Sabado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Domingo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_Mantenimiento = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Reporte = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LSV_HacerPed = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBL_Sucursal = New System.Windows.Forms.Label()
        Me.LBL_Telefono = New System.Windows.Forms.Label()
        Me.LBL_Email = New System.Windows.Forms.Label()
        Me.BTN_CajaVenta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Config = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PIC_Logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LBL_Version = New System.Windows.Forms.Label()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(271, -21)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 258)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'LSV_RebPed
        '
        Me.LSV_RebPed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_RebPed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Lunes, Me.Martes, Me.Miercoles, Me.Jueves, Me.Viernes, Me.Sabado, Me.Domingo})
        Me.LSV_RebPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSV_RebPed.FullRowSelect = True
        Me.LSV_RebPed.GridLines = True
        Me.LSV_RebPed.HideSelection = False
        Me.LSV_RebPed.Location = New System.Drawing.Point(24, 28)
        Me.LSV_RebPed.MultiSelect = False
        Me.LSV_RebPed.Name = "LSV_RebPed"
        Me.LSV_RebPed.Size = New System.Drawing.Size(481, 237)
        Me.LSV_RebPed.TabIndex = 3
        Me.LSV_RebPed.UseCompatibleStateImageBehavior = False
        Me.LSV_RebPed.View = System.Windows.Forms.View.Details
        '
        'Lunes
        '
        Me.Lunes.Text = "Lunes"
        '
        'Martes
        '
        Me.Martes.Text = "Martes"
        '
        'Miercoles
        '
        Me.Miercoles.Text = "Miercoles"
        '
        'Jueves
        '
        Me.Jueves.Text = "Jueves"
        '
        'Viernes
        '
        Me.Viernes.Text = "Viernes"
        '
        'Sabado
        '
        Me.Sabado.Text = "Sabado"
        '
        'Domingo
        '
        Me.Domingo.Text = "Domingo"
        '
        'BTN_Mantenimiento
        '
        Me.BTN_Mantenimiento.BorderRadius = 25
        Me.BTN_Mantenimiento.BorderThickness = 2
        Me.BTN_Mantenimiento.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Mantenimiento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Mantenimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Mantenimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Mantenimiento.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Mantenimiento.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Mantenimiento.ForeColor = System.Drawing.Color.White
        Me.BTN_Mantenimiento.Image = CType(resources.GetObject("BTN_Mantenimiento.Image"), System.Drawing.Image)
        Me.BTN_Mantenimiento.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Mantenimiento.ImageSize = New System.Drawing.Size(80, 80)
        Me.BTN_Mantenimiento.Location = New System.Drawing.Point(36, 514)
        Me.BTN_Mantenimiento.Name = "BTN_Mantenimiento"
        Me.BTN_Mantenimiento.Size = New System.Drawing.Size(438, 84)
        Me.BTN_Mantenimiento.TabIndex = 5
        Me.BTN_Mantenimiento.Text = "1. Mantenimiento"
        '
        'BTN_Reporte
        '
        Me.BTN_Reporte.BorderRadius = 25
        Me.BTN_Reporte.BorderThickness = 2
        Me.BTN_Reporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Reporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Reporte.Enabled = False
        Me.BTN_Reporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Reporte.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Reporte.ForeColor = System.Drawing.Color.White
        Me.BTN_Reporte.Image = CType(resources.GetObject("BTN_Reporte.Image"), System.Drawing.Image)
        Me.BTN_Reporte.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Reporte.ImageSize = New System.Drawing.Size(90, 90)
        Me.BTN_Reporte.Location = New System.Drawing.Point(632, 514)
        Me.BTN_Reporte.Name = "BTN_Reporte"
        Me.BTN_Reporte.Size = New System.Drawing.Size(438, 84)
        Me.BTN_Reporte.TabIndex = 6
        Me.BTN_Reporte.Text = "2. Reportes"
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
        Me.CerrarApp.Location = New System.Drawing.Point(1022, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 9
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LSV_RebPed)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(565, 214)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 283)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recibir pedidos proveedores"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LSV_HacerPed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 283)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hacer pedidos proveedores"
        '
        'LSV_HacerPed
        '
        Me.LSV_HacerPed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_HacerPed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.LSV_HacerPed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSV_HacerPed.FullRowSelect = True
        Me.LSV_HacerPed.GridLines = True
        Me.LSV_HacerPed.HideSelection = False
        Me.LSV_HacerPed.Location = New System.Drawing.Point(24, 28)
        Me.LSV_HacerPed.MultiSelect = False
        Me.LSV_HacerPed.Name = "LSV_HacerPed"
        Me.LSV_HacerPed.Size = New System.Drawing.Size(481, 237)
        Me.LSV_HacerPed.TabIndex = 3
        Me.LSV_HacerPed.UseCompatibleStateImageBehavior = False
        Me.LSV_HacerPed.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Lunes"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Martes"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Miercoles"
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Jueves"
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Viernes"
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "Sabado"
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Domingo"
        '
        'LBL_Sucursal
        '
        Me.LBL_Sucursal.AutoSize = True
        Me.LBL_Sucursal.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Sucursal.ForeColor = System.Drawing.Color.White
        Me.LBL_Sucursal.Location = New System.Drawing.Point(12, 136)
        Me.LBL_Sucursal.Name = "LBL_Sucursal"
        Me.LBL_Sucursal.Size = New System.Drawing.Size(69, 16)
        Me.LBL_Sucursal.TabIndex = 22
        Me.LBL_Sucursal.Text = "Sucursal:"
        '
        'LBL_Telefono
        '
        Me.LBL_Telefono.AutoSize = True
        Me.LBL_Telefono.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Telefono.ForeColor = System.Drawing.Color.White
        Me.LBL_Telefono.Location = New System.Drawing.Point(12, 162)
        Me.LBL_Telefono.Name = "LBL_Telefono"
        Me.LBL_Telefono.Size = New System.Drawing.Size(66, 16)
        Me.LBL_Telefono.TabIndex = 23
        Me.LBL_Telefono.Text = "Telefono:"
        '
        'LBL_Email
        '
        Me.LBL_Email.AutoSize = True
        Me.LBL_Email.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Email.ForeColor = System.Drawing.Color.White
        Me.LBL_Email.Location = New System.Drawing.Point(12, 187)
        Me.LBL_Email.Name = "LBL_Email"
        Me.LBL_Email.Size = New System.Drawing.Size(47, 16)
        Me.LBL_Email.TabIndex = 24
        Me.LBL_Email.Text = "Email:"
        '
        'BTN_CajaVenta
        '
        Me.BTN_CajaVenta.BorderRadius = 25
        Me.BTN_CajaVenta.BorderThickness = 2
        Me.BTN_CajaVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CajaVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CajaVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CajaVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CajaVenta.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_CajaVenta.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CajaVenta.ForeColor = System.Drawing.Color.White
        Me.BTN_CajaVenta.Image = CType(resources.GetObject("BTN_CajaVenta.Image"), System.Drawing.Image)
        Me.BTN_CajaVenta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_CajaVenta.ImageSize = New System.Drawing.Size(90, 90)
        Me.BTN_CajaVenta.Location = New System.Drawing.Point(318, 604)
        Me.BTN_CajaVenta.Name = "BTN_CajaVenta"
        Me.BTN_CajaVenta.Size = New System.Drawing.Size(438, 84)
        Me.BTN_CajaVenta.TabIndex = 26
        Me.BTN_CajaVenta.Text = "3. Caja y ventas"
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
        Me.BTN_Config.ImageSize = New System.Drawing.Size(75, 75)
        Me.BTN_Config.Location = New System.Drawing.Point(1022, 84)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_Config.Size = New System.Drawing.Size(66, 66)
        Me.BTN_Config.TabIndex = 27
        '
        'PIC_Logo
        '
        Me.PIC_Logo.BackColor = System.Drawing.Color.Transparent
        Me.PIC_Logo.BorderRadius = 15
        Me.PIC_Logo.ImageRotate = 0!
        Me.PIC_Logo.Location = New System.Drawing.Point(12, 12)
        Me.PIC_Logo.Name = "PIC_Logo"
        Me.PIC_Logo.Size = New System.Drawing.Size(107, 107)
        Me.PIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_Logo.TabIndex = 28
        Me.PIC_Logo.TabStop = False
        '
        'LBL_Version
        '
        Me.LBL_Version.AutoSize = True
        Me.LBL_Version.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Version.ForeColor = System.Drawing.Color.White
        Me.LBL_Version.Location = New System.Drawing.Point(12, 685)
        Me.LBL_Version.Name = "LBL_Version"
        Me.LBL_Version.Size = New System.Drawing.Size(84, 16)
        Me.LBL_Version.TabIndex = 29
        Me.LBL_Version.Text = "Ver. 1.0.0.2"
        '
        'M_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.CerrarApp
        Me.ClientSize = New System.Drawing.Size(1100, 710)
        Me.Controls.Add(Me.LBL_Version)
        Me.Controls.Add(Me.PIC_Logo)
        Me.Controls.Add(Me.BTN_Config)
        Me.Controls.Add(Me.BTN_CajaVenta)
        Me.Controls.Add(Me.LBL_Email)
        Me.Controls.Add(Me.LBL_Telefono)
        Me.Controls.Add(Me.LBL_Sucursal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CerrarApp)
        Me.Controls.Add(Me.BTN_Reporte)
        Me.Controls.Add(Me.BTN_Mantenimiento)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "M_Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LSV_RebPed As ListView
    Friend WithEvents Lunes As ColumnHeader
    Friend WithEvents Martes As ColumnHeader
    Friend WithEvents Miercoles As ColumnHeader
    Friend WithEvents Jueves As ColumnHeader
    Friend WithEvents Viernes As ColumnHeader
    Friend WithEvents Sabado As ColumnHeader
    Friend WithEvents Domingo As ColumnHeader
    Friend WithEvents BTN_Mantenimiento As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Reporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LSV_HacerPed As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents LBL_Email As Label
    Friend WithEvents LBL_Telefono As Label
    Friend WithEvents LBL_Sucursal As Label
    Friend WithEvents BTN_CajaVenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Config As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents PIC_Logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LBL_Version As Label
End Class
