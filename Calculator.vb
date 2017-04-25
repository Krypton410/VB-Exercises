Module Calculator

    Private _additon As String


    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer


    Private Property b As Integer

    Private Property a As Integer
    Private Property v As Integer

    Dim IntA As Integer
    Dim m As String
    Dim m1 As String
    Dim m2 As String
    Dim IntB As Integer
    Dim strOperation As String
    Dim intAnswer As Integer

    Property Additon(p1 As Integer) As String
        Get
            Return _additon
        End Get
        Set(value As String)
            _additon = value
        End Set
    End Property


    Public Function Button0(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 0


        Return k

    End Function
    Public Function Button1(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 1


        Return k

    End Function
    Public Function Button2(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 2


        Return k

    End Function
    Public Function Button3(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 3


        Return k

    End Function
    Public Function Button4(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 4


        Return k

    End Function
    Public Function Button5(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 5


        Return k

    End Function
    Public Function Button6(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 6


        Return k

    End Function
    Public Function Button7(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 7


        Return k

    End Function
    Public Function Button8(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 8


        Return k

    End Function
    Public Function Button9(ByVal k As Integer) As Integer


        v = Val(Calculator1.box1.Text)
        k = v * 10 + 9



        Return k

    End Function
    Public Function clear(ByVal k As Integer) As Integer


        Calculator1.box1.Text = "0"
        k = Calculator1.box1.Text

        Return k

    End Function


    Public Function equals(ByVal k As Integer) As Integer
        IntB = Val(Calculator1.box1.Text)
        Select Case strOperation
            Case Is = 1
                intAnswer = IntA + IntB
            Case Is = 2
                intAnswer = IntA - IntB
            Case Is = 3
                intAnswer = IntA * IntB
            Case Is = 4
                intAnswer = IntA / IntB
        End Select
        Calculator1.box1.Text = intAnswer
        k = intAnswer
        Return k

    End Function
    Public Function Addition(ByVal k As Integer) As Integer

        strOperation = 1

        IntA = Val(Calculator1.box1.Text)
        
        'k = IntA
       

        Return k
    End Function
    Public Function Subtraction(ByVal k As Integer) As Integer

        strOperation = 2
        m = "-"

        IntA = (Calculator1.box1.Text)
        'k = IntA

        Return k
    End Function
    Public Function Multiplication(ByVal k As Integer) As Integer

        strOperation = 3
        IntA = Val(Calculator1.box1.Text)
        'k = IntA

        Return k
    End Function
    Public Function Division(ByVal k As Integer) As Integer

        strOperation = 4
        IntA = Val(Calculator1.box1.Text)


        'k = IntA

        Return k
    End Function


End Module
