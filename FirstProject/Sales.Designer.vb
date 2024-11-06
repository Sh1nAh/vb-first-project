<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sales
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
        Me.dtpsales = New System.Windows.Forms.DateTimePicker()
        Me.lblsalesid = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.lblcustomerid = New System.Windows.Forms.Label()
        Me.lblsaleqty = New System.Windows.Forms.Label()
        Me.lblamount = New System.Windows.Forms.Label()
        Me.lblitemname = New System.Windows.Forms.Label()
        Me.lblitemid = New System.Windows.Forms.Label()
        Me.lblbrand = New System.Windows.Forms.Label()
        Me.lblprice = New System.Windows.Forms.Label()
        Me.lblstockqty = New System.Windows.Forms.Label()
        Me.lblfinalqty = New System.Windows.Forms.Label()
        Me.lblfinalamount = New System.Windows.Forms.Label()
        Me.cbocusname = New System.Windows.Forms.ComboBox()
        Me.cboitemname = New System.Windows.Forms.ComboBox()
        Me.txtcusid = New System.Windows.Forms.TextBox()
        Me.txtsalesqty = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtitemid = New System.Windows.Forms.TextBox()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.txtstockqty = New System.Windows.Forms.TextBox()
        Me.txtfinalqty = New System.Windows.Forms.TextBox()
        Me.txtfinalamount = New System.Windows.Forms.TextBox()
        Me.lblsalesdate = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.btnsellproduct = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.dgvsales = New System.Windows.Forms.DataGridView()
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpsales
        '
        Me.dtpsales.Location = New System.Drawing.Point(649, 26)
        Me.dtpsales.Name = "dtpsales"
        Me.dtpsales.Size = New System.Drawing.Size(200, 20)
        Me.dtpsales.TabIndex = 0
        '
        'lblsalesid
        '
        Me.lblsalesid.AutoSize = True
        Me.lblsalesid.Location = New System.Drawing.Point(47, 33)
        Me.lblsalesid.Name = "lblsalesid"
        Me.lblsalesid.Size = New System.Drawing.Size(0, 13)
        Me.lblsalesid.TabIndex = 1
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Location = New System.Drawing.Point(26, 106)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(82, 13)
        Me.lblcustomername.TabIndex = 2
        Me.lblcustomername.Text = "Customer Name"
        '
        'lblcustomerid
        '
        Me.lblcustomerid.AutoSize = True
        Me.lblcustomerid.Location = New System.Drawing.Point(26, 155)
        Me.lblcustomerid.Name = "lblcustomerid"
        Me.lblcustomerid.Size = New System.Drawing.Size(62, 13)
        Me.lblcustomerid.TabIndex = 3
        Me.lblcustomerid.Text = "CustomerID"
        '
        'lblsaleqty
        '
        Me.lblsaleqty.AutoSize = True
        Me.lblsaleqty.Location = New System.Drawing.Point(26, 200)
        Me.lblsaleqty.Name = "lblsaleqty"
        Me.lblsaleqty.Size = New System.Drawing.Size(44, 13)
        Me.lblsaleqty.TabIndex = 4
        Me.lblsaleqty.Text = "SaleQty"
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Location = New System.Drawing.Point(26, 250)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(43, 13)
        Me.lblamount.TabIndex = 5
        Me.lblamount.Text = "Amount"
        '
        'lblitemname
        '
        Me.lblitemname.AutoSize = True
        Me.lblitemname.Location = New System.Drawing.Point(246, 106)
        Me.lblitemname.Name = "lblitemname"
        Me.lblitemname.Size = New System.Drawing.Size(58, 13)
        Me.lblitemname.TabIndex = 6
        Me.lblitemname.Text = "Item Name"
        '
        'lblitemid
        '
        Me.lblitemid.AutoSize = True
        Me.lblitemid.Location = New System.Drawing.Point(246, 170)
        Me.lblitemid.Name = "lblitemid"
        Me.lblitemid.Size = New System.Drawing.Size(38, 13)
        Me.lblitemid.TabIndex = 7
        Me.lblitemid.Text = "ItemID"
        '
        'lblbrand
        '
        Me.lblbrand.AutoSize = True
        Me.lblbrand.Location = New System.Drawing.Point(246, 233)
        Me.lblbrand.Name = "lblbrand"
        Me.lblbrand.Size = New System.Drawing.Size(35, 13)
        Me.lblbrand.TabIndex = 8
        Me.lblbrand.Text = "Brand"
        '
        'lblprice
        '
        Me.lblprice.AutoSize = True
        Me.lblprice.Location = New System.Drawing.Point(439, 145)
        Me.lblprice.Name = "lblprice"
        Me.lblprice.Size = New System.Drawing.Size(31, 13)
        Me.lblprice.TabIndex = 9
        Me.lblprice.Text = "Price"
        '
        'lblstockqty
        '
        Me.lblstockqty.AutoSize = True
        Me.lblstockqty.Location = New System.Drawing.Point(439, 203)
        Me.lblstockqty.Name = "lblstockqty"
        Me.lblstockqty.Size = New System.Drawing.Size(51, 13)
        Me.lblstockqty.TabIndex = 10
        Me.lblstockqty.Text = "StockQty"
        '
        'lblfinalqty
        '
        Me.lblfinalqty.AutoSize = True
        Me.lblfinalqty.Location = New System.Drawing.Point(767, 125)
        Me.lblfinalqty.Name = "lblfinalqty"
        Me.lblfinalqty.Size = New System.Drawing.Size(45, 13)
        Me.lblfinalqty.TabIndex = 11
        Me.lblfinalqty.Text = "FinalQty"
        '
        'lblfinalamount
        '
        Me.lblfinalamount.AutoSize = True
        Me.lblfinalamount.Location = New System.Drawing.Point(760, 203)
        Me.lblfinalamount.Name = "lblfinalamount"
        Me.lblfinalamount.Size = New System.Drawing.Size(68, 13)
        Me.lblfinalamount.TabIndex = 12
        Me.lblfinalamount.Text = "Final Amount"
        '
        'cbocusname
        '
        Me.cbocusname.FormattingEnabled = True
        Me.cbocusname.Location = New System.Drawing.Point(114, 103)
        Me.cbocusname.Name = "cbocusname"
        Me.cbocusname.Size = New System.Drawing.Size(121, 21)
        Me.cbocusname.TabIndex = 13
        '
        'cboitemname
        '
        Me.cboitemname.FormattingEnabled = True
        Me.cboitemname.Location = New System.Drawing.Point(310, 103)
        Me.cboitemname.Name = "cboitemname"
        Me.cboitemname.Size = New System.Drawing.Size(121, 21)
        Me.cboitemname.TabIndex = 14
        '
        'txtcusid
        '
        Me.txtcusid.Location = New System.Drawing.Point(114, 148)
        Me.txtcusid.Name = "txtcusid"
        Me.txtcusid.Size = New System.Drawing.Size(121, 20)
        Me.txtcusid.TabIndex = 15
        '
        'txtsalesqty
        '
        Me.txtsalesqty.Location = New System.Drawing.Point(114, 200)
        Me.txtsalesqty.Name = "txtsalesqty"
        Me.txtsalesqty.Size = New System.Drawing.Size(121, 20)
        Me.txtsalesqty.TabIndex = 16
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(114, 247)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(121, 20)
        Me.txtamount.TabIndex = 17
        '
        'txtitemid
        '
        Me.txtitemid.Location = New System.Drawing.Point(312, 167)
        Me.txtitemid.Name = "txtitemid"
        Me.txtitemid.Size = New System.Drawing.Size(120, 20)
        Me.txtitemid.TabIndex = 18
        '
        'txtbrand
        '
        Me.txtbrand.Location = New System.Drawing.Point(312, 226)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(121, 20)
        Me.txtbrand.TabIndex = 19
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(496, 138)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(121, 20)
        Me.txtprice.TabIndex = 20
        '
        'txtstockqty
        '
        Me.txtstockqty.Location = New System.Drawing.Point(496, 200)
        Me.txtstockqty.Name = "txtstockqty"
        Me.txtstockqty.Size = New System.Drawing.Size(121, 20)
        Me.txtstockqty.TabIndex = 21
        '
        'txtfinalqty
        '
        Me.txtfinalqty.Location = New System.Drawing.Point(717, 148)
        Me.txtfinalqty.Name = "txtfinalqty"
        Me.txtfinalqty.Size = New System.Drawing.Size(121, 20)
        Me.txtfinalqty.TabIndex = 22
        '
        'txtfinalamount
        '
        Me.txtfinalamount.Location = New System.Drawing.Point(717, 230)
        Me.txtfinalamount.Name = "txtfinalamount"
        Me.txtfinalamount.Size = New System.Drawing.Size(121, 20)
        Me.txtfinalamount.TabIndex = 23
        '
        'lblsalesdate
        '
        Me.lblsalesdate.AutoSize = True
        Me.lblsalesdate.Location = New System.Drawing.Point(584, 32)
        Me.lblsalesdate.Name = "lblsalesdate"
        Me.lblsalesdate.Size = New System.Drawing.Size(59, 13)
        Me.lblsalesdate.TabIndex = 24
        Me.lblsalesdate.Text = "Sales Date"
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(442, 240)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 25
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(542, 240)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 26
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'btnsellproduct
        '
        Me.btnsellproduct.Location = New System.Drawing.Point(763, 269)
        Me.btnsellproduct.Name = "btnsellproduct"
        Me.btnsellproduct.Size = New System.Drawing.Size(75, 23)
        Me.btnsellproduct.TabIndex = 27
        Me.btnsellproduct.Text = "Sell Product"
        Me.btnsellproduct.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(763, 316)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 28
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'dgvsales
        '
        Me.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsales.Location = New System.Drawing.Point(12, 289)
        Me.dgvsales.Name = "dgvsales"
        Me.dgvsales.Size = New System.Drawing.Size(733, 177)
        Me.dgvsales.TabIndex = 29
        '
        'sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 474)
        Me.Controls.Add(Me.dgvsales)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsellproduct)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblsalesdate)
        Me.Controls.Add(Me.txtfinalamount)
        Me.Controls.Add(Me.txtfinalqty)
        Me.Controls.Add(Me.txtstockqty)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.txtitemid)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtsalesqty)
        Me.Controls.Add(Me.txtcusid)
        Me.Controls.Add(Me.cboitemname)
        Me.Controls.Add(Me.cbocusname)
        Me.Controls.Add(Me.lblfinalamount)
        Me.Controls.Add(Me.lblfinalqty)
        Me.Controls.Add(Me.lblstockqty)
        Me.Controls.Add(Me.lblprice)
        Me.Controls.Add(Me.lblbrand)
        Me.Controls.Add(Me.lblitemid)
        Me.Controls.Add(Me.lblitemname)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.lblsaleqty)
        Me.Controls.Add(Me.lblcustomerid)
        Me.Controls.Add(Me.lblcustomername)
        Me.Controls.Add(Me.lblsalesid)
        Me.Controls.Add(Me.dtpsales)
        Me.Name = "sales"
        Me.Text = "sales"
        CType(Me.dgvsales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpsales As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblsalesid As System.Windows.Forms.Label
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents lblcustomerid As System.Windows.Forms.Label
    Friend WithEvents lblsaleqty As System.Windows.Forms.Label
    Friend WithEvents lblamount As System.Windows.Forms.Label
    Friend WithEvents lblitemname As System.Windows.Forms.Label
    Friend WithEvents lblitemid As System.Windows.Forms.Label
    Friend WithEvents lblbrand As System.Windows.Forms.Label
    Friend WithEvents lblprice As System.Windows.Forms.Label
    Friend WithEvents lblstockqty As System.Windows.Forms.Label
    Friend WithEvents lblfinalqty As System.Windows.Forms.Label
    Friend WithEvents lblfinalamount As System.Windows.Forms.Label
    Friend WithEvents cbocusname As System.Windows.Forms.ComboBox
    Friend WithEvents cboitemname As System.Windows.Forms.ComboBox
    Friend WithEvents txtcusid As System.Windows.Forms.TextBox
    Friend WithEvents txtsalesqty As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtitemid As System.Windows.Forms.TextBox
    Friend WithEvents txtbrand As System.Windows.Forms.TextBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents txtstockqty As System.Windows.Forms.TextBox
    Friend WithEvents txtfinalqty As System.Windows.Forms.TextBox
    Friend WithEvents txtfinalamount As System.Windows.Forms.TextBox
    Friend WithEvents lblsalesdate As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
    Friend WithEvents btnsellproduct As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents dgvsales As System.Windows.Forms.DataGridView
End Class
