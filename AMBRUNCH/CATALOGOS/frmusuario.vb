Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmusuario
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_usuario
    Dim tabla As New DataTable
    Public flag As Integer
    Dim idprod As Integer
    Public nomtipo As String

    Private Sub combo()
        conn = New c_mysqlconn
        tabla.Clear()
        tabla = conn.consulta("select * from tipou order by idtipou")
        ctipo.Items.Clear()
        For Each row As DataRow In tabla.Rows
            ctipo.Items.Add(row("idtipou") & " " & row("tipo"))
        Next row


    End Sub
    Public Sub mostrar(ByVal registro As c_usuario)
        datos = registro
        tid.Text = registro.Clave
        tnombre.Text = registro.Nombre
        ctipo.Text = registro.Tipo & " " & nomtipo
        tlogin.Text = registro.Login
        pwd1.Text = registro.Password
        pwd2.Text = registro.Password


    End Sub

    Private Sub limpiar()
        tid.Text = ""
        tnombre.Text = ""
        ctipo.Text = ""

        tlogin.Text = ""
        pwd1.Text = ""
        pwd2.Text = ""

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
        If Strings.Len(tnombre.Text) > 0 And Strings.Len(tlogin.Text) And Strings.Len(ctipo.Text) > 0 And Strings.Len(pwd1.Text) > 0 And Strings.Len(pwd2.Text) > 0 Then
            If pwd1.Text = pwd2.Text Then
                datos.Nombre = UCase(tnombre.Text)
                datos.Tipo = sacarclave(ctipo.Text)
                datos.Login = tlogin.Text
                datos.Password = pwd1.Text
                If flag = 1 Then
                    conn = New c_mysqlconn
                    If conn.insertarnuevo(datos) Then
                        MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmcntausuarios.consulta()

                        Me.Dispose()
                    Else
                        MessageBox.Show("Datos No Guardados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    conn = New c_mysqlconn
                    If conn.modificar(datos, datos.Clave.ToString) Then
                        MessageBox.Show("Datos Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frmcntausuarios.consulta()
                        Me.Dispose()
                    Else
                        MessageBox.Show("Datos No Guardados", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else
                MessageBox.Show("¡Las Contraseñas no coinciden!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("¡Verifique Sus Datos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frmusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "USUARIO")
        combo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pwd1.PasswordChar.ToString = "*" Then
            pwd1.PasswordChar = ""
        Else
            pwd1.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If pwd2.PasswordChar.ToString = "*" Then
            pwd2.PasswordChar = ""
        Else
            pwd2.PasswordChar = "*"
        End If
    End Sub
End Class