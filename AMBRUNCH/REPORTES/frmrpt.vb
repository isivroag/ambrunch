Imports MySql.Data.MySqlClient
Public Class frmrpt
    Public folio As String
    Dim seguir As Integer
    Public Sub ticket()
        Dim conn As New c_mysqlconn
        Dim tabla As New DataTable
        Dim REPORTE As New rptticket


        Dim sql As String
        sql = "SELECT vventa1.folio_vta, vventa1.folio_pago, vventa1.cliente, vventa1.total_vta, vventa1.dinero, vventa1.cambio, vventa1.letra, vventa1.metodo, det_vta1.nom_prod, det_vta1.cantidad, det_vta1.unidad_prod, det_vta1.precio_prod, det_vta1.subtotal, vventa1.fecha_vta " &
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

    Private Sub frmrpt_Load(sender As Object, e As EventArgs) Handles Me.Load
        ExtendedMethods.DoubleBuffered(ReportViewer, True)
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

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles ReportViewer.Load

    End Sub
End Class