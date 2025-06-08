<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContraseñaCambiar
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
	Public WithEvents txtNuevaContraseña As System.Windows.Forms.TextBox
	Public WithEvents txtContraseña As System.Windows.Forms.TextBox
	Public WithEvents txtNuevaContraseña2 As System.Windows.Forms.TextBox
	Public WithEvents lblNuevaContraseña2 As System.Windows.Forms.Label
	Public WithEvents lblNuevaContraseña As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblContraseña As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContraseñaCambiar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.txtNuevaContraseña = New System.Windows.Forms.TextBox
		Me.txtContraseña = New System.Windows.Forms.TextBox
		Me.txtNuevaContraseña2 = New System.Windows.Forms.TextBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblNuevaContraseña2 = New System.Windows.Forms.Label
		Me.lblNuevaContraseña = New System.Windows.Forms.Label
		Me.lblContraseña = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.ClientSize = New System.Drawing.Size(297, 193)
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
		Me.Name = "frmContraseñaCambiar"
		Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancelar
		Me.cmdCancelar.Text = "&Cancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(113, 25)
		Me.cmdCancelar.Location = New System.Drawing.Point(160, 152)
		Me.cmdCancelar.TabIndex = 8
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
		Me.AcceptButton = Me.cmdAceptar
		Me.cmdAceptar.Size = New System.Drawing.Size(113, 25)
		Me.cmdAceptar.Location = New System.Drawing.Point(24, 152)
		Me.cmdAceptar.TabIndex = 7
		Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAceptar.CausesValidation = True
		Me.cmdAceptar.Enabled = True
		Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAceptar.TabStop = True
		Me.cmdAceptar.Name = "cmdAceptar"
		Me.txtNuevaContraseña.AutoSize = False
		Me.txtNuevaContraseña.Size = New System.Drawing.Size(81, 19)
		Me.txtNuevaContraseña.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNuevaContraseña.Location = New System.Drawing.Point(176, 64)
		Me.txtNuevaContraseña.Maxlength = 10
		Me.txtNuevaContraseña.PasswordChar = ChrW(42)
		Me.txtNuevaContraseña.TabIndex = 1
		Me.txtNuevaContraseña.AcceptsReturn = True
		Me.txtNuevaContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNuevaContraseña.BackColor = System.Drawing.SystemColors.Window
		Me.txtNuevaContraseña.CausesValidation = True
		Me.txtNuevaContraseña.Enabled = True
		Me.txtNuevaContraseña.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNuevaContraseña.HideSelection = True
		Me.txtNuevaContraseña.ReadOnly = False
		Me.txtNuevaContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNuevaContraseña.MultiLine = False
		Me.txtNuevaContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNuevaContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNuevaContraseña.TabStop = True
		Me.txtNuevaContraseña.Visible = True
		Me.txtNuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNuevaContraseña.Name = "txtNuevaContraseña"
		Me.txtContraseña.AutoSize = False
		Me.txtContraseña.Size = New System.Drawing.Size(81, 19)
		Me.txtContraseña.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtContraseña.Location = New System.Drawing.Point(136, 16)
		Me.txtContraseña.Maxlength = 10
		Me.txtContraseña.PasswordChar = ChrW(42)
		Me.txtContraseña.TabIndex = 0
		Me.txtContraseña.AcceptsReturn = True
		Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContraseña.BackColor = System.Drawing.SystemColors.Window
		Me.txtContraseña.CausesValidation = True
		Me.txtContraseña.Enabled = True
		Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContraseña.HideSelection = True
		Me.txtContraseña.ReadOnly = False
		Me.txtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContraseña.MultiLine = False
		Me.txtContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContraseña.TabStop = True
		Me.txtContraseña.Visible = True
		Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContraseña.Name = "txtContraseña"
		Me.txtNuevaContraseña2.AutoSize = False
		Me.txtNuevaContraseña2.Size = New System.Drawing.Size(81, 19)
		Me.txtNuevaContraseña2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNuevaContraseña2.Location = New System.Drawing.Point(176, 96)
		Me.txtNuevaContraseña2.Maxlength = 10
		Me.txtNuevaContraseña2.PasswordChar = ChrW(42)
		Me.txtNuevaContraseña2.TabIndex = 2
		Me.txtNuevaContraseña2.AcceptsReturn = True
		Me.txtNuevaContraseña2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNuevaContraseña2.BackColor = System.Drawing.SystemColors.Window
		Me.txtNuevaContraseña2.CausesValidation = True
		Me.txtNuevaContraseña2.Enabled = True
		Me.txtNuevaContraseña2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNuevaContraseña2.HideSelection = True
		Me.txtNuevaContraseña2.ReadOnly = False
		Me.txtNuevaContraseña2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNuevaContraseña2.MultiLine = False
		Me.txtNuevaContraseña2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNuevaContraseña2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNuevaContraseña2.TabStop = True
		Me.txtNuevaContraseña2.Visible = True
		Me.txtNuevaContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNuevaContraseña2.Name = "txtNuevaContraseña2"
		Me.Frame1.Size = New System.Drawing.Size(265, 97)
		Me.Frame1.Location = New System.Drawing.Point(16, 40)
		Me.Frame1.TabIndex = 4
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.lblNuevaContraseña2.Text = "Reentrar Nueva Contraseña"
		Me.lblNuevaContraseña2.Size = New System.Drawing.Size(153, 17)
		Me.lblNuevaContraseña2.Location = New System.Drawing.Point(16, 56)
		Me.lblNuevaContraseña2.TabIndex = 6
		Me.lblNuevaContraseña2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNuevaContraseña2.BackColor = System.Drawing.SystemColors.Control
		Me.lblNuevaContraseña2.Enabled = True
		Me.lblNuevaContraseña2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNuevaContraseña2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNuevaContraseña2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNuevaContraseña2.UseMnemonic = True
		Me.lblNuevaContraseña2.Visible = True
		Me.lblNuevaContraseña2.AutoSize = False
		Me.lblNuevaContraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNuevaContraseña2.Name = "lblNuevaContraseña2"
		Me.lblNuevaContraseña.Text = "Nueva Contraseña"
		Me.lblNuevaContraseña.Size = New System.Drawing.Size(153, 17)
		Me.lblNuevaContraseña.Location = New System.Drawing.Point(16, 24)
		Me.lblNuevaContraseña.TabIndex = 5
		Me.lblNuevaContraseña.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNuevaContraseña.BackColor = System.Drawing.SystemColors.Control
		Me.lblNuevaContraseña.Enabled = True
		Me.lblNuevaContraseña.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNuevaContraseña.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNuevaContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNuevaContraseña.UseMnemonic = True
		Me.lblNuevaContraseña.Visible = True
		Me.lblNuevaContraseña.AutoSize = False
		Me.lblNuevaContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNuevaContraseña.Name = "lblNuevaContraseña"
		Me.lblContraseña.Text = "Contraseña"
		Me.lblContraseña.Size = New System.Drawing.Size(81, 17)
		Me.lblContraseña.Location = New System.Drawing.Point(48, 16)
		Me.lblContraseña.TabIndex = 3
		Me.lblContraseña.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblContraseña.BackColor = System.Drawing.SystemColors.Control
		Me.lblContraseña.Enabled = True
		Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblContraseña.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblContraseña.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblContraseña.UseMnemonic = True
		Me.lblContraseña.Visible = True
		Me.lblContraseña.AutoSize = False
		Me.lblContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblContraseña.Name = "lblContraseña"
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(txtNuevaContraseña)
		Me.Controls.Add(txtContraseña)
		Me.Controls.Add(txtNuevaContraseña2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblContraseña)
		Me.Frame1.Controls.Add(lblNuevaContraseña2)
		Me.Frame1.Controls.Add(lblNuevaContraseña)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class