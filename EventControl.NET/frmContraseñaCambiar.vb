Option Strict Off
Option Explicit On
Friend Class frmContraseñaCambiar
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		If txtContraseña.Text = gstrContraseña Then
			If txtNuevaContraseña.Text = txtNuevaContraseña2.Text Then
				If EC_SHAREWARE Then
					Select Case frmEventControl.cboIdioma.SelectedIndex
						Case EC_ESPAÑOL
							MsgBox("Solamente puede cambiar la contraseña " & "en la versión registrada de " & gstrPrograma, MsgBoxStyle.Information, "Cambiar Contraseña Información")
						Case EC_ENGLISH
							MsgBox("Only can change the Password in the " & "registered version of " & gstrPrograma, MsgBoxStyle.Information, "Change Password Information")
						Case EC_CATALA
							MsgBox("Solsament pot cambiar la contrasenya " & "a la versió registrada de " & gstrPrograma, MsgBoxStyle.Information, "Cambiar Contrasenya Informació")
					End Select
				Else
					
					gdb.NewPassword(gstrContraseña, txtNuevaContraseña.Text)
					gdbHistorial.NewPassword(gstrContraseña, txtNuevaContraseña.Text)
					
					gstrContraseña = txtNuevaContraseña.Text
					SaveSetting("EventControl", "Inicio", "gstrContraseña", Contraseña_Encriptar(gstrContraseña))
					
				End If
				Me.Close()
			Else
				Select Case frmEventControl.cboIdioma.SelectedIndex
					Case EC_ESPAÑOL
						MsgBox("La nueva contraseña no coincide", MsgBoxStyle.Information, "Cambiar Contraseña - Error")
					Case EC_ENGLISH
						MsgBox("The new password don't coincides", MsgBoxStyle.Information, "Change Password - Error")
					Case EC_CATALA
						MsgBox("La nova contrasenya no coincideix", MsgBoxStyle.Information, "Cambiar Contrasenya - Error")
				End Select
				txtNuevaContraseña.Focus()
			End If
		Else
			
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPAÑOL
					MsgBox("Contraseña Erronea", MsgBoxStyle.Information, "Cambiar Contraseña - Error")
				Case EC_ENGLISH
					MsgBox("Invalid Password", MsgBoxStyle.Information, "Change Password - Error")
				Case EC_CATALA
					MsgBox("Contrasenya Erronia", MsgBoxStyle.Information, "Cambiar Contrasenya - Error")
			End Select
			txtContraseña.Focus()
			
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		Me.Close()
	End Sub
	
	Private Sub frmContraseñaCambiar_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				Me.Text = "Cambiar Contraseña"
				lblContraseña.Text = "Contraseña"
				lblNuevaContraseña.Text = "Nueva Contraseña"
				lblNuevaContraseña2.Text = "Reentrar nueva Contraseña"
				cmdAceptar.Text = "&Aceptar"
				cmdCancelar.Text = "&Cancelar"
			Case EC_ENGLISH
				Me.Text = "Change Password"
				lblContraseña.Text = "Password"
				lblNuevaContraseña.Text = "New Password"
				lblNuevaContraseña2.Text = "Re-entrer new Password"
				cmdAceptar.Text = "&Accept"
				cmdCancelar.Text = "&Cancel"
			Case EC_CATALA
				Me.Text = "Cambiar Contrasenya"
				lblContraseña.Text = "Contrasenya"
				lblNuevaContraseña.Text = "Nova Contrasenya"
				lblNuevaContraseña2.Text = "Reentrar nova Contrasenya"
				cmdAceptar.Text = "&Acceptar"
				cmdCancelar.Text = "&Cancelar"
		End Select
	End Sub
	
	
	Private Sub txtContraseña_()
		
	End Sub
	
	Private Sub txtContraseña_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyzñç" & "ABCDEFGHIJKLMNOPQRSTUVWXYZÑÇ", Chr(KeyAscii)) = 0 Then
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
	Private Sub txtNuevaContraseña_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaContraseña.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyzñç" & "ABCDEFGHIJKLMNOPQRSTUVWXYZÑÇ", Chr(KeyAscii)) = 0 Then
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
	Private Sub txtNuevaContraseña2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtNuevaContraseña2.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If InStr("0123456789" & "abcdefghijklmnopqrstuvwxyzñç" & "ABCDEFGHIJKLMNOPQRSTUVWXYZÑÇ", Chr(KeyAscii)) = 0 Then
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