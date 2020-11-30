
Public Class frmcancelar
    Private Sub frmcancelar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CANCELAR VENTA")
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tobs.Text) > 0 Then
            If (MsgBox("ESTA SEGURO DE CANCELAR ESTA VENTA", vbQuestion + vbYesNo, "CANCELAR") = MsgBoxResult.Yes) Then
                frmcntaventa.observaciones = tobs.Text
                frmcntaventa.cancelarventa()

                Dispose()
            End If
        Else
            MsgBox("NO ES POSIBLE CANCELAR LA VENTA, SIN REGISTAR UN MOTIVO", vbInformation + vbOKOnly, "CANCELAR")
        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub
End Class