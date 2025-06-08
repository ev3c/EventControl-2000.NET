Option Strict Off
Option Explicit On
Module Declaraciones
	' Para que no pida contraseña si no autoarranque
	Public bolPrimerArranque As Boolean
	
	' Database y recorsets de EventControl.mdb
	Public gdb As DAO.Database
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsPrograma, antes de poder utilizarlas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsPrograma As DAO.Recordset
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsEvento, antes de poder utilizarlas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsEvento As DAO.Recordset
	
	' Database y recorsets de Historial
	Public gdbHistorial As DAO.Database
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsHistorial, antes de poder utilizarlas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsHistorial As DAO.Recordset
	
	' Array para guardar las url del dia
	Public gaURL() As String
	Public gaHistorial() As String
	
	
	Public Structure ecOnOff
		'UPGRADE_NOTE: On se actualizó a On_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim On_Renamed As Date 'Hora de arranque
		Dim Off As Date 'Hora de parada
	End Structure
	
	Public gaWin() As ecOnOff 'Evento Windows
	Public gaScr() As ecOnOff 'Evento Protector Pantalla
	Public gaMdm() As ecOnOff 'Evento Módem
	Public gaTmr() As ecOnOff 'Evento Cronometro
	Public gaPrg() As ecOnOff 'Evento Programa
	
	Public giWin As Short 'Indice para evento Windows
	Public giScr As Short 'Índice para evento Pantalla
	Public giMdm As Short 'Índice para evento Módem
	Public giTmr As Short 'Índice para evento Cronometro
	Public gnPrg As Short 'Índice para número Programa
	Public giPrg() As Short 'Indice para evento Programa
	
	Public gtWin As ecOnOff 'Temp último evento Windows
	Public gtScr As ecOnOff 'Temp último evento Screen
	Public gtMdm As ecOnOff 'Temp último evento Modem
	Public gtTmr As ecOnOff 'Temp último evento Cronometro
	Public gtPrg() As ecOnOff 'Temp últimos eventos Programas
	
	Public gdPrgDia() As Date 'Horas programas dia
	Public gdPrgMes() As Date 'Horas programas mes
	Public gdPrgAño() As Date 'Horas programas año
	
	' Fecha en que arranca el Programa EventControl
	Public gdFechaOn As Date
	
	'Para control de programas introducidos por el usuario
	Public gaPrograma(99, 2) As String
	
	Public gstrIconMsg As String 'Mensaje del Icono
	Public gstrPrograma As String 'Nombre y Versión de EventControl
	Public gstrContraseña As String 'Contraseña
	Public gblnContraseña As Boolean 'Contraseña correcta
	Public gstrFormatoFecha As String 'Formato de la fecha
	Public gblnCronoOn As Boolean 'Cronometro On/Off
	
	'Public garrFichero(99) As String  'Para guardar los programas activos
	
	Public Const EC_ESPAÑOL As Short = 0
	Public Const EC_ENGLISH As Short = 1
	Public Const EC_CATALA As Short = 2
	
	Public EC_SHAREWARE As Boolean 'True si coincide Encriptado
	Public gstrNumeroHD As String 'Para guardar Numero HD
	Public gstrNumeroRegistro As String 'Para guardar Num Encriptado
	Public gblnPausar As Boolean 'Pausar & Reactivar
	Public giIdioma As Short 'Para saber el Idioma
	
	Public MyDate As Date 'Fecha interna
End Module