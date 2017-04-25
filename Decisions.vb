Public Class Decisions

    Private Property k As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Decision1.lessthan(k)
    End Sub
End Class