Public Class Form1

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim a As Integer
        For a = 1 To 12
            lstDisplay.Items.Add("2*" & a & "=" & a * 2)
        Next
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lstDisplay.Items.Clear()
    End Sub
End Class
