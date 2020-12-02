Imports MySql.Data.MySqlClient
Public Class frmrpt
    Public folio As String
    Public fecha As Date
    Public fechaini As Date
    Public fechafin As Date
    Dim seguir As Integer
    Public Sub ticket()
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptticket


        Dim sql As String
        sql = "SELECT vventa1.folio_vta, vventa1.folio_pago, vventa1.cliente, vventa1.total_vta, vventa1.dinero, vventa1.cambio,vventa1.saldo,vventa1.descuento, vventa1.letra, vventa1.metodo, det_vta1.nom_prod, det_vta1.cantidad, det_vta1.unidad_prod, det_vta1.precio_prod, det_vta1.subtotal, vventa1.fecha_vta " &
            "FROM ambrunch.vventa vventa1 INNER JOIN ambrunch.det_vta det_vta1 ON vventa1.folio_vta=det_vta1.folio_vta " &
            "where vventa1.folio_vta='" & folio & "'" &
            "GROUP BY vventa1.folio_vta ORDER BY vventa1.folio_vta"





        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)
            seguir = 1

            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS EN EL PAGO", vbInformation + vbOKOnly, "PAGO")
            seguir = 0
        End If

    End Sub

    Public Sub corteticket()
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptcaja


        Dim sql As String
        sql = " SELECT vventa1.folio_pago, vventa1.fecha_vta, vventa1.total_vta, vventa1.metodo " &
               "FROM   ambrunch.vventa vventa1 " &
               "WHERE vventa1.estado_vta=1 and date(vventa1.fecha_vta)='" & Format(fecha, "yyyy-MM-dd") & "'"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)
            seguir = 1

            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS", vbInformation + vbOKOnly, "CORTE DE CAJA")
            seguir = 0
        End If

    End Sub

    Public Sub prodvta()
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptprodvta


        Dim sql As String
        sql = "SELECT vprodvta1.fecha_vta, vprodvta1.nom_prod, vprodvta1.cantidad, vprodvta1.precio_prod, vprodvta1.subtotal, vprodvta1.unidad_prod " &
               "FROM ambrunch.vprodvta vprodvta1 " &
               "WHERE Date(vprodvta1.fecha_vta) between'" & Format(fechaini, "yyyy-MM-dd") & "' and '" & Format(fechafin, "yyyy-MM-dd") & "'"

        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)
            seguir = 1

            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS", vbInformation + vbOKOnly, "PRODUCTOS VENDIDOS")
            seguir = 0
        End If

    End Sub

    Private Sub frmrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ExtendedMethods.DoubleBuffered(ReportViewer, True)
        inicial(sender, e, "IMPRESIÓN")
        'If seguir = 1 Then
        '    ReportViewer.Refresh()
        'Else
        '    Dispose()
        'End If

        'For Each Ctrl As Control In Me.ReportViewer.Controls
        '    If TypeOf Ctrl Is ToolStrip Then
        '        For Each Obj As Object In CType(Ctrl, ToolStrip).Items
        '            If TypeOf Obj Is ToolStripButton Then
        '                'Se agrega el disparador del evento
        '                AddHandler CType(Obj, ToolStripButton).Click, AddressOf printButton_Click
        '            End If
        '        Next
        '    End If
        'Next
    End Sub
    Public Sub inventario()
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptinventario


        Dim sql As String
        sql = "SELECT vinventario1.nom_insumo, vinventario1.cant_insumo, vinventario1.nom_unidad " &
                "FROM vinventario vinventario1"




        tabla = conn.consulta(sql)
        If tabla.Rows.Count > 0 Then
            ReportViewer.ReportSource = REPORTE
            REPORTE.SetDataSource(tabla)
            seguir = 1

            'ReportViewer.Refresh()
        Else
            MsgBox("NO EXISTE REGISTROS", vbInformation + vbOKOnly, "INVENTARIO")
            seguir = 0
        End If
    End Sub
    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles ReportViewer.Load

    End Sub
End Class