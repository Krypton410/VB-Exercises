Public Class Operators

    Private Property a As Double

    Private Property b As Double

    Private Property k As Double

    Private Property v As Integer

    Public Sub box1_TextChanged(sender As System.Object, e As System.EventArgs) Handles box1.TextChanged

    End Sub

    Public Sub box2_TextChanged(sender As System.Object, e As System.EventArgs) Handles box2.TextChanged

    End Sub

    Public Sub result_TextChanged(sender As System.Object, e As System.EventArgs) Handles result.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        result.Text = Module1.addThem(k)

    End Sub

 


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        result.Text = Module1.subtractThem(k)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        result.Text = Module1.multiplyThem(k)
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        result.Text = Module1.divideThem(k)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        result.Text = Module1.backslashThem(k)
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        result.Text = Module1.modThem(k)
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        result.Text = Module1.raiseThem(k)
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class