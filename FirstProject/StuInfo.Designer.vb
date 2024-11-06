<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StuInfo
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
        Me.lblstuinfo = New System.Windows.Forms.Label()
        Me.lblstuid = New System.Windows.Forms.Label()
        Me.stuname = New System.Windows.Forms.Label()
        Me.lbljava = New System.Windows.Forms.Label()
        Me.lblvb = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.cbostuid = New System.Windows.Forms.ComboBox()
        Me.txtstuname = New System.Windows.Forms.TextBox()
        Me.txtjava = New System.Windows.Forms.TextBox()
        Me.txtvb = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btntotal = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblstuinfo
        '
        Me.lblstuinfo.AutoSize = True
        Me.lblstuinfo.Location = New System.Drawing.Point(139, 32)
        Me.lblstuinfo.Name = "lblstuinfo"
        Me.lblstuinfo.Size = New System.Drawing.Size(99, 13)
        Me.lblstuinfo.TabIndex = 0
        Me.lblstuinfo.Text = "Student Information"
        '
        'lblstuid
        '
        Me.lblstuid.AutoSize = True
        Me.lblstuid.Location = New System.Drawing.Point(18, 87)
        Me.lblstuid.Name = "lblstuid"
        Me.lblstuid.Size = New System.Drawing.Size(55, 13)
        Me.lblstuid.TabIndex = 1
        Me.lblstuid.Text = "StudentID"
        '
        'stuname
        '
        Me.stuname.AutoSize = True
        Me.stuname.Location = New System.Drawing.Point(18, 140)
        Me.stuname.Name = "stuname"
        Me.stuname.Size = New System.Drawing.Size(75, 13)
        Me.stuname.TabIndex = 2
        Me.stuname.Text = "Student Name"
        '
        'lbljava
        '
        Me.lbljava.AutoSize = True
        Me.lbljava.Location = New System.Drawing.Point(18, 188)
        Me.lbljava.Name = "lbljava"
        Me.lbljava.Size = New System.Drawing.Size(30, 13)
        Me.lbljava.TabIndex = 3
        Me.lbljava.Text = "Java"
        '
        'lblvb
        '
        Me.lblvb.AutoSize = True
        Me.lblvb.Location = New System.Drawing.Point(18, 238)
        Me.lblvb.Name = "lblvb"
        Me.lblvb.Size = New System.Drawing.Size(41, 13)
        Me.lblvb.TabIndex = 4
        Me.lblvb.Text = "VB.Net"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(18, 290)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(58, 13)
        Me.lbltotal.TabIndex = 5
        Me.lbltotal.Text = "Total Mark"
        '
        'cbostuid
        '
        Me.cbostuid.FormattingEnabled = True
        Me.cbostuid.Location = New System.Drawing.Point(96, 84)
        Me.cbostuid.Name = "cbostuid"
        Me.cbostuid.Size = New System.Drawing.Size(121, 21)
        Me.cbostuid.TabIndex = 6
        '
        'txtstuname
        '
        Me.txtstuname.Location = New System.Drawing.Point(96, 133)
        Me.txtstuname.Name = "txtstuname"
        Me.txtstuname.Size = New System.Drawing.Size(121, 20)
        Me.txtstuname.TabIndex = 7
        '
        'txtjava
        '
        Me.txtjava.Location = New System.Drawing.Point(96, 185)
        Me.txtjava.Name = "txtjava"
        Me.txtjava.Size = New System.Drawing.Size(121, 20)
        Me.txtjava.TabIndex = 8
        '
        'txtvb
        '
        Me.txtvb.Location = New System.Drawing.Point(96, 231)
        Me.txtvb.Name = "txtvb"
        Me.txtvb.Size = New System.Drawing.Size(121, 20)
        Me.txtvb.TabIndex = 9
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(96, 283)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 20)
        Me.txttotal.TabIndex = 10
        '
        'btntotal
        '
        Me.btntotal.Location = New System.Drawing.Point(37, 364)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(75, 23)
        Me.btntotal.TabIndex = 11
        Me.btntotal.Text = "Total Marks"
        Me.btntotal.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(142, 363)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'StuInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 447)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btntotal)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtvb)
        Me.Controls.Add(Me.txtjava)
        Me.Controls.Add(Me.txtstuname)
        Me.Controls.Add(Me.cbostuid)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblvb)
        Me.Controls.Add(Me.lbljava)
        Me.Controls.Add(Me.stuname)
        Me.Controls.Add(Me.lblstuid)
        Me.Controls.Add(Me.lblstuinfo)
        Me.Name = "StuInfo"
        Me.Text = "StuInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstuinfo As System.Windows.Forms.Label
    Friend WithEvents lblstuid As System.Windows.Forms.Label
    Friend WithEvents stuname As System.Windows.Forms.Label
    Friend WithEvents lbljava As System.Windows.Forms.Label
    Friend WithEvents lblvb As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents cbostuid As System.Windows.Forms.ComboBox
    Friend WithEvents txtstuname As System.Windows.Forms.TextBox
    Friend WithEvents txtjava As System.Windows.Forms.TextBox
    Friend WithEvents txtvb As System.Windows.Forms.TextBox
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents btntotal As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
