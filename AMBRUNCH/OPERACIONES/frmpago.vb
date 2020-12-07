Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmpago
    Public foliovta As Int64
    Public saldo As Double
    Dim conn As c_mysqlconn
    Dim pago As c_pago
    Private Sub frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "PAGAR")
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Len(tpago.Text) > 0 And Len(cmetodo.Text) > 0 Then
            If CDbl(tpago.Text) >= CDbl(ttotal.Text) Then
                sender.visible = False
                pago = New c_pago
                pago.Folio_vta = foliovta
                pago.Total_pago = ttotal.Text
                pago.Dinero = tpago.Text
                pago.Cambio = tcambio.Text
                pago.Metodo = cmetodo.Text
                pago.Saldo = tsaldo.Text
                pago.Descuento = tdescuento.Text

                pago.Letra = EnLetras(ttotal.Text)
                conn = New c_mysqlconn
                conn.insertarnuevo(pago)
                imprimir()
                Dispose()

                frmcaja.inventario()
                frmcaja.limpiar()
                frmcaja.bnuevo.Visible = True
                frmcaja.bcancelar.Visible = False
                frmcaja.bsalir.Visible = True
                frmcaja.bpagar.Visible = False
                frmcaja.GPANEL.Enabled = False
                frmcaja.Valoperacion = 0

            End If
        End If
    End Sub

    Private Sub imprimir()


        frmrpt.folio = foliovta
        frmrpt.imprimir = 1
        frmrpt.ticket()
        frmrpt.ShowDialog()
        frmrpt.BringToFront()

    End Sub
    Private Sub calcular()
        If Len(tpago.Text) > 0 And Len(ttotal.Text) > 0 Then
            If CDbl(tpago.Text) > CDbl(ttotal.Text) Then
                tcambio.Text = tpago.Text - ttotal.Text
            Else
                tcambio.Text = "0.00"
            End If
        Else
            tcambio.Text = "0.00"
        End If

    End Sub
    Private Sub tpago_TextChanged(sender As Object, e As EventArgs) Handles tpago.TextChanged
        calcular()
    End Sub

    Private Sub cmetodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmetodo.SelectedIndexChanged
        If cmetodo.Text = "EFECTIVO" Then
            tpago.Text = "0.00"
            tcambio.Text = "0.00"
        Else
            tpago.Text = ttotal.Text
            tcambio.Text = "0.00"
        End If
    End Sub

    Private Sub tpor_TextChanged(sender As Object, e As EventArgs) Handles tpor.TextChanged

    End Sub

    Private Sub tpor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpor.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tdescuento_TextChanged(sender As Object, e As EventArgs) Handles tdescuento.TextChanged

    End Sub

    Private Sub tdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tdescuento.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tpago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tpago.KeyPress
        solonumeros(sender, e)
    End Sub

    Private Sub tdescuento_LostFocus(sender As Object, e As EventArgs) Handles tdescuento.LostFocus
        calculardesc()
    End Sub

    Private Sub calculardesc()
        ttotal.Text = CDbl(tsaldo.Text) - CDbl(tdescuento.Text)
        tpor.Text = Math.Round((CDbl(tdescuento.Text) / CDbl(tsaldo.Text)) * 100, 2)
    End Sub

    Private Sub calcularpor()

        ttotal.Text = Math.Round(CDbl(tsaldo.Text) * (1 - (CDbl(tpor.Text) / 100)), 2)
        tdescuento.Text = CDbl(tsaldo.Text) - CDbl(ttotal.Text)
    End Sub

    Private Sub tpor_LostFocus(sender As Object, e As EventArgs) Handles tpor.LostFocus
        calcularpor()
    End Sub
End Class