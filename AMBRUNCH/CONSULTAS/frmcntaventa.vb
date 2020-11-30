Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntaventa
    Dim conn As New c_mysqlconn
    Dim fechaini As DateTime
    Dim fechafin As DateTime
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Dim tablaprodvta As New DataTable
    Dim tablaprod As New DataTable
    Public flag As Integer
    Public folio As String
    Public observaciones As String

    Public Sub consulta()
        conn = New c_mysqlconn
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn.consulta(grdetalle, "select folio_vta,folio_pago,fecha_vta,cliente,total_vta,metodo,estado_vta,nom_estado from vventa where fecha_vta between '" & Format(fechaini, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(fechafin, "yyyy-MM-dd HH:mm:ss") & "'")


        formatogrid()



    End Sub
    Private Sub formatogrid()

        grdetalle.Columns(0).HeaderText = "FOLIO_VTA"
        grdetalle.Columns(1).HeaderText = "FOLIO_PAGO"
        grdetalle.Columns(2).HeaderText = "FECHA"
        grdetalle.Columns(3).HeaderText = "CLIENTE"
        grdetalle.Columns(4).HeaderText = "TOTAL"
        grdetalle.Columns(5).HeaderText = "METODO"
        grdetalle.Columns(6).HeaderText = "ESTADO"
        grdetalle.Columns(7).HeaderText = "ESTADO"

        grdetalle.Columns(1).Visible = False
        grdetalle.Columns(6).Visible = False

        grdetalle.AutoResizeColumns()
        grdetalle.Columns(3).Width = 200

        grdetalle.Columns(4).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight






    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        fechaini = (New Date(DtInicio.Value.Year, DtInicio.Value.Month, DtInicio.Value.Day, 0, 0, 0))
        fechafin = (New Date(DtFin.Value.Year, DtFin.Value.Month, DtFin.Value.Day, 23, 59, 59))

        consulta()

    End Sub
    Private Sub frmcntaventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        inicial(sender, e, "CONSULTA DE VENTAS")
        DtInicio.Value = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        DtFin.Value = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))


        fechaini = (New Date(Now.Year, Now.Month, Now.Day, 0, 0, 0))
        fechafin = (New Date(Now.Year, Now.Month, Now.Day, 23, 59, 59))
        consulta()
    End Sub

    Public Sub cancelarventa()
        conn = New c_mysqlconn
        Dim foliovta As Integer
        'CANCELAR VENTA
        foliovta = grdetalle.CurrentRow.Cells(0).Value
        conn.eliminar(foliovta, 1, UCase(observaciones))
        'CONSULTAR PRODUCTOS VENDIDOS
        conn = New c_mysqlconn
        tablaprodvta = conn.consulta("select * from det_vta where folio_vta='" & foliovta & "'")

        For Each row As DataRow In tablaprodvta.Rows

            Dim idprod As Integer
            Dim cantidad As Double
            Dim unidad As String
            idprod = row.Item("id_prod").ToString
            cantidad = row.Item("cantidad").ToString
            unidad = row.Item("unidad_prod").ToString

            Dim contable As Integer
            conn = New c_mysqlconn
            contable = conn.Obtener_dato("select contable_prod as dato from producto where id_prod='" & idprod & "'")

            Dim existencias As Double
            conn = New c_mysqlconn
            existencias = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & idprod & "' and id_almacen=1")


            Dim movimiento As New c_movimiento
            If contable = 1 Then
                movimiento.Id_almacen = 1
                movimiento.Id_prod = idprod
                movimiento.Tipo_mov = 2
                movimiento.Cant_mov = cantidad
                movimiento.Ini_mov = existencias
                movimiento.Fin_mov = existencias + cantidad
                movimiento.Unidad_mov = unidad
                movimiento.Obs_mov = "CANCELACION VENTA " & foliovta
                movimiento.Fecha_mov = Format(Now, "yyyy-MM-dd HH:mm:sss")
            Else
                movimiento.Id_almacen = 1
                movimiento.Id_prod = idprod
                movimiento.Tipo_mov = 2
                movimiento.Cant_mov = cantidad
                movimiento.Ini_mov = 0
                movimiento.Fin_mov = 0
                movimiento.Unidad_mov = unidad
                movimiento.Obs_mov = "CANCELACION VENTA " & foliovta
                movimiento.Fecha_mov = Format(Now, "yyyy-MM-dd HH:mm:sss")

            End If
            conn = New c_mysqlconn
            conn.insertarmov(movimiento)

            conn = New c_mysqlconn
            conn.actualizarproducto(movimiento.Id_prod, movimiento.Id_almacen, movimiento.Fin_mov)

        Next
        MsgBox("VENTA CANCELADA", vbInformation + vbOKOnly, "CANCELAR")






        consulta()
    End Sub



    Private Sub bimprimir_Click(sender As Object, e As EventArgs)
        folio = Convert.ToString(grdetalle.CurrentRow().Cells(0).Value)

    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        If grdetalle.SelectedRows.Count > 0 Then
            frmcancelar.show()
            frmcancelar.BringToFront()



        End If
    End Sub
End Class