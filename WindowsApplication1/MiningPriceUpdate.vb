Imports System.IO
Imports MySql.Data.MySqlClient
Public Class MiningPriceUpdate
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub BrowseFileButton_Click(sender As Object, e As EventArgs) Handles BrowseFileButton.Click
        OpenFileDialog1.Filter = "CSV File | *.csv"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            FilePath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim readText() As String = File.ReadAllLines(FilePath.Text)
        Dim filecolumns() As String
        Dim s As String
        Importing_Label.Visible = True
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"

        Try
            Mysqlconn.Open()
            cmd = New MySqlCommand()
            cmd.Connection = Mysqlconn
            cmd.CommandText = "mining_prices_update"
            cmd.CommandType = CommandType.StoredProcedure
            For Each s In readText
                filecolumns = s.Split(",")
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@item_name", filecolumns(0))
                cmd.Parameters("@item_name").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("Price_Isk", filecolumns(1))
                cmd.Parameters("@item_name").Direction = ParameterDirection.Input
                cmd.ExecuteNonQuery()
            Next
            MessageBox.Show("Import Successful")
        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub
End Class