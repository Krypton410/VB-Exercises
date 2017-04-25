Module Decision1
    Private Property a As Integer
    Private Property b As Integer

    Public Function lessthan(ByVal k As String) As String
        a = Val(Comparison1.box1.Text)


        If (a < 20) Then
            k = ("a is less than 20")
            Decisions.result.Text = k

        Else
            k = ("a is not less than 20")
            Decisions.result.Text = k

        End If

        Decisions.value.Text = ("a value is: " & a)
        Return k

    End Function
End Module
