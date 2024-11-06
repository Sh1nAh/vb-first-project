Public Class Customer
    Dim objCustomer As New ConnectorTableAdapters.CustomerTableAdapter

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvcustomer.DataSource = objCustomer.GetData
    End Sub

    Public Sub AutoID()
        Dim dt As New DataTable
        dt = objCustomer.GetData
        If dt.Rows.Count > 0 Then
            Dim lastrow As Integer = dt.Rows.Count - 1
            Dim OldID As String = dt.Rows(lastrow).Item(0).ToString
            Dim NewID As String = Format(CInt(OldID.Substring(2) + 1), "C-0000")
            txtCustomerID.Text = NewID
        Else
            txtCustomerID.Text = "C-0001"
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        AutoID()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        btnNew.Enabled = False
        Clear()
    End Sub

    Public Function Customervalidate()
        If txtName.Text = "" Then
            MessageBox.Show("Enter Name", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
            Return False
        ElseIf IsNumeric(txtName.Text) = True Then
            MessageBox.Show("Name must be words", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Clear()
            txtName.Focus()
            Return False
        ElseIf txtAddress.Text = "" Then
            MessageBox.Show("Enter Address", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtAddress.Focus()
            Return False
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("Enter Phone", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPhone.Focus()
            Return False
        End If
        Return True
    End Function

    Public Sub Clear()
        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Customervalidate() = True Then
            objCustomer.InsertQuery(txtCustomerID.Text, txtName.Text, txtAddress.Text, txtPhone.Text)
            MessageBox.Show("Successfully Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvcustomer.DataSource = objCustomer.GetData
            Clear()
            AutoID()
            btnDelete.Enabled = True
            btnUpdate.Enabled = True
            btnClose.Enabled = True
            btnNew.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Customervalidate() = True Then
            objCustomer.UpdateQuery(txtName.Text, txtAddress.Text, txtPhone.Text, txtCustomerID.Text)
            MessageBox.Show("successfully Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvcustomer.DataSource = objCustomer.GetData
            Clear()
            AutoID()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        objCustomer.DeleteQuery(txtCustomerID.Text)
        dgvcustomer.DataSource = objCustomer.GetData
        MessageBox.Show("Deleted")
        Clear()
        AutoID()
    End Sub

    Private Sub dgvcustomer_Click(sender As Object, e As EventArgs) Handles dgvcustomer.Click
        btnUpdate.Visible = True
        btnDelete.Visible = True
        Dim row As Integer = dgvcustomer.CurrentRow.Index
        txtCustomerID.Text = dgvcustomer.Item(0, row).Value.ToString
        txtName.Text = dgvcustomer.Item(1, row).Value.ToString
        txtAddress.Text = dgvcustomer.Item(2, row).Value.ToString
        txtPhone.Text = dgvcustomer.Item(3, row).Value.ToString
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub
End Class
