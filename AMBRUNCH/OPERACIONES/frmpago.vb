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

                pago.Letra = EnLetras(ttotal.Text)
                conn = New c_mysqlconn
                conn.insertarnuevo(pago)
                imprimir()
                Dispose()
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


End Class