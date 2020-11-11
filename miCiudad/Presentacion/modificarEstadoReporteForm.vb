Public Class modificarEstadoReporteForm
    Private Sub btnAceptarModReport_Click(sender As Object, e As EventArgs)
        Try

            Dim estadoReporte As String
            estadoReporte = cbxEstado.SelectedItem.ToString()

            Dim id As String
            id = tbxId.Text

            Dim reporteNuevo As New claseReporte()
            reporteNuevo.Id = id
            reporteNuevo.Estado = estadoReporte

            Dim logica As New LogicaReporte()
            logica.asignarReporte(reporteNuevo)

        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class