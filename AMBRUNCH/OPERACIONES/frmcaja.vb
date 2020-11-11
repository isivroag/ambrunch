Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcaja
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim tabla As New DataTable
    Public flag As Integer
    Public folio As Integer
    Dim TOTAL As Double
    Dim id_reg As Integer
    Public Sub limpiar()
        tfolio.Text = ""
        tcliente.Text = ""

        tfecha.Value = Now
        ttotal.Text = "0.00"
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        grdetalle.ColumnCount = 8
        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdetalle.Columns(0).HeaderText = "ID"
        grdetalle.Columns(1).HeaderText = "FOLIO"
        grdetalle.Columns(2).HeaderText = "CLAVE"
        grdetalle.Columns(3).HeaderText = "PRODUCTO"
        grdetalle.Columns(4).HeaderText = "CANTIDAD"
        grdetalle.Columns(5).HeaderText = "PRECIO"
        grdetalle.Columns(6).HeaderText = "SUBTOTAL"
        grdetalle.Columns(7).HeaderText = "ESTADO"



        grdetalle.AutoResizeColumns()
        'grdetalle.Columns(1).Width = 280
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdetalle.Columns(5).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(6).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdetalle.Columns(0).Visible = False
        grdetalle.Columns(2).Visible = False
        grdetalle.Columns(1).Visible = False
        grdetalle.Columns(7).Visible = False




    End Sub
    Public Sub deshabilitar()
        GPANEL.Enabled = False
        limpiar()
        bnuevo.Visible = True
        bpagar.Visible = False
        bcancelar.Visible = False
        bsalir.Visible = False

    End Sub



    Private Sub frmcaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        If flag = 1 Then
            limpiar()
            tfecha.Value = Now
            grdetalle.ColumnCount = 8
            formatogrid()
        End If
    End Sub
    Private Sub habilitar()
        bnuevo.Visible = False
        bpagar.Visible = True
        bcancelar.Visible = True

    End Sub


    Private Sub insertar()
        folio = 0
        conn = New c_mysqlconn
        If conn.ventanueva() Then
            conn = New c_mysqlconn
            folio = conn.Obtener_ID("select max(folio_vta) as max_id from venta")

        End If
        tfolio.Text = folio
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        'frmauxvta.Show()
        'frmauxvta.BringToFront()
        'frmauxvta.folio = folio



        'frmbuscarp.folio = folio
        'frmbuscarp.Show()
        'frmbuscarp.BringToFront()
        'frmbuscarp.tbuscar.Focus()

    End Sub



    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        limpiar()
        GPANEL.Enabled = True
        habilitar()
        insertar()
        tcliente.Text = "PUBLICO EN GENERAL"
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        conn.borrarventa(tfolio.Text)
        deshabilitar()
        limpiar()
        conn = New c_mysqlconn

    End Sub
End Class