Option Strict Off
Option Explicit On
Module URLAdress
	
	Public Structure ProcData
		Dim AppHwnd As Integer
		Dim title As String
		Dim Placement As String
		'UPGRADE_NOTE: Left se actualizó a Left_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Left_Renamed As Integer
		Dim Top As Integer
		'UPGRADE_NOTE: Right se actualizó a Right_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Right_Renamed As Integer
		Dim Bottom As Integer
	End Structure
	
	'UPGRADE_ISSUE: No se admite la declaración de un parámetro 'As Any'. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function EnumWindows Lib "user32" (ByVal lpEnumFunc As Any, ByVal lParam As Integer) As Integer
	
	Private Declare Function GetWindowText Lib "user32"  Alias "GetWindowTextA"(ByVal hwnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	
	Private Declare Function GetWindow Lib "user32" (ByVal hwnd As Integer, ByVal wCmd As Integer) As Integer
	Private Declare Function FindWindow Lib "user32"  Alias "FindWindowA"(ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
	Private Declare Function GetClassName Lib "user32"  Alias "GetClassNameA"(ByVal hwnd As Integer, ByVal lpClassName As String, ByVal nMaxCount As Integer) As Integer
	'UPGRADE_ISSUE: No se admite la declaración de un parámetro 'As Any'. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Private Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer
	
	Private Const WM_GETTEXT As Short = &HDs
	Private Const WM_GETTEXTLENGTH As Short = &HEs
	
	Private Const GW_CHILD As Short = 5
	Private Const GW_HWNDNEXT As Short = 2
	Private Const GW_HWNDFIRST As Short = 0
	
	Private iURL As Short
	
	' ***********************************************
	' If this window is of the Edit class, return
	' its contents. Otherwise search its children
	' for an Edit object.
	' ***********************************************
	Public Function EditInfo(ByRef window_hwnd As Integer) As String
		Dim txt As String
		Dim buf As String
		Dim buflen As Integer
		Dim child_hwnd As Integer
		Dim children() As Integer
		Dim num_children As Short
		Dim i As Short
		
		' Get the class name.
		buflen = 256
		buf = Space(buflen - 1)
		buflen = GetClassName(window_hwnd, buf, buflen)
		buf = Left(buf, buflen)
		
		' See if we found an Edit object.
		If buf = "Edit" Then
			EditInfo = WindowText(window_hwnd)
			Exit Function
		End If
		
		' It's not an Edit object. Search the children.
		' Make a list of the child windows.
		num_children = 0
		child_hwnd = GetWindow(window_hwnd, GW_CHILD)
		Do While child_hwnd <> 0
			num_children = num_children + 1
			'UPGRADE_WARNING: El límite inferior de la matriz children ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
			ReDim Preserve children(num_children)
			children(num_children) = child_hwnd
			
			child_hwnd = GetWindow(child_hwnd, GW_HWNDNEXT)
		Loop 
		
		' Get information on the child windows.
		For i = 1 To num_children
			txt = EditInfo(children(i))
			If txt <> "" Then
				Exit For
			End If
		Next i
		
		EditInfo = txt
	End Function
	' ************************************************
	' Return the text associated with the window.
	' ************************************************
	Public Function WindowText(ByRef window_hwnd As Integer) As String
		Dim txtlen As Integer
		Dim txt As String
		
		WindowText = ""
		If window_hwnd = 0 Then Exit Function
		
		txtlen = SendMessage(window_hwnd, WM_GETTEXTLENGTH, 0, 0)
		If txtlen = 0 Then Exit Function
		
		txtlen = txtlen + 1
		txt = Space(txtlen)
		txtlen = SendMessage(window_hwnd, WM_GETTEXT, txtlen, txt)
		WindowText = Left(txt, txtlen)
	End Function
	
	
	Public Function EnumProc(ByVal app_hwnd As Integer, ByVal lParam As Integer) As Boolean
		Dim buf As New VB6.FixedLengthString(1024)
		Dim title As String
		Dim length As Integer
		Dim strURLAdress As String
		Dim bSave As Boolean
		Dim iFirstPoint As Object
		Dim iSecondPoint As Short
		
		' Get the window's title.
		length = GetWindowText(app_hwnd, buf.Value, Len(buf.Value))
		title = Left(buf.Value, length)
		
		' See if the title ends with " - Netscape".
		If InStr(title, "- Netscape") Or InStr(title, "- Microsoft Internet Explorer") Then
			' This is it. Find the ComboBox information.
			
			strURLAdress = EditInfo(app_hwnd)
			bSave = True
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iFirstPoint. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			iFirstPoint = InStr(strURLAdress, ".")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iFirstPoint. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If iFirstPoint <> 0 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iFirstPoint. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iSecondPoint = InStr(iFirstPoint + 1, strURLAdress, ".")
			End If
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iFirstPoint. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Left(strURLAdress, 7) = "http://" And iFirstPoint <> 0 And iSecondPoint <> 0 Then
				
				gaURL(iURL) = strURLAdress
				iURL = iURL + 1
				
				'      Do While gaHistorial(x) <> ""
				'        If gaHistorial(x) = strURLAdress Then
				'          bSave = False
				'          Exit Do
				'        Else
				'          x = x + 1
				'        End If
				'      Loop
				'
				'      If bSave Then
				'        x = 0
				'        Do While gaHistorial(x) <> ""
				'           x = x + 1
				'        Loop
				'        gaHistorial(x) = strURLAdress
				'        Call frmEventControl.Evento_Historial_Grabar( _
				''             MyDate, Time, strURLAdress)
				'      End If
				
			End If
			
		End If
		
		'Continue search
		EnumProc = 1
		
	End Function
	' Start the enumeration.
	Public Sub GetURLAdress()
		Dim x As Object
		Dim y As Short
		Dim bDelete As Object
		Dim bAdd As Boolean
		
		'Redimensiona el array de las URL activas
		ReDim gaURL(999)
		iURL = 0
		
		'Lee las URL activas en gaURL()
		'UPGRADE_WARNING: Agregue un delegado para el operador AddressOf EnumProc Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="E9E157F7-EF0C-4016-87B7-7D7FBBC6EE08"'
		Call EnumWindows(AddressOf EnumProc, 0)
		
		
		'Comprobamos si cada dirección de Historial está en
		'gaURL activas, si no está la borramos de Historial
		Do 
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bDelete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bDelete = True 'borrar de historial si no está
			For y = 0 To iURL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If gaHistorial(x) = gaURL(y) Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bDelete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bDelete = False
				End If
			Next 
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bDelete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bDelete Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Array_Delete(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gaHistorial = Array_Delete(gaHistorial, x)
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = x + 1
			End If
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Loop While gaHistorial(x) <> ""
		
		
		'Comprueba si las URL de gaURL() están en gaHistorial
		'y si no están las Añade.
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = 0
		Do 
			bAdd = True
			y = 0
			Do 
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If gaURL(x) = gaHistorial(y) Then
					bAdd = False
				End If
				y = y + 1
			Loop While gaHistorial(y) <> ""
			
			If bAdd Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gaHistorial(y) = gaURL(x)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Call frmEventControl.Evento_Historial_Grabar(MyDate, TimeOfDay, gaURL(x))
			End If
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = x + 1
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Loop While gaURL(x) <> ""
		
	End Sub
	
	Private Function Array_Delete(ByRef lArray() As String, ByRef iPos As Object) As Object
		Dim x As Short
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = iPos
		Do 
			lArray(x) = lArray(x + 1)
			x = x + 1
		Loop While lArray(x) <> ""
		
		Array_Delete = VB6.CopyArray(lArray)
		
	End Function
End Module