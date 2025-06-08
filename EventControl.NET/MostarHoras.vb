Option Strict Off
Option Explicit On
Module HoraSuma
	Function Hora_Suma(ByRef dtArg As Date) As String
		Dim Horas As Double
		Dim Minutos As Double
		Dim RetBuffer As String
		
		Horas = dtArg.ToOADate * 24
		Minutos = (Horas - Int(Horas)) * 60
		Horas = Int(Horas)
		RetBuffer = VB6.Format(Horas, "0") & ":" & VB6.Format(Minutos, "00")
		Hora_Suma = RetBuffer
		' Se puede asignar la expresion anterior a
		' Hora_Suma.(en lo personal, no me gusta)
	End Function
End Module