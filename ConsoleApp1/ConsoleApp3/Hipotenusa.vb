Imports System

Module Hipotenusa
    Sub Main(args As String())
        Dim cateto_a As Double
        Dim cateto_b As Double
        Dim hipotenusa As Double

        Console.WriteLine("Ingrese el cateto A: ")
        cateto_a = Console.ReadLine()
        Console.WriteLine("Ingrese el cateto B: ")
        cateto_b = Console.ReadLine()

        hipotenusa = Math.Sqrt(Math.Pow(cateto_a, 2) + Math.Pow(cateto_b, 2))
        Console.WriteLine(hipotenusa)

    End Sub
End Module
