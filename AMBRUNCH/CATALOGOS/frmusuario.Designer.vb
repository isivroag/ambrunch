<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmusuario
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pwd2 = New System.Windows.Forms.TextBox()
        Me.pwd1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tlogin = New System.Windows.Forms.TextBox()
        Me.ctipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox.SuspendLayout()
        Me.toolmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 43)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.Button2)
        Me.GroupBox.Controls.Add(Me.Button1)
        Me.GroupBox.Controls.Add(Me.Label7)
        Me.GroupBox.Controls.Add(Me.Label6)
        Me.GroupBox.Controls.Add(Me.pwd2)
        Me.GroupBox.Controls.Add(Me.pwd1)
        Me.GroupBox.Controls.Add(Me.Label4)
        Me.GroupBox.Controls.Add(Me.tlogin)
        Me.GroupBox.Controls.Add(Me.ctipo)
        Me.GroupBox.Controls.Add(Me.Label3)
        Me.GroupBox.Controls.Add(Me.Label5)
        Me.GroupBox.Controls.Add(Me.tnombre)
        Me.GroupBox.Controls.Add(Me.Label2)
        Me.GroupBox.Controls.Add(Me.tid)
        Me.GroupBox.Location = New System.Drawing.Point(15, 97)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(444, 202)
        Me.GroupBox.TabIndex = 84
        Me.GroupBox.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.showblue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(406, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 22)
        Me.Button2.TabIndex = 26
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.showblue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(208, 158)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 22)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "CONFIRMAR CONTRASEÑA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "CONTRASEÑA"
        '
        'pwd2
        '
        Me.pwd2.Location = New System.Drawing.Point(246, 159)
        Me.pwd2.Multiline = True
        Me.pwd2.Name = "pwd2"
        Me.pwd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd2.Size = New System.Drawing.Size(161, 21)
        Me.pwd2.TabIndex = 22
        '
        'pwd1
        '
        Me.pwd1.Location = New System.Drawing.Point(47, 159)
        Me.pwd1.Multiline = True
        Me.pwd1.Name = "pwd1"
        Me.pwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd1.Size = New System.Drawing.Size(161, 21)
        Me.pwd1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "LOGIN"
        '
        'tlogin
        '
        Me.tlogin.Location = New System.Drawing.Point(47, 117)
        Me.tlogin.Multiline = True
        Me.tlogin.Name = "tlogin"
        Me.tlogin.Size = New System.Drawing.Size(387, 21)
        Me.tlogin.TabIndex = 20
        '
        'ctipo
        '
        Me.ctipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ctipo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctipo.FormattingEnabled = True
        Me.ctipo.Items.AddRange(New Object() {"PIEZA"})
        Me.ctipo.Location = New System.Drawing.Point(275, 30)
        Me.ctipo.Name = "ctipo"
        Me.ctipo.Size = New System.Drawing.Size(159, 21)
        Me.ctipo.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(262, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "TIPO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(47, 72)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(387, 20)
        Me.tnombre.TabIndex = 15
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
        Me.tid.Location = New System.Drawing.Point(47, 31)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(109, 20)
        Me.tid.TabIndex = 13
        '
        'toolmenu
        '
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bsalir})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(472, 46)
        Me.toolmenu.TabIndex = 85
        Me.toolmenu.Text = "ToolStrip1"
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
        'frmusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(472, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.toolmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmusuario"
        Me.Text = "frmusuario"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tlogin As TextBox
    Friend WithEvents ctipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pwd2 As TextBox
    Friend WithEvents pwd1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
