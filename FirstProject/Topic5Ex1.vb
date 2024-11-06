Public Class Topic5Ex1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim a As Integer
            a = txtage.Text
            If a >= 30 Then
                MessageBox.Show("Adult", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a >= 25 And a <= 30 Then
                MessageBox.Show("Young Adult", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a >= 20 And a <= 25 Then
                MessageBox.Show("Youth", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf a <= 30 Then
                MessageBox.Show("Teens", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Please type a correct Integer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class