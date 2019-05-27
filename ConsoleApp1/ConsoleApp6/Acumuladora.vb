Imports System

Module Acumuladora

    Dim primer_digito As Decimal
    Dim acumulador_decimal As Decimal

    Sub Main(args As String())
        Console.WriteLine("ingrese un digito!")
        primer_digito = Console.ReadLine()
        Acumular(primer_digito)
        Console.WriteLine("ingrese un digito!")
        primer_digito = Console.ReadLine()
        Acumular(primer_digito)
        Console.WriteLine("ingrese un digito!")
        primer_digito = Console.ReadLine()
        Acumular(primer_digito)


    End Sub

    Private Sub Acumular(primer_digito)

        acumulador_decimal += primer_digito
        Console.WriteLine("El valor acumulado es " & acumulador_decimal)



    End Sub

End Module
