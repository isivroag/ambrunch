﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcntaproducto
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
        Me.ltitulo = New System.Windows.Forms.Label()
        Me.toolmenu = New System.Windows.Forms.ToolStrip()
        Me.grdatos = New System.Windows.Forms.DataGridView()
        Me.bnuevo = New System.Windows.Forms.ToolStripButton()
        Me.bcambiar = New System.Windows.Forms.ToolStripButton()
        Me.beliminar = New System.Windows.Forms.ToolStripButton()
        Me.binventario = New System.Windows.Forms.ToolStripButton()
        Me.bsalir = New System.Windows.Forms.ToolStripButton()
        Me.toolmenu.SuspendLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ltitulo
        '
        Me.ltitulo.AutoSize = True
        Me.ltitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltitulo.Location = New System.Drawing.Point(127, 46)
        Me.ltitulo.Name = "ltitulo"
        Me.ltitulo.Size = New System.Drawing.Size(364, 43)
        Me.ltitulo.TabIndex = 81
        Me.ltitulo.Text = "CONSULTA DE PRODUCTOS"
        Me.ltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ltitulo.UseCompatibleTextRendering = True
        '
        'toolmenu
        '
        Me.toolmenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bnuevo, Me.bcambiar, Me.beliminar, Me.binventario, Me.bsalir})
        Me.toolmenu.Location = New System.Drawing.Point(0, 0)
        Me.toolmenu.Name = "toolmenu"
        Me.toolmenu.Size = New System.Drawing.Size(624, 46)
        Me.toolmenu.TabIndex = 80
        Me.toolmenu.Text = "ToolStrip1"
        '
        'grdatos
        '
        Me.grdatos.AllowUserToAddRows = False
        Me.grdatos.AllowUserToDeleteRows = False
        Me.grdatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdatos.BackgroundColor = System.Drawing.Color.White
        Me.grdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdatos.ColumnHeadersHeight = 30
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdatos.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grdatos.EnableHeadersVisualStyles = False
        Me.grdatos.GridColor = System.Drawing.Color.White
        Me.grdatos.Location = New System.Drawing.Point(12, 92)
        Me.grdatos.MultiSelect = False
        Me.grdatos.Name = "grdatos"
        Me.grdatos.ReadOnly = True
        Me.grdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdatos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.grdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdatos.Size = New System.Drawing.Size(600, 306)
        Me.grdatos.TabIndex = 79
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
        'bcambiar
        '
        Me.bcambiar.Image = Global.AMBRUNCH.My.Resources.Resources.EDIT
        Me.bcambiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcambiar.Name = "bcambiar"
        Me.bcambiar.Size = New System.Drawing.Size(63, 43)
        Me.bcambiar.Text = "CAMBIAR"
        Me.bcambiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'beliminar
        '
        Me.beliminar.Image = Global.AMBRUNCH.My.Resources.Resources.DELETE
        Me.beliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.beliminar.Name = "beliminar"
        Me.beliminar.Size = New System.Drawing.Size(64, 43)
        Me.beliminar.Text = "ELIMINAR"
        Me.beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'binventario
        '
        Me.binventario.Image = Global.AMBRUNCH.My.Resources.Resources.listainventario
        Me.binventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.binventario.Name = "binventario"
        Me.binventario.Size = New System.Drawing.Size(77, 43)
        Me.binventario.Text = "INVENTARIO"
        Me.binventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'frmcntaproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(624, 410)
        Me.Controls.Add(Me.ltitulo)
        Me.Controls.Add(Me.toolmenu)
        Me.Controls.Add(Me.grdatos)
        Me.Name = "frmcntaproducto"
        Me.Text = "frmcntaproducto"
        Me.toolmenu.ResumeLayout(False)
        Me.toolmenu.PerformLayout()
        CType(Me.grdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ltitulo As Label
    Friend WithEvents toolmenu As ToolStrip
    Friend WithEvents bnuevo As ToolStripButton
    Friend WithEvents bcambiar As ToolStripButton
    Friend WithEvents beliminar As ToolStripButton
    Friend WithEvents binventario As ToolStripButton
    Friend WithEvents bsalir As ToolStripButton
    Private WithEvents grdatos As DataGridView
End Class
