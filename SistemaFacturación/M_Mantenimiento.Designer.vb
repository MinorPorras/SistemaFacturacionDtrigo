<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class M_Mantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_Mantenimiento))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BTN_Sucursal = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Usuario = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Proveedor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Cliente = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Categoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Impuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Producto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Marca = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_RegresarMant = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(136, -122)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 1
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
        Me.CerrarApp.Location = New System.Drawing.Point(745, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 10
        '
        'BTN_Sucursal
        '
        Me.BTN_Sucursal.BorderRadius = 25
        Me.BTN_Sucursal.BorderThickness = 2
        Me.BTN_Sucursal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Sucursal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Sucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Sucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Sucursal.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Sucursal.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Sucursal.ForeColor = System.Drawing.Color.White
        Me.BTN_Sucursal.Image = CType(resources.GetObject("BTN_Sucursal.Image"), System.Drawing.Image)
        Me.BTN_Sucursal.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Sucursal.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Sucursal.Location = New System.Drawing.Point(37, 211)
        Me.BTN_Sucursal.Name = "BTN_Sucursal"
        Me.BTN_Sucursal.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Sucursal.TabIndex = 11
        Me.BTN_Sucursal.Text = "1. Sucursales"
        '
        'BTN_Usuario
        '
        Me.BTN_Usuario.BorderRadius = 25
        Me.BTN_Usuario.BorderThickness = 2
        Me.BTN_Usuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Usuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Usuario.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Usuario.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Usuario.ForeColor = System.Drawing.Color.White
        Me.BTN_Usuario.Image = CType(resources.GetObject("BTN_Usuario.Image"), System.Drawing.Image)
        Me.BTN_Usuario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Usuario.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Usuario.Location = New System.Drawing.Point(428, 211)
        Me.BTN_Usuario.Name = "BTN_Usuario"
        Me.BTN_Usuario.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Usuario.TabIndex = 12
        Me.BTN_Usuario.Text = "2. Usuarios"
        '
        'BTN_Proveedor
        '
        Me.BTN_Proveedor.BorderRadius = 25
        Me.BTN_Proveedor.BorderThickness = 2
        Me.BTN_Proveedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Proveedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Proveedor.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Proveedor.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Proveedor.ForeColor = System.Drawing.Color.White
        Me.BTN_Proveedor.Image = CType(resources.GetObject("BTN_Proveedor.Image"), System.Drawing.Image)
        Me.BTN_Proveedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Proveedor.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Proveedor.Location = New System.Drawing.Point(428, 301)
        Me.BTN_Proveedor.Name = "BTN_Proveedor"
        Me.BTN_Proveedor.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Proveedor.TabIndex = 14
        Me.BTN_Proveedor.Text = "4. Proveedores"
        '
        'BTN_Cliente
        '
        Me.BTN_Cliente.BorderRadius = 25
        Me.BTN_Cliente.BorderThickness = 2
        Me.BTN_Cliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Cliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Cliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Cliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Cliente.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Cliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Cliente.ForeColor = System.Drawing.Color.White
        Me.BTN_Cliente.Image = CType(resources.GetObject("BTN_Cliente.Image"), System.Drawing.Image)
        Me.BTN_Cliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Cliente.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Cliente.Location = New System.Drawing.Point(37, 301)
        Me.BTN_Cliente.Name = "BTN_Cliente"
        Me.BTN_Cliente.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Cliente.TabIndex = 13
        Me.BTN_Cliente.Text = "3. Clientes"
        '
        'BTN_Categoria
        '
        Me.BTN_Categoria.BorderRadius = 25
        Me.BTN_Categoria.BorderThickness = 2
        Me.BTN_Categoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Categoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Categoria.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Categoria.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Categoria.ForeColor = System.Drawing.Color.White
        Me.BTN_Categoria.Image = CType(resources.GetObject("BTN_Categoria.Image"), System.Drawing.Image)
        Me.BTN_Categoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Categoria.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Categoria.Location = New System.Drawing.Point(428, 391)
        Me.BTN_Categoria.Name = "BTN_Categoria"
        Me.BTN_Categoria.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Categoria.TabIndex = 16
        Me.BTN_Categoria.Text = "6. Categoría"
        '
        'BTN_Impuesto
        '
        Me.BTN_Impuesto.BorderRadius = 25
        Me.BTN_Impuesto.BorderThickness = 2
        Me.BTN_Impuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Impuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Impuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Impuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Impuesto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Impuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Impuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_Impuesto.Image = CType(resources.GetObject("BTN_Impuesto.Image"), System.Drawing.Image)
        Me.BTN_Impuesto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Impuesto.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Impuesto.Location = New System.Drawing.Point(37, 391)
        Me.BTN_Impuesto.Name = "BTN_Impuesto"
        Me.BTN_Impuesto.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Impuesto.TabIndex = 15
        Me.BTN_Impuesto.Text = "5. Impuestos"
        '
        'BTN_Producto
        '
        Me.BTN_Producto.BorderRadius = 25
        Me.BTN_Producto.BorderThickness = 2
        Me.BTN_Producto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Producto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Producto.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Producto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Producto.ForeColor = System.Drawing.Color.White
        Me.BTN_Producto.Image = CType(resources.GetObject("BTN_Producto.Image"), System.Drawing.Image)
        Me.BTN_Producto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Producto.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Producto.Location = New System.Drawing.Point(428, 481)
        Me.BTN_Producto.Name = "BTN_Producto"
        Me.BTN_Producto.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Producto.TabIndex = 18
        Me.BTN_Producto.Text = "8. Productos"
        '
        'BTN_Marca
        '
        Me.BTN_Marca.BorderRadius = 25
        Me.BTN_Marca.BorderThickness = 2
        Me.BTN_Marca.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Marca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Marca.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Marca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Marca.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Marca.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Marca.ForeColor = System.Drawing.Color.White
        Me.BTN_Marca.Image = CType(resources.GetObject("BTN_Marca.Image"), System.Drawing.Image)
        Me.BTN_Marca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTN_Marca.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_Marca.Location = New System.Drawing.Point(37, 481)
        Me.BTN_Marca.Name = "BTN_Marca"
        Me.BTN_Marca.Size = New System.Drawing.Size(359, 84)
        Me.BTN_Marca.TabIndex = 17
        Me.BTN_Marca.Text = "7. Marcas"
        '
        'BTN_RegresarMant
        '
        Me.BTN_RegresarMant.BorderRadius = 25
        Me.BTN_RegresarMant.BorderThickness = 2
        Me.BTN_RegresarMant.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarMant.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarMant.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarMant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarMant.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarMant.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarMant.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarMant.Image = CType(resources.GetObject("BTN_RegresarMant.Image"), System.Drawing.Image)
        Me.BTN_RegresarMant.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_RegresarMant.Location = New System.Drawing.Point(37, 580)
        Me.BTN_RegresarMant.Name = "BTN_RegresarMant"
        Me.BTN_RegresarMant.Size = New System.Drawing.Size(750, 84)
        Me.BTN_RegresarMant.TabIndex = 20
        Me.BTN_RegresarMant.Text = "0. Regresar"
        '
        'M_Mantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BTN_RegresarMant
        Me.ClientSize = New System.Drawing.Size(823, 676)
        Me.Controls.Add(Me.BTN_RegresarMant)
        Me.Controls.Add(Me.BTN_Producto)
        Me.Controls.Add(Me.BTN_Marca)
        Me.Controls.Add(Me.BTN_Categoria)
        Me.Controls.Add(Me.BTN_Impuesto)
        Me.Controls.Add(Me.BTN_Proveedor)
        Me.Controls.Add(Me.BTN_Cliente)
        Me.Controls.Add(Me.BTN_Usuario)
        Me.Controls.Add(Me.BTN_Sucursal)
        Me.Controls.Add(Me.CerrarApp)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "M_Mantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents BTN_Usuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Sucursal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarMant As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Producto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Marca As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Categoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Impuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Proveedor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Cliente As Guna.UI2.WinForms.Guna2Button
End Class
