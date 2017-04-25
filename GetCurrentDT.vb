Public Class GetCurrentDT

    Private Property k As String

    Private Sub GetCurrentDT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = GetCurrentDT1.equal(k)
    End Sub
End Class