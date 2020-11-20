Public Class c_usuario
    Private _clave As Integer
    Private _nombre As String
    Private _login As String
    Private _password As String
    Private _tipo As Integer
    Private _estado_u As Boolean

    Public Property Clave As Integer
        Get
            Return _clave
        End Get
        Set(value As Integer)
            _clave = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Login As String
        Get
            Return _login
        End Get
        Set(value As String)
            _login = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property

    Public Property Estado_u As Boolean
        Get
            Return _estado_u
        End Get
        Set(value As Boolean)
            _estado_u = value
        End Set
    End Property
End Class
