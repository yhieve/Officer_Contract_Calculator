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
        Dim PastedString As String
        PastedString = AppraisleBox.Text
        Dim Stringlength As Integer
        Stringlength = PastedString.Length
        Dim StringArray As String()
        StringArray = PastedString.Split(vbLf)
        Dim ItemNames As List(Of String) = New List(Of String)
        Dim ItemAmounts As List(Of String) = New List(Of String)
        Dim M3Amounts As List(Of String) = New List(Of String)
        For Each PastedRecord As String In StringArray
            Dim Array As String() = PastedRecord.Split(Constants.vbTab)
            ItemNames.Add(Array(0))
            ItemAmounts.Add(Array(1))
            M3Amounts.Add(Array(5))
        Next
        Dim myform As New OreCalculator(ItemNames, ItemAmounts, M3Amounts)
        myform.Show()
    End Sub
End Class