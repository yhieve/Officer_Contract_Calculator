<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemPriceUpdate
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
        Me.components = New System.ComponentModel.Container()
        Me.Update_All = New System.Windows.Forms.Button()
        Me.Manual_Override = New System.Windows.Forms.Button()
        Me.Update_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.import_txt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Update_All
        '
        Me.Update_All.Location = New System.Drawing.Point(30, 50)
        Me.Update_All.Name = "Update_All"
        Me.Update_All.Size = New System.Drawing.Size(75, 23)
        Me.Update_All.TabIndex = 0
        Me.Update_All.Text = "Update"
        Me.Update_All.UseVisualStyleBackColor = True
        '
        'Manual_Override
        '
        Me.Manual_Override.Location = New System.Drawing.Point(150, 50)
        Me.Manual_Override.Name = "Manual_Override"
        Me.Manual_Override.Size = New System.Drawing.Size(98, 23)
        Me.Manual_Override.TabIndex = 1
        Me.Manual_Override.Text = "Manual Override"
        Me.Manual_Override.UseVisualStyleBackColor = True
        '
        'import_txt
        '
        Me.import_txt.AutoSize = True
        Me.import_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.import_txt.Location = New System.Drawing.Point(56, 27)
        Me.import_txt.Name = "import_txt"
        Me.import_txt.Size = New System.Drawing.Size(155, 20)
        Me.import_txt.TabIndex = 2
        Me.import_txt.Text = "Import in progress"
        Me.import_txt.Visible = False
        '
        'OrePriceUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(272, 125)
        Me.Controls.Add(Me.import_txt)
        Me.Controls.Add(Me.Manual_Override)
        Me.Controls.Add(Me.Update_All)
        Me.Name = "OrePriceUpdate"
        Me.Text = "OrePriceUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Update_All As System.Windows.Forms.Button
    Friend WithEvents Manual_Override As System.Windows.Forms.Button
    Friend WithEvents Update_Timer As System.Windows.Forms.Timer
    Friend WithEvents import_txt As System.Windows.Forms.Label
End Class
