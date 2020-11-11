Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmmovimientos
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer
    Public existencia As Double
    Dim movimiento As New c_movimiento


    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from tipomov order by id_tmov")
        ctipo.Items.Clear()
        For Each row As DataRow In tabla.Rows
            ctipo.Items.Add(row("id_tmov") & " " & row("tmov"))
        Next row


    End Sub

    Public Sub mostrar(ByVal producto As c_producto)
        datos = producto
        tid.Text = producto.Id_prod
        tnombre.Text = producto.Nom_prod
        tunidad.Text = producto.Unidad_prod
        buscar()

    End Sub
    Private Sub tcant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcant.KeyPress
        solonumeros(sender, e)
    End Sub
    Private Sub frmmovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "MOVIMIENTOS")
        combo()
    End Sub
    Private Sub buscar()
        conn = New c_mysqlconn
        tabla.Clear()
        existencia = conn.Obtener_dato("select cant_prod as dato from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='1'")

        texistencia.Text = existencia

    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        movimiento.Id_prod = datos.Id_prod
        movimiento.Id_almacen = 1
        movimiento.Fecha_mov = Date.Today.Date.ToString
        movimiento.Tipo_mov = sacarclave(ctipo.Text)
        movimiento.Ini_mov = existencia
        movimiento.Unidad_mov = datos.Unidad_prod
        movimiento.Cant_mov = Convert.ToDouble(tcant.Text)


        Select Case sacarclave(ctipo.Text)
            Case 1
                movimiento.Fin_mov = Convert.ToDouble(existencia) + Convert.ToDouble(tcant.Text)
            Case 2
                movimiento.Fin_mov = Convert.ToDouble(existencia) + Convert.ToDouble(tcant.Text)
            Case 3
                movimiento.Fin_mov = Convert.ToDouble(existencia) - Convert.ToDouble(tcant.Text)
            Case 4
                movimiento.Fin_mov = Convert.ToDouble(existencia) - Convert.ToDouble(tcant.Text)
            Case 5
                movimiento.Fin_mov = Convert.ToDouble(existencia) + Convert.ToDouble(tcant.Text)
        End Select

        movimiento.Obs_mov = tobs.Text

        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from inventario where id_prod='" & datos.Id_prod & "' and id_almacen='1'")
        Dim registroe As Integer = 0
        If tabla.Rows.Count > 0 Then
            registroe = 1
        End If

        If conn.insertarmov(movimiento) Then
            conn = New c_mysqlconn
            If registroe = 1 Then
                conn.actualizarproducto(movimiento.Id_prod, movimiento.Id_almacen, movimiento.Fin_mov)
            Else
                conn.primerinv(movimiento.Id_prod, movimiento.Id_almacen, movimiento.Fin_mov, movimiento.Unidad_mov)
            End If

            MessageBox.Show("Datos Guardados")
            If flag = 2 Then
                frmkardex.mostrar(datos)
            Else
                frmcntainventario.consulta()
            End If



            Me.Dispose()

        Else
            MessageBox.Show("Datos No Guardados")
        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub
    Private Sub frmmovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class