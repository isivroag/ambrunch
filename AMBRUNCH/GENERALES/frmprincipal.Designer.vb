﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.toolmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolmenu
        '
        Me.toolmenu.BackColor = System.Drawing.Color.White
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bunidad, Me.bproductos, Me.bcaja, Me.binventario, Me.bsalir})
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmprincipal"
        Me.Text = "frmprincipal"
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
End Class
