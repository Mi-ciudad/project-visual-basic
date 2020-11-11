Public Class ClaseUsuario

    Private _email As String
    Private _passwd As String
    Private _ci As Integer
    Private _nombre As String
    Private _apellido As String
    Private _tipo As String
    Private _nombreUsuario As String

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property Passwd As String
        Get
            Return _passwd
        End Get
        Set(value As String)
            _passwd = value
        End Set
    End Property

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
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

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Sub ClaseUsuario()

    End Sub

    Public Sub ClaseUsuario(email_ As String, nombreUsuario_ As String, passwd_ As String, ci_ As Integer, nombre_ As String, apellido_ As String, tipoUsuario_ As String)
        NombreUsuario = nombreUsuario_
        Email = email_
        Passwd = passwd_
        Ci = ci_
        Nombre = nombre_
        Apellido = apellido_
        Tipo = tipoUsuario_
    End Sub
End Class