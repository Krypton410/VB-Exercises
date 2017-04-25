Public Class Doloop1

    Private Property k As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Doloop.Dloop(k)
    End Sub

    Private Sub rslt_Click(sender As System.Object, e As System.EventArgs) Handles rslt.Click

    End Sub
End Class