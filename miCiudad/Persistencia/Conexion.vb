Public Class Conexion

    Public Function abrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        Try
            conexion = New Npgsql.NpgsqlConnection
            Dim cadenaConexion As String
<<<<<<< Updated upstream

            'cadenaConexion = "Server=127.0.0.1;Port=5432;User Id='postgres';Password='root';Database =miCiudad"
            cadenaConexion = "Server=10.1.14.80;Port=5432;User Id='postgres';Password='password';Database =miciudad"

=======
            'cadenaConexion = "Server=127.0.0.1;Port=5432;User Id='postgres';Password='root';Database =miCiudad"
            cadenaConexion = "Server=10.1.14.80;Port=5432;User Id='postgres';Password='password';Database =miCiudad"
>>>>>>> Stashed changes
            conexion.ConnectionString = cadenaConexion
            conexion.Open()

        Catch ex As Exception
            Throw ex
        End Try

        Return conexion
    End Function

End Class
