<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPacientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnCerrarVista = New System.Windows.Forms.Button()
        Me.btnMinimizaar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControlPaciente = New System.Windows.Forms.TabControl()
        Me.tabPacienteListar = New System.Windows.Forms.TabPage()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtCantidadRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboPacientes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.TabPacientesAgregar = New System.Windows.Forms.TabPage()
        Me.mtxtTelefonoPac = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccionPac = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCedulaPac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApellidoPac = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNomPaciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdPac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabPacienteEditar = New System.Windows.Forms.TabPage()
        Me.mtxtTelefonoMod = New System.Windows.Forms.MaskedTextBox()
        Me.txtDireccionMod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCedulaMod = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtApellidoMod = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNombreMod = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtIdModificar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlControl.SuspendLayout()
        Me.TabControlPaciente.SuspendLayout()
        Me.tabPacienteListar.SuspendLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPacientesAgregar.SuspendLayout()
        Me.tabPacienteEditar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlControl.Size = New System.Drawing.Size(1092, 52)
        Me.pnlControl.TabIndex = 5
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
        Me.btnCerrarVista.Location = New System.Drawing.Point(1052, 0)
        Me.btnCerrarVista.Name = "btnCerrarVista"
        Me.btnCerrarVista.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarVista.TabIndex = 11
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
        Me.btnMinimizaar.Location = New System.Drawing.Point(1006, 2)
        Me.btnMinimizaar.Name = "btnMinimizaar"
        Me.btnMinimizaar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizaar.TabIndex = 10
        Me.btnMinimizaar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pacientes"
        '
        'TabControlPaciente
        '
        Me.TabControlPaciente.Controls.Add(Me.tabPacienteListar)
        Me.TabControlPaciente.Controls.Add(Me.TabPacientesAgregar)
        Me.TabControlPaciente.Controls.Add(Me.tabPacienteEditar)
        Me.TabControlPaciente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPaciente.Location = New System.Drawing.Point(0, 52)
        Me.TabControlPaciente.Name = "TabControlPaciente"
        Me.TabControlPaciente.SelectedIndex = 0
        Me.TabControlPaciente.Size = New System.Drawing.Size(1092, 569)
        Me.TabControlPaciente.TabIndex = 5
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
        Me.tabPacienteListar.Controls.Add(Me.cboPacientes)
        Me.tabPacienteListar.Controls.Add(Me.Label2)
        Me.tabPacienteListar.Controls.Add(Me.dgvPacientes)
        Me.tabPacienteListar.Location = New System.Drawing.Point(4, 29)
        Me.tabPacienteListar.Name = "tabPacienteListar"
        Me.tabPacienteListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPacienteListar.Size = New System.Drawing.Size(1084, 536)
        Me.tabPacienteListar.TabIndex = 0
        Me.tabPacienteListar.Text = "Lista de Pacientes:"
        Me.tabPacienteListar.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestablecer.Location = New System.Drawing.Point(723, 43)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(137, 28)
        Me.btnRestablecer.TabIndex = 14
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        '
        'txtCantidadRegistro
        '
        Me.txtCantidadRegistro.Location = New System.Drawing.Point(852, 470)
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
        Me.Label5.Location = New System.Drawing.Point(671, 473)
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
        'cboPacientes
        '
        Me.cboPacientes.FormattingEnabled = True
        Me.cboPacientes.Items.AddRange(New Object() {"Id_Paciente", "Nombre", "Apellido", "Cedula"})
        Me.cboPacientes.Location = New System.Drawing.Point(19, 43)
        Me.cboPacientes.Name = "cboPacientes"
        Me.cboPacientes.Size = New System.Drawing.Size(173, 28)
        Me.cboPacientes.TabIndex = 5
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
        Me.Label2.Text = "Buscar Paciente:"
        '
        'dgvPacientes
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvPacientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(3, 81)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.RowHeadersVisible = False
        Me.dgvPacientes.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPacientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPacientes.RowTemplate.Height = 29
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(1073, 371)
        Me.dgvPacientes.TabIndex = 0
        '
        'TabPacientesAgregar
        '
        Me.TabPacientesAgregar.Controls.Add(Me.mtxtTelefonoPac)
        Me.TabPacientesAgregar.Controls.Add(Me.txtDireccionPac)
        Me.TabPacientesAgregar.Controls.Add(Me.Label11)
        Me.TabPacientesAgregar.Controls.Add(Me.Label10)
        Me.TabPacientesAgregar.Controls.Add(Me.txtCedulaPac)
        Me.TabPacientesAgregar.Controls.Add(Me.Label9)
        Me.TabPacientesAgregar.Controls.Add(Me.txtApellidoPac)
        Me.TabPacientesAgregar.Controls.Add(Me.Label8)
        Me.TabPacientesAgregar.Controls.Add(Me.btnCancelar)
        Me.TabPacientesAgregar.Controls.Add(Me.btnGuardar)
        Me.TabPacientesAgregar.Controls.Add(Me.txtNomPaciente)
        Me.TabPacientesAgregar.Controls.Add(Me.Label4)
        Me.TabPacientesAgregar.Controls.Add(Me.txtIdPac)
        Me.TabPacientesAgregar.Controls.Add(Me.Label3)
        Me.TabPacientesAgregar.Location = New System.Drawing.Point(4, 29)
        Me.TabPacientesAgregar.Name = "TabPacientesAgregar"
        Me.TabPacientesAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPacientesAgregar.Size = New System.Drawing.Size(1084, 536)
        Me.TabPacientesAgregar.TabIndex = 1
        Me.TabPacientesAgregar.Text = "Agregar Paciente"
        Me.TabPacientesAgregar.UseVisualStyleBackColor = True
        '
        'mtxtTelefonoPac
        '
        Me.mtxtTelefonoPac.Location = New System.Drawing.Point(379, 316)
        Me.mtxtTelefonoPac.Mask = "0000-0000"
        Me.mtxtTelefonoPac.Name = "mtxtTelefonoPac"
        Me.mtxtTelefonoPac.Size = New System.Drawing.Size(329, 27)
        Me.mtxtTelefonoPac.TabIndex = 19
        '
        'txtDireccionPac
        '
        Me.txtDireccionPac.Location = New System.Drawing.Point(379, 388)
        Me.txtDireccionPac.Name = "txtDireccionPac"
        Me.txtDireccionPac.Size = New System.Drawing.Size(329, 27)
        Me.txtDireccionPac.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(379, 363)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(302, 22)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Direccion"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(379, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(302, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Telefono:"
        '
        'txtCedulaPac
        '
        Me.txtCedulaPac.Location = New System.Drawing.Point(379, 249)
        Me.txtCedulaPac.Name = "txtCedulaPac"
        Me.txtCedulaPac.Size = New System.Drawing.Size(329, 27)
        Me.txtCedulaPac.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(379, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(302, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cedula:"
        '
        'txtApellidoPac
        '
        Me.txtApellidoPac.Location = New System.Drawing.Point(379, 188)
        Me.txtApellidoPac.Name = "txtApellidoPac"
        Me.txtApellidoPac.Size = New System.Drawing.Size(329, 27)
        Me.txtApellidoPac.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(379, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(302, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Apellido"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(585, 454)
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
        Me.btnGuardar.Location = New System.Drawing.Point(362, 454)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtNomPaciente
        '
        Me.txtNomPaciente.Location = New System.Drawing.Point(379, 128)
        Me.txtNomPaciente.Name = "txtNomPaciente"
        Me.txtNomPaciente.Size = New System.Drawing.Size(329, 27)
        Me.txtNomPaciente.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(379, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(302, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'txtIdPac
        '
        Me.txtIdPac.Location = New System.Drawing.Point(379, 65)
        Me.txtIdPac.Name = "txtIdPac"
        Me.txtIdPac.Size = New System.Drawing.Size(329, 27)
        Me.txtIdPac.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(379, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Paciente:"
        '
        'tabPacienteEditar
        '
        Me.tabPacienteEditar.Controls.Add(Me.mtxtTelefonoMod)
        Me.tabPacienteEditar.Controls.Add(Me.txtDireccionMod)
        Me.tabPacienteEditar.Controls.Add(Me.Label12)
        Me.tabPacienteEditar.Controls.Add(Me.Label13)
        Me.tabPacienteEditar.Controls.Add(Me.txtCedulaMod)
        Me.tabPacienteEditar.Controls.Add(Me.Label14)
        Me.tabPacienteEditar.Controls.Add(Me.txtApellidoMod)
        Me.tabPacienteEditar.Controls.Add(Me.Label15)
        Me.tabPacienteEditar.Controls.Add(Me.txtNombreMod)
        Me.tabPacienteEditar.Controls.Add(Me.Label16)
        Me.tabPacienteEditar.Controls.Add(Me.btnCancel)
        Me.tabPacienteEditar.Controls.Add(Me.btnModificar)
        Me.tabPacienteEditar.Controls.Add(Me.txtIdModificar)
        Me.tabPacienteEditar.Controls.Add(Me.Label7)
        Me.tabPacienteEditar.Location = New System.Drawing.Point(4, 29)
        Me.tabPacienteEditar.Name = "tabPacienteEditar"
        Me.tabPacienteEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPacienteEditar.Size = New System.Drawing.Size(1084, 536)
        Me.tabPacienteEditar.TabIndex = 2
        Me.tabPacienteEditar.Text = "Modificar Paciente"
        Me.tabPacienteEditar.UseVisualStyleBackColor = True
        '
        'mtxtTelefonoMod
        '
        Me.mtxtTelefonoMod.Location = New System.Drawing.Point(392, 320)
        Me.mtxtTelefonoMod.Mask = "0000-0000"
        Me.mtxtTelefonoMod.Name = "mtxtTelefonoMod"
        Me.mtxtTelefonoMod.Size = New System.Drawing.Size(329, 27)
        Me.mtxtTelefonoMod.TabIndex = 29
        '
        'txtDireccionMod
        '
        Me.txtDireccionMod.Location = New System.Drawing.Point(392, 392)
        Me.txtDireccionMod.Name = "txtDireccionMod"
        Me.txtDireccionMod.Size = New System.Drawing.Size(329, 27)
        Me.txtDireccionMod.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(392, 367)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(302, 22)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Direccion"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(392, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(302, 22)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Telefono:"
        '
        'txtCedulaMod
        '
        Me.txtCedulaMod.Location = New System.Drawing.Point(392, 253)
        Me.txtCedulaMod.Name = "txtCedulaMod"
        Me.txtCedulaMod.Size = New System.Drawing.Size(329, 27)
        Me.txtCedulaMod.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(392, 228)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(302, 22)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Cedula:"
        '
        'txtApellidoMod
        '
        Me.txtApellidoMod.Location = New System.Drawing.Point(392, 192)
        Me.txtApellidoMod.Name = "txtApellidoMod"
        Me.txtApellidoMod.Size = New System.Drawing.Size(329, 27)
        Me.txtApellidoMod.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(392, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(302, 22)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Apellido"
        '
        'txtNombreMod
        '
        Me.txtNombreMod.Location = New System.Drawing.Point(392, 132)
        Me.txtNombreMod.Name = "txtNombreMod"
        Me.txtNombreMod.Size = New System.Drawing.Size(329, 27)
        Me.txtNombreMod.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(392, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(302, 22)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Nombre:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(582, 453)
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
        Me.btnModificar.Location = New System.Drawing.Point(401, 453)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 40)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Guardar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtIdModificar
        '
        Me.txtIdModificar.Location = New System.Drawing.Point(392, 77)
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
        Me.Label7.Location = New System.Drawing.Point(392, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Id Paciente:"
        '
        'frmPacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 621)
        Me.Controls.Add(Me.TabControlPaciente)
        Me.Controls.Add(Me.pnlControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPacientes"
        Me.pnlControl.ResumeLayout(False)
        Me.TabControlPaciente.ResumeLayout(False)
        Me.tabPacienteListar.ResumeLayout(False)
        Me.tabPacienteListar.PerformLayout()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPacientesAgregar.ResumeLayout(False)
        Me.TabPacientesAgregar.PerformLayout()
        Me.tabPacienteEditar.ResumeLayout(False)
        Me.tabPacienteEditar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlControl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControlPaciente As TabControl
    Friend WithEvents tabPacienteListar As TabPage
    Friend WithEvents txtCantidadRegistro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboPacientes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents TabPacientesAgregar As TabPage
    Friend WithEvents mtxtTelefonoPac As MaskedTextBox
    Friend WithEvents txtDireccionPac As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCedulaPac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApellidoPac As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNomPaciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdPac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tabPacienteEditar As TabPage
    Friend WithEvents mtxtTelefonoMod As MaskedTextBox
    Friend WithEvents txtDireccionMod As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCedulaMod As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtApellidoMod As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNombreMod As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtIdModificar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCerrarVista As Button
    Friend WithEvents btnMinimizaar As Button
    Friend WithEvents btnRestablecer As Button
End Class
