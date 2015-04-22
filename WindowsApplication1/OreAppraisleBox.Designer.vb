<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OreAppraisleBox
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
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.AppraisleBox = New System.Windows.Forms.RichTextBox()
        Me.Skip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(199, 229)
        Me.Submit_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(77, 27)
        Me.Submit_Button.TabIndex = 100
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(64, 229)
        Me.Clear_All_Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(77, 27)
        Me.Clear_All_Button.TabIndex = 99
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'AppraisleBox
        '
        Me.AppraisleBox.Location = New System.Drawing.Point(41, 19)
        Me.AppraisleBox.Name = "AppraisleBox"
        Me.AppraisleBox.Size = New System.Drawing.Size(393, 205)
        Me.AppraisleBox.TabIndex = 98
        Me.AppraisleBox.Text = ""
        '
        'Skip
        '
        Me.Skip.Location = New System.Drawing.Point(334, 229)
        Me.Skip.Margin = New System.Windows.Forms.Padding(2)
        Me.Skip.Name = "Skip"
        Me.Skip.Size = New System.Drawing.Size(77, 27)
        Me.Skip.TabIndex = 101
        Me.Skip.Text = "Skip"
        Me.Skip.UseVisualStyleBackColor = True
        '
        'OreAppraisleBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Officer_EVE_Ore_Calculator.My.Resources.Resources.NASA_Asteroid_Mining
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 275)
        Me.Controls.Add(Me.Skip)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.AppraisleBox)
        Me.Name = "OreAppraisleBox"
        Me.Text = "OreAppraisleBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
    Friend WithEvents AppraisleBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Skip As System.Windows.Forms.Button
End Class
