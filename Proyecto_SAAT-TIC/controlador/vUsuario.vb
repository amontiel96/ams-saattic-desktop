Public Class vUsuario
    Private users As String
    Private pass As String
    Private nivel As String

    Public Property _users
        Get
            Return users
        End Get
        Set(value)
            users = value
        End Set
    End Property
    Public Property _pass
        Get
            Return pass
        End Get
        Set(value)
            pass = value
        End Set
    End Property
    Public Property _nivel
        Get
            Return nivel
        End Get
        Set(value)
            nivel = value
        End Set
    End Property
End Class
