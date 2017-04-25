Module StringThem
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer
    Private Property b As String
    Private Property c As String

    Private Property a As String
    Private Property p As String
    Private Property v As Integer



    Private Property greet As String





    Public Function Them(ByVal k As Integer) As Integer
        a = StringsThem1.lastname.Text
        b = StringsThem1.firstname.Text
        c = StringsThem1.box2.Text
        p = b + a

        StringsThem1.Names.Text = (p)

        'String Constructor

        Dim letters As Char() = {"H", "E", "l", "l", "o"}
        greet = New String(letters)
        StringsThem1.Greetings.Text = (greet)

        'methods reutrning string
        Dim sarray() As String = {"Hello", "Fromm", "Tutorials", "Point"}
        Dim message As String = String.Join(" ", sarray)
        StringsThem1.Greetings.Text = (message)

        'formatting method to convert a value

        Dim waiting As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)
        Dim chat As String = String.Format("Message Sent at {0:t} of {0:D}", waiting)
        Stringsthem1.messageD.Text = (chat)


        Return k



    End Function
End Module
