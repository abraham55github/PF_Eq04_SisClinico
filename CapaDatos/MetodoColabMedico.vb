Imports System.Data.SqlClient
Public Class MetodoColabMedico
    'Muestra la tabla de colaboradores medicos
    Public Shared Function ListarColabMedicos() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("ListarColabMedicoss", CN)
                Using tabla As New DataTable
                    DA.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function
    'Realiza busqueda por IDs
    Public Shared Function BuscarIdAreaM(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_AreaM", CN)
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

    Public Shared Function BuscarIdmedico(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_Medico", CN)
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
    Public Shared Sub InsertarColabMed(id As Integer, nom As String, apellido As String, telefono As String, idArea As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Insertar_ColabMedicos", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@nombre", nom)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@idArea", idArea)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'Proceso para actualizar datos
    Public Shared Sub ActualizarMedicos(id As Integer, nom As String, apellido As String, telefono As String, idArea As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Actualizar_ColabMedicos", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@nombre", nom)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@telefono", telefono)
                CMD.Parameters.AddWithValue("@idArea", idArea)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    'Proceso para eliminar datos
    Public Shared Sub EliminarMedicos(id As Integer)

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Eliminar_Medicos", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
