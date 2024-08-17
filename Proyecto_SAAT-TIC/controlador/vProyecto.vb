Public Class vProyecto
    Dim vProyecto, vId_cli, vId_Info, vNombre, vId_tipo, vDescripcion As String

    Public Property gProyecto
        Get
            Return vProyecto
        End Get
        Set(value)
            vProyecto = value
        End Set
    End Property
    Public Property gCliente
        Get
            Return vId_cli
        End Get
        Set(value)
            vId_cli = value
        End Set
    End Property
    Public Property gInfo
        Get
            Return vId_Info
        End Get
        Set(value)
            vId_Info = value
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
    Public Property gIdTipo
        Get
            Return vId_tipo
        End Get
        Set(value)
            vId_tipo = value
        End Set
    End Property
    Public Property gDescr
        Get
            Return vDescripcion
        End Get
        Set(value)
            vDescripcion = value
        End Set
    End Property
End Class
