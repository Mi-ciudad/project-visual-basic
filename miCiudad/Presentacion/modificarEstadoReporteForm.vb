Public Class modificarEstadoReporteForm


    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            Dim estadoReporte As String
            estadoReporte = cbxEstado.SelectedItem.ToString()

            Dim id As Integer

            id = tbxId.Text

            Dim reporteNuevo As New claseReporte()
            reporteNuevo.Id = id
            reporteNuevo.Estado = estadoReporte

            Dim logica As New LogicaReporte()
            logica.asignarReporte(reporteNuevo)
            MsgBox("Este estado fue modificado")
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub
End Class