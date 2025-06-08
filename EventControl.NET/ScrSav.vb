Option Strict Off
Option Explicit On
Module ScrSav
	
	Public Declare Function TerminateProcess Lib "Kernel32" (ByVal hProcess As Integer, ByVal uExitCode As Integer) As Integer
	
	'Constants used by the API functions
	Const WM_CLOSE As Short = &H10s
	Const WM_DESTROY As Short = &H2s
	
	
	'UPGRADE_WARNING: La estructura PROCESSENTRY32 puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function Process32First Lib "Kernel32" (ByVal hSnapshot As Integer, ByRef lppe As PROCESSENTRY32) As Integer
	
	'UPGRADE_WARNING: La estructura PROCESSENTRY32 puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function Process32Next Lib "Kernel32" (ByVal hSnapshot As Integer, ByRef lppe As PROCESSENTRY32) As Integer
	
	Declare Function CloseHandle Lib "Kernel32" (ByVal Handle As Integer) As Integer
	
	Declare Function OpenProcess Lib "Kernel32" (ByVal dwDesiredAccessas As Integer, ByVal bInheritHandle As Integer, ByVal dwProcId As Integer) As Integer
	
	Declare Function EnumProcesses Lib "psapi.dll" (ByRef lpidProcess As Integer, ByVal cb As Integer, ByRef cbNeeded As Integer) As Integer
	
	Declare Function GetModuleFileNameExA Lib "psapi.dll" (ByVal hProcess As Integer, ByVal hModule As Integer, ByVal ModuleName As String, ByVal nSize As Integer) As Integer
	
	Declare Function EnumProcessModules Lib "psapi.dll" (ByVal hProcess As Integer, ByRef lphModule As Integer, ByVal cb As Integer, ByRef cbNeeded As Integer) As Integer
	
	Declare Function CreateToolhelp32Snapshot Lib "Kernel32" (ByVal dwFlags As Integer, ByVal th32ProcessID As Integer) As Integer
	
	'UPGRADE_WARNING: La estructura OSVERSIONINFO puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="C429C3A5-5D47-4CD9-8F51-74A1616405DC"'
	Declare Function GetVersionExA Lib "Kernel32" (ByRef lpVersionInformation As OSVERSIONINFO) As Short
	
	Structure PROCESSENTRY32
		Dim dwSize As Integer
		Dim cntUsage As Integer
		Dim th32ProcessID As Integer ' This process
		Dim th32DefaultHeapID As Integer
		Dim th32ModuleID As Integer ' Associated exe
		Dim cntThreads As Integer
		Dim th32ParentProcessID As Integer ' This process's parent process
		Dim pcPriClassBase As Integer ' Base priority of process threads
		Dim dwFlags As Integer
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(260),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=260)> Public szExeFile() As Char ' MAX_PATH
	End Structure
	
	Structure OSVERSIONINFO
		Dim dwOSVersionInfoSize As Integer
		Dim dwMajorVersion As Integer
		Dim dwMinorVersion As Integer
		Dim dwBuildNumber As Integer
		Dim dwPlatformId As Integer '1 = Windows 95.
		'2 = Windows NT
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(128),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=128)> Public szCSDVersion() As Char
	End Structure
	
	Const PROCESS_QUERY_INFORMATION As Short = 1024
	Const PROCESS_VM_READ As Short = 16
	Const MAX_PATH As Short = 260
	Const STANDARD_RIGHTS_REQUIRED As Integer = &HF0000
	Const SYNCHRONIZE As Integer = &H100000
	'STANDARD_RIGHTS_REQUIRED Or SYNCHRONIZE Or &HFFF
	Const PROCESS_ALL_ACCESS As Integer = &H1F0FFF
	Const TH32CS_SNAPPROCESS As Integer = &H2
	Const hNull As Short = 0
	
	Function StrZToStr(ByRef s As String) As String
		StrZToStr = Left(s, InStr(s, Chr(0)) - 1)
	End Function
	
	Public Function getVersion() As Integer
		Dim osinfo As OSVERSIONINFO
		Dim retvalue As Short
		osinfo.dwOSVersionInfoSize = 148
		osinfo.szCSDVersion = Space(128)
		retvalue = GetVersionExA(osinfo)
		getVersion = osinfo.dwPlatformId
	End Function
	
	Function GetWinFiles() As Object
		Dim lRetX As Object
		Dim arrFichero(99) As String
		Dim intFichero As Short
		
		On Error GoTo GetWinFiles_Err
		
		Dim cb As Integer
		Dim cbNeeded As Integer
		Dim NumElements As Integer
		Dim ProcessIDs() As Integer
		Dim cbNeeded2 As Integer
		Dim NumElements2 As Integer
		Dim lRet As Integer
		Dim ModuleName As String
		Dim nSize As Integer
		Dim hProcess As Integer
		Dim i As Integer
		'UPGRADE_WARNING: El límite inferior de la matriz Modules ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Modules(200) As Integer
		Dim hSnap As Integer
		Dim proc As PROCESSENTRY32
		Dim f As Integer
		Dim sname As String
		Select Case getVersion()
			
			Case 1 'Windows 95/98
				
				hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0)
				If hSnap = hNull Then Exit Function
				proc.dwSize = Len(proc)
				
				' Iterate through the processes
				f = Process32First(hSnap, proc)
				
				Do While f
					sname = StrZToStr(proc.szExeFile)
					arrFichero(intFichero) = sname
					intFichero = intFichero + 1
					f = Process32Next(hSnap, proc)
				Loop 
				
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lRetX. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lRetX = CloseHandle(hSnap)
				
			Case Else 'Windows NT
				
				'Get the array containing the process id's for each process  object
				cb = 8
				cbNeeded = 96
				Do While cb <= cbNeeded
					cb = cb * 2
					ReDim ProcessIDs(cb / 4)
					lRet = EnumProcesses(ProcessIDs(1), cb, cbNeeded)
				Loop 
				NumElements = cbNeeded / 4
				
				For i = 1 To NumElements
					'Get a handle to the Process
					hProcess = OpenProcess(PROCESS_QUERY_INFORMATION Or PROCESS_VM_READ, 0, ProcessIDs(i))
					'Got a Process handle
					If hProcess <> 0 Then
						'Get an array of the module handles for the specified
						'process
						lRet = EnumProcessModules(hProcess, Modules(1), 200, cbNeeded2)
						'If the Module Array is retrieved, Get the ModuleFileName
						If lRet <> 0 Then
							ModuleName = Space(MAX_PATH)
							nSize = 500
							lRet = GetModuleFileNameExA(hProcess, Modules(1), ModuleName, nSize)
							sname = Left(ModuleName, lRet)
							'sname = StrZToStr(sname)
							arrFichero(intFichero) = sname
							intFichero = intFichero + 1
						End If
					End If
					'Close the handle to the process
					lRet = CloseHandle(hProcess)
				Next 
				
		End Select
		
		arrFichero(intFichero) = ""
		GetWinFiles = VB6.CopyArray(arrFichero)
		
