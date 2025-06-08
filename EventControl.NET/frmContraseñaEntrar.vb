Option Strict Off
Option Explicit On
Friend Class frmContrase�aEntrar
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If txtContrase�a.Text = gstrContrase�a Then
			gblnContrase�a = True
			Me.Close()
		Else
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPA�OL
					MsgBox("Contrase�a Erronea", MsgBoxStyle.Information, "Entrar Contrase�a - Error")
				Case EC_ENGLISH
					MsgBox("Invalid Password", MsgBoxStyle.Information, "Enter Password - Error")
				Case EC_CATALA
					MsgBox("Contrasenya Erronia", MsgBoxStyle.Information, "Entrar Contrase�a - Error")
			End Select
			txtContrase�a.Focus()
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		gblnContrase�a = False
		Me.Close()
	End Sub
	
	Private Sub frmContrase�aEntrar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		gblnContrase�a = False
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				Me.Text = "Entrar Contrase�a"
				lblContrase�a.Text = "Contrase�a"
				cmdAceptar.Text = "&Aceptar"
				cmdCancelar.Text = "&Cancelar"
			Case EC_ENGLISH
				Me.Text = "Enter Password"
				lblContrase�a.Text = "Password"
				cmdAceptar.Text = "&Accept"
				cmdCancelar.Text = "&Cancel"
			Case EC_CATALA
				Me.Text = "Entrar Contrasenya"
				lblContrase�a.Text = "Contrasenya"
				cmdAceptar.Text = "&Acceptar"
				cmdCancelar.Text = "&Cancelar"
		End Select
	End Sub
	
	Private Sub frmContrase�aEntrar_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		tmrContrase�a.Enabled = False
	End Sub
	
	Private Sub tmrContrase�a_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmrContrase�a.Tick
		
		tmrContrase�a.Enabled = False
		Me.Close()
		
	End Sub
End Class