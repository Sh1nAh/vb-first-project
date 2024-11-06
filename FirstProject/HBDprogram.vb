Public Class HBDprogram
    Private Sub birthdayGreeting(ByVal PersonName As String)
        Dim msg As String
        If PersonName <> "" Then
            msg = "Happy Birthday" & PersonName & "!"
        Else
            msg = "Person Name is not specified"
        End If
        lblMessage.Text = msg
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        birthdayGreeting(txtName.Text.Trim)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class