Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcntaproducto


    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim datos As New c_producto
    Dim tabla As New DataTable
    Public flag As Integer
    Public origen As Integer
    Public accion As Integer
    Private Sub frmcntaproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CONSULTA DE PRODUCTOS")
        consulta()
        If accion = 1 Then
            bnuevo.Visible = False
            bcambiar.Visible = False
            beliminar.Visible = False
            binventario.Visible = False
            ltitulo.Font = New Font("Segoe UI Semibold", 14)
            ltitulo.Text = "SELECIONE EL PRODUCTO DESEADO"

        End If
    End Sub

    Public Sub consulta()
        ' grdatos.DataSource = Nothing
        ' grdatos.Rows.Clear()
        ' grdatos.Columns.Clear()
        conn = New c_mysqlconn
        conn.consulta(grdatos, "select * from producto where estado_prod=1 order by id_prod")
        formatogrid()
    End Sub
    Private Sub formatogrid()

        DoubleBuffered = True
        grdatos.Columns(0).HeaderText = "ID"
        grdatos.Columns(1).HeaderText = "PRODUCTO"
        grdatos.Columns(2).HeaderText = "UNIDAD"
        grdatos.Columns(3).HeaderText = "PRECIO"

        grdatos.Columns(4).HeaderText = "ESTADO"
        grdatos.AutoResizeColumns()
        grdatos.Columns(0).Width = 50
        grdatos.Columns(1).Width = 250
        grdatos.Columns(2).Width = 100
        grdatos.Columns(3).Width = 100
        grdatos.Columns(4).Visible = False




    End Sub
    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bcambiar_Click(sender As Object, e As EventArgs) Handles bcambiar.Click
        datos.Id_prod = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        datos.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
        datos.Precio_prod = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

        frmproducto.Show()
        frmproducto.mostrar(datos)
        frmproducto.flag = 2
    End Sub

    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        frmproducto.Show()
        frmproducto.flag = 1
    End Sub

    Private Sub beliminar_Click(sender As Object, e As EventArgs) Handles beliminar.Click
        If MsgBox("DESEA ELIMINAR ESTE REGISTRO", vbYesNo + vbQuestion, "ELIMINAR") = vbYes Then
            Dim clave As String
            clave = Convert.ToDouble(grdatos.CurrentRow().Cells(0).Value)
            conn = New c_mysqlconn
            If conn.eliminar(clave, 4) = True Then
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
                        datos.Id_prod = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
                        datos.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
                        datos.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)
                        datos.Precio_prod = Convert.ToString(grdatos.CurrentRow().Cells(3).Value)

                        frmproducto.Show()
                        frmproducto.mostrar(datos)
                        frmproducto.flag = 2
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
                    datos.Id_prod = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
                    datos.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
                    datos.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)

                    frmkardex.Show()
                    frmkardex.mostrar(datos)

                End If
            End If

        End If
    End Sub

    Private Sub binventario_Click(sender As Object, e As EventArgs) Handles binventario.Click
        datos.Id_prod = Convert.ToString(grdatos.CurrentRow().Cells(0).Value)
        datos.Nom_prod = Convert.ToString(grdatos.CurrentRow().Cells(1).Value)
        datos.Unidad_prod = Convert.ToString(grdatos.CurrentRow().Cells(2).Value)


        frmkardex.Show()
        frmkardex.mostrar(datos)
    End Sub

    Private Sub grdatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdatos.CellContentClick

    End Sub
End Class