﻿Public Class bajaUsuarioForm
    Dim logica As New LogicaUsuario

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim ci = Convert.ToInt32(tbxCi.Text)
        Try
            Dim si As Byte
            si = MsgBox("¿Desea eliminar este usuario de la base de datos?", vbYesNo, "Eliminar Usuario")
            If si = 6 Then
                Dim res = logica.bajaUsuario(ci)

                If res Then
                    MsgBox("Eliminado")
                    tbxCi.Clear()
                End If

            End If
        Catch ex As Exception
            MsgBox("Error: " + ex.Message)
        End Try

    End Sub
End Class