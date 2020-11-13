Public Class LogicaReporte
    Dim persistencia As New PersistenciaReporte

    Public Sub asignarReporte(reportesito As claseReporte)
        persistencia.asignarReporte(reportesito)
    End Sub

    Public Function bucarReporte(id As Integer) As claseReporte
        persistencia.bucarPersona(id)
        Dim newPersonaClase As claseReporte
        newPersonaClase = persistencia.bucarPersona(id)
        Return newPersonaClase
    End Function

    Public Function listarReporte()
        Return persistencia.listarReporte()
    End Function

    Public Function bajaReporte(ci As Integer) As Boolean
        persistencia.bajaReporte(ci)
    End Function

End Class
