Module nested

    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function nesteds(ByVal k As String) As String
        a = Val(Nested1.box1.Text)
        b = Val(Nested1.box2.Text)

        If (a = 100) Then
            If (b = 200) Then
                k = ("Value of a is 100 and Value of B is 200")
            End If
        End If
        Nested1.result.Text = k



        Return k
    End Function
End Module
