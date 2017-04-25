Public Class Comparison1

    Private Property k As String

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        result.Text = Comparison.facing(k)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Comparison.equal(k)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        result.Text = Comparison.lessthan(k)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        result.Text = Comparison.greaterthan(k)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        result.Text = Comparison.greaterthanor(k)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        result.Text = Comparison.lessthanor(k)
    End Sub

    Private Sub Comparison1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class