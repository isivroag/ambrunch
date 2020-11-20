<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntaprodvta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmcntaprodvta))
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.bexcel = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.bimprimir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ttotal = New System.Windows.Forms.TextBox()
        Me.Dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.bbuscar = New System.Windows.Forms.Button()
        Me.grdetalle = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtFin = New System.Windows.Forms.DateTimePicker()
        Me.DtInicio = New System.Windows.Forms.DateTimePicker()
        Me.toolmenu.SuspendLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolmenu
        '
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bexcel, Me.bsalir, Me.bimprimir})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(603, 46)
        Me.toolmenu.TabIndex = 97
        Me.toolmenu.Text = "ToolStrip1"
        '
        'bexcel
        '
        Me.bexcel.Image = Global.AMBRUNCH.My.Resources.Resources.excel
        Me.bexcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bexcel.Name = "bexcel"
        Me.bexcel.Size = New System.Drawing.Size(66, 43)
        Me.bexcel.Text = "EXPORTAR"
        Me.bexcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'bimprimir
        '
        Me.bimprimir.Image = Global.AMBRUNCH.My.Resources.Resources.print
        Me.bimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bimprimir.Name = "bimprimir"
        Me.bimprimir.Size = New System.Drawing.Size(63, 43)
        Me.bimprimir.Text = "IMPRIMIR"
        Me.bimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(142, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 43)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "PRODUCTOS VENDIDOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 437)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "TOTAL"
        '
        'ttotal
        '
        Me.ttotal.Location = New System.Drawing.Point(482, 435)
        Me.ttotal.Name = "ttotal"
        Me.ttotal.Size = New System.Drawing.Size(109, 20)
        Me.ttotal.TabIndex = 95
        '
        'Dtfecha
        '
        Me.Dtfecha.CustomFormat = "yyyy-MM-dd"
        Me.Dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtfecha.Location = New System.Drawing.Point(448, 105)
        Me.Dtfecha.Name = "Dtfecha"
        Me.Dtfecha.Size = New System.Drawing.Size(107, 20)
        Me.Dtfecha.TabIndex = 91
        '
        'bbuscar
        '
        Me.bbuscar.BackColor = System.Drawing.Color.White
        Me.bbuscar.BackgroundImage = Global.AMBRUNCH.My.Resources.Resources.SEARCH
        Me.bbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbuscar.ForeColor = System.Drawing.Color.Black
        Me.bbuscar.Location = New System.Drawing.Point(561, 100)
        Me.bbuscar.Name = "bbuscar"
        Me.bbuscar.Size = New System.Drawing.Size(30, 30)
        Me.bbuscar.TabIndex = 92
        Me.bbuscar.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdetalle.EnableHeadersVisualStyles = False
        Me.grdetalle.GridColor = System.Drawing.Color.White
        Me.grdetalle.Location = New System.Drawing.Point(12, 136)
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
        Me.grdetalle.Size = New System.Drawing.Size(579, 293)
        Me.grdetalle.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(267, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 15)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "HASTA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(101, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 15)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "DESDE:"
        '
        'DtFin
        '
        Me.DtFin.CustomFormat = "yyyy-MM-dd"
        Me.DtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFin.Location = New System.Drawing.Point(321, 105)
        Me.DtFin.Name = "DtFin"
        Me.DtFin.Size = New System.Drawing.Size(107, 20)
        Me.DtFin.TabIndex = 100
        '
        'DtInicio
        '
        Me.DtInicio.CustomFormat = "yyyy-MM-dd"
        Me.DtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtInicio.Location = New System.Drawing.Point(154, 105)
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.Size = New System.Drawing.Size(107, 20)
        Me.DtInicio.TabIndex = 99
        '
        'frmcntaprodvta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 470)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DtFin)
        Me.Controls.Add(Me.DtInicio)
        Me.Controls.Add(Me.grdetalle)
        Me.Controls.Add(Me.toolmenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ttotal)
        Me.Controls.Add(Me.bbuscar)
        Me.Controls.Add(Me.Dtfecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmcntaprodvta"
        Me.Text = "frmcntaprodvta"
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        CType(Me.grdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bexcel As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Friend WithEvents bimprimir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ttotal As TextBox
    Friend WithEvents bbuscar As Button
    Friend WithEvents Dtfecha As DateTimePicker
    Private WithEvents grdetalle As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtFin As DateTimePicker
    Friend WithEvents DtInicio As DateTimePicker
End Class
