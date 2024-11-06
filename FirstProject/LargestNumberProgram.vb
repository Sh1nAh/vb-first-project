Public Class FrmDivisionProgram

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim x, y, answer As Integer
        Try
            x = txtDivisor.Text
            y = txtDividend.Text
            answer = x / y
            lblResult.Text = x & "/" & y & "=" & answer
        Catch ex As DivideByZeroException
            MessageBox.Show("Division by zero")
            lblResult.Text = "Divident should not zero"
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            lblResult.Text = "Invalid Divisor or Dividend"
        Finally
            MessageBox.Show("Error Checking is complete", "Try Catch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Application.Exit()
    End Sub
End Class