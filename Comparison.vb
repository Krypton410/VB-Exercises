Module Comparison


    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function equal(ByVal k As String) As String
        a = Comparison1.box1.Text
        b = Comparison1.box2.Text

        If (a = b) Then
            k = ("a is equal to b")

        Else
            k = ("a is not equal to b")

        End If
        Comparison1.result.Text = k
        Return k
    End Function
    Public Function lessthan(ByVal k As String) As String
        a = Val(Comparison1.box1.Text)
        b = Val(Comparison1.box2.Text)
        If (a < b) Then
            k = ("a is less than b")
            Comparison1.result.Text = k

        Else
            k = ("a is not less than b")
            Comparison1.result.Text = k

        End If

        Return k
    End Function

    Public Function greaterthan(ByVal k As String) As String
        a = Comparison1.box1.Text
        b = Comparison1.box2.Text
        If (a > b) Then
            k = ("a is greater than b")
            Comparison1.result.Text = k

        Else
            k = ("a is not greater than b")
            Comparison1.result.Text = k


        End If

        Return k
    End Function
    Public Function lessthanor(ByVal k As String) As String
        a = Comparison1.box1.Text
        b = Comparison1.box2.Text
        If (a <= b) Then
            k = ("a is less than or equal to b")
            Comparison1.result.Text = k
        Else
            k = ("a is not less than or equal to b")
            Comparison1.result.Text = k
        End If

        Return k
    End Function
    Public Function greaterthanor(ByVal k As String) As String
        a = Comparison1.box1.Text
        b = Comparison1.box2.Text
        If (a >= b) Then
            k = ("a is greater than or equal b")
            Comparison1.result.Text = k
        Else
            k = ("a is not greater than or equal b")
            Comparison1.result.Text = k

        End If

        Return k
    End Function
    Public Function facing(ByVal k As String) As String

        a = Comparison1.box1.Text
        b = Comparison1.box2.Text
        If (a > b) Then
            Comparison1.result.Text = k
            k = ("a <> b")
        Else
            k = ("a is not <> b")
            Comparison1.result.Text = k

        End If

        Return k
    End Function

End Module
