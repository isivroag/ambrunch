Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcortecaja

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

        conn.consulta(grdetalle, "select folio_pago,total_vta,metodo from vventa where vventa.estado_vta=1 and date(fecha_vta) = '" & Format(Dtfecha.Value, "yyyy-MM-dd") & "' order by folio_pago")


        formatogrid()

        conn = New c_mysqlconn
        ttotal.Text = conn.Obtener_dato("SELECT SUM(total_vta) as dato FROM vventa WHERE vventa.estado_vta=1 and date(fecha_vta)='" & Format(Dtfecha.Value, "yyyy-MM-dd") & "' GROUP BY DATE(fecha_vta)")

    End Sub
    Private Sub formatogrid()


        grdetalle.Columns(0).HeaderText = "FOLIO_PAGO"

        grdetalle.Columns(1).HeaderText = "MONTO"
        grdetalle.Columns(2).HeaderText = "METODO"



        grdetalle.AutoResizeColumns()


        grdetalle.Columns(1).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight




    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        fecha = (New Date(Dtfecha.Value.Year, Dtfecha.Value.Month, Dtfecha.Value.Day))
        consulta()

    End Sub

    Private Sub frmcortecaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        inicial(sender, e, "CORTE DE CAJA")
        Dtfecha.Value = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))



        fecha = (New Date(Now.Year, Now.Month, Now.Day))

        consulta()
    End Sub

    Private Sub imprimir()

        frmrpt.imprimir=0
        frmrpt.fecha = fecha
        frmrpt.corteticket()
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
        ExportarDatosExcel(grdetalle, "CORTE DE CAJA DEL " & Format(Dtfecha.Value, "yyyy-MM-dd"))
    End Sub
End Class