Public Class claseBajaUsuario
    Private _ci As Integer

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Sub ClaseBajaUsuario()

    End Sub

    Public Sub ClaseBajaUsuario(ci_ As Integer)
        Ci = ci_
    End Sub

End Class
