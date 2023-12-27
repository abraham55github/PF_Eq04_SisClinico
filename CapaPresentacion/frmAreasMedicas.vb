Imports System.Runtime.InteropServices
Public Class frmAreasMedicas
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub frmAreasMedicas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'muestra la tabla Areas medicas y muestra la cantidad de filas
        dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.ListarAreas
        txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1

        TabAreasMedicasAgregar.Parent = Nothing
        tabAreaMedicaEditar.Parent = Nothing
        tabAreasMedicasListar.Parent = TabControlAreaM
    End Sub

    Private Sub lblCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'Busca por medio del nombre del area medica
        If cboAreasMedicas.SelectedItem = "Nombre_Area" Then
            Dim vista As New DataView(CapaDatos.MetodosAreas_Medicas.ListarAreas)
            vista.RowFilter = "nombre_Area LIKE'" & txtBuscar.Text & "%'"
            dgvAreasMedicas.DataSource = vista
            txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            'Busca por el identificador del area
            If cboAreasMedicas.SelectedItem = "Id_Area" And txtBuscar.Text <> "" Then
                dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.BuscarAreas(Convert.ToInt32(txtBuscar.Text))
                txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Muestra la ventana para agregar datos
        tabAreasMedicasListar.Parent = Nothing
        tabAreaMedicaEditar.Parent = Nothing
        TabAreasMedicasAgregar.Parent = TabControlAreaM
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            'Valida e inserta datos a la tabla
            If txtIdArea.Text = Nothing Or txtNomArea.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                CapaEntidades.AreasMedicas.Insertar(txtIdArea.Text, txtNomArea.Text)
                MsgBox("Los datos fueron ingresados correctamente")
                txtIdArea.Clear()
                txtNomArea.Clear()
                TabAreasMedicasAgregar.Parent = Nothing
                tabAreaMedicaEditar.Parent = Nothing
                tabAreasMedicasListar.Parent = TabControlAreaM
                dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.ListarAreas
                txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Muestra la ventana listar tabla
        TabAreasMedicasAgregar.Parent = Nothing
        tabAreaMedicaEditar.Parent = Nothing
        tabAreasMedicasListar.Parent = TabControlAreaM
        txtIdArea.Clear()
        txtNomArea.Clear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim fila As Integer
        Try
            'Muestras los datos de la fila selecionada para editarla
            tabAreasMedicasListar.Parent = Nothing
            tabAreaMedicaEditar.Parent = TabControlAreaM
            fila = dgvAreasMedicas.CurrentCell.RowIndex

            txtIdModificar.Text = dgvAreasMedicas(0, fila).Value.ToString()
            txtNombreModificar.Text = dgvAreasMedicas(1, fila).Value.ToString()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            'Valida y guarda las modificaciones editadas
            If txtIdModificar.Text = Nothing Or txtNombreModificar.Text = Nothing Then
                Throw New Exception("Hay campos vacios")
            Else
                CapaEntidades.AreasMedicas.Editar(txtIdModificar.Text, txtNombreModificar.Text)
                MsgBox("Los datos fueron actualizados correctamente")
                TabAreasMedicasAgregar.Parent = Nothing
                tabAreaMedicaEditar.Parent = Nothing
                tabAreasMedicasListar.Parent = TabControlAreaM
                dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.ListarAreas
                txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim fila As Integer
        Dim borrar As DialogResult

        Try
            'Guarda el id de la fila seleccionada para luego eliminar
            borrar = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If borrar = DialogResult.Yes Then
                fila = dgvAreasMedicas.CurrentCell.RowIndex
                CapaEntidades.AreasMedicas.Eliminar(dgvAreasMedicas(0, fila).Value.ToString())

                dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.ListarAreas
                txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Muestra la ventana listar 
        TabAreasMedicasAgregar.Parent = Nothing
        tabAreaMedicaEditar.Parent = Nothing
        tabAreasMedicasListar.Parent = TabControlAreaM
    End Sub

    Private Sub btnCerrarVista_Click(sender As Object, e As EventArgs) Handles btnCerrarVista.Click
        Close()
    End Sub

    Private Sub btnMinimizaar_Click(sender As Object, e As EventArgs) Handles btnMinimizaar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        'Restablece la tabla luego de realizar una busqueda
        txtBuscar.Clear()
        dgvAreasMedicas.DataSource = CapaDatos.MetodosAreas_Medicas.ListarAreas
        txtCantidadRegistro.Text = dgvAreasMedicas.RowCount - 1
    End Sub

    Private Sub pnlControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class