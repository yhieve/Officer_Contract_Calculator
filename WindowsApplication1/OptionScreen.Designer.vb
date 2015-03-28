<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionScreen))
        Me.Ore_Calculator_Button = New System.Windows.Forms.Button()
        Me.Ore_Price_Updater_Button = New System.Windows.Forms.Button()
        Me.PI_Calculator_Button = New System.Windows.Forms.Button()
        Me.PI_Price_Updater_Button = New System.Windows.Forms.Button()
        Me.Inventory_Button = New System.Windows.Forms.Button()
        Me.Build_Info_Button = New System.Windows.Forms.Button()
        Me.Loading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ore_Calculator_Button
        '
        Me.Ore_Calculator_Button.Location = New System.Drawing.Point(38, 34)
        Me.Ore_Calculator_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ore_Calculator_Button.Name = "Ore_Calculator_Button"
        Me.Ore_Calculator_Button.Size = New System.Drawing.Size(144, 35)
        Me.Ore_Calculator_Button.TabIndex = 0
        Me.Ore_Calculator_Button.Text = "Ore Calculator"
        Me.Ore_Calculator_Button.UseVisualStyleBackColor = True
        '
        'Ore_Price_Updater_Button
        '
        Me.Ore_Price_Updater_Button.Location = New System.Drawing.Point(218, 34)
        Me.Ore_Price_Updater_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ore_Price_Updater_Button.Name = "Ore_Price_Updater_Button"
        Me.Ore_Price_Updater_Button.Size = New System.Drawing.Size(174, 35)
        Me.Ore_Price_Updater_Button.TabIndex = 1
        Me.Ore_Price_Updater_Button.Text = "Ore Price Updater"
        Me.Ore_Price_Updater_Button.UseVisualStyleBackColor = True
        '
        'PI_Calculator_Button
        '
        Me.PI_Calculator_Button.Location = New System.Drawing.Point(38, 118)
        Me.PI_Calculator_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PI_Calculator_Button.Name = "PI_Calculator_Button"
        Me.PI_Calculator_Button.Size = New System.Drawing.Size(144, 35)
        Me.PI_Calculator_Button.TabIndex = 2
        Me.PI_Calculator_Button.Text = "PI Calculator"
        Me.PI_Calculator_Button.UseVisualStyleBackColor = True
        '
        'PI_Price_Updater_Button
        '
        Me.PI_Price_Updater_Button.Location = New System.Drawing.Point(218, 118)
        Me.PI_Price_Updater_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PI_Price_Updater_Button.Name = "PI_Price_Updater_Button"
        Me.PI_Price_Updater_Button.Size = New System.Drawing.Size(174, 35)
        Me.PI_Price_Updater_Button.TabIndex = 3
        Me.PI_Price_Updater_Button.Text = "PI Price Updater"
        Me.PI_Price_Updater_Button.UseVisualStyleBackColor = True
        '
        'Inventory_Button
        '
        Me.Inventory_Button.Location = New System.Drawing.Point(38, 212)
        Me.Inventory_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Inventory_Button.Name = "Inventory_Button"
        Me.Inventory_Button.Size = New System.Drawing.Size(144, 35)
        Me.Inventory_Button.TabIndex = 4
        Me.Inventory_Button.Text = "Inventory"
        Me.Inventory_Button.UseVisualStyleBackColor = True
        '
        'Build_Info_Button
        '
        Me.Build_Info_Button.Location = New System.Drawing.Point(218, 212)
        Me.Build_Info_Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Build_Info_Button.Name = "Build_Info_Button"
        Me.Build_Info_Button.Size = New System.Drawing.Size(174, 35)
        Me.Build_Info_Button.TabIndex = 5
        Me.Build_Info_Button.Text = "Build Info"
        Me.Build_Info_Button.UseVisualStyleBackColor = True
        '
        'Loading
        '
        Me.Loading.AutoSize = True
        Me.Loading.Location = New System.Drawing.Point(169, 283)
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(66, 20)
        Me.Loading.TabIndex = 6
        Me.Loading.Text = "Loading"
        Me.Loading.Visible = False
        '
        'OptionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(448, 322)
        Me.Controls.Add(Me.Loading)
        Me.Controls.Add(Me.Build_Info_Button)
        Me.Controls.Add(Me.Inventory_Button)
        Me.Controls.Add(Me.PI_Price_Updater_Button)
        Me.Controls.Add(Me.PI_Calculator_Button)
        Me.Controls.Add(Me.Ore_Price_Updater_Button)
        Me.Controls.Add(Me.Ore_Calculator_Button)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "OptionScreen"
        Me.Text = "Option_Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ore_Calculator_Button As System.Windows.Forms.Button
    Friend WithEvents Ore_Price_Updater_Button As System.Windows.Forms.Button
    Friend WithEvents PI_Calculator_Button As System.Windows.Forms.Button
    Friend WithEvents PI_Price_Updater_Button As System.Windows.Forms.Button
    Friend WithEvents Inventory_Button As System.Windows.Forms.Button
    Friend WithEvents Build_Info_Button As System.Windows.Forms.Button
    Friend WithEvents Loading As System.Windows.Forms.Label
End Class
