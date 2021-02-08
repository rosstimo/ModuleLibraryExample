


''' <summary>
''' A collection of useful though somewhat eccentric methods and resource thingies...
''' </summary>
Module libTJR

    ''' <summary>
    ''' Says Hello
    ''' </summary>
    ''' <returns>String: "Hello, World" </returns>
    Function SayHello() As String
        Return "Hello, World!"
    End Function

    ''' <summary>
    ''' Generates a random integer within a range
    ''' </summary>
    ''' <param name="maxNumber"></param>
    ''' <returns>Integer value from 0 to maxNumber inclusive.</returns>
    Function GetRandomNumber(maxNumber As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        Return CInt(Math.Floor(Rnd() * (maxNumber + 1)))
    End Function


End Module
