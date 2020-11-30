Public Class frmprincipal

    Public usuario As Integer


    Private Sub permisos()

        Select Case usuario
            Case 1 'ROOT


            Case 2 'ADMIN
                For Each men As ToolStripButton In toolmenu.Items
                    If men.Name = "busuario" Then
                        men.Visible = False
                    Else
                        men.Visible = True
                    End If
                Next

            Case 3 'CAJA
                For Each men As ToolStripButton In toolmenu.Items
                    If men.Name = "bcaja" Or men.Name = "bcntaticket" Or men.Name = "bcorte" Or men.Name = "bprodvta" Or men.Name = "bsalir" Then
                        men.Visible = True
                    Else
                        men.Visible = False
                    End If
                Next

            Case 4 'FISCAL

            Case 5


        End Select

    End Sub
    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("¿DESEA SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "SALIR")
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
            End
        Else
            Exit Sub
        End If
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
        permisos()
    End Sub

    Private Sub bcntaticket_Click(sender As Object, e As EventArgs) Handles bcntaticket.Click


        frmcntaticket.Show()
        frmcntaticket.BringToFront()

    End Sub

    Private Sub bcorte_Click(sender As Object, e As EventArgs) Handles bcorte.Click



        frmcortecaja.Show()
        frmcortecaja.BringToFront()

    End Sub

    Private Sub bprodvta_Click(sender As Object, e As EventArgs) Handles bprodvta.Click

        frmcntaprodvta.Show()
        frmcntaprodvta.BringToFront()

    End Sub

    Private Sub panelcontenedor_Paint(sender As Object, e As PaintEventArgs) Handles panelcontenedor.Paint

    End Sub

    Private Sub busuario_Click(sender As Object, e As EventArgs) Handles busuario.Click
        frmcntausuarios.accion = 0
        frmcntausuarios.Show()
        frmcntausuarios.BringToFront()

    End Sub

    Private Sub bcntavta_Click(sender As Object, e As EventArgs) Handles bcntavta.Click
        frmcntaventa.Show()
        frmcntaventa.BringToFront()

    End Sub
End Class