GetWinFiles_Err: 
		
	End Function
	
	Public Sub ControlEventos(ByRef IsScrSavOn As Boolean, ByRef IsPrgOn() As Boolean)
		Dim intPrograma As Object
		Dim arrFichero() As String
		Dim intFichero As Short
		
		IsScrSavOn = False
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto GetWinFiles. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arrFichero = GetWinFiles
		'Call GetWinFiles
		
		Do 
			If Right(UCase(arrFichero(intFichero)), 4) = ".SCR" Then
				IsScrSavOn = True
				Exit Do
			End If
			intFichero = intFichero + 1
		Loop While arrFichero(intFichero) <> ""
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intPrograma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Do While gaPrograma(intPrograma, 1) <> ""
			intFichero = 0
			Do 
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intPrograma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If UCase(arrFichero(intFichero)) = UCase(gaPrograma(intPrograma, 1)) Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intPrograma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					IsPrgOn(intPrograma) = True
					Exit Do
				End If
				intFichero = intFichero + 1
			Loop While arrFichero(intFichero) <> ""
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intPrograma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			intPrograma = intPrograma + 1
		Loop 
		
	End Sub
	
	Public Sub Programa_Apagar(ByRef sPath As String)
		Dim lRetX As Object
		
		On Error GoTo Programa_Apagar_Err
		
		
		Dim hProc As Integer
		Dim cb As Integer
		Dim cbNeeded As Integer
		Dim NumElements As Integer
		Dim ProcessIDs() As Integer
		Dim cbNeeded2 As Integer
		Dim NumElements2 As Integer
		Dim lRet As Integer
		Dim ModuleName As String
		Dim nSize As Integer
		Dim i As Integer
		Dim hProcess As Object
		Dim hProcess2 As Integer
		'UPGRADE_WARNING: El límite inferior de la matriz Modules ha cambiado de 1 a 0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
		Dim Modules(200) As Integer
		Dim hSnap As Integer
		Dim proc As PROCESSENTRY32
		Dim f As Integer
		Dim sname As String
		Select Case getVersion()
			
			Case 1 'Windows 95/98
				
				hSnap = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0)
				If hSnap = hNull Then Exit Sub
				proc.dwSize = Len(proc)
				
				' Iterate through the processes
				f = Process32First(hSnap, proc)
				
				Do While f
					sname = StrZToStr(proc.szExeFile)
					hProc = OpenProcess(0, 0, proc.th32ProcessID)
					If UCase(sPath) = UCase(sname) Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lRetX. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lRetX = TerminateProcess(hProc, 0)
					End If
					f = Process32Next(hSnap, proc)
				Loop 
				
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lRetX. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lRetX = CloseHandle(hSnap)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lRetX. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				lRetX = CloseHandle(hProc)
				
			Case Else 'Windows NT
				
				'Get the array containing the process id's for each process  object
				cb = 8
				cbNeeded = 96
				Do While cb <= cbNeeded
					cb = cb * 2
					ReDim ProcessIDs(cb / 4)
					lRet = EnumProcesses(ProcessIDs(1), cb, cbNeeded)
				Loop 
				NumElements = cbNeeded / 4
				
				For i = 1 To NumElements
					'Get a handle to the Process
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto hProcess. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					hProcess = OpenProcess(PROCESS_QUERY_INFORMATION Or PROCESS_VM_READ, 0, ProcessIDs(i))
					'Got a Process handle
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto hProcess. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If hProcess <> 0 Then
						'Get an array of the module handles for the specified
						'process
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto hProcess. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						lRet = EnumProcessModules(hProcess, Modules(1), 200, cbNeeded2)
						'If the Module Array is retrieved, Get the ModuleFileName
						If lRet <> 0 Then
							ModuleName = Space(MAX_PATH)
							nSize = 500
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto hProcess. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							lRet = GetModuleFileNameExA(hProcess, Modules(1), ModuleName, nSize)
							sname = Left(ModuleName, lRet)
							'sname = StrZToStr(sname)
							hProcess2 = OpenProcess(PROCESS_ALL_ACCESS, 0, ProcessIDs(i))
							If UCase(sPath) = UCase(sname) Then
								lRet = TerminateProcess(hProcess2, 0)
							End If
						End If
					End If
					'Close the handle to the process
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto hProcess. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					lRet = CloseHandle(hProcess)
					lRet = CloseHandle(hProcess2)
				Next 
				
		End Select
		
Programa_Apagar_Err: 
		
	End Sub
End Module