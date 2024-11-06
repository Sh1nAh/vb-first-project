<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RichTBMenu
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
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.mnufile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnunew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuopen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnusave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuevent = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnufont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnucolor = New System.Windows.Forms.ToolStripMenuItem()
        Me.RTB = New System.Windows.Forms.MenuStrip()
        Me.RTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'mnufile
        '
        Me.mnufile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnunew, Me.mnuopen, Me.mnusave})
        Me.mnufile.Name = "mnufile"
        Me.mnufile.Size = New System.Drawing.Size(35, 20)
        Me.mnufile.Text = "File"
        '
        'mnunew
        '
        Me.mnunew.Name = "mnunew"
        Me.mnunew.Size = New System.Drawing.Size(152, 22)
        Me.mnunew.Text = "New"
        '
        'mnuopen
        '
        Me.mnuopen.Name = "mnuopen"
        Me.mnuopen.Size = New System.Drawing.Size(152, 22)
        Me.mnuopen.Text = "Open"
        '
        'mnusave
        '
        Me.mnusave.Name = "mnusave"
        Me.mnusave.Size = New System.Drawing.Size(152, 22)
        Me.mnusave.Text = "Save"
        '
        'mnuevent
        '
        Me.mnuevent.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnufont, Me.mnucolor})
        Me.mnuevent.Name = "mnuevent"
        Me.mnuevent.Size = New System.Drawing.Size(47, 20)
        Me.mnuevent.Text = "Event"
        '
        'mnufont
        '
        Me.mnufont.Name = "mnufont"
        Me.mnufont.Size = New System.Drawing.Size(98, 22)
        Me.mnufont.Text = "Font"
        '
        'mnucolor
        '
        Me.mnucolor.Name = "mnucolor"
        Me.mnucolor.Size = New System.Drawing.Size(98, 22)
        Me.mnucolor.Text = "Color"
        '
        'RTB
        '
        Me.RTB.BackColor = System.Drawing.Color.Transparent
        Me.RTB.Enabled = False
        Me.RTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnufile, Me.mnuevent})
        Me.RTB.Location = New System.Drawing.Point(0, 0)
        Me.RTB.Name = "RTB"
        Me.RTB.Size = New System.Drawing.Size(284, 24)
        Me.RTB.TabIndex = 0
        Me.RTB.Text = "MenuStrip1"
        '
        'RichTBMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 238)
        Me.Controls.Add(Me.RTB)
        Me.MainMenuStrip = Me.RTB
        Me.Name = "RichTBMenu"
        Me.Text = "RichTBMenu"
        Me.RTB.ResumeLayout(False)
        Me.RTB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents mnufile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnunew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuopen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnusave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuevent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnufont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnucolor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RTB As System.Windows.Forms.MenuStrip
End Class
