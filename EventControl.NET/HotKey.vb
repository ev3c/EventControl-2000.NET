Option Strict Off
Option Explicit On
Module HotKey
	Public Const GWL_WNDPROC As Short = (-4)
	Public Const WM_HOTKEY As Short = &H312s
	Public Const MOD_ALT As Short = &H1s
	Public Const MOD_CONTROL As Short = &H2s
	Public Const MOD_SHIFT As Short = &H4s
	
	Public Declare Function SetWindowLong Lib "user32"  Alias "SetWindowLongA"(ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
	Public Declare Function CallWindowProc Lib "user32"  Alias "CallWindowProcA"(ByVal lpPrevWndFunc As Integer, ByVal hwnd As Integer, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
	Public Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As Integer, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
	Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As Integer, ByVal id As Integer) As Integer
	
	Public Proc_Original As Integer
	
	Public Sub Subclasifica_Ventana(ByRef hwnd As Integer)
		If Proc_Original = 0 Then
			'UPGRADE_WARNING: Agregue un delegado para el operador AddressOf Mi_Proc Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
			Proc_Original = SetWindowLong(hwnd, GWL_WNDPROC, AddressOf Mi_Proc)
		End If
	End Sub
	
	Public Sub Ventana_Normal(ByRef hwnd As Integer)
		If Proc_Original <> 0 Then
			Call SetWindowLong(hwnd, GWL_WNDPROC, Proc_Original)
			Proc_Original = 0
		End If
	End Sub
	
	
	Public Function Mi_Proc(ByVal hw As Integer, ByVal uMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
		Dim strMsg As Object
		
		On Error GoTo errHandler
		
		If uMsg = WM_HOTKEY Then
			
			frmEventControl.Show()
			If frmEventControl.Contraseña_Entrar Then
				frmEventControl.VerControlTiempo_Actualizar()
			Else
				frmEventControl.Hide()
				'UPGRADE_ISSUE: App propiedad App.TaskVisible no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				App.TaskVisible = False
			End If
			
		Else
			Mi_Proc = CallWindowProc(Proc_Original, hw, uMsg, wParam, lParam)
		End If
		
		Exit Function
		
errHandler: 
		Select Case giIdioma
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg = "Había una subventana abierta"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg = "There was open a subwindow"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg = "Hi havia una subfinestra oberta"
		End Select
		MsgBox(strMsg, MsgBoxStyle.Information + MsgBoxStyle.SystemModal + MsgBoxStyle.MsgBoxSetForeground, gstrPrograma)
		
	End Function
End Module