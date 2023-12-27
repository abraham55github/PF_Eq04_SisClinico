<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreasMedicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAreasMedicas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlControl = New System.Windows.Forms.Panel()
        Me.btnCerrarVista = New System.Windows.Forms.Button()
        Me.btnMinimizaar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabAreaMedicaEditar = New System.Windows.Forms.TabPage()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtNombreModificar = New System.Windows.Forms.TextBox()
        Me.txtIdModificar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabAreasMedicasAgregar = New System.Windows.Forms.TabPage()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.txtNomArea = New System.Windows.Forms.TextBox()
        Me.txtIdArea = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabAreasMedicasListar = New System.Windows.Forms.TabPage()
        Me.btnRestablecer = New System.Windows.Forms.Button()
        Me.txtCantidadRegistro = New System.Windows.Forms.TextBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.cboAreasMedicas = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvAreasMedicas = New System.Windows.Forms.DataGridView()
        Me.TabControlAreaM = New System.Windows.Forms.TabControl()
        Me.pnlControl.SuspendLayout()
        Me.tabAreaMedicaEditar.SuspendLayout()
        Me.TabAreasMedicasAgregar.SuspendLayout()
        Me.tabAreasMedicasListar.SuspendLayout()
        CType(Me.dgvAreasMedicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlAreaM.SuspendLayout()
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
        Me.pnlControl.Size = New System.Drawing.Size(1074, 52)
        Me.pnlControl.TabIndex = 2
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
        Me.btnCerrarVista.Location = New System.Drawing.Point(1034, 0)
        Me.btnCerrarVista.Name = "btnCerrarVista"
        Me.btnCerrarVista.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarVista.TabIndex = 15
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
        Me.btnMinimizaar.Location = New System.Drawing.Point(988, 2)
        Me.btnMinimizaar.Name = "btnMinimizaar"
        Me.btnMinimizaar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizaar.TabIndex = 14
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
        Me.Label1.Text = "Areas Medicas"
        '
        'tabAreaMedicaEditar
        '
        Me.tabAreaMedicaEditar.Controls.Add(Me.btnCancel)
        Me.tabAreaMedicaEditar.Controls.Add(Me.btnModificar)
        Me.tabAreaMedicaEditar.Controls.Add(Me.txtNombreModificar)
        Me.tabAreaMedicaEditar.Controls.Add(Me.txtIdModificar)
        Me.tabAreaMedicaEditar.Controls.Add(Me.Label6)
        Me.tabAreaMedicaEditar.Controls.Add(Me.Label7)
        Me.tabAreaMedicaEditar.Location = New System.Drawing.Point(4, 29)
        Me.tabAreaMedicaEditar.Name = "tabAreaMedicaEditar"
        Me.tabAreaMedicaEditar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAreaMedicaEditar.Size = New System.Drawing.Size(1066, 489)
        Me.tabAreaMedicaEditar.TabIndex = 2
        Me.tabAreaMedicaEditar.Text = "Modificar Area Medica"
        Me.tabAreaMedicaEditar.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(537, 265)
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
        Me.btnModificar.Location = New System.Drawing.Point(356, 265)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(137, 40)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Guardar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtNombreModificar
        '
        Me.txtNombreModificar.Location = New System.Drawing.Point(384, 200)
        Me.txtNombreModificar.Name = "txtNombreModificar"
        Me.txtNombreModificar.Size = New System.Drawing.Size(238, 27)
        Me.txtNombreModificar.TabIndex = 14
        '
        'txtIdModificar
        '
        Me.txtIdModificar.Location = New System.Drawing.Point(384, 112)
        Me.txtIdModificar.Name = "txtIdModificar"
        Me.txtIdModificar.ReadOnly = True
        Me.txtIdModificar.Size = New System.Drawing.Size(238, 27)
        Me.txtIdModificar.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(384, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 22)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nombre de Area Medica:"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(384, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 22)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Id Area Medica:"
        '
        'TabAreasMedicasAgregar
        '
        Me.TabAreasMedicasAgregar.Controls.Add(Me.btnCancelar)
        Me.TabAreasMedicasAgregar.Controls.Add(Me.btnGuardar)
        Me.TabAreasMedicasAgregar.Controls.Add(Me.txtNomArea)
        Me.TabAreasMedicasAgregar.Controls.Add(Me.txtIdArea)
        Me.TabAreasMedicasAgregar.Controls.Add(Me.Label4)
        Me.TabAreasMedicasAgregar.Controls.Add(Me.Label3)
        Me.TabAreasMedicasAgregar.Location = New System.Drawing.Point(4, 29)
        Me.TabAreasMedicasAgregar.Name = "TabAreasMedicasAgregar"
        Me.TabAreasMedicasAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAreasMedicasAgregar.Size = New System.Drawing.Size(1066, 489)
        Me.TabAreasMedicasAgregar.TabIndex = 1
        Me.TabAreasMedicasAgregar.Text = "Agregar Area Medica"
        Me.TabAreasMedicasAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(558, 269)
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
        Me.btnGuardar.Location = New System.Drawing.Point(377, 269)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(137, 40)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtNomArea
        '
        Me.txtNomArea.Location = New System.Drawing.Point(405, 204)
        Me.txtNomArea.Name = "txtNomArea"
        Me.txtNomArea.Size = New System.Drawing.Size(238, 27)
        Me.txtNomArea.TabIndex = 8
        '
        'txtIdArea
        '
        Me.txtIdArea.Location = New System.Drawing.Point(405, 116)
        Me.txtIdArea.Name = "txtIdArea"
        Me.txtIdArea.Size = New System.Drawing.Size(238, 27)
        Me.txtIdArea.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(405, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nombre de Area Medica:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(405, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id Area Medica:"
        '
        'tabAreasMedicasListar
        '
        Me.tabAreasMedicasListar.Controls.Add(Me.btnRestablecer)
        Me.tabAreasMedicasListar.Controls.Add(Me.txtCantidadRegistro)
        Me.tabAreasMedicasListar.Controls.Add(Me.txtBuscar)
        Me.tabAreasMedicasListar.Controls.Add(Me.Label5)
        Me.tabAreasMedicasListar.Controls.Add(Me.btnBuscar)
        Me.tabAreasMedicasListar.Controls.Add(Me.btnEliminar)
        Me.tabAreasMedicasListar.Controls.Add(Me.btnEditar)
        Me.tabAreasMedicasListar.Controls.Add(Me.btnAgregar)
        Me.tabAreasMedicasListar.Controls.Add(Me.cboAreasMedicas)
        Me.tabAreasMedicasListar.Controls.Add(Me.Label2)
        Me.tabAreasMedicasListar.Controls.Add(Me.dgvAreasMedicas)
        Me.tabAreasMedicasListar.Location = New System.Drawing.Point(4, 29)
        Me.tabAreasMedicasListar.Name = "tabAreasMedicasListar"
        Me.tabAreasMedicasListar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAreasMedicasListar.Size = New System.Drawing.Size(1066, 489)
        Me.tabAreasMedicasListar.TabIndex = 0
        Me.tabAreasMedicasListar.Text = "Lista de Areas Medicas"
        Me.tabAreasMedicasListar.UseVisualStyleBackColor = True
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
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(198, 44)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(376, 27)
        Me.txtBuscar.TabIndex = 6
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
        Me.btnEliminar.Location = New System.Drawing.Point(896, 203)
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
        Me.btnEditar.Location = New System.Drawing.Point(896, 143)
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
        Me.btnAgregar.Location = New System.Drawing.Point(896, 77)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(137, 40)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'cboAreasMedicas
        '
        Me.cboAreasMedicas.FormattingEnabled = True
        Me.cboAreasMedicas.Items.AddRange(New Object() {"Id_Area", "Nombre_Area"})
        Me.cboAreasMedicas.Location = New System.Drawing.Point(19, 43)
        Me.cboAreasMedicas.Name = "cboAreasMedicas"
        Me.cboAreasMedicas.Size = New System.Drawing.Size(173, 28)
        Me.cboAreasMedicas.TabIndex = 5
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
        Me.Label2.Text = "Buscar Area Medica:"
        '
        'dgvAreasMedicas
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dgvAreasMedicas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAreasMedicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAreasMedicas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvAreasMedicas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAreasMedicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAreasMedicas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAreasMedicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAreasMedicas.Location = New System.Drawing.Point(20, 77)
        Me.dgvAreasMedicas.Name = "dgvAreasMedicas"
        Me.dgvAreasMedicas.RowHeadersVisible = False
        Me.dgvAreasMedicas.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvAreasMedicas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAreasMedicas.RowTemplate.Height = 29
        Me.dgvAreasMedicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAreasMedicas.Size = New System.Drawing.Size(837, 358)
        Me.dgvAreasMedicas.TabIndex = 0
        '
        'TabControlAreaM
        '
        Me.TabControlAreaM.Controls.Add(Me.tabAreasMedicasListar)
        Me.TabControlAreaM.Controls.Add(Me.TabAreasMedicasAgregar)
        Me.TabControlAreaM.Controls.Add(Me.tabAreaMedicaEditar)
        Me.TabControlAreaM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlAreaM.Location = New System.Drawing.Point(0, 52)
        Me.TabControlAreaM.Name = "TabControlAreaM"
        Me.TabControlAreaM.SelectedIndex = 0
        Me.TabControlAreaM.Size = New System.Drawing.Size(1074, 522)
        Me.TabControlAreaM.TabIndex = 3
        '
        'frmAreasMedicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1074, 574)
        Me.Controls.Add(Me.TabControlAreaM)
        Me.Controls.Add(Me.pnlControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAreasMedicas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAreasMedicas"
        Me.pnlControl.ResumeLayout(False)
        Me.tabAreaMedicaEditar.ResumeLayout(False)
        Me.tabAreaMedicaEditar.PerformLayout()
        Me.TabAreasMedicasAgregar.ResumeLayout(False)
        Me.TabAreasMedicasAgregar.PerformLayout()
        Me.tabAreasMedicasListar.ResumeLayout(False)
        Me.tabAreasMedicasListar.PerformLayout()
        CType(Me.dgvAreasMedicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlAreaM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlControl As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarVista As Button
    Friend WithEvents btnMinimizaar As Button
    Friend WithEvents tabAreaMedicaEditar As TabPage
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents txtNombreModificar As TextBox
    Friend WithEvents txtIdModificar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TabAreasMedicasAgregar As TabPage
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents txtNomArea As TextBox
    Friend WithEvents txtIdArea As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tabAreasMedicasListar As TabPage
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents txtCantidadRegistro As TextBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cboAreasMedicas As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAreasMedicas As DataGridView
    Friend WithEvents TabControlAreaM As TabControl
End Class
