Module ifelse


    Private Property a As Integer

    Private Property k As String

    Public Function measure(ByVal k As String) As String
        a = Val(ifelses.Box1.Text)


        If (a = 10) Then
            k = ("Value of a is 10")
           

        ElseIf (a = 20) Then
            k = ("value of a is 20")

        ElseIf (a = 30) Then
            k = ("value of a is 30")

        Else
            k = ("Not Match")
        End If
        ifelses.result.Text = k
        ifelses.value.Text = ("a value is:" & a)
        Return k

    End Function

End Module
