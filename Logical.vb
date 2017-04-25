Module Logical


    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function andThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a And b) Then
            k = ("Condition is true")

        Else
            k = ("Condition is False")

        End If
        Logical1.result.Text = k
        Return k
    End Function


    Public Function notThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (Not (a And b)) Then
            k = ("Condition is True")

        Else
            k = ("Condition is Not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function



    Public Function orThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a Or b) Then
            k = ("Condition is True")

        Else
            k = ("Condition is Not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function

    Public Function xorThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a Xor b) Then
            k = ("Condition is True")

        Else
            k = ("Condtion is not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function
    Public Function andalsoThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a AndAlso b) Then
            k = ("Condition is True")

        Else
            k = ("Condtion is not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function
    Public Function orelseThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a OrElse b) Then
            k = ("Condition is True")

        Else
            k = ("Condtion is not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function

    Public Function trueThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a = True And b = True) Then
            k = ("Condition is True")

        Else
            k = ("Condtion is not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function
    Public Function falseThem(ByVal k As String) As String
        a = Logical1.box1.Text
        b = Logical1.box2.Text

        If (a = False And b = False) Then
            k = ("Condition is True")

        Else
            k = ("Condtion is not True")

        End If
        Logical1.result.Text = k
        Return k
    End Function

End Module
