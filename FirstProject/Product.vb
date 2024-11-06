Public Class Product
    Dim objProduct As New ConnectorTableAdapters.ProductTableAdapter

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvproduct.DataSource = objProduct.GetData
        AutoID()
        AddCategory()
    End Sub

    Public Sub AutoID()
        Dim dt As New DataTable
        dt = objProduct.GetData
        If dt.Rows.Count > 0 Then
            Dim lastrow As Integer = dt.Rows.Count - 1
            Dim OldID As String = dt.Rows(lastrow).Item(0).ToString
            Dim NewID As String = Format(CInt(OldID.Substring(2) + 1), "C-0000")
            txtProductID.Text = NewID
        Else
            txtProductID.Text = "C-0001"
        End If
    End Sub

    Public Function Productvalidate()
        If txtProductName.Text = "" Then
            MessageBox.Show("Enter Name", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtProductName.Focus()
            Return False
        ElseIf IsNumeric(txtPrice.Text) = False Then
            MessageBox.Show("Enter Price", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPrice.Focus()
        ElseIf txtStockQty.Text = "" Then
            MessageBox.Show("Enter StockQty", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtStockQty.Focus()
            Return False
        ElseIf cboBrand.SelectedIndex = 0 Then
            MessageBox.Show("You must choose,Brand")
            cboBrand.Focus()
            Return False
        End If
        Return True
    End Function

    Public Sub Clear()
        txtProductName.Clear()
        txtPrice.Clear()
        txtStockQty.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Productvalidate() = True Then
            objProduct.InsertQuery(txtProductID.Text, txtProductName.Text, cboBrand.Text, txtPrice.Text, txtStockQty.Text)
            MessageBox.Show("Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvproduct.DataSource = objProduct.GetData
            Clear()
            AutoID()
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            btnClose.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Productvalidate() = True Then
            objProduct.UpdateQuery(txtProductID.Text, txtProductName.Text, cboBrand.Text, txtPrice.Text, txtStockQty.Text)
            MessageBox.Show("successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvproduct.DataSource = objProduct.GetData
            Clear()
            AutoID()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        objProduct.DeleteQuery(txtProductID.Text)
        dgvproduct.DataSource = objProduct.GetData
        MessageBox.Show("Deleted")
        Clear()
        AutoID()
    End Sub

    Private Sub dgvproduct_Click(sender As Object, e As EventArgs) Handles dgvproduct.Click
        btnUpdate.Visible = True
        btnDelete.Visible = True
        Dim row As Integer = dgvproduct.CurrentRow.Index
        txtProductID.Text = dgvproduct.Item(0, row).Value.ToString
        txtProductName.Text = dgvproduct.Item(1, row).Value.ToString
        cboBrand.Text = dgvproduct.Item(2, row).Value.ToString
        txtPrice.Text = dgvproduct.Item(3, row).Value.ToString
        txtStockQty.Text = dgvproduct.Item(4, row).Value.ToString
    End Sub
    Public Sub AddCategory()
        cboBrand.Items.Add("Select Brand")
        cboBrand.Items.Add("Dell")
        cboBrand.Items.Add("HP")
        cboBrand.Items.Add("Acer")
        cboBrand.Items.Add("Lenovo")
        cboBrand.SelectedIndex = 0
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class