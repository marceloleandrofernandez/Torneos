Imports TorneosEntidades
Module TestPartido
    Sub main()
        Dim partido As New Partido
        Console.WriteLine("[*]-TEST PARTIDO-[*]")

        partido.Fecha = "1/8/2017"
        Console.WriteLine("Goles Local {0}", partido.GolesLocal)
        Console.WriteLine("Goles Visitante {0}", partido.GolesVisitante)
        partido.nuevoGolLocal(15)
        partido.nuevoGolVisitante(23)
        partido.nuevoGolLocal(25)
        partido.nuevoGolVisitante(44)
        partido.nuevoGolLocal(68)
        For Each item In partido.MinutosGolesLocales
            Console.WriteLine("Minutos Goles local:{0} ", item)
        Next
        For Each item In partido.MinutosGolesVisitantes
            Console.WriteLine("Minutos Goles Visitante:{0} ", item)
        Next
        Console.WriteLine("Goles Local {0}", partido.GolesLocal)
        Console.WriteLine("Goles Visitante {0}", partido.GolesVisitante)

        Console.WriteLine("[*]Finaliza el Partido[*]")
        partido.Finalizado()
        partido.nuevoGolLocal(95)
        partido.nuevoGolVisitante(105)
        partido.nuevoGolLocal(2)
        partido.nuevoGolVisitante(55)
        For Each item In partido.MinutosGolesLocales
            Console.WriteLine("Minutos Goles local:{0} ", item)
        Next
        For Each item In partido.MinutosGolesVisitantes
            Console.WriteLine("Minutos Goles Visitante:{0} ", item)
        Next
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")

        Console.ReadKey()
    End Sub
End Module
