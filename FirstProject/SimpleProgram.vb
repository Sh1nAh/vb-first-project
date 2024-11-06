Public Class SimpleProgram

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim a As Integer
        a = txtmark.Text
        If a >= 40 And a <= 65 Then
            MessageBox.Show("Pass", "Mark Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a > 65 And a < 75 Then
            MessageBox.Show("credit", "Mark Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a < 40 Then
            MessageBox.Show("Fail", "Mark Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class