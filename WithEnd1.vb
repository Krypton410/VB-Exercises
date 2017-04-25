Module WithEnd1
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer
    Private Property b As String
    Private Property c As String

    Private Property a As String
    Private Property v As Integer

    Public Function withThem(ByVal k As Integer) As Integer
        a = WithEnd.TextBox1.Text
        b = WithEnd.Box2.Text
        c = WithEnd.Box3.Text

        With WithEnd
            WithEnd.Names.Text = a
            WithEnd.Author.Text = b
            WithEnd.Subject.Text = c





        End With


        Return k
    End Function
End Module
