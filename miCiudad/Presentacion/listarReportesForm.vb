Public Class listarReportesForm
    Private Sub listarReporte_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim logica As New LogicaReporte()
        Dim newClaseReporte = logica.listarReporte()
        Dim array(5) As String
        For i = 0 To newClaseReporte.Count - 1
            array(0) = newClaseReporte(i).Id
            array(1) = newClaseReporte(i).Direccion
            array(2) = newClaseReporte(i).Descripcion
            array(3) = newClaseReporte(i).Estado
            array(4) = newClaseReporte(i).Ci
            Dim item = New ListViewItem(array)
            ListViewReportes.Items.Add(item)
        Next

    End Sub

    Private Sub ListViewReportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewReportes.SelectedIndexChanged

    End Sub
End Class