<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContrase�aCambiar
#Region "C�digo generado por el Dise�ador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Dise�ador de Windows Forms.
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
	'Requerido por el Dise�ador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents txtNuevaContrase�a As System.Windows.Forms.TextBox
	Public WithEvents txtContrase�a As System.Windows.Forms.TextBox
	Public WithEvents txtNuevaContrase�a2 As System.Windows.Forms.TextBox
	Public WithEvents lblNuevaContrase�a2 As System.Windows.Forms.Label
	Public WithEvents lblNuevaContrase�a As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblContrase�a As System.Windows.Forms.Label
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContrase�aCambiar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.txtNuevaContrase�a = New System.Windows.Forms.TextBox
		Me.txtContrase�a = New System.Windows.Forms.TextBox
		Me.txtNuevaContrase�a2 = New System.Windows.Forms.TextBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblNuevaContrase�a2 = New System.Windows.Forms.Label
		Me.lblNuevaContrase�a = New System.Windows.Forms.Label
		Me.lblContrase�a = New System.Windows.Forms.Label
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
		Me.Name = "frmContrase�aCambiar"
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
		Me.txtNuevaContrase�a.AutoSize = False
		Me.txtNuevaContrase�a.Size = New System.Drawing.Size(81, 19)
		Me.txtNuevaContrase�a.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNuevaContrase�a.Location = New System.Drawing.Point(176, 64)
		Me.txtNuevaContrase�a.Maxlength = 10
		Me.txtNuevaContrase�a.PasswordChar = ChrW(42)
		Me.txtNuevaContrase�a.TabIndex = 1
		Me.txtNuevaContrase�a.AcceptsReturn = True
		Me.txtNuevaContrase�a.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNuevaContrase�a.BackColor = System.Drawing.SystemColors.Window
		Me.txtNuevaContrase�a.CausesValidation = True
		Me.txtNuevaContrase�a.Enabled = True
		Me.txtNuevaContrase�a.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNuevaContrase�a.HideSelection = True
		Me.txtNuevaContrase�a.ReadOnly = False
		Me.txtNuevaContrase�a.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNuevaContrase�a.MultiLine = False
		Me.txtNuevaContrase�a.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNuevaContrase�a.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNuevaContrase�a.TabStop = True
		Me.txtNuevaContrase�a.Visible = True
		Me.txtNuevaContrase�a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNuevaContrase�a.Name = "txtNuevaContrase�a"
		Me.txtContrase�a.AutoSize = False
		Me.txtContrase�a.Size = New System.Drawing.Size(81, 19)
		Me.txtContrase�a.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtContrase�a.Location = New System.Drawing.Point(136, 16)
		Me.txtContrase�a.Maxlength = 10
		Me.txtContrase�a.PasswordChar = ChrW(42)
		Me.txtContrase�a.TabIndex = 0
		Me.txtContrase�a.AcceptsReturn = True
		Me.txtContrase�a.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtContrase�a.BackColor = System.Drawing.SystemColors.Window
		Me.txtContrase�a.CausesValidation = True
		Me.txtContrase�a.Enabled = True
		Me.txtContrase�a.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtContrase�a.HideSelection = True
		Me.txtContrase�a.ReadOnly = False
		Me.txtContrase�a.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtContrase�a.MultiLine = False
		Me.txtContrase�a.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtContrase�a.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtContrase�a.TabStop = True
		Me.txtContrase�a.Visible = True
		Me.txtContrase�a.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtContrase�a.Name = "txtContrase�a"
		Me.txtNuevaContrase�a2.AutoSize = False
		Me.txtNuevaContrase�a2.Size = New System.Drawing.Size(81, 19)
		Me.txtNuevaContrase�a2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtNuevaContrase�a2.Location = New System.Drawing.Point(176, 96)
		Me.txtNuevaContrase�a2.Maxlength = 10
		Me.txtNuevaContrase�a2.PasswordChar = ChrW(42)
		Me.txtNuevaContrase�a2.TabIndex = 2
		Me.txtNuevaContrase�a2.AcceptsReturn = True
		Me.txtNuevaContrase�a2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtNuevaContrase�a2.BackColor = System.Drawing.SystemColors.Window
		Me.txtNuevaContrase�a2.CausesValidation = True
		Me.txtNuevaContrase�a2.Enabled = True
		Me.txtNuevaContrase�a2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtNuevaContrase�a2.HideSelection = True
		Me.txtNuevaContrase�a2.ReadOnly = False
		Me.txtNuevaContrase�a2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNuevaContrase�a2.MultiLine = False
		Me.txtNuevaContrase�a2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtNuevaContrase�a2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtNuevaContrase�a2.TabStop = True
		Me.txtNuevaContrase�a2.Visible = True
		Me.txtNuevaContrase�a2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtNuevaContrase�a2.Name = "txtNuevaContrase�a2"
		Me.Frame1.Size = New System.Drawing.Size(265, 97)
		Me.Frame1.Location = New System.Drawing.Point(16, 40)
		Me.Frame1.TabIndex = 4
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.lblNuevaContrase�a2.Text = "Reentrar Nueva Contrase�a"
		Me.lblNuevaContrase�a2.Size = New System.Drawing.Size(153, 17)
		Me.lblNuevaContrase�a2.Location = New System.Drawing.Point(16, 56)
		Me.lblNuevaContrase�a2.TabIndex = 6
		Me.lblNuevaContrase�a2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNuevaContrase�a2.BackColor = System.Drawing.SystemColors.Control
		Me.lblNuevaContrase�a2.Enabled = True
		Me.lblNuevaContrase�a2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNuevaContrase�a2.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNuevaContrase�a2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNuevaContrase�a2.UseMnemonic = True
		Me.lblNuevaContrase�a2.Visible = True
		Me.lblNuevaContrase�a2.AutoSize = False
		Me.lblNuevaContrase�a2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNuevaContrase�a2.Name = "lblNuevaContrase�a2"
		Me.lblNuevaContrase�a.Text = "Nueva Contrase�a"
		Me.lblNuevaContrase�a.Size = New System.Drawing.Size(153, 17)
		Me.lblNuevaContrase�a.Location = New System.Drawing.Point(16, 24)
		Me.lblNuevaContrase�a.TabIndex = 5
		Me.lblNuevaContrase�a.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNuevaContrase�a.BackColor = System.Drawing.SystemColors.Control
		Me.lblNuevaContrase�a.Enabled = True
		Me.lblNuevaContrase�a.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNuevaContrase�a.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNuevaContrase�a.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNuevaContrase�a.UseMnemonic = True
		Me.lblNuevaContrase�a.Visible = True
		Me.lblNuevaContrase�a.AutoSize = False
		Me.lblNuevaContrase�a.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNuevaContrase�a.Name = "lblNuevaContrase�a"
		Me.lblContrase�a.Text = "Contrase�a"
		Me.lblContrase�a.Size = New System.Drawing.Size(81, 17)
		Me.lblContrase�a.Location = New System.Drawing.Point(48, 16)
		Me.lblContrase�a.TabIndex = 3
		Me.lblContrase�a.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblContrase�a.BackColor = System.Drawing.SystemColors.Control
		Me.lblContrase�a.Enabled = True
		Me.lblContrase�a.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblContrase�a.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblContrase�a.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblContrase�a.UseMnemonic = True
		Me.lblContrase�a.Visible = True
		Me.lblContrase�a.AutoSize = False
		Me.lblContrase�a.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblContrase�a.Name = "lblContrase�a"
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(txtNuevaContrase�a)
		Me.Controls.Add(txtContrase�a)
		Me.Controls.Add(txtNuevaContrase�a2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblContrase�a)
		Me.Frame1.Controls.Add(lblNuevaContrase�a2)
		Me.Frame1.Controls.Add(lblNuevaContrase�a)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class