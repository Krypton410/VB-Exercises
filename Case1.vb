Public Class Case1

    Private Property k As Integer

    Private Property grade As String

    Private Property a As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        result.Text = Cases.caseThem(k)
    End Sub
End Class