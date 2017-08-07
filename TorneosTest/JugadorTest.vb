Imports TorneosEntidades
Module JugadorTest
    Sub Main()
        Dim jugador As New Jugador

        Console.WriteLine("[*]-TEST JUGADOR [*]")
        jugador.Numero = 77
        Console.WriteLine("Numero Jugador: {0}", jugador.Numero)
        jugador.Numero = 99
        Console.WriteLine("Numero Jugador: {0}", jugador.Numero)
        jugador.Numero = 0
        Console.WriteLine("Numero Jugador: {0}", jugador.Numero)
        jugador.Numero = 100
        Console.WriteLine("Numero Jugador: {0}", jugador.Numero)
        Console.ReadKey()
    End Sub
End Module
