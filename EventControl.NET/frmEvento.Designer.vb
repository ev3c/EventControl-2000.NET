<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmEvento
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
	Public WithEvents dtpFechaDesde As AxMSComCtl2.AxDTPicker
	Public WithEvents cmdSalir As System.Windows.Forms.Button
	Public WithEvents cmdBorrar As System.Windows.Forms.Button
	Public WithEvents lstEvento As System.Windows.Forms.ListBox
	Public WithEvents dtpFechaHasta As AxMSComCtl2.AxDTPicker
	Public WithEvents lblFechaHasta As System.Windows.Forms.Label
	Public WithEvents lblFechaDesde As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents lblInfo0 As System.Windows.Forms.Label
	Public WithEvents lblInfo1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEvento))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.dtpFechaDesde = New AxMSComCtl2.AxDTPicker
		Me.cmdSalir = New System.Windows.Forms.Button
		Me.cmdBorrar = New System.Windows.Forms.Button
		Me.lstEvento = New System.Windows.Forms.ListBox
		Me.dtpFechaHasta = New AxMSComCtl2.AxDTPicker
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.lblFechaHasta = New System.Windows.Forms.Label
		Me.lblFechaDesde = New System.Windows.Forms.Label
		Me.lblInfo0 = New System.Windows.Forms.Label
		Me.lblInfo1 = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.ClientSize = New System.Drawing.Size(307, 230)
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
		Me.Name = "frmEvento"
		dtpFechaDesde.OcxState = CType(resources.GetObject("dtpFechaDesde.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpFechaDesde.Size = New System.Drawing.Size(89, 25)
		Me.dtpFechaDesde.Location = New System.Drawing.Point(40, 144)
		Me.dtpFechaDesde.TabIndex = 5
		Me.dtpFechaDesde.Name = "dtpFechaDesde"
		Me.cmdSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdSalir
		Me.cmdSalir.Text = "&Salir"
		Me.cmdSalir.Size = New System.Drawing.Size(89, 25)
		Me.cmdSalir.Location = New System.Drawing.Point(192, 72)
		Me.cmdSalir.TabIndex = 2
		Me.cmdSalir.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSalir.CausesValidation = True
		Me.cmdSalir.Enabled = True
		Me.cmdSalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSalir.TabStop = True
		Me.cmdSalir.Name = "cmdSalir"
		Me.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBorrar.Text = "&Borrar"
		Me.cmdBorrar.Size = New System.Drawing.Size(89, 25)
		Me.cmdBorrar.Location = New System.Drawing.Point(192, 32)
		Me.cmdBorrar.TabIndex = 1
		Me.cmdBorrar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBorrar.CausesValidation = True
		Me.cmdBorrar.Enabled = True
		Me.cmdBorrar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBorrar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBorrar.TabStop = True
		Me.cmdBorrar.Name = "cmdBorrar"
		Me.lstEvento.Size = New System.Drawing.Size(145, 72)
		Me.lstEvento.Location = New System.Drawing.Point(24, 32)
		Me.lstEvento.TabIndex = 0
		Me.lstEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstEvento.BackColor = System.Drawing.SystemColors.Window
		Me.lstEvento.CausesValidation = True
		Me.lstEvento.Enabled = True
		Me.lstEvento.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstEvento.IntegralHeight = True
		Me.lstEvento.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstEvento.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstEvento.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstEvento.Sorted = False
		Me.lstEvento.TabStop = True
		Me.lstEvento.Visible = True
		Me.lstEvento.MultiColumn = False
		Me.lstEvento.Name = "lstEvento"
		dtpFechaHasta.OcxState = CType(resources.GetObject("dtpFechaHasta.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpFechaHasta.Size = New System.Drawing.Size(89, 25)
		Me.dtpFechaHasta.Location = New System.Drawing.Point(176, 144)
		Me.dtpFechaHasta.TabIndex = 6
		Me.dtpFechaHasta.Name = "dtpFechaHasta"
		Me.Frame1.Size = New System.Drawing.Size(257, 73)
		Me.Frame1.Location = New System.Drawing.Point(24, 112)
		Me.Frame1.TabIndex = 7
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.lblFechaHasta.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblFechaHasta.Text = "=<  Hasta Fecha"
		Me.lblFechaHasta.Size = New System.Drawing.Size(89, 17)
		Me.lblFechaHasta.Location = New System.Drawing.Point(152, 16)
		Me.lblFechaHasta.TabIndex = 9
		Me.lblFechaHasta.BackColor = System.Drawing.SystemColors.Control
		Me.lblFechaHasta.Enabled = True
		Me.lblFechaHasta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFechaHasta.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFechaHasta.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFechaHasta.UseMnemonic = True
		Me.lblFechaHasta.Visible = True
		Me.lblFechaHasta.AutoSize = False
		Me.lblFechaHasta.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFechaHasta.Name = "lblFechaHasta"
		Me.lblFechaDesde.Text = "Desde Fecha  >="
		Me.lblFechaDesde.Size = New System.Drawing.Size(89, 17)
		Me.lblFechaDesde.Location = New System.Drawing.Point(16, 16)
		Me.lblFechaDesde.TabIndex = 8
		Me.lblFechaDesde.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFechaDesde.BackColor = System.Drawing.SystemColors.Control
		Me.lblFechaDesde.Enabled = True
		Me.lblFechaDesde.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFechaDesde.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFechaDesde.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFechaDesde.UseMnemonic = True
		Me.lblFechaDesde.Visible = True
		Me.lblFechaDesde.AutoSize = False
		Me.lblFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFechaDesde.Name = "lblFechaDesde"
		Me.lblInfo0.Text = "Eventos de:"
		Me.lblInfo0.Size = New System.Drawing.Size(105, 17)
		Me.lblInfo0.Location = New System.Drawing.Point(24, 16)
		Me.lblInfo0.TabIndex = 4
		Me.lblInfo0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInfo0.BackColor = System.Drawing.SystemColors.Control
		Me.lblInfo0.Enabled = True
		Me.lblInfo0.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInfo0.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInfo0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInfo0.UseMnemonic = True
		Me.lblInfo0.Visible = True
		Me.lblInfo0.AutoSize = False
		Me.lblInfo0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInfo0.Name = "lblInfo0"
		Me.lblInfo1.Text = "Para borrar los Eventos (Fecha, HoraOn y HoraOff)"
		Me.lblInfo1.Size = New System.Drawing.Size(257, 17)
		Me.lblInfo1.Location = New System.Drawing.Point(32, 200)
		Me.lblInfo1.TabIndex = 3
		Me.lblInfo1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblInfo1.BackColor = System.Drawing.SystemColors.Control
		Me.lblInfo1.Enabled = True
		Me.lblInfo1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblInfo1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblInfo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblInfo1.UseMnemonic = True
		Me.lblInfo1.Visible = True
		Me.lblInfo1.AutoSize = False
		Me.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblInfo1.Name = "lblInfo1"
		Me.Controls.Add(dtpFechaDesde)
		Me.Controls.Add(cmdSalir)
		Me.Controls.Add(cmdBorrar)
		Me.Controls.Add(lstEvento)
		Me.Controls.Add(dtpFechaHasta)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(lblInfo0)
		Me.Controls.Add(lblInfo1)
		Me.Frame1.Controls.Add(lblFechaHasta)
		Me.Frame1.Controls.Add(lblFechaDesde)
		CType(Me.dtpFechaHasta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dtpFechaDesde, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class