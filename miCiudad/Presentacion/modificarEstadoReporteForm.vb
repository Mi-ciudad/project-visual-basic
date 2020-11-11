Public Class modificarEstadoReporteForm

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub modificarEstadoReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ButtonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnAceptar.ClientRectangle
        myRectangle.Inflate(-5, 10)
        ButtonPath.AddEllipse(myRectangle)
        btnAceptar.Region = New Region(ButtonPath)
        btnBorrar.Region = New Region(ButtonPath)
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
End Class