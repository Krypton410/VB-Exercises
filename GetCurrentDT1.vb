Module GetCurrentDT1
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As String

    Private Property a As String




    Public Function equal(ByVal k As String) As String
 
        GetCurrentDT.result.Text = (Now.ToLongTimeString)
        k = GetCurrentDT.result.Text
        Return k
    End Function
End Module
