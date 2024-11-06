Public Class frmMain
    Dim objmyClass As New MyClassTest
    Private Sub btnCall_Click(sender As Object, e As EventArgs) Handles btnCall.Click
        Try
            If cboMethod.Text = "Method 1" Then
                objMyClass.Method1()
            End If
            If cboMethod.Text = "Method 2" Then
                objmyClass.Method2()
            End If
            If cboMethod.Text = "Method 3" Then
                objmyClass.Method3()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
