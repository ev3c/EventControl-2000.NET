Option Strict Off
Option Explicit On
Module Declaraciones
	' Para que no pida contrase�a si no autoarranque
	Public bolPrimerArranque As Boolean
	
	' Database y recorsets de EventControl.mdb
	Public gdb As DAO.Database
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsPrograma, antes de poder utilizarlas. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsPrograma As DAO.Recordset
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsEvento, antes de poder utilizarlas. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsEvento As DAO.Recordset
	
	' Database y recorsets de Historial
	Public gdbHistorial As DAO.Database
	'UPGRADE_WARNING: Puede que necesite inicializar las matrices de la estructura grsHistorial, antes de poder utilizarlas. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
	Public grsHistorial As DAO.Recordset
	
	' Array para guardar las url del dia
	Public gaURL() As String
	Public gaHistorial() As String
	
	
	Public Structure ecOnOff
		'UPGRADE_NOTE: On se actualiz� a On_Renamed. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim On_Renamed As Date 'Hora de arranque
		Dim Off As Date 'Hora de parada
	End Structure
	
	Public gaWin() As ecOnOff 'Evento Windows
	Public gaScr() As ecOnOff 'Evento Protector Pantalla
	Public gaMdm() As ecOnOff 'Evento M�dem
	Public gaTmr() As ecOnOff 'Evento Cronometro
	Public gaPrg() As ecOnOff 'Evento Programa
	
	Public giWin As Short 'Indice para evento Windows
	Public giScr As Short '�ndice para evento Pantalla
	Public giMdm As Short '�ndice para evento M�dem
	Public giTmr As Short '�ndice para evento Cronometro
	Public gnPrg As Short '�ndice para n�mero Programa
	Public giPrg() As Short 'Indice para evento Programa
	
	Public gtWin As ecOnOff 'Temp �ltimo evento Windows
	Public gtScr As ecOnOff 'Temp �ltimo evento Screen
	Public gtMdm As ecOnOff 'Temp �ltimo evento Modem
	Public gtTmr As ecOnOff 'Temp �ltimo evento Cronometro
	Public gtPrg() As ecOnOff 'Temp �ltimos eventos Programas
	
	Public gdPrgDia() As Date 'Horas programas dia
	Public gdPrgMes() As Date 'Horas programas mes
	Public gdPrgA�o() As Date 'Horas programas a�o
	
	' Fecha en que arranca el Programa EventControl
	Public gdFechaOn As Date
	
	'Para control de programas introducidos por el usuario
	Public gaPrograma(99, 2) As String
	
	Public gstrIconMsg As String 'Mensaje del Icono
	Public gstrPrograma As String 'Nombre y Versi�n de EventControl
	Public gstrContrase�a As String 'Contrase�a
	Public gblnContrase�a As Boolean 'Contrase�a correcta
	Public gstrFormatoFecha As String 'Formato de la fecha
	Public gblnCronoOn As Boolean 'Cronometro On/Off
	
	'Public garrFichero(99) As String  'Para guardar los programas activos
	
	Public Const EC_ESPA�OL As Short = 0
	Public Const EC_ENGLISH As Short = 1
	Public Const EC_CATALA As Short = 2
	
	Public EC_SHAREWARE As Boolean 'True si coincide Encriptado
	Public gstrNumeroHD As String 'Para guardar Numero HD
	Public gstrNumeroRegistro As String 'Para guardar Num Encriptado
	Public gblnPausar As Boolean 'Pausar & Reactivar
	Public giIdioma As Short 'Para saber el Idioma
	
	Public MyDate As Date 'Fecha interna
End Module