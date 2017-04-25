Module ComparingStrings
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As String

    Private Property a As String




    Public Function equal(ByVal k As String) As String
        a = ComparingStrings1.Box1.Text
        b = ComparingStrings1.Box2.Text

        If (StrComp(a, b)) Then
            k = (a & " and " & b & " are not equal")

        Else
            k = (a & " and " & b & " are equal")

        End If
        ComparingStrings1.result.Text = k
        Return k
    End Function
End Module
