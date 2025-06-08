Option Strict Off
Option Explicit On
Friend Class frmInformacion
	Inherits System.Windows.Forms.Form
	
	Private Sub cmdAceptar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAceptar.Click
		
		gstrNumeroRegistro = Trim(UCase(CStr(txtNumeroRegistro.Text)))
		
		If Encriptar(gstrNumeroHD) = gstrNumeroRegistro Then
			EC_SHAREWARE = False
		Else
			If gstrNumeroRegistro <> "" Then
				Select Case frmEventControl.cboIdioma.SelectedIndex
					Case EC_ESPAÑOL
						MsgBox("Número de Registro ERRONEO", MsgBoxStyle.Information, "Registrar " & gstrPrograma)
					Case EC_ENGLISH
						MsgBox("WRONG Register Number", MsgBoxStyle.Information, "Register " & gstrPrograma)
					Case EC_CATALA
						MsgBox("Número de Registre ERRONI", MsgBoxStyle.Information, "Registrar " & gstrPrograma)
				End Select
			End If
			EC_SHAREWARE = True
		End If
		
		Me.Close()
	End Sub
	
	Private Sub cmdFormulario_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFormulario.Click
		Dim Ret As Object
		Dim oeCrLf As Object
		Dim strBody As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oeCrLf. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		oeCrLf = "%0a"
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oeCrLf. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strBody = "Identificación: " & gstrNumeroHD & oeCrLf & "Empresa:" & oeCrLf & "Apellidos:" & oeCrLf & "Nombre:" & oeCrLf & "Dirección:" & oeCrLf & "Código Postal:" & oeCrLf & "Población:" & oeCrLf & "País:" & oeCrLf & "e-mail:" & oeCrLf & oeCrLf & "REGISTRO 1 programa ....... 2000pts/12euros/10$" & oeCrLf & "1)Ingreso/Transferencia en c/c La Caixa 2100-3701-11-2500016526" & oeCrLf & "    (indicar Nombre o Identificación en la transferencia)" & oeCrLf & "2)Envío cheque al portador" & oeCrLf & "3)Envío en Metálico"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oeCrLf. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strBody = "Identification: " & gstrNumeroHD & oeCrLf & "Company:" & oeCrLf & "Surname:" & oeCrLf & "Name:" & oeCrLf & "Direction:" & oeCrLf & "Postal Code:" & oeCrLf & "City:" & oeCrLf & "Country:" & oeCrLf & "e-mail:" & oeCrLf & oeCrLf & "REGISTER 1 program ....... 2000pts/12euros/10$" & oeCrLf & "1))Entrance/Transference in c/c La Caixa 2700-3701-11-2500016526" & oeCrLf & "    (indicate Name or Identification in the transference)" & oeCrLf & "2)Postal shipment of check to the carrier " & oeCrLf & "3)Postal shipment in Cash"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto oeCrLf. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strBody = "Identificació: " & gstrNumeroHD & oeCrLf & "Empresa:" & oeCrLf & "Cognoms:" & oeCrLf & "Nom:" & oeCrLf & "Direcció:" & oeCrLf & "Codi Postal:" & oeCrLf & "Població:" & oeCrLf & "País:" & oeCrLf & "e-mail:" & oeCrLf & oeCrLf & "REGISTRE 1 programa ....... 2000pts/12euros/10$" & oeCrLf & "1)Ingrés/Transferència al c/c La Caixa 2700-3701-11-2500016526" & oeCrLf & "    (indicar Nom o Identificació a la transferència)" & oeCrLf & "2)Enviament txec al portador" & oeCrLf & "3)Enviament en Metàl·lic"
		End Select
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Ret. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ret = ShellExecute(Me.Handle.ToInt32, "Open", "mailto:evalenti@wanadoo.es?subject=REGISTRAR " & gstrPrograma & " - ID:" & gstrNumeroHD & "&Body=" & strBody, "", "", 3)
	End Sub
	
	
	Private Sub frmInformacion_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		txtNumeroRegistro.Text = gstrNumeroRegistro
		
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				Me.Text = "Información"
				cmdFormulario.Text = "&Enviar Formulario de Registro"
				cmdAceptar.Text = "&Aceptar"
				lblIdentificacion.Text = "Identificación"
				lblNumeroRegistro.Text = "Número de Registro"
				ToolTip1.SetToolTip(picShareIt, "Registrar el programa con Tarjeta de Crédito")
			Case EC_ENGLISH
				Me.Text = "Information"
				cmdFormulario.Text = "&Send Register Form"
				cmdAceptar.Text = "&Accept"
				lblIdentificacion.Text = "Identification"
				lblNumeroRegistro.Text = "Register Number"
				ToolTip1.SetToolTip(picShareIt, "Register the program with Credit Card")
			Case EC_CATALA
				Me.Text = "Informació"
				cmdFormulario.Text = "&Enviar Formulari de Registre"
				cmdAceptar.Text = "&Acceptar"
				lblIdentificacion.Text = "Identificació"
				lblNumeroRegistro.Text = "Número de Registre"
				ToolTip1.SetToolTip(picShareIt, "Registrar el programa amb Tarjeta de Crèdit")
		End Select
		
		If EC_SHAREWARE Then
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPAÑOL
					lblShareWare.Text = "Este programa es ShareWare. Por favor, REGISTRA el programa para colaborar en el desarrollo de nuevas versiones."
				Case EC_ENGLISH
					lblShareWare.Text = "This program is ShareWare. Please, REGISTERS the program to collaborate in the development of new versions."
				Case EC_CATALA
					lblShareWare.Text = "Aquest programa és ShareWare. Per favor, REGISTRA el programa per a col·laborar en el desenvopulament de noves versions."
			End Select
		Else
			Select Case frmEventControl.cboIdioma.SelectedIndex
				Case EC_ESPAÑOL
					lblShareWare.Text = "Programa REGISTRADO."
				Case EC_ENGLISH
					lblShareWare.Text = "REGISTERED Program."
				Case EC_CATALA
					lblShareWare.Text = "Programa REGISTRAT."
			End Select
			
			txtNumeroRegistro.Enabled = False
			
		End If
		
		lblNumeroHD.Text = gstrNumeroHD
		lblPrograma.Text = gstrPrograma
	End Sub
	
	Private Sub lblMailWanadoo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblMailWanadoo.Click
		Call ShellExecute(Me.Handle.ToInt32, "Open", "mailto:evalenti@wanadoo.es?subject=" & gstrPrograma & " - ID:" & gstrNumeroHD, "", "", 3)
	End Sub
	
	Private Sub lblWeb_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblWeb.Click
		Call ShellExecute(Me.Handle.ToInt32, "open", "http://perso.wanadoo.es/evalenti", "", "", 5)
	End Sub
	
	Private Sub picShareIt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles picShareIt.Click
		Dim strShareItWeb As Object
		Dim strShareIt As String
		Select Case frmEventControl.cboIdioma.SelectedIndex
			Case EC_ESPAÑOL
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strShareItWeb. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strShareItWeb = "http://shareit1.element5.com/programs.html?productid=139357&language=Spanish"
			Case EC_ENGLISH
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strShareItWeb. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strShareItWeb = "http://shareit1.element5.com/programs.html?productid=139357&language=English"
			Case EC_CATALA
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strShareItWeb. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				strShareItWeb = "http://shareit1.element5.com/programs.html?productid=139357&language=Spanish"
		End Select
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto strShareItWeb. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Call ShellExecute(Me.Handle.ToInt32, "open", strShareItWeb, "", "", 5)
		
	End Sub
End Class