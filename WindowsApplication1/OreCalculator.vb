Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class OreCalculator
    Dim Mysqlconn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ItemNames As List(Of String) = New List(Of String)
    Dim ItemAmounts As List(Of String) = New List(Of String)
    Dim M3Amounts As List(Of String) = New List(Of String)

    Private Sub Calc_Units1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units1.Leave
        If (IPU1.Text.Trim().Length = 0 Or Units1.Text.Trim().Length = 0) Then
            IskMade1.Text = 0
        Else
            IskMade1.Text = Convert.ToDecimal(IPU1.Text) * Convert.ToDecimal(Units1.Text)
            M3Made1.Text = Convert.ToDecimal(Units1.Text) * Convert.ToDecimal(Item1.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units2.Leave
        If (IPU2.Text.Trim().Length = 0 Or Units2.Text.Trim().Length = 0) Then
            IskMade2.Text = 0
        Else
            IskMade2.Text = Convert.ToDecimal(IPU2.Text) * Convert.ToDecimal(Units2.Text)
            M3Made2.Text = Convert.ToDecimal(Units2.Text) * Convert.ToDecimal(Item2.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units3.Leave
        If (IPU3.Text.Trim().Length = 0 Or Units3.Text.Trim().Length = 0) Then
            IskMade3.Text = 0
        Else
            IskMade3.Text = Convert.ToDecimal(IPU3.Text) * Convert.ToDecimal(Units3.Text)
            M3Made3.Text = Convert.ToDecimal(Units3.Text) * Convert.ToDecimal(Item3.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units4_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units4.Leave
        If (IPU4.Text.Trim().Length = 0 Or Units4.Text.Trim().Length = 0) Then
            IskMade4.Text = 0
        Else
            IskMade4.Text = Convert.ToDecimal(IPU4.Text) * Convert.ToDecimal(Units4.Text)
            M3Made4.Text = Convert.ToDecimal(Units4.Text) * Convert.ToDecimal(Item4.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units5_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units5.Leave
        If (IPU5.Text.Trim().Length = 0 Or Units5.Text.Trim().Length = 0) Then
            IskMade5.Text = 0
        Else
            IskMade5.Text = Convert.ToDecimal(IPU5.Text) * Convert.ToDecimal(Units5.Text)
            M3Made5.Text = Convert.ToDecimal(Units5.Text) * Convert.ToDecimal(Item5.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units6.Leave
        If (IPU6.Text.Trim().Length = 0 Or Units6.Text.Trim().Length = 0) Then
            IskMade6.Text = 0
        Else
            IskMade6.Text = Convert.ToDecimal(IPU6.Text) * Convert.ToDecimal(Units6.Text)
            M3Made6.Text = Convert.ToDecimal(Units6.Text) * Convert.ToDecimal(Item6.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units7_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units7.Leave
        If (IPU7.Text.Trim().Length = 0 Or Units7.Text.Trim().Length = 0) Then
            IskMade7.Text = 0
        Else
            IskMade7.Text = Convert.ToDecimal(IPU7.Text) * Convert.ToDecimal(Units7.Text)
            M3Made7.Text = Convert.ToDecimal(Units7.Text) * Convert.ToDecimal(Item7.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units8_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units8.Leave
        If (IPU8.Text.Trim().Length = 0 Or Units8.Text.Trim().Length = 0) Then
            IskMade8.Text = 0
        Else
            IskMade8.Text = Convert.ToDecimal(IPU8.Text) * Convert.ToDecimal(Units8.Text)
            M3Made8.Text = Convert.ToDecimal(Units8.Text) * Convert.ToDecimal(Item8.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units9_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units9.Leave
        If (IPU9.Text.Trim().Length = 0 Or Units9.Text.Trim().Length = 0) Then
            IskMade9.Text = 0
        Else
            IskMade9.Text = Convert.ToDecimal(IPU9.Text) * Convert.ToDecimal(Units9.Text)
            M3Made9.Text = Convert.ToDecimal(Units9.Text) * Convert.ToDecimal(Item9.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units10_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU10.Text.Trim().Length = 0 Or Units10.Text.Trim().Length = 0) Then
            IskMade10.Text = 0
        Else
            IskMade10.Text = Convert.ToDecimal(IPU10.Text) * Convert.ToDecimal(Units10.Text)
            M3Made10.Text = Convert.ToDecimal(Units10.Text) * Convert.ToDecimal(Item10.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units11_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units10.Leave
        If (IPU11.Text.Trim().Length = 0 Or Units11.Text.Trim().Length = 0) Then
            IskMade11.Text = 0
        Else
            IskMade11.Text = Convert.ToDecimal(IPU11.Text) * Convert.ToDecimal(Units11.Text)
            M3Made11.Text = Convert.ToDecimal(Units11.Text) * Convert.ToDecimal(Item11.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units12_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units12.Leave
        If (IPU12.Text.Trim().Length = 0 Or Units12.Text.Trim().Length = 0) Then
            IskMade12.Text = 0
        Else
            IskMade12.Text = Convert.ToDecimal(IPU12.Text) * Convert.ToDecimal(Units12.Text)
            M3Made12.Text = Convert.ToDecimal(Units12.Text) * Convert.ToDecimal(Item12.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units13_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units13.Leave
        If (IPU13.Text.Trim().Length = 0 Or Units13.Text.Trim().Length = 0) Then
            IskMade13.Text = 0
        Else
            IskMade13.Text = Convert.ToDecimal(IPU13.Text) * Convert.ToDecimal(Units13.Text)
            M3Made13.Text = Convert.ToDecimal(Units13.Text) * Convert.ToDecimal(Item13.SelectedValue)
            Calc_Total_Isk_Made()
        End If
    End Sub
    Private Sub Calc_Units14_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Units14.Leave
        If (IPU14.Text.Trim().Length = 0 Or Units14.Text.Trim().Length = 0) Then
            IskMade14.Text = 0
        Else
            IskMade14.Text = Convert.ToDecimal(IPU14.Text) * Convert.ToDecimal(Units14.Text)
            M3Made14.Text = Convert.ToDecimal(Units14.Text) * Convert.ToDecimal(Item14.SelectedValue)
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
            Convert.ToDecimal(IskMade10.Text) +
            Convert.ToDecimal(IskMade11.Text) +
            Convert.ToDecimal(IskMade12.Text) +
            Convert.ToDecimal(IskMade13.Text) +
            Convert.ToDecimal(IskMade14.Text) +
            Convert.ToDecimal(IskMade15.Text)
        Total_M3_Made.Text = Convert.ToDecimal(M3Made1.Text) +
            Convert.ToDecimal(M3Made2.Text) +
            Convert.ToDecimal(M3Made3.Text) +
            Convert.ToDecimal(M3Made4.Text) +
            Convert.ToDecimal(M3Made5.Text) +
            Convert.ToDecimal(M3Made6.Text) +
            Convert.ToDecimal(M3Made7.Text) +
            Convert.ToDecimal(M3Made8.Text) +
            Convert.ToDecimal(M3Made9.Text) +
            Convert.ToDecimal(M3Made10.Text) +
            Convert.ToDecimal(M3Made11.Text) +
            Convert.ToDecimal(M3Made12.Text) +
            Convert.ToDecimal(M3Made13.Text) +
            Convert.ToDecimal(M3Made14.Text) +
            Convert.ToDecimal(M3Made15.Text)
    End Sub

    Private Sub Clear_All_Button_Click(sender As Object, e As EventArgs) Handles Clear_All_Button.Click
        Item1.Text = " "
        Item2.Text = " "
        Item3.Text = " "
        Item4.Text = " "
        Item5.Text = " "
        Item6.Text = " "
        Item7.Text = " "
        Item8.Text = " "
        Item9.Text = " "
        Item10.Text = " "
        Item11.Text = " "
        Item12.Text = " "
        Item13.Text = " "
        Item14.Text = " "
        Item15.Text = " "
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
        IPU11.Text = ""
        IPU12.Text = ""
        IPU13.Text = ""
        IPU14.Text = ""
        IPU15.Text = ""
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
        Units11.Text = ""
        Units12.Text = ""
        Units13.Text = ""
        Units14.Text = ""
        Units15.Text = ""
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
        IskMade11.Text = "0"
        IskMade12.Text = "0"
        IskMade13.Text = "0"
        IskMade14.Text = "0"
        IskMade15.Text = "0"
        M3Made1.Text = "0"
        M3Made2.Text = "0"
        M3Made3.Text = "0"
        M3Made4.Text = "0"
        M3Made5.Text = "0"
        M3Made6.Text = "0"
        M3Made7.Text = "0"
        M3Made8.Text = "0"
        M3Made9.Text = "0"
        M3Made10.Text = "0"
        M3Made11.Text = "0"
        M3Made12.Text = "0"
        M3Made13.Text = "0"
        M3Made14.Text = "0"
        M3Made15.Text = "0"
        Character_Name.Text = ""
        Total_Isk_Made.Text = ""
        Total_M3_Made.Text = ""
    End Sub
    Private Sub OreCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet1.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet1.Mining_Prices)
        'TODO: This line of code loads data into the 'YHIDataSet.Mining_Prices' table. You can move, or remove it, as needed.
        Me.Mining_PricesTableAdapter.Fill(Me.YHIDataSet.Mining_Prices)

        IPU1.Text = " "
        IPU2.Text = " "
        IPU3.Text = " "
        IPU4.Text = " "
        IPU5.Text = " "
        IPU6.Text = " "
        IPU7.Text = " "
        IPU8.Text = " "
        IPU9.Text = " "
        IPU10.Text = " "
        IPU11.Text = " "
        IPU12.Text = " "
        IPU13.Text = " "
        IPU14.Text = " "
        IPU15.Text = " "

    End Sub
    Private Sub Item1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item1.SelectedIndexChanged
        If Item1.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item1.SelectedItem.Row
            IPU1.Text = Source_Data.Price
        End If

    End Sub

    Private Sub Item2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item2.SelectedIndexChanged
        If Item2.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item2.SelectedItem.Row
            IPU2.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item3.SelectedIndexChanged
        If Item3.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item3.SelectedItem.Row
            IPU3.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item4.SelectedIndexChanged
        If Item4.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item4.SelectedItem.Row
            IPU4.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item5.SelectedIndexChanged
        If Item5.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item5.SelectedItem.Row
            IPU5.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item6.SelectedIndexChanged
        If Item6.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item6.SelectedItem.Row
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
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item8.SelectedItem.Row
            IPU8.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item9.SelectedIndexChanged
        If Item9.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item9.SelectedItem.Row
            IPU9.Text = Source_Data.Price
        End If
    End Sub

    Private Sub Item10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item10.SelectedIndexChanged
        If Item10.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item10.SelectedItem.Row
            IPU10.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item11.SelectedIndexChanged
        If Item11.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item11.SelectedItem.Row
            IPU11.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item12.SelectedIndexChanged
        If Item12.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item12.SelectedItem.Row
            IPU12.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item13_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item13.SelectedIndexChanged
        If Item13.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item13.SelectedItem.Row
            IPU13.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item14_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item14.SelectedIndexChanged
        If Item14.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item14.SelectedItem.Row
            IPU14.Text = Source_Data.Price
        End If
    End Sub
    Private Sub Item15_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Item15.SelectedIndexChanged
        If Item15.SelectedIndex > 0 Then
            Dim Source_Data As Officer_EVE_Ore_Calculator.YHIDataSet.Mining_PricesRow = Item15.SelectedItem.Row
            IPU15.Text = Source_Data.Price
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
                cmd.CommandText = "mining_purchase"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@character_name", Character_Name.Text)
                cmd.Parameters("@character_name").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@import_date", DateTime.Now)
                cmd.Parameters("@import_date").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@total_isk", Total_Isk_Made.Text)
                cmd.Parameters("@total_isk").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@total_m3", Total_M3_Made.Text)
                cmd.Parameters("@total_m3").Direction = ParameterDirection.Input
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
                cmd.Parameters.AddWithValue("@item11", Item11.Text)
                cmd.Parameters("@item11").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units11", Units11.Text)
                cmd.Parameters("@units11").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item12", Item12.Text)
                cmd.Parameters("@item12").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units12", Units12.Text)
                cmd.Parameters("@units12").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item13", Item13.Text)
                cmd.Parameters("@item13").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units13", Units13.Text)
                cmd.Parameters("@units13").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item14", Item14.Text)
                cmd.Parameters("@item14").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units14", Units14.Text)
                cmd.Parameters("@units14").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@item15", Item15.Text)
                cmd.Parameters("@item15").Direction = ParameterDirection.Input
                cmd.Parameters.AddWithValue("@units15", Units15.Text)
                cmd.Parameters("@units15").Direction = ParameterDirection.Input

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
    Public Sub New(ItemNames As List(Of String), ItemAmounts As List(Of String), M3Amounts As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()
        Me.ItemNames = ItemNames
        Me.ItemAmounts = ItemAmounts
        Me.M3Amounts = M3Amounts

    End Sub

    Private Sub OreCalculator_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If ItemNames.Count > 0 Then
            Item1.Text = Me.ItemNames(0)
            Units1.Text = Me.ItemAmounts(0)
            M3Made1.Text = Me.M3Amounts(0)
            IskMade1.Text = Convert.ToDecimal(IPU1.Text) * Convert.ToDecimal(Units1.Text)
            M3Made1.Text = M3Made1.Text.Remove(M3Made1.Text.Length - 3)
        End If
        If ItemNames.Count > 1 Then
            Item2.Text = Me.ItemNames(1)
            Units2.Text = Me.ItemAmounts(1)
            M3Made2.Text = Me.M3Amounts(1)
            IskMade2.Text = Convert.ToDecimal(IPU2.Text) * Convert.ToDecimal(Units2.Text)
            M3Made2.Text = M3Made2.Text.Remove(M3Made2.Text.Length - 3)
        End If
        If ItemNames.Count > 2 Then
            Item3.Text = Me.ItemNames(2)
            Units3.Text = Me.ItemAmounts(2)
            M3Made3.Text = Me.M3Amounts(2)
            IskMade3.Text = Convert.ToDecimal(IPU3.Text) * Convert.ToDecimal(Units3.Text)
            M3Made3.Text = M3Made3.Text.Remove(M3Made3.Text.Length - 3)
        End If
        If ItemNames.Count > 3 Then
            Item4.Text = Me.ItemNames(3)
            Units4.Text = Me.ItemAmounts(3)
            M3Made4.Text = Me.M3Amounts(3)
            IskMade4.Text = Convert.ToDecimal(IPU4.Text) * Convert.ToDecimal(Units4.Text)
            M3Made4.Text = M3Made4.Text.Remove(M3Made4.Text.Length - 3)
        End If
        If ItemNames.Count > 4 Then
            Item5.Text = Me.ItemNames(4)
            Units5.Text = Me.ItemAmounts(4)
            M3Made5.Text = Me.M3Amounts(4)
            IskMade5.Text = Convert.ToDecimal(IPU5.Text) * Convert.ToDecimal(Units5.Text)
            M3Made5.Text = M3Made5.Text.Remove(M3Made5.Text.Length - 3)
        End If
        If ItemNames.Count > 5 Then
            Item6.Text = Me.ItemNames(5)
            Units6.Text = Me.ItemAmounts(5)
            M3Made6.Text = Me.M3Amounts(5)
            IskMade6.Text = Convert.ToDecimal(IPU6.Text) * Convert.ToDecimal(Units6.Text)
            M3Made6.Text = M3Made1.Text.Remove(M3Made6.Text.Length - 3)
        End If
        If ItemNames.Count > 6 Then
            Item7.Text = Me.ItemNames(6)
            Units7.Text = Me.ItemAmounts(6)
            M3Made7.Text = Me.M3Amounts(6)
            IskMade7.Text = Convert.ToDecimal(IPU7.Text) * Convert.ToDecimal(Units7.Text)
            M3Made7.Text = M3Made7.Text.Remove(M3Made7.Text.Length - 3)
        End If
        If ItemNames.Count > 7 Then
            Item8.Text = Me.ItemNames(7)
            Units8.Text = Me.ItemAmounts(7)
            M3Made8.Text = Me.M3Amounts(7)
            IskMade8.Text = Convert.ToDecimal(IPU8.Text) * Convert.ToDecimal(Units8.Text)
            M3Made8.Text = M3Made8.Text.Remove(M3Made8.Text.Length - 3)
        End If
        If ItemNames.Count > 8 Then
            Item9.Text = Me.ItemNames(8)
            Units9.Text = Me.ItemAmounts(8)
            M3Made9.Text = Me.M3Amounts(8)
            IskMade9.Text = Convert.ToDecimal(IPU9.Text) * Convert.ToDecimal(Units9.Text)
            M3Made9.Text = M3Made9.Text.Remove(M3Made9.Text.Length - 3)
        End If
        If ItemNames.Count > 9 Then
            Item10.Text = Me.ItemNames(9)
            Units10.Text = Me.ItemAmounts(9)
            M3Made10.Text = Me.M3Amounts(9)
            IskMade10.Text = Convert.ToDecimal(IPU10.Text) * Convert.ToDecimal(Units10.Text)
            M3Made10.Text = M3Made10.Text.Remove(M3Made10.Text.Length - 3)
        End If
        If ItemNames.Count > 10 Then
            Item11.Text = Me.ItemNames(10)
            Units11.Text = Me.ItemAmounts(10)
            M3Made11.Text = Me.M3Amounts(10)
            IskMade11.Text = Convert.ToDecimal(IPU11.Text) * Convert.ToDecimal(Units11.Text)
            M3Made11.Text = M3Made11.Text.Remove(M3Made11.Text.Length - 3)
        End If
        If ItemNames.Count > 11 Then
            Item12.Text = Me.ItemNames(11)
            Units12.Text = Me.ItemAmounts(11)
            M3Made12.Text = Me.M3Amounts(11)
            IskMade12.Text = Convert.ToDecimal(IPU12.Text) * Convert.ToDecimal(Units12.Text)
            M3Made12.Text = M3Made12.Text.Remove(M3Made12.Text.Length - 3)
        End If
        If ItemNames.Count > 12 Then
            Item13.Text = Me.ItemNames(12)
            Units13.Text = Me.ItemAmounts(12)
            M3Made13.Text = Me.M3Amounts(12)
            IskMade13.Text = Convert.ToDecimal(IPU13.Text) * Convert.ToDecimal(Units13.Text)
            M3Made13.Text = M3Made13.Text.Remove(M3Made13.Text.Length - 3)
        End If
        If ItemNames.Count > 13 Then
            Item14.Text = Me.ItemNames(13)
            Units14.Text = Me.ItemAmounts(13)
            M3Made14.Text = Me.M3Amounts(13)
            IskMade14.Text = Convert.ToDecimal(IPU14.Text) * Convert.ToDecimal(Units14.Text)
            M3Made14.Text = M3Made14.Text.Remove(M3Made14.Text.Length - 3)
        End If
        If ItemNames.Count > 14 Then
            Item15.Text = Me.ItemNames(14)
            Units15.Text = Me.ItemAmounts(14)
            M3Made15.Text = Me.M3Amounts(15)
            IskMade15.Text = Convert.ToDecimal(IPU15.Text) * Convert.ToDecimal(Units15.Text)
            M3Made15.Text = M3Made15.Text.Remove(M3Made15.Text.Length - 3)
        End If
        Calc_Total_Isk_Made()

    End Sub
End Class