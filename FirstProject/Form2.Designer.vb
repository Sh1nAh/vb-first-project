<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnCall = New System.Windows.Forms.Button()
        Me.cboMethod = New System.Windows.Forms.ComboBox()
        Me.txtMethod = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCall
        '
        Me.btnCall.Location = New System.Drawing.Point(24, 88)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(75, 23)
        Me.btnCall.TabIndex = 0
        Me.btnCall.Text = "Call"
        Me.btnCall.UseVisualStyleBackColor = True
        '
        'cboMethod
        '
        Me.cboMethod.FormattingEnabled = True
        Me.cboMethod.Items.AddRange(New Object() {"Method 1", "Method 2", "Method 3"})
        Me.cboMethod.Location = New System.Drawing.Point(134, 88)
        Me.cboMethod.Name = "cboMethod"
        Me.cboMethod.Size = New System.Drawing.Size(121, 21)
        Me.cboMethod.TabIndex = 1
        Me.cboMethod.Text = "--Select a method--"
        '
        'txtMethod
        '
        Me.txtMethod.Location = New System.Drawing.Point(24, 31)
        Me.txtMethod.Name = "txtMethod"
        Me.txtMethod.ReadOnly = True
        Me.txtMethod.Size = New System.Drawing.Size(231, 20)
        Me.txtMethod.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.txtMethod)
        Me.Controls.Add(Me.cboMethod)
        Me.Controls.Add(Me.btnCall)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCall As System.Windows.Forms.Button
    Friend WithEvents cboMethod As System.Windows.Forms.ComboBox
    Friend WithEvents txtMethod As System.Windows.Forms.TextBox
End Class
