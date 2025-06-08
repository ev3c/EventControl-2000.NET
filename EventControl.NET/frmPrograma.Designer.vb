<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPrograma
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form reemplaza a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents _cmdMover_3 As System.Windows.Forms.Button
	Public WithEvents _cmdMover_2 As System.Windows.Forms.Button
	Public WithEvents _cmdMover_1 As System.Windows.Forms.Button
	Public WithEvents _cmdMover_0 As System.Windows.Forms.Button
	Public WithEvents cmdModificar As System.Windows.Forms.Button
	Public WithEvents cmdSalir As System.Windows.Forms.Button
	Public WithEvents chkContraseña As System.Windows.Forms.CheckBox
	Public WithEvents cmdBorrarEventos As System.Windows.Forms.Button
	Public WithEvents txtNombre As System.Windows.Forms.TextBox
	Public dlgNombreOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents cmdExaminar As System.Windows.Forms.Button
	Public WithEvents txtPath As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblNombre As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblID As System.Windows.Forms.Label
	Public WithEvents fraPrograma As System.Windows.Forms.GroupBox
	Public WithEvents cmdBorrar As System.Windows.Forms.Button
	Public WithEvents cmdAñadir As System.Windows.Forms.Button
	Public WithEvents cmdMover As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPrograma))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me._cmdMover_3 = New System.Windows.Forms.Button
		Me._cmdMover_2 = New System.Windows.Forms.Button
		Me._cmdMover_1 = New System.Windows.Forms.Button
		Me._cmdMover_0 = New System.Windows.Forms.Button
		Me.cmdModificar = New System.Windows.Forms.Button
		Me.cmdSalir = New System.Windows.Forms.Button
		Me.fraPrograma = New System.Windows.Forms.GroupBox
		Me.chkContraseña = New System.Windows.Forms.CheckBox
		Me.cmdBorrarEventos = New System.Windows.Forms.Button
		Me.txtNombre = New System.Windows.Forms.TextBox
		Me.dlgNombreOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmdExaminar = New System.Windows.Forms.Button
		Me.txtPath = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblNombre = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblID = New System.Windows.Forms.Label
		Me.cmdBorrar = New System.Windows.Forms.Button
		Me.cmdAñadir = New System.Windows.Forms.Button
		Me.cmdMover = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.fraPrograma.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.cmdMover, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.ClientSize = New System.Drawing.Size(520, 172)
		Me.Location = New System.Drawing.Point(3, 19)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPrograma"
		Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancelar.Text = "&Cancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(105, 25)
		Me.cmdCancelar.Location = New System.Drawing.Point(352, 128)
		Me.cmdCancelar.TabIndex = 16
		Me.cmdCancelar.Visible = False
		Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancelar.CausesValidation = True
		Me.cmdCancelar.Enabled = True
		Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancelar.TabStop = True
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAceptar.Text = "&Aceptar"
		Me.cmdAceptar.Size = New System.Drawing.Size(105, 25)
		Me.cmdAceptar.Location = New System.Drawing.Point(168, 128)
		Me.cmdAceptar.TabIndex = 15
		Me.cmdAceptar.Visible = False
		Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAceptar.CausesValidation = True
		Me.cmdAceptar.Enabled = True
		Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAceptar.TabStop = True
		Me.cmdAceptar.Name = "cmdAceptar"
		Me._cmdMover_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdMover_3.Size = New System.Drawing.Size(25, 25)
		Me._cmdMover_3.Location = New System.Drawing.Point(88, 128)
		Me._cmdMover_3.Image = CType(resources.GetObject("_cmdMover_3.Image"), System.Drawing.Image)
		Me._cmdMover_3.TabIndex = 14
		Me._cmdMover_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdMover_3.CausesValidation = True
		Me._cmdMover_3.Enabled = True
		Me._cmdMover_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdMover_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdMover_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdMover_3.TabStop = True
		Me._cmdMover_3.Name = "_cmdMover_3"
		Me._cmdMover_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdMover_2.Size = New System.Drawing.Size(25, 25)
		Me._cmdMover_2.Location = New System.Drawing.Point(64, 128)
		Me._cmdMover_2.Image = CType(resources.GetObject("_cmdMover_2.Image"), System.Drawing.Image)
		Me._cmdMover_2.TabIndex = 13
		Me._cmdMover_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdMover_2.CausesValidation = True
		Me._cmdMover_2.Enabled = True
		Me._cmdMover_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdMover_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdMover_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdMover_2.TabStop = True
		Me._cmdMover_2.Name = "_cmdMover_2"
		Me._cmdMover_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdMover_1.Size = New System.Drawing.Size(25, 25)
		Me._cmdMover_1.Location = New System.Drawing.Point(40, 128)
		Me._cmdMover_1.Image = CType(resources.GetObject("_cmdMover_1.Image"), System.Drawing.Image)
		Me._cmdMover_1.TabIndex = 12
		Me._cmdMover_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdMover_1.CausesValidation = True
		Me._cmdMover_1.Enabled = True
		Me._cmdMover_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdMover_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdMover_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdMover_1.TabStop = True
		Me._cmdMover_1.Name = "_cmdMover_1"
		Me._cmdMover_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me._cmdMover_0.Size = New System.Drawing.Size(25, 25)
		Me._cmdMover_0.Location = New System.Drawing.Point(16, 128)
		Me._cmdMover_0.Image = CType(resources.GetObject("_cmdMover_0.Image"), System.Drawing.Image)
		Me._cmdMover_0.TabIndex = 11
		Me._cmdMover_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdMover_0.CausesValidation = True
		Me._cmdMover_0.Enabled = True
		Me._cmdMover_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdMover_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdMover_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdMover_0.TabStop = True
		Me._cmdMover_0.Name = "_cmdMover_0"
		Me.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdModificar.Text = "&Modificar"
		Me.cmdModificar.Size = New System.Drawing.Size(89, 25)
		Me.cmdModificar.Location = New System.Drawing.Point(216, 128)
		Me.cmdModificar.TabIndex = 10
		Me.cmdModificar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdModificar.CausesValidation = True
		Me.cmdModificar.Enabled = True
		Me.cmdModificar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdModificar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdModificar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdModificar.TabStop = True
		Me.cmdModificar.Name = "cmdModificar"
		Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSalir.Text = "&Salir"
		Me.cmdSalir.Size = New System.Drawing.Size(97, 25)
		Me.cmdSalir.Location = New System.Drawing.Point(408, 128)
		Me.cmdSalir.TabIndex = 8
		Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSalir.CausesValidation = True
		Me.cmdSalir.Enabled = True
		Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSalir.TabStop = True
		Me.cmdSalir.Name = "cmdSalir"
		Me.fraPrograma.Text = "Programas"
		Me.fraPrograma.Size = New System.Drawing.Size(489, 105)
		Me.fraPrograma.Location = New System.Drawing.Point(16, 8)
		Me.fraPrograma.TabIndex = 2
		Me.fraPrograma.BackColor = System.Drawing.SystemColors.Control
		Me.fraPrograma.Enabled = True
		Me.fraPrograma.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraPrograma.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraPrograma.Visible = True
		Me.fraPrograma.Name = "fraPrograma"
		Me.chkContraseña.Text = "Protejer con contraseña"
		Me.chkContraseña.Size = New System.Drawing.Size(153, 17)
		Me.chkContraseña.Location = New System.Drawing.Point(224, 48)
		Me.chkContraseña.TabIndex = 19
		Me.chkContraseña.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkContraseña.BackColor = System.Drawing.SystemColors.Control
		Me.chkContraseña.CausesValidation = True
		Me.chkContraseña.Enabled = True
		Me.chkContraseña.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkContraseña.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkContraseña.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkContraseña.TabStop = True
		Me.chkContraseña.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkContraseña.Visible = True
		Me.chkContraseña.Name = "chkContraseña"
		Me.cmdBorrarEventos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBorrarEventos.Text = "Borrar &Eventos"
		Me.cmdBorrarEventos.Size = New System.Drawing.Size(129, 25)
		Me.cmdBorrarEventos.Location = New System.Drawing.Point(232, 16)
		Me.cmdBorrarEventos.TabIndex = 18
		Me.cmdBorrarEventos.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBorrarEventos.CausesValidation = True
		Me.cmdBorrarEventos.Enabled = True
		Me.cmdBorrarEventos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBorrarEventos.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBorrarEventos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBorrarEventos.TabStop = True
		Me.cmdBorrarEventos.Name = "cmdBorrarEventos"
		Me.txtNombre.AutoSize = False
		Me.txtNombre.Size = New System.Drawing.Size(137, 19)
		Me.txtNombre.Location = New System.Drawing.Point(72, 48)
		Me.txtNombre.Maxlength = 15
		Me.txtNombre.TabIndex = 17
		Me.txtNombre.AcceptsReturn = True
		Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
		Me.txtNombre.CausesValidation = True
		Me.txtNombre.Enabled = True
		Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNombre.HideSelection = True
		Me.txtNombre.ReadOnly = False
		Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNombre.MultiLine = False
		Me.txtNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNombre.TabStop = True
		Me.txtNombre.Visible = True
		Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNombre.Name = "txtNombre"
		Me.cmdExaminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExaminar.Text = "&Examinar"
		Me.cmdExaminar.Size = New System.Drawing.Size(89, 25)
		Me.cmdExaminar.Location = New System.Drawing.Point(384, 40)
		Me.cmdExaminar.TabIndex = 9
		Me.cmdExaminar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdExaminar.CausesValidation = True
		Me.cmdExaminar.Enabled = True
		Me.cmdExaminar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdExaminar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExaminar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdExaminar.TabStop = True
		Me.cmdExaminar.Name = "cmdExaminar"
		Me.txtPath.AutoSize = False
		Me.txtPath.Size = New System.Drawing.Size(401, 19)
		Me.txtPath.Location = New System.Drawing.Point(72, 72)
		Me.txtPath.TabIndex = 7
		Me.txtPath.AcceptsReturn = True
		Me.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtPath.BackColor = System.Drawing.SystemColors.Window
		Me.txtPath.CausesValidation = True
		Me.txtPath.Enabled = True
		Me.txtPath.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPath.HideSelection = True
		Me.txtPath.ReadOnly = False
		Me.txtPath.Maxlength = 0
		Me.txtPath.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPath.MultiLine = False
		Me.txtPath.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPath.TabStop = True
		Me.txtPath.Visible = True
		Me.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPath.Name = "txtPath"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label3.Text = "Path:"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 72)
		Me.Label3.TabIndex = 6
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblNombre.Text = "Nombre:"
		Me.lblNombre.Size = New System.Drawing.Size(57, 17)
		Me.lblNombre.Location = New System.Drawing.Point(8, 48)
		Me.lblNombre.TabIndex = 5
		Me.lblNombre.BackColor = System.Drawing.SystemColors.Control
		Me.lblNombre.Enabled = True
		Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNombre.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNombre.UseMnemonic = True
		Me.lblNombre.Visible = True
		Me.lblNombre.AutoSize = False
		Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNombre.Name = "lblNombre"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label1.Text = "ID:"
		Me.Label1.Size = New System.Drawing.Size(25, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 24)
		Me.Label1.TabIndex = 4
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lblID.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblID.BackColor = System.Drawing.SystemColors.Desktop
		Me.lblID.ForeColor = System.Drawing.SystemColors.Window
		Me.lblID.Size = New System.Drawing.Size(33, 17)
		Me.lblID.Location = New System.Drawing.Point(72, 24)
		Me.lblID.TabIndex = 3
		Me.lblID.Enabled = True
		Me.lblID.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblID.UseMnemonic = True
		Me.lblID.Visible = True
		Me.lblID.AutoSize = False
		Me.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblID.Name = "lblID"
		Me.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBorrar.Text = "&Borrar"
		Me.cmdBorrar.Size = New System.Drawing.Size(89, 25)
		Me.cmdBorrar.Location = New System.Drawing.Point(312, 128)
		Me.cmdBorrar.TabIndex = 1
		Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBorrar.CausesValidation = True
		Me.cmdBorrar.Enabled = True
		Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBorrar.TabStop = True
		Me.cmdBorrar.Name = "cmdBorrar"
		Me.cmdAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAñadir.Text = "&Añadir"
		Me.cmdAñadir.Size = New System.Drawing.Size(89, 25)
		Me.cmdAñadir.Location = New System.Drawing.Point(120, 128)
		Me.cmdAñadir.TabIndex = 0
		Me.cmdAñadir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAñadir.CausesValidation = True
		Me.cmdAñadir.Enabled = True
		Me.cmdAñadir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAñadir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAñadir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAñadir.TabStop = True
		Me.cmdAñadir.Name = "cmdAñadir"
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(_cmdMover_3)
		Me.Controls.Add(_cmdMover_2)
		Me.Controls.Add(_cmdMover_1)
		Me.Controls.Add(_cmdMover_0)
		Me.Controls.Add(cmdModificar)
		Me.Controls.Add(cmdSalir)
		Me.Controls.Add(fraPrograma)
		Me.Controls.Add(cmdBorrar)
		Me.Controls.Add(cmdAñadir)
		Me.fraPrograma.Controls.Add(chkContraseña)
		Me.fraPrograma.Controls.Add(cmdBorrarEventos)
		Me.fraPrograma.Controls.Add(txtNombre)
		Me.fraPrograma.Controls.Add(cmdExaminar)
		Me.fraPrograma.Controls.Add(txtPath)
		Me.fraPrograma.Controls.Add(Label3)
		Me.fraPrograma.Controls.Add(lblNombre)
		Me.fraPrograma.Controls.Add(Label1)
		Me.fraPrograma.Controls.Add(lblID)
		Me.cmdMover.SetIndex(_cmdMover_3, CType(3, Short))
		Me.cmdMover.SetIndex(_cmdMover_2, CType(2, Short))
		Me.cmdMover.SetIndex(_cmdMover_1, CType(1, Short))
		Me.cmdMover.SetIndex(_cmdMover_0, CType(0, Short))
		CType(Me.cmdMover, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraPrograma.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class