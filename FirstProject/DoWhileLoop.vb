Public Class Frmwhileloop

    Private Sub Btngenerate_Click(sender As Object, e As EventArgs) Handles Btngenerate.Click
        Dim objrandom As New Random
        Dim Number As Integer = 0
        lstNumber.Items.Clear()
        Do While Number < 30
            Number = objrandom.Next(50)
            lstNumber.Items.Add(Number)
        Loop
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub
End Class