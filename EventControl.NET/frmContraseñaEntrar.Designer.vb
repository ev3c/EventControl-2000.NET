<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmContrase�aEntrar
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
	Public WithEvents txtContrase�a As System.Windows.Forms.TextBox
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents cmdCancelar As System.Windows.Forms.Button
	Public WithEvents tmrContrase�a As System.Windows.Forms.Timer
	Public WithEvents lblContrase�a As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Dise�ador de Windows Forms.
	'No lo modifique con el editor de c�digo.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContrase�aEntrar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtContrase�a = New System.Windows.Forms.TextBox
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.cmdCancelar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.tmrContrase�a = New System.Windows.Forms.Timer(components)
		Me.lblContrase�a = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Entrar Contrase�a"
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
		Me.Name = "frmContrase�aEntrar"
		Me.txtContrase�a.AutoSize = False
		Me.txtContrase�a.Size = New System.Drawing.Size(81, 19)
		Me.txtContrase�a.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtContrase�a.Location = New System.Drawing.Point(168, 32)
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
		Me.tmrContrase�a.Enabled = False
		Me.tmrContrase�a.Interval = 1
		Me.lblContrase�a.Text = "Contrase�a"
		Me.lblContrase�a.Size = New System.Drawing.Size(81, 17)
		Me.lblContrase�a.Location = New System.Drawing.Point(40, 24)
		Me.lblContrase�a.TabIndex = 4
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
		Me.Controls.Add(txtContrase�a)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(cmdCancelar)
		Me.Controls.Add(Frame1)
		Me.Frame1.Controls.Add(lblContrase�a)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class