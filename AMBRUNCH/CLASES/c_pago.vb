Public Class c_pago
    Private _folio_pago As Int64
    Private _folio_vta As Int64
    Private _total_pago As Double
    Private _dinero As Double
    Private _cambio As Double
    Private _letra As String
    Private _metodo As String
    Private _saldo As Double
    Private _descuento As Double


    Public Property Folio_pago As Long
        Get
            Return _folio_pago
        End Get
        Set(value As Long)
            _folio_pago = value
        End Set
    End Property

    Public Property Folio_vta As Long
        Get
            Return _folio_vta
        End Get
        Set(value As Long)
            _folio_vta = value
        End Set
    End Property

    Public Property Total_pago As Double
        Get
            Return _total_pago
        End Get
        Set(value As Double)
            _total_pago = value
        End Set
    End Property

    Public Property Dinero As Double
        Get
            Return _dinero
        End Get
        Set(value As Double)
            _dinero = value
        End Set
    End Property

    Public Property Cambio As Double
        Get
            Return _cambio
        End Get
        Set(value As Double)
            _cambio = value
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

    Public Property Metodo As String
        Get
            Return _metodo
        End Get
        Set(value As String)
            _metodo = value
        End Set
    End Property

    Public Property Saldo As Double
        Get
            Return _saldo
        End Get
        Set(value As Double)
            _saldo = value
        End Set
    End Property

    Public Property Descuento As Double
        Get
            Return _descuento
        End Get
        Set(value As Double)
            _descuento = value
        End Set
    End Property
End Class
