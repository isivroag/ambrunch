Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntaticket
    Dim conn As New c_mysqlconn
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer
    Public folio As String

    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        Dim opc As String


        conn.consulta(grdetalle, "select folio_vta,folio_pago,fecha_vta,cliente,total_vta,metodo from vventa where fecha_vta between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "'")


        formatogrid()



    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO_VTA"
        grdetalle.Columns(0).HeaderText = "FOLIO_PAGO"
        grdetalle.Columns(1).HeaderText = "FECHA"
        grdetalle.Columns(2).HeaderText = "CLIENTE"
        grdetalle.Columns(4).HeaderText = "TOTAL"
        grdetalle.Columns(5).HeaderText = "METODO"


        grdetalle.AutoResizeColumns()
        grdetalle.Columns(3).Width = 200
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        'grdetalle.Columns(0).Visible = False
        'grdetalle.Columns(1).Visible = False
        'grdetalle.Columns(7).Visible = False




    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()

    End Sub
    Private Sub frmcntaticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        DtInicio.Value = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        DtFin.Value = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))


        fechaini = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        fechafin = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))
        consulta()

    End Sub

    Private Sub grdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentClick

    End Sub



    Private Sub imprimir()


        frmrpt.folio = folio
        frmrpt.ticket()
        frmrpt.ShowDialog()
        frmrpt.BringToFront()

    End Sub

    Private Sub grdetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellDoubleClick
        folio = Convert.ToString(grdetalle.Rows(e.RowIndex).Cells(0).Value)
        imprimir()

    End Sub
End Class