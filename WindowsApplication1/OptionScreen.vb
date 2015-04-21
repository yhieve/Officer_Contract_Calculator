Public Class OptionScreen

    Private Sub Ore_Calculator_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ore_Calculator_Button.Click
        Loading.Visible = True
        Dim myform As New OreAppraisleBox
        myform.Show()
        Me.Close()
    End Sub

    Private Sub Ore_Price_Updater_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ore_Price_Updater_Button.Click
        Loading.Visible = True
        Dim myform As New MiningPriceUpdate
        myform.Show()
        Me.Close()
    End Sub

    Private Sub PI_Price_Updater_Button_Click(sender As Object, e As EventArgs) Handles PI_Price_Updater_Button.Click
        Loading.Visible = True
        Dim myform As New PIPriceUpdate
        myform.Show()
        Me.Close()
    End Sub

    Private Sub PI_Calculator_Button_Click(sender As Object, e As EventArgs) Handles PI_Calculator_Button.Click
        Loading.Visible = True
        Dim myform As New PIAppraisleBox
        myform.Show()
        Me.Close()
    End Sub
End Class