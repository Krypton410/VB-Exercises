Module Doloop
    Private Property a As Integer
    Private Property b As Integer

    Public Function Dloop(ByVal k As String) As String
        a = Val(Doloop1.Box1.Text)

        Do
            k = ("Value of a :" & a)
            a = a + 1
        Loop While (a < 20)
        Console.ReadLine()
        Doloop1.result.Text = k
        Doloop1.rslt.Text = a
        Return k

    End Function

End Module
