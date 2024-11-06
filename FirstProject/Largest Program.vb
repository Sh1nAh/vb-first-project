Public Class Largest_Program
    Private Function Largest(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As String
        Dim Result As String
        If num1 > num2 Then
            Result = "Largest number is" & num1
        ElseIf num2 > num1 And num2 > num3 Then
            Result = "Largest number is" & num2
        Else
            Result = "Largest number is" & num3
        End If
        Return Result
    End Function
    Private Sub btnLargest_Click(sender As Object, e As EventArgs) Handles btnLargest.Click
        Dim one, two, three As Integer
        one = txtone.Text
        two = txttwo.Text
        three = txtthree.Text
        lblResult.Text = Largest(one, two, three)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class