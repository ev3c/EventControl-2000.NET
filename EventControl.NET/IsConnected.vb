Option Strict Off
Option Explicit On
Module mdm
	
	'UPGRADE_ISSUE: No se admite la declaración de un parámetro 'As Any'. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Public Declare Function RasEnumConnections Lib "RasApi32.dll"  Alias "RasEnumConnectionsA"(ByRef lpRasCon As Any, ByRef lpcb As Integer, ByRef lpcConnections As Integer) As Integer
	'UPGRADE_ISSUE: No se admite la declaración de un parámetro 'As Any'. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Public Declare Function RasGetConnectStatus Lib "RasApi32.dll"  Alias "RasGetConnectStatusA"(ByVal hRasCon As Integer, ByRef lpStatus As Any) As Integer
	
	Public Const RAS95_MaxEntryName As Short = 256
	Public Const RAS95_MaxDeviceType As Short = 16
	Public Const RAS95_MaxDeviceName As Short = 32
	
	Public Structure RASCONN95
		Dim dwSize As Integer
		Dim hRasCon As Integer
		<VBFixedArray(RAS95_MaxEntryName)> Dim szEntryName() As Byte
		<VBFixedArray(RAS95_MaxDeviceType)> Dim szDeviceType() As Byte
		<VBFixedArray(RAS95_MaxDeviceName)> Dim szDeviceName() As Byte
		
		'UPGRADE_TODO: Se debe llamar a "Initialize" para inicializar instancias de esta estructura. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim szEntryName(RAS95_MaxEntryName)
			ReDim szDeviceType(RAS95_MaxDeviceType)
			ReDim szDeviceName(RAS95_MaxDeviceName)
		End Sub
	End Structure
	
	Public Structure RASCONNSTATUS95
		Dim dwSize As Integer
		Dim RasConnState As Integer
		Dim dwError As Integer
		<VBFixedArray(RAS95_MaxDeviceType)> Dim szDeviceType() As Byte
		<VBFixedArray(RAS95_MaxDeviceName)> Dim szDeviceName() As Byte
		
		'UPGRADE_TODO: Se debe llamar a "Initialize" para inicializar instancias de esta estructura. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B4BFF9E0-8631-45CF-910E-62AB3970F27B"'
		Public Sub Initialize()
			ReDim szDeviceType(RAS95_MaxDeviceType)
			ReDim szDeviceName(RAS95_MaxDeviceName)
		End Sub
	End Structure
	Public Function IsConnected() As Boolean
		'UPGRADE_WARNING: Es posible que la matriz TRasCon necesite tener elementos individuales inicializados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B97B714D-9338-48AC-B03F-345B617E2B02"'
		Dim TRasCon(255) As RASCONN95
		Dim lg As Integer
		Dim lpcon As Integer
		Dim ResVal As Integer
		'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura Tstatus, antes de poder utilizarlas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim Tstatus As RASCONNSTATUS95
		
		On Error GoTo NoModem
		
		TRasCon(0).dwSize = 412
		lg = 256 * TRasCon(0).dwSize
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto TRasCon(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ResVal = RasEnumConnections(TRasCon(0), lg, lpcon)
		If ResVal <> 0 Then
			IsConnected = False
			Exit Function
		End If
		
		Tstatus.dwSize = 160
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Tstatus. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ResVal = RasGetConnectStatus(TRasCon(0).hRasCon, Tstatus)
		If Tstatus.RasConnState = &H2000s Then
			IsConnected = True
		Else
			IsConnected = False
		End If
		
		Exit Function
		
		
		'Si no hi ha RasApi
NoModem: 
		
	End Function
End Module