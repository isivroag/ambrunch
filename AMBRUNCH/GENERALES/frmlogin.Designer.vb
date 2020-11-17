<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlogin))
        Me.btaceptar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tpassword = New System.Windows.Forms.TextBox()
        Me.tlogin = New System.Windows.Forms.TextBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btaceptar
        '
        Me.btaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btaceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btaceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btaceptar.FlatAppearance.BorderSize = 5
        Me.btaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btaceptar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btaceptar.ForeColor = System.Drawing.Color.White
        Me.btaceptar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btaceptar.Location = New System.Drawing.Point(1, 115)
        Me.btaceptar.Name = "btaceptar"
        Me.btaceptar.Size = New System.Drawing.Size(387, 39)
        Me.btaceptar.TabIndex = 34
        Me.btaceptar.Text = "ENTRAR"
        Me.btaceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btaceptar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(89, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "CONTRASEÑA"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Black
        Me.label1.Location = New System.Drawing.Point(89, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 20)
        Me.label1.TabIndex = 32
        Me.label1.Text = "USUARIO"
        '
        'tpassword
        '
        Me.tpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpassword.Location = New System.Drawing.Point(195, 63)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpassword.Size = New System.Drawing.Size(171, 26)
        Me.tpassword.TabIndex = 31
        '
        'tlogin
        '
        Me.tlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlogin.Location = New System.Drawing.Point(195, 22)
        Me.tlogin.Name = "tlogin"
        Me.tlogin.Size = New System.Drawing.Size(171, 26)
        Me.tlogin.TabIndex = 30
        '
        'imagen
        '
        Me.imagen.Image = Global.AMBRUNCH.My.Resources.Resources.login2
        Me.imagen.Location = New System.Drawing.Point(15, 18)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(68, 68)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen.TabIndex = 35
        Me.imagen.TabStop = False
        '
        'frmlogin
        '
        Me.AcceptButton = Me.btaceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 166)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.btaceptar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.tpassword)
        Me.Controls.Add(Me.tlogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmlogin"
        Me.Text = "INICIO SISTEMA PUNTO DE VENTA"
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagen As PictureBox
    Friend WithEvents btaceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents tpassword As TextBox
    Friend WithEvents tlogin As TextBox
End Class
