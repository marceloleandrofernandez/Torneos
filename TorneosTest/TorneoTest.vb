Imports TorneosEntidades
Module TorneoTest

    Sub Main()
        Dim torn As New torneo
        Console.WriteLine("[*]-TEST DE TORNEO [*]")
        torn.Nombre = "Torneo asdfffdsa"
        Console.WriteLine("Nombre del Torneo: {0}", torn.Nombre)
        torn.Nombre = ""
        Console.WriteLine("Nombre del Torneo: {0}", torn.Nombre)
        torn.Nombre = "Nombre de un Torneoasdasdadasdadasdddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd"
        Console.WriteLine("Nombre del Torneo: {0}", torn.Nombre)
        Console.ReadKey()

    End Sub

End Module
