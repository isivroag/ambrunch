Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntamovimientos
    Dim conn As New c_mysqlconn
    Dim texto As String
    Public almacen As Int64
    Public insumo As Int64
    Public cant As Double
    Dim tabla As New DataTable
    Public flag As Integer
    Dim sql As String
    Public Sub consulta()
        If chmov.CheckState = CheckState.Checked Then
            sql = "limit 15"
        Else
            sql = ""
        End If
        grdatos.DataSource = Nothing
        grdatos.Rows.Clear()
        grdatos.Columns.Clear()

        conn = New c_mysqlconn
        conn.consulta(grdatos, "select fecha_mov,ini_mov,cant_mov,fin_mov,tmov,obs_mov from vmovimiento where id_prod='" & insumo & "' and id_almacen='" & almacen & "' order by fecha_mov desc,id_mov desc " & sql)

        ttotal.Text = cant
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "FECHA"

        grdatos.Columns(1).HeaderText = "INV. INI"
        grdatos.Columns(2).HeaderText = "CANTIDAD"
        grdatos.Columns(3).HeaderText = "INV. FIN"
        grdatos.Columns(4).HeaderText = "TIPO"
        grdatos.Columns(5).HeaderText = "OBSERVACIONES"

        grdatos.AutoResizeColumns()
        grdatos.Columns(1).Width = 80
        grdatos.Columns(2).Width = 80
        grdatos.Columns(3).Width = 80
        grdatos.Columns(5).Width = 150

        grdatos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdatos.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    End Sub

    Private Sub frmcntamovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdatos, True)
        inicial(sender, e, "HISTORIAL DE MOVIMIENTOS")
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        ExportarDatosExcel(grdatos, "HISTORIAL DE MOVIMIENTOS DEL PRODUCTO: ")
    End Sub
End Class