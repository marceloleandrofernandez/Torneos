Imports TorneosEntidades
Module PersonaTest
    Sub main()
        Dim pers As New Persona("Ramon", "21 / 9 / 1985")
        Console.WriteLine("[*]-TEST DE PERSONA [*]")
        Console.WriteLine("Nombre: {0}", pers.Nombre)
        Console.WriteLine("Fecha Nacimiento: {0} ", pers.FechaNacimiento)
        Console.WriteLine("Edad Persona: {0}", pers.Edad)
        pers.Nombre = ""
        Console.WriteLine("Nombre: {0}", pers.Nombre)
        pers.Nombre = "ajsjsjsjsjsjsjsjkakajsdlajsdñljasdflkjasdflkjhasdfkljhaskdfjhaklsjdfh"
        Console.WriteLine("Nombre: {0}", pers.Nombre)
        Console.ReadKey()
    End Sub
End Module
