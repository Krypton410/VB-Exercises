Public Class GettingSub1

    Private Property k As Object

    Private Sub GettingSub1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = GettingSub.GetSub(k)
    End Sub
End Class