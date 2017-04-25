Module Assignment

    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer
    Private Property b As Integer

    Private Property a As Integer
    Private Property v As Integer

    Public Function equalsThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text
        v = a
        k = a = v
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function addandThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text
        v = Assignment1.box1.Text
        a += a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function subtractandThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a -= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function multiplyandThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a *= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function divideandThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a /= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function backslashThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a \= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function raiseThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a ^= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function leftThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a <<= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function rightThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a >>= a
        k = a
        Assignment1.result.Text = k

        Return k
    End Function
    Public Function andThem(ByVal k As Integer) As Integer
        a = Assignment1.box1.Text

        a &= a

        k = a
        Assignment1.result.Text = k

        Return k
    End Function

End Module
