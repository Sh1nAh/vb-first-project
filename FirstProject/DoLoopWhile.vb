Public Class Frimdoloopwhile

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        Dim strStudentname As String
        lstName.Items.Clear()
        Do
            strStudentname = InputBox("Please Enter student Name", "Input Name")
            If strStudentname.Trim <> "" Then
                lstName.Items.Add(strStudentname)
            End If
        Loop While (strStudentname.Trim <> "")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub
End Class