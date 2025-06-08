Option Strict Off
Option Explicit On
Module Contraseña
	Public Function Contraseña_Encriptar(ByRef sContraseña As String) As String
		Dim x As Object
		Dim sTemp As Object
		Dim sChr As String
		
		For x = 1 To Len(sContraseña)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sChr = Mid(sContraseña, x, 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTemp = sTemp + Chr(Asc(sChr) + 5 + x)
		Next x
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Contraseña_Encriptar = sTemp
	End Function
	
	Public Function Contraseña_DesEncriptar(ByRef sContraseña As String) As String
		Dim x As Object
		Dim sTemp As Object
		Dim sChr As String
		
		For x = 1 To Len(sContraseña)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sChr = Mid(sContraseña, x, 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sTemp = sTemp + Chr(Asc(sChr) - 5 - x)
		Next x
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto sTemp. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Contraseña_DesEncriptar = sTemp
	End Function
End Module