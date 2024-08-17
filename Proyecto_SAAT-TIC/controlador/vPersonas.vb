Public Class vPersonas

    Dim vNombre, vAP, vAM, vCorreo, vUser, vPwd As String
    Dim vidMun, vidtUser, vIdP, vId_inf, vId_clie As Integer
    Dim vFecha As Date
    Public Property gId
        Get
            Return vIdP
        End Get
        Set(value)
            vIdP = value
        End Set
    End Property
    Public Property gId_info
        Get
            Return vId_inf
        End Get
        Set(value)
            vId_inf = value
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

    Public Property gNombre
        Get
            Return vNombre
        End Get
        Set(value)
            vNombre = value
        End Set
    End Property
    Public Property gAP
        Get
            Return vAP
        End Get
        Set(value)
            vAP = value
        End Set
    End Property
    Public Property gAM
        Get
            Return vAM
        End Get
        Set(value)
            vAM = value
        End Set
    End Property
    Public Property gCorreo
        Get
            Return vCorreo
        End Get
        Set(value)
            vCorreo = value
        End Set
    End Property
    Public Property gUser
        Get
            Return vUser
        End Get
        Set(value)
            vUser = value
        End Set
    End Property
    Public Property gPwd
        Get
            Return vPwd
        End Get
        Set(value)
            vPwd = value
        End Set
    End Property
    Public Property gIdMun
        Get
            Return vidMun
        End Get
        Set(value)
            vidMun = value
        End Set
    End Property
    Public Property gIdtUser
        Get
            Return vidtUser
        End Get
        Set(value)
            vidtUser = value
        End Set
    End Property
    Public Property gFecha
        Get
            Return vFecha
        End Get
        Set(value)
            vFecha = value
        End Set
    End Property


End Class
