<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_Impuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Impuestos))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LSV_Impuesto = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.descripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.porcentaje = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarImpuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NImpuesto = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MNU_CONTX.SuspendLayout()
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
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, -95)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(397, 328)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 25
        Me.Guna2PictureBox1.TabStop = False
        '
        'LSV_Impuesto
        '
        Me.LSV_Impuesto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Impuesto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.codigo, Me.descripcion, Me.porcentaje})
        Me.LSV_Impuesto.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Impuesto.FullRowSelect = True
        Me.LSV_Impuesto.GridLines = True
        Me.LSV_Impuesto.HideSelection = False
        Me.LSV_Impuesto.Location = New System.Drawing.Point(23, 149)
        Me.LSV_Impuesto.MultiSelect = False
        Me.LSV_Impuesto.Name = "LSV_Impuesto"
        Me.LSV_Impuesto.Size = New System.Drawing.Size(385, 167)
        Me.LSV_Impuesto.TabIndex = 30
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
        Me.descripcion.Width = 111
        '
        'porcentaje
        '
        Me.porcentaje.Text = "porcentaje"
        Me.porcentaje.Width = 87
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
        Me.BTN_RegresarImpuesto.Location = New System.Drawing.Point(12, 322)
        Me.BTN_RegresarImpuesto.Name = "BTN_RegresarImpuesto"
        Me.BTN_RegresarImpuesto.Size = New System.Drawing.Size(200, 57)
        Me.BTN_RegresarImpuesto.TabIndex = 32
        Me.BTN_RegresarImpuesto.Text = "Regresar"
        '
        'BTN_NImpuesto
        '
        Me.BTN_NImpuesto.BorderColor = System.Drawing.Color.Red
        Me.BTN_NImpuesto.BorderRadius = 25
        Me.BTN_NImpuesto.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NImpuesto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NImpuesto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NImpuesto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NImpuesto.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NImpuesto.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NImpuesto.ForeColor = System.Drawing.Color.White
        Me.BTN_NImpuesto.Image = CType(resources.GetObject("BTN_NImpuesto.Image"), System.Drawing.Image)
        Me.BTN_NImpuesto.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_NImpuesto.Location = New System.Drawing.Point(218, 322)
        Me.BTN_NImpuesto.Name = "BTN_NImpuesto"
        Me.BTN_NImpuesto.Size = New System.Drawing.Size(208, 57)
        Me.BTN_NImpuesto.TabIndex = 31
        Me.BTN_NImpuesto.Text = "Agregar"
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
        Me.CerrarApp.ImageSize = New System.Drawing.Size(50, 50)
        Me.CerrarApp.Location = New System.Drawing.Point(389, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(37, 41)
        Me.CerrarApp.TabIndex = 33
        '
        'P_Impuestos
        '
        Me.AcceptButton = Me.BTN_NImpuesto
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarImpuesto
        Me.ClientSize = New System.Drawing.Size(438, 406)
        Me.Controls.Add(Me.CerrarApp)
        Me.Controls.Add(Me.BTN_RegresarImpuesto)
        Me.Controls.Add(Me.BTN_NImpuesto)
        Me.Controls.Add(Me.LSV_Impuesto)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Impuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "P_Impuestos"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LSV_Impuesto As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents codigo As ColumnHeader
    Friend WithEvents descripcion As ColumnHeader
    Friend WithEvents porcentaje As ColumnHeader
    Friend WithEvents BTN_RegresarImpuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NImpuesto As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
End Class
