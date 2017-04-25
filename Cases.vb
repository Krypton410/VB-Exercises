Module Cases

    Private Property a As String



    Public Function caseThem(ByVal k As String) As String
        a = Case1.box1.Text
        Dim grade As Char = "A"
        Select Case a
            Case "A"
                k = ("Excellent")
            Case "B"
                k = ("Well Done")
            Case "C"
                k = ("You passed")
            Case "D"
                k = ("Better Try Again")
            Case Else
                k = (" Invalid Grade")
        End Select
        Case1.value.Text = (" Your Grade is : " & a)
        Case1.result.Text = k
        Return k
    End Function
End Module
