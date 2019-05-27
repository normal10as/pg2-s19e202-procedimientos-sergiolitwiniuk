Imports System

Module Hipotenusa
    Sub Main(args As String())

        Dim fecha As Date
        Dim dias As Double
        Dim fecha_sumada As Date

        Console.WriteLine("ingresar una fecha: mm/dd/aaaa ")
        fecha = Console.ReadLine()
        Console.WriteLine("ingrese nro de dias: ")
        dias = Console.ReadLine()
        fecha_sumada = fecha.AddDays(dias)
        Console.WriteLine(fecha_sumada)
    End Sub
End Module
