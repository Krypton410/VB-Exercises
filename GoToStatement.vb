Module GoToStatement
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function state(ByVal k As String) As String
        a = GoToStatement1.box1.Text
        Do
            If (a = 15) Then
                a = a + 1
                Continue Do

            End If
            GoToStatement1.result.Text = (" Value of a : " & a)
            a = a + 1
        Loop While (a < 20)
        k = GoToStatement1.result.Text
        Return k
    End Function
End Module
