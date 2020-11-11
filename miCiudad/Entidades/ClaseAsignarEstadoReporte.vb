Public Class claseAsignarEstadoReporte
    Private _id As Integer
    Private _estado As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Sub ClaseAsignarEstadoReporte()

    End Sub

    Public Sub ClaseAsignarEstadoReporte(id_ As Integer, estado_ As String)
        Id = id_
        Estado = estado_
    End Sub

End Class
