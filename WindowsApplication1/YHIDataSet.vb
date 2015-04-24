Partial Class YHIDataSet
    Partial Class PI_PricesDataTable

        Private Sub PI_PricesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.M3Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

