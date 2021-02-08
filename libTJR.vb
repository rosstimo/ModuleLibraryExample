Module libTJR

    Function SayHello() As String
        Return "Hello, World!"
    End Function

    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function


End Module
