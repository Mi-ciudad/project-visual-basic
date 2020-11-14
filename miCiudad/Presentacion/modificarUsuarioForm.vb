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

            tbxCorreo.Text = ""
            tbxCi.Text = ""
            tbxNombre.Text = ""
            tbxApellido.Text = ""
            tbxContrasenia.Text = ""

            Dim logica As New LogicaUsuario()
            logica.modificarUsuario(usuarioNueva)
            MsgBox("Este usuario fue modificado")
        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub modificarUsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxContrasenia.PasswordChar = "*"

    End Sub
End Class