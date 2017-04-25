Module FormatD1




    Private Property result As Object

    Private Property box1 As Integer

    Private Property box2 As Integer

  





   




    Public Function res(ByVal k As String) As String

        Dim independenceDay As New Date(1947, 8, 15, 0, 0, 0)
        FormatD.a.Text = ("Format 'd' " & independenceDay.ToString("d"))
        FormatD.b.Text = ("Format 'D' " & independenceDay.ToString("D"))
        FormatD.c.Text = ("Format 't' " & independenceDay.ToString("t"))
        FormatD.d.Text = ("Format 'T' " & independenceDay.ToString("T"))
        FormatD.e.Text = ("Format 'f' " & independenceDay.ToString("f"))
        FormatD.f.Text = ("Format 'F " & independenceDay.ToString("F"))
        FormatD.g.Text = ("Format 'g' " & independenceDay.ToString("g"))
        FormatD.h.Text = ("Format 'G' " & independenceDay.ToString("G"))
        FormatD.i.Text = ("Format 'M' " & independenceDay.ToString("M"))
        FormatD.j.Text = ("Format 'R' " & independenceDay.ToString("R"))
        FormatD.k.Text = ("Format 'y' " & independenceDay.ToString("y"))




        k = FormatD.a.Text



        Return k
    End Function



   

End Module
