Public Class c_det_vta
    Private _id_reg As Integer
    Private _folio_vta As Integer
    Private _id_prod As Integer
    Private _nom_prod As String
    Private _cantidad As Double
    Private _unidad_prod As String
    Private _precio_prod As Double
    Private _subtotal As Double
    Private _estado_det As Double

    Public Property Id_reg As Integer
        Get
            Return _id_reg
        End Get
        Set(value As Integer)
            _id_reg = value
        End Set
    End Property

    Public Property Folio_vta As Integer
        Get
            Return _folio_vta
        End Get
        Set(value As Integer)
            _folio_vta = value
        End Set
    End Property

    Public Property Id_prod As Integer
        Get
            Return _id_prod
        End Get
        Set(value As Integer)
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

    Public Property Cantidad As Double
        Get
            Return _cantidad
        End Get
        Set(value As Double)
            _cantidad = value
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

    Public Property Precio_prod As Double
        Get
            Return _precio_prod
        End Get
        Set(value As Double)
            _precio_prod = value
        End Set
    End Property

    Public Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property

    Public Property Estado_det As Double
        Get
            Return _estado_det
        End Get
        Set(value As Double)
            _estado_det = value
        End Set
    End Property
End Class
