Imports MySql.Data.MySqlClient
Public Class frmlogin
    Dim conn As c_mysqlconn
    Dim usuario As String
    Dim contraseña As String
    Dim consulta As String
    Dim tipo As Integer
    Public resp As Integer
    Public tur As String
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        consulta = "select * from usuario where login='" & tlogin.Text & "' and password='" & tpassword.Text & "'"
        conn = New c_mysqlconn

        tipo = conn.entrar(consulta)
        If tipo <> 0 Then
            MsgBox("BIENVENIDO", vbOKOnly + vbInformation, "ENTRAR")
            nivelusuario = tipo
            frmprincipal.usuario = tipo
            frmprincipal.Show()


            Me.Close()

        Else
            MsgBox("ACCESO DENEGADO", vbOKOnly + vbInformation, "ENTRAR")
        End If
    End Sub
End Class
