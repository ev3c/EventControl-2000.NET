Option Strict Off
Option Explicit On
Module Contrase�a
	Public Function Contrase�a_Encriptar(ByRef sContrase�a As String) As String
		Dim x As Object
		Dim sTemp As Object
		Dim sChr As String
		
		For x = 1 To Len(sContrase�a)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sChr = Mid(sContrase�a, x, 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTemp = sTemp + Chr(Asc(sChr) + 5 + x)
		Next x
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Contrase�a_Encriptar = sTemp
	End Function
	
	Public Function Contrase�a_DesEncriptar(ByRef sContrase�a As String) As String
		Dim x As Object
		Dim sTemp As Object
		Dim sChr As String
		
		For x = 1 To Len(sContrase�a)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sChr = Mid(sContrase�a, x, 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTemp = sTemp + Chr(Asc(sChr) - 5 - x)
		Next x
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Contrase�a_DesEncriptar = sTemp
	End Function
End Module