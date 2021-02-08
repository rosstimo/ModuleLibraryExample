Module MainModule

    Sub Main()
        Console.WriteLine(libTJR.SayHello())
        For i = 0 To 5
            Console.WriteLine(libTJR.GetRandomNumber(5))
        Next
        libTJR.GetRandomNumber(5)

        Console.Read()
    End Sub

End Module
