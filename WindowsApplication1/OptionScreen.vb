Public Class OptionScreen

    Private Sub Ore_Calculator_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ore_Calculator_Button.Click
        Loading.Visible = True
        Dim myform As New OreCalculator
        myform.Show()
        Loading.Visible = False
    End Sub

    Private Sub Ore_Price_Updater_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ore_Price_Updater_Button.Click
        Dim myform As New MiningPriceUpdate
        myform.Show()
        Loading.Visible = False
    End Sub

    Private Sub PI_Price_Updater_Button_Click(sender As Object, e As EventArgs) Handles PI_Price_Updater_Button.Click
        Loading.Visible = True
        Dim myform As New PIPriceUpdate
        myform.Show()
        Loading.Visible = False
    End Sub

    Private Sub PI_Calculator_Button_Click(sender As Object, e As EventArgs) Handles PI_Calculator_Button.Click
        Loading.Visible = True
        Dim myform As New PICalculator
        myform.Show()
        Loading.Visible = False
    End Sub
End Class