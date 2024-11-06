<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frimdoloopwhile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstName = New System.Windows.Forms.ListBox()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstName
        '
        Me.lstName.FormattingEnabled = True
        Me.lstName.Location = New System.Drawing.Point(12, 12)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(260, 186)
        Me.lstName.TabIndex = 0
        '
        'Btnadd
        '
        Me.Btnadd.Location = New System.Drawing.Point(32, 228)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(75, 23)
        Me.Btnadd.TabIndex = 1
        Me.Btnadd.Text = "Add Name"
        Me.Btnadd.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(162, 228)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Frimdoloopwhile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Btnadd)
        Me.Controls.Add(Me.lstName)
        Me.Name = "Frimdoloopwhile"
        Me.Text = "Student Name Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstName As System.Windows.Forms.ListBox
    Friend WithEvents Btnadd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
