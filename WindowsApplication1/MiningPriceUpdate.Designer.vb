<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiningPriceUpdate
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
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.BrowseFileButton = New System.Windows.Forms.Button()
        Me.FilePath = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Importing_Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImportButton
        '
        Me.ImportButton.Location = New System.Drawing.Point(189, 87)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(108, 43)
        Me.ImportButton.TabIndex = 5
        Me.ImportButton.Text = "Import"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'BrowseFileButton
        '
        Me.BrowseFileButton.Location = New System.Drawing.Point(377, 30)
        Me.BrowseFileButton.Name = "BrowseFileButton"
        Me.BrowseFileButton.Size = New System.Drawing.Size(92, 33)
        Me.BrowseFileButton.TabIndex = 4
        Me.BrowseFileButton.Text = "Browse"
        Me.BrowseFileButton.UseVisualStyleBackColor = True
        '
        'FilePath
        '
        Me.FilePath.Location = New System.Drawing.Point(27, 37)
        Me.FilePath.Name = "FilePath"
        Me.FilePath.Size = New System.Drawing.Size(344, 26)
        Me.FilePath.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Importing_Label
        '
        Me.Importing_Label.AutoSize = True
        Me.Importing_Label.Location = New System.Drawing.Point(101, 133)
        Me.Importing_Label.Name = "Importing_Label"
        Me.Importing_Label.Size = New System.Drawing.Size(294, 20)
        Me.Importing_Label.TabIndex = 6
        Me.Importing_Label.Text = "Import in progress. Do not close window."
        Me.Importing_Label.Visible = False
        '
        'MiningPriceUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 161)
        Me.Controls.Add(Me.Importing_Label)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.BrowseFileButton)
        Me.Controls.Add(Me.FilePath)
        Me.Name = "MiningPriceUpdate"
        Me.Text = "MiningPriceUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImportButton As System.Windows.Forms.Button
    Friend WithEvents BrowseFileButton As System.Windows.Forms.Button
    Friend WithEvents FilePath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Importing_Label As System.Windows.Forms.Label
End Class
