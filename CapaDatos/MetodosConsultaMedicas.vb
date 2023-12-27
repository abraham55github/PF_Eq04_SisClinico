Imports System.Data.SqlClient
Public Class MetodosConsultaMedicas
    'Proceso para mostrar tabla consultas
    Public Shared Function ListarConsultas() As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using DA As New SqlDataAdapter("ListarConsultass", CN)
                Using tabla As New DataTable
                    DA.Fill(tabla)

                    Return tabla
                End Using
            End Using
        End Using
    End Function
    'Procedimiento de busqueda por medio de los ids
    Public Shared Function BuscarIdconsulta(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_Consulta", CN)
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
    Public Shared Function BuscarIdMed(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_MedConsulta", CN)
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

    Public Shared Function BuscarIdPac(id As Integer) As DataTable

        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("BuscarId_PacConsulta", CN)
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

    'procediemiento para insertar datos
    Public Shared Sub InsertarCosultas(id As Integer, dia As Date, padecimiento As String, estadoConsulta As String, total As Double, idPac As Integer, IdMed As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Insertar_Consultas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@dia", dia)
                CMD.Parameters.AddWithValue("@padecimiento", padecimiento)
                CMD.Parameters.AddWithValue("@estadoconsulta", estadoConsulta)
                CMD.Parameters.AddWithValue("@total", total)
                CMD.Parameters.AddWithValue("@idPac", idPac)
                CMD.Parameters.AddWithValue("@idMed", IdMed)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'proecedimeinto para actualizar 
    Public Shared Sub ActualizarCosultas(id As Integer, dia As Date, padecimiento As String, estadoConsulta As String, total As Double, idPac As Integer, IdMed As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Actualizar_Consultas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CMD.Parameters.AddWithValue("@dia", dia)
                CMD.Parameters.AddWithValue("@padecimiento", padecimiento)
                CMD.Parameters.AddWithValue("@estadoconsulta", estadoConsulta)
                CMD.Parameters.AddWithValue("@total", total)
                CMD.Parameters.AddWithValue("@idPac", idPac)
                CMD.Parameters.AddWithValue("@idMed", IdMed)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    'procedimiento para eliminar
    Public Shared Sub EliminarConsultas(id As Integer)
        Using CN As New SqlConnection(My.Settings.Conexion)
            Using CMD As New SqlCommand("Eliminar_Consultas", CN)
                CMD.CommandType = CommandType.StoredProcedure
                CMD.Parameters.AddWithValue("@Id", id)
                CN.Open()
                CMD.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
