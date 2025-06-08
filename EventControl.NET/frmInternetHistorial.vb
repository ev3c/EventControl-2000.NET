Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmInternetHistorial
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Me.Close()
	End Sub
	
	Private Sub cmdBorrarHistorial_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrarHistorial.Click
		Dim intBorrar As Object
		Dim strMsgBorrar As Object
		Dim strMsgPrg As Object
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Borrar Historial"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Seguro que desea Borrar el Historial de Internet"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Delete History"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Sure you wants to Delete Internet History"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Borrar Historial"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Segur que desitja Borrar l'Historial d'Internet"
		End Select
		
		If frmEventControl.Contraseña_Entrar Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intBorrar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			intBorrar = MsgBox(strMsgBorrar, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, strMsgPrg)
			If intBorrar = MsgBoxResult.Yes Then
				If grsHistorial.RecordCount > 0 Then
					grsHistorial.MoveFirst()
				End If
				Do While Not grsHistorial.EOF
					grsHistorial.Delete()
					grsHistorial.MoveNext()
				Loop 
				
				Call Historial_Compactar()
				
				Call frmEventControl.gaHistorial_Leer()
				Call cmdAceptar_Click(cmdAceptar, New System.EventArgs())
				
			End If
		End If
		
	End Sub
	
	Private Sub dtpFechaHistorial_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles dtpFechaHistorial.Change
		
		Call InternetHistorial_Actualizar(dtpFechaHistorial)
		
	End Sub
	
	
	Private Sub frmInternetHistorial_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				Me.Text = "Internet Historial"
				cmdAceptar.Text = "&Aceptar"
				cmdBorrarHistorial.Text = "&Borrar Historial"
				lblFecha.Text = "&Fecha Historial:"
				ToolTip1.SetToolTip(lstHistorial, "Doble click para ir a la página web")
				
			Case EC_ENGLISH
				Me.Text = "Internet History"
				cmdAceptar.Text = "&Accept"
				cmdBorrarHistorial.Text = "&Delete History"
				lblFecha.Text = "&History Date:"
				ToolTip1.SetToolTip(lstHistorial, "Double click to go to web page")
				
			Case EC_CATALA
				Me.Text = "Internet Historial"
				cmdAceptar.Text = "&Acceptar"
				cmdBorrarHistorial.Text = "&Borrar Historial"
				lblFecha.Text = "&Data Historial:"
				ToolTip1.SetToolTip(lstHistorial, "Doble click per anar a la pàgina web")
				
		End Select
		
		dtpFechaHistorial.CustomFormat = gstrFormatoFecha
		dtpFechaHistorial.Value = MyDate
		
		Call InternetHistorial_Actualizar(MyDate)
		
	End Sub
	
	Private Sub InternetHistorial_Actualizar(ByRef fecha As Object)
		
		grsHistorial = gdbHistorial.OpenRecordset("SELECT * " & "FROM tblHistorial " & "ORDER BY url_fecha, url_hora ")
		
		lstHistorial.Items.Clear()
		
		If grsHistorial.RecordCount > 0 Then
			grsHistorial.MoveFirst()
		End If
		Do While Not grsHistorial.EOF
			If grsHistorial.Fields("url_fecha").Value = dtpFechaHistorial.Value Then
				lstHistorial.Items.Add(VB6.Format(grsHistorial.Fields("url_fecha").Value, gstrFormatoFecha) & " - " & grsHistorial.Fields("url_hora").Value & " - " & grsHistorial.Fields("url_adress").Value)
			End If
			grsHistorial.MoveNext()
		Loop 
		
	End Sub
	
	Private Sub lstHistorial_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstHistorial.DoubleClick
		Dim sURL As String
		sURL = lstHistorial.Text
		sURL = Trim(VB.Right(sURL, Len(sURL) - 24))
		
		Call ShellExecute(Me.Handle.ToInt32, "open", sURL, "", "", 5)
		
		Call cmdAceptar_Click(cmdAceptar, New System.EventArgs())
		
	End Sub
	
	Private Sub Historial_Compactar()
		
		'Cierra Historial.mdb
		grsHistorial.Close()
		'UPGRADE_NOTE: El objeto grsHistorial no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		grsHistorial = Nothing
		gdbHistorial.Close()
		'UPGRADE_NOTE: El objeto gdbHistorial no se puede destruir hasta que no se realice la recolección de los elementos no utilizados. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		gdbHistorial = Nothing
		
		If gstrContraseña = "" Then
			DAODBEngine_definst.CompactDatabase(My.Application.Info.DirectoryPath & "\Historial.mdb", My.Application.Info.DirectoryPath & "\Hist_Co.mdb")
		Else
			DAODBEngine_definst.CompactDatabase(My.Application.Info.DirectoryPath & "\Historial.mdb", My.Application.Info.DirectoryPath & "\Hist_Co.mdb",  ,  , ";PWD=" & gstrContraseña)
		End If
		
		'Borra Historial
		'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(My.Application.Info.DirectoryPath & "\Historial.mdb") <> "" Then
			Kill(My.Application.Info.DirectoryPath & "\Historial.mdb")
		End If
		
		'Renombra Hist_Co.mdb
		Rename(My.Application.Info.DirectoryPath & "\Hist_Co.mdb", My.Application.Info.DirectoryPath & "\Historial.mdb")
		
		
		'Reabre Historial
		gdbHistorial = DAODBEngine_definst.Workspaces(0).OpenDatabase(My.Application.Info.DirectoryPath & "\Historial.mdb", True, False, ";PWD=" & gstrContraseña)
		
		grsHistorial = gdbHistorial.OpenRecordset("SELECT * " & "FROM tblHistorial " & "ORDER BY url_fecha, url_hora")
		
	End Sub
End Class