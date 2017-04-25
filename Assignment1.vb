Public Class Assignment1

    Private Property k As Object

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Assignment.equalsThem(k)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        result.Text = Assignment.addandThem(k)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        result.Text = Assignment.subtractandThem(k)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        result.Text = Assignment.multiplyandThem(k)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        result.Text = Assignment.divideandThem(k)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        result.Text = Assignment.backslashThem(k)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        result.Text = Assignment.raiseThem(k)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        result.Text = Assignment.leftThem(k)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        result.Text = Assignment.rightThem(k)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        result.Text = Assignment.andThem(k)
    End Sub
End Class