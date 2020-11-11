Public Class bajaUsuarioForm
    Dim logica As New LogicaUsuario

    Private Sub EliminarUsuario(sender As Object, e As EventArgs)

    End Sub

    Private Sub bajaUsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ButtonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnAceptar.ClientRectangle
        myRectangle.Inflate(1, 20)
        ButtonPath.AddEllipse(myRectangle)
        btnAceptar.Region = New Region(ButtonPath)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ci = Convert.ToInt32(tbxCi.Text)

        Dim si As Byte
        si = MsgBox("¿Desea eliminar este usuario de la base de datos?", vbYesNo, "Eliminar Usuario")
        If si = 6 Then
            Dim res = logica.bajaUsuario(ci)

            If res Then
                MsgBox("Eliminado")
                tbxCi.Clear()
            End If

        End If
    End Sub

End Class