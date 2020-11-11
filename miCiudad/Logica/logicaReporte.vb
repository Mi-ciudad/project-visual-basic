Public Class LogicaReporte
    Public Sub asignarReporte(reportesito As claseReporte)
        Dim persistencia As New PersistenciaReporte
        persistencia.asignarReporte(reportesito)
    End Sub

    Public Function bucarReporte(id As Integer) As claseReporte
        Dim persistencia As New PersistenciaReporte
        persistencia.bucarPersona(id)
        Dim newPersonaClase As claseReporte
        newPersonaClase = persistencia.bucarPersona(id)
        Return newPersonaClase
    End Function
End Class
