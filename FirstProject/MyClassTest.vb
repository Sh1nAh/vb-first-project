Public Class MyClassTest
    Sub Method1()
        frmMain.txtMethod.Text = ""
        frmMain.txtMethod.Text = "This is method 1 of" + Me.GetType.ToString
    End Sub
    Sub Method2()
        frmMain.txtMethod.Text = ""
        frmMain.txtMethod.Text = "This is method 2 of" + Me.GetType.ToString
    End Sub
    Sub Method3()
        frmMain.txtMethod.Text = ""
        frmMain.txtMethod.Text = "This is method 3 of" + Me.GetType.ToString
    End Sub
End Class