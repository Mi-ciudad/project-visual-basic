Public Class buscarReporte
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Dim idReporte As Integer
            idReporte = tbxId.Text

            Dim personaNueva = New claseReporte()

            Dim logica As New LogicaReporte()
            personaNueva = logica.bucarReporte(idReporte)

            'Mostrar.Text = personaNueva.Ci.ToString + " - " + personaNueva.Nombre + " - " + personaNueva.Direccion


        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub
End Class