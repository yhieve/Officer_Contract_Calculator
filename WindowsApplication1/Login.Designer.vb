<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.User_Name = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.User_Name_Label = New System.Windows.Forms.Label()
        Me.Password_Label = New System.Windows.Forms.Label()
        Me.Login_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'User_Name
        '
        Me.User_Name.Location = New System.Drawing.Point(81, 48)
        Me.User_Name.Name = "User_Name"
        Me.User_Name.Size = New System.Drawing.Size(121, 20)
        Me.User_Name.TabIndex = 0
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(81, 88)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(121, 20)
        Me.Password.TabIndex = 1
        '
        'User_Name_Label
        '
        Me.User_Name_Label.AutoSize = True
        Me.User_Name_Label.Location = New System.Drawing.Point(15, 55)
        Me.User_Name_Label.Name = "User_Name_Label"
        Me.User_Name_Label.Size = New System.Drawing.Size(60, 13)
        Me.User_Name_Label.TabIndex = 2
        Me.User_Name_Label.Text = "User Name"
        '
        'Password_Label
        '
        Me.Password_Label.AutoSize = True
        Me.Password_Label.Location = New System.Drawing.Point(22, 95)
        Me.Password_Label.Name = "Password_Label"
        Me.Password_Label.Size = New System.Drawing.Size(53, 13)
        Me.Password_Label.TabIndex = 3
        Me.Password_Label.Text = "Password"
        '
        'Login_Button
        '
        Me.Login_Button.Location = New System.Drawing.Point(25, 140)
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(75, 23)
        Me.Login_Button.TabIndex = 4
        Me.Login_Button.Text = "Login"
        Me.Login_Button.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Location = New System.Drawing.Point(127, 140)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 188)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Login_Button)
        Me.Controls.Add(Me.Password_Label)
        Me.Controls.Add(Me.User_Name_Label)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.User_Name)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents User_Name As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents User_Name_Label As System.Windows.Forms.Label
    Friend WithEvents Password_Label As System.Windows.Forms.Label
    Friend WithEvents Login_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
End Class
