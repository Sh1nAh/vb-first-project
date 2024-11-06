Public Class LoopExercise1

    Private Sub btnShowResult_Click(sender As Object, e As EventArgs) Handles btnShowResult.Click
        Dim a As Integer
        Dim b As Integer = txtNo.Text
        For a = b To 10
            Dim result As Integer = b Mod 2
            If (result.Equals(0)) Then
                lstDisplay.Items.Add(b)
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class