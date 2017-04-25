Module Module1

    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer
    Private Property v As Integer

    Public Function addThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a + b
        Operators.result.Text = k

        Return k
    End Function
    Public Function subtractThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a - b
        Operators.result.Text = k

        Return k
    End Function
    Public Function multiplyThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a * b
        Operators.result.Text = k

        Return k
    End Function
    Public Function divideThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a / b
        Operators.result.Text = k

        Return k
    End Function
    Public Function backslashThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a \ b
        Operators.result.Text = k

        Return k
    End Function
    Public Function raiseThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a + b
        Operators.result.Text = k

        Return k
    End Function
    Public Function modThem(ByVal k As Integer) As Integer
        a = Operators.box1.Text
        b = Operators.box2.Text
        k = a Mod b
        Operators.result.Text = k

        Return k
    End Function


End Module
