<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIPriceUpdate
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
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(27, 23)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(344, 26)
        Me.FilePath.TabIndex = 0
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Location = New System.Drawing.Point(377, 16)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(92, 33)
        Me.BrowseFileButton.TabIndex = 1
        Me.BrowseFileButton.Text = "Browse"
        Me.BrowseFileButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(189, 73)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(108, 43)
        Me.ImportButton.TabIndex = 2
        Me.ImportButton.Text = "Import"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PIPriceUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 161)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.BrowseFileButton)
        Me.Controls.Add(Me.FilePath)
        Me.Name = "PIPriceUpdate"
        Me.Text = "PIPriceUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FilePath As System.Windows.Forms.TextBox
    Friend WithEvents BrowseFileButton As System.Windows.Forms.Button
    Friend WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
