Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmImprimir
	Inherits System.Windows.Forms.Form
	Dim mintPrnLinea As Short 'Numero de línea impresa
	Dim mintPrnLen As Short 'Longitud de la página
	
	Private Sub cmdImprimir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImprimir.Click
		Dim strMsgInfo As Object
		Dim strMsgFechaErronea As Object
		Dim strMsgPrg As Object
		Dim dteFecha As Date
		Dim intID As Short 'Ultimo Evento Impreso
		Dim dteTiempo As Date 'Suma de los tiempos
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Imprimir Eventos"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgFechaErronea. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgFechaErronea = "Fecha Desde es mayor que Fecha Hasta"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgInfo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgInfo = "Los Eventos activos en este momento no serán listados"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Print Events"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgFechaErronea. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgFechaErronea = "From Date it's bigger than To Date"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgInfo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgInfo = "Active Events on this moment can't be listed"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Imprimir Events"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgFechaErronea. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgFechaErronea = "Data Des de és major que Data Fins a"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgInfo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgInfo = "Els Events actius en aquest moment no seran llistats"
		End Select
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto dtpFechaHasta._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto dtpFechaDesde._Value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If dtpFechaDesde._Value > dtpFechaHasta._Value Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox(strMsgFechaErronea, MsgBoxStyle.Information, strMsgPrg)
			Exit Sub
		End If
		
		grsEvento = gdb.OpenRecordset("SELECT * " & "FROM tblEvento " & "ORDER BY ProgramaID, Fecha, HoraOn")
		
		If grsEvento.RecordCount > 0 Then
			grsEvento.MoveFirst()
		End If
		
		mintPrnLinea = 0 'Línea impresa numero 0
		
		Call Imprimir_Titulo()
		Call Imprimir_SubTitulo()
		
		Do While Not grsEvento.EOF
			dteFecha = CDate(VB6.Format(grsEvento.Fields("Fecha").Value, gstrFormatoFecha))
			If dteFecha >= dtpFechaDesde._Value And dteFecha <= dtpFechaHasta._Value Then
				
				If grsEvento.Fields("ProgramaID").Value = lstEvento.SelectedIndex Or lstEvento.SelectedIndex = 0 Then
					
					If intID <> grsEvento.Fields("ProgramaID").Value Then
						If intID <> 0 Then
							Call Imprimir_SubTotal(dteTiempo)
							dteTiempo = #12:00:00 AM#
							intID = grsEvento.Fields("ProgramaID").Value
						Else
							If dteTiempo <> #12:00:00 AM# Or intID = 0 Then
								intID = grsEvento.Fields("ProgramaID").Value
							End If
						End If
					End If
					
					dteTiempo = System.Date.FromOADate(dteTiempo.ToOADate + System.Date.FromOADate(grsEvento.Fields("HoraOff").Value - grsEvento.Fields("HoraOn").Value).ToOADate)
					
					Call Imprimir_Evento()
					
				End If
			End If
			grsEvento.MoveNext()
		Loop 
		
		Call Imprimir_SubTotal(dteTiempo)
		
		'UPGRADE_ISSUE: Printer método Printer.EndDoc no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.EndDoc()
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox(strMsgInfo, MsgBoxStyle.Information, strMsgPrg)
		
		Call cmdSalir_Click(cmdSalir, New System.EventArgs())
		
	End Sub
	
	Private Sub cmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSalir.Click
		Me.Close()
	End Sub
	
	
	Private Sub frmImprimir_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim strEvento0 As Object
		
		mintPrnLen = 65 'Longitud de la página A4
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strEvento0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strEvento0 = "Todos los Eventos"
				cmdImprimir.Text = "&Imprimir"
				cmdSalir.Text = "&Salir"
				Me.Text = "Imprimir Eventos"
				lblInfo0.Text = "Eventos de:"
				
				lblFechaDesde.Text = "Desde Fecha  >="
				lblFechaHasta.Text = "=<  Hasta Fecha"
				dtpFechaDesde.CustomFormat = gstrFormatoFecha
				dtpFechaHasta.CustomFormat = gstrFormatoFecha
				
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strEvento0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strEvento0 = "All the Events"
				cmdImprimir.Text = "&Print"
				cmdSalir.Text = "&Exit"
				Me.Text = "Print Events"
				lblInfo0.Text = "Events of:"
				
				lblFechaDesde.Text = "From Date  >="
				lblFechaHasta.Text = "=<  To Date"
				dtpFechaDesde.CustomFormat = gstrFormatoFecha
				dtpFechaHasta.CustomFormat = gstrFormatoFecha
				
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strEvento0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strEvento0 = "Tots els Events"
				cmdImprimir.Text = "&Imprimir"
				cmdSalir.Text = "&Sortir"
				Me.Text = "Imprimir Events"
				lblInfo0.Text = "Events de:"
				
				lblFechaDesde.Text = "Des de Data  >="
				lblFechaHasta.Text = "=<  Fins a Data"
				dtpFechaDesde.CustomFormat = gstrFormatoFecha
				dtpFechaHasta.CustomFormat = gstrFormatoFecha
				
		End Select
		
		dtpFechaDesde.Value = dtpFechaDesde.MinDate
		dtpFechaHasta.Value = dtpFechaHasta.MaxDate
		
		lstEvento.Items.Clear()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strEvento0. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lstEvento.Items.Add(strEvento0)
		grsPrograma.MoveFirst()
		Do While Not grsPrograma.EOF
			lstEvento.Items.Add(grsPrograma.Fields("Nombre").Value)
			grsPrograma.MoveNext()
		Loop 
		lstEvento.SelectedIndex = frmPrograma.lblID.Text
	End Sub
	
	Private Sub Imprimir_Titulo()
		Dim x As Object
		Dim strHasta As Object
		Dim strDesde As Object
		Dim strTitulo As Object
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strTitulo = "Listado de Eventos"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strDesde. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strDesde = "Desde : "
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHasta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strHasta = "Hasta : "
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strTitulo = "Report of Events"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strDesde. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strDesde = "From : "
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHasta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strHasta = "To   : "
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strTitulo = "Llistat d'Events"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strDesde. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strDesde = "Des de : "
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHasta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strHasta = "Fins a : "
		End Select
		
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeName(Printer.Font, "Courier New")
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeSize(Printer.Font, 30)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, True)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, True)
		For x = 1 To 6
			'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
			'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			Printer.Print()
		Next 
		
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(7), strTitulo)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, False)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, False)
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(7), strDesde, VB6.Format(dtpFechaDesde._Value, gstrFormatoFecha))
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(7), strHasta, VB6.Format(dtpFechaHasta._Value, gstrFormatoFecha))
		
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeSize(Printer.Font, 10)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, False)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, False)
		'UPGRADE_ISSUE: Printer método Printer.NewPage no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.NewPage()
		
	End Sub
	
	
	Private Sub Imprimir_SubTitulo()
		Dim x As Object
		Dim strSubTitulo As Object
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strSubTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strSubTitulo = "ID     Nombre Evento       Fecha          Hora On      Hora Off     Tiempo Uso"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strSubTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strSubTitulo = "ID     Event Name          Date           Time On      Time Off     Time of Use"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strSubTitulo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strSubTitulo = "ID     Nom Event           Data           Hora On      Hora Off     Tiempo Uso"
		End Select
		
		If mintPrnLinea > mintPrnLen - 8 Then
			'UPGRADE_ISSUE: Printer método Printer.NewPage no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			Printer.NewPage()
			mintPrnLinea = 0
		End If
		
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeName(Printer.Font, "Courier New")
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeSize(Printer.Font, 10)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, True)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, True)
		
		For x = 1 To 5
			'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
			'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			Printer.Print()
		Next x
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(10), strSubTitulo)
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, False)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, False)
		
		mintPrnLinea = 7
		
	End Sub
	
	Private Sub Imprimir_Evento()
		Dim strHoraOff, strFecha, strID, strNombre, strHoraOn, strTiempo As Object
		Dim strEvento As String
		Static dteTiempo As Date
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strID. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strID = VB6.Format(grsEvento.Fields("ProgramaID").Value, "00")
		
		grsPrograma.MoveFirst()
		grsPrograma.Move((Int(CDbl(strID)) - 1))
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strNombre. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strNombre = VB.Left(grsPrograma.Fields("Nombre").Value & "               ", 15)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strFecha. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strFecha = VB6.Format(grsEvento.Fields("Fecha").Value, gstrFormatoFecha)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHoraOn. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strHoraOn = VB6.Format(grsEvento.Fields("HoraOn").Value, "Hh:Nn:Ss")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHoraOff. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strHoraOff = VB6.Format(grsEvento.Fields("HoraOff").Value, "Hh:Nn:Ss")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strTiempo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strTiempo = VB6.Format(grsEvento.Fields("HoraOff").Value - grsEvento.Fields("HoraOn").Value, "Hh:Nn:Ss")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strTiempo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHoraOff. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strHoraOn. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strFecha. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strNombre. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strID. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strEvento = strID & "     " & strNombre & "     " & strFecha & "     " & strHoraOn & "     " & strHoraOff & "     " & strTiempo
		
		
		If mintPrnLinea > mintPrnLen Then
			Call Imprimir_SubTitulo()
		End If
		
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(10), strEvento)
		mintPrnLinea = mintPrnLinea + 1
		
	End Sub
	
	Private Sub Imprimir_SubTotal(ByRef dteTiempo As Date)
		
		If mintPrnLinea > mintPrnLen - 5 Then
			'UPGRADE_ISSUE: Printer método Printer.NewPage no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			Printer.NewPage()
			Call Imprimir_SubTitulo()
		End If
		
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, True)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, True)
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print(SPC(58), "Total............... ", Hora_Suma(dteTiempo))
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		'UPGRADE_ISSUE: Printer objeto no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6B85A2A7-FE9F-4FBE-AA0C-CF11AC86A305"'
		'UPGRADE_ISSUE: Printer método Printer.Print no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Print()
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeBold(Printer.Font, False)
		'UPGRADE_ISSUE: Printer propiedad Printer.Font no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Printer.Font = VB6.FontChangeUnderline(Printer.Font, False)
		mintPrnLinea = mintPrnLinea + 4
		
	End Sub
End Class