Public Class StringsThem1

    Private Property k As String

    Private Property p As String

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        fff.Text = StringThem.Them(k)
    End Sub
End Class