<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmwhileloop
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
        Me.Btngenerate = New System.Windows.Forms.Button()
        Me.lstNumber = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btngenerate
        '
        Me.Btngenerate.Location = New System.Drawing.Point(186, 45)
        Me.Btngenerate.Name = "Btngenerate"
        Me.Btngenerate.Size = New System.Drawing.Size(75, 23)
        Me.Btngenerate.TabIndex = 0
        Me.Btngenerate.Text = "Generate"
        Me.Btngenerate.UseVisualStyleBackColor = True
        '
        'lstNumber
        '
        Me.lstNumber.FormattingEnabled = True
        Me.lstNumber.Location = New System.Drawing.Point(12, 13)
        Me.lstNumber.Name = "lstNumber"
        Me.lstNumber.Size = New System.Drawing.Size(143, 225)
        Me.lstNumber.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(186, 112)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Frmwhileloop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstNumber)
        Me.Controls.Add(Me.Btngenerate)
        Me.Name = "Frmwhileloop"
        Me.Text = "Random Number Program"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btngenerate As System.Windows.Forms.Button
    Friend WithEvents lstNumber As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
