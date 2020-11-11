Public Class claseModificarUsuario
    Private _ci As Integer
    Private _nombre As String
    Private _apellido As String
    Private _telefono As Integer
    Private _correo As String
    Private _contrasenia As String
    Private _tipoUsuario As String

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

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property Contrasenia As String
        Get
            Return _contrasenia
        End Get
        Set(value As String)
            _contrasenia = value
        End Set
    End Property

    Public Property TipoUsuario As String
        Get
            Return _tipoUsuario
        End Get
        Set(value As String)
            _tipoUsuario = value
        End Set
    End Property

    Public Sub ClaseModificarUsuario()

    End Sub

    Public Sub ClaseModificarUsuario(ci_ As Integer, nombre_ As String, apellido_ As String, telefono_ As Integer, correo_ As String, contrasenia_ As String, tipoUsuario_ As String)
        Ci = ci_
        Nombre = nombre_
        Apellido = apellido_
        Telefono = telefono_
        Correo = correo_
        Contrasenia = contrasenia_
        TipoUsuario = tipoUsuario_
    End Sub
End Class
