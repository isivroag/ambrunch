﻿
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcntaprodvta
    Dim conn As New c_mysqlconn
    Dim fecha As DateTime

    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "select cantidad,nom_prod,precio_prod,unidad_prod,subtotal from vprodvta where date(fecha_vta) = '" & Format(Dtfecha.Value, "yyyy-MM-dd") & "' order by folio_pago")


        formatogrid()

        conn = New c_mysqlconn
        ttotal.Text = conn.Obtener_dato("SELECT sum(subtotal) as dato  FROM vprodvta WHERE date(fecha_vta)='" & Format(Dtfecha.Value, "yyyy-MM-dd") & "' GROUP BY folio_vta")

    End Sub
    Private Sub formatogrid()


        grdetalle.Columns(0).HeaderText = "CANT"

        grdetalle.Columns(1).HeaderText = "PRODUCTO"
        grdetalle.Columns(2).HeaderText = "PRECIO"
        grdetalle.Columns(3).HeaderText = "U. MED"
        grdetalle.Columns(4).HeaderText = "SUBTOTAL"



        grdetalle.AutoResizeColumns()


        grdetalle.Columns(2).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight




    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        fecha = (New Date(Dtfecha.Value.Year, Dtfecha.Value.Month, Dtfecha.Value.Day))


        consulta()

    End Sub

    Private Sub imprimir()


        frmrpt.fecha = fecha
        frmrpt.prodvta()
        frmrpt.ShowDialog()
        frmrpt.BringToFront()

    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click
        fecha = Dtfecha.Value
        imprimir()
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()

    End Sub

    Private Sub bexcel_Click(sender As Object, e As EventArgs) Handles bexcel.Click
        ExportarDatosExcel(grdetalle, "PRODUCTOS VENDIDOS DEL " & Format(Dtfecha.Value, "yyyy-MM-dd"))
    End Sub
    Private Sub frmcntaprodvta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        Dtfecha.Value = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))



        fecha = (New Date(Now.Year, Now.Month, Now.Day))

        consulta()
    End Sub
End Class