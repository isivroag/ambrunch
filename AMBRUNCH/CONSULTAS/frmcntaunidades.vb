Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmcntaunidades
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_unidad
    Dim tabla As New DataTable
    Public flag As Integer

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from unidad where estado_unidad=1 order by id_unidad")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "UNIDAD"
        grdatos.Columns(2).HeaderText = "ESTADO"
        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 50
        grdatos.Columns(1).Width = 250
        grdatos.Columns(2).Width = 100


        grdatos.Columns(2).Visible = False

    End Sub
    Private Sub frmcntaunidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE UNIDADES")
        ExtendedMethods.DoubleBuffered(grdatos, True)
        consulta()
    End Sub

    Private Sub bcambiar_Click(sender As Object, e As EventArgs) Handles bcambiar.Click
        datos.Id_unidad = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_unidad = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)



        frmunidad.Show()
        frmunidad.mostrar(datos)
        frmunidad.flag = 2
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click



        frmunidad.Show()
        frmunidad.flag = 1
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            If conn.eliminar(clave, 2) = True Then
                consulta()
                MsgBox("REGISTRO ELIMINADO", vbInformation + vbOKOnly, "ELIMINAR")
            End If

        End If
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub
End Class