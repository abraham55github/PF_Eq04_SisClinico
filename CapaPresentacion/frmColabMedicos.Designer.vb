<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmColabMedicos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColabMedicos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnCerrarVista = New System.Windows.Forms.Button()
        Me.btnMinimizaar = New System.Windows.Forms.Button()
        Me.tabControlColabMedico = New System.Windows.Forms.TabControl()
        Me.tabColabMedicoListar = New System.Windows.Forms.TabPage()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtCantidadRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.cboColabMedico = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvColabMedicos = New System.Windows.Forms.DataGridView()
        Me.tabColabMedicoAgregar = New System.Windows.Forms.TabPage()
        Me.mtxtTelefonoMed = New System.Windows.Forms.MaskedTextBox()
        Me.txtAreaMed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtApeMed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNomMed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdMedico = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabColabMedicoEditar = New System.Windows.Forms.TabPage()
        Me.mtxtTelefonoMod = New System.Windows.Forms.MaskedTextBox()
        Me.txtIdAreaMod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApeMod = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtNombreModificar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdModificar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlControl.SuspendLayout()
        Me.tabControlColabMedico.SuspendLayout()
        Me.tabColabMedicoListar.SuspendLayout()
        CType(Me.dgvColabMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabColabMedicoAgregar.SuspendLayout()
        Me.tabColabMedicoEditar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Colaborador Médico"
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
        Me.pnlControl.Size = New System.Drawing.Size(1123, 52)
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
        Me.btnCerrarVista.Location = New System.Drawing.Point(1083, 0)
        Me.btnCerrarVista.Name = "btnCerrarVista"
        Me.btnCerrarVista.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarVista.TabIndex = 13
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
        Me.btnMinimizaar.Location = New System.Drawing.Point(1037, 2)
        Me.btnMinimizaar.Name = "btnMinimizaar"
        Me.btnMinimizaar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizaar.TabIndex = 12
        Me.btnMinimizaar.UseVisualStyleBackColor = False
        '
        'tabControlColabMedico
        '
        Me.tabControlColabMedico.Controls.Add(Me.tabColabMedicoListar)
        Me.tabControlColabMedico.Controls.Add(Me.tabColabMedicoAgregar)
        Me.tabControlColabMedico.Controls.Add(Me.tabColabMedicoEditar)
        Me.tabControlColabMedico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlColabMedico.Location = New System.Drawing.Point(0, 52)
        Me.tabControlColabMedico.Name = "tabControlColabMedico"
        Me.tabControlColabMedico.SelectedIndex = 0
        Me.tabControlColabMedico.Size = New System.Drawing.Size(1123, 548)
        Me.tabControlColabMedico.TabIndex = 6
        '
        'tabColabMedicoListar
        '
        Me.tabColabMedicoListar.Controls.Add(Me.btnRestablecer)
        Me.tabColabMedicoListar.Controls.Add(Me.txtCantidadRegistro)
        Me.tabColabMedicoListar.Controls.Add(Me.Label5)
        Me.tabColabMedicoListar.Controls.Add(Me.btnBuscar)
        Me.tabColabMedicoListar.Controls.Add(Me.btnEliminar)
        Me.tabColabMedicoListar.Controls.Add(Me.btnEditar)
        Me.tabColabMedicoListar.Controls.Add(Me.btnAgregar)
        Me.tabColabMedicoListar.Controls.Add(Me.txtBuscar)
        Me.tabColabMedicoListar.Controls.Add(Me.cboColabMedico)
        Me.tabColabMedicoListar.Controls.Add(Me.Label2)
        Me.tabColabMedicoListar.Controls.Add(Me.dgvColabMedicos)
        Me.tabColabMedicoListar.Location = New System.Drawing.Point(4, 29)
        Me.tabColabMedicoListar.Name = "tabColabMedicoListar"
        Me.tabColabMedicoListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColabMedicoListar.Size = New System.Drawing.Size(1115, 515)
        Me.tabColabMedicoListar.TabIndex = 0
        Me.tabColabMedicoListar.Text = "Lista de Colaboradores Médicos"
        Me.tabColabMedicoListar.UseVisualStyleBackColor = True
        '
        'btnRestablecer
        '
        Me.btnRestablecer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestablecer.Location = New System.Drawing.Point(723, 43)
        Me.btnRestablecer.Name = "btnRestablecer"
        Me.btnRestablecer.Size = New System.Drawing.Size(137, 28)
        Me.btnRestablecer.TabIndex = 15
        Me.btnRestablecer.Text = "Restablecer"
        Me.btnRestablecer.UseVisualStyleBackColor = False
        '
        'txtCantidadRegistro
        '
        Me.txtCantidadRegistro.Location = New System.Drawing.Point(682, 445)
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
        Me.Label5.Location = New System.Drawing.Point(501, 448)
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
        Me.btnEliminar.Location = New System.Drawing.Point(945, 203)
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
        Me.btnEditar.Location = New System.Drawing.Point(945, 143)
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
        Me.btnAgregar.Location = New System.Drawing.Point(945, 77)
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
        'cboColabMedico
        '
        Me.cboColabMedico.FormattingEnabled = True
        Me.cboColabMedico.Items.AddRange(New Object() {"Id_Medico", "Id_Area", "Nombre_Medico", "Apellido_Medico", "Nombre_Area"})
        Me.cboColabMedico.Location = New System.Drawing.Point(19, 43)
        Me.cboColabMedico.Name = "cboColabMedico"
        Me.cboColabMedico.Size = New System.Drawing.Size(173, 28)
        Me.cboColabMedico.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Buscar Colaborador Médico:"
        '
        'dgvColabMedicos
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvColabMedicos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvColabMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvColabMedicos.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvColabMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvColabMedicos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColabMedicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvColabMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColabMedicos.Location = New System.Drawing.Point(20, 77)
        Me.dgvColabMedicos.Name = "dgvColabMedicos"
        Me.dgvColabMedicos.RowHeadersVisible = False
        Me.dgvColabMedicos.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvColabMedicos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvColabMedicos.RowTemplate.Height = 29
        Me.dgvColabMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvColabMedicos.Size = New System.Drawing.Size(919, 358)
        Me.dgvColabMedicos.TabIndex = 0
        '
        'tabColabMedicoAgregar
        '
        Me.tabColabMedicoAgregar.Controls.Add(Me.mtxtTelefonoMed)
        Me.tabColabMedicoAgregar.Controls.Add(Me.txtAreaMed)
        Me.tabColabMedicoAgregar.Controls.Add(Me.Label10)
        Me.tabColabMedicoAgregar.Controls.Add(Me.Label9)
        Me.tabColabMedicoAgregar.Controls.Add(Me.txtApeMed)
        Me.tabColabMedicoAgregar.Controls.Add(Me.Label8)
        Me.tabColabMedicoAgregar.Controls.Add(Me.btnCancelar)
        Me.tabColabMedicoAgregar.Controls.Add(Me.btnGuardar)
        Me.tabColabMedicoAgregar.Controls.Add(Me.txtNomMed)
        Me.tabColabMedicoAgregar.Controls.Add(Me.Label4)
        Me.tabColabMedicoAgregar.Controls.Add(Me.txtIdMedico)
        Me.tabColabMedicoAgregar.Controls.Add(Me.Label3)
        Me.tabColabMedicoAgregar.Location = New System.Drawing.Point(4, 29)
        Me.tabColabMedicoAgregar.Name = "tabColabMedicoAgregar"
        Me.tabColabMedicoAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColabMedicoAgregar.Size = New System.Drawing.Size(1115, 583)
        Me.tabColabMedicoAgregar.TabIndex = 1
        Me.tabColabMedicoAgregar.Text = "Agregar Colaborador Médico"
        Me.tabColabMedicoAgregar.UseVisualStyleBackColor = True
        '
        'mtxtTelefonoMed
        '
        Me.mtxtTelefonoMed.Location = New System.Drawing.Point(362, 254)
        Me.mtxtTelefonoMed.Mask = "0000-0000"
        Me.mtxtTelefonoMed.Name = "mtxtTelefonoMed"
        Me.mtxtTelefonoMed.Size = New System.Drawing.Size(238, 27)
        Me.mtxtTelefonoMed.TabIndex = 20
        '
        'txtAreaMed
        '
        Me.txtAreaMed.Location = New System.Drawing.Point(362, 325)
        Me.txtAreaMed.Name = "txtAreaMed"
        Me.txtAreaMed.Size = New System.Drawing.Size(238, 27)
        Me.txtAreaMed.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(362, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(211, 22)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Id Area Medica:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(362, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 22)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Telefono:"
        '
        'txtApeMed
        '
        Me.txtApeMed.Location = New System.Drawing.Point(362, 188)
        Me.txtApeMed.Name = "txtApeMed"
        Me.txtApeMed.Size = New System.Drawing.Size(238, 27)
        Me.txtApeMed.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(362, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 22)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Apellido:"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(516, 395)
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
        Me.btnGuardar.Location = New System.Drawing.Point(335, 395)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtNomMed
        '
        Me.txtNomMed.Location = New System.Drawing.Point(362, 121)
        Me.txtNomMed.Name = "txtNomMed"
        Me.txtNomMed.Size = New System.Drawing.Size(238, 27)
        Me.txtNomMed.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(362, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre:"
        '
        'txtIdMedico
        '
        Me.txtIdMedico.Location = New System.Drawing.Point(362, 55)
        Me.txtIdMedico.Name = "txtIdMedico"
        Me.txtIdMedico.Size = New System.Drawing.Size(238, 27)
        Me.txtIdMedico.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(362, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Medico:"
        '
        'tabColabMedicoEditar
        '
        Me.tabColabMedicoEditar.Controls.Add(Me.mtxtTelefonoMod)
        Me.tabColabMedicoEditar.Controls.Add(Me.txtIdAreaMod)
        Me.tabColabMedicoEditar.Controls.Add(Me.Label11)
        Me.tabColabMedicoEditar.Controls.Add(Me.Label12)
        Me.tabColabMedicoEditar.Controls.Add(Me.txtApeMod)
        Me.tabColabMedicoEditar.Controls.Add(Me.Label13)
        Me.tabColabMedicoEditar.Controls.Add(Me.btnCancel)
        Me.tabColabMedicoEditar.Controls.Add(Me.btnModificar)
        Me.tabColabMedicoEditar.Controls.Add(Me.txtNombreModificar)
        Me.tabColabMedicoEditar.Controls.Add(Me.Label6)
        Me.tabColabMedicoEditar.Controls.Add(Me.txtIdModificar)
        Me.tabColabMedicoEditar.Controls.Add(Me.Label7)
        Me.tabColabMedicoEditar.Location = New System.Drawing.Point(4, 29)
        Me.tabColabMedicoEditar.Name = "tabColabMedicoEditar"
        Me.tabColabMedicoEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabColabMedicoEditar.Size = New System.Drawing.Size(1115, 583)
        Me.tabColabMedicoEditar.TabIndex = 2
        Me.tabColabMedicoEditar.Text = "Modificar Colaborador Médico"
        Me.tabColabMedicoEditar.UseVisualStyleBackColor = True
        '
        'mtxtTelefonoMod
        '
        Me.mtxtTelefonoMod.Location = New System.Drawing.Point(411, 261)
        Me.mtxtTelefonoMod.Mask = "0000-0000"
        Me.mtxtTelefonoMod.Name = "mtxtTelefonoMod"
        Me.mtxtTelefonoMod.Size = New System.Drawing.Size(238, 27)
        Me.mtxtTelefonoMod.TabIndex = 26
        '
        'txtIdAreaMod
        '
        Me.txtIdAreaMod.Location = New System.Drawing.Point(411, 332)
        Me.txtIdAreaMod.Name = "txtIdAreaMod"
        Me.txtIdAreaMod.Size = New System.Drawing.Size(238, 27)
        Me.txtIdAreaMod.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(411, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(211, 22)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Id Area Medica:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(411, 236)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(211, 22)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Telefono:"
        '
        'txtApeMod
        '
        Me.txtApeMod.Location = New System.Drawing.Point(411, 195)
        Me.txtApeMod.Name = "txtApeMod"
        Me.txtApeMod.Size = New System.Drawing.Size(238, 27)
        Me.txtApeMod.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(411, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(211, 22)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Apellido:"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(561, 391)
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
        Me.btnModificar.Location = New System.Drawing.Point(380, 391)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 40)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Guardar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtNombreModificar
        '
        Me.txtNombreModificar.Location = New System.Drawing.Point(411, 133)
        Me.txtNombreModificar.Name = "txtNombreModificar"
        Me.txtNombreModificar.Size = New System.Drawing.Size(238, 27)
        Me.txtNombreModificar.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(411, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nombre:"
        '
        'txtIdModificar
        '
        Me.txtIdModificar.Location = New System.Drawing.Point(411, 70)
        Me.txtIdModificar.Name = "txtIdModificar"
        Me.txtIdModificar.ReadOnly = True
        Me.txtIdModificar.Size = New System.Drawing.Size(238, 27)
        Me.txtIdModificar.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(411, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Id_Medico"
        '
        'frmColabMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 600)
        Me.Controls.Add(Me.tabControlColabMedico)
        Me.Controls.Add(Me.pnlControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmColabMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmColabMedicos"
        Me.pnlControl.ResumeLayout(False)
        Me.tabControlColabMedico.ResumeLayout(False)
        Me.tabColabMedicoListar.ResumeLayout(False)
        Me.tabColabMedicoListar.PerformLayout()
        CType(Me.dgvColabMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabColabMedicoAgregar.ResumeLayout(False)
        Me.tabColabMedicoAgregar.PerformLayout()
        Me.tabColabMedicoEditar.ResumeLayout(False)
        Me.tabColabMedicoEditar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlControl As Panel
    Friend WithEvents tabControlColabMedico As TabControl
    Friend WithEvents tabColabMedicoListar As TabPage
    Friend WithEvents txtCantidadRegistro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents cboColabMedico As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvColabMedicos As DataGridView
    Friend WithEvents tabColabMedicoAgregar As TabPage
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNomMed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdMedico As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tabColabMedicoEditar As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtNombreModificar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdModificar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAreaMed As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtApeMed As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents mtxtTelefonoMed As MaskedTextBox
    Friend WithEvents mtxtTelefonoMod As MaskedTextBox
    Friend WithEvents txtIdAreaMod As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtApeMod As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCerrarVista As Button
    Friend WithEvents btnMinimizaar As Button
    Friend WithEvents btnRestablecer As Button
End Class
