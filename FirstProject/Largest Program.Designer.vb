<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Largest_Program
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
        Me.btnLargest = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtone = New System.Windows.Forms.TextBox()
        Me.txttwo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtthree = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnLargest
        '
        Me.btnLargest.Location = New System.Drawing.Point(25, 277)
        Me.btnLargest.Name = "btnLargest"
        Me.btnLargest.Size = New System.Drawing.Size(75, 23)
        Me.btnLargest.TabIndex = 0
        Me.btnLargest.Text = "Largest"
        Me.btnLargest.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(179, 277)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtone
        '
        Me.txtone.Location = New System.Drawing.Point(154, 31)
        Me.txtone.Name = "txtone"
        Me.txtone.Size = New System.Drawing.Size(100, 20)
        Me.txtone.TabIndex = 2
        '
        'txttwo
        '
        Me.txttwo.Location = New System.Drawing.Point(154, 80)
        Me.txttwo.Name = "txttwo"
        Me.txttwo.Size = New System.Drawing.Size(100, 20)
        Me.txttwo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Enter Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter Third Number"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(25, 181)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(229, 76)
        Me.lblResult.TabIndex = 8
        '
        'txtthree
        '
        Me.txtthree.Location = New System.Drawing.Point(154, 138)
        Me.txtthree.Name = "txtthree"
        Me.txtthree.Size = New System.Drawing.Size(100, 20)
        Me.txtthree.TabIndex = 9
        '
        'Largest_Program
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 325)
        Me.Controls.Add(Me.txtthree)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttwo)
        Me.Controls.Add(Me.txtone)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLargest)
        Me.Name = "Largest_Program"
        Me.Text = "Largest_Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLargest As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtone As System.Windows.Forms.TextBox
    Friend WithEvents txttwo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtthree As System.Windows.Forms.TextBox
End Class
