Option Strict Off
Option Explicit On
Friend Class frmContraseñaEntrar
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If txtContraseña.Text = gstrContraseña Then
			gblnContraseña = True
			Me.Close()
		Else
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPAÑOL
					MsgBox("Contraseña Erronea", MsgBoxStyle.Information, "Entrar Contraseña - Error")
				Case EC_ENGLISH
					MsgBox("Invalid Password", MsgBoxStyle.Information, "Enter Password - Error")
				Case EC_CATALA
					MsgBox("Contrasenya Erronia", MsgBoxStyle.Information, "Entrar Contraseña - Error")
			End Select
			txtContraseña.Focus()
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		gblnContraseña = False
		Me.Close()
	End Sub
	
	Private Sub frmContraseñaEntrar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		gblnContraseña = False
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				Me.Text = "Entrar Contraseña"
				lblContraseña.Text = "Contraseña"
				cmdAceptar.Text = "&Aceptar"
				cmdCancelar.Text = "&Cancelar"
			Case EC_ENGLISH
				Me.Text = "Enter Password"
				lblContraseña.Text = "Password"
				cmdAceptar.Text = "&Accept"
				cmdCancelar.Text = "&Cancel"
			Case EC_CATALA
				Me.Text = "Entrar Contrasenya"
				lblContraseña.Text = "Contrasenya"
				cmdAceptar.Text = "&Acceptar"
				cmdCancelar.Text = "&Cancelar"
		End Select
	End Sub
	
	Private Sub frmContraseñaEntrar_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		tmrContraseña.Enabled = False
	End Sub
	
	Private Sub tmrContraseña_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrContraseña.Tick
		
		tmrContraseña.Enabled = False
		Me.Close()
		
	End Sub
End Class