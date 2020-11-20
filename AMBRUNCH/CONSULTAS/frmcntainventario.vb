Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntainventario
    Dim conn As New c_mysqlconn
    Dim datos As New c_producto
    Dim texto As String
    Public almacen As String
    Public insumo As String
    Dim tabla As New DataTable
    Public flag As Integer
    Dim sql As String


    Public Sub consulta()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()

        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from vinventario" & sql & " order by id_almacen,id_prod")


        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "ID ALM"
        grdatos.Columns(2).HeaderText = "ALMACEN"
        grdatos.Columns(3).HeaderText = "ID PROD"
        grdatos.Columns(4).HeaderText = "PRODUCTO"
        grdatos.Columns(5).HeaderText = "CANTIDAD"
        grdatos.Columns(6).HeaderText = "UNIDAD"

        grdatos.AutoResizeColumns()
        'grdatos.Columns(2).Width = 250
        grdatos.Columns(4).Width = 200
        'grdatos.Columns(6).Width = 250
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(0).Visible = False
        grdatos.Columns(1).Visible = False
        grdatos.Columns(3).Visible = False
        'grdatos.Columns(5).Visible = False

    End Sub

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from almacen where estado_almacen=1 order by id_almacen")
        calmacen.Items.Clear()
        calmacen.Items.Add("TODOS")
        For Each row As DataRow In tabla.Rows
            calmacen.Items.Add(row("id_almacen") & " " & row("nom_almacen"))
        Next row
    End Sub
    Private Sub frncntainventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdatos, True)
        inicial(sender, e, "INVENTARIO")

        combo()
        calmacen.Text = "TODOS"
        sql = ""
        consulta()
    End Sub



    Private Sub calmacen_MouseUp(sender As Object, e As MouseEventArgs) Handles calmacen.MouseUp
        If calmacen.Text <> "" Then
            If calmacen.Text = "TODOS" Then
                sql = ""
            Else
                sql = " where id_almacen='" & sacarclave(calmacen.Text) & "'"
            End If
            consulta()

        End If
    End Sub

    Private Sub calmacen_TextChanged(sender As Object, e As EventArgs) Handles calmacen.TextChanged
        If calmacen.Text <> "" Then
            If calmacen.Text = "TODOS" Then
                sql = ""
            Else
                sql = " where id_almacen='" & sacarclave(calmacen.Text) & "'"
            End If
            consulta()

        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        ExportarDatosExcel(grdatos, "REPORTE DE INVENTARIO AL " & Now.ToShortDateString.ToString)
    End Sub

    Private Sub bmov_Click(sender As Object, e As EventArgs) Handles bmov.Click



        frmcntamovimientos.Show()
        frmcntamovimientos.almacen = grdatos.CurrentRow.Cells(1).Value
        frmcntamovimientos.insumo = grdatos.CurrentRow.Cells(3).Value
        frmcntamovimientos.cant = grdatos.CurrentRow.Cells(5).Value
        frmcntamovimientos.consulta()
        frmcntamovimientos.BringToFront()
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        datos = New c_producto
        datos.id_prod = grdatos.CurrentRow.Cells(3).Value
        datos.nom_prod = grdatos.CurrentRow.Cells(4).Value
        datos.unidad_prod = grdatos.CurrentRow.Cells(6).Value




        frmmovimientos.Show()
        frmmovimientos.flag = 1
        frmmovimientos.mostrar(datos)
    End Sub


End Class