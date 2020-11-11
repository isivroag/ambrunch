Public Class c_unidad
    Private _id_unidad As Int64
    Private _nom_unidad As String
    Private _estado_unidad As Boolean

    Public Property Id_unidad As Long
        Get
            Return _id_unidad
        End Get
        Set(value As Long)
            _id_unidad = value
        End Set
    End Property

    Public Property Nom_unidad As String
        Get
            Return _nom_unidad
        End Get
        Set(value As String)
            _nom_unidad = value
        End Set
    End Property

    Public Property Estado_unidad As Boolean
        Get
            Return _estado_unidad
        End Get
        Set(value As Boolean)
            _estado_unidad = value
        End Set
    End Property
End Class
