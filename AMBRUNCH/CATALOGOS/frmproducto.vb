Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmproducto
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from unidad order by id_unidad")
        cunidad.Items.Clear()
        For Each row As DataRow In tabla.Rows
            cunidad.Items.Add(row("nom_unidad"))
        Next row


    End Sub
    Public Sub mostrar(ByVal producto As c_producto)
        datos = producto
        tid.Text = producto.Id_prod
        tnombre.Text = producto.Nom_prod
        cunidad.Text = producto.Unidad_prod
        tprecio.Text = producto.Precio_prod


    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        cunidad.Text = ""
        tprecio.Text = ""
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub tnombre_LostFocus(sender As Object, e As EventArgs)
        tnombre.Text = UCase(tnombre.Text)
    End Sub

    Private Sub tnombre_Leave(sender As Object, e As EventArgs)
        tnombre.Text = UCase(tnombre.Text)
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then

            datos.Nom_prod = UCase(tnombre.Text)
            datos.Unidad_prod = cunidad.Text
            datos.Precio_prod = tprecio.Text




            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproducto.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_prod.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaproducto.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub frmproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "PRODUCTOS")
        combo()
    End Sub
End Class