<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmovimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmovimientos))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tcant = New System.Windows.Forms.TextBox()
        Me.ctipo = New System.Windows.Forms.ComboBox()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tunidad = New System.Windows.Forms.TextBox()
        Me.texistencia = New System.Windows.Forms.TextBox()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.toolmenu.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 43)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "MOVIMIENTO"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 15)
        Me.Label8.TabIndex = 147
        Me.Label8.Text = "EXISTENCIAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "OBSERVACIONES"
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(16, 75)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(398, 75)
        Me.tobs.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "CANTIDAD"
        '
        'tcant
        '
        Me.tcant.BackColor = System.Drawing.Color.Yellow
        Me.tcant.Location = New System.Drawing.Point(16, 34)
        Me.tcant.Name = "tcant"
        Me.tcant.Size = New System.Drawing.Size(96, 20)
        Me.tcant.TabIndex = 144
        '
        'ctipo
        '
        Me.ctipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipo.FormattingEnabled = True
        Me.ctipo.Items.AddRange(New Object() {"PIEZA"})
        Me.ctipo.Location = New System.Drawing.Point(171, 34)
        Me.ctipo.Name = "ctipo"
        Me.ctipo.Size = New System.Drawing.Size(243, 21)
        Me.ctipo.TabIndex = 19
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
        'toolmenu
        '
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bsalir})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(460, 46)
        Me.toolmenu.TabIndex = 86
        Me.toolmenu.Text = "ToolStrip1"
        '
        'bsalir
        '
        Me.bsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bsalir.Image = Global.AMBRUNCH.My.Resources.Resources.cancelar
        Me.bsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bsalir.Name = "bsalir"
        Me.bsalir.Size = New System.Drawing.Size(71, 43)
        Me.bsalir.Text = "CANCELAR"
        Me.bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID"
        '
        'tid
        '
        Me.tid.Enabled = False
        Me.tid.Location = New System.Drawing.Point(11, 31)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(70, 20)
        Me.tid.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(96, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "PRODUCTO"
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Label1)
        Me.GroupBox.Controls.Add(Me.tunidad)
        Me.GroupBox.Controls.Add(Me.Label8)
        Me.GroupBox.Controls.Add(Me.texistencia)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.tnombre)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.tid)
        Me.GroupBox.Location = New System.Drawing.Point(10, 99)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(435, 115)
        Me.GroupBox.TabIndex = 84
        Me.GroupBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "UNIDAD M."
        '
        'tunidad
        '
        Me.tunidad.BackColor = System.Drawing.Color.White
        Me.tunidad.Location = New System.Drawing.Point(319, 76)
        Me.tunidad.Name = "tunidad"
        Me.tunidad.ReadOnly = True
        Me.tunidad.Size = New System.Drawing.Size(95, 20)
        Me.tunidad.TabIndex = 151
        '
        'texistencia
        '
        Me.texistencia.BackColor = System.Drawing.Color.White
        Me.texistencia.Location = New System.Drawing.Point(12, 76)
        Me.texistencia.Name = "texistencia"
        Me.texistencia.ReadOnly = True
        Me.texistencia.Size = New System.Drawing.Size(100, 20)
        Me.texistencia.TabIndex = 149
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(87, 31)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(327, 20)
        Me.tnombre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(154, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "TIPO DE MOVIMIENTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tobs)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tcant)
        Me.GroupBox1.Controls.Add(Me.ctipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 175)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        '
        'frmmovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(460, 408)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.toolmenu)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmovimientos"
        Me.Text = "frmmovimientos"
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tcant As TextBox
    Friend WithEvents ctipo As ComboBox
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tunidad As TextBox
    Friend WithEvents texistencia As TextBox
End Class
