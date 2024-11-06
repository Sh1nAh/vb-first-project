Public Class Report
    Dim objSaleView As New ConnectorTableAdapters.SaleviewTableAdapter
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If rdoBrand.Checked = True Then
            dgvreport.DataSource = objSaleView.GetDataByBrand(txtbrand.Text)
        ElseIf rdoname.Checked = True Then
            dgvreport.DataSource = objSaleView.GetDataByProductName(txtname.Text)
        ElseIf rdoSaleDate.Checked = True Then
            dgvreport.DataSource = objSaleView.GetDataBySaleDate(dtpDate.Value.Date)
        ElseIf rdoSaleID.Checked = True Then
            dgvreport.DataSource = objSaleView.GetDataBySaleID(txtsaleid.Text)
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class