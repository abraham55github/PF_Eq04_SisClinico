<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiPrincipal1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPrincipal1))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlBarraTitulo = New System.Windows.Forms.Panel()
        Me.btnCerrarApp = New System.Windows.Forms.Button()
        Me.btnMaxi = New System.Windows.Forms.Button()
        Me.btnMini = New System.Windows.Forms.Button()
        Me.btnMinimizaar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.mnuEstado = New System.Windows.Forms.ToolStrip()
        Me.lblUsuaio = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFechaHora = New System.Windows.Forms.ToolStripLabel()
        Me.mnuPrincipal = New System.Windows.Forms.ToolStrip()
        Me.btnConsultas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPacientes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnColaboradoresMed = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAreaMedico = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DopDownInfo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnInfoGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnInfoApp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tmrHora = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBarraTitulo.SuspendLayout()
        Me.mnuEstado.SuspendLayout()
        Me.mnuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBarraTitulo
        '
        Me.pnlBarraTitulo.BackColor = System.Drawing.Color.Navy
        Me.pnlBarraTitulo.Controls.Add(Me.btnCerrarApp)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMaxi)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMini)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMinimizaar)
        Me.pnlBarraTitulo.Controls.Add(Me.Label2)
        Me.pnlBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.pnlBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.pnlBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlBarraTitulo.Name = "pnlBarraTitulo"
        Me.pnlBarraTitulo.Size = New System.Drawing.Size(1850, 40)
        Me.pnlBarraTitulo.TabIndex = 12
        '
        'btnCerrarApp
        '
        Me.btnCerrarApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarApp.BackColor = System.Drawing.Color.Navy
        Me.btnCerrarApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarApp.FlatAppearance.BorderSize = 0
        Me.btnCerrarApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCerrarApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarApp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrarApp.Image = CType(resources.GetObject("btnCerrarApp.Image"), System.Drawing.Image)
        Me.btnCerrarApp.Location = New System.Drawing.Point(1810, 0)
        Me.btnCerrarApp.Name = "btnCerrarApp"
        Me.btnCerrarApp.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarApp.TabIndex = 8
        Me.btnCerrarApp.UseVisualStyleBackColor = False
        '
        'btnMaxi
        '
        Me.btnMaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaxi.BackColor = System.Drawing.Color.Navy
        Me.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaxi.FlatAppearance.BorderSize = 0
        Me.btnMaxi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMaxi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaxi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMaxi.Image = Global.CapaPresentacion.My.Resources.Resources.maxi
        Me.btnMaxi.Location = New System.Drawing.Point(1764, 0)
        Me.btnMaxi.Name = "btnMaxi"
        Me.btnMaxi.Size = New System.Drawing.Size(40, 40)
        Me.btnMaxi.TabIndex = 7
        Me.btnMaxi.UseVisualStyleBackColor = False
        '
        'btnMini
        '
        Me.btnMini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMini.BackColor = System.Drawing.Color.Navy
        Me.btnMini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMini.FlatAppearance.BorderSize = 0
        Me.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMini.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMini.Image = Global.CapaPresentacion.My.Resources.Resources.res
        Me.btnMini.Location = New System.Drawing.Point(1764, -3)
        Me.btnMini.Name = "btnMini"
        Me.btnMini.Size = New System.Drawing.Size(40, 40)
        Me.btnMini.TabIndex = 6
        Me.btnMini.UseVisualStyleBackColor = False
        Me.btnMini.Visible = False
        '
        'btnMinimizaar
        '
        Me.btnMinimizaar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizaar.BackColor = System.Drawing.Color.Navy
        Me.btnMinimizaar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizaar.FlatAppearance.BorderSize = 0
        Me.btnMinimizaar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizaar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizaar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinimizaar.Image = CType(resources.GetObject("btnMinimizaar.Image"), System.Drawing.Image)
        Me.btnMinimizaar.Location = New System.Drawing.Point(1718, 0)
        Me.btnMinimizaar.Name = "btnMinimizaar"
        Me.btnMinimizaar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizaar.TabIndex = 5
        Me.btnMinimizaar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Menu Principal"
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.Navy
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRestaurar.Image = Global.CapaPresentacion.My.Resources.Resources.res
        Me.btnRestaurar.Location = New System.Drawing.Point(2924, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Navy
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(2878, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.Navy
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMaximizar.Image = Global.CapaPresentacion.My.Resources.Resources.maxi
        Me.btnMaximizar.Location = New System.Drawing.Point(2924, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Navy
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(2970, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AccessibleName = "Selección de nuevo elemento"
        Me.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.miniToolStrip.Location = New System.Drawing.Point(1094, 19)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(1097, 62)
        Me.miniToolStrip.TabIndex = 11
        '
        'mnuEstado
        '
        Me.mnuEstado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mnuEstado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUsuaio, Me.ToolStripSeparator6, Me.lblFechaHora})
        Me.mnuEstado.Location = New System.Drawing.Point(0, 868)
        Me.mnuEstado.Name = "mnuEstado"
        Me.mnuEstado.Size = New System.Drawing.Size(1850, 25)
        Me.mnuEstado.TabIndex = 15
        Me.mnuEstado.Text = "ToolStrip1"
        '
        'lblUsuaio
        '
        Me.lblUsuaio.Name = "lblUsuaio"
        Me.lblUsuaio.Size = New System.Drawing.Size(113, 22)
        Me.lblUsuaio.Text = "ToolStripLabel1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'lblFechaHora
        '
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(113, 22)
        Me.lblFechaHora.Text = "ToolStripLabel2"
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.AutoSize = False
        Me.mnuPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.mnuPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mnuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnConsultas, Me.ToolStripSeparator1, Me.btnPacientes, Me.ToolStripSeparator2, Me.btnColaboradoresMed, Me.ToolStripSeparator3, Me.btnAreaMedico, Me.ToolStripSeparator4, Me.DopDownInfo, Me.ToolStripSeparator5, Me.btnSalir})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 40)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(1850, 50)
        Me.mnuPrincipal.TabIndex = 17
        Me.mnuPrincipal.Text = "ToolStrip2"
        '
        'btnConsultas
        '
        Me.btnConsultas.ForeColor = System.Drawing.Color.White
        Me.btnConsultas.Image = Global.CapaPresentacion.My.Resources.Resources.producto
        Me.btnConsultas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(233, 47)
        Me.btnConsultas.Text = "Consultas Médicas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'btnPacientes
        '
        Me.btnPacientes.ForeColor = System.Drawing.Color.White
        Me.btnPacientes.Image = Global.CapaPresentacion.My.Resources.Resources.clientes
        Me.btnPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPacientes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(152, 47)
        Me.btnPacientes.Text = "Pacientes"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'btnColaboradoresMed
        '
        Me.btnColaboradoresMed.ForeColor = System.Drawing.Color.White
        Me.btnColaboradoresMed.Image = Global.CapaPresentacion.My.Resources.Resources.empleados
        Me.btnColaboradoresMed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnColaboradoresMed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnColaboradoresMed.Name = "btnColaboradoresMed"
        Me.btnColaboradoresMed.Size = New System.Drawing.Size(263, 47)
        Me.btnColaboradoresMed.Text = "Colboradores Médicos"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 50)
        '
        'btnAreaMedico
        '
        Me.btnAreaMedico.ForeColor = System.Drawing.Color.White
        Me.btnAreaMedico.Image = CType(resources.GetObject("btnAreaMedico.Image"), System.Drawing.Image)
        Me.btnAreaMedico.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAreaMedico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAreaMedico.Name = "btnAreaMedico"
        Me.btnAreaMedico.Size = New System.Drawing.Size(181, 47)
        Me.btnAreaMedico.Text = "Areas Médicas"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 50)
        '
        'DopDownInfo
        '
        Me.DopDownInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnInfoGeneral, Me.btnInfoApp})
        Me.DopDownInfo.ForeColor = System.Drawing.Color.White
        Me.DopDownInfo.Image = CType(resources.GetObject("DopDownInfo.Image"), System.Drawing.Image)
        Me.DopDownInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DopDownInfo.Name = "DopDownInfo"
        Me.DopDownInfo.Size = New System.Drawing.Size(147, 47)
        Me.DopDownInfo.Text = "Informacion"
        Me.DopDownInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DopDownInfo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'btnInfoGeneral
        '
        Me.btnInfoGeneral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInfoGeneral.ForeColor = System.Drawing.Color.White
        Me.btnInfoGeneral.Name = "btnInfoGeneral"
        Me.btnInfoGeneral.Size = New System.Drawing.Size(287, 30)
        Me.btnInfoGeneral.Text = "Informacion General"
        '
        'btnInfoApp
        '
        Me.btnInfoApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInfoApp.ForeColor = System.Drawing.Color.White
        Me.btnInfoApp.Name = "btnInfoApp"
        Me.btnInfoApp.Size = New System.Drawing.Size(287, 30)
        Me.btnInfoApp.Text = "Información de la App"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 50)
        '
        'btnSalir
        '
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.CapaPresentacion.My.Resources.Resources.icons8_export_50
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 47)
        Me.btnSalir.Text = "Salir"
        '
        'tmrHora
        '
        Me.tmrHora.Interval = 1000
        '
        'mdiPrincipal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1850, 893)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Controls.Add(Me.mnuEstado)
        Me.Controls.Add(Me.pnlBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "mdiPrincipal1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mdiPrincipal1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.pnlBarraTitulo.ResumeLayout(False)
        Me.pnlBarraTitulo.PerformLayout()
        Me.mnuEstado.ResumeLayout(False)
        Me.mnuEstado.PerformLayout()
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pnlBarraTitulo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizaar As Button
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMaxi As Button
    Friend WithEvents btnCerrarApp As Button
    Friend WithEvents miniToolStrip As ToolStrip
    Friend WithEvents mnuEstado As ToolStrip
    Friend WithEvents lblUsuaio As ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents lblFechaHora As ToolStripLabel
    Friend WithEvents mnuPrincipal As ToolStrip
    Friend WithEvents btnConsultas As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnPacientes As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnColaboradoresMed As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnAreaMedico As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DopDownInfo As ToolStripDropDownButton
    Friend WithEvents btnInfoApp As ToolStripMenuItem
    Friend WithEvents btnInfoGeneral As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents tmrHora As Timer
End Class
