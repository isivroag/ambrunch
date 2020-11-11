Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmkardex
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub mostrar(ByVal producto As c_producto)
        datos = producto
        tid.Text = producto.Id_prod
        tnombre.Text = producto.Nom_prod
        cunidad.Text = producto.Unidad_prod
        consulta()

    End Sub
    Public Sub consulta()
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()
        Dim total As Double = 0
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from vinventario where id_prod='" & datos.Id_prod & "' order by id_prod")
        If grdatos.Rows.Count > 0 Then
            For Each row As DataGridViewRow In grdatos.Rows
                total += row.Cells(5).Value
            Next

        End If
        ttotal.Text = total
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "ID ALM"
        grdatos.Columns(2).HeaderText = "ALMACEN"
        grdatos.Columns(3).HeaderText = "ID PRODUCTO"
        grdatos.Columns(4).HeaderText = "PRODUCTO"
        grdatos.Columns(5).HeaderText = "CANTIDAD"
        grdatos.Columns(6).HeaderText = "UNIDAD"

        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 100
        grdatos.Columns(1).Width = 100
        grdatos.Columns(2).Width = 100
        grdatos.Columns(3).Width = 100
        grdatos.Columns(4).Width = 100
        grdatos.Columns(6).Width = 250
        grdatos.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdatos.Columns(0).Visible = False
        grdatos.Columns(3).Visible = False
        grdatos.Columns(4).Visible = False
        ' grdatos.Columns(2).Visible = False

    End Sub
    Private Sub frmkardex_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdatos, True)
        inicial(sender, e, "DETALLE DE INVENTARIO")
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        frmmovimientos.Show()
        frmmovimientos.mostrar(datos)
        frmmovimientos.flag = 2
    End Sub


End Class