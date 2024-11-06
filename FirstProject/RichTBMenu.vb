Public Class RichTBMenu
    Dim isedit As Boolean
    Private Sub RichTBMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RTB.Focus()
        RTB.Modified = False
    End Sub
    Private Sub mnunew_Click(sender As Object, e As EventArgs) Handles mnunew.Click
        Dim rm As RichTBMenu
        rm = New RichTBMenu()
        rm.Show()
    End Sub
    Private Sub mnuopen_Click(sender As Object, e As EventArgs) Handles mnuopen.Click
        If discardchanges() Then
            OpenFileDialog1.Filter = "RTF Files|*.RTF|Doc File|*.Doc|Text Files|*.txt"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim fName As String
                fName = OpenFileDialog1.FileName
                RTB.LoadFile(fName)
                RTB.Modified = False
            End If
        End If
    End Sub
    Function discardchanges() As Boolean
        If RTB.Modified Then
            Dim reply As MsgBoxResult
            reply = MsgBox("Text hasn't been saved,Discard changes?", MsgBoxStyle.YesNo)
            If reply = MsgBoxResult.No Then
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function
    Private Sub mnusave_Click(sender As Object, e As EventArgs) Handles mnusave.Click
        SaveFileDialog1.Filter = "RTF Files|*.RTF|Doc File|*.Doc|Text Files|*.txt"
        SaveFileDialog1.DefaultExt = "RTF"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fname As String
            fname = SaveFileDialog1.FileName
            RTB.Modified = False
        End If
    End Sub
    Private Sub mnufont_Click(sender As Object, e As EventArgs) Handles mnufont.Click
        If Not RTB.Font Is Nothing Then
            FontDialog1.Font = RTB.SelectionFont
        Else
            FontDialog1.Font = Nothing
        End If
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RTB.SelectionFont = FontDialog1.Font
        End If
    End Sub
    Private Sub mnucolor_Click(sender As Object, e As EventArgs) Handles mnucolor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            RTB.SelectionColor = ColorDialog1.Color
        End If
    End Sub
End Class