
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcntaprodvta
    Dim conn As New c_mysqlconn
    Dim fecha As DateTime
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "select cantidad,nom_prod,precio_prod,unidad_prod,subtotal from vprodvta where date(fecha_vta) between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "' order by folio_pago")


        formatogrid()

        conn = New c_mysqlconn
        ttotal.Text = conn.Obtener_dato("SELECT sum(subtotal) as dato FROM vprodvta WHERE date(fecha_vta) between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "'")

        conn = New c_mysqlconn
        tdescuentos.Text = conn.Obtener_dato("SELECT sum(descuento) as dato FROM vventa WHERE vventa.estado_vta=1 and date(fecha_vta) between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "'")

        conn = New c_mysqlconn
        tpagos.Text = conn.Obtener_dato("SELECT sum(total_vta) as dato FROM vventa WHERE vventa.estado_vta=1 and  date(fecha_vta) between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "'")

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

        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()

    End Sub

    Private Sub imprimir()

        frmrpt.imprimir = 0
        frmrpt.fechaini = fechaini
        frmrpt.fechafin = fechafin
        frmrpt.prodvta()
        frmrpt.ShowDialog()
        frmrpt.BringToFront()

    End Sub

    Private Sub bimprimir_Click(sender As Object, e As EventArgs) Handles bimprimir.Click

        imprimir()
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()

    End Sub

    Private Sub bexcel_Click(sender As Object, e As EventArgs) Handles bexcel.Click
        ExportarDatosExcel(grdetalle, "PRODUCTOS VENDIDOS DEL " & Format(DtInicio.Value, "yyyy-MM-dd") & " AL " & Format(DtFin.Value, "yyyy-MM-dd"))
    End Sub
    Private Sub frmcntaprodvta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        inicial(sender, e, "PRODUCTOS VENDIDOS")

        DtInicio.Value = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        DtFin.Value = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))


        fechaini = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        fechafin = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))


        fecha = (New Date(Now.Year, Now.Month, Now.Day))

        consulta()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub DtFin_ValueChanged(sender As Object, e As EventArgs) Handles DtFin.ValueChanged

    End Sub

    Private Sub DtInicio_ValueChanged(sender As Object, e As EventArgs) Handles DtInicio.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class