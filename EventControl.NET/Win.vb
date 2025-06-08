Option Strict Off
Option Explicit On
Module Win
	Public Const HWND_TOPMOST As Short = -1
	Public Const HWND_NOTOPMOST As Short = -2
	Public Const SWP_NOACTIVATE As Short = &H10s
	Public Const SWP_SHOWWINDOW As Short = &H40s
	Public Const SWP_NOMOVE As Short = &H2s
	Public Const SWP_NOZORDER As Short = &H4s
	Public Const SWP_NOSIZE As Short = &H1s
	
	
	Public Declare Sub SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer)
End Module