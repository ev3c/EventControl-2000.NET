Option Strict Off
Option Explicit On
Module msdos
	'// Declaraciones
	Private Declare Function GetShortPathName Lib "kernel32"  Alias "GetShortPathNameA"(ByVal lpszLongPath As String, ByVal lpszShortPath As String, ByVal cchBuffer As Integer) As Integer
	
	'// Funcion
	Public Function NombreCorto(ByRef sNombreLargo As String) As String
		Dim sNombreCorto As New VB6.FixedLengthString(255)
		GetShortPathName(sNombreLargo, sNombreCorto.Value, 255)
		NombreCorto = sNombreCorto.Value
	End Function
End Module