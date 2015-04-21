<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIAppraisleBox
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
        Me.AppraisleBox = New System.Windows.Forms.RichTextBox()
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AppraisleBox
        '
        Me.AppraisleBox.Location = New System.Drawing.Point(60, 35)
        Me.AppraisleBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AppraisleBox.Name = "AppraisleBox"
        Me.AppraisleBox.Size = New System.Drawing.Size(588, 313)
        Me.AppraisleBox.TabIndex = 0
        Me.AppraisleBox.Text = ""
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(364, 358)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(116, 42)
        Me.Submit_Button.TabIndex = 97
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(196, 358)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(116, 42)
        Me.Clear_All_Button.TabIndex = 96
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'PIAppraisleBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Officer_EVE_Ore_Calculator.My.Resources.Resources.yellow_violet_planet_by_paulinemoss_d532k8u
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 423)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.AppraisleBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PIAppraisleBox"
        Me.Text = "PIAppraisleBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppraisleBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
End Class
