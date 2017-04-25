Public Class Bitshift1

    Private Property k As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Bitshift.andThem(k)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        result.Text = Bitshift.orThem(k)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        result.Text = Bitshift.notThem(k)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        result.Text = Bitshift.xorThem(k)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        result.Text = Bitshift.leftThem(k)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        result.Text = Bitshift.rightThem(k)
    End Sub
End Class