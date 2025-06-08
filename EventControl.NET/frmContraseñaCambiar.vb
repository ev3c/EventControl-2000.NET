Option Strict Off
Option Explicit On
Friend Class frmContrase�aCambiar
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If txtContrase�a.Text = gstrContrase�a Then
			If txtNuevaContrase�a.Text = txtNuevaContrase�a2.Text Then
				If EC_SHAREWARE Then
					Select Case frmEventControl.cboIdioma.SelectedIndex
						Case EC_ESPA�OL
							MsgBox("Solamente puede cambiar la contrase�a " & "en la versi�n registrada de " & gstrPrograma, MsgBoxStyle.Information, "Cambiar Contrase�a Informaci�n")
						Case EC_ENGLISH
							MsgBox("Only can change the Password in the " & "registered version of " & gstrPrograma, MsgBoxStyle.Information, "Change Password Information")
						Case EC_CATALA
							MsgBox("Solsament pot cambiar la contrasenya " & "a la versi� registrada de " & gstrPrograma, MsgBoxStyle.Information, "Cambiar Contrasenya Informaci�")
					End Select
				Else
					
					gdb.NewPassword(gstrContrase�a, txtNuevaContrase�a.Text)
					gdbHistorial.NewPassword(gstrContrase�a, txtNuevaContrase�a.Text)
					
					gstrContrase�a = txtNuevaContrase�a.Text
					SaveSetting("EventControl", "Inicio", "gstrContrase�a", Contrase�a_Encriptar(gstrContrase�a))
					
				End If
				Me.Close()
			Else
				Select Case frmEventControl.cboIdioma.SelectedIndex
					Case EC_ESPA�OL
						MsgBox("La nueva contrase�a no coincide", MsgBoxStyle.Information, "Cambiar Contrase�a - Error")
					Case EC_ENGLISH
						MsgBox("The new password don't coincides", MsgBoxStyle.Information, "Change Password - Error")
					Case EC_CATALA
						MsgBox("La nova contrasenya no coincideix", MsgBoxStyle.Information, "Cambiar Contrasenya - Error")
				End Select
				txtNuevaContrase�a.Focus()
			End If
		Else
			
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPA�OL
					MsgBox("Contrase�a Erronea", MsgBoxStyle.Information, "Cambiar Contrase�a - Error")
				Case EC_ENGLISH
					MsgBox("Invalid Password", MsgBoxStyle.Information, "Change Password - Error")
				Case EC_CATALA
					MsgBox("Contrasenya Erronia", MsgBoxStyle.Information, "Cambiar Contrasenya - Error")
			End Select
			txtContrase�a.Focus()
			
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmContrase�aCambiar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				Me.Text = "Cambiar Contrase�a"
				lblContrase�a.Text = "Contrase�a"
				lblNuevaContrase�a.Text = "Nueva Contrase�a"
				lblNuevaContrase�a2.Text = "Reentrar nueva Contrase�a"
				cmdAceptar.Text = "&Aceptar"
				cmdCancelar.Text = "&Cancelar"
			Case EC_ENGLISH
				Me.Text = "Change Password"
				lblContrase�a.Text = "Password"
				lblNuevaContrase�a.Text = "New Password"
				lblNuevaContrase�a2.Text = "Re-entrer new Password"
				cmdAceptar.Text = "&Accept"
				cmdCancelar.Text = "&Cancel"
			Case EC_CATALA
				Me.Text = "Cambiar Contrasenya"
				lblContrase�a.Text = "Contrasenya"
				lblNuevaContrase�a.Text = "Nova Contrasenya"
				lblNuevaContrase�a2.Text = "Reentrar nova Contrasenya"
				cmdAceptar.Text = "&Acceptar"
				cmdCancelar.Text = "&Cancelar"
		End Select
	End Sub
	
	
	Private Sub txtContrase�a_()
		
	End Sub
	
	Private Sub txtContrase�a_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtContrase�a.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyz��" & "ABCDEFGHIJKLMNOPQRSTUVWXYZ��", Chr(KeyAscii)) = 0 Then
			If KeyAscii <> 8 Then
				KeyAscii = 0
				Beep()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtNuevaContrase�a_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaContrase�a.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyz��" & "ABCDEFGHIJKLMNOPQRSTUVWXYZ��", Chr(KeyAscii)) = 0 Then
			If KeyAscii <> 8 Then
				KeyAscii = 0
				Beep()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub txtNuevaContrase�a2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaContrase�a2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyz��" & "ABCDEFGHIJKLMNOPQRSTUVWXYZ��", Chr(KeyAscii)) = 0 Then
			If KeyAscii <> 8 Then
				KeyAscii = 0
				Beep()
			End If
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class