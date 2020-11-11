Public Class modificarUserForm

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try

            Dim emailUsuario As String
            emailUsuario = tbxCorreo.Text

            Dim ciUsuario As Integer
            ciUsuario = tbxCi.Text

            Dim nombreUsuario As String
            nombreUsuario = tbxNombre.Text

            Dim apellidoUsuario As String
            apellidoUsuario = tbxApellido.Text

            Dim contrasenia As String
            contrasenia = tbxContrasenia.Text

            Dim usuarioNueva = New ClaseUsuario()
            usuarioNueva.Email = emailUsuario
            usuarioNueva.Ci = ciUsuario
            usuarioNueva.Nombre = nombreUsuario
            usuarioNueva.Apellido = apellidoUsuario
            usuarioNueva.Passwd = contrasenia

            Dim logica As New LogicaUsuario()
            logica.modificarUsuario(usuarioNueva)
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub modificarUsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ButtonPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
        Dim myRectangle As Rectangle = btnAceptar.ClientRectangle
        myRectangle.Inflate(-5, 10)
        ButtonPath.AddEllipse(myRectangle)
        btnAceptar.Region = New Region(ButtonPath)
        btnBorrar.Region = New Region(ButtonPath)
    End Sub
End Class