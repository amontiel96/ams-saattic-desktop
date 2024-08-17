Public Class vAsesoria
    Dim vTema, vDesc As String
    Dim vId, vId_info, vId_clie, vStatus As Integer

    Public Property gTema
        Get
            Return vTema
        End Get
        Set(value)
            vTema = value
        End Set
    End Property
    Public Property gDesc
        Get
            Return vDesc
        End Get
        Set(value)
            vDesc = value
        End Set
    End Property
    Public Property gId
        Get
            Return vId
        End Get
        Set(value)
            vId = value
        End Set
    End Property
    Public Property gId_info
        Get
            Return vId_info
        End Get
        Set(value)
            vId_info = value
        End Set
    End Property
    Public Property gId_clie
        Get
            Return vId_clie
        End Get
        Set(value)
            vId_clie = value
        End Set
    End Property
End Class
