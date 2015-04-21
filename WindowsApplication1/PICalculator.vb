Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class PICalculator
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Calc_Units1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units1.Leave
        If (IPU1.Text.Trim().Length = 0 Or Units1.Text.Trim().Length = 0) Then
            IskMade1.Text = 0
        Else
            IskMade1.Text = Convert.ToDecimal(IPU1.Text) * Convert.ToDecimal(Units1.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units2.Leave
        If (IPU2.Text.Trim().Length = 0 Or Units2.Text.Trim().Length = 0) Then
            IskMade2.Text = 0
        Else
            IskMade2.Text = Convert.ToDecimal(IPU2.Text) * Convert.ToDecimal(Units2.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units3.Leave
        If (IPU3.Text.Trim().Length = 0 Or Units3.Text.Trim().Length = 0) Then
            IskMade3.Text = 0
        Else
            IskMade3.Text = Convert.ToDecimal(IPU3.Text) * Convert.ToDecimal(Units3.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units4.Leave
        If (IPU4.Text.Trim().Length = 0 Or Units4.Text.Trim().Length = 0) Then
            IskMade4.Text = 0
        Else
            IskMade4.Text = Convert.ToDecimal(IPU4.Text) * Convert.ToDecimal(Units4.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units5.Leave
        If (IPU5.Text.Trim().Length = 0 Or Units5.Text.Trim().Length = 0) Then
            IskMade5.Text = 0
        Else
            IskMade5.Text = Convert.ToDecimal(IPU5.Text) * Convert.ToDecimal(Units5.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units6.Leave
        If (IPU6.Text.Trim().Length = 0 Or Units6.Text.Trim().Length = 0) Then
            IskMade6.Text = 0
        Else
            IskMade6.Text = Convert.ToDecimal(IPU6.Text) * Convert.ToDecimal(Units6.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units7.Leave
        If (IPU7.Text.Trim().Length = 0 Or Units7.Text.Trim().Length = 0) Then
            IskMade7.Text = 0
        Else
            IskMade7.Text = Convert.ToDecimal(IPU7.Text) * Convert.ToDecimal(Units7.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units8.Leave
        If (IPU8.Text.Trim().Length = 0 Or Units8.Text.Trim().Length = 0) Then
            IskMade8.Text = 0
        Else
            IskMade8.Text = Convert.ToDecimal(IPU8.Text) * Convert.ToDecimal(Units8.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units9.Leave
        If (IPU9.Text.Trim().Length = 0 Or Units9.Text.Trim().Length = 0) Then
            IskMade9.Text = 0
        Else
            IskMade9.Text = Convert.ToDecimal(IPU9.Text) * Convert.ToDecimal(Units9.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU10.Text.Trim().Length = 0 Or Units10.Text.Trim().Length = 0) Then
            IskMade10.Text = 0
        Else
            IskMade10.Text = Convert.ToDecimal(IPU10.Text) * Convert.ToDecimal(Units10.Text)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Total_Isk_Made()
        Total_Isk_Made.Text = Convert.ToDecimal(IskMade1.Text) +
            Convert.ToDecimal(IskMade2.Text) +
            Convert.ToDecimal(IskMade3.Text) +
            Convert.ToDecimal(IskMade4.Text) +
            Convert.ToDecimal(IskMade5.Text) +
            Convert.ToDecimal(IskMade6.Text) +
            Convert.ToDecimal(IskMade7.Text) +
            Convert.ToDecimal(IskMade8.Text) +
            Convert.ToDecimal(IskMade9.Text) +
            Convert.ToDecimal(IskMade10.Text)
    End Sub
    Private Sub Clear_All_Button_Click(sender As Object, e As EventArgs) Handles Clear_All_Button.Click
        Item1.Text = ""
        Item2.Text = ""
        Item3.Text = ""
        Item4.Text = ""
        Item5.Text = ""
        Item6.Text = ""
        Item7.Text = ""
        Item8.Text = ""
        Item9.Text = ""
        Item10.Text = ""
        IPU1.Text = ""
        IPU2.Text = ""
        IPU3.Text = ""
        IPU4.Text = ""
        IPU5.Text = ""
        IPU6.Text = ""
        IPU7.Text = ""
        IPU8.Text = ""
        IPU9.Text = ""
        IPU10.Text = ""
        Units1.Text = ""
        Units2.Text = ""
        Units3.Text = ""
        Units4.Text = ""
        Units5.Text = ""
        Units6.Text = ""
        Units7.Text = ""
        Units8.Text = ""
        Units9.Text = ""
        Units10.Text = ""
        IskMade1.Text = "0"
        IskMade2.Text = "0"
        IskMade3.Text = "0"
        IskMade4.Text = "0"
        IskMade5.Text = "0"
        IskMade6.Text = "0"
        IskMade7.Text = "0"
        IskMade8.Text = "0"
        IskMade9.Text = "0"
        IskMade10.Text = "0"
        Character_Name.Text = ""
        Total_Isk_Made.Text = ""
    End Sub

    Private Sub PICalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet1.PI_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet.PI_Prices' table. You can move, or remove it, as needed.
        Me.PI_PricesTableAdapter.Fill(Me.YHIDataSet.PI_Prices)

        IPU1.Text = ""
        IPU2.Text = ""
        IPU3.Text = ""
        IPU4.Text = ""
        IPU5.Text = ""
        IPU6.Text = ""
        IPU7.Text = ""
        IPU8.Text = ""
        IPU9.Text = ""
        IPU10.Text = ""

    End Sub
    Private Sub Item1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item1.SelectedIndexChanged
        If Item1.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item1.SelectedItem.Row
            IPU1.Text = Source_Data.Price
        End If

    End Sub

    Private Sub Item2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item2.SelectedIndexChanged
        If Item2.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item2.SelectedItem.Row
            IPU2.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item3.SelectedIndexChanged
        If Item3.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item3.SelectedItem.Row
            IPU3.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item4.SelectedIndexChanged
        If Item4.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item4.SelectedItem.Row
            IPU4.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item5.SelectedIndexChanged
        If Item5.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item5.SelectedItem.Row
            IPU5.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item6.SelectedIndexChanged
        If Item6.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item6.SelectedItem.Row
            IPU6.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item7.SelectedIndexChanged
        If Item7.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item7.SelectedItem.Row
            IPU7.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item8_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item8.SelectedIndexChanged
        If Item8.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item8.SelectedItem.Row
            IPU8.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item9.SelectedIndexChanged
        If Item9.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item9.SelectedItem.Row
            IPU9.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item10.SelectedIndexChanged
        If Item10.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.PI_PricesRow = Item10.SelectedItem.Row
            IPU10.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        Mysqlconn = New MySqlConnection()
        Mysqlconn.ConnectionString = "server=yhi.is-a-guru.com;Uid=YHI;Pwd=miningore;database=YHI"

        Try
            Mysqlconn.Open()
            If Not String.IsNullOrEmpty(Character_Name.Text) Then
                cmd = New MySqlCommand()
                cmd.Connection = Mysqlconn
                cmd.CommandText = "PI_Purchase"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@character_name", Character_Name.Text)
                cmd.Parameters("@character_name").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@import_date", DateTime.Now)
                cmd.Parameters("@import_date").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@total_isk", Total_Isk_Made.Text)
                cmd.Parameters("@total_isk").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item1", Item1.Text)
                cmd.Parameters("@item1").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units1", Units1.Text)
                cmd.Parameters("@units1").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item2", Item2.Text)
                cmd.Parameters("@item2").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units2", Units2.Text)
                cmd.Parameters("@units2").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item3", Item3.Text)
                cmd.Parameters("@item3").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units3", Units3.Text)
                cmd.Parameters("@units3").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item4", Item4.Text)
                cmd.Parameters("@item4").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units4", Units4.Text)
                cmd.Parameters("@units4").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item5", Item5.Text)
                cmd.Parameters("@item5").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units5", Units5.Text)
                cmd.Parameters("@units5").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item6", Item6.Text)
                cmd.Parameters("@item6").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units6", Units6.Text)
                cmd.Parameters("@units6").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item7", Item7.Text)
                cmd.Parameters("@item7").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units7", Units7.Text)
                cmd.Parameters("@units7").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item8", Item8.Text)
                cmd.Parameters("@item8").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units8", Units8.Text)
                cmd.Parameters("@units8").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item9", Item9.Text)
                cmd.Parameters("@item9").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units9", Units9.Text)
                cmd.Parameters("@units9").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item10", Item10.Text)
                cmd.Parameters("@item10").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units10", Units10.Text)
                cmd.Parameters("@units10").Direction = ParameterDirection.Input

                cmd.ExecuteNonQuery()
                MessageBox.Show("Ore counts for " & Character_Name.Text & " imported successfully")
            Else
                MessageBox.Show("Character name must not be blank")
            End If

        Catch myerror As MySqlException
            MessageBox.Show(myerror.Message)
        Finally
            Mysqlconn.Dispose()
        End Try
    End Sub
    Private Sub Ore_Calculator_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim myform As New OptionScreen
        myform.Show()
        Me.Close()
    End Sub
End Class