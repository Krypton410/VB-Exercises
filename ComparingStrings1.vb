Public Class ComparingStrings1

    Private Property k As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = ComparingStrings.equal(k)
    End Sub
End Class