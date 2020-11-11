Public Class mainForm
    Private Sub AltaUserMenuItem_Click(sender As Object, e As EventArgs) Handles AltaUserMenuItem.Click
        formAltaUsuario.ShowDialog()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click
        modificarUserForm.ShowDialog()
    End Sub

    Private Sub AsignarEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarEstadoToolStripMenuItem.Click
        modificarEstadoReporteForm.ShowDialog()
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BajaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaUsuarioToolStripMenuItem.Click
        bajaUsuarioForm.ShowDialog()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        buscarReporte.ShowDialog()
    End Sub
End Class
