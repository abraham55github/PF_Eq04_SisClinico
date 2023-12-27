Public Class ConsultaMedica
    Public Shared Sub InsertarCosultas(id As String, dia As Date, padecimiento As String, estadoConsulta As String, total As String, idPac As String, IdMed As String)
        CapaDatos.MetodosConsultaMedicas.InsertarCosultas(Convert.ToInt32(id), dia, padecimiento, estadoConsulta, Convert.ToDouble(total), Convert.ToInt32(idPac), Convert.ToInt32(IdMed))
    End Sub

    Public Shared Sub ActualizarCosultas(id As String, dia As Date, padecimiento As String, estadoConsulta As String, total As String, idPac As String, IdMed As String)
        CapaDatos.MetodosConsultaMedicas.ActualizarCosultas(Convert.ToInt32(id), dia, padecimiento, estadoConsulta, Convert.ToDouble(total), Convert.ToInt32(idPac), Convert.ToInt32(IdMed))
    End Sub

    Public Shared Sub Eliminar(Id As String)
        CapaDatos.MetodosConsultaMedicas.EliminarConsultas(Convert.ToInt32(Id))
    End Sub

End Class
