Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class frmbuscarp
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer
    Public folio As String


    Public Sub consulta()
        ' grdetalle.DataSource = Nothing
        ' grdetalle.Rows.Clear()
        ' grdetalle.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdetalle, "select * from producto order by id_prod")
        formatogrid()
    End Sub

    Public Sub buscar()
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdetalle, "select * from producto where nom_prod like '%" & tbuscar.Text & "%'or id_prod like '%" & tbuscar.Text & "%' order by nom_prod")
        formatogrid()
    End Sub
    Private Sub formatogrid()
        DoubleBuffered = True
        grdetalle.Columns(0).HeaderText = "CLAVE"
        grdetalle.Columns(1).HeaderText = "NOMBRE"
        grdetalle.Columns(2).HeaderText = "UNIDAD"
        grdetalle.Columns(3).HeaderText = "PRECIO"

        grdetalle.Columns(4).HeaderText = "ESTADO"



        grdetalle.AutoResizeColumns()
        grdetalle.Columns(1).Width = 300
        grdetalle.Columns(3).Width = 100
        grdetalle.Columns(3).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight



        grdetalle.Columns(4).Visible = False
        grdetalle.Columns(5).Visible = False



    End Sub




    Private Sub grdetalle_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellDoubleClick




        frmauxventa.folio = folio

        frmauxventa.id_prod = Convert.ToString(grdetalle.Rows(e.RowIndex).Cells(0).Value)
        frmauxventa.tid.Text = Convert.ToInt64(grdetalle.Rows(e.RowIndex).Cells(0).Value)
        frmauxventa.tnom.Text = Convert.ToString(grdetalle.Rows(e.RowIndex).Cells(1).Value)
        frmauxventa.tmedida.Text = Convert.ToString(grdetalle.Rows(e.RowIndex).Cells(2).Value)
        frmauxventa.tprecio.Text = Convert.ToString(grdetalle.Rows(e.RowIndex).Cells(3).Value)
        frmauxventa.tcantidad.Focus()
        'Me.Hide()


        frmauxventa.Show()
        frmauxventa.tcantidad.Focus()
        frmauxventa.BringToFront()


        Dispose()


    End Sub
    Private Sub frmbuscarp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "BUSCAR PRODUCTO")
        consulta()
        ExtendedMethods.DoubleBuffered(Me, True)
        ExtendedMethods.DoubleBuffered(grdetalle, True)

        Dim xl, yl As Integer
        xl = (Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width) / 2
        yl = (Screen.PrimaryScreen.WorkingArea.Height - Me.Size.Height) / 2

        Me.Location = New Point(xl, yl)
    End Sub

    Private Sub tbuscar_TextChanged(sender As Object, e As EventArgs) Handles tbuscar.TextChanged

        buscar()

    End Sub

    Private Sub grdetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdetalle.CellContentClick

    End Sub
End Class