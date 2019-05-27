Imports System

Module VolumenCilindro
    Sub Main(args As String())
        Dim radio_cilindro As Double
        Dim altura_cilindro As Double
        Dim volumen_cilindro As Double
        Dim pi As Double

        pi = Math.PI

        Console.WriteLine("ingrese el radio del cilindro: ")
        radio_cilindro = Console.ReadLine()
        Console.WriteLine("ingrese la altura del cilindro: ")
        altura_cilindro = Console.ReadLine()

        volumen_cilindro = pi * Math.Pow(radio_cilindro, 2) * altura_cilindro

        Console.WriteLine("El volumen del cilindro es: " & volumen_cilindro)


    End Sub
End Module
