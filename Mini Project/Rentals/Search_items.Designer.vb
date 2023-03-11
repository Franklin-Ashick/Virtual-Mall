<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_items
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search_items))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.search_car = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.search_cust = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.search_rental = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.ser_rental = New System.Windows.Forms.Panel()
        Me.textBox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.RentalCarDataSet2 = New Mini_Project.RentalCarDataSet2()
        Me.RentalTableAdapter = New Mini_Project.RentalCarDataSet3TableAdapters.rentalTableAdapter()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSet3 = New Mini_Project.RentalCarDataSet3()
        Me.ser_cust = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LicenceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.textbox11 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.button11 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.CustTableAdapter = New Mini_Project.RentalCarDataSet2TableAdapters.custTableAdapter()
        Me.ser_car = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColourDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MfgdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsurancenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSet1 = New Mini_Project.RentalCarDataSet1()
        Me.textbox111 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.button111 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.CarTableAdapter = New Mini_Project.RentalCarDataSet1TableAdapters.carTableAdapter()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.ser_rental.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ser_cust.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.ser_car.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.search_car)
        Me.Panel1.Controls.Add(Me.search_cust)
        Me.Panel1.Controls.Add(Me.search_rental)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 447)
        Me.Panel1.TabIndex = 10
        '
        'search_car
        '
        Me.search_car.ActiveBorderThickness = 1
        Me.search_car.ActiveCornerRadius = 20
        Me.search_car.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.search_car.ActiveForecolor = System.Drawing.Color.Transparent
        Me.search_car.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.search_car.BackColor = System.Drawing.Color.Transparent
        Me.search_car.BackgroundImage = CType(resources.GetObject("search_car.BackgroundImage"), System.Drawing.Image)
        Me.search_car.ButtonText = "Search  Car"
        Me.search_car.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_car.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_car.ForeColor = System.Drawing.Color.MediumBlue
        Me.search_car.IdleBorderThickness = 1
        Me.search_car.IdleCornerRadius = 30
        Me.search_car.IdleFillColor = System.Drawing.Color.Transparent
        Me.search_car.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.search_car.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.search_car.Location = New System.Drawing.Point(1, 220)
        Me.search_car.Margin = New System.Windows.Forms.Padding(5)
        Me.search_car.Name = "search_car"
        Me.search_car.Size = New System.Drawing.Size(181, 41)
        Me.search_car.TabIndex = 9
        Me.search_car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'search_cust
        '
        Me.search_cust.ActiveBorderThickness = 1
        Me.search_cust.ActiveCornerRadius = 20
        Me.search_cust.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.search_cust.ActiveForecolor = System.Drawing.Color.Transparent
        Me.search_cust.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.search_cust.BackColor = System.Drawing.Color.Transparent
        Me.search_cust.BackgroundImage = CType(resources.GetObject("search_cust.BackgroundImage"), System.Drawing.Image)
        Me.search_cust.ButtonText = "Search Customer"
        Me.search_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_cust.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_cust.ForeColor = System.Drawing.Color.MediumBlue
        Me.search_cust.IdleBorderThickness = 1
        Me.search_cust.IdleCornerRadius = 30
        Me.search_cust.IdleFillColor = System.Drawing.Color.Transparent
        Me.search_cust.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.search_cust.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.search_cust.Location = New System.Drawing.Point(1, 163)
        Me.search_cust.Margin = New System.Windows.Forms.Padding(5)
        Me.search_cust.Name = "search_cust"
        Me.search_cust.Size = New System.Drawing.Size(181, 41)
        Me.search_cust.TabIndex = 8
        Me.search_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'search_rental
        '
        Me.search_rental.ActiveBorderThickness = 1
        Me.search_rental.ActiveCornerRadius = 20
        Me.search_rental.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.search_rental.ActiveForecolor = System.Drawing.Color.Transparent
        Me.search_rental.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.search_rental.BackColor = System.Drawing.Color.Transparent
        Me.search_rental.BackgroundImage = CType(resources.GetObject("search_rental.BackgroundImage"), System.Drawing.Image)
        Me.search_rental.ButtonText = "Search Rental Car"
        Me.search_rental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_rental.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_rental.ForeColor = System.Drawing.Color.MediumBlue
        Me.search_rental.IdleBorderThickness = 1
        Me.search_rental.IdleCornerRadius = 30
        Me.search_rental.IdleFillColor = System.Drawing.Color.Transparent
        Me.search_rental.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.search_rental.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.search_rental.Location = New System.Drawing.Point(1, 106)
        Me.search_rental.Margin = New System.Windows.Forms.Padding(5)
        Me.search_rental.Name = "search_rental"
        Me.search_rental.Size = New System.Drawing.Size(181, 41)
        Me.search_rental.TabIndex = 7
        Me.search_rental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.MidnightBlue
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded
        Me.BunifuSeparator1.LineThickness = 5
        Me.BunifuSeparator1.Location = New System.Drawing.Point(181, 0)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical
        Me.BunifuSeparator1.Size = New System.Drawing.Size(10, 489)
        Me.BunifuSeparator1.TabIndex = 0
        '
        'ser_rental
        '
        Me.ser_rental.BackColor = System.Drawing.Color.Transparent
        Me.ser_rental.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ser_rental.Controls.Add(Me.textBox1)
        Me.ser_rental.Controls.Add(Me.Panel2)
        Me.ser_rental.Controls.Add(Me.dataGridView1)
        Me.ser_rental.Controls.Add(Me.label3)
        Me.ser_rental.Controls.Add(Me.label2)
        Me.ser_rental.Location = New System.Drawing.Point(197, 12)
        Me.ser_rental.Name = "ser_rental"
        Me.ser_rental.Size = New System.Drawing.Size(643, 426)
        Me.ser_rental.TabIndex = 11
        '
        'textBox1
        '
        Me.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textBox1.BackColor = System.Drawing.Color.SeaShell
        Me.textBox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.ForeColor = System.Drawing.Color.Black
        Me.textBox1.HintForeColor = System.Drawing.Color.Black
        Me.textBox1.HintText = ""
        Me.textBox1.isPassword = False
        Me.textBox1.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textBox1.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textBox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textBox1.LineThickness = 2
        Me.textBox1.Location = New System.Drawing.Point(297, 49)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox1.MaxLength = 32767
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(154, 25)
        Me.textBox1.TabIndex = 153
        Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.button1)
        Me.Panel2.Location = New System.Drawing.Point(205, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 54)
        Me.Panel2.TabIndex = 104
        '
        'button1
        '
        Me.button1.ActiveBorderThickness = 1
        Me.button1.ActiveCornerRadius = 20
        Me.button1.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.button1.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button1.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.button1.BackColor = System.Drawing.Color.Transparent
        Me.button1.BackgroundImage = CType(resources.GetObject("button1.BackgroundImage"), System.Drawing.Image)
        Me.button1.ButtonText = "Search"
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.button1.IdleBorderThickness = 1
        Me.button1.IdleCornerRadius = 30
        Me.button1.IdleFillColor = System.Drawing.Color.Transparent
        Me.button1.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.button1.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.button1.Location = New System.Drawing.Point(65, 5)
        Me.button1.Margin = New System.Windows.Forms.Padding(5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(100, 44)
        Me.button1.TabIndex = 103
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CarDataGridViewTextBoxColumn, Me.CnameDataGridViewTextBoxColumn, Me.FromdateDataGridViewTextBoxColumn, Me.ReturndateDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dataGridView1.Location = New System.Drawing.Point(3, 150)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(640, 273)
        Me.dataGridView1.TabIndex = 102
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CarDataGridViewTextBoxColumn
        '
        Me.CarDataGridViewTextBoxColumn.DataPropertyName = "car"
        Me.CarDataGridViewTextBoxColumn.HeaderText = "car"
        Me.CarDataGridViewTextBoxColumn.Name = "CarDataGridViewTextBoxColumn"
        '
        'CnameDataGridViewTextBoxColumn
        '
        Me.CnameDataGridViewTextBoxColumn.DataPropertyName = "c_name"
        Me.CnameDataGridViewTextBoxColumn.HeaderText = "c_name"
        Me.CnameDataGridViewTextBoxColumn.Name = "CnameDataGridViewTextBoxColumn"
        '
        'FromdateDataGridViewTextBoxColumn
        '
        Me.FromdateDataGridViewTextBoxColumn.DataPropertyName = "from_date"
        Me.FromdateDataGridViewTextBoxColumn.HeaderText = "from_date"
        Me.FromdateDataGridViewTextBoxColumn.Name = "FromdateDataGridViewTextBoxColumn"
        '
        'ReturndateDataGridViewTextBoxColumn
        '
        Me.ReturndateDataGridViewTextBoxColumn.DataPropertyName = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.HeaderText = "return_date"
        Me.ReturndateDataGridViewTextBoxColumn.Name = "ReturndateDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(196, 52)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 16)
        Me.label3.TabIndex = 99
        Me.label3.Text = "Car Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.IndianRed
        Me.label2.Location = New System.Drawing.Point(251, 11)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(141, 24)
        Me.label2.TabIndex = 98
        Me.label2.Text = "Car On Rental"
        '
        'RentalCarDataSet2
        '
        Me.RentalCarDataSet2.DataSetName = "RentalCarDataSet2"
        Me.RentalCarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "rental"
        '
        'RentalCarDataSet3
        '
        Me.RentalCarDataSet3.DataSetName = "RentalCarDataSet3"
        Me.RentalCarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ser_cust
        '
        Me.ser_cust.BackColor = System.Drawing.Color.Transparent
        Me.ser_cust.Controls.Add(Me.Label1)
        Me.ser_cust.Controls.Add(Me.Label4)
        Me.ser_cust.Controls.Add(Me.DataGridView2)
        Me.ser_cust.Controls.Add(Me.textbox11)
        Me.ser_cust.Controls.Add(Me.Panel3)
        Me.ser_cust.Location = New System.Drawing.Point(195, 12)
        Me.ser_cust.Name = "ser_cust"
        Me.ser_cust.Size = New System.Drawing.Size(645, 426)
        Me.ser_cust.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(196, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 16)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Customer Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(203, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 24)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Search Customer Record"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.MobDataGridViewTextBoxColumn, Me.LicenceDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.IssuedateDataGridViewTextBoxColumn, Me.AddrDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.CustBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(0, 230)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(638, 193)
        Me.DataGridView2.TabIndex = 157
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "f_name"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "f_name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "l_name"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "l_name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'MobDataGridViewTextBoxColumn
        '
        Me.MobDataGridViewTextBoxColumn.DataPropertyName = "mob"
        Me.MobDataGridViewTextBoxColumn.HeaderText = "mob"
        Me.MobDataGridViewTextBoxColumn.Name = "MobDataGridViewTextBoxColumn"
        '
        'LicenceDataGridViewTextBoxColumn
        '
        Me.LicenceDataGridViewTextBoxColumn.DataPropertyName = "licence"
        Me.LicenceDataGridViewTextBoxColumn.HeaderText = "licence"
        Me.LicenceDataGridViewTextBoxColumn.Name = "LicenceDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'IssuedateDataGridViewTextBoxColumn
        '
        Me.IssuedateDataGridViewTextBoxColumn.DataPropertyName = "issue_date"
        Me.IssuedateDataGridViewTextBoxColumn.HeaderText = "issue_date"
        Me.IssuedateDataGridViewTextBoxColumn.Name = "IssuedateDataGridViewTextBoxColumn"
        '
        'AddrDataGridViewTextBoxColumn
        '
        Me.AddrDataGridViewTextBoxColumn.DataPropertyName = "addr"
        Me.AddrDataGridViewTextBoxColumn.HeaderText = "addr"
        Me.AddrDataGridViewTextBoxColumn.Name = "AddrDataGridViewTextBoxColumn"
        '
        'CustBindingSource
        '
        Me.CustBindingSource.DataMember = "cust"
        Me.CustBindingSource.DataSource = Me.RentalCarDataSet2BindingSource
        '
        'RentalCarDataSet2BindingSource
        '
        Me.RentalCarDataSet2BindingSource.DataSource = Me.RentalCarDataSet2
        Me.RentalCarDataSet2BindingSource.Position = 0
        '
        'textbox11
        '
        Me.textbox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox11.BackColor = System.Drawing.Color.SeaShell
        Me.textbox11.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox11.ForeColor = System.Drawing.Color.Black
        Me.textbox11.HintForeColor = System.Drawing.Color.Black
        Me.textbox11.HintText = ""
        Me.textbox11.isPassword = False
        Me.textbox11.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox11.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox11.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox11.LineThickness = 2
        Me.textbox11.Location = New System.Drawing.Point(299, 105)
        Me.textbox11.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox11.MaxLength = 32767
        Me.textbox11.Name = "textbox11"
        Me.textbox11.Size = New System.Drawing.Size(154, 25)
        Me.textbox11.TabIndex = 156
        Me.textbox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.button11)
        Me.Panel3.Location = New System.Drawing.Point(207, 137)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 54)
        Me.Panel3.TabIndex = 155
        '
        'button11
        '
        Me.button11.ActiveBorderThickness = 1
        Me.button11.ActiveCornerRadius = 20
        Me.button11.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.button11.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button11.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.button11.BackColor = System.Drawing.Color.Transparent
        Me.button11.BackgroundImage = CType(resources.GetObject("button11.BackgroundImage"), System.Drawing.Image)
        Me.button11.ButtonText = "Search"
        Me.button11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button11.ForeColor = System.Drawing.Color.MediumBlue
        Me.button11.IdleBorderThickness = 1
        Me.button11.IdleCornerRadius = 30
        Me.button11.IdleFillColor = System.Drawing.Color.Transparent
        Me.button11.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.button11.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.button11.Location = New System.Drawing.Point(65, 5)
        Me.button11.Margin = New System.Windows.Forms.Padding(5)
        Me.button11.Name = "button11"
        Me.button11.Size = New System.Drawing.Size(100, 44)
        Me.button11.TabIndex = 103
        Me.button11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustTableAdapter
        '
        Me.CustTableAdapter.ClearBeforeFill = True
        '
        'ser_car
        '
        Me.ser_car.BackColor = System.Drawing.Color.Transparent
        Me.ser_car.Controls.Add(Me.Label6)
        Me.ser_car.Controls.Add(Me.Label7)
        Me.ser_car.Controls.Add(Me.DataGridView3)
        Me.ser_car.Controls.Add(Me.textbox111)
        Me.ser_car.Controls.Add(Me.Panel4)
        Me.ser_car.Location = New System.Drawing.Point(192, 12)
        Me.ser_car.Name = "ser_car"
        Me.ser_car.Size = New System.Drawing.Size(648, 423)
        Me.ser_car.TabIndex = 160
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(196, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 16)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Car Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.IndianRed
        Me.Label7.Location = New System.Drawing.Point(209, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 24)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Search Car Record"
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.CarnameDataGridViewTextBoxColumn, Me.CarnoDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.BrandnameDataGridViewTextBoxColumn, Me.ColourDataGridViewTextBoxColumn, Me.MfgdateDataGridViewTextBoxColumn, Me.MilageDataGridViewTextBoxColumn, Me.InsurancenoDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.CarBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(11, 191)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(620, 229)
        Me.DataGridView3.TabIndex = 163
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CarnameDataGridViewTextBoxColumn
        '
        Me.CarnameDataGridViewTextBoxColumn.DataPropertyName = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.HeaderText = "car_name"
        Me.CarnameDataGridViewTextBoxColumn.Name = "CarnameDataGridViewTextBoxColumn"
        '
        'CarnoDataGridViewTextBoxColumn
        '
        Me.CarnoDataGridViewTextBoxColumn.DataPropertyName = "car_no"
        Me.CarnoDataGridViewTextBoxColumn.HeaderText = "car_no"
        Me.CarnoDataGridViewTextBoxColumn.Name = "CarnoDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'BrandnameDataGridViewTextBoxColumn
        '
        Me.BrandnameDataGridViewTextBoxColumn.DataPropertyName = "brand_name"
        Me.BrandnameDataGridViewTextBoxColumn.HeaderText = "brand_name"
        Me.BrandnameDataGridViewTextBoxColumn.Name = "BrandnameDataGridViewTextBoxColumn"
        '
        'ColourDataGridViewTextBoxColumn
        '
        Me.ColourDataGridViewTextBoxColumn.DataPropertyName = "colour"
        Me.ColourDataGridViewTextBoxColumn.HeaderText = "colour"
        Me.ColourDataGridViewTextBoxColumn.Name = "ColourDataGridViewTextBoxColumn"
        '
        'MfgdateDataGridViewTextBoxColumn
        '
        Me.MfgdateDataGridViewTextBoxColumn.DataPropertyName = "mfg_date"
        Me.MfgdateDataGridViewTextBoxColumn.HeaderText = "mfg_date"
        Me.MfgdateDataGridViewTextBoxColumn.Name = "MfgdateDataGridViewTextBoxColumn"
        '
        'MilageDataGridViewTextBoxColumn
        '
        Me.MilageDataGridViewTextBoxColumn.DataPropertyName = "milage"
        Me.MilageDataGridViewTextBoxColumn.HeaderText = "milage"
        Me.MilageDataGridViewTextBoxColumn.Name = "MilageDataGridViewTextBoxColumn"
        '
        'InsurancenoDataGridViewTextBoxColumn
        '
        Me.InsurancenoDataGridViewTextBoxColumn.DataPropertyName = "insurance_no"
        Me.InsurancenoDataGridViewTextBoxColumn.HeaderText = "insurance_no"
        Me.InsurancenoDataGridViewTextBoxColumn.Name = "InsurancenoDataGridViewTextBoxColumn"
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "car"
        Me.CarBindingSource.DataSource = Me.RentalCarDataSet1BindingSource
        '
        'RentalCarDataSet1BindingSource
        '
        Me.RentalCarDataSet1BindingSource.DataSource = Me.RentalCarDataSet1
        Me.RentalCarDataSet1BindingSource.Position = 0
        '
        'RentalCarDataSet1
        '
        Me.RentalCarDataSet1.DataSetName = "RentalCarDataSet1"
        Me.RentalCarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'textbox111
        '
        Me.textbox111.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox111.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox111.BackColor = System.Drawing.Color.SeaShell
        Me.textbox111.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox111.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox111.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox111.ForeColor = System.Drawing.Color.Black
        Me.textbox111.HintForeColor = System.Drawing.Color.Black
        Me.textbox111.HintText = ""
        Me.textbox111.isPassword = False
        Me.textbox111.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox111.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox111.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox111.LineThickness = 2
        Me.textbox111.Location = New System.Drawing.Point(291, 63)
        Me.textbox111.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox111.MaxLength = 32767
        Me.textbox111.Name = "textbox111"
        Me.textbox111.Size = New System.Drawing.Size(154, 25)
        Me.textbox111.TabIndex = 161
        Me.textbox111.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.button111)
        Me.Panel4.Location = New System.Drawing.Point(199, 114)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 54)
        Me.Panel4.TabIndex = 160
        '
        'button111
        '
        Me.button111.ActiveBorderThickness = 1
        Me.button111.ActiveCornerRadius = 20
        Me.button111.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.button111.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button111.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.button111.BackColor = System.Drawing.Color.Transparent
        Me.button111.BackgroundImage = CType(resources.GetObject("button111.BackgroundImage"), System.Drawing.Image)
        Me.button111.ButtonText = "Search"
        Me.button111.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button111.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button111.ForeColor = System.Drawing.Color.MediumBlue
        Me.button111.IdleBorderThickness = 1
        Me.button111.IdleCornerRadius = 30
        Me.button111.IdleFillColor = System.Drawing.Color.Transparent
        Me.button111.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.button111.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.button111.Location = New System.Drawing.Point(65, 5)
        Me.button111.Margin = New System.Windows.Forms.Padding(5)
        Me.button111.Name = "button111"
        Me.button111.Size = New System.Drawing.Size(100, 44)
        Me.button111.TabIndex = 103
        Me.button111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(820, -2)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuCustomLabel3.TabIndex = 161
        Me.BunifuCustomLabel3.Text = "X"
        '
        'Search_items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(845, 447)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ser_rental)
        Me.Controls.Add(Me.ser_car)
        Me.Controls.Add(Me.ser_cust)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search_items"
        Me.Text = "`"
        Me.Panel1.ResumeLayout(False)
        Me.ser_rental.ResumeLayout(False)
        Me.ser_rental.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ser_cust.ResumeLayout(False)
        Me.ser_cust.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ser_car.ResumeLayout(False)
        Me.ser_car.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents search_car As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents search_cust As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents search_rental As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents ser_rental As Panel
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents button1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents textBox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FromdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturndateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RentalCarDataSet2 As RentalCarDataSet2
    Friend WithEvents RentalTableAdapter As RentalCarDataSet3TableAdapters.rentalTableAdapter
    Friend WithEvents RentalBindingSource As BindingSource
    Friend WithEvents RentalCarDataSet3 As RentalCarDataSet3
    Friend WithEvents ser_cust As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents RentalCarDataSet2BindingSource As BindingSource
    Friend WithEvents textbox11 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents button11 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents CustBindingSource As BindingSource
    Friend WithEvents CustTableAdapter As RentalCarDataSet2TableAdapters.custTableAdapter
    Private WithEvents Label1 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LicenceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IssuedateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ser_car As Panel
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents RentalCarDataSet1BindingSource As BindingSource
    Friend WithEvents RentalCarDataSet1 As RentalCarDataSet1
    Friend WithEvents textbox111 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents button111 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As RentalCarDataSet1TableAdapters.carTableAdapter
    Private WithEvents Label6 As Label
    Private WithEvents Label7 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CarnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CarnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ColourDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MfgdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InsurancenoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
