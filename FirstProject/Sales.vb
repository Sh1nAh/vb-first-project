Public Class sales
    Dim objCustomer As New ConnectorTableAdapters.CustomerTableAdapter
    Dim objProduct As New ConnectorTableAdapters.ProductTableAdapter
    Dim objSale As New ConnectorTableAdapters.SaleTableAdapter
    Dim objSaleDetail As New ConnectorTableAdapters.SaleDetailTableAdapter
    Dim dt As New DataTable
    Dim dr As DataRow
    Public Sub AutoID()
        Dim sale As New DataTable
        sale = objSale.GetData
        If sale.Rows.Count > 0 Then
            Dim lastrow As Integer = sale.Rows.Count - 1
            Dim oldid As String = sale.Rows(lastrow).Item(0).ToString
            Dim newID As String = Format(CInt(oldid.Substring(2) + 1), "S-0000")
            lblsalesid.Text = newID
        Else
            lblsalesid.Text = "S-0001"
        End If
    End Sub
    Private Sub sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerLoad()
        AutoID()
        ItemLoad()
        AddingColumn()
    End Sub
    Public Sub CustomerLoad()
        Dim CusDT As New DataTable
        CusDT = objCustomer.GetData
        If CusDT.Rows.Count > 0 Then
            For i As Integer = 0 To CusDT.Rows.Count - 1
                cbocusname.Items.Add(CusDT.Rows(i).Item(1).ToString)
            Next
        End If
        cbocusname.Items.Insert(0, "Select Customer Name")
        cbocusname.SelectedIndex = 0
    End Sub
    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocusname.SelectedIndexChanged
        Dim CusDT As New DataTable
        CusDT = objCustomer.GetData
        For i As Integer = 0 To CusDT.Rows.Count - 1
            If cbocusname.SelectedItem.ToString = CusDT.Rows(i).Item(1).ToString Then
                txtcusid.Text = CusDT.Rows(i).Item(0).ToString
            End If
        Next
    End Sub
    Public Sub ItemLoad()
        Dim ItemDT As New DataTable
        ItemDT = objProduct.GetData
        If ItemDT.Rows.Count > 0 Then
            For i As Integer = 0 To ItemDT.Rows.Count - 1
                cboitemname.Items.Add(ItemDT.Rows(i).Item(1).ToString)
            Next
        End If
        cboitemname.Items.Insert(0, "Select Item Name")
        cboitemname.SelectedIndex = 0
    End Sub
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtprice.TextChanged
        If txtprice.TextLength > 0 Then
        End If
    End Sub
    Private Sub cboitemname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboitemname.SelectedIndexChanged
        Dim DT As New DataTable
        DT = objProduct.GetData
        For i As Integer = 0 To DT.Rows.Count - 1
            If cboitemname.SelectedItem.ToString = DT.Rows(i).Item(1).ToString Then
                txtitemid.Text = DT.Rows(i).Item(1).ToString
                txtbrand.Text = DT.Rows(i).Item(1).ToString
                txtprice.Text = DT.Rows(i).Item(1).ToString
                txtstockqty.Text = DT.Rows(i).Item(1).ToString
            End If
        Next
    End Sub
    Public Sub AddingColumn()
        dt.Columns.Clear()
        dr = dt.NewRow
        dr.Table.Columns.Add("Sale ID")
        dr.Table.Columns.Add("Item ID")
        dr.Table.Columns.Add("Price")
        dr.Table.Columns.Add("Quantity")
        dr.Table.Columns.Add("Amount")
        dgvsales.Refresh()
        dgvsales.DataSource = dt
    End Sub
    Public Function qtyValidate()
        If IsNumeric(txtsalesqty.Text) = False Then
            MessageBox.Show("Enter only numbers!")
            txtsalesqty.Clear()
            txtsalesqty.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If qtyValidate() = True Then
            dr = dt.NewRow
            dr(0) = lblsalesid.Text
            dr(1) = txtitemid.Text
            dr(2) = txtprice.Text
            dr(3) = txtsalesqty.Text
            dr(4) = txtamount.Text

            dt.Rows.Add(dr)
            dgvsales.Refresh()
            dgvsales.DataSource = dt
            CalculateTotalAmount()
            CalculateTotalQuantity()
            AddToListClear()
        End If
    End Sub
    Public Sub CalculateTotalAmount()
        Dim totalamount = 0
        Dim totalrow As Integer
        totalrow = dt.Rows.Count
        For i As Integer = 0 To totalrow - 1
            totalamount += CInt(dt.Rows(i).Item(4).ToString)
        Next
        txtfinalamount.Text = totalamount
    End Sub
    Public Sub CalculateTotalQuantity()
        Dim TotalQty = 0
        Dim totalrow As Integer
        totalrow = dt.Rows.Count
        For i As Integer = 0 To totalrow - 1
            TotalQty += CInt(dt.Rows(i).Item(3).ToString)
        Next
        txtfinalqty.Text = TotalQty
    End Sub
    Public Sub AddToListClear()
        cboitemname.SelectedIndex = 0
        txtitemid.Clear()
        txtbrand.Clear()
        txtprice.Clear()
        txtstockqty.Clear()
        txtsalesqty.Text = 0
        txtamount.Text = 0
    End Sub
    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim row As Integer = dgvsales.CurrentRow.Index
        dt.Rows.RemoveAt(row)
        dgvsales.Refresh()
    End Sub
    Public Sub Clear()
        cbocusname.SelectedIndex = 0
        lblcustomerid.Text = ""
        txtfinalqty.Clear()
        txtfinalamount.Clear()
        lblamount.Text = ""
    End Sub
    Private Sub btnsellproduct_Click(sender As Object, e As EventArgs) Handles btnsellproduct.Click
        objSale.InsertQuery(lblsalesid.Text, Today.Date, txtcusid.Text, txtfinalqty.Text, txtfinalamount.Text)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim itemid As String = dt.Rows(i).Item(1).ToString
            Dim price As Integer = dt.Rows(i).Item(2).ToString
            Dim qty As Integer = dt.Rows(i).Item(3).ToString
            Dim amount As Integer = dt.Rows(i).Item(4).ToString
            objSaleDetail.InsertQuery(lblsalesid.Text, txtitemid.Text, price, qty, amount)
            objProduct.DecreaseQty(qty, itemid)
        Next
        MessageBox.Show("Sale Process is completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        AutoID()
        Clear()
    End Sub
    Private Sub txtsalesqty_TextChanged(sender As Object, e As EventArgs) Handles txtsalesqty.TextChanged
        If txtprice.TextLength > 0 Then
            If CInt(txtsalesqty.Text) > CInt(txtstockqty.Text) Then
                MessageBox.Show("You can sale under or equal with StockQty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtsalesqty.Text = 0
                txtsalesqty.Focus()
            Else
                txtamount.Text = CInt(txtprice.Text) * CInt(txtsalesqty.Text)
            End If
        End If
    End Sub
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class