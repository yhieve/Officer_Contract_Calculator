Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Xml

Public Class ItemPriceUpdate
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim Import_Date As DateTime = DateTime.Now
    Dim MSDR As MySqlDataReader
    Private Sub Update_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_All.Click

        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"

        Mysqlconn.Open()
        cmd = New MySqlCommand()
        cmd.Connection = Mysqlconn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Item_Number FROM Buy_Sell_Prices"
        MSDR = cmd.ExecuteReader
        While MSDR.Read()
            import_txt.Visible = True
            Get_Median_Prices(MSDR.GetString(0))
        End While
        MsgBox("Import completed")
    End Sub

    Private Sub Get_Median_Prices(ByVal typeid As String)
        Dim wc As WebClient
        wc = New WebClient
        Dim Response As String
        Response = wc.DownloadString("http://api.eve-central.com/api/marketstat?typeid=" & typeid)
        Dim doc As XmlDocument = New XmlDocument
        doc.LoadXml(Response)
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"
        Mysqlconn.Open()
        Dim list As XmlNodeList = doc.GetElementsByTagName("median")
        Dim cmd2 As MySqlCommand = New MySqlCommand
        cmd2.Connection = Mysqlconn
        cmd2.CommandText = "update_prices"
        cmd2.Parameters.Clear()
        cmd2.Parameters.AddWithValue("median_Buy", list(0).InnerText)
        cmd2.Parameters.AddWithValue("median_Sell", list(1).InnerText)
        cmd2.Parameters.AddWithValue("type_id", typeid)
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.ExecuteNonQuery()
        Mysqlconn.Close()
    End Sub
End Class