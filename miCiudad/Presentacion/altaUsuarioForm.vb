﻿Public Class formAltaUsuario

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
            Dim logica As New LogicaUsuario()

            If emailUsuario <> "" And ciUsuario.ToString <> "" And apellidoUsuario <> "" And nombreUsuario <> "" And contrasenia <> "" Then
                usuarioNueva.Email = emailUsuario
                usuarioNueva.Ci = ciUsuario
                usuarioNueva.Nombre = nombreUsuario
                usuarioNueva.Apellido = apellidoUsuario
                usuarioNueva.Passwd = contrasenia

                logica.altaUsuario(usuarioNueva)

                MsgBox("Este usuario fue ingresado")

                tbxCorreo.Text = ""
                tbxCi.Text = ""
                tbxNombre.Text = ""
                tbxApellido.Text = ""
                tbxContrasenia.Text = ""
            Else
                'Por si cualquier casillero esta vacio
                If emailUsuario = "" Or ciUsuario.ToString = "" Or nombreUsuario = "" Or apellidoUsuario = "" Or contrasenia = "" Then
                    MsgBox("No puedes dejar ninguna casilla vacia")
                End If


            End If

        Catch ex As Exception
            MsgBox("un error: " + ex.Message)
        End Try
    End Sub

    Private Sub altaUsuarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxContrasenia.PasswordChar = "*"
    End Sub

    Private Sub btnBorrar_Click_1(sender As Object, e As EventArgs) Handles btnBorrar.Click
        tbxCorreo.Text = ""
        tbxCi.Text = ""
        tbxNombre.Text = ""
        tbxApellido.Text = ""
        tbxContrasenia.Text = ""

    End Sub
    'End Sub
    'Me.tbxNombre Border.CornerRadius
End Class