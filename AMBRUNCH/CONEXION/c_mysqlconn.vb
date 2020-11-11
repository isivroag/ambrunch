Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class c_mysqlconn
    Public _sql As String
    Public _conexion As New MySqlConnection
    Private adaptador As New MySqlDataAdapter
    Private comando As New MySqlCommand
    Private ta As New DataTable
    Private ta2 As New DataTable
    Public dtsdatos As New DataSet
    Public dtvdatos As New DataView
#Region "CONEXION"
    Private Sub conexion()
        _sql = "server=" & My.Settings.server & "; Uid=" & My.Settings.user & "; Pwd=" & My.Settings.pwd & ";database=" & My.Settings.db & ""
        _conexion = New MySqlConnection(_sql)
    End Sub

    Public Sub desconectar()
        _conexion.Close()

    End Sub
#End Region

#Region "LOGIN"
    Public Function entrar(ByVal sql As String) As Integer
        Dim tipo As Integer
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sql, _conexion)
            adaptador.Fill(dtsdatos, "registro")
            If dtsdatos.Tables("registro").Rows.Count <> 0 Then
                'tipo = True
                tipo = Convert.ToString(dtsdatos.Tables("registro").Rows(0).Item("tipo"))
            Else
                'tipo = False
                tipo = 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            tipo = 0
        Finally
            desconectar()
        End Try
        Return tipo
    End Function
#End Region

