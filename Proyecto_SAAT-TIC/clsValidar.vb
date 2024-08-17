Public Class clsValidar
    Dim v As String
    Dim n As String
    Dim tipo As String
    Dim ap As String
    Dim cor As String
    Dim tel As String
    Dim recibe As String
    Dim nom As String
    Dim des As String
    Public tipo1 As String = tipo

    Public Property mtdTipoUser() As String
        Get
            Return tipo
        End Get
        Set(ByVal value As String)
            tipo = value

        End Set
    End Property
   




    Public Property password() As String
        Get
            Return v
        End Get
        Set(ByVal value As String)
            If (value.Length <= 8) Then
                v = value
            Else
                v = "Solo se permiten 8 digitos"
            End If
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return n
        End Get
        Set(ByVal value As String)
            If (value.Length <= 15 And Not (IsNumeric(value) = True)) Then
                n = value
            Else
                n = "Únicamente letras"
            End If
        End Set
    End Property
    Public Property Apellidos() As String
        Get
            Return ap
        End Get
        Set(ByVal value As String)
            If (value.Length <= 25 And Not (IsNumeric(value) = True)) Then
                ap = value
            Else
                ap = "Únicamente letras"
            End If
        End Set
    End Property
    Public Property Correo() As String
        Get
            Return cor
        End Get
        Set(ByVal value As String)
            cor = value
        End Set
    End Property
    Public Property Telef() As String
        Get
            Return tel
        End Get
        Set(ByVal value As String)
            If (value.Length = 10 And IsNumeric(value) = True) Then
                tel = value
            Else
                tel = "Solo numeros"
            End If
        End Set
    End Property
    Public Property nombreI() As String
        Get
            Return nom
        End Get
        Set(ByVal value As String)
            If (value.Length <= 20 And Not IsNumeric(value) = True) Then
                nom = value
            Else
                nom = "Escribir 5 digitos numericos"
            End If
        End Set
    End Property
    Public Property DescripcionI() As String
        Get
            Return des
        End Get
        Set(ByVal value As String)
            If (value.Length <= 250) Then
                des = value

            End If
        End Set
    End Property

End Class

