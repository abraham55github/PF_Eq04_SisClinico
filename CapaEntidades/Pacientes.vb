Public Class Pacientes
    Public Shared Sub Insertar(id As String, nom As String, apellido As String, cedula As String, tel As String, direc As String)
        CapaDatos.MetodosPacientes.InsertarPacientes(Convert.ToInt32(id), nom, apellido, cedula, tel, direc)
    End Sub

    Public Shared Sub editar(id As String, nom As String, apellido As String, cedula As String, tel As String, direc As String)
        CapaDatos.MetodosPacientes.ActualizarPacientes(Convert.ToInt32(id), nom, apellido, cedula, tel, direc)
    End Sub

    Public Shared Sub Eliminar(Id As String)
        CapaDatos.MetodosPacientes.EliminarPaciente(Convert.ToInt32(Id))
    End Sub

End Class