#Region "CONSULTAS"

    Public Function consulta(ByVal ds As DataSet, ByVal sql As String) As Boolean
        Dim estado As Boolean
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sql, _conexion)
            adaptador.Fill(ds, "det_orden")
            If ds.Tables("det_orden").Rows.Count <> 0 Then
                estado = True
            Else
                estado = False
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function consulta(ByVal Tabla As DataGridView, ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Dim TAB2 As New DataTable
        Try

            Tabla.DataSource = Nothing

            conexion()
            TAB2.Clear()

            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(TAB2)
            Tabla.DataSource = TAB2
        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return TAB2
    End Function

    Public Function consulta(ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Dim TAB2 As New DataTable
        Try

            conexion()
            TAB2.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(TAB2)


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try

        Return TAB2
    End Function

    Public Function consultan(ByVal sqlcons As String) As DataTable
        Dim estado As Boolean = True
        Try


            conexion()
            ta2.Clear()

            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta2)

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return ta2
    End Function

    Public Function Obtener_dato(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("dato")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("dato"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function
    Public Function Obtener_ID(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("max_id")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("max_id"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function

    Public Function Obtener_primero(ByVal sqlcons As String) As String
        Try
            conexion()
            ta.Clear()
            adaptador = New MySqlDataAdapter(sqlcons, _conexion)
            adaptador.Fill(ta)

            If ta.Rows.Count = 1 Then
                If Convert.ToString(ta.Rows(0).Item("min_id")) = "" Then
                    Return 0
                Else
                    Return Convert.ToString(ta.Rows(0).Item("min_id"))
                End If
            Else
                Return 0
            End If

        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado " & ex.Message.ToString)
            Return 0
        Finally
            desconectar()
        End Try
    End Function

#End Region


#Region "ELIMINAR"
    Public Function eliminar(ByVal clave As String, ByVal indice As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            Select Case indice
                Case 1
                   ' adaptador.UpdateCommand = New MySqlCommand("update mesa Set estado_mesa=0 where id_mesa=@id", _conexion)
                Case 2
                    adaptador.UpdateCommand = New MySqlCommand("update unidad Set estado_unidad=0 where id_unidad=@id", _conexion)
                Case 3
                    adaptador.UpdateCommand = New MySqlCommand("update cajero Set estado_cajero=0 where id_cajero=@id", _conexion)
                Case 4
                    adaptador.UpdateCommand = New MySqlCommand("update producto SET estado_prod=0 where id_prod=@id", _conexion)
                Case 5
                    adaptador.UpdateCommand = New MySqlCommand("update almacen Set estado_almacen=0 where id_almacen=@id", _conexion)
                Case 6
                   ' adaptador.UpdateCommand = New MySqlCommand("update alimento Set estado_ali=0 where id_ali=@id", _conexion)
                Case 7
                  '  adaptador.UpdateCommand = New MySqlCommand("update guarnicion Set estado_guar=0 where id_guar=@id", _conexion)
                Case 8
                  '  adaptador.UpdateCommand = New MySqlCommand("update det_guar Set estado_det=0 where id_det=@id", _conexion)


                    'eliminacion anidada de tipo


                Case 9
                  '  adaptador.UpdateCommand = New MySqlCommand("update alimento Set estado_ali=0 where id_subtipo=@id", _conexion)
                Case 10
                 '   adaptador.UpdateCommand = New MySqlCommand("update guarnicion Set estado_guar=0 where id_subtipo=@id", _conexion)
                Case 11
                 '   adaptador.UpdateCommand = New MySqlCommand("update det_guar Set estado_det=0 where id_subtipo=@id", _conexion)

                Case 12
                    '   adaptador.UpdateCommand = New MySqlCommand("update subtipo Set estado_subtipo=0 where id_tipo=@id", _conexion)


            End Select

            adaptador.UpdateCommand.Parameters.Add("@id", MySqlDbType.Int64).Value = clave


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "UNIDAD"
    Public Function insertarnuevo(ByVal datos As c_unidad) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into unidad(nom_unidad) values (@nom_unidad)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_unidad", MySqlDbType.VarChar).Value = datos.Nom_unidad


            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function modificar(ByVal datos As c_unidad, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update unidad Set nom_unidad=@nom_unidad where id_unidad=@id_unidad", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_unidad", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_unidad", MySqlDbType.VarChar).Value = datos.Nom_unidad



            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region
#Region "PRODUCTOS"
    Public Function insertarnuevo(ByVal datos As c_producto) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into producto(nom_prod,unidad_prod,precio_prod) values (@nom_prod,@unidad_prod,@precio_prod)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@nom_prod", MySqlDbType.VarChar).Value = datos.Nom_prod
            adaptador.InsertCommand.Parameters.Add("@unidad_prod", MySqlDbType.VarChar).Value = datos.Unidad_prod
            adaptador.InsertCommand.Parameters.Add("@precio_prod", MySqlDbType.Double).Value = datos.Precio_prod

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function


    Public Function modificar(ByVal datos As c_producto, ByVal clave As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update producto Set nom_prod=@nom_prod,unidad_prod=@unidad_prod,precio_prod=@precio_prod where id_prod=@id_prod", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@nom_prod", MySqlDbType.VarChar).Value = datos.Nom_prod
            adaptador.UpdateCommand.Parameters.Add("@unidad_prod", MySqlDbType.VarChar).Value = datos.Unidad_prod
            adaptador.UpdateCommand.Parameters.Add("@precio_prod", MySqlDbType.Double).Value = datos.Precio_prod


            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MsgBox("La conexión no fue exitosa,revise que el servidor este encendido y que el estado de su red sea adecuado" & ex.Message.ToString)
            'MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "INVENTARIO"
    Public Function insertarmov(ByVal datos As c_movimiento) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into movimiento (id_prod,id_almacen,id_tipomov,fecha_mov,ini_mov,cant_mov,unidad_mov,fin_mov,obs_mov) values (@id_prod,@id_almacen,@tipo_mov,@fecha_mov,@ini_mov,@cant_mov,@unidad_mov,@fin_mov,@obs_mov)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = datos.Id_prod
            adaptador.InsertCommand.Parameters.Add("@Id_almacen", MySqlDbType.Int64).Value = datos.Id_almacen
            adaptador.InsertCommand.Parameters.Add("@tipo_mov", MySqlDbType.Int32).Value = datos.Tipo_mov
            adaptador.InsertCommand.Parameters.Add("@fecha_mov", MySqlDbType.Date).Value = Format(datos.Fecha_mov, "yyyy-MM-dd")
            adaptador.InsertCommand.Parameters.Add("@ini_mov", MySqlDbType.Double).Value = datos.Ini_mov
            adaptador.InsertCommand.Parameters.Add("@cant_mov", MySqlDbType.Double).Value = datos.Cant_mov
            adaptador.InsertCommand.Parameters.Add("@unidad_mov", MySqlDbType.String).Value = datos.Unidad_mov
            adaptador.InsertCommand.Parameters.Add("@fin_mov", MySqlDbType.Double).Value = datos.Fin_mov
            adaptador.InsertCommand.Parameters.Add("@obs_mov", MySqlDbType.String).Value = datos.Obs_mov
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function primerinv(ByVal clave As String, ByVal almacen As String, ByVal cantidad As Double, ByVal unidad As String) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into inventario (id_almacen,id_prod,cant_prod,nom_unidad) values (@id_almacen,@id_prod,@cant_prod,@nom_unidad)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = clave
            adaptador.InsertCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = almacen
            adaptador.InsertCommand.Parameters.Add("@cant_prod", MySqlDbType.Double).Value = cantidad
            adaptador.InsertCommand.Parameters.Add("@nom_unidad", MySqlDbType.String).Value = unidad

            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
    Public Function actualizarproducto(ByVal clave As String, ByVal almacen As String, ByVal final As Double) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update inventario set cant_prod=@final where id_prod=@id_prod and id_almacen=@id_almacen", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@id_prod", MySqlDbType.Int64).Value = clave
            adaptador.UpdateCommand.Parameters.Add("@id_almacen", MySqlDbType.Int64).Value = almacen
            adaptador.UpdateCommand.Parameters.Add("@final", MySqlDbType.Double).Value = final

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region

#Region "VENTAS"
    Public Function ventanueva() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.InsertCommand = New MySqlCommand("insert into venta (folio_fis,fecha_vta,cliente,total_vta,fact_vta,letra,estado_vta) values (0,@fecha_vta,@cliente,@total_vta,@fact_vta,@letra,@estado_vta)", _conexion)
            adaptador.InsertCommand.Parameters.Add("@fecha_vta", MySqlDbType.DateTime).Value = Format(Now, "yyyy-MM-dd HH:mm:ss")
            adaptador.InsertCommand.Parameters.Add("@cliente", MySqlDbType.String).Value = "PUBLICO EN GENERAL"
            adaptador.InsertCommand.Parameters.Add("@total_vta", MySqlDbType.Double).Value = 0
            adaptador.InsertCommand.Parameters.Add("@fact_vta", MySqlDbType.Int16).Value = 0
            adaptador.InsertCommand.Parameters.Add("@estado_vta", MySqlDbType.Int16).Value = 0
            adaptador.InsertCommand.Parameters.Add("@letra", MySqlDbType.String).Value = ""
            _conexion.Open()
            adaptador.InsertCommand.Connection = _conexion
            adaptador.InsertCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function actualizarventa(ByVal datos As c_venta, ByVal folio As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update venta set fecha_vta=@fecha_vta,cliente_vta=@cliente_vta,total_vta=@total_vta,fact_vta=@fact_vta,letra=@letra,estado_vta=@estado_vta where folio_vta=@folio_vta", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_vta", MySqlDbType.Int64).Value = folio
            adaptador.UpdateCommand.Parameters.Add("@fecha_vta", MySqlDbType.DateTime).Value = Format(datos.Fecha_vta, "yyyy-MM-dd HH:mm:ss")
            adaptador.UpdateCommand.Parameters.Add("@cliente_vta", MySqlDbType.String).Value = datos.Cliente

            adaptador.UpdateCommand.Parameters.Add("@total_vta", MySqlDbType.Double).Value = datos.Total_vta
            adaptador.UpdateCommand.Parameters.Add("@fact_vta", MySqlDbType.Int16).Value = datos.Fact_vta
            adaptador.UpdateCommand.Parameters.Add("@letra", MySqlDbType.String).Value = datos.Letra
            adaptador.UpdateCommand.Parameters.Add("@estado_vta", MySqlDbType.Int16).Value = 1
            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function cancelarventa(ByVal folio As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.UpdateCommand = New MySqlCommand("update venta set estado_vta='0' where folio_vta=@folio_vta", _conexion)
            adaptador.UpdateCommand.Parameters.Add("@folio_vta", MySqlDbType.Int64).Value = folio

            _conexion.Open()
            adaptador.UpdateCommand.Connection = _conexion
            adaptador.UpdateCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function

    Public Function borrarventa(ByVal folio As Integer) As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            adaptador.DeleteCommand = New MySqlCommand("delete from venta where folio_vta=@folio_vta", _conexion)
            adaptador.DeleteCommand.Parameters.Add("@folio_vta", MySqlDbType.Int64).Value = folio

            _conexion.Open()
            adaptador.DeleteCommand.Connection = _conexion
            adaptador.DeleteCommand.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            estado = False
        Finally
            desconectar()
        End Try
        Return estado
    End Function
#End Region
End Class
