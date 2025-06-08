Option Strict Off
Option Explicit On
Friend Class frmPrograma
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdBorrarEventos_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrarEventos.Click
		Dim strBookMark As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strBookMark. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		strBookMark = VB6.CopyArray(grsPrograma.Bookmark)
		'UPGRADE_ISSUE: No se admite Load instrucci�n. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmEvento)
		frmEvento.ShowDialog()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strBookMark. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		grsPrograma.Bookmark = strBookMark
	End Sub
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		Dim strMsg2 As Object
		Dim strMsg1 As Object
		Dim strMsg0 As Object
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg0. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg0 = "Debe especificar el Nombre y el Path del Programa a A�adir"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg1. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg1 = "El Path del Programa a A�adir no existe"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg2. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg2 = "A�adir Programa"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg0. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg0 = "You should specify the Name and the Path of the Program to Add"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg1. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg1 = "The Path of the Program to Add don't exist"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg2. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg2 = "Add Program"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg0. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg0 = "Ha d'especificar el Nom i el Path del Programa a Afegir"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg1. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg1 = "El Path del Programa a Afegir no existeix"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg2. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsg2 = "Afegir Programa"
		End Select
		If txtNombre.Text = "" Or txtPath.Text = "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg2. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox(strMsg0, MsgBoxStyle.Information, strMsg2)
		Else
			'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If Dir(txtPath.Text) = "" Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsg2. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox(strMsg1, MsgBoxStyle.Information, strMsg2)
			Else
				Call Campos_Grabar()
				grsPrograma.Update()
				Call Command_Mostrar()
				Call cmdMover_Click(cmdMover.Item(3), New System.EventArgs())
				
			End If
		End If
	End Sub
	
	Private Sub cmdA�adir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdA�adir.Click
		Call Command_Ocultar()
		grsPrograma.MoveLast()
		lblID.Text = grsPrograma.Fields("ID").Value + 1
		grsPrograma.AddNew()
		txtNombre.Text = ""
		txtPath.Text = ""
		txtNombre.Focus()
	End Sub
	
	Private Sub cmdBorrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBorrar.Click
		Dim strMsgUltimo As Object
		Dim strMsgNoBorrar As Object
		Dim strMsgBorrar As Object
		Dim strMsgPrg As Object
		Dim intBorrar As Short
		Dim intID As Object
		Dim intBorradoID As Short
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Borrar Programa"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Seguro que desea Borrar el Programa " & grsPrograma.Fields("Nombre").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgNoBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgNoBorrar = "No puede Borrar un Programa que est� siendo Cronometrado"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgUltimo. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgUltimo = "Debe haber c�mo m�nimo un Programa definido"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Delete Program"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Sure you wants to Delete the Program" & grsPrograma.Fields("Nombre").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgNoBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgNoBorrar = "It cannot Erase a Program that it is being Cronometred"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgUltimo. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgUltimo = "It should have how minimum one defined Program"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgPrg = "Borrar Programa"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgBorrar = "Segur que desitja Borrar el Programa " & grsPrograma.Fields("Nombre").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgNoBorrar. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgNoBorrar = "No pot Borrar un Programa que est� essent Cronometrat"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgUltimo. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strMsgUltimo = "Hi ha d'haber com a m�nim un Programa definit"
		End Select
		
		intBorradoID = grsPrograma.Fields("ID").Value
		
		If gtPrg(intBorradoID - 4).On_Renamed <> CDate("0") Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox(strMsgNoBorrar, MsgBoxStyle.Information, strMsgPrg)
		Else
			
			If grsPrograma.RecordCount <= 5 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox(strMsgUltimo, MsgBoxStyle.Information, strMsgPrg)
			Else
				
				If frmEventControl.Contrase�a_Entrar Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strMsgPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					intBorrar = MsgBox(strMsgBorrar, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, strMsgPrg)
					If intBorrar = MsgBoxResult.Yes Then
						grsPrograma.Delete()
						grsPrograma.MoveFirst()
						Do While Not grsPrograma.EOF
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							intID = grsPrograma.Fields("ID").Value
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							If intID > intBorradoID Then
								grsPrograma.Edit()
								'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								grsPrograma.Fields("ID").Value = intID - 1
								grsPrograma.Update()
							End If
							grsPrograma.MoveNext()
						Loop 
						
						If grsEvento.RecordCount > 0 Then
							grsEvento.MoveFirst()
						End If
						Do While Not grsEvento.EOF
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							intID = grsEvento.Fields("ProgramaID").Value
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							If intID = intBorradoID Then
								grsEvento.Delete()
							End If
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							If intID > intBorradoID Then
								grsEvento.Edit()
								'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto intID. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
								grsEvento.Fields("ProgramaID").Value = intID - 1
								grsEvento.Update()
							End If
							'grsEvento.Update
							grsEvento.MoveNext()
						Loop 
						
						Call cmdMover_Click(cmdMover.Item(0), New System.EventArgs())
						
					End If
				End If
			End If
		End If
	End Sub
	
	Private Sub cmdCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancelar.Click
		grsPrograma.CancelUpdate()
		Call Command_Mostrar()
		Call cmdMover_Click(cmdMover.Item(3), New System.EventArgs())
		'Call Campos_Ver
	End Sub
	
	Private Sub cmdExaminar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExaminar.Click
		Dim txtFichero As Object
		
		On Error GoTo errHandler
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				dlgNombreOpen.Title = "Examinar Programas"
				'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgNombreOpen.Filter = "Archivos de Programa (*.exe) |*.exe"
			Case EC_ENGLISH
				dlgNombreOpen.Title = "Examine Programs"
				'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgNombreOpen.Filter = "Program Files (*.exe) |*.exe"
			Case EC_CATALA
				dlgNombreOpen.Title = "Examinar Programes"
				'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				dlgNombreOpen.Filter = "Arxius de Programa (*.exe) |*.exe"
		End Select
		
		'UPGRADE_WARNING: La propiedad CancelError de CommonDialog no se admite en Visual Basic .NET. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		dlgNombre.CancelError = True
		dlgNombreOpen.InitialDirectory = "c:\"
		dlgNombreOpen.ShowDialog()
		
		txtPath.Text = dlgNombreOpen.FileName
		
		Exit Sub
		
