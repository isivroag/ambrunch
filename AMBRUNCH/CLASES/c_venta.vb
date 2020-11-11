Public Class c_venta
    Private _folio_vta As Int64
    Private _folio_fis As Int64
    Private _fecha_vta As DateTime
    Private _cliente As String
    Private _total_vta As Double
    Private _fact_vta As Boolean
    Private _estado_vta As Boolean
    Private _letra As String

    Public Property Folio_vta As Long
        Get
            Return _folio_vta
        End Get
        Set(value As Long)
            _folio_vta = value
        End Set
    End Property

    Public Property Folio_fis As Long
        Get
            Return _folio_fis
        End Get
        Set(value As Long)
            _folio_fis = value
        End Set
    End Property

    Public Property Fecha_vta As Date
        Get
            Return _fecha_vta
        End Get
        Set(value As Date)
            _fecha_vta = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    Public Property Total_vta As Double
        Get
            Return _total_vta
        End Get
        Set(value As Double)
            _total_vta = value
        End Set
    End Property

    Public Property Fact_vta As Boolean
        Get
            Return _fact_vta
        End Get
        Set(value As Boolean)
            _fact_vta = value
        End Set
    End Property

    Public Property Estado_vta As Boolean
        Get
            Return _estado_vta
        End Get
        Set(value As Boolean)
            _estado_vta = value
        End Set
    End Property

    Public Property Letra As String
        Get
            Return _letra
        End Get
        Set(value As String)
            _letra = value
        End Set
    End Property
End Class
