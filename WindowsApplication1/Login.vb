Imports MySql.Data.MySqlClient
Public Class Login

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Close()
    End Sub

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Login_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login_Button.Click

        MysqlConn = New MySqlConnection()
        MysqlConn.ConnectionString = "server=yhi.is-a-guru.com;userid=YHI;password=miningore;database=YHI"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Login As String
            Login = "SELECT * FROM YHI.Users WHERE User_Name='" & User_Name.Text & "' AND User_PW='" & Password.Text & "' "
            COMMAND = New MySqlCommand(Login, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim myform As New OptionScreen
                myform.Show()
                Me.Close()
            Else
                MessageBox.Show("Username and password do not match")
            End If

            MysqlConn.Close()
            
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class