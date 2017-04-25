Module CreateDT1
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As String

    Private Property a As String




    Public Function equal(ByVal k As String) As String
        Dim date1 As New Date(2012, 12, 16, 12, 0, 0)
        Dim date2 As Date = #12/16/2017 12:00:52 AM#
        Dim date3 As Date = Date.Now
        Dim date4 As Date = Date.UtcNow
        Dim date5 As Date = Date.Today

        CreateDT.d1.Text = (date1)
        CreateDT.d2.Text = (date2)
        CreateDT.d3.Text = (date3)
        CreateDT.d4.Text = (date4)
        CreateDT.d5.Text = (date5)
        Return k
    End Function
End Module
