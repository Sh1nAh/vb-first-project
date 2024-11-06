Public Class StuInfo
        Public Shared intSizeOfArray As Integer = 3
        Public Shared strid(intSizeOfArray) As String
        Public Shared strname(intSizeOfArray) As String
    Public Shared intJava(intSizeOfArray) As Integer
        Public Shared intvb(intSizeOfArray) As Integer
        Private Sub StudentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim objReader As IO.StreamReader
            Dim intCount As Integer = 0
        Dim strLocationAndNameOfFile As String = "D:\HND16\VB.Net\FirstProject\Student.txt"
            Dim intFill As Integer
            Dim strFileErrorMessage As String = "The file is not available.Restart when the file is available."
            If IO.File.Exists(strLocationAndNameOfFile) Then
                objReader = IO.File.OpenText(strLocationAndNameOfFile)
                If intCount > UBound(strid) Then
                    MessageBox.Show("Array out of bound")
                Else
                    Do While objReader.Peek <> -1
                        strname(intCount) = objReader.ReadLine()
                        strid(intCount) = objReader.ReadLine()
                        intJava(intCount) = Convert.ToInt32(objReader.ReadLine())
                        intvb(intCount) = Convert.ToInt32(objReader.ReadLine())
                        intCount += 1
                    Loop
                    objReader.Close()
                End If
                For intFill = 0 To (strid.Length - 1)
                    cbostuid.Items.Add(strid(intFill))
                Next
            Else
                MessageBox.Show(strFileErrorMessage, "Error")
                Me.Close()
            End If
        End Sub
        Private Sub cbostuid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbostuid.SelectedIndexChanged
            show_otherinfo(cbostuid.SelectedIndex)
        End Sub
        Public Sub show_otherinfo(ByVal i As Integer)
        txtstuname.Text = strname(i).ToString
        txtjava.Text = intJava(i)
        txtvb.Text = intvb(i)
    End Sub
    Private Sub btntotalmarks_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim a As Integer
        Dim b As Integer
        a = Convert.ToInt32(txtjava.Text)
        b = Convert.ToInt32(txtvb.Text)
        txttotal.Text = a + b
    End Sub
        Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
            End
    End Sub
End Class