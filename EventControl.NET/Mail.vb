Option Strict Off
Option Explicit On
Module Mail
	Public Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
End Module