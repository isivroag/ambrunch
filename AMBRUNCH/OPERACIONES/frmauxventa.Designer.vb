<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxventa
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tsubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcantidad = New System.Windows.Forms.TextBox()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tprecio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tnom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.bagregar = New System.Windows.Forms.Button()
        Me.tmedida = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(175, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(290, 43)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "AGREGAR PRODUCTO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(382, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "SUBTOTAL"
        '
        'tsubtotal
        '
        Me.tsubtotal.Location = New System.Drawing.Point(385, 125)
        Me.tsubtotal.Name = "tsubtotal"
        Me.tsubtotal.ReadOnly = True
        Me.tsubtotal.Size = New System.Drawing.Size(131, 20)
        Me.tsubtotal.TabIndex = 71
        Me.tsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(154, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "CANTIDAD"
        '
        'tcantidad
        '
        Me.tcantidad.BackColor = System.Drawing.Color.Yellow
        Me.tcantidad.Location = New System.Drawing.Point(157, 125)
        Me.tcantidad.Name = "tcantidad"
        Me.tcantidad.Size = New System.Drawing.Size(113, 20)
        Me.tcantidad.TabIndex = 70
        Me.tcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(24, 65)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(97, 20)
        Me.tid.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(21, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "PRECIO"
        '
        'tprecio
        '
        Me.tprecio.Location = New System.Drawing.Point(24, 125)
        Me.tprecio.Name = "tprecio"
        Me.tprecio.ReadOnly = True
        Me.tprecio.Size = New System.Drawing.Size(127, 20)
        Me.tprecio.TabIndex = 69
        Me.tprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(124, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 15)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "NOMBRE DEL PRODUCTO"
        '
        'tnom
        '
        Me.tnom.Location = New System.Drawing.Point(127, 65)
        Me.tnom.Name = "tnom"
        Me.tnom.ReadOnly = True
        Me.tnom.Size = New System.Drawing.Size(389, 20)
        Me.tnom.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(21, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 15)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "ID"
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.White
        Me.bbuscar.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.SEARCH
        Me.bbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbuscar.ForeColor = System.Drawing.Color.Black
        Me.bbuscar.Location = New System.Drawing.Point(522, 55)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(30, 30)
        Me.bbuscar.TabIndex = 75
        Me.bbuscar.UseVisualStyleBackColor = False
        '
        'bagregar
        '
        Me.bagregar.BackColor = System.Drawing.Color.White
        Me.bagregar.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.PLUS
        Me.bagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bagregar.ForeColor = System.Drawing.Color.Black
        Me.bagregar.Location = New System.Drawing.Point(573, 98)
        Me.bagregar.Name = "bagregar"
        Me.bagregar.Size = New System.Drawing.Size(56, 60)
        Me.bagregar.TabIndex = 74
        Me.bagregar.UseVisualStyleBackColor = False
        '
        'tmedida
        '
        Me.tmedida.Location = New System.Drawing.Point(276, 125)
        Me.tmedida.Name = "tmedida"
        Me.tmedida.ReadOnly = True
        Me.tmedida.Size = New System.Drawing.Size(103, 20)
        Me.tmedida.TabIndex = 77
        Me.tmedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(284, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "U. MEDIDA"
        '
        'frmauxventa
        '
        Me.AcceptButton = Me.bagregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 170)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tmedida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.bagregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tsubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tcantidad)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tprecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tnom)
        Me.Name = "frmauxventa"
        Me.Text = "frmauxventa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tsubtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tcantidad As TextBox
    Friend WithEvents tid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tprecio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tnom As TextBox
    Friend WithEvents bagregar As Button
    Friend WithEvents bbuscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tmedida As TextBox
    Friend WithEvents Label7 As Label
End Class
