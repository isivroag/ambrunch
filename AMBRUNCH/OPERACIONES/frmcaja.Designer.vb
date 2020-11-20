<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcaja
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcaja))
        Me.GPANEL = New System.Windows.Forms.GroupBox()
        Me.grdetalle = New System.Windows.Forms.DataGridView()
        Me.cfact = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.bquitar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tfolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tcliente = New System.Windows.Forms.TextBox()
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bnuevo = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.bpagar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.GPANEL.SuspendLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPANEL
        '
        Me.GPANEL.BackColor = System.Drawing.Color.Transparent
        Me.GPANEL.Controls.Add(Me.grdetalle)
        Me.GPANEL.Controls.Add(Me.cfact)
        Me.GPANEL.Controls.Add(Me.Label5)
        Me.GPANEL.Controls.Add(Me.ttotal)
        Me.GPANEL.Controls.Add(Me.bquitar)
        Me.GPANEL.Controls.Add(Me.bagregar)
        Me.GPANEL.Controls.Add(Me.Label4)
        Me.GPANEL.Controls.Add(Me.Label1)
        Me.GPANEL.Controls.Add(Me.tfecha)
        Me.GPANEL.Controls.Add(Me.Label6)
        Me.GPANEL.Controls.Add(Me.tfolio)
        Me.GPANEL.Controls.Add(Me.Label3)
        Me.GPANEL.Controls.Add(Me.tcliente)
        Me.GPANEL.Enabled = False
        Me.GPANEL.ForeColor = System.Drawing.Color.Silver
        Me.GPANEL.Location = New System.Drawing.Point(12, 50)
        Me.GPANEL.Name = "GPANEL"
        Me.GPANEL.Size = New System.Drawing.Size(697, 490)
        Me.GPANEL.TabIndex = 60
        Me.GPANEL.TabStop = False
        '
        'grdetalle
        '
        Me.grdetalle.AllowUserToAddRows = False
        Me.grdetalle.AllowUserToDeleteRows = False
        Me.grdetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdetalle.BackgroundColor = System.Drawing.Color.White
        Me.grdetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdetalle.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdetalle.EnableHeadersVisualStyles = False
        Me.grdetalle.GridColor = System.Drawing.Color.White
        Me.grdetalle.Location = New System.Drawing.Point(19, 170)
        Me.grdetalle.MultiSelect = False
        Me.grdetalle.Name = "grdetalle"
        Me.grdetalle.ReadOnly = True
        Me.grdetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdetalle.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grdetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdetalle.Size = New System.Drawing.Size(665, 267)
        Me.grdetalle.TabIndex = 99
        '
        'cfact
        '
        Me.cfact.AutoSize = True
        Me.cfact.ForeColor = System.Drawing.Color.Black
        Me.cfact.Location = New System.Drawing.Point(29, 120)
        Me.cfact.Name = "cfact"
        Me.cfact.Size = New System.Drawing.Size(179, 17)
        Me.cfact.TabIndex = 66
        Me.cfact.Text = "EL CLIENTE DESEA FACTURA"
        Me.cfact.UseVisualStyleBackColor = True
        Me.cfact.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(466, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 32)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "TOTAL"
        '
        'ttotal
        '
        Me.ttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(558, 443)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(126, 35)
        Me.ttotal.TabIndex = 58
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bquitar
        '
        Me.bquitar.BackColor = System.Drawing.Color.White
        Me.bquitar.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.basketmenos
        Me.bquitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bquitar.Location = New System.Drawing.Point(645, 131)
        Me.bquitar.Name = "bquitar"
        Me.bquitar.Size = New System.Drawing.Size(39, 33)
        Me.bquitar.TabIndex = 57
        Me.bquitar.UseVisualStyleBackColor = False
        '
        'bagregar
        '
        Me.bagregar.BackColor = System.Drawing.Color.White
        Me.bagregar.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.basketplus
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bagregar.ForeColor = System.Drawing.Color.Black
        Me.bagregar.Location = New System.Drawing.Point(600, 131)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(39, 33)
        Me.bagregar.TabIndex = 56
        Me.bagregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "DETALLE DE VENTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(555, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 15)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "FECHA"
        '
        'tfecha
        '
        Me.tfecha.CustomFormat = "yyyy-MM-dd"
        Me.tfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tfecha.Location = New System.Drawing.Point(558, 37)
        Me.tfecha.Name = "tfecha"
        Me.tfecha.Size = New System.Drawing.Size(126, 29)
        Me.tfecha.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "FOLIO"
        '
        'tfolio
        '
        Me.tfolio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfolio.Location = New System.Drawing.Point(18, 37)
        Me.tfolio.Name = "tfolio"
        Me.tfolio.Size = New System.Drawing.Size(97, 26)
        Me.tfolio.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "CLIENTE"
        '
        'tcliente
        '
        Me.tcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcliente.Location = New System.Drawing.Point(18, 88)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(666, 26)
        Me.tcliente.TabIndex = 47
        '
        'toolmenu
        '
        Me.toolmenu.BackColor = System.Drawing.Color.White
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnuevo, Me.bsalir, Me.bpagar, Me.bcancelar})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(721, 46)
        Me.toolmenu.TabIndex = 93
        Me.toolmenu.Text = "ToolStrip1"
        '
        'bnuevo
        '
        Me.bnuevo.Image = Global.AMBRUNCH.My.Resources.Resources._NEW
        Me.bnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bnuevo.Name = "bnuevo"
        Me.bnuevo.Size = New System.Drawing.Size(50, 43)
        Me.bnuevo.Text = "NUEVO"
        Me.bnuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bsalir
        '
        Me.bsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bsalir.Image = Global.AMBRUNCH.My.Resources.Resources.SALIR
        Me.bsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(41, 43)
        Me.bsalir.Text = "SALIR"
        Me.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bpagar
        '
        Me.bpagar.Image = Global.AMBRUNCH.My.Resources.Resources.pay
        Me.bpagar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bpagar.Name = "bpagar"
        Me.bpagar.Size = New System.Drawing.Size(48, 43)
        Me.bpagar.Text = "PAGAR"
        Me.bpagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bpagar.Visible = False
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.Image = Global.AMBRUNCH.My.Resources.Resources.cancelar
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(71, 43)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bcancelar.Visible = False
        '
        'frmcaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(721, 548)
        Me.Controls.Add(Me.toolmenu)
        Me.Controls.Add(Me.GPANEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcaja"
        Me.Text = "frmcaja"
        Me.GPANEL.ResumeLayout(False)
        Me.GPANEL.PerformLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GPANEL As GroupBox
    Friend WithEvents cfact As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ttotal As TextBox
    Friend WithEvents bquitar As Button
    Friend WithEvents bagregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tfecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents tfolio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tcliente As TextBox
    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bnuevo As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents bpagar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
    Private WithEvents grdetalle As DataGridView
End Class
