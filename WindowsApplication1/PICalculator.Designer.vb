<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PICalculator
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
        Me.Submit_Button = New System.Windows.Forms.Button()
        Me.Item10 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YHIDataSet1 = New Officer_EVE_Ore_Calculator.YHIDataSet()
        Me.Item9 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item8 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item7 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item6 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item5 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item4 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item3 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Item2 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.YHIDataSet = New Officer_EVE_Ore_Calculator.YHIDataSet()
        Me.Clear_All_Button = New System.Windows.Forms.Button()
        Me.IskMade10 = New System.Windows.Forms.TextBox()
        Me.Units10 = New System.Windows.Forms.TextBox()
        Me.IPU10 = New System.Windows.Forms.TextBox()
        Me.IskMade9 = New System.Windows.Forms.TextBox()
        Me.Units9 = New System.Windows.Forms.TextBox()
        Me.IPU9 = New System.Windows.Forms.TextBox()
        Me.IskMade8 = New System.Windows.Forms.TextBox()
        Me.Units8 = New System.Windows.Forms.TextBox()
        Me.IPU8 = New System.Windows.Forms.TextBox()
        Me.IskMade7 = New System.Windows.Forms.TextBox()
        Me.Units7 = New System.Windows.Forms.TextBox()
        Me.IPU7 = New System.Windows.Forms.TextBox()
        Me.IskMade6 = New System.Windows.Forms.TextBox()
        Me.Units6 = New System.Windows.Forms.TextBox()
        Me.IPU6 = New System.Windows.Forms.TextBox()
        Me.IskMade5 = New System.Windows.Forms.TextBox()
        Me.Units5 = New System.Windows.Forms.TextBox()
        Me.IPU5 = New System.Windows.Forms.TextBox()
        Me.IskMade4 = New System.Windows.Forms.TextBox()
        Me.Units4 = New System.Windows.Forms.TextBox()
        Me.IPU4 = New System.Windows.Forms.TextBox()
        Me.IskMade3 = New System.Windows.Forms.TextBox()
        Me.Units3 = New System.Windows.Forms.TextBox()
        Me.IPU3 = New System.Windows.Forms.TextBox()
        Me.IskMade2 = New System.Windows.Forms.TextBox()
        Me.Units2 = New System.Windows.Forms.TextBox()
        Me.IPU2 = New System.Windows.Forms.TextBox()
        Me.Total_Isk_Made = New System.Windows.Forms.TextBox()
        Me.Total_Isk_Made_Label = New System.Windows.Forms.Label()
        Me.Isk_Made_Label = New System.Windows.Forms.Label()
        Me.Units_Label = New System.Windows.Forms.Label()
        Me.ISK_Per_Unit_Label = New System.Windows.Forms.Label()
        Me.Item_Label = New System.Windows.Forms.Label()
        Me.IskMade1 = New System.Windows.Forms.TextBox()
        Me.Units1 = New System.Windows.Forms.TextBox()
        Me.IPU1 = New System.Windows.Forms.TextBox()
        Me.Item1 = New System.Windows.Forms.ComboBox()
        Me.PIPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Character_Name = New System.Windows.Forms.TextBox()
        Me.Character_Name_Label = New System.Windows.Forms.Label()
        Me.PI_PricesTableAdapter = New Officer_EVE_Ore_Calculator.YHIDataSetTableAdapters.PI_PricesTableAdapter()
        CType(Me.PIPricesBindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YHIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YHIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Submit_Button
        '
        Me.Submit_Button.Location = New System.Drawing.Point(508, 633)
        Me.Submit_Button.Name = "Submit_Button"
        Me.Submit_Button.Size = New System.Drawing.Size(115, 41)
        Me.Submit_Button.TabIndex = 95
        Me.Submit_Button.Text = "Submit"
        Me.Submit_Button.UseVisualStyleBackColor = True
        '
        'Item10
        '
        Me.Item10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item10.DataSource = Me.PIPricesBindingSource9
        Me.Item10.DisplayMember = "Item"
        Me.Item10.FormattingEnabled = True
        Me.Item10.Location = New System.Drawing.Point(75, 577)
        Me.Item10.Name = "Item10"
        Me.Item10.Size = New System.Drawing.Size(233, 28)
        Me.Item10.TabIndex = 90
        '
        'PIPricesBindingSource9
        '
        Me.PIPricesBindingSource9.DataMember = "PI_Prices"
        Me.PIPricesBindingSource9.DataSource = Me.YHIDataSet1
        '
        'YHIDataSet1
        '
        Me.YHIDataSet1.DataSetName = "YHIDataSet"
        Me.YHIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Item9
        '
        Me.Item9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item9.DataSource = Me.PIPricesBindingSource8
        Me.Item9.DisplayMember = "Item"
        Me.Item9.FormattingEnabled = True
        Me.Item9.Location = New System.Drawing.Point(75, 516)
        Me.Item9.Name = "Item9"
        Me.Item9.Size = New System.Drawing.Size(233, 28)
        Me.Item9.TabIndex = 86
        '
        'PIPricesBindingSource8
        '
        Me.PIPricesBindingSource8.DataMember = "PI_Prices"
        Me.PIPricesBindingSource8.DataSource = Me.YHIDataSet1
        '
        'Item8
        '
        Me.Item8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item8.DataSource = Me.PIPricesBindingSource7
        Me.Item8.DisplayMember = "Item"
        Me.Item8.FormattingEnabled = True
        Me.Item8.Location = New System.Drawing.Point(75, 460)
        Me.Item8.Name = "Item8"
        Me.Item8.Size = New System.Drawing.Size(233, 28)
        Me.Item8.TabIndex = 82
        '
        'PIPricesBindingSource7
        '
        Me.PIPricesBindingSource7.DataMember = "PI_Prices"
        Me.PIPricesBindingSource7.DataSource = Me.YHIDataSet1
        '
        'Item7
        '
        Me.Item7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item7.DataSource = Me.PIPricesBindingSource6
        Me.Item7.DisplayMember = "Item"
        Me.Item7.FormattingEnabled = True
        Me.Item7.Location = New System.Drawing.Point(75, 408)
        Me.Item7.Name = "Item7"
        Me.Item7.Size = New System.Drawing.Size(233, 28)
        Me.Item7.TabIndex = 78
        '
        'PIPricesBindingSource6
        '
        Me.PIPricesBindingSource6.DataMember = "PI_Prices"
        Me.PIPricesBindingSource6.DataSource = Me.YHIDataSet1
        '
        'Item6
        '
        Me.Item6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item6.DataSource = Me.PIPricesBindingSource5
        Me.Item6.DisplayMember = "Item"
        Me.Item6.FormattingEnabled = True
        Me.Item6.Location = New System.Drawing.Point(75, 357)
        Me.Item6.Name = "Item6"
        Me.Item6.Size = New System.Drawing.Size(233, 28)
        Me.Item6.TabIndex = 74
        '
        'PIPricesBindingSource5
        '
        Me.PIPricesBindingSource5.DataMember = "PI_Prices"
        Me.PIPricesBindingSource5.DataSource = Me.YHIDataSet1
        '
        'Item5
        '
        Me.Item5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item5.DataSource = Me.PIPricesBindingSource4
        Me.Item5.DisplayMember = "Item"
        Me.Item5.FormattingEnabled = True
        Me.Item5.Location = New System.Drawing.Point(75, 303)
        Me.Item5.Name = "Item5"
        Me.Item5.Size = New System.Drawing.Size(233, 28)
        Me.Item5.TabIndex = 70
        '
        'PIPricesBindingSource4
        '
        Me.PIPricesBindingSource4.DataMember = "PI_Prices"
        Me.PIPricesBindingSource4.DataSource = Me.YHIDataSet1
        '
        'Item4
        '
        Me.Item4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item4.DataSource = Me.PIPricesBindingSource3
        Me.Item4.DisplayMember = "Item"
        Me.Item4.FormattingEnabled = True
        Me.Item4.Location = New System.Drawing.Point(75, 249)
        Me.Item4.Name = "Item4"
        Me.Item4.Size = New System.Drawing.Size(233, 28)
        Me.Item4.TabIndex = 66
        '
        'PIPricesBindingSource3
        '
        Me.PIPricesBindingSource3.DataMember = "PI_Prices"
        Me.PIPricesBindingSource3.DataSource = Me.YHIDataSet1
        '
        'Item3
        '
        Me.Item3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item3.DataSource = Me.PIPricesBindingSource2
        Me.Item3.DisplayMember = "Item"
        Me.Item3.FormattingEnabled = True
        Me.Item3.Location = New System.Drawing.Point(75, 196)
        Me.Item3.Name = "Item3"
        Me.Item3.Size = New System.Drawing.Size(233, 28)
        Me.Item3.TabIndex = 62
        '
        'PIPricesBindingSource2
        '
        Me.PIPricesBindingSource2.DataMember = "PI_Prices"
        Me.PIPricesBindingSource2.DataSource = Me.YHIDataSet1
        '
        'Item2
        '
        Me.Item2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item2.DataSource = Me.PIPricesBindingSource1
        Me.Item2.DisplayMember = "Item"
        Me.Item2.FormattingEnabled = True
        Me.Item2.Location = New System.Drawing.Point(75, 146)
        Me.Item2.Name = "Item2"
        Me.Item2.Size = New System.Drawing.Size(233, 28)
        Me.Item2.TabIndex = 58
        '
        'PIPricesBindingSource1
        '
        Me.PIPricesBindingSource1.DataMember = "PI_Prices"
        Me.PIPricesBindingSource1.DataSource = Me.YHIDataSet
        '
        'YHIDataSet
        '
        Me.YHIDataSet.DataSetName = "YHIDataSet"
        Me.YHIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Clear_All_Button
        '
        Me.Clear_All_Button.Location = New System.Drawing.Point(341, 633)
        Me.Clear_All_Button.Name = "Clear_All_Button"
        Me.Clear_All_Button.Size = New System.Drawing.Size(115, 41)
        Me.Clear_All_Button.TabIndex = 94
        Me.Clear_All_Button.Text = "Clear All"
        Me.Clear_All_Button.UseVisualStyleBackColor = True
        '
        'IskMade10
        '
        Me.IskMade10.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade10.Enabled = False
        Me.IskMade10.Location = New System.Drawing.Point(732, 579)
        Me.IskMade10.Name = "IskMade10"
        Me.IskMade10.ReadOnly = True
        Me.IskMade10.Size = New System.Drawing.Size(137, 26)
        Me.IskMade10.TabIndex = 93
        Me.IskMade10.Text = "0"
        '
        'Units10
        '
        Me.Units10.Location = New System.Drawing.Point(549, 581)
        Me.Units10.Name = "Units10"
        Me.Units10.Size = New System.Drawing.Size(137, 26)
        Me.Units10.TabIndex = 92
        '
        'IPU10
        '
        Me.IPU10.BackColor = System.Drawing.SystemColors.Window
        Me.IPU10.Enabled = False
        Me.IPU10.Location = New System.Drawing.Point(357, 579)
        Me.IPU10.Name = "IPU10"
        Me.IPU10.ReadOnly = True
        Me.IPU10.Size = New System.Drawing.Size(137, 26)
        Me.IPU10.TabIndex = 91
        '
        'IskMade9
        '
        Me.IskMade9.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade9.Enabled = False
        Me.IskMade9.Location = New System.Drawing.Point(732, 518)
        Me.IskMade9.Name = "IskMade9"
        Me.IskMade9.ReadOnly = True
        Me.IskMade9.Size = New System.Drawing.Size(137, 26)
        Me.IskMade9.TabIndex = 89
        Me.IskMade9.Text = "0"
        '
        'Units9
        '
        Me.Units9.Location = New System.Drawing.Point(549, 520)
        Me.Units9.Name = "Units9"
        Me.Units9.Size = New System.Drawing.Size(137, 26)
        Me.Units9.TabIndex = 88
        '
        'IPU9
        '
        Me.IPU9.BackColor = System.Drawing.SystemColors.Window
        Me.IPU9.Enabled = False
        Me.IPU9.Location = New System.Drawing.Point(357, 518)
        Me.IPU9.Name = "IPU9"
        Me.IPU9.ReadOnly = True
        Me.IPU9.Size = New System.Drawing.Size(137, 26)
        Me.IPU9.TabIndex = 87
        '
        'IskMade8
        '
        Me.IskMade8.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade8.Enabled = False
        Me.IskMade8.Location = New System.Drawing.Point(732, 462)
        Me.IskMade8.Name = "IskMade8"
        Me.IskMade8.ReadOnly = True
        Me.IskMade8.Size = New System.Drawing.Size(137, 26)
        Me.IskMade8.TabIndex = 85
        Me.IskMade8.Text = "0"
        '
        'Units8
        '
        Me.Units8.Location = New System.Drawing.Point(549, 464)
        Me.Units8.Name = "Units8"
        Me.Units8.Size = New System.Drawing.Size(137, 26)
        Me.Units8.TabIndex = 84
        '
        'IPU8
        '
        Me.IPU8.BackColor = System.Drawing.SystemColors.Window
        Me.IPU8.Enabled = False
        Me.IPU8.Location = New System.Drawing.Point(357, 462)
        Me.IPU8.Name = "IPU8"
        Me.IPU8.ReadOnly = True
        Me.IPU8.Size = New System.Drawing.Size(137, 26)
        Me.IPU8.TabIndex = 83
        '
        'IskMade7
        '
        Me.IskMade7.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade7.Enabled = False
        Me.IskMade7.Location = New System.Drawing.Point(732, 410)
        Me.IskMade7.Name = "IskMade7"
        Me.IskMade7.ReadOnly = True
        Me.IskMade7.Size = New System.Drawing.Size(137, 26)
        Me.IskMade7.TabIndex = 81
        Me.IskMade7.Text = "0"
        '
        'Units7
        '
        Me.Units7.Location = New System.Drawing.Point(549, 412)
        Me.Units7.Name = "Units7"
        Me.Units7.Size = New System.Drawing.Size(137, 26)
        Me.Units7.TabIndex = 80
        '
        'IPU7
        '
        Me.IPU7.BackColor = System.Drawing.SystemColors.Window
        Me.IPU7.Enabled = False
        Me.IPU7.Location = New System.Drawing.Point(357, 410)
        Me.IPU7.Name = "IPU7"
        Me.IPU7.ReadOnly = True
        Me.IPU7.Size = New System.Drawing.Size(137, 26)
        Me.IPU7.TabIndex = 79
        '
        'IskMade6
        '
        Me.IskMade6.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade6.Enabled = False
        Me.IskMade6.Location = New System.Drawing.Point(732, 359)
        Me.IskMade6.Name = "IskMade6"
        Me.IskMade6.ReadOnly = True
        Me.IskMade6.Size = New System.Drawing.Size(137, 26)
        Me.IskMade6.TabIndex = 77
        Me.IskMade6.Text = "0"
        '
        'Units6
        '
        Me.Units6.Location = New System.Drawing.Point(549, 361)
        Me.Units6.Name = "Units6"
        Me.Units6.Size = New System.Drawing.Size(137, 26)
        Me.Units6.TabIndex = 76
        '
        'IPU6
        '
        Me.IPU6.BackColor = System.Drawing.SystemColors.Window
        Me.IPU6.Enabled = False
        Me.IPU6.Location = New System.Drawing.Point(357, 359)
        Me.IPU6.Name = "IPU6"
        Me.IPU6.ReadOnly = True
        Me.IPU6.Size = New System.Drawing.Size(137, 26)
        Me.IPU6.TabIndex = 75
        '
        'IskMade5
        '
        Me.IskMade5.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade5.Enabled = False
        Me.IskMade5.Location = New System.Drawing.Point(732, 305)
        Me.IskMade5.Name = "IskMade5"
        Me.IskMade5.ReadOnly = True
        Me.IskMade5.Size = New System.Drawing.Size(137, 26)
        Me.IskMade5.TabIndex = 73
        Me.IskMade5.Text = "0"
        '
        'Units5
        '
        Me.Units5.Location = New System.Drawing.Point(549, 307)
        Me.Units5.Name = "Units5"
        Me.Units5.Size = New System.Drawing.Size(137, 26)
        Me.Units5.TabIndex = 72
        '
        'IPU5
        '
        Me.IPU5.BackColor = System.Drawing.SystemColors.Window
        Me.IPU5.Enabled = False
        Me.IPU5.Location = New System.Drawing.Point(357, 305)
        Me.IPU5.Name = "IPU5"
        Me.IPU5.ReadOnly = True
        Me.IPU5.Size = New System.Drawing.Size(137, 26)
        Me.IPU5.TabIndex = 71
        '
        'IskMade4
        '
        Me.IskMade4.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade4.Enabled = False
        Me.IskMade4.Location = New System.Drawing.Point(732, 251)
        Me.IskMade4.Name = "IskMade4"
        Me.IskMade4.ReadOnly = True
        Me.IskMade4.Size = New System.Drawing.Size(137, 26)
        Me.IskMade4.TabIndex = 69
        Me.IskMade4.Text = "0"
        '
        'Units4
        '
        Me.Units4.Location = New System.Drawing.Point(549, 253)
        Me.Units4.Name = "Units4"
        Me.Units4.Size = New System.Drawing.Size(137, 26)
        Me.Units4.TabIndex = 68
        '
        'IPU4
        '
        Me.IPU4.BackColor = System.Drawing.SystemColors.Window
        Me.IPU4.Enabled = False
        Me.IPU4.Location = New System.Drawing.Point(357, 251)
        Me.IPU4.Name = "IPU4"
        Me.IPU4.ReadOnly = True
        Me.IPU4.Size = New System.Drawing.Size(137, 26)
        Me.IPU4.TabIndex = 67
        '
        'IskMade3
        '
        Me.IskMade3.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade3.Enabled = False
        Me.IskMade3.Location = New System.Drawing.Point(732, 198)
        Me.IskMade3.Name = "IskMade3"
        Me.IskMade3.ReadOnly = True
        Me.IskMade3.Size = New System.Drawing.Size(137, 26)
        Me.IskMade3.TabIndex = 65
        Me.IskMade3.Text = "0"
        '
        'Units3
        '
        Me.Units3.Location = New System.Drawing.Point(549, 200)
        Me.Units3.Name = "Units3"
        Me.Units3.Size = New System.Drawing.Size(137, 26)
        Me.Units3.TabIndex = 64
        '
        'IPU3
        '
        Me.IPU3.BackColor = System.Drawing.SystemColors.Window
        Me.IPU3.Enabled = False
        Me.IPU3.Location = New System.Drawing.Point(357, 198)
        Me.IPU3.Name = "IPU3"
        Me.IPU3.ReadOnly = True
        Me.IPU3.Size = New System.Drawing.Size(137, 26)
        Me.IPU3.TabIndex = 63
        Me.IPU3.Text = " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'IskMade2
        '
        Me.IskMade2.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade2.Enabled = False
        Me.IskMade2.Location = New System.Drawing.Point(732, 148)
        Me.IskMade2.Name = "IskMade2"
        Me.IskMade2.ReadOnly = True
        Me.IskMade2.Size = New System.Drawing.Size(137, 26)
        Me.IskMade2.TabIndex = 61
        Me.IskMade2.Text = "0"
        '
        'Units2
        '
        Me.Units2.Location = New System.Drawing.Point(549, 150)
        Me.Units2.Name = "Units2"
        Me.Units2.Size = New System.Drawing.Size(137, 26)
        Me.Units2.TabIndex = 60
        '
        'IPU2
        '
        Me.IPU2.BackColor = System.Drawing.SystemColors.Window
        Me.IPU2.Enabled = False
        Me.IPU2.Location = New System.Drawing.Point(357, 148)
        Me.IPU2.Name = "IPU2"
        Me.IPU2.ReadOnly = True
        Me.IPU2.Size = New System.Drawing.Size(137, 26)
        Me.IPU2.TabIndex = 59
        '
        'Total_Isk_Made
        '
        Me.Total_Isk_Made.BackColor = System.Drawing.SystemColors.Window
        Me.Total_Isk_Made.Location = New System.Drawing.Point(620, 24)
        Me.Total_Isk_Made.Name = "Total_Isk_Made"
        Me.Total_Isk_Made.ReadOnly = True
        Me.Total_Isk_Made.Size = New System.Drawing.Size(177, 26)
        Me.Total_Isk_Made.TabIndex = 49
        Me.Total_Isk_Made.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Total_Isk_Made_Label
        '
        Me.Total_Isk_Made_Label.AutoSize = True
        Me.Total_Isk_Made_Label.Location = New System.Drawing.Point(501, 24)
        Me.Total_Isk_Made_Label.Name = "Total_Isk_Made_Label"
        Me.Total_Isk_Made_Label.Size = New System.Drawing.Size(113, 20)
        Me.Total_Isk_Made_Label.TabIndex = 48
        Me.Total_Isk_Made_Label.Text = "Total Isk Made"
        '
        'Isk_Made_Label
        '
        Me.Isk_Made_Label.AutoSize = True
        Me.Isk_Made_Label.Location = New System.Drawing.Point(761, 68)
        Me.Isk_Made_Label.Name = "Isk_Made_Label"
        Me.Isk_Made_Label.Size = New System.Drawing.Size(74, 20)
        Me.Isk_Made_Label.TabIndex = 53
        Me.Isk_Made_Label.Text = "Isk Made"
        '
        'Units_Label
        '
        Me.Units_Label.AutoSize = True
        Me.Units_Label.Location = New System.Drawing.Point(596, 68)
        Me.Units_Label.Name = "Units_Label"
        Me.Units_Label.Size = New System.Drawing.Size(46, 20)
        Me.Units_Label.TabIndex = 52
        Me.Units_Label.Text = "Units"
        '
        'ISK_Per_Unit_Label
        '
        Me.ISK_Per_Unit_Label.AutoSize = True
        Me.ISK_Per_Unit_Label.Location = New System.Drawing.Point(380, 68)
        Me.ISK_Per_Unit_Label.Name = "ISK_Per_Unit_Label"
        Me.ISK_Per_Unit_Label.Size = New System.Drawing.Size(91, 20)
        Me.ISK_Per_Unit_Label.TabIndex = 51
        Me.ISK_Per_Unit_Label.Text = "Isk Per Unit"
        '
        'Item_Label
        '
        Me.Item_Label.AutoSize = True
        Me.Item_Label.Location = New System.Drawing.Point(171, 68)
        Me.Item_Label.Name = "Item_Label"
        Me.Item_Label.Size = New System.Drawing.Size(41, 20)
        Me.Item_Label.TabIndex = 50
        Me.Item_Label.Text = "Item"
        '
        'IskMade1
        '
        Me.IskMade1.BackColor = System.Drawing.SystemColors.Window
        Me.IskMade1.Enabled = False
        Me.IskMade1.Location = New System.Drawing.Point(732, 92)
        Me.IskMade1.Name = "IskMade1"
        Me.IskMade1.ReadOnly = True
        Me.IskMade1.Size = New System.Drawing.Size(137, 26)
        Me.IskMade1.TabIndex = 57
        Me.IskMade1.Text = "0"
        '
        'Units1
        '
        Me.Units1.Location = New System.Drawing.Point(549, 94)
        Me.Units1.Name = "Units1"
        Me.Units1.Size = New System.Drawing.Size(137, 26)
        Me.Units1.TabIndex = 56
        '
        'IPU1
        '
        Me.IPU1.BackColor = System.Drawing.SystemColors.Window
        Me.IPU1.Enabled = False
        Me.IPU1.Location = New System.Drawing.Point(357, 92)
        Me.IPU1.Name = "IPU1"
        Me.IPU1.ReadOnly = True
        Me.IPU1.Size = New System.Drawing.Size(137, 26)
        Me.IPU1.TabIndex = 55
        '
        'Item1
        '
        Me.Item1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Item1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item1.DataSource = Me.PIPricesBindingSource
        Me.Item1.DisplayMember = "Item"
        Me.Item1.FormattingEnabled = True
        Me.Item1.Location = New System.Drawing.Point(75, 94)
        Me.Item1.Name = "Item1"
        Me.Item1.Size = New System.Drawing.Size(233, 28)
        Me.Item1.TabIndex = 54
        '
        'PIPricesBindingSource
        '
        Me.PIPricesBindingSource.DataMember = "PI_Prices"
        Me.PIPricesBindingSource.DataSource = Me.YHIDataSet
        '
        'Character_Name
        '
        Me.Character_Name.BackColor = System.Drawing.SystemColors.Window
        Me.Character_Name.Location = New System.Drawing.Point(279, 24)
        Me.Character_Name.Name = "Character_Name"
        Me.Character_Name.Size = New System.Drawing.Size(177, 26)
        Me.Character_Name.TabIndex = 167
        Me.Character_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Character_Name_Label
        '
        Me.Character_Name_Label.AutoSize = True
        Me.Character_Name_Label.Location = New System.Drawing.Point(194, 24)
        Me.Character_Name_Label.Name = "Character_Name_Label"
        Me.Character_Name_Label.Size = New System.Drawing.Size(79, 20)
        Me.Character_Name_Label.TabIndex = 168
        Me.Character_Name_Label.Text = "Character"
        '
        'PI_PricesTableAdapter
        '
        Me.PI_PricesTableAdapter.ClearBeforeFill = True
        '
        'PICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Officer_EVE_Ore_Calculator.My.Resources.Resources.yellow_violet_planet_by_paulinemoss_d532k8u
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(944, 692)
        Me.Controls.Add(Me.Character_Name)
        Me.Controls.Add(Me.Character_Name_Label)
        Me.Controls.Add(Me.Submit_Button)
        Me.Controls.Add(Me.Item10)
        Me.Controls.Add(Me.Item9)
        Me.Controls.Add(Me.Item8)
        Me.Controls.Add(Me.Item7)
        Me.Controls.Add(Me.Item6)
        Me.Controls.Add(Me.Item5)
        Me.Controls.Add(Me.Item4)
        Me.Controls.Add(Me.Item3)
        Me.Controls.Add(Me.Item2)
        Me.Controls.Add(Me.Clear_All_Button)
        Me.Controls.Add(Me.IskMade10)
        Me.Controls.Add(Me.Units10)
        Me.Controls.Add(Me.IPU10)
        Me.Controls.Add(Me.IskMade9)
        Me.Controls.Add(Me.Units9)
        Me.Controls.Add(Me.IPU9)
        Me.Controls.Add(Me.IskMade8)
        Me.Controls.Add(Me.Units8)
        Me.Controls.Add(Me.IPU8)
        Me.Controls.Add(Me.IskMade7)
        Me.Controls.Add(Me.Units7)
        Me.Controls.Add(Me.IPU7)
        Me.Controls.Add(Me.IskMade6)
        Me.Controls.Add(Me.Units6)
        Me.Controls.Add(Me.IPU6)
        Me.Controls.Add(Me.IskMade5)
        Me.Controls.Add(Me.Units5)
        Me.Controls.Add(Me.IPU5)
        Me.Controls.Add(Me.IskMade4)
        Me.Controls.Add(Me.Units4)
        Me.Controls.Add(Me.IPU4)
        Me.Controls.Add(Me.IskMade3)
        Me.Controls.Add(Me.Units3)
        Me.Controls.Add(Me.IPU3)
        Me.Controls.Add(Me.IskMade2)
        Me.Controls.Add(Me.Units2)
        Me.Controls.Add(Me.IPU2)
        Me.Controls.Add(Me.Total_Isk_Made)
        Me.Controls.Add(Me.Total_Isk_Made_Label)
        Me.Controls.Add(Me.Isk_Made_Label)
        Me.Controls.Add(Me.Units_Label)
        Me.Controls.Add(Me.ISK_Per_Unit_Label)
        Me.Controls.Add(Me.Item_Label)
        Me.Controls.Add(Me.IskMade1)
        Me.Controls.Add(Me.Units1)
        Me.Controls.Add(Me.IPU1)
        Me.Controls.Add(Me.Item1)
        Me.Name = "PICalculator"
        Me.Text = "PICalculator"
        CType(Me.PIPricesBindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YHIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YHIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit_Button As System.Windows.Forms.Button
    Friend WithEvents Item10 As System.Windows.Forms.ComboBox
    Friend WithEvents Item9 As System.Windows.Forms.ComboBox
    Friend WithEvents Item8 As System.Windows.Forms.ComboBox
    Friend WithEvents Item7 As System.Windows.Forms.ComboBox
    Friend WithEvents Item6 As System.Windows.Forms.ComboBox
    Friend WithEvents Item5 As System.Windows.Forms.ComboBox
    Friend WithEvents Item4 As System.Windows.Forms.ComboBox
    Friend WithEvents Item3 As System.Windows.Forms.ComboBox
    Friend WithEvents Item2 As System.Windows.Forms.ComboBox
    Friend WithEvents Clear_All_Button As System.Windows.Forms.Button
    Friend WithEvents IskMade10 As System.Windows.Forms.TextBox
    Friend WithEvents Units10 As System.Windows.Forms.TextBox
    Friend WithEvents IPU10 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade9 As System.Windows.Forms.TextBox
    Friend WithEvents Units9 As System.Windows.Forms.TextBox
    Friend WithEvents IPU9 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade8 As System.Windows.Forms.TextBox
    Friend WithEvents Units8 As System.Windows.Forms.TextBox
    Friend WithEvents IPU8 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade7 As System.Windows.Forms.TextBox
    Friend WithEvents Units7 As System.Windows.Forms.TextBox
    Friend WithEvents IPU7 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade6 As System.Windows.Forms.TextBox
    Friend WithEvents Units6 As System.Windows.Forms.TextBox
    Friend WithEvents IPU6 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade5 As System.Windows.Forms.TextBox
    Friend WithEvents Units5 As System.Windows.Forms.TextBox
    Friend WithEvents IPU5 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade4 As System.Windows.Forms.TextBox
    Friend WithEvents Units4 As System.Windows.Forms.TextBox
    Friend WithEvents IPU4 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade3 As System.Windows.Forms.TextBox
    Friend WithEvents Units3 As System.Windows.Forms.TextBox
    Friend WithEvents IPU3 As System.Windows.Forms.TextBox
    Friend WithEvents IskMade2 As System.Windows.Forms.TextBox
    Friend WithEvents Units2 As System.Windows.Forms.TextBox
    Friend WithEvents IPU2 As System.Windows.Forms.TextBox
    Friend WithEvents Total_Isk_Made As System.Windows.Forms.TextBox
    Friend WithEvents Total_Isk_Made_Label As System.Windows.Forms.Label
    Friend WithEvents Isk_Made_Label As System.Windows.Forms.Label
    Friend WithEvents Units_Label As System.Windows.Forms.Label
    Friend WithEvents ISK_Per_Unit_Label As System.Windows.Forms.Label
    Friend WithEvents Item_Label As System.Windows.Forms.Label
    Friend WithEvents IskMade1 As System.Windows.Forms.TextBox
    Friend WithEvents Units1 As System.Windows.Forms.TextBox
    Friend WithEvents IPU1 As System.Windows.Forms.TextBox
    Friend WithEvents Item1 As System.Windows.Forms.ComboBox
    Friend WithEvents Character_Name As System.Windows.Forms.TextBox
    Friend WithEvents Character_Name_Label As System.Windows.Forms.Label
    Friend WithEvents YHIDataSet As Officer_EVE_Ore_Calculator.YHIDataSet
    Friend WithEvents PIPricesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PI_PricesTableAdapter As Officer_EVE_Ore_Calculator.YHIDataSetTableAdapters.PI_PricesTableAdapter
    Friend WithEvents PIPricesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents YHIDataSet1 As Officer_EVE_Ore_Calculator.YHIDataSet
    Friend WithEvents PIPricesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents PIPricesBindingSource9 As System.Windows.Forms.BindingSource
End Class