errHandler: 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto txtFichero. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtFichero = ErrorToString()
	End Sub
	
	Private Sub cmdModificar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdModificar.Click
		If frmEventControl.Contrase�a_Entrar Then
			Call Command_Ocultar()
			grsPrograma.Edit()
			txtNombre.Focus()
		End If
	End Sub
	
	Private Sub cmdSalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSalir.Click
		Dim iIndex As Object
		Dim iPrg As Object
		grsPrograma.MoveFirst()
		Do While Not grsPrograma.EOF
			If grsPrograma.Fields("ID").Value > 4 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gaPrograma(iPrg, 0) = grsPrograma.Fields("Nombre").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gaPrograma(iPrg, 1) = grsPrograma.Fields("Path").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gaPrograma(iPrg, 2) = grsPrograma.Fields("Password").Value
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				iPrg = iPrg + 1
			End If
			grsPrograma.MoveNext()
		Loop 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gaPrograma(iPrg, 0) = ""
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iPrg = 0
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iIndex. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		iIndex = frmEventControl.cboPrg.SelectedIndex
		frmEventControl.cboPrg.Items.Clear()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Do While gaPrograma(iPrg, 0) <> ""
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmEventControl.cboPrg.Items.Add(gaPrograma(iPrg, 0))
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iPrg. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			iPrg = iPrg + 1
		Loop 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iIndex. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If iIndex >= frmEventControl.cboPrg.Items.Count Then
			frmEventControl.cboPrg.SelectedIndex = 0
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto iIndex. Haga clic aqu� para obtener m�s informaci�n: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmEventControl.cboPrg.SelectedIndex = iIndex
		End If
		Me.Close()
	End Sub
	
	Private Sub frmPrograma_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPA�OL
				cmdA�adir.Text = "&A�adir"
				cmdBorrar.Text = "&Borrar"
				cmdExaminar.Text = "&Examinar HD"
				cmdModificar.Text = "&Modificar"
				cmdSalir.Text = "&Salir"
				cmdAceptar.Text = "&Aceptar"
				cmdCancelar.Text = "&Cancelar"
				cmdBorrarEventos.Text = "Borrar &Eventos"
				fraPrograma.Text = "Programas"
				Me.Text = "Gestionar Programas y Borrar Eventos"
				lblNombre.Text = "Nombre:"
				chkContrase�a.Text = "Protejer con Contrase�a"
				ToolTip1.SetToolTip(chkContrase�a, "Solo se podr� ejecutar el programa si se conoce la contrase�a")
			Case EC_ENGLISH
				cmdA�adir.Text = "&Add"
				cmdBorrar.Text = "&Delete"
				cmdExaminar.Text = "E&xamine HD"
				cmdModificar.Text = "&Modify"
				cmdSalir.Text = "&Exit"
				cmdAceptar.Text = "&Accept"
				cmdCancelar.Text = "&Cancel"
				cmdBorrarEventos.Text = "Delete &Events"
				fraPrograma.Text = "Programs"
				Me.Text = "Negotiate Programs and Delete Events"
				lblNombre.Text = "Name:"
				chkContrase�a.Text = "Protect by Password"
				ToolTip1.SetToolTip(chkContrase�a, "Only can execute the program if know the Password")
			Case EC_CATALA
				cmdA�adir.Text = "&Afegir"
				cmdBorrar.Text = "&Borrar"
				cmdExaminar.Text = "&Examinar HD"
				cmdModificar.Text = "&Modificar"
				cmdSalir.Text = "&Sortir"
				cmdAceptar.Text = "&Acceptar"
				cmdCancelar.Text = "&Cancelar"
				cmdBorrarEventos.Text = "Borrar &Events"
				fraPrograma.Text = "Programes"
				Me.Text = "Gestionar Programes y Borrar Events"
				lblNombre.Text = "Nom:"
				chkContrase�a.Text = "Protegir amb Contrasenya"
				ToolTip1.SetToolTip(chkContrase�a, "Nom�s es podr� executar el programa si es coneix la contrasenya")
		End Select
		
		Call Command_Mostrar()
		Call cmdMover_Click(cmdMover.Item(0), New System.EventArgs())
		
	End Sub
	Private Sub cmdMover_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMover.Click
		Dim Index As Short = cmdMover.GetIndex(eventSender)
		Select Case Index
			Case 0
				grsPrograma.MoveFirst()
			Case 1
				grsPrograma.MovePrevious()
			Case 2
				grsPrograma.MoveNext()
			Case 3
				grsPrograma.MoveLast()
		End Select
		
		If grsPrograma.BOF Then grsPrograma.MoveFirst()
		If grsPrograma.EOF Then grsPrograma.MoveLast()
		
		Call Campos_Ver()
		
		If CDbl(lblID.Text) < 5 Then
			cmdModificar.Enabled = False
			cmdBorrar.Enabled = False
		Else
			cmdModificar.Enabled = True
			cmdBorrar.Enabled = True
		End If
		
	End Sub
	
	Private Sub Campos_Ver()
		lblID.Text = ""
		txtNombre.Text = ""
		txtPath.Text = ""
		chkContrase�a.CheckState = System.Windows.Forms.CheckState.Unchecked
		
		lblID.Text = grsPrograma.Fields("ID").Value
		txtNombre.Text = grsPrograma.Fields("Nombre").Value
		If grsPrograma.Fields("Path").Value <> Chr(0) Then
			txtPath.Text = grsPrograma.Fields("Path").Value
		End If
		If grsPrograma.Fields("Password").Value <> Chr(0) Then
			chkContrase�a.CheckState = grsPrograma.Fields("Password").Value
		End If
		
	End Sub
	
	Private Sub Campos_Grabar()
		grsPrograma.Fields("ID").Value = lblID.Text
		grsPrograma.Fields("Nombre").Value = txtNombre.Text
		grsPrograma.Fields("Path").Value = txtPath.Text
		grsPrograma.Fields("Password").Value = chkContrase�a.CheckState
	End Sub
	
	Private Sub Command_Ocultar()
		cmdA�adir.Visible = False
		cmdModificar.Visible = False
		cmdBorrar.Visible = False
		cmdSalir.Visible = False
		
		cmdMover(0).Enabled = False
		cmdMover(1).Enabled = False
		cmdMover(2).Enabled = False
		cmdMover(3).Enabled = False
		
		cmdAceptar.Visible = True
		cmdCancelar.Visible = True
		cmdExaminar.Enabled = True
		
		chkContrase�a.Enabled = True
		
		cmdBorrarEventos.Enabled = False
		
		txtNombre.Enabled = True
		txtPath.Enabled = True
	End Sub
	
	Private Sub Command_Mostrar()
		cmdA�adir.Visible = True
		cmdModificar.Visible = True
		cmdBorrar.Visible = True
		cmdSalir.Visible = True
		
		cmdAceptar.Visible = False
		cmdCancelar.Visible = False
		cmdExaminar.Enabled = False
		
		cmdMover(0).Enabled = True
		cmdMover(1).Enabled = True
		cmdMover(2).Enabled = True
		cmdMover(3).Enabled = True
		
		chkContrase�a.Enabled = False
		
		cmdBorrarEventos.Enabled = True
		
		txtNombre.Enabled = False
		txtPath.Enabled = False
	End Sub
	
	Private Sub frmPrograma_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		Dim Cancel As Boolean = eventArgs.Cancel
		Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
		If cmdSalir.Visible = False Then
			Cancel = True
		End If
		eventArgs.Cancel = Cancel
	End Sub
End Class