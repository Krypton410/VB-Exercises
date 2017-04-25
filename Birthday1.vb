Module Birthday1


    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer












    Public Function res(ByVal k As String) As String

    

        Dim birthday As Date
        Dim bday As Integer
        Dim monthy As Integer
        Dim monthyname As String

        birthday = #7/27/1998#
        bday = Microsoft.VisualBasic.DateAndTime.Day(birthday)
        monthy = Microsoft.VisualBasic.DateAndTime.Month(birthday)
        monthyname = Microsoft.VisualBasic.DateAndTime.MonthName(monthy)
        Birthdays.op1.Text = (birthday)
        Birthdays.op2.Text = (bday)
        Birthdays.op3.Text = (monthy)
        Birthdays.op4.Text = (monthyname)



        k = Birthdays.op4.Text



        Return k
    End Function
End Module
