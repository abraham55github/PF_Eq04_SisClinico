Public Class AreasMedicas

    Public Shared Sub Insertar(Id As String, nombre As String)
        CapaDatos.MetodosAreas_Medicas.InsertarAreas(Convert.ToInt32(Id), nombre)
    End Sub

    Public Shared Sub Editar(Id As String, nombre As String)
        CapaDatos.MetodosAreas_Medicas.ActualizarAreas(Convert.ToInt32(Id), nombre)
    End Sub

    Public Shared Sub Eliminar(Id As String)
        CapaDatos.MetodosAreas_Medicas.EliminarAreas(Convert.ToInt32(Id))
    End Sub

End Class
