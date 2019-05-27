Imports System

Module Potencias
    Sub Main(args As String())
        Dim base As Int16
        Dim resultado_2 As Double
        Dim resultado_3 As Double
        Dim resultado_5 As Double

        Console.WriteLine("ingrese un numero para ser elevado a la 2,3 y 5ta potencia: ")
        base = Console.ReadLine()
        resultado_2 = Math.Pow(base, 2)
        resultado_3 = Math.Pow(base, 3)
        resultado_5 = Math.Pow(base, 5)
        Console.WriteLine("elevado a la 2: " & resultado_2 & vbNewLine & "elevado a la 3: " & resultado_3 & vbNewLine & "elevado a la 5: " & resultado_5)



    End Sub
End Module
