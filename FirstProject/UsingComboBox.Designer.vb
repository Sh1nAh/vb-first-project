<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsingComboBox
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Color"
        '
        'cboColor
        '
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Location = New System.Drawing.Point(89, 5)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(144, 21)
        Me.cboColor.TabIndex = 1
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(15, 43)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(257, 160)
        Me.lstDisplay.TabIndex = 2
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(42, 228)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'Btnclose
        '
        Me.Btnclose.Location = New System.Drawing.Point(170, 228)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(75, 23)
        Me.Btnclose.TabIndex = 4
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'UsingComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 263)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.cboColor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UsingComboBox"
        Me.Text = "UsingComboBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents Btnclose As System.Windows.Forms.Button
End Class
