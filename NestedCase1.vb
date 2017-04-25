Module NestedCase1
    Private Property result As Object
    Private Property values As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

    Private Property b As Integer

    Private Property a As Integer




    Public Function nesteds(ByVal k As String) As String
        a = Val(NestedCase.box1.Text)
        b = Val(NestedCase.box2.Text)
        Select a
            Case 100
                k = ("This is part of outer case")
                Select Case b
                    Case 200
                        NestedCase.value.Text = ("This is part of inner case")

                End Select
        End Select



        NestedCase.result.Text = k
        NestedCase.valuea.Text = ("Exact value of a is :" & a)
        NestedCase.valueb.Text = ("Exact value of b is :" & b)



        Return k
    End Function
End Module
