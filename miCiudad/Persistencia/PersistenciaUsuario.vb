﻿Imports Npgsql

Public Class PersistenciaUsuario
    Dim conexion As New Npgsql.NpgsqlConnection

    Public Sub New()

    End Sub

    Public Sub modificarUsuario(usuarito As ClaseUsuario)
        Try

            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String

            cadenaComandos = "UPDATE usuarios SET password =md5(@password), email=@email, nombre =@name, apellido =@surname, tipoUsuario =@userType WHERE ci = @ci;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = usuarito.Passwd
            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = usuarito.Email

            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Nombre
            cmd.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Apellido
            cmd.Parameters.Add("@userType", NpgsqlTypes.NpgsqlDbType.Varchar, 20).Value = "Usuario"
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Ci

            cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function altaUsuario(usuarito As ClaseUsuario) As Boolean
        Try

            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String
            cadenaComandos = " insert into usuarios   (password, email, ci, nombre, apellido, tipoUsuario) values(md5(@password), @email, @ci, @name, @surname, @userType);"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = usuarito.Email
            cmd.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = usuarito.Passwd
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = usuarito.Ci
            cmd.Parameters.Add("@name", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Nombre
            cmd.Parameters.Add("@surname", NpgsqlTypes.NpgsqlDbType.Varchar, 30).Value = usuarito.Apellido
            cmd.Parameters.Add("@userType", NpgsqlTypes.NpgsqlDbType.Varchar, 10).Value = "Usuario"

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery
            If resultado >= 1 Then
                Return True
            Else
                Return False
            End If
            'cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function bajaUsuario(ci As Integer) As Boolean
        Try
            Dim logica As New LogicaReporte
            Dim res = logica.bajaReporte(ci)

            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion
            Dim cadenaComandos As String

            Dim resultado As Integer

            cadenaComandos = "DELETE FROM usuarios WHERE ci = @ci ;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            resultado = cmd.ExecuteNonQuery

            If resultado >= 1 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function


End Class
