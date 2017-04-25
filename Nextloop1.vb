Module Nextloop1
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer
    Private Property v As Integer

    Public Function nextThem(ByVal k As Integer) As Integer
        Dim anArray() As Integer = {1, 3, 5, 7, 9}
        Dim arrayItem As Integer
        For Each arrayItem In anArray
            k = (arrayItem)
        Next
        Console.ReadLine()


  

        Nextloop.result.Text = k

        Return k
    End Function
End Module
