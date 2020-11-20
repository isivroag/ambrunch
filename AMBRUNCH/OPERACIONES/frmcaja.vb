Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class frmcaja
    Dim conn As New c_mysqlconn
    Dim texto As String
    Dim tabla As New DataTable
    Dim tablaprod As New DataTable
    Public flag As Integer
    Public folio As Integer
    Dim TOTAL As Double
    Dim id_reg As Integer
    Public Valoperacion As Integer

    Public Sub inventario()
        Dim idprod As Int64
        Dim cantidad As Double
        Dim contable As Boolean
        Dim inicial As Double
        Dim final As Double
        Dim unidad As String

        For i = 0 To grdetalle.Rows.Count - 1
            idprod = grdetalle.Rows(i).Cells(2).Value
            cantidad = grdetalle.Rows(i).Cells(4).Value
            unidad = grdetalle.Rows(i).Cells(5).Value
            ' consultar producto
            conn = New c_mysqlconn
            tablaprod = conn.consulta("select id_prod,contable_prod from producto where id_prod='" & idprod & "'")
            If tablaprod.Rows.Count <> 0 Then
                contable = tablaprod.Rows(0).Item("contable_prod").ToString
                If contable = True Then
                    'consultar inventario si el producto es inventariable siempre inventario 1
                    conn = New c_mysqlconn
                    inicial = conn.Obtener_dato("select cant_insumo as dato from vinventario where id_almacen=1 and id_prod='" & idprod & "'")
                    final = inicial - cantidad
                Else
                    inicial = 0
                    final = 0
                End If

                'registrar movimiento de venta en inventario
                Dim movimiento As New c_movimiento
                movimiento.Id_prod = idprod
                movimiento.Id_almacen = 1
                movimiento.Fecha_mov = tfecha.Value
                movimiento.Cant_mov = cantidad
                movimiento.Tipo_mov = 4
                movimiento.Ini_mov = inicial
                movimiento.Unidad_mov = unidad
                movimiento.Fin_mov = final
                movimiento.Obs_mov = "VENTA FOLIO " & folio
                conn = New c_mysqlconn
                conn.insertarmov(movimiento)

                'actualizar inventario
                conn = New c_mysqlconn
                conn.actualizarproducto(idprod, 1, final)



            End If





        Next
    End Sub
    Public Sub limpiar()
        tfolio.Text = ""
        tcliente.Text = ""

        tfecha.Value = Now
        ttotal.Text = "0.00"
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()
        grdetalle.ColumnCount = 9
        formatogrid()
    End Sub

    Private Sub formatogrid()
        DoubleBuffered = True
        grdetalle.Columns(0).HeaderText = "ID"
        grdetalle.Columns(1).HeaderText = "FOLIO"
        grdetalle.Columns(2).HeaderText = "CLAVE"
        grdetalle.Columns(3).HeaderText = "PRODUCTO"
        grdetalle.Columns(4).HeaderText = "CANTIDAD"
        grdetalle.Columns(5).HeaderText = "U. MED."
        grdetalle.Columns(6).HeaderText = "PRECIO"
        grdetalle.Columns(7).HeaderText = "SUBTOTAL"
        grdetalle.Columns(8).HeaderText = "ESTADO"



        grdetalle.AutoResizeColumns()
        grdetalle.Columns(3).Width = 280
        'grdetalle.Columns(2).Width = 70
        grdetalle.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grdetalle.Columns(6).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdetalle.Columns(7).DefaultCellStyle.Format = "C2"
        grdetalle.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        grdetalle.Columns(0).Visible = False
        grdetalle.Columns(2).Visible = False
        grdetalle.Columns(1).Visible = False
        grdetalle.Columns(8).Visible = False




    End Sub
    Public Sub deshabilitar()
        GPANEL.Enabled = False
        limpiar()
        bnuevo.Visible = True
        bpagar.Visible = False
        bcancelar.Visible = False
        bsalir.Visible = True

    End Sub



    Private Sub frmcaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicial(sender, e, "CAJA")
        ExtendedMethods.DoubleBuffered(grdetalle, True)
        If flag = 1 Then
            limpiar()
            tfecha.Value = Now
            grdetalle.ColumnCount = 8
            formatogrid()
            Valoperacion = 0
        End If
    End Sub
    Private Sub habilitar()
        bnuevo.Visible = False
        bpagar.Visible = True
        bcancelar.Visible = True
        bsalir.Visible = False
    End Sub


    Private Sub insertar()
        folio = 0
        folio = conn.Obtener_ID("select max(folio_vta) as max_id from venta")
        folio = folio + 1
        conn = New c_mysqlconn
        If conn.ventanueva(folio) Then
            conn = New c_mysqlconn

        End If
        tfolio.Text = folio
    End Sub

    Private Sub bagregar_Click(sender As Object, e As EventArgs) Handles bagregar.Click
        frmauxventa.Show()
        frmauxventa.BringToFront()
        frmauxventa.folio = folio



        frmbuscarp.folio = folio
        frmbuscarp.Show()
        frmbuscarp.BringToFront()
        frmbuscarp.tbuscar.Focus()

    End Sub
    Public Sub CONSULTA()
        grdetalle.DataSource = Nothing
        grdetalle.Rows.Clear()
        grdetalle.Columns.Clear()

        conn = New c_mysqlconn
        conn.consulta(grdetalle, "select * from det_vta where folio_vta='" & folio & "' and estado_det=1")
        formatogrid()
        TOTAL = 0

        For Each row As DataGridViewRow In grdetalle.Rows
            TOTAL = TOTAL + row.Cells(7).Value
        Next
        ttotal.Text = Format(TOTAL, "C2")
    End Sub


    Private Sub bnuevo_Click(sender As Object, e As EventArgs) Handles bnuevo.Click
        limpiar()
        GPANEL.Enabled = True
        habilitar()
        insertar()
        tcliente.Text = "PUBLICO EN GENERAL"
        Valoperacion = 1
    End Sub

    Private Sub bsalir_Click(sender As Object, e As EventArgs) Handles bsalir.Click
        Dispose()
    End Sub

    Private Sub bcancelar_Click(sender As Object, e As EventArgs) Handles bcancelar.Click
        conn = New c_mysqlconn

        conn.borrarventa(tfolio.Text)
        deshabilitar()
        limpiar()
        Valoperacion = 0

    End Sub



    Private Sub bquitar_Click(sender As Object, e As EventArgs) Handles bquitar.Click
        If MsgBox("¿DESEA ELIMINAR ESTE PRODUCTO DE LA VENTA?", vbYesNo, "ELIMINAR PRODUCTO") = MsgBoxResult.Yes Then
            If grdetalle.Rows.Count > 0 Then
                If grdetalle.CurrentRow IsNot Nothing Then
                    conn = New c_mysqlconn

                    id_reg = grdetalle.CurrentRow.Cells(0).Value
                    conn.eliminardetalle(id_reg)
                    CONSULTA()
                Else
                    MsgBox("ANTES DEBE SELECCIONAR EL PRODUCTO A ELIMINAR" & Chr(13) & "VERIFIQUE LOS DATOS", vbInformation + vbQuestion, "CAJA")
                End If
            Else
                MsgBox("NO EXISTEN PRODUCTOS EN LA LISTA" & Chr(13) & "VERIFIQUE LOS DATOS", vbInformation + vbQuestion, "CAJA")
            End If
        End If
    End Sub

    Private Sub bpagar_Click(sender As Object, e As EventArgs) Handles bpagar.Click
        If Len(ttotal.Text) > 0 Then
            If CDbl(ttotal.Text) > 0 Then
                conn = New c_mysqlconn
                Dim venta As New c_venta
                venta.Folio_vta = folio
                venta.Fecha_vta = tfecha.Value
                venta.Fact_vta = False
                venta.Cliente = tcliente.Text
                venta.Total_vta = CDbl(ttotal.Text)
                venta.Letra = EnLetras(CDbl(ttotal.Text))
                conn.actualizarventa(venta, folio)
                frmpago.foliovta = tfolio.Text
                frmpago.ttotal.Text = ttotal.Text
                frmpago.tpago.Text = "0.00"
                frmpago.tcambio.Text = "0.00"
                frmpago.ShowDialog()

            Else
                MsgBox("NO ES POSIBLE PROCESAR EL PAGO DE ESTA VENTA" & Chr(13) & "VERIFIQUE LA OPERACION", vbInformation + vbQuestion, "CAJA")
            End If
        Else
            MsgBox("NO ES POSIBLE PROCESAR EL PAGO DE ESTA VENTA" & Chr(13) & "VERIFIQUE LA OPERACION", vbInformation + vbQuestion, "CAJA")
        End If
    End Sub

    Private Sub frmcaja_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Valoperacion = 0 Then
            Dispose()
        Else
            MsgBox("NO ES POSIBLE CERRAR CAJA, YA QUE TIENE UNA OPERACION PENDIENTE." & Chr(13) & " SI DESEA CERRAR, DEBE CANCELAR PRIMERO LA VENTA", vbExclamation + vbOKOnly, "CERRAR")
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        inventario()

    End Sub
End Class