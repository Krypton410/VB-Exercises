Public Class Birthdays

    Private Property birthday As String

    Private Property bday As String

    Private Property Monthy As String

    Private Property MonthNamey As String

    Private Property k As String

    Private Sub Birthday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        op1.Text = Birthday1.res(birthday)
        op2.Text = Birthday1.res(bday)
        op3.Text = Birthday1.res(Monthy)
        op4.Text = Birthday1.res(k)
    End Sub
End Class