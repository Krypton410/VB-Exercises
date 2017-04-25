Module Precedence
    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer
    Private Property c As Integer
    Private Property d As Integer
    Private Property v As Integer

    Public Function ONE(ByVal k As Integer) As Integer
        a = Precedence1.Box1.Text
        b = Precedence1.Box2.Text
        c = Precedence1.Box4.Text
        d = Precedence1.Box2.Text
        k = (a + b) * c / d
        Operators.result.Text = k

        Return k
    End Function
    Public Function TWO(ByVal k As Integer) As Integer
        a = Precedence1.Box1.Text
        b = Precedence1.Box2.Text
        c = Precedence1.Box4.Text
        d = Precedence1.Box2.Text
        k = ((a + b) * c) / d
        Operators.result.Text = k

        Return k
    End Function
    Public Function THREE(ByVal k As Integer) As Integer
        a = Precedence1.Box1.Text
        b = Precedence1.Box2.Text
        c = Precedence1.Box4.Text
        d = Precedence1.Box2.Text
        k = (a + b) * (c / d)
        Operators.result.Text = k

        Return k
    End Function
    Public Function FOUR(ByVal k As Integer) As Integer
        a = Precedence1.Box1.Text
        b = Precedence1.Box2.Text
        c = Precedence1.Box4.Text
        d = Precedence1.Box2.Text
        k = a + (b * c) / d
        Operators.result.Text = k

        Return k
    End Function





End Module
