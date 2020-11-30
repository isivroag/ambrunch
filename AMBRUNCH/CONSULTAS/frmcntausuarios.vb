Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntausuarios

    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_usuario
    Dim tabla As New DataTable
    Public flag As Integer
    Public origen As Integer
    Public accion As Integer
    Private Sub cntausuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE USUARIOS")
        consulta()


    End Sub
    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from vusuario where estado_u=1 and idtipou<>1 order by clave")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "NOMBRE"
        grdatos.Columns(2).HeaderText = "LOGIN"
        grdatos.Columns(3).HeaderText = "PASSWORD"
        grdatos.Columns(4).HeaderText = "ID TIPO"
        grdatos.Columns(5).HeaderText = "TIPO"
        grdatos.Columns(6).HeaderText = "ESTADO"

        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 50
        grdatos.Columns(1).Width = 250
        grdatos.Columns(2).Width = 150
        grdatos.Columns(3).Width = 100

        grdatos.Columns(3).Visible = False
        grdatos.Columns(4).Visible = False
        grdatos.Columns(6).Visible = False




    End Sub
    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bcambiar_Click(sender As Object, e As EventArgs) Handles bcambiar.Click
        datos.Clave = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nombre = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        datos.Login = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        datos.Password = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
        datos.Tipo = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)



        frmusuario.Show()
        frmusuario.nomtipo = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
        frmusuario.mostrar(datos)
        frmusuario.flag = 2
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click



        frmusuario.Show()
        frmusuario.flag = 1
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            If conn.eliminar(clave, 6, "") = True Then
                consulta()
                MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
            End If

        End If
    End Sub

    Private Sub grdatos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellDoubleClick
        If e.RowIndex >= 0 Then
            If accion = 0 Then



                Select Case origen
                    Case 1
                        datos.Clave = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
                        datos.Nombre = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
                        datos.Login = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
                        datos.Password = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)
                        datos.Tipo = Convert.ToString(grdatos.CurrentRow().Cells(4).Value)

                        frmusuario.Show()
                        frmusuario.nomtipo = Convert.ToString(grdatos.CurrentRow().Cells(5).Value)
                        frmusuario.mostrar(datos)
                        frmusuario.flag = 2
                    Case 2

                        'frmauxreceta.flag = 1
                        'frmauxreceta.id_insumo = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
                        'frmauxreceta.tconcepto.Text = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
                        'frmauxreceta.concepto = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
                        'frmauxreceta.lunidad.Text = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)

                        'frmauxreceta.ShowDialog()
                        'Dispose()
                End Select
            Else
                If accion = 1 Then


                End If
            End If

        End If
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class