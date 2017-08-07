Imports TorneosEntidades
Module EquipoTest
    Sub main()
        Dim equipo As New Equipo("Rojo")
        Console.WriteLine("[*]-TEST EQUIPO [*]")
        Console.WriteLine("Nombre Equipo: {0}", equipo.Nombre)
        equipo.Nombre = "Azul"
        Console.WriteLine("Nombre Equipo: {0}", equipo.Nombre)
        equipo.Nombre = ""
        Console.WriteLine("Nombre Equipo: {0}", equipo.Nombre)
        equipo.Nombre = "qwertyuiopñlaskfjiqpeoijrnfnooiskdjflqkjerijfkjdksa"
        Console.WriteLine("Nombre Equipo: {0}", equipo.Nombre)
        Console.ReadKey()

    End Sub
End Module
