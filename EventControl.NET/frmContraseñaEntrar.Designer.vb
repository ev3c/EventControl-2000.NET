<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContraseñaEntrar
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
	Public WithEvents txtContraseña As System.Windows.Forms.TextBox
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents tmrContraseña As System.Windows.Forms.Timer
	Public WithEvents lblContraseña As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContraseñaEntrar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtContraseña = New System.Windows.Forms.TextBox
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.tmrContraseña = New System.Windows.Forms.Timer(components)
		Me.lblContraseña = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Entrar Contraseña"
		Me.ClientSize = New System.Drawing.Size(312, 124)
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
		Me.Name = "frmContraseñaEntrar"
		Me.txtContraseña.AutoSize = False
		Me.txtContraseña.Size = New System.Drawing.Size(81, 19)
		Me.txtContraseña.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtContraseña.Location = New System.Drawing.Point(168, 32)
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
		Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAceptar.Text = "&Aceptar"
		Me.AcceptButton = Me.cmdAceptar
		Me.cmdAceptar.Size = New System.Drawing.Size(113, 25)
		Me.cmdAceptar.Location = New System.Drawing.Point(32, 80)
		Me.cmdAceptar.TabIndex = 2
		Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAceptar.CausesValidation = True
		Me.cmdAceptar.Enabled = True
		Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAceptar.TabStop = True
		Me.cmdAceptar.Name = "cmdAceptar"
		Me.cmdCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdCancelar
		Me.cmdCancelar.Text = "&Cancelar"
		Me.cmdCancelar.Size = New System.Drawing.Size(113, 25)
		Me.cmdCancelar.Location = New System.Drawing.Point(168, 80)
		Me.cmdCancelar.TabIndex = 1
		Me.cmdCancelar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancelar.CausesValidation = True
		Me.cmdCancelar.Enabled = True
		Me.cmdCancelar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancelar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancelar.TabStop = True
		Me.cmdCancelar.Name = "cmdCancelar"
		Me.Frame1.Size = New System.Drawing.Size(265, 57)
		Me.Frame1.Location = New System.Drawing.Point(24, 8)
		Me.Frame1.TabIndex = 3
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.tmrContraseña.Enabled = False
		Me.tmrContraseña.Interval = 1
		Me.lblContraseña.Text = "Contraseña"
		Me.lblContraseña.Size = New System.Drawing.Size(81, 17)
		Me.lblContraseña.Location = New System.Drawing.Point(40, 24)
		Me.lblContraseña.TabIndex = 4
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
		Me.Controls.Add(txtContraseña)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(lblContraseña)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class