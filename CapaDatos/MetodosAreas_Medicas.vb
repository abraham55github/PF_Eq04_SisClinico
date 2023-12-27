Imports System.Data.SqlClient

Public Class MetodosAreas_Medicas
    'Lista la tabla areas medicas
    Public Shared Function ListarAreas() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("ListarAreasM", CN)
                Using tabla As New DataTable
                    DA.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function
    'Busqueda de area por Id
    Public Shared Function BuscarAreas(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_Area", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@codigo", id)

                Using DA As New SqlDataAdapter(CMD)
                    Using tabla As New DataTable
                        DA.Fill(tabla)

                        Return tabla
                    End Using
                End Using
            End Using
        End Using
    End Function
    'Procedimiento para insertar datos
    Public Shared Sub InsertarAreas(id As Integer, nom As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Insertar_AreasMedicas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@nombre", nom)

                CN.Open()
                CMD.ExecuteNonQuery()

            End Using
        End Using
    End Sub
    'Procedimiento para actualizar tabla
    Public Shared Sub ActualizarAreas(id As Integer, nom As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Actualizar_AreasMedicas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@nombre", nom)
                CMD.Parameters.AddWithValue("@Id", id)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'Procemiento para eliminar un registro
    Public Shared Sub EliminarAreas(id As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Eliminar_AreasMedicas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CN.Open()
                CMD.ExecuteNonQuery()

            End Using
        End Using
    End Sub
End Class
