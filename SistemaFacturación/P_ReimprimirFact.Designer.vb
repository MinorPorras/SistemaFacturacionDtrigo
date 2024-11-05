<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class P_ReimprimirFact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_ReimprimirFact))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.LSV_Factura = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.num_factura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fecha_emision = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nUsuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comentario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.entrega_cliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vuelto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipo_venta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cobrada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_REIMPRIMIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_RegresarFact = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_ImpReciente = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_BuscarFact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'LSV_Factura
        '
        Me.LSV_Factura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Factura.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.num_factura, Me.fecha_emision, Me.nCliente, Me.nUsuario, Me.comentario, Me.total, Me.entrega_cliente, Me.vuelto, Me.tipo_venta, Me.cobrada})
        Me.LSV_Factura.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Factura.FullRowSelect = True
        Me.LSV_Factura.GridLines = True
        Me.LSV_Factura.HideSelection = False
        Me.LSV_Factura.Location = New System.Drawing.Point(41, 259)
        Me.LSV_Factura.MultiSelect = False
        Me.LSV_Factura.Name = "LSV_Factura"
        Me.LSV_Factura.Size = New System.Drawing.Size(1166, 387)
        Me.LSV_Factura.TabIndex = 52
        Me.LSV_Factura.UseCompatibleStateImageBehavior = False
        Me.LSV_Factura.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'num_factura
        '
        Me.num_factura.Text = "# factura"
        '
        'fecha_emision
        '
        Me.fecha_emision.Text = "Fecha de emisión"
        Me.fecha_emision.Width = 101
        '
        'nCliente
        '
        Me.nCliente.Text = "Cliente"
        Me.nCliente.Width = 47
        '
        'nUsuario
        '
        Me.nUsuario.Text = "Usuario"
        '
        'comentario
        '
        Me.comentario.Text = "Comentario"
        Me.comentario.Width = 73
        '
        'total
        '
        Me.total.Text = "Total"
        '
        'entrega_cliente
        '
        Me.entrega_cliente.Text = "Entrega cliente"
        Me.entrega_cliente.Width = 94
        '
        'vuelto
        '
        Me.vuelto.Text = "Vuelto"
        '
        'tipo_venta
        '
        Me.tipo_venta.Text = "tipo_venta"
        Me.tipo_venta.Width = 73
        '
        'cobrada
        '
        Me.cobrada.Text = "Cobrada"
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_REIMPRIMIR})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(134, 26)
        '
        'MNU_REIMPRIMIR
        '
        Me.MNU_REIMPRIMIR.Name = "MNU_REIMPRIMIR"
        Me.MNU_REIMPRIMIR.Size = New System.Drawing.Size(133, 22)
        Me.MNU_REIMPRIMIR.Text = "Reimprimir"
        Me.MNU_REIMPRIMIR.Visible = False
        '
        'BTN_RegresarFact
        '
        Me.BTN_RegresarFact.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarFact.BorderRadius = 25
        Me.BTN_RegresarFact.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarFact.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarFact.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarFact.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarFact.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarFact.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarFact.Image = CType(resources.GetObject("BTN_RegresarFact.Image"), System.Drawing.Image)
        Me.BTN_RegresarFact.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarFact.Location = New System.Drawing.Point(78, 665)
        Me.BTN_RegresarFact.Name = "BTN_RegresarFact"
        Me.BTN_RegresarFact.Size = New System.Drawing.Size(473, 57)
        Me.BTN_RegresarFact.TabIndex = 51
        Me.BTN_RegresarFact.Text = "Regresar"
        '
        'BTN_ImpReciente
        '
        Me.BTN_ImpReciente.BorderColor = System.Drawing.Color.Red
        Me.BTN_ImpReciente.BorderRadius = 25
        Me.BTN_ImpReciente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImpReciente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_ImpReciente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_ImpReciente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_ImpReciente.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_ImpReciente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_ImpReciente.ForeColor = System.Drawing.Color.White
        Me.BTN_ImpReciente.Image = CType(resources.GetObject("BTN_ImpReciente.Image"), System.Drawing.Image)
        Me.BTN_ImpReciente.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_ImpReciente.Location = New System.Drawing.Point(670, 665)
        Me.BTN_ImpReciente.Name = "BTN_ImpReciente"
        Me.BTN_ImpReciente.Size = New System.Drawing.Size(475, 57)
        Me.BTN_ImpReciente.TabIndex = 50
        Me.BTN_ImpReciente.Text = "Imprimir más reciente"
        '
        'TXT_BuscarFact
        '
        Me.TXT_BuscarFact.BorderRadius = 20
        Me.TXT_BuscarFact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarFact.DefaultText = ""
        Me.TXT_BuscarFact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarFact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarFact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarFact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarFact.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarFact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarFact.Location = New System.Drawing.Point(41, 199)
        Me.TXT_BuscarFact.Name = "TXT_BuscarFact"
        Me.TXT_BuscarFact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarFact.PlaceholderText = "Buscar proveedor"
        Me.TXT_BuscarFact.SelectedText = ""
        Me.TXT_BuscarFact.Size = New System.Drawing.Size(1166, 42)
        Me.TXT_BuscarFact.TabIndex = 49
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(346, -124)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(539, 442)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 48
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
        Me.CerrarApp.Location = New System.Drawing.Point(1141, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 47
        '
        'PrintDocument
        '
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'P_ReimprimirFact
        '
        Me.AcceptButton = Me.BTN_ImpReciente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarFact
        Me.ClientSize = New System.Drawing.Size(1219, 746)
        Me.Controls.Add(Me.LSV_Factura)
        Me.Controls.Add(Me.BTN_RegresarFact)
        Me.Controls.Add(Me.BTN_ImpReciente)
        Me.Controls.Add(Me.TXT_BuscarFact)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.CerrarApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "P_ReimprimirFact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reimprimir factura"
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents LSV_Factura As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents num_factura As ColumnHeader
    Friend WithEvents fecha_emision As ColumnHeader
    Friend WithEvents nCliente As ColumnHeader
    Friend WithEvents nUsuario As ColumnHeader
    Friend WithEvents comentario As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents entrega_cliente As ColumnHeader
    Friend WithEvents vuelto As ColumnHeader
    Friend WithEvents tipo_venta As ColumnHeader
    Friend WithEvents cobrada As ColumnHeader
    Friend WithEvents BTN_RegresarFact As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ImpReciente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_BuscarFact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_REIMPRIMIR As ToolStripMenuItem
    Friend WithEvents PrintDocument As Printing.PrintDocument
    Friend WithEvents PrintDialog As PrintDialog
End Class
