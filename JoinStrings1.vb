Module JoinStrings1


    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As String

    Private Property a As String




    Public Function equal(ByVal k As String) As String
        a = JoinStrings.Box1.Text
        b = JoinStrings.Box2.Text
        Dim strarray As String() = {"Down the way where tehn ights are gay", "And The Suns shines daily on the mountain top",
                                    " I took a trup on a sailing ship", "And when  I reached Jamaica", "Imade a stop"}

        Dim str As String = String.Join(vbCrLf, strarray)
        JoinStrings.result.Text = (str)


 
        k = (str)
        Return k
    End Function

End Module
