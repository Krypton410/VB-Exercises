Module ExitStatement
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function state(ByVal k As String) As String
        a = ExitStatement1.box1.Text
        While (a < 20)
            ExitStatement1.result.Text = ("value of a : " & a)
            a = a + 1
            If (a < 15) Then
                Exit While
            End If
        End While

        k = ExitStatement1.result.Text
        Return k
    End Function
End Module
