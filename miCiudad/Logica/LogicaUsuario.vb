Public Class LogicaUsuario
    Dim persistencia As New PersistenciaUsuario

    Public Sub altaUsuario(usuarito As ClaseUsuario)
        persistencia.altaUsuario(usuarito)
    End Sub

    Public Sub modificarUsuario(usuarito As ClaseUsuario)
        persistencia.modificarUsuario(usuarito)
    End Sub

    Public Function bajaUsuario(ci As Integer)
        Return persistencia.bajaUsuario(ci)
    End Function

End Class