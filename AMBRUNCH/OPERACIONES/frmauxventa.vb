Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmauxventa
    Public id_prod As Integer
    Public folio As Integer
    Dim conn As c_mysqlconn
    Dim registro As c_det_vta

    Private Sub calcular()
        If Len(tcantidad.Text) > 0 And Len(tprecio.Text) > 0 Then
            If Convert.ToDouble(tcantidad.Text) Then
                tsubtotal.Text = Convert.ToDouble(tcantidad.Text) * Convert.ToDouble(tprecio.Text)
            Else
                tsubtotal.Text = "0.00"
            End If
        Else
            tsubtotal.Text = "0.00"
        End If

    End Sub

    Private Sub tcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcantidad.KeyPress
        solonumeros(sender, e)

    End Sub

    Private Sub tcantidad_TextChanged(sender As Object, e As EventArgs) Handles tcantidad.TextChanged
        calcular()
    End Sub

    Private Sub frmauxventa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "Agregar Producto")
    End Sub

    Private Sub tcantidad_GotFocus(sender As Object, e As EventArgs) Handles tcantidad.GotFocus
        tcantidad.BackColor = Color.Yellow
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        If Len(tid.Text) > 0 And Len(tcantidad.Text) > 0 Then
            conn = New c_mysqlconn
            registro = New c_det_vta
            registro.Folio_vta = folio
            registro.Id_prod = tid.Text
            registro.Nom_prod = tnom.Text
            registro.Cantidad = tcantidad.Text
            registro.Precio_prod = tprecio.Text
            registro.Unidad_prod = tmedida.Text
            registro.Subtotal = tsubtotal.Text
            If conn.insertarnuevo(registro) Then
                MsgBox("PRODUCTO AGREGADO", vbInformation + vbOKOnly, "AGREGAR PRODUCTO")
                frmcaja.CONSULTA()
                Dispose()

            Else
                MsgBox("PRODUCTO NO AGREGADO", vbInformation + vbOKOnly, "AGREGAR PRODUCTO")
            End If
        Else
            MsgBox("INFORMACION FALTANTE, REVISE SUS DATOS POR FAVOR", vbInformation + vbOKOnly, "AGREGAR PRODUCTO")
        End If
    End Sub

    Private Sub bbuscar_Click(sender As Object, e As EventArgs) Handles bbuscar.Click
        frmcntaproducto.Show()
        frmcntaproducto.BringToFront()
        frmcntaproducto.flag = 2
    End Sub
End Class