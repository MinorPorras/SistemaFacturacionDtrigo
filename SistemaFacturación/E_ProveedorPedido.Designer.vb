<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_ProveedorPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_ProveedorPedido))
        Me.MNU_CONTX = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.MNU_ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBX_RecibirPedido = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBX_DiaPedido = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.LSV_Pedido = New System.Windows.Forms.ListView()
        Me.HacerPed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.rebPed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBL_Proveedor = New System.Windows.Forms.Label()
        Me.BTN_RegresarPed = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_NProv = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MNU_CONTX.SuspendLayout()
        Me.SuspendLayout()
        '
        'MNU_CONTX
        '
        Me.MNU_CONTX.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MNU_CONTX.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_ELIMINAR})
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
        Me.MNU_CONTX.Size = New System.Drawing.Size(118, 26)
        '
        'MNU_ELIMINAR
        '
        Me.MNU_ELIMINAR.Name = "MNU_ELIMINAR"
        Me.MNU_ELIMINAR.Size = New System.Drawing.Size(117, 22)
        Me.MNU_ELIMINAR.Text = "Eliminar"
        Me.MNU_ELIMINAR.Visible = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 25
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(427, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(312, 23)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Día en el que se recibe el pedido:"
        '
        'CBX_RecibirPedido
        '
        Me.CBX_RecibirPedido.AutoRoundedCorners = True
        Me.CBX_RecibirPedido.BackColor = System.Drawing.Color.Transparent
        Me.CBX_RecibirPedido.BorderRadius = 17
        Me.CBX_RecibirPedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_RecibirPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_RecibirPedido.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_RecibirPedido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_RecibirPedido.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_RecibirPedido.ForeColor = System.Drawing.Color.Black
        Me.CBX_RecibirPedido.ItemHeight = 30
        Me.CBX_RecibirPedido.Items.AddRange(New Object() {"", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.CBX_RecibirPedido.Location = New System.Drawing.Point(472, 240)
        Me.CBX_RecibirPedido.Name = "CBX_RecibirPedido"
        Me.CBX_RecibirPedido.Size = New System.Drawing.Size(213, 36)
        Me.CBX_RecibirPedido.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(427, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Día en el que se hace el pedido:"
        '
        'CBX_DiaPedido
        '
        Me.CBX_DiaPedido.AutoRoundedCorners = True
        Me.CBX_DiaPedido.BackColor = System.Drawing.Color.Transparent
        Me.CBX_DiaPedido.BorderRadius = 17
        Me.CBX_DiaPedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CBX_DiaPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBX_DiaPedido.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_DiaPedido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CBX_DiaPedido.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CBX_DiaPedido.ForeColor = System.Drawing.Color.Black
        Me.CBX_DiaPedido.ItemHeight = 30
        Me.CBX_DiaPedido.Items.AddRange(New Object() {"", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.CBX_DiaPedido.Location = New System.Drawing.Point(472, 121)
        Me.CBX_DiaPedido.Name = "CBX_DiaPedido"
        Me.CBX_DiaPedido.Size = New System.Drawing.Size(213, 36)
        Me.CBX_DiaPedido.TabIndex = 59
        '
        'LSV_Pedido
        '
        Me.LSV_Pedido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LSV_Pedido.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HacerPed, Me.rebPed})
        Me.LSV_Pedido.ContextMenuStrip = Me.MNU_CONTX
        Me.LSV_Pedido.FullRowSelect = True
        Me.LSV_Pedido.GridLines = True
        Me.LSV_Pedido.HideSelection = False
        Me.LSV_Pedido.Location = New System.Drawing.Point(32, 66)
        Me.LSV_Pedido.MultiSelect = False
        Me.LSV_Pedido.Name = "LSV_Pedido"
        Me.LSV_Pedido.Size = New System.Drawing.Size(360, 259)
        Me.LSV_Pedido.TabIndex = 63
        Me.LSV_Pedido.UseCompatibleStateImageBehavior = False
        Me.LSV_Pedido.View = System.Windows.Forms.View.Details
        '
        'HacerPed
        '
        Me.HacerPed.Text = "Hacer el pedido"
        Me.HacerPed.Width = 179
        '
        'rebPed
        '
        Me.rebPed.Text = "Recibir el pedido"
        Me.rebPed.Width = 176
        '
        'LBL_Proveedor
        '
        Me.LBL_Proveedor.AutoSize = True
        Me.LBL_Proveedor.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Proveedor.ForeColor = System.Drawing.Color.White
        Me.LBL_Proveedor.Location = New System.Drawing.Point(138, 40)
        Me.LBL_Proveedor.Name = "LBL_Proveedor"
        Me.LBL_Proveedor.Size = New System.Drawing.Size(103, 23)
        Me.LBL_Proveedor.TabIndex = 64
        Me.LBL_Proveedor.Text = "Proveedor"
        '
        'BTN_RegresarPed
        '
        Me.BTN_RegresarPed.BorderColor = System.Drawing.Color.Red
        Me.BTN_RegresarPed.BorderRadius = 25
        Me.BTN_RegresarPed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_RegresarPed.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_RegresarPed.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_RegresarPed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_RegresarPed.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BTN_RegresarPed.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_RegresarPed.ForeColor = System.Drawing.Color.White
        Me.BTN_RegresarPed.Image = CType(resources.GetObject("BTN_RegresarPed.Image"), System.Drawing.Image)
        Me.BTN_RegresarPed.ImageSize = New System.Drawing.Size(40, 40)
        Me.BTN_RegresarPed.Location = New System.Drawing.Point(32, 350)
        Me.BTN_RegresarPed.Name = "BTN_RegresarPed"
        Me.BTN_RegresarPed.Size = New System.Drawing.Size(322, 57)
        Me.BTN_RegresarPed.TabIndex = 65
        Me.BTN_RegresarPed.Text = "Regresar"
        '
        'BTN_NProv
        '
        Me.BTN_NProv.AutoRoundedCorners = True
        Me.BTN_NProv.BorderColor = System.Drawing.Color.Red
        Me.BTN_NProv.BorderRadius = 27
        Me.BTN_NProv.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTN_NProv.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_NProv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_NProv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_NProv.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.BTN_NProv.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold)
        Me.BTN_NProv.ForeColor = System.Drawing.Color.White
        Me.BTN_NProv.Image = CType(resources.GetObject("BTN_NProv.Image"), System.Drawing.Image)
        Me.BTN_NProv.ImageSize = New System.Drawing.Size(60, 60)
        Me.BTN_NProv.Location = New System.Drawing.Point(413, 350)
        Me.BTN_NProv.Name = "BTN_NProv"
        Me.BTN_NProv.Size = New System.Drawing.Size(313, 57)
        Me.BTN_NProv.TabIndex = 66
        Me.BTN_NProv.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Proveedor: "
        '
        'E_ProveedorPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CancelButton = Me.BTN_RegresarPed
        Me.ClientSize = New System.Drawing.Size(766, 436)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_NProv)
        Me.Controls.Add(Me.BTN_RegresarPed)
        Me.Controls.Add(Me.LBL_Proveedor)
        Me.Controls.Add(Me.LSV_Pedido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBX_RecibirPedido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBX_DiaPedido)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "E_ProveedorPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Días de pedidos"
        Me.MNU_CONTX.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MNU_CONTX As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MNU_ELIMINAR As ToolStripMenuItem
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Label6 As Label
    Friend WithEvents CBX_RecibirPedido As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBX_DiaPedido As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents LBL_Proveedor As Label
    Friend WithEvents LSV_Pedido As ListView
    Friend WithEvents HacerPed As ColumnHeader
    Friend WithEvents rebPed As ColumnHeader
    Friend WithEvents BTN_RegresarPed As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_NProv As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
End Class
