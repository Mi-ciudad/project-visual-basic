Imports Npgsql



Public Class PersistenciaReporte

    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub asignarReporte(reportesito As claseReporte)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String

            cadenaComandos = "UPDATE Reportes SET estado =@state WHERE id = @id;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = reportesito.Descripcion
            cmd.Parameters.Add("@direction", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Direccion
            cmd.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Estado
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = reportesito.Ci
            cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Bytea).Value = reportesito.Imagen

        Catch ex As Exception

        End Try
    End Sub


    Public Function bucarPersona(cedula As Integer) As claseReporte
        Dim newReporte As New claseReporte()
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String
            cadenaComandos = "SELECT * FROM reportes WHERE id = @id;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = cedula

            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                newReporte.Ci = Convert.ToInt32(lector(0).ToString)
                newReporte.Descripcion = lector(1).ToString
                newReporte.Direccion = lector(2).ToString
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()

        End Try
        Return newReporte
    End Function
    '    Public Sub altaReporte(reportesito As claseReporte)
    '        Try
    '            Dim classcnn = New Conexion
    '            conexion = classcnn.abrirConexion

    '            Dim cmd = New Npgsql.NpgsqlCommand
    '            cmd.Connection = conexion
    '            Dim cadenaComandos As String
    '            cadenaComandos = "insert into Reportes (description, direction, state, id, ci, image) values (@description, @direction, @state, DEFAULT, @ci, @image);"
    '            cmd.CommandText = cadenaComandos

    '            cmd.Parameters.Add("@description", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = reportesito.Descripcion
    '            cmd.Parameters.Add("@direction", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Direccion
    '            cmd.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Estado
    '            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = reportesito.Ci
    '            cmd.Parameters.Add("@image", NpgsqlTypes.NpgsqlDbType.Bytea).Value = reportesito.Imagen


    '            cmd.ExecuteReader()
    '        Catch ex As Exception
    '            Throw ex
    '        Finally
    '            conexion.Close()
    '        End Try
    '    End Sub

End Class
