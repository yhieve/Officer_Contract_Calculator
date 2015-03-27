Public Class PIPriceUpdate

    Private Sub BrowseFileButton_Click(sender As Object, e As EventArgs) Handles BrowseFileButton.Click
        OpenFileDialog1.Filter = "CSV File | *.csv"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub
End Class