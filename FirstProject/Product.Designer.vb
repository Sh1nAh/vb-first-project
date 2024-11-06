<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtStockQty = New System.Windows.Forms.TextBox()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStockQty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dgvproduct = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(219, 12)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(121, 20)
        Me.txtProductID.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(219, 60)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(121, 20)
        Me.txtProductName.TabIndex = 1
        '
        'txtStockQty
        '
        Me.txtStockQty.Location = New System.Drawing.Point(219, 201)
        Me.txtStockQty.Name = "txtStockQty"
        Me.txtStockQty.Size = New System.Drawing.Size(121, 20)
        Me.txtStockQty.TabIndex = 3
        '
        'cboBrand
        '
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(219, 106)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(121, 21)
        Me.cboBrand.TabIndex = 4
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(123, 18)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(55, 13)
        Me.lblProductID.TabIndex = 5
        Me.lblProductID.Text = "ProductID"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(123, 60)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(75, 13)
        Me.lblProductName.TabIndex = 6
        Me.lblProductName.Text = "Product Name"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(123, 106)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(35, 13)
        Me.lblBrand.TabIndex = 7
        Me.lblBrand.Text = "Brand"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(123, 154)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'lblStockQty
        '
        Me.lblStockQty.AutoSize = True
        Me.lblStockQty.Location = New System.Drawing.Point(123, 197)
        Me.lblStockQty.Name = "lblStockQty"
        Me.lblStockQty.Size = New System.Drawing.Size(51, 13)
        Me.lblStockQty.TabIndex = 9
        Me.lblStockQty.Text = "StockQty"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(374, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(374, 72)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(374, 133)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dgvproduct
        '
        Me.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproduct.Location = New System.Drawing.Point(16, 247)
        Me.dgvproduct.Name = "dgvproduct"
        Me.dgvproduct.Size = New System.Drawing.Size(551, 183)
        Me.dgvproduct.TabIndex = 15
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(374, 197)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 26)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(219, 154)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 16
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 463)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.dgvproduct)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblStockQty)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblProductID)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.txtStockQty)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtProductID)
        Me.Name = "Product"
        Me.Text = "Product"
        CType(Me.dgvproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtProductID As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtStockQty As System.Windows.Forms.TextBox
    Friend WithEvents cboBrand As System.Windows.Forms.ComboBox
    Friend WithEvents lblProductID As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblStockQty As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgvproduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
End Class
