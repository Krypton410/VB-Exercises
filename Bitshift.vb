Module Bitshift



    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer
    Private Property v As Integer

    Public Function andThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = a And b
        Bitshift1.result.Text = k

        Return k
    End Function

    Public Function orThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = a Or b
        Bitshift1.result.Text = k

        Return k
    End Function
    Public Function xorThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = a Xor b
        Bitshift1.result.Text = k

        Return k
    End Function
    Public Function leftThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = a << 2
        Bitshift1.result.Text = k

        Return k
    End Function
    Public Function rightThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = a >> 2
        Bitshift1.result.Text = k

        Return k
    End Function
    Public Function notThem(ByVal k As Integer) As Integer
        a = Bitshift1.box1.Text
        b = Bitshift1.box2.Text
        k = Not a
        Bitshift1.result.Text = k

        Return k
    End Function



End Module
