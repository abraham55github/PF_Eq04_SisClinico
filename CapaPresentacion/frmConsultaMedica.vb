Imports System.Runtime.InteropServices
Public Class frmConsultaMedica
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub limpiar() 'Funcion para limpiar los campos
        txtIdCons.Clear()
        'dtpConsulta.Value = New DateTime(" ")
        txtPadecimiento.Clear()
        cboEstadoConsulta.DataSource = Nothing
        txtTotalConsul.Clear()
        txtIdPac.Clear()
        txtIdMed.Clear()
    End Sub
    Private Sub frmConsultaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Muestra la tabla consultas con su cantidad de filas
        dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
        txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        TabConsultasAgregar.Parent = Nothing
        tabConsultaEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlConsulta
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Realiza busquedas por padecimiento, estado de consulta, Nombre y apellido paciente, nombre y apellido de medicos y nombre de area
        If cboConsulta.SelectedItem = "Padecimiento" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Padecimiento LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Estado Consulta" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Estado_Consulta LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Nombre_Paciente" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Nombre_Paciente LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Apellido_Paciente" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Apellido_Paciente LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Nombre_Medico" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Nombre_Medico LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Apellido_Medico" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "Apellido_Medico LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
        If cboConsulta.SelectedItem = "Nombre_Area" Then
            Dim vista As New DataView(CapaDatos.MetodosConsultaMedicas.ListarConsultas)
            vista.RowFilter = "nombre_Area LIKE'" & txtBuscar.Text & "%'"
            dgvConsultas.DataSource = vista
            txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'Realiza busqueda por las id de los medicos, pacientes y consulta
            If cboConsulta.SelectedItem = "Id Medico" And txtBuscar.Text <> "" Then
                dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.BuscarIdMed(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
            End If
            If cboConsulta.SelectedItem = "Id Paciente" And txtBuscar.Text <> "" Then
                dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.BuscarIdPac(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
            End If
            If cboConsulta.SelectedItem = "Id Consulta" And txtBuscar.Text <> "" Then
                dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.BuscarIdconsulta(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        tabPacienteListar.Parent = Nothing
        tabConsultaEditar.Parent = Nothing
        TabConsultasAgregar.Parent = TabControlConsulta

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Realiza validaciones e ingresa nuevos tados a la tabla
            If txtIdCons.Text = Nothing Or txtPadecimiento.Text = Nothing Or txtTotalConsul.Text = Nothing Or txtIdPac.Text = Nothing Or txtIdMed.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                If cboEstadoConsulta.SelectedItem = "Pendiente" Then
                    CapaEntidades.ConsultaMedica.InsertarCosultas(txtIdCons.Text, dtpConsulta.Value, txtPadecimiento.Text, "Pendiente", txtTotalConsul.Text, txtIdPac.Text, txtIdMed.Text)
                    MsgBox("Los datos fueron ingresados correctamente")
                    limpiar()
                    dgvConsultas.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
                    txtCantidadRegistro.Text = dgvConsultas.RowCount
                    TabConsultasAgregar.Parent = Nothing
                    tabConsultaEditar.Parent = Nothing
                    tabPacienteListar.Parent = TabControlConsulta
                End If
                If cboEstadoConsulta.SelectedItem = "No Pendiente" Then
                    CapaEntidades.ConsultaMedica.InsertarCosultas(txtIdCons.Text, dtpConsulta.Value, txtPadecimiento.Text, "No Pendiente", txtTotalConsul.Text, txtIdPac.Text, txtIdMed.Text)
                    MsgBox("Los datos fueron ingresados correctamente")
                    limpiar()
                    dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
                    txtCantidadRegistro.Text = dgvConsultas.RowCount
                    TabConsultasAgregar.Parent = Nothing
                    tabConsultaEditar.Parent = Nothing
                    tabPacienteListar.Parent = TabControlConsulta
                End If
                If cboEstadoConsulta.SelectedItem = "" Then
                    Throw New Exception("Ingrese el estado de la consulta")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        TabConsultasAgregar.Parent = Nothing
        tabConsultaEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlConsulta
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Ingresa las modificaciones hechas 
            If txtPadecimientoMod.Text = Nothing Or txtTotalMod.Text = Nothing Or txtIdPacMod.Text = Nothing Or txtIdMedMod.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                If cboEstadoConsMod.SelectedItem = "Pendiente" Or cboEstadoConsMod.Text = "Pendiente" Then
                    CapaEntidades.ConsultaMedica.ActualizarCosultas(txtIdModificar.Text, dtpDiaMod.Value, txtPadecimientoMod.Text, "Pendiente ", txtTotalMod.Text, txtIdPacMod.Text, txtIdMedMod.Text)
                    MsgBox("Los datos fueron actualizados correctamente")
                    TabConsultasAgregar.Parent = Nothing
                    tabConsultaEditar.Parent = Nothing
                    tabPacienteListar.Parent = TabControlConsulta
                    dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
                    txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
                End If
                If cboEstadoConsMod.SelectedItem = "No Pendiente" Or cboEstadoConsMod.Text = "No Pendiente" Then
                    CapaEntidades.ConsultaMedica.ActualizarCosultas(txtIdModificar.Text, dtpDiaMod.Value, txtPadecimientoMod.Text, "No Pendiente", txtTotalMod.Text, txtIdPacMod.Text, txtIdMedMod.Text)
                    MsgBox("Los datos fueron actualizados correctamente")
                    TabConsultasAgregar.Parent = Nothing
                    tabConsultaEditar.Parent = Nothing
                    tabPacienteListar.Parent = TabControlConsulta
                    dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
                    txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
                End If
                If cboEstadoConsMod.SelectedItem = "" And cboEstadoConsMod.Text = " " Then
                    Throw New Exception("Ingrese el estado de la consulta")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

        Dim fila As Integer
        Try
            'Guarda los datos de la fila selecionada para luego eliminarlas
            TabConsultasAgregar.Parent = Nothing
            tabPacienteListar.Parent = Nothing
            tabConsultaEditar.Parent = TabControlConsulta
            fila = dgvConsultas.CurrentCell.RowIndex

            txtIdModificar.Text = dgvConsultas(0, fila).Value.ToString()
            dtpDiaMod.Value = dgvConsultas(1, fila).Value.ToString()
            txtPadecimientoMod.Text = dgvConsultas(2, fila).Value.ToString()
            cboEstadoConsMod.Text = dgvConsultas(3, fila).Value.ToString()
            txtTotalMod.Text = dgvConsultas(4, fila).Value.ToString()
            txtIdPacMod.Text = dgvConsultas(5, fila).Value.ToString()
            txtIdMedMod.Text = dgvConsultas(8, fila).Value.ToString()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer
        Dim borrar As DialogResult

        Try
            'Guarda la fila selecionada para eliminarla
            borrar = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If borrar = DialogResult.Yes Then
                fila = dgvConsultas.CurrentCell.RowIndex
                CapaEntidades.ConsultaMedica.Eliminar(dgvConsultas(0, fila).Value.ToString())

                dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
                txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub pnlControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMinimizaar_Click(sender As Object, e As EventArgs) Handles btnMinimizaar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrarVista_Click(sender As Object, e As EventArgs) Handles btnCerrarVista.Click
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TabConsultasAgregar.Parent = Nothing
        tabConsultaEditar.Parent = Nothing
        tabPacienteListar.Parent = TabControlConsulta
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        'Restablece la tabla luego de una busqueda
        txtBuscar.Text = " "
        dgvConsultas.DataSource = CapaDatos.MetodosConsultaMedicas.ListarConsultas
        txtCantidadRegistro.Text = dgvConsultas.RowCount - 1
    End Sub


End Class