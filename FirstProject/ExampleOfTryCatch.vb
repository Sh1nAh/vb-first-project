Public Class ExampleOfTryCatch

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim a As Integer
            a = txtmark.Text
            If a >= 40 And a <= 65 Then
                MessageBox.Show("Pass", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a > 65 And a < 75 Then
                MessageBox.Show("credit", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a < 40 Then
                MessageBox.Show("Fail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please type a correct integer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class