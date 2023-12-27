Public Class frmCargaApp
    Private Sub tmrCargar_Tick(sender As Object, e As EventArgs) Handles tmrCargar.Tick
        'condiciones de la barra de carga
        If pbrCargar.Value < 100 Then
            pbrCargar.Value = pbrCargar.Value + 10
            lblProgreso.Text = "Cargando el sistema al " & pbrCargar.Value & " %"
        Else
            tmrCargar.Enabled = False
            Me.Hide()
            mdiPrincipal1.Show()
        End If
    End Sub

    Private Sub frmCargaApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrCargar.Start() 'Inicia el timer para la barra de carga
    End Sub
End Class