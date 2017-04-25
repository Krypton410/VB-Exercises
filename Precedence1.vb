Public Class Precedence1

    Private Property k As Object

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        one.Text = Precedence.ONE(k)
        two.Text = Precedence.TWO(k)
        three.Text = Precedence.THREE(k)
        four.Text = Precedence.FOUR(k)
    End Sub
End Class