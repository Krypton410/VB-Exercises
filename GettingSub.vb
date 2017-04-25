Module GettingSub

    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function GetSub(ByVal k As String) As String
        Dim str As String
        str = "Last night I dreamt of San Pedro"
        GettingSub1.result.Text = (str)
        Dim substr As String = str.Substring(23)
        GettingSub1.resulta.Text = (substr)
        k = GettingSub1.result.Text
        Return k
    End Function
End Module
