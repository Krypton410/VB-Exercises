Public Class GoToStatement1

    Private Property k As String

    Private Sub box1_TextChanged(sender As System.Object, e As System.EventArgs) Handles box1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub result_Click(sender As System.Object, e As System.EventArgs) Handles result.Click

    End Sub
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = ContinueStatement.state(k)
    End Sub
End Class