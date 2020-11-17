<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal
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
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bunidad = New System.Windows.Forms.ToolStripButton()
        Me.bproductos = New System.Windows.Forms.ToolStripButton()
        Me.bcaja = New System.Windows.Forms.ToolStripButton()
        Me.binventario = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.bcntaticket = New System.Windows.Forms.ToolStripButton()
        Me.bcorte = New System.Windows.Forms.ToolStripButton()
        Me.bprodvta = New System.Windows.Forms.ToolStripButton()
        Me.toolmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolmenu
        '
        Me.toolmenu.BackColor = System.Drawing.Color.White
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bunidad, Me.bproductos, Me.bcaja, Me.binventario, Me.bsalir, Me.bcntaticket, Me.bcorte, Me.bprodvta})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(1088, 54)
        Me.toolmenu.TabIndex = 79
        Me.toolmenu.Text = "ToolStrip1"
        '
        'bunidad
        '
        Me.bunidad.Image = Global.AMBRUNCH.My.Resources.Resources.unidades
        Me.bunidad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bunidad.Name = "bunidad"
        Me.bunidad.Size = New System.Drawing.Size(67, 51)
        Me.bunidad.Text = "UNIDADES"
        Me.bunidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bproductos
        '
        Me.bproductos.Image = Global.AMBRUNCH.My.Resources.Resources.ingredientes
        Me.bproductos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bproductos.Name = "bproductos"
        Me.bproductos.Size = New System.Drawing.Size(78, 51)
        Me.bproductos.Text = "PRODUCTOS"
        Me.bproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bcaja
        '
        Me.bcaja.Image = Global.AMBRUNCH.My.Resources.Resources.CASH
        Me.bcaja.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcaja.Name = "bcaja"
        Me.bcaja.Size = New System.Drawing.Size(40, 51)
        Me.bcaja.Text = "CAJA"
        Me.bcaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'binventario
        '
        Me.binventario.Image = Global.AMBRUNCH.My.Resources.Resources.inventario
        Me.binventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.binventario.Name = "binventario"
        Me.binventario.Size = New System.Drawing.Size(77, 51)
        Me.binventario.Text = "INVENTARIO"
        Me.binventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bsalir
        '
        Me.bsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bsalir.Image = Global.AMBRUNCH.My.Resources.Resources.SALIR
        Me.bsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(41, 51)
        Me.bsalir.Text = "SALIR"
        Me.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bcntaticket
        '
        Me.bcntaticket.Image = Global.AMBRUNCH.My.Resources.Resources.rptcaja
        Me.bcntaticket.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcntaticket.Name = "bcntaticket"
        Me.bcntaticket.Size = New System.Drawing.Size(63, 51)
        Me.bcntaticket.Text = "RPT CAJA"
        Me.bcntaticket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bcorte
        '
        Me.bcorte.Image = Global.AMBRUNCH.My.Resources.Resources.CORTE
        Me.bcorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcorte.Name = "bcorte"
        Me.bcorte.Size = New System.Drawing.Size(46, 51)
        Me.bcorte.Text = "CORTE"
        Me.bcorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bprodvta
        '
        Me.bprodvta.Image = Global.AMBRUNCH.My.Resources.Resources.BAG
        Me.bprodvta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bprodvta.Name = "bprodvta"
        Me.bprodvta.Size = New System.Drawing.Size(58, 51)
        Me.bprodvta.Text = "PROD VT"
        Me.bprodvta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.fondo800
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1088, 654)
        Me.Controls.Add(Me.toolmenu)
        Me.DoubleBuffered = True
        Me.Name = "frmprincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmprincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bunidad As ToolStripButton
    Friend WithEvents bproductos As ToolStripButton
    Friend WithEvents bcaja As ToolStripButton
    Friend WithEvents binventario As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents bcntaticket As ToolStripButton
    Friend WithEvents bcorte As ToolStripButton
    Friend WithEvents bprodvta As ToolStripButton
End Class
