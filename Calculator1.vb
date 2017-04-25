Public Class Calculator1



    Dim a1 As Integer
    Dim a2 As Integer
    Dim intAnswer As Integer

    Private Property a0 As Integer

    Private Property k As Integer

    Private Property a3 As Integer

    Private Property a4 As Integer

    Private Property a5 As Integer

    Private Property a6 As Integer

    Private Property a7 As Integer

    Private Property a8 As Integer

    Private Property a9 As Integer

    Private Property k9 As Integer

    Private Property IntA As Integer




    Private Sub btn0_Click(sender As System.Object, e As System.EventArgs) Handles btn0.Click
        box1.Text = Calculator.Button0(k)
    End Sub

    Private Sub btn1_Click(sender As System.Object, e As System.EventArgs) Handles btn1.Click
        box1.Text = Calculator.Button1(k)

    End Sub
    Private Sub btn2_Click(sender As System.Object, e As System.EventArgs) Handles btn2.Click
        box1.Text = Calculator.Button2(k)

    End Sub
    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        box1.Text = Calculator.Button3(k)
    End Sub
    Private Sub btn4_Click(sender As System.Object, e As System.EventArgs) Handles btn4.Click
        box1.Text = Calculator.Button4(k)
    End Sub
    Private Sub btn5_Click(sender As System.Object, e As System.EventArgs) Handles btn5.Click
        box1.Text = Calculator.Button5(k)

    End Sub
    Private Sub btn6_Click(sender As System.Object, e As System.EventArgs) Handles btn6.Click
        box1.Text = Calculator.Button6(k)

    End Sub
    Private Sub btn7_Click(sender As System.Object, e As System.EventArgs) Handles btn7.Click
        box1.Text = Calculator.Button7(k)

    End Sub
    Private Sub btn8_Click(sender As System.Object, e As System.EventArgs) Handles btn8.Click
        box1.Text = Calculator.Button8(k)

    End Sub
    Private Sub btn9_Click(sender As System.Object, e As System.EventArgs) Handles btn9.Click
        box1.Text = Calculator.Button9(k)

    End Sub



    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        box1.Text = Calculator.clear(k)
    End Sub

    Private Sub btnEquals_Click(sender As System.Object, e As System.EventArgs) Handles btnEquals.Click
        box1.Text = Calculator.equals(k)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        box1.Text = Calculator.Addition(k)
        box1.Text = (" + ")

    End Sub

    Private Sub btnSubtract_Click(sender As System.Object, e As System.EventArgs) Handles btnSubtract.Click
        box1.Text = Calculator.Subtraction(k)
        box1.Text = (" - ")
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        box1.Text = Calculator.Multiplication(k)
        box1.Text = (" * ")
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        box1.Text = Calculator.Division(k)
        box1.Text = (" / ")
    End Sub
End Class
