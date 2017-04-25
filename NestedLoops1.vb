Module NestedLoops1

    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function Them(ByVal k As String) As String
        a = Val(NestedLoops.Box1.Text)

        Dim i, j As Integer
        j = a
        For i = a To 100
            For j = 2 To i
                If (i Mod j) = 0 Then
                    Exit For
                End If

            Next j
            If (j > (i \ j)) Then
                'Console.WriteLine("{0} is prime", i)
                NestedLoops.result.Text = (a & " is Prime")
            End If

        Next i
        Console.ReadLine()
        k = NestedLoops.result.Text
        Return k
    End Function
End Module
