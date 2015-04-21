Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.IO
Imports System
Imports System.ComponentModel
Imports System.Windows

Public Class OreAppraisleBox

    Private Sub Clear_All_Button_Click(sender As Object, e As EventArgs) Handles Clear_All_Button.Click
        AppraisleBox.Text = ""
    End Sub

    Private Sub Submit_Button_Click(sender As Object, e As EventArgs) Handles Submit_Button.Click
        'TODO add data formatting and copying
        Dim myform As New OreCalculator
        myform.Show()
    End Sub
    Private Sub Ore_Appraisle_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim myform As New OptionScreen
        myform.Show()
    End Sub
End Class