<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_Caja
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(P_Caja))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.LBL_Hora = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_Conteo = New Guna.UI2.WinForms.Guna2Button()
        Me.CerrarApp = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.LBL_Fecha = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_BuscarCliente = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_BuscarProducto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_MODIFICAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_Reprint = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_Total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_RegresarCliente = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_DelFactura = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_TVenta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_CuentaCobrar = New Guna.UI2.WinForms.Guna2Button()
        Me.PIC_Logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTN_GuardarCuenta = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_Fav1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav2 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav4 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav5 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav6 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav7 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Fav8 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.BTN_NProd = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.LBL_Usu = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DGV_Caja = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID_Prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MNU_CONTX.SuspendLayout()
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.DGV_Caja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'LBL_Hora
        '
        Me.LBL_Hora.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Hora.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Hora.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Hora.Location = New System.Drawing.Point(172, 55)
        Me.LBL_Hora.Name = "LBL_Hora"
        Me.LBL_Hora.Size = New System.Drawing.Size(62, 32)
        Me.LBL_Hora.TabIndex = 102
        Me.LBL_Hora.Text = "00:00"
        Me.LBL_Hora.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_Conteo
        '
        Me.BTN_Conteo.BorderColor = System.Drawing.Color.White
        Me.BTN_Conteo.BorderRadius = 25
        Me.BTN_Conteo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Conteo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Conteo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Conteo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Conteo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_Conteo.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Conteo.ForeColor = System.Drawing.Color.Black
        Me.BTN_Conteo.Location = New System.Drawing.Point(11, 561)
        Me.BTN_Conteo.Name = "BTN_Conteo"
        Me.BTN_Conteo.Size = New System.Drawing.Size(602, 53)
        Me.BTN_Conteo.TabIndex = 99
        Me.BTN_Conteo.Text = "[F1] Conteo y cierre de caja"
        '
        'CerrarApp
        '
        Me.CerrarApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.CerrarApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.CerrarApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.CerrarApp.FillColor = System.Drawing.Color.SandyBrown
        Me.CerrarApp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CerrarApp.ForeColor = System.Drawing.Color.White
        Me.CerrarApp.Image = CType(resources.GetObject("CerrarApp.Image"), System.Drawing.Image)
        Me.CerrarApp.ImageSize = New System.Drawing.Size(90, 90)
        Me.CerrarApp.Location = New System.Drawing.Point(1261, 12)
        Me.CerrarApp.Name = "CerrarApp"
        Me.CerrarApp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.CerrarApp.Size = New System.Drawing.Size(66, 66)
        Me.CerrarApp.TabIndex = 46
        '
        'LBL_Fecha
        '
        Me.LBL_Fecha.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Fecha.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Fecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Fecha.Location = New System.Drawing.Point(172, 12)
        Me.LBL_Fecha.Name = "LBL_Fecha"
        Me.LBL_Fecha.Size = New System.Drawing.Size(53, 32)
        Me.LBL_Fecha.TabIndex = 101
        Me.LBL_Fecha.Text = "1/1/1"
        Me.LBL_Fecha.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_BuscarCliente
        '
        Me.TXT_BuscarCliente.BorderRadius = 20
        Me.TXT_BuscarCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarCliente.DefaultText = ""
        Me.TXT_BuscarCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarCliente.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarCliente.Location = New System.Drawing.Point(98, 504)
        Me.TXT_BuscarCliente.Name = "TXT_BuscarCliente"
        Me.TXT_BuscarCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarCliente.PlaceholderText = "Doble click para buscar"
        Me.TXT_BuscarCliente.SelectedText = ""
        Me.TXT_BuscarCliente.Size = New System.Drawing.Size(515, 42)
        Me.TXT_BuscarCliente.TabIndex = 95
        '
        'TXT_BuscarProducto
        '
        Me.TXT_BuscarProducto.BorderRadius = 20
        Me.TXT_BuscarProducto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BuscarProducto.DefaultText = ""
        Me.TXT_BuscarProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BuscarProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_BuscarProducto.ForeColor = System.Drawing.Color.Black
        Me.TXT_BuscarProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BuscarProducto.Location = New System.Drawing.Point(739, 55)
        Me.TXT_BuscarProducto.Name = "TXT_BuscarProducto"
        Me.TXT_BuscarProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BuscarProducto.PlaceholderText = "Doble click para buscar"
        Me.TXT_BuscarProducto.SelectedText = ""
        Me.TXT_BuscarProducto.Size = New System.Drawing.Size(439, 42)
        Me.TXT_BuscarProducto.TabIndex = 97
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
        'BTN_Reprint
        '
        Me.BTN_Reprint.BorderColor = System.Drawing.Color.White
        Me.BTN_Reprint.BorderRadius = 25
        Me.BTN_Reprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Reprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Reprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Reprint.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BTN_Reprint.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_Reprint.ForeColor = System.Drawing.Color.Black
        Me.BTN_Reprint.Location = New System.Drawing.Point(11, 627)
        Me.BTN_Reprint.Name = "BTN_Reprint"
        Me.BTN_Reprint.Size = New System.Drawing.Size(602, 53)
        Me.BTN_Reprint.TabIndex = 104
        Me.BTN_Reprint.Text = "[F2] Reimprimir ticket"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(824, 447)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(146, 32)
        Me.Guna2HtmlLabel5.TabIndex = 99
        Me.Guna2HtmlLabel5.Text = "Total a pagar:"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Guna2HtmlLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(11, 508)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(81, 32)
        Me.Guna2HtmlLabel3.TabIndex = 94
        Me.Guna2HtmlLabel3.Text = "Cliente:"
        Me.Guna2HtmlLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'TXT_Total
        '
        Me.TXT_Total.BorderRadius = 20
        Me.TXT_Total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_Total.DefaultText = ""
        Me.TXT_Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Total.ForeColor = System.Drawing.Color.Black
        Me.TXT_Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_Total.Location = New System.Drawing.Point(976, 442)
        Me.TXT_Total.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_Total.PlaceholderText = ""
        Me.TXT_Total.SelectedText = ""
        Me.TXT_Total.Size = New System.Drawing.Size(329, 42)
        Me.TXT_Total.TabIndex = 100
        '
        'BTN_RegresarCliente
        '
        Me.BTN_RegresarCliente.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarCliente.BorderRadius = 25
        Me.BTN_RegresarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarCliente.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarCliente.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarCliente.ForeColor = System.Drawing.Color.Black
        Me.BTN_RegresarCliente.Location = New System.Drawing.Point(12, 693)
        Me.BTN_RegresarCliente.Name = "BTN_RegresarCliente"
        Me.BTN_RegresarCliente.Size = New System.Drawing.Size(602, 53)
        Me.BTN_RegresarCliente.TabIndex = 106
        Me.BTN_RegresarCliente.Text = "[F3] Regresar"
        '
        'BTN_DelFactura
        '
        Me.BTN_DelFactura.BorderColor = System.Drawing.Color.White
        Me.BTN_DelFactura.BorderRadius = 25
        Me.BTN_DelFactura.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_DelFactura.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_DelFactura.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_DelFactura.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_DelFactura.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_DelFactura.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_DelFactura.ForeColor = System.Drawing.Color.Black
        Me.BTN_DelFactura.Location = New System.Drawing.Point(630, 495)
        Me.BTN_DelFactura.Name = "BTN_DelFactura"
        Me.BTN_DelFactura.Size = New System.Drawing.Size(675, 53)
        Me.BTN_DelFactura.TabIndex = 103
        Me.BTN_DelFactura.Text = "[F4] Borrar Factura"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(98, 55)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(61, 32)
        Me.Guna2HtmlLabel2.TabIndex = 2
        Me.Guna2HtmlLabel2.Text = "Hora:"
        Me.Guna2HtmlLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_TVenta
        '
        Me.BTN_TVenta.BorderColor = System.Drawing.Color.Red
        Me.BTN_TVenta.BorderRadius = 25
        Me.BTN_TVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_TVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_TVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_TVenta.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_TVenta.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_TVenta.ForeColor = System.Drawing.Color.Black
        Me.BTN_TVenta.Location = New System.Drawing.Point(630, 693)
        Me.BTN_TVenta.Name = "BTN_TVenta"
        Me.BTN_TVenta.Size = New System.Drawing.Size(675, 53)
        Me.BTN_TVenta.TabIndex = 107
        Me.BTN_TVenta.Text = "[F7] Terminar venta"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(98, 12)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(68, 32)
        Me.Guna2HtmlLabel1.TabIndex = 1
        Me.Guna2HtmlLabel1.Text = "Fecha:"
        Me.Guna2HtmlLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_CuentaCobrar
        '
        Me.BTN_CuentaCobrar.BorderColor = System.Drawing.Color.White
        Me.BTN_CuentaCobrar.BorderRadius = 25
        Me.BTN_CuentaCobrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaCobrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_CuentaCobrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_CuentaCobrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_CuentaCobrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTN_CuentaCobrar.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_CuentaCobrar.ForeColor = System.Drawing.Color.Black
        Me.BTN_CuentaCobrar.Location = New System.Drawing.Point(630, 561)
        Me.BTN_CuentaCobrar.Name = "BTN_CuentaCobrar"
        Me.BTN_CuentaCobrar.Size = New System.Drawing.Size(675, 53)
        Me.BTN_CuentaCobrar.TabIndex = 108
        Me.BTN_CuentaCobrar.Text = "[F5] Cuentas por cobrar"
        '
        'PIC_Logo
        '
        Me.PIC_Logo.BackColor = System.Drawing.Color.Transparent
        Me.PIC_Logo.BorderRadius = 15
        Me.PIC_Logo.ImageRotate = 0!
        Me.PIC_Logo.Location = New System.Drawing.Point(12, 12)
        Me.PIC_Logo.Name = "PIC_Logo"
        Me.PIC_Logo.Size = New System.Drawing.Size(80, 79)
        Me.PIC_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_Logo.TabIndex = 0
        Me.PIC_Logo.TabStop = False
        '
        'BTN_GuardarCuenta
        '
        Me.BTN_GuardarCuenta.BorderColor = System.Drawing.Color.White
        Me.BTN_GuardarCuenta.BorderRadius = 25
        Me.BTN_GuardarCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_GuardarCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_GuardarCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_GuardarCuenta.FillColor = System.Drawing.Color.LightSeaGreen
        Me.BTN_GuardarCuenta.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_GuardarCuenta.ForeColor = System.Drawing.Color.Black
        Me.BTN_GuardarCuenta.Location = New System.Drawing.Point(630, 627)
        Me.BTN_GuardarCuenta.Name = "BTN_GuardarCuenta"
        Me.BTN_GuardarCuenta.Size = New System.Drawing.Size(675, 53)
        Me.BTN_GuardarCuenta.TabIndex = 109
        Me.BTN_GuardarCuenta.Text = "[F6] Guardar cuenta"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(629, 59)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(104, 32)
        Me.Guna2HtmlLabel4.TabIndex = 96
        Me.Guna2HtmlLabel4.Text = "Producto:"
        Me.Guna2HtmlLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'BTN_Fav1
        '
        Me.BTN_Fav1.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav1.BorderRadius = 25
        Me.BTN_Fav1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav1.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav1.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav1.Location = New System.Drawing.Point(34, 54)
        Me.BTN_Fav1.Name = "BTN_Fav1"
        Me.BTN_Fav1.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav1.TabIndex = 91
        '
        'BTN_Fav2
        '
        Me.BTN_Fav2.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav2.BorderRadius = 25
        Me.BTN_Fav2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav2.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav2.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav2.Location = New System.Drawing.Point(307, 54)
        Me.BTN_Fav2.Name = "BTN_Fav2"
        Me.BTN_Fav2.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav2.TabIndex = 92
        '
        'BTN_Fav3
        '
        Me.BTN_Fav3.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav3.BorderRadius = 25
        Me.BTN_Fav3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav3.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav3.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav3.Location = New System.Drawing.Point(34, 133)
        Me.BTN_Fav3.Name = "BTN_Fav3"
        Me.BTN_Fav3.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav3.TabIndex = 93
        '
        'BTN_Fav4
        '
        Me.BTN_Fav4.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav4.BorderRadius = 25
        Me.BTN_Fav4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav4.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav4.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav4.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav4.Location = New System.Drawing.Point(307, 133)
        Me.BTN_Fav4.Name = "BTN_Fav4"
        Me.BTN_Fav4.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav4.TabIndex = 94
        '
        'BTN_Fav5
        '
        Me.BTN_Fav5.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav5.BorderRadius = 25
        Me.BTN_Fav5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav5.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav5.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav5.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav5.Location = New System.Drawing.Point(34, 215)
        Me.BTN_Fav5.Name = "BTN_Fav5"
        Me.BTN_Fav5.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav5.TabIndex = 95
        '
        'BTN_Fav6
        '
        Me.BTN_Fav6.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav6.BorderRadius = 25
        Me.BTN_Fav6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav6.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav6.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav6.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav6.Location = New System.Drawing.Point(307, 215)
        Me.BTN_Fav6.Name = "BTN_Fav6"
        Me.BTN_Fav6.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav6.TabIndex = 96
        '
        'BTN_Fav7
        '
        Me.BTN_Fav7.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav7.BorderRadius = 25
        Me.BTN_Fav7.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav7.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav7.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav7.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav7.Location = New System.Drawing.Point(34, 296)
        Me.BTN_Fav7.Name = "BTN_Fav7"
        Me.BTN_Fav7.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav7.TabIndex = 97
        '
        'BTN_Fav8
        '
        Me.BTN_Fav8.BorderColor = System.Drawing.Color.White
        Me.BTN_Fav8.BorderRadius = 25
        Me.BTN_Fav8.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Fav8.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Fav8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Fav8.FillColor = System.Drawing.Color.Khaki
        Me.BTN_Fav8.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fav8.ForeColor = System.Drawing.Color.Black
        Me.BTN_Fav8.Location = New System.Drawing.Point(307, 296)
        Me.BTN_Fav8.Name = "BTN_Fav8"
        Me.BTN_Fav8.Size = New System.Drawing.Size(253, 63)
        Me.BTN_Fav8.TabIndex = 98
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav8)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav7)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav6)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav5)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav4)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav3)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav2)
        Me.Guna2GroupBox1.Controls.Add(Me.BTN_Fav1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Gray
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(13, 105)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(601, 379)
        Me.Guna2GroupBox1.TabIndex = 93
        Me.Guna2GroupBox1.Text = "Favoritos"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_NProd
        '
        Me.BTN_NProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NProd.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTN_NProd.Font = New System.Drawing.Font("Snap ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NProd.ForeColor = System.Drawing.Color.White
        Me.BTN_NProd.ImageSize = New System.Drawing.Size(90, 90)
        Me.BTN_NProd.Location = New System.Drawing.Point(1184, 55)
        Me.BTN_NProd.Name = "BTN_NProd"
        Me.BTN_NProd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTN_NProd.Size = New System.Drawing.Size(44, 44)
        Me.BTN_NProd.TabIndex = 110
        Me.BTN_NProd.Text = "+"
        Me.BTN_NProd.TextOffset = New System.Drawing.Point(2, -2)
        '
        'LBL_Usu
        '
        Me.LBL_Usu.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Usu.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LBL_Usu.ForeColor = System.Drawing.SystemColors.Control
        Me.LBL_Usu.Location = New System.Drawing.Point(491, 12)
        Me.LBL_Usu.Name = "LBL_Usu"
        Me.LBL_Usu.Size = New System.Drawing.Size(82, 32)
        Me.LBL_Usu.TabIndex = 113
        Me.LBL_Usu.Text = "Usuario"
        Me.LBL_Usu.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.Control
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(396, 12)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(89, 32)
        Me.Guna2HtmlLabel6.TabIndex = 114
        Me.Guna2HtmlLabel6.Text = "Usuario:"
        Me.Guna2HtmlLabel6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
        '
        'DGV_Caja
        '
        Me.DGV_Caja.AllowUserToDeleteRows = False
        Me.DGV_Caja.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Caja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Caja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Caja.ColumnHeadersHeight = 15
        Me.DGV_Caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_Caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Prod, Me.codigo, Me.Nombre_prod, Me.precioVenta, Me.cantidad, Me.Total})
        Me.DGV_Caja.ContextMenuStrip = Me.MNU_CONTX
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Caja.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_Caja.GridColor = System.Drawing.Color.White
        Me.DGV_Caja.Location = New System.Drawing.Point(629, 105)
        Me.DGV_Caja.Name = "DGV_Caja"
        Me.DGV_Caja.RowHeadersVisible = False
        Me.DGV_Caja.Size = New System.Drawing.Size(675, 331)
        Me.DGV_Caja.TabIndex = 115
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DGV_Caja.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGV_Caja.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Caja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV_Caja.ThemeStyle.HeaderStyle.Height = 15
        Me.DGV_Caja.ThemeStyle.ReadOnly = False
        Me.DGV_Caja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DGV_Caja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGV_Caja.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Caja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.RowsStyle.Height = 22
        Me.DGV_Caja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_Caja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID_Prod
        '
        Me.ID_Prod.HeaderText = "ID"
        Me.ID_Prod.Name = "ID_Prod"
        Me.ID_Prod.ReadOnly = True
        Me.ID_Prod.Visible = False
        '
        'codigo
        '
        Me.codigo.HeaderText = "Codigo"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'Nombre_prod
        '
        Me.Nombre_prod.HeaderText = "Producto"
        Me.Nombre_prod.Name = "Nombre_prod"
        Me.Nombre_prod.ReadOnly = True
        '
        'precioVenta
        '
        Me.precioVenta.HeaderText = "P. Venta"
        Me.precioVenta.Name = "precioVenta"
        Me.precioVenta.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cant."
        Me.cantidad.Name = "cantidad"
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'P_Caja
        '
        Me.AcceptButton = Me.BTN_NProd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1339, 763)
        Me.Controls.Add(Me.DGV_Caja)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.LBL_Usu)
        Me.Controls.Add(Me.BTN_NProd)
        Me.Controls.Add(Me.BTN_GuardarCuenta)
        Me.Controls.Add(Me.BTN_CuentaCobrar)
        Me.Controls.Add(Me.BTN_TVenta)
        Me.Controls.Add(Me.BTN_RegresarCliente)
        Me.Controls.Add(Me.BTN_Reprint)
        Me.Controls.Add(Me.BTN_DelFactura)
        Me.Controls.Add(Me.BTN_Conteo)
        Me.Controls.Add(Me.LBL_Hora)
        Me.Controls.Add(Me.LBL_Fecha)
        Me.Controls.Add(Me.TXT_Total)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.TXT_BuscarProducto)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.TXT_BuscarCliente)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.CerrarApp)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.PIC_Logo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "P_Caja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MNU_CONTX.ResumeLayout(False)
        CType(Me.PIC_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.DGV_Caja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents BTN_GuardarCuenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_CuentaCobrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_TVenta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_RegresarCliente As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Reprint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_DelFactura As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Conteo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_Hora As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_Fecha As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_Total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_BuscarProducto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_BuscarCliente As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTN_Fav8 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav7 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_Fav1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CerrarApp As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PIC_Logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTN_NProd As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_MODIFICAR As ToolStripMenuItem
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents LBL_Usu As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DGV_Caja As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ID_Prod As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_prod As DataGridViewTextBoxColumn
    Friend WithEvents precioVenta As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
