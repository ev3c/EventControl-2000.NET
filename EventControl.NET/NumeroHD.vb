Option Strict Off
Option Explicit On
Module NumeroHD
	'---------------------------------------------------------------------------
	'Form de prueba para leer la etiqueta y el número de serie de un disco.
	'                                                                (18/Feb/97)
	'---------------------------------------------------------------------------
	
	'Declaración de la función, sólo está en el API de 32 bits
	'
	Private Declare Function GetVolumeInformation Lib "Kernel32"  Alias "GetVolumeInformationA"(ByVal lpRootPathName As String, ByVal lpVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
	
	
	Public Function LeerNumeroHD(ByRef strUnidad As String) As String
		Dim lVSN, n As Integer
		Dim s1, s2 As String
		Dim unidad As String
		Dim sTmp As String
		
		On Error Resume Next
		
		'Se debe especificar el directorio raiz
		unidad = Trim(strUnidad)
		
		'Reservar espacio para las cadenas que se pasarán al API
		s1 = New String(Chr(0), 255)
		s2 = New String(Chr(0), 255)
		n = GetVolumeInformation(unidad, s1, Len(s1), lVSN, 0, 0, s2, Len(s2))
		's1 será la etiqueta del volumen
		'lVSN tendrá el valor del Volume Serial Number (número de serie del volumen)
		's2 el tipo de archivos: FAT, etc.
		
		'Convertirlo a hexadecimal para mostrarlo como en el Dir.
		sTmp = Hex(lVSN)
		
		LeerNumeroHD = Trim(sTmp)
		
	End Function
	
	
	Public Function Encriptar(ByRef strNumeroHD As String) As String
		Dim x, iNum As Object
		Dim iASC As Short
		Dim sLetra As String
		
		For x = 1 To Len(strNumeroHD)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto x. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			sLetra = Mid(strNumeroHD, x, 1)
			iASC = Asc(sLetra)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iNum. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			iNum = iNum + iASC
		Next x
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iNum. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iNum = iNum * 1234567
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iNum. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Encriptar = Hex(iNum)
		
	End Function
End Module