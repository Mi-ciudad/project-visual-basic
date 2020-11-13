Imports Npgsql
Public Class PersistenciaReporte

    Dim conexion As Npgsql.NpgsqlConnection

    'SIN TERMINAR BUSCAR REPORTE
    'cambiar persona por reporte
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

            'Cambiar cedula por id
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

    Public Sub asignarReporte(reportesito As claseReporte)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion
            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion
            Dim cadenaComandos As String

            cadenaComandos = "UPDATE Reportes SET estado =@state WHERE id = @id;"
            cmd.CommandText = cadenaComandos

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = reportesito.Id
            cmd.Parameters.Add("@state", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = reportesito.Estado
            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function listarReporte()
        Dim listaReportesito As New List(Of claseReporte)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand With {
                .Connection = conexion
            }
            Dim cadenaComandos As String
            cadenaComandos = "SELECT * FROM reportes;"
            cmd.CommandText = cadenaComandos

            Dim lector As NpgsqlDataReader
            lector = cmd.ExecuteReader()

            While lector.Read
                Dim reporte As New claseReporte With {
                    .Descripcion = lector(0).ToString,
                    .Direccion = lector(1).ToString,
                    .Estado = lector(2).ToString,
                    .Id = lector(3).ToString,
                    .Ci = lector(4).ToString
                }
                listaReportesito.Add(reporte)
                'reporte.use = lector(0).ToString

            End While
        Catch ex As Exception

        Finally
            conexion.Close()
        End Try
        Return listaReportesito
    End Function

    Public Function bajaReporte(ci As Integer) As Boolean
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.abrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand


            cmd.Connection = conexion
            Dim cadenaComandos As String

            Dim resultado As Integer

            cadenaComandos = "DELETE FROM reportes WHERE ci = @ci ;"
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
