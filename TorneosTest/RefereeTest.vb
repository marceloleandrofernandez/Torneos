Imports TorneosEntidades
Module RefereeTest
    Sub Main()
        Dim referee As New Referee

        Console.WriteLine("[*]-TEST REFEREEE-[*]")
        referee.Internacional = True
        Console.WriteLine("Tipo Referee: {0}", referee.Internacional)
        referee.Internacional = False
        Console.WriteLine("Tipo Referee: {0}", referee.Internacional)
        Console.ReadKey()
    End Sub
End Module
