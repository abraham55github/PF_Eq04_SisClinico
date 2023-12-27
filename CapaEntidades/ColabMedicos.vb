Public Class ColabMedicos
    Public Shared Sub Insertar(id As String, nom As String, apellido As String, telefono As String, idArea As String)
        CapaDatos.MetodoColabMedico.InsertarColabMed(Convert.ToInt32(id), nom, apellido, telefono, Convert.ToInt32(idArea))
    End Sub

    Public Shared Sub editar(id As String, nom As String, apellido As String, telefono As String, idArea As String)
        CapaDatos.MetodoColabMedico.ActualizarMedicos(Convert.ToInt32(id), nom, apellido, telefono, Convert.ToInt32(idArea))
    End Sub

    Public Shared Sub Eliminar(Id As String)
        CapaDatos.MetodoColabMedico.EliminarMedicos(Convert.ToInt32(Id))
    End Sub
End Class
