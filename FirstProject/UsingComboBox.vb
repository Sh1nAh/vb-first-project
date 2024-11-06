Public Class UsingComboBox

    Private Sub UsingComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboColor.Items.Add("Black")
        cboColor.Items.Add("Red")
        cboColor.Items.Add("Green")
        cboColor.Items.Add("Gray")
        cboColor.Items.Add("Blue")
    End Sub

    Private Sub cboColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboColor.SelectedIndexChanged
        If cboColor.SelectedIndex = 0 Then
            lstDisplay.BackColor = Color.Black
        End If
        If cboColor.SelectedIndex = 1 Then
            lstDisplay.BackColor = Color.Red
        End If
        If cboColor.SelectedIndex = 2 Then
            lstDisplay.BackColor = Color.Green
        End If
        If cboColor.SelectedIndex = 3 Then
            lstDisplay.BackColor = Color.Gray
        End If
        If cboColor.SelectedIndex = 4 Then
            lstDisplay.BackColor = Color.Blue
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lstDisplay.BackColor = Color.White
        cboColor.Text = ""
        cboColor.Focus()
    End Sub

    Private Sub Btnclose_Click(sender As Object, e As EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub
End Class