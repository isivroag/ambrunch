Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmunidad
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_unidad
    Dim tabla As New DataTable
    Public flag As Integer
    Dim id_tipo As Integer

    Public Sub mostrar(ByVal registro As c_unidad)
        datos = registro
        tid.Text = registro.Id_unidad
        tnombre.Text = registro.Nom_unidad



    End Sub


    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""


    End Sub
    Private Sub frmunidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "UNIDADES")
        limpiar()
    End Sub

    Private Sub bguardar_Click(sender As Object, e As EventArgs) Handles bguardar.Click
        If Strings.Len(tnombre.Text) > 0 Then

            datos.Nom_unidad = UCase(tnombre.Text)

            If flag = 1 Then
                conn = New c_mysqlconn
                If conn.insertarnuevo(datos) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaunidades.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                conn = New c_mysqlconn
                If conn.modificar(datos, datos.Id_unidad.ToString) Then
                    MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmcntaunidades.consulta()
                    Me.Dispose()
                Else
                    MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub
End Class