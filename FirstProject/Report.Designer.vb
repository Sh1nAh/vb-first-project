<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.rdosaleid = New System.Windows.Forms.RadioButton()
        Me.rdosaledate = New System.Windows.Forms.RadioButton()
        Me.rdoname = New System.Windows.Forms.RadioButton()
        Me.rdobrand = New System.Windows.Forms.RadioButton()
        Me.txtsaleid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.dgvreport = New System.Windows.Forms.DataGridView()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.dgvreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdosaleid
        '
        Me.rdosaleid.AutoSize = True
        Me.rdosaleid.Location = New System.Drawing.Point(24, 39)
        Me.rdosaleid.Name = "rdosaleid"
        Me.rdosaleid.Size = New System.Drawing.Size(57, 17)
        Me.rdosaleid.TabIndex = 0
        Me.rdosaleid.TabStop = True
        Me.rdosaleid.Text = "SaleID"
        Me.rdosaleid.UseVisualStyleBackColor = True
        '
        'rdosaledate
        '
        Me.rdosaledate.AutoSize = True
        Me.rdosaledate.Location = New System.Drawing.Point(24, 88)
        Me.rdosaledate.Name = "rdosaledate"
        Me.rdosaledate.Size = New System.Drawing.Size(72, 17)
        Me.rdosaledate.TabIndex = 1
        Me.rdosaledate.TabStop = True
        Me.rdosaledate.Text = "Sale Date"
        Me.rdosaledate.UseVisualStyleBackColor = True
        '
        'rdoname
        '
        Me.rdoname.AutoSize = True
        Me.rdoname.Location = New System.Drawing.Point(316, 40)
        Me.rdoname.Name = "rdoname"
        Me.rdoname.Size = New System.Drawing.Size(76, 17)
        Me.rdoname.TabIndex = 2
        Me.rdoname.TabStop = True
        Me.rdoname.Text = "Item Name"
        Me.rdoname.UseVisualStyleBackColor = True
        '
        'rdobrand
        '
        Me.rdobrand.AutoSize = True
        Me.rdobrand.Location = New System.Drawing.Point(316, 90)
        Me.rdobrand.Name = "rdobrand"
        Me.rdobrand.Size = New System.Drawing.Size(53, 17)
        Me.rdobrand.TabIndex = 3
        Me.rdobrand.TabStop = True
        Me.rdobrand.Text = "Brand"
        Me.rdobrand.UseVisualStyleBackColor = True
        '
        'txtsaleid
        '
        Me.txtsaleid.Location = New System.Drawing.Point(112, 39)
        Me.txtsaleid.Name = "txtsaleid"
        Me.txtsaleid.Size = New System.Drawing.Size(100, 20)
        Me.txtsaleid.TabIndex = 4
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(404, 38)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 20)
        Me.txtname.TabIndex = 6
        '
        'txtbrand
        '
        Me.txtbrand.Location = New System.Drawing.Point(404, 88)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(100, 20)
        Me.txtbrand.TabIndex = 7
        '
        'dgvreport
        '
        Me.dgvreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreport.Location = New System.Drawing.Point(24, 151)
        Me.dgvreport.Name = "dgvreport"
        Me.dgvreport.Size = New System.Drawing.Size(480, 198)
        Me.dgvreport.TabIndex = 8
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(527, 115)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 9
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(527, 172)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(75, 23)
        Me.btnreport.TabIndex = 10
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(112, 87)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(189, 20)
        Me.dtpdate.TabIndex = 11
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(527, 226)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 373)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dgvreport)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtsaleid)
        Me.Controls.Add(Me.rdobrand)
        Me.Controls.Add(Me.rdoname)
        Me.Controls.Add(Me.rdosaledate)
        Me.Controls.Add(Me.rdosaleid)
        Me.Name = "Report"
        Me.Text = "Report"
        CType(Me.dgvreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdosaleid As System.Windows.Forms.RadioButton
    Friend WithEvents rdosaledate As System.Windows.Forms.RadioButton
    Friend WithEvents rdoname As System.Windows.Forms.RadioButton
    Friend WithEvents rdobrand As System.Windows.Forms.RadioButton
    Friend WithEvents txtsaleid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtbrand As System.Windows.Forms.TextBox
    Friend WithEvents dgvreport As System.Windows.Forms.DataGridView
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
