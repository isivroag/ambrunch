<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcancelar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcancelar))
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toolmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolmenu
        '
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bsalir, Me.bguardar})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(451, 46)
        Me.toolmenu.TabIndex = 91
        Me.toolmenu.Text = "ToolStrip1"
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
        'bguardar
        '
        Me.bguardar.Image = Global.AMBRUNCH.My.Resources.Resources.save
        Me.bguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(65, 43)
        Me.bguardar.Text = "GUARDAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(22, 120)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(414, 78)
        Me.tobs.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(417, 15)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "ESCRIBA LAS RAZONES POR LAS CUALES ESTA CANCELANDO ESTA VENTA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 43)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "CANCELACIÓN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'frmcancelar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(451, 210)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tobs)
        Me.Controls.Add(Me.toolmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcancelar"
        Me.Text = "frmcancelar"
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
