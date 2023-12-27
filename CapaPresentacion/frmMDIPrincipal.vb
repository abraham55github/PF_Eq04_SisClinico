Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class mdiPrincipal1
    'Permite Mover el formulario por medio de un panel
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub pnlBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        'El form se mostrara en tamaño normal
        btnMini.Visible = False
        btnMaxi.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnCerrarApp_Click(sender As Object, e As EventArgs) Handles btnCerrarApp.Click
        'opcion para cerrar la app
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Realmente desea salir de la App?", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub btnMinimizaar_Click(sender As Object, e As EventArgs) Handles btnMinimizaar.Click
        'Minimiza el form mdi
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaxi_Click(sender As Object, e As EventArgs) Handles btnMaxi.Click
        'Form en pantalla completa
        btnMaxi.Visible = False
        btnMini.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        'Muestra formulario hijo Consultas medicas
        frmConsultaMedica.MdiParent = Me
        frmConsultaMedica.Show()
    End Sub

    Private Sub btnPacientes_Click(sender As Object, e As EventArgs) Handles btnPacientes.Click
        'Muestra formulario hijo Pacientes
        frmPacientes.MdiParent = Me
        frmPacientes.Show()
    End Sub

    Private Sub btnColaboradoresMed_Click(sender As Object, e As EventArgs) Handles btnColaboradoresMed.Click
        'Muestra formulario hijo Medicos
        frmColabMedicos.MdiParent = Me
        frmColabMedicos.Show()
    End Sub

    Private Sub btnAreaMedico_Click(sender As Object, e As EventArgs) Handles btnAreaMedico.Click
        'Muestra formulario hijo Areas Medicas
        frmAreasMedicas.MdiParent = Me
        frmAreasMedicas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Salir de la app
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Realmente desea salir de la App?", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If opcion = DialogResult.Yes Then
            End
        End If

    End Sub

    Private Sub btnInfoGeneral_Click(sender As Object, e As EventArgs) Handles btnInfoGeneral.Click
        'Muestra formulario hijo Informacion general
        frmInfoGeneral.MdiParent = Me
        frmInfoGeneral.Show()
    End Sub

    Private Sub tmrHora_Tick(sender As Object, e As EventArgs) Handles tmrHora.Tick
        ' Muestra nombre de usuario y la hora del sistema
        lblUsuaio.Text = "Usuario: " & Environ("USERNAME")
        lblFechaHora.Text = "Fecha y Hora: [" & Date.Now.ToString("dd MMM yyy hh:mm:ss") & "]"
    End Sub

    Private Sub mdiPrincipal1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrHora.Start()
        Dim ctl As Control
        Dim ctlmdi As MdiClient

        'Permite cambiar el fondo del form mdi
        For Each ctl In Me.Controls
            Try
                ctlmdi = CType(ctl, MdiClient)
                ctlmdi.BackColor = Me.BackColor
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub btnInfoApp_Click(sender As Object, e As EventArgs) Handles btnInfoApp.Click
        'Muestra formulario hijo informacion de la app
        frmInfoApp.MdiParent = Me
        frmInfoApp.Show()
    End Sub
End Class
