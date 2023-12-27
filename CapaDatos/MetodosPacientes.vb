Imports System.Data.SqlClient
Public Class MetodosPacientes
    Public Shared Function ListarPacientes() As DataTable

        'Muestra los datos de la tabla paciente
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("ListarPaciente", CN)
                Using tabla As New DataTable
                    DA.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function

    'Proceso para realizar busqueda por id
    Public Shared Function BuscarPaciente(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_Paciente", CN)
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

    'Procedimeinto para insertar 
    Public Shared Sub InsertarPacientes(id As Integer, nom As String, apellido As String, cedula As String, tel As String, direc As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Insertar_Pacientes", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@nombre", nom)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@tel", tel)
                CMD.Parameters.AddWithValue("@direc", direc)
                CN.Open()
                CMD.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    'Procedimiento para actualizar datos 
    Public Shared Sub ActualizarPacientes(id As Integer, nom As String, apellido As String, cedula As String, tel As String, direc As String)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Actualizar_Pacientess", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@nombre", nom)
                CMD.Parameters.AddWithValue("@apellido", apellido)
                CMD.Parameters.AddWithValue("@cedula", cedula)
                CMD.Parameters.AddWithValue("@tel", tel)
                CMD.Parameters.AddWithValue("@direc", direc)
                CN.Open()
                CMD.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    'Proceso para eliminar
    Public Shared Sub EliminarPaciente(id As Integer)

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Eliminar_Paciente", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
