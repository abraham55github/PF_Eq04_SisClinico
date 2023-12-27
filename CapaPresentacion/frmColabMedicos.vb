Imports System.Runtime.InteropServices
Public Class frmColabMedicos
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub limpiar() 'Limpia los textbox
        txtIdMedico.Clear()
        txtNomMed.Clear()
        txtApeMed.Clear()
        txtAreaMed.Clear()
        mtxtTelefonoMed.Clear()
    End Sub
    Private Sub frmColabMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'muestra la tabla medicos con la cantidad ingresados
        dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
        txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
        tabColabMedicoAgregar.Parent = Nothing
        tabColabMedicoEditar.Parent = Nothing
        tabColabMedicoListar.Parent = tabControlColabMedico
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Realiza busqueda por medio del nombre y apellido del medico e nombre del area que trabaja
        If cboColabMedico.SelectedItem = "Nombre_Area" Then
            Dim vista As New DataView(CapaDatos.MetodoColabMedico.ListarColabMedicos)
            vista.RowFilter = "nombre_Area LIKE'" & txtBuscar.Text & "%'"
            dgvColabMedicos.DataSource = vista
            txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
        End If
        If cboColabMedico.SelectedItem = "Nombre_Medico" Then
            Dim vista As New DataView(CapaDatos.MetodoColabMedico.ListarColabMedicos)
            vista.RowFilter = "Nombre_Medico LIKE'" & txtBuscar.Text & "%'"
            dgvColabMedicos.DataSource = vista
            txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
        End If
        If cboColabMedico.SelectedItem = "Apellido_Medico" Then
            Dim vista As New DataView(CapaDatos.MetodoColabMedico.ListarColabMedicos)
            vista.RowFilter = "Apellido_Medico LIKE'" & txtBuscar.Text & "%'"
            dgvColabMedicos.DataSource = vista
            txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'Realiza busqueda para el id de medico y area
            If cboColabMedico.SelectedItem = "Id_Medico" And txtBuscar.Text <> "" Then
                dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.BuscarIdmedico(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
            End If
            If cboColabMedico.SelectedItem = "Id_Area" And txtBuscar.Text <> "" Then
                dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.BuscarIdAreaM(txtBuscar.Text)
                txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Realiza validaciones y luego inserta los datos en la tabla
            If txtIdMedico.Text = Nothing Or txtNomMed.Text = Nothing Or txtApeMed.Text = Nothing Or mtxtTelefonoMed.Text = Nothing Or txtAreaMed.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                CapaEntidades.ColabMedicos.Insertar(txtIdMedico.Text, txtNomMed.Text, txtApeMed.Text, mtxtTelefonoMed.Text, txtAreaMed.Text)
                MsgBox("Los datos fueron ingresados correctamente")
                limpiar()

                dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
                txtCantidadRegistro.Text = dgvColabMedicos.RowCount
                tabColabMedicoAgregar.Parent = Nothing
                tabColabMedicoEditar.Parent = Nothing
                tabColabMedicoListar.Parent = tabControlColabMedico
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        tabColabMedicoAgregar.Parent = Nothing
        tabColabMedicoEditar.Parent = Nothing
        tabColabMedicoListar.Parent = tabControlColabMedico
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        tabColabMedicoListar.Parent = Nothing
        tabColabMedicoEditar.Parent = Nothing
        tabColabMedicoAgregar.Parent = tabControlColabMedico
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim fila As Integer
        Try
            'Guarda los datos de la fila seleccionada para luego ir a la ventana editar
            tabColabMedicoListar.Parent = Nothing
            tabColabMedicoAgregar.Parent = Nothing
            tabColabMedicoEditar.Parent = tabControlColabMedico
            fila = dgvColabMedicos.CurrentCell.RowIndex

            txtIdModificar.Text = dgvColabMedicos(0, fila).Value.ToString()
            txtNombreModificar.Text = dgvColabMedicos(1, fila).Value.ToString()
            txtApeMod.Text = dgvColabMedicos(2, fila).Value.ToString()
            mtxtTelefonoMod.Text = dgvColabMedicos(3, fila).Value.ToString()
            txtIdAreaMod.Text = dgvColabMedicos(4, fila).Value.ToString()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Guarda las modificaciones hechas al registro
            If txtNombreModificar.Text = Nothing Or txtApeMod.Text = Nothing Or mtxtTelefonoMod.Text = Nothing Or txtIdAreaMod.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                CapaEntidades.ColabMedicos.editar(txtIdModificar.Text, txtNombreModificar.Text, txtApeMod.Text, mtxtTelefonoMod.Text, txtIdAreaMod.Text)
                MsgBox("Los datos fueron actualizados correctamente")
                dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
                txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
                tabColabMedicoAgregar.Parent = Nothing
                tabColabMedicoEditar.Parent = Nothing
                tabColabMedicoListar.Parent = tabControlColabMedico

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer
        Dim borrar As DialogResult

        Try
            'Guarda el id de medico para luego eliminarlo
            borrar = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If borrar = DialogResult.Yes Then
                fila = dgvColabMedicos.CurrentCell.RowIndex
                CapaEntidades.ColabMedicos.Eliminar(dgvColabMedicos(0, fila).Value.ToString())

                dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
                txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tabColabMedicoAgregar.Parent = Nothing
        tabColabMedicoEditar.Parent = Nothing
        tabColabMedicoListar.Parent = tabControlColabMedico
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        'Restablece la tabla luego de realizar busquedas
        txtBuscar.Clear()
        dgvColabMedicos.DataSource = CapaDatos.MetodoColabMedico.ListarColabMedicos
        txtCantidadRegistro.Text = dgvColabMedicos.RowCount - 1
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
End Class