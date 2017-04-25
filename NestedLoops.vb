Public Class NestedLoops

    Private Property k As String

    Private Sub NestedLoops_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = NestedLoops1.Them(k)
    End Sub
End Class