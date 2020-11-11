Public Class c_producto
    Private _id_prod As Int64
    Private _nom_prod As String
    Private _precio_prod As String
    Private _unidad_prod As String
    Private _estado_prod As Boolean

    Public Property Id_prod As Long
        Get
            Return _id_prod
        End Get
        Set(value As Long)
            _id_prod = value
        End Set
    End Property

    Public Property Nom_prod As String
        Get
            Return _nom_prod
        End Get
        Set(value As String)
            _nom_prod = value
        End Set
    End Property

    Public Property Precio_prod As String
        Get
            Return _precio_prod
        End Get
        Set(value As String)
            _precio_prod = value
        End Set
    End Property

    Public Property Unidad_prod As String
        Get
            Return _unidad_prod
        End Get
        Set(value As String)
            _unidad_prod = value
        End Set
    End Property

    Public Property Estado_prod As Boolean
        Get
            Return _estado_prod
        End Get
        Set(value As Boolean)
            _estado_prod = value
        End Set
    End Property
End Class
