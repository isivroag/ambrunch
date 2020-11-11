Public Class frmprincipal
    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Application.Exit()
    End Sub

    Private Sub bproductoss_Click(sender As Object, e As EventArgs) Handles bproductos.Click
        frmcntaproducto.accion = 0
        frmcntaproducto.Show()
        frmcntaproducto.BringToFront()

    End Sub


    Private Sub bunidad_Click(sender As Object, e As EventArgs) Handles bunidad.Click
        frmcntaunidades.Show()
        frmcntaunidades.BringToFront()
    End Sub

    Private Sub binventario_Click(sender As Object, e As EventArgs) Handles binventario.Click
        frmcntainventario.Show()
        frmcntainventario.BringToFront()
    End Sub

    Private Sub bcaja_Click(sender As Object, e As EventArgs) Handles bcaja.Click

        frmcaja.Show()
        frmcaja.BringToFront()
    End Sub

    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "BIENVENIDO")
    End Sub
End Class