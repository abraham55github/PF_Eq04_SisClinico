Imports System.Runtime.InteropServices

Public Class frmPacientes
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub frmPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Muestra la tabla Pacientes y la cantidad de ellos
        dgvPacientes.DataSource = CapaDatos.MetodosPacientes.ListarPacientes()
        TabPacientesAgregar.Parent = Nothing
        tabPacienteEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlPaciente
        txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Muestra la ventana agregar
        tabPacienteListar.Parent = Nothing
        tabPacienteEditar.Parent = Nothing
        TabPacientesAgregar.Parent = TabControlPaciente
        txtIdPac.Focus()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Realiza busquedas por medio del nombre, apellido y cedula del paciente
        If cboPacientes.SelectedItem = "Nombre" Then
            Dim vista As New DataView(CapaDatos.MetodosPacientes.ListarPacientes)
            vista.RowFilter = "Nombre_Paciente LIKE'" & txtBuscar.Text & "%'"
            dgvPacientes.DataSource = vista
            txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
        End If
        If cboPacientes.SelectedItem = "Apellido" Then
            Dim vista As New DataView(CapaDatos.MetodosPacientes.ListarPacientes)
            vista.RowFilter = "Apellido_Paciente LIKE'" & txtBuscar.Text & "%'"
            dgvPacientes.DataSource = vista
            txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
        End If
        If cboPacientes.SelectedItem = "Cedula" Then
            Dim vista As New DataView(CapaDatos.MetodosPacientes.ListarPacientes)
            vista.RowFilter = "Cedula LIKE'" & txtBuscar.Text & "%'"
            dgvPacientes.DataSource = vista
            txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'Realiza busqueda por medio del id del paciente
            If cboPacientes.SelectedItem = "Id_Paciente" And txtBuscar.Text <> "" Then
                dgvPacientes.DataSource = CapaDatos.MetodosPacientes.BuscarPaciente(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Guarda los datos ingresados para insertarlos en la tabla
            If txtIdPac.Text = Nothing Or txtNomPaciente.Text = Nothing Or txtApellidoPac.Text = Nothing Or txtCedulaPac.Text = Nothing Or mtxtTelefonoPac.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                CapaEntidades.Pacientes.Insertar(txtIdPac.Text, txtNomPaciente.Text, txtApellidoPac.Text, txtCedulaPac.Text, mtxtTelefonoPac.Text, txtDireccionPac.Text)
                MsgBox("Los datos fueron ingresados correctamente")
                txtIdPac.Clear()
                txtNomPaciente.Clear()
                txtApellidoPac.Clear()
                txtCedulaPac.Clear()
                mtxtTelefonoPac.Clear()
                txtDireccionPac.Clear()
                TabPacientesAgregar.Parent = Nothing
                tabPacienteEditar.Parent = Nothing
                tabPacienteListar.Parent = TabControlPaciente
                dgvPacientes.DataSource = CapaDatos.MetodosPacientes.ListarPacientes
                txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim fila As Integer
        Try
            'Guarda los valores de la fila seleccionada para luego editar
            tabPacienteListar.Parent = Nothing
            TabPacientesAgregar.Parent = Nothing
            tabPacienteEditar.Parent = TabControlPaciente
            fila = dgvPacientes.CurrentCell.RowIndex
            txtNombreMod.Focus()
            txtIdModificar.Text = dgvPacientes(0, fila).Value.ToString()
            txtNombreMod.Text = dgvPacientes(1, fila).Value.ToString()
            txtApellidoMod.Text = dgvPacientes(2, fila).Value.ToString()
            txtCedulaMod.Text = dgvPacientes(3, fila).Value.ToString()
            mtxtTelefonoMod.Text = dgvPacientes(4, fila).Value.ToString()
            txtDireccionMod.Text = dgvPacientes(5, fila).Value.ToString()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Guarda los datos modificados 
            If txtNombreMod.Text = Nothing Or txtApellidoMod.Text = Nothing Or txtApellidoMod.Text = Nothing Or txtCedulaMod.Text = Nothing Or mtxtTelefonoMod.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else

                CapaEntidades.Pacientes.editar(txtIdModificar.Text, txtNombreMod.Text, txtApellidoMod.Text, txtCedulaMod.Text, mtxtTelefonoMod.Text, txtDireccionMod.Text)
                MsgBox("Los datos fueron actualizados correctamente")
                TabPacientesAgregar.Parent = Nothing
                tabPacienteEditar.Parent = Nothing
                tabPacienteListar.Parent = TabControlPaciente
                dgvPacientes.DataSource = CapaDatos.MetodosPacientes.ListarPacientes
                txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TabPacientesAgregar.Parent = Nothing
        tabPacienteEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlPaciente
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        TabPacientesAgregar.Parent = Nothing
        tabPacienteEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlPaciente
        txtIdPac.Clear()
        txtNomPaciente.Clear()
        txtApellidoPac.Clear()
        txtCedulaPac.Clear()
        mtxtTelefonoPac.Clear()
        txtDireccionPac.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer
        Dim borrar As DialogResult
        'Elimina el registro selecionado en la tabla
        Try
            borrar = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If borrar = DialogResult.Yes Then
                fila = dgvPacientes.CurrentCell.RowIndex
                CapaEntidades.Pacientes.Eliminar(dgvPacientes(0, fila).Value.ToString())

                dgvPacientes.DataSource = CapaDatos.MetodosPacientes.ListarPacientes
                txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCerrarVista_Click(sender As Object, e As EventArgs) Handles btnCerrarVista.Click
        Close()
    End Sub

    Private Sub btnMinimizaar_Click(sender As Object, e As EventArgs) Handles btnMinimizaar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub pnlControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        'Restablece la tabla luego de realizar una busqueda
        txtBuscar.Clear()
        dgvPacientes.DataSource = CapaDatos.MetodosPacientes.ListarPacientes()
        txtCantidadRegistro.Text = dgvPacientes.RowCount - 1
    End Sub
End Class