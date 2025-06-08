Option Strict Off
Option Explicit On
Module NotIcon
	' estructura que usa la funcion  Shell_NotifyIcon
	Structure NOTIFYICONDATA
		Dim cbSize As Integer
		Dim hwnd As Integer
		Dim uID As Integer
		Dim uFlags As Integer
		Dim uCallbackMessage As Integer
		Dim hIcon As Integer
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(64),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=64)> Public szTip() As Char
	End Structure
	' Flags para NOTIFYICONDATA
	Public Const NIF_MESSAGE As Short = &H1s
	Public Const NIF_ICON As Short = &H2s
	Public Const NIF_TIP As Short = &H4s
	
	' comandos que procesa  Shell_NotifyIcon
	Public Const NIM_ADD As Short = &H0s
	Public Const NIM_MODIFY As Short = &H1s
	Public Const NIM_DELETE As Short = &H2s
	' funcion   Shell_NotifyIcon
	'UPGRADE_WARNING: La estructura NOTIFYICONDATA puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Sub Shell_NotifyIcon Lib "shell32.dll"  Alias "Shell_NotifyIconA"(ByVal dwMessage As Integer, ByRef lpData As NOTIFYICONDATA)
	' funcion para copiar string
	Declare Sub lstrcpyn Lib "kernel32"  Alias "lstrcpynA"(ByVal lpString1 As String, ByVal lpString2 As String, ByVal size As Integer)
	' eventos del mouse
	Public Const WM_MOUSEFIRST As Short = &H200s
	Public Const WM_MOUSEMOVE As Short = &H200s
	Public Const WM_LBUTTONDOWN As Short = &H201s
	Public Const WM_LBUTTONUP As Short = &H202s
	Public Const WM_LBUTTONDBLCLK As Short = &H203s
	Public Const WM_RBUTTONDOWN As Short = &H204s
	Public Const WM_RBUTTONUP As Short = &H205s
	Public Const WM_RBUTTONDBLCLK As Short = &H206s
	Public Const WM_MBUTTONDOWN As Short = &H207s
	Public Const WM_MBUTTONUP As Short = &H208s
	Public Const WM_MBUTTONDBLCLK As Short = &H209s
	Public Const WM_MOUSELAST As Short = &H209s
	' Global, solo usamos un icono
	'UPGRADE_NOTE: NotIcon se actualizó a NotIcon_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Dim NotIcon_Renamed As NOTIFYICONDATA
	Sub IconModify(ByRef ico As Integer)
		NotIcon_Renamed.hIcon = ico
		Shell_NotifyIcon(NIM_MODIFY, NotIcon_Renamed)
	End Sub
	
	Sub IconDelete()
		Shell_NotifyIcon(NIM_DELETE, NotIcon_Renamed)
	End Sub
	
	Sub IconAdd(ByRef hwnd As Integer, ByRef ico As Integer, ByRef tip As String)
		NotIcon_Renamed.cbSize = 88
		NotIcon_Renamed.hwnd = hwnd
		NotIcon_Renamed.uID = 1
		NotIcon_Renamed.uFlags = NIF_ICON + NIF_MESSAGE + NIF_TIP
		NotIcon_Renamed.uCallbackMessage = WM_MOUSEMOVE
		NotIcon_Renamed.hIcon = ico
		lstrcpyn(NotIcon_Renamed.szTip, tip, 63)
		Shell_NotifyIcon(NIM_ADD, NotIcon_Renamed)
	End Sub
End Module