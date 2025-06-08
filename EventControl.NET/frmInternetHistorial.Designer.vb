<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInternetHistorial
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
	Public WithEvents cmdBorrarHistorial As System.Windows.Forms.Button
	Public WithEvents cmdAceptar As System.Windows.Forms.Button
	Public WithEvents lstHistorial As System.Windows.Forms.ListBox
	Public WithEvents dtpFechaHistorial As AxMSComCtl2.AxDTPicker
	Public WithEvents lblFecha As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInternetHistorial))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdBorrarHistorial = New System.Windows.Forms.Button
		Me.cmdAceptar = New System.Windows.Forms.Button
		Me.lstHistorial = New System.Windows.Forms.ListBox
		Me.dtpFechaHistorial = New AxMSComCtl2.AxDTPicker
		Me.lblFecha = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.dtpFechaHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Internet Historial"
		Me.ClientSize = New System.Drawing.Size(600, 281)
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
		Me.Name = "frmInternetHistorial"
		Me.cmdBorrarHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdBorrarHistorial.Text = "Borrar Historial"
		Me.cmdBorrarHistorial.Size = New System.Drawing.Size(89, 25)
		Me.cmdBorrarHistorial.Location = New System.Drawing.Point(504, 72)
		Me.cmdBorrarHistorial.TabIndex = 2
		Me.cmdBorrarHistorial.BackColor = System.Drawing.SystemColors.Control
		Me.cmdBorrarHistorial.CausesValidation = True
		Me.cmdBorrarHistorial.Enabled = True
		Me.cmdBorrarHistorial.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdBorrarHistorial.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdBorrarHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdBorrarHistorial.TabStop = True
		Me.cmdBorrarHistorial.Name = "cmdBorrarHistorial"
		Me.cmdAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAceptar.Text = "&Aceptar"
		Me.cmdAceptar.Size = New System.Drawing.Size(89, 33)
		Me.cmdAceptar.Location = New System.Drawing.Point(504, 16)
		Me.cmdAceptar.TabIndex = 1
		Me.cmdAceptar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAceptar.CausesValidation = True
		Me.cmdAceptar.Enabled = True
		Me.cmdAceptar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAceptar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAceptar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAceptar.TabStop = True
		Me.cmdAceptar.Name = "cmdAceptar"
		Me.lstHistorial.Size = New System.Drawing.Size(489, 267)
		Me.lstHistorial.Location = New System.Drawing.Point(8, 8)
		Me.lstHistorial.TabIndex = 0
		Me.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstHistorial.BackColor = System.Drawing.SystemColors.Window
		Me.lstHistorial.CausesValidation = True
		Me.lstHistorial.Enabled = True
		Me.lstHistorial.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstHistorial.IntegralHeight = True
		Me.lstHistorial.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstHistorial.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lstHistorial.Sorted = False
		Me.lstHistorial.TabStop = True
		Me.lstHistorial.Visible = True
		Me.lstHistorial.MultiColumn = False
		Me.lstHistorial.Name = "lstHistorial"
		dtpFechaHistorial.OcxState = CType(resources.GetObject("dtpFechaHistorial.OcxState"), System.Windows.Forms.AxHost.State)
		Me.dtpFechaHistorial.Size = New System.Drawing.Size(89, 25)
		Me.dtpFechaHistorial.Location = New System.Drawing.Point(504, 136)
		Me.dtpFechaHistorial.TabIndex = 3
		Me.dtpFechaHistorial.Name = "dtpFechaHistorial"
		Me.lblFecha.Text = "Fecha Historial:"
		Me.lblFecha.Size = New System.Drawing.Size(81, 17)
		Me.lblFecha.Location = New System.Drawing.Point(504, 120)
		Me.lblFecha.TabIndex = 4
		Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFecha.BackColor = System.Drawing.SystemColors.Control
		Me.lblFecha.Enabled = True
		Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFecha.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFecha.UseMnemonic = True
		Me.lblFecha.Visible = True
		Me.lblFecha.AutoSize = False
		Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblFecha.Name = "lblFecha"
		Me.Controls.Add(cmdBorrarHistorial)
		Me.Controls.Add(cmdAceptar)
		Me.Controls.Add(lstHistorial)
		Me.Controls.Add(dtpFechaHistorial)
		Me.Controls.Add(lblFecha)
		CType(Me.dtpFechaHistorial, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class