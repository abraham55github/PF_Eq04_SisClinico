<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaMedica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaMedica))
        Me.TabControlConsulta = New System.Windows.Forms.TabControl()
        Me.tabPacienteListar = New System.Windows.Forms.TabPage()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtCantidadRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboConsulta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        Me.TabConsultasAgregar = New System.Windows.Forms.TabPage()
        Me.cboEstadoConsulta = New System.Windows.Forms.ComboBox()
        Me.dtpConsulta = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalConsul = New System.Windows.Forms.TextBox()
        Me.txtIdMed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdPac = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPadecimiento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdCons = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabConsultaEditar = New System.Windows.Forms.TabPage()
        Me.cboEstadoConsMod = New System.Windows.Forms.ComboBox()
        Me.dtpDiaMod = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalMod = New System.Windows.Forms.TextBox()
        Me.txtIdMedMod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIdPacMod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPadecimientoMod = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtIdModificar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnCerrarVista = New System.Windows.Forms.Button()
        Me.btnMinimizaar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlConsulta.SuspendLayout()
        Me.tabPacienteListar.SuspendLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsultasAgregar.SuspendLayout()
        Me.tabConsultaEditar.SuspendLayout()
        Me.pnlControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlConsulta
        '
        Me.TabControlConsulta.Controls.Add(Me.tabPacienteListar)
        Me.TabControlConsulta.Controls.Add(Me.TabConsultasAgregar)
        Me.TabControlConsulta.Controls.Add(Me.tabConsultaEditar)
        Me.TabControlConsulta.Location = New System.Drawing.Point(0, 52)
        Me.TabControlConsulta.Name = "TabControlConsulta"
        Me.TabControlConsulta.SelectedIndex = 0
        Me.TabControlConsulta.Size = New System.Drawing.Size(1819, 569)
        Me.TabControlConsulta.TabIndex = 7
        '
        'tabPacienteListar
        '
        Me.tabPacienteListar.Controls.Add(Me.btnRestablecer)
        Me.tabPacienteListar.Controls.Add(Me.txtCantidadRegistro)
        Me.tabPacienteListar.Controls.Add(Me.Label5)
        Me.tabPacienteListar.Controls.Add(Me.btnBuscar)
        Me.tabPacienteListar.Controls.Add(Me.btnEliminar)
        Me.tabPacienteListar.Controls.Add(Me.btnEditar)
        Me.tabPacienteListar.Controls.Add(Me.btnAgregar)
        Me.tabPacienteListar.Controls.Add(Me.txtBuscar)
        Me.tabPacienteListar.Controls.Add(Me.cboConsulta)
        Me.tabPacienteListar.Controls.Add(Me.Label2)
        Me.tabPacienteListar.Controls.Add(Me.dgvConsultas)
        Me.tabPacienteListar.Location = New System.Drawing.Point(4, 29)
        Me.tabPacienteListar.Name = "tabPacienteListar"
        Me.tabPacienteListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPacienteListar.Size = New System.Drawing.Size(1811, 536)
        Me.tabPacienteListar.TabIndex = 0
        Me.tabPacienteListar.Text = "Lista de Consultas Médicas:"
        Me.tabPacienteListar.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestablecer.Location = New System.Drawing.Point(723, 42)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(137, 28)
        Me.btnRestablecer.TabIndex = 13
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        '
        'txtCantidadRegistro
        '
        Me.txtCantidadRegistro.Location = New System.Drawing.Point(1352, 473)
        Me.txtCantidadRegistro.Name = "txtCantidadRegistro"
        Me.txtCantidadRegistro.ReadOnly = True
        Me.txtCantidadRegistro.Size = New System.Drawing.Size(81, 27)
        Me.txtCantidadRegistro.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1171, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Cantidad de Registros:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(580, 43)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(137, 28)
        Me.btnBuscar.TabIndex = 10
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(466, 473)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(137, 40)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(292, 473)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(137, 40)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(120, 473)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(137, 40)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(198, 44)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(376, 27)
        Me.txtBuscar.TabIndex = 6
        '
        'cboConsulta
        '
        Me.cboConsulta.FormattingEnabled = True
        Me.cboConsulta.Items.AddRange(New Object() {"Id Consulta", "Id Paciente", "Id Medico", "Padecimiento", "Estado Consulta", "Nombre_Paciente", "Apellido_Paciente", "Nombre_Medico", "Apellido_Medico", "Nombre_Area"})
        Me.cboConsulta.Location = New System.Drawing.Point(19, 43)
        Me.cboConsulta.Name = "cboConsulta"
        Me.cboConsulta.Size = New System.Drawing.Size(173, 28)
        Me.cboConsulta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar Consulta:"
        '
        'dgvConsultas
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvConsultas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Location = New System.Drawing.Point(3, 81)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.RowHeadersVisible = False
        Me.dgvConsultas.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvConsultas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsultas.RowTemplate.Height = 29
        Me.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultas.Size = New System.Drawing.Size(1808, 371)
        Me.dgvConsultas.TabIndex = 0
        '
        'TabConsultasAgregar
        '
        Me.TabConsultasAgregar.Controls.Add(Me.cboEstadoConsulta)
        Me.TabConsultasAgregar.Controls.Add(Me.dtpConsulta)
        Me.TabConsultasAgregar.Controls.Add(Me.txtTotalConsul)
        Me.TabConsultasAgregar.Controls.Add(Me.txtIdMed)
        Me.TabConsultasAgregar.Controls.Add(Me.Label6)
        Me.TabConsultasAgregar.Controls.Add(Me.txtIdPac)
        Me.TabConsultasAgregar.Controls.Add(Me.Label11)
        Me.TabConsultasAgregar.Controls.Add(Me.Label10)
        Me.TabConsultasAgregar.Controls.Add(Me.Label9)
        Me.TabConsultasAgregar.Controls.Add(Me.txtPadecimiento)
        Me.TabConsultasAgregar.Controls.Add(Me.Label8)
        Me.TabConsultasAgregar.Controls.Add(Me.btnCancelar)
        Me.TabConsultasAgregar.Controls.Add(Me.btnGuardar)
        Me.TabConsultasAgregar.Controls.Add(Me.Label4)
        Me.TabConsultasAgregar.Controls.Add(Me.txtIdCons)
        Me.TabConsultasAgregar.Controls.Add(Me.Label3)
        Me.TabConsultasAgregar.Location = New System.Drawing.Point(4, 29)
        Me.TabConsultasAgregar.Name = "TabConsultasAgregar"
        Me.TabConsultasAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConsultasAgregar.Size = New System.Drawing.Size(1811, 536)
        Me.TabConsultasAgregar.TabIndex = 1
        Me.TabConsultasAgregar.Text = "Agregar Consulta Médica"
        Me.TabConsultasAgregar.UseVisualStyleBackColor = True
        '
        'cboEstadoConsulta
        '
        Me.cboEstadoConsulta.FormattingEnabled = True
        Me.cboEstadoConsulta.Items.AddRange(New Object() {"Pendiente", "No Pendiente"})
        Me.cboEstadoConsulta.Location = New System.Drawing.Point(776, 223)
        Me.cboEstadoConsulta.Name = "cboEstadoConsulta"
        Me.cboEstadoConsulta.Size = New System.Drawing.Size(329, 28)
        Me.cboEstadoConsulta.TabIndex = 24
        '
        'dtpConsulta
        '
        Me.dtpConsulta.Location = New System.Drawing.Point(776, 102)
        Me.dtpConsulta.MaxDate = New Date(9998, 12, 30, 0, 0, 0, 0)
        Me.dtpConsulta.Name = "dtpConsulta"
        Me.dtpConsulta.Size = New System.Drawing.Size(329, 27)
        Me.dtpConsulta.TabIndex = 23
        Me.dtpConsulta.Value = New Date(2022, 3, 7, 0, 0, 0, 0)
        '
        'txtTotalConsul
        '
        Me.txtTotalConsul.Location = New System.Drawing.Point(776, 290)
        Me.txtTotalConsul.Name = "txtTotalConsul"
        Me.txtTotalConsul.Size = New System.Drawing.Size(329, 27)
        Me.txtTotalConsul.TabIndex = 22
        '
        'txtIdMed
        '
        Me.txtIdMed.Location = New System.Drawing.Point(776, 429)
        Me.txtIdMed.Name = "txtIdMed"
        Me.txtIdMed.Size = New System.Drawing.Size(329, 27)
        Me.txtIdMed.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(776, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 22)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Id Medico:"
        '
        'txtIdPac
        '
        Me.txtIdPac.Location = New System.Drawing.Point(776, 359)
        Me.txtIdPac.Name = "txtIdPac"
        Me.txtIdPac.Size = New System.Drawing.Size(329, 27)
        Me.txtIdPac.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(776, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(302, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Id Paciente:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(776, 265)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Total:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(776, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(302, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Estado de Consulta:"
        '
        'txtPadecimiento
        '
        Me.txtPadecimiento.Location = New System.Drawing.Point(776, 162)
        Me.txtPadecimiento.Name = "txtPadecimiento"
        Me.txtPadecimiento.Size = New System.Drawing.Size(329, 27)
        Me.txtPadecimiento.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(776, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Padecimiento:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(985, 474)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(137, 40)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(762, 474)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(776, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de Consulta Médica:"
        '
        'txtIdCons
        '
        Me.txtIdCons.Location = New System.Drawing.Point(776, 39)
        Me.txtIdCons.Name = "txtIdCons"
        Me.txtIdCons.Size = New System.Drawing.Size(329, 27)
        Me.txtIdCons.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(776, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Consulta:"
        '
        'tabConsultaEditar
        '
        Me.tabConsultaEditar.Controls.Add(Me.cboEstadoConsMod)
        Me.tabConsultaEditar.Controls.Add(Me.dtpDiaMod)
        Me.tabConsultaEditar.Controls.Add(Me.txtTotalMod)
        Me.tabConsultaEditar.Controls.Add(Me.txtIdMedMod)
        Me.tabConsultaEditar.Controls.Add(Me.Label12)
        Me.tabConsultaEditar.Controls.Add(Me.txtIdPacMod)
        Me.tabConsultaEditar.Controls.Add(Me.Label13)
        Me.tabConsultaEditar.Controls.Add(Me.Label14)
        Me.tabConsultaEditar.Controls.Add(Me.Label15)
        Me.tabConsultaEditar.Controls.Add(Me.txtPadecimientoMod)
        Me.tabConsultaEditar.Controls.Add(Me.Label16)
        Me.tabConsultaEditar.Controls.Add(Me.Label17)
        Me.tabConsultaEditar.Controls.Add(Me.btnCancel)
        Me.tabConsultaEditar.Controls.Add(Me.btnModificar)
        Me.tabConsultaEditar.Controls.Add(Me.txtIdModificar)
        Me.tabConsultaEditar.Controls.Add(Me.Label7)
        Me.tabConsultaEditar.Location = New System.Drawing.Point(4, 29)
        Me.tabConsultaEditar.Name = "tabConsultaEditar"
        Me.tabConsultaEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConsultaEditar.Size = New System.Drawing.Size(1811, 536)
        Me.tabConsultaEditar.TabIndex = 2
        Me.tabConsultaEditar.Text = "Modificar Consulta Médica"
        Me.tabConsultaEditar.UseVisualStyleBackColor = True
        '
        'cboEstadoConsMod
        '
        Me.cboEstadoConsMod.FormattingEnabled = True
        Me.cboEstadoConsMod.Items.AddRange(New Object() {"Pendiente", "No Pendiente"})
        Me.cboEstadoConsMod.Location = New System.Drawing.Point(713, 225)
        Me.cboEstadoConsMod.Name = "cboEstadoConsMod"
        Me.cboEstadoConsMod.Size = New System.Drawing.Size(329, 28)
        Me.cboEstadoConsMod.TabIndex = 36
        '
        'dtpDiaMod
        '
        Me.dtpDiaMod.Location = New System.Drawing.Point(713, 104)
        Me.dtpDiaMod.MaxDate = New Date(9998, 12, 30, 0, 0, 0, 0)
        Me.dtpDiaMod.Name = "dtpDiaMod"
        Me.dtpDiaMod.Size = New System.Drawing.Size(329, 27)
        Me.dtpDiaMod.TabIndex = 35
        Me.dtpDiaMod.Value = New Date(2022, 3, 7, 0, 0, 0, 0)
        '
        'txtTotalMod
        '
        Me.txtTotalMod.Location = New System.Drawing.Point(713, 292)
        Me.txtTotalMod.Name = "txtTotalMod"
        Me.txtTotalMod.Size = New System.Drawing.Size(329, 27)
        Me.txtTotalMod.TabIndex = 34
        '
        'txtIdMedMod
        '
        Me.txtIdMedMod.Location = New System.Drawing.Point(713, 431)
        Me.txtIdMedMod.Name = "txtIdMedMod"
        Me.txtIdMedMod.Size = New System.Drawing.Size(329, 27)
        Me.txtIdMedMod.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(713, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(302, 22)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Id Medico:"
        '
        'txtIdPacMod
        '
        Me.txtIdPacMod.Location = New System.Drawing.Point(713, 361)
        Me.txtIdPacMod.Name = "txtIdPacMod"
        Me.txtIdPacMod.Size = New System.Drawing.Size(329, 27)
        Me.txtIdPacMod.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(713, 336)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 22)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Id Paciente:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(713, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(302, 22)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Total:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(713, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(302, 22)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Estado de Consulta:"
        '
        'txtPadecimientoMod
        '
        Me.txtPadecimientoMod.Location = New System.Drawing.Point(713, 164)
        Me.txtPadecimientoMod.Name = "txtPadecimientoMod"
        Me.txtPadecimientoMod.Size = New System.Drawing.Size(329, 27)
        Me.txtPadecimientoMod.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(713, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(302, 22)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Padecimiento:"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(713, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(302, 22)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = "Fecha de Consulta Médica:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(905, 477)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(137, 40)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(713, 477)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 40)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Guardar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtIdModificar
        '
        Me.txtIdModificar.Location = New System.Drawing.Point(713, 40)
        Me.txtIdModificar.Name = "txtIdModificar"
        Me.txtIdModificar.ReadOnly = True
        Me.txtIdModificar.Size = New System.Drawing.Size(329, 27)
        Me.txtIdModificar.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(713, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Id Consulta:"
        '
        'pnlControl
        '
        Me.pnlControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlControl.Controls.Add(Me.btnCerrarVista)
        Me.pnlControl.Controls.Add(Me.btnMinimizaar)
        Me.pnlControl.Controls.Add(Me.Label1)
        Me.pnlControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlControl.Name = "pnlControl"
        Me.pnlControl.Size = New System.Drawing.Size(1819, 52)
        Me.pnlControl.TabIndex = 8
        '
        'btnCerrarVista
        '
        Me.btnCerrarVista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarVista.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCerrarVista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarVista.FlatAppearance.BorderSize = 0
        Me.btnCerrarVista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCerrarVista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarVista.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrarVista.Image = CType(resources.GetObject("btnCerrarVista.Image"), System.Drawing.Image)
        Me.btnCerrarVista.Location = New System.Drawing.Point(1779, -2)
        Me.btnCerrarVista.Name = "btnCerrarVista"
        Me.btnCerrarVista.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarVista.TabIndex = 9
        Me.btnCerrarVista.UseVisualStyleBackColor = False
        '
        'btnMinimizaar
        '
        Me.btnMinimizaar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizaar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMinimizaar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizaar.FlatAppearance.BorderSize = 0
        Me.btnMinimizaar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizaar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizaar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinimizaar.Image = CType(resources.GetObject("btnMinimizaar.Image"), System.Drawing.Image)
        Me.btnMinimizaar.Location = New System.Drawing.Point(1733, 0)
        Me.btnMinimizaar.Name = "btnMinimizaar"
        Me.btnMinimizaar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizaar.TabIndex = 6
        Me.btnMinimizaar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consultas Medicas"
        '
        'frmConsultaMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1819, 621)
        Me.Controls.Add(Me.pnlControl)
        Me.Controls.Add(Me.TabControlConsulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConsultaMedica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaMedica"
        Me.TabControlConsulta.ResumeLayout(False)
        Me.tabPacienteListar.ResumeLayout(False)
        Me.tabPacienteListar.PerformLayout()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsultasAgregar.ResumeLayout(False)
        Me.TabConsultasAgregar.PerformLayout()
        Me.tabConsultaEditar.ResumeLayout(False)
        Me.tabConsultaEditar.PerformLayout()
        Me.pnlControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlConsulta As TabControl
    Friend WithEvents tabPacienteListar As TabPage
    Friend WithEvents txtCantidadRegistro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboConsulta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvConsultas As DataGridView
    Friend WithEvents TabConsultasAgregar As TabPage
    Friend WithEvents dtpConsulta As DateTimePicker
    Friend WithEvents txtTotalConsul As TextBox
    Friend WithEvents txtIdMed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdPac As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPadecimiento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdCons As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tabConsultaEditar As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtIdModificar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboEstadoConsulta As ComboBox
    Friend WithEvents cboEstadoConsMod As ComboBox
    Friend WithEvents dtpDiaMod As DateTimePicker
    Friend WithEvents txtTotalMod As TextBox
    Friend WithEvents txtIdMedMod As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtIdPacMod As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPadecimientoMod As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents pnlControl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnMinimizaar As Button
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents btnCerrarVista As Button
End Class
