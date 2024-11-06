Partial Class Connector
    Partial Class SaleDataTable

        Private Sub SaleDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CustomerIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class