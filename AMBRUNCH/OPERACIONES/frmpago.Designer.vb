<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpago))
        Me.cmetodo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tcambio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tpago = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.bguardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmetodo
        '
        Me.cmetodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmetodo.FormattingEnabled = True
        Me.cmetodo.Items.AddRange(New Object() {"EFECTIVO", "TARJETA"})
        Me.cmetodo.Location = New System.Drawing.Point(280, 75)
        Me.cmetodo.Name = "cmetodo"
        Me.cmetodo.Size = New System.Drawing.Size(160, 39)
        Me.cmetodo.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 31)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "METODO DE PAGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "CAMBIO"
        '
        'tcambio
        '
        Me.tcambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcambio.Location = New System.Drawing.Point(280, 178)
        Me.tcambio.Name = "tcambio"
        Me.tcambio.Size = New System.Drawing.Size(160, 38)
        Me.tcambio.TabIndex = 71
        Me.tcambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 31)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "PAGO"
        '
        'tpago
        '
        Me.tpago.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpago.Location = New System.Drawing.Point(280, 127)
        Me.tpago.Name = "tpago"
        Me.tpago.Size = New System.Drawing.Size(160, 38)
        Me.tpago.TabIndex = 69
        Me.tpago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 31)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "TOTAL"
        '
        'ttotal
        '
        Me.ttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttotal.Location = New System.Drawing.Point(280, 24)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(160, 38)
        Me.ttotal.TabIndex = 67
        Me.ttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'bguardar
        '
        Me.bguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.bguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bguardar.FlatAppearance.BorderSize = 5
        Me.bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bguardar.ForeColor = System.Drawing.Color.White
        Me.bguardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.bguardar.Location = New System.Drawing.Point(12, 244)
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(428, 39)
        Me.bguardar.TabIndex = 74
        Me.bguardar.Text = "PAGAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bguardar.UseVisualStyleBackColor = False
        '
        'frmpago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(454, 303)
        Me.Controls.Add(Me.bguardar)
        Me.Controls.Add(Me.cmetodo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tcambio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tpago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ttotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmpago"
        Me.Text = "frmpago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmetodo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tcambio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tpago As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ttotal As TextBox
    Friend WithEvents bguardar As Button
End Class
