<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recipt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.purchase_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.billing_panel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.quality = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.amount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Cart1DataDataSet = New Mini_Project.Cart1DataDataSet()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartTableAdapter = New Mini_Project.Cart1DataDataSetTableAdapters.cartTableAdapter()
        Me.CartIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.billing_panel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cart1DataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SandyBrown
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SandyBrown
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Print"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.DarkOrange
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.Tan
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Tan
        Me.BunifuThinButton21.Location = New System.Drawing.Point(232, 566)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(107, 41)
        Me.BunifuThinButton21.TabIndex = 75
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'purchase_btn
        '
        Me.purchase_btn.ActiveBorderThickness = 1
        Me.purchase_btn.ActiveCornerRadius = 20
        Me.purchase_btn.ActiveFillColor = System.Drawing.Color.SandyBrown
        Me.purchase_btn.ActiveForecolor = System.Drawing.Color.Black
        Me.purchase_btn.ActiveLineColor = System.Drawing.Color.SandyBrown
        Me.purchase_btn.BackColor = System.Drawing.SystemColors.Control
        Me.purchase_btn.BackgroundImage = CType(resources.GetObject("purchase_btn.BackgroundImage"), System.Drawing.Image)
        Me.purchase_btn.ButtonText = "Close"
        Me.purchase_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchase_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_btn.ForeColor = System.Drawing.Color.DarkOrange
        Me.purchase_btn.IdleBorderThickness = 1
        Me.purchase_btn.IdleCornerRadius = 20
        Me.purchase_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.purchase_btn.IdleForecolor = System.Drawing.Color.Tan
        Me.purchase_btn.IdleLineColor = System.Drawing.Color.Tan
        Me.purchase_btn.Location = New System.Drawing.Point(114, 566)
        Me.purchase_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.purchase_btn.Name = "purchase_btn"
        Me.purchase_btn.Size = New System.Drawing.Size(107, 41)
        Me.purchase_btn.TabIndex = 76
        Me.purchase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'billing_panel
        '
        Me.billing_panel.Controls.Add(Me.Label6)
        Me.billing_panel.Controls.Add(Me.Label1)
        Me.billing_panel.Controls.Add(Me.Label5)
        Me.billing_panel.Controls.Add(Me.quality)
        Me.billing_panel.Controls.Add(Me.amount)
        Me.billing_panel.Controls.Add(Me.BunifuImageButton1)
        Me.billing_panel.Controls.Add(Me.Label4)
        Me.billing_panel.Controls.Add(Me.Label3)
        Me.billing_panel.Controls.Add(Me.Label2)
        Me.billing_panel.Controls.Add(Me.DataGridView1)
        Me.billing_panel.Location = New System.Drawing.Point(0, -2)
        Me.billing_panel.Margin = New System.Windows.Forms.Padding(2)
        Me.billing_panel.Name = "billing_panel"
        Me.billing_panel.Size = New System.Drawing.Size(469, 561)
        Me.billing_panel.TabIndex = 77
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(118, 520)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 27)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Thank You..Visit Again"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(296, 424)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(58, 424)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Quantity"
        '
        'quality
        '
        Me.quality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.quality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.quality.BackColor = System.Drawing.Color.Linen
        Me.quality.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.quality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quality.Enabled = False
        Me.quality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quality.ForeColor = System.Drawing.Color.Black
        Me.quality.HintForeColor = System.Drawing.Color.Black
        Me.quality.HintText = ""
        Me.quality.isPassword = False
        Me.quality.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.quality.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.quality.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.quality.LineThickness = 3
        Me.quality.Location = New System.Drawing.Point(51, 459)
        Me.quality.Margin = New System.Windows.Forms.Padding(4)
        Me.quality.MaxLength = 32767
        Me.quality.Name = "quality"
        Me.quality.Size = New System.Drawing.Size(91, 35)
        Me.quality.TabIndex = 91
        Me.quality.Text = "Quantity"
        Me.quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'amount
        '
        Me.amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.amount.BackColor = System.Drawing.Color.Linen
        Me.amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.amount.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amount.Enabled = False
        Me.amount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.ForeColor = System.Drawing.Color.Black
        Me.amount.HintForeColor = System.Drawing.Color.Empty
        Me.amount.HintText = ""
        Me.amount.isPassword = False
        Me.amount.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.amount.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.amount.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.amount.LineThickness = 3
        Me.amount.Location = New System.Drawing.Point(296, 459)
        Me.amount.Margin = New System.Windows.Forms.Padding(4)
        Me.amount.MaxLength = 32767
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(96, 35)
        Me.amount.TabIndex = 92
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowBuffering = False
        Me.BunifuImageButton1.AllowToggling = False
        Me.BunifuImageButton1.AllowZooming = False
        Me.BunifuImageButton1.AllowZoomingOnFocus = False
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 20
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(33, 35)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(53, 55)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(122, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = False
        Me.BunifuImageButton1.ShowImageBorders = False
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(53, 55)
        Me.BunifuImageButton1.TabIndex = 90
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 20
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 24)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Ph-9803034685"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 38)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Bangalore"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(181, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 28)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "Royal Blooms"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(198, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartIdDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.AmtDataGridViewTextBoxColumn})
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Chocolate
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Chocolate
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.DataSource = Me.CartBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(120, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.Chocolate
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(12, 122)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(445, 284)
        Me.DataGridView1.TabIndex = 86
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Chocolate
        '
        'Cart1DataDataSet
        '
        Me.Cart1DataDataSet.DataSetName = "Cart1DataDataSet"
        Me.Cart1DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataMember = "cart"
        Me.CartBindingSource.DataSource = Me.Cart1DataDataSet
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'CartIdDataGridViewTextBoxColumn
        '
        Me.CartIdDataGridViewTextBoxColumn.DataPropertyName = "cart_Id"
        Me.CartIdDataGridViewTextBoxColumn.HeaderText = "cart_Id"
        Me.CartIdDataGridViewTextBoxColumn.Name = "CartIdDataGridViewTextBoxColumn"
        Me.CartIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        Me.ProductDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmtDataGridViewTextBoxColumn
        '
        Me.AmtDataGridViewTextBoxColumn.DataPropertyName = "amt"
        Me.AmtDataGridViewTextBoxColumn.HeaderText = "amt"
        Me.AmtDataGridViewTextBoxColumn.Name = "AmtDataGridViewTextBoxColumn"
        Me.AmtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'recipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 618)
        Me.Controls.Add(Me.billing_panel)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.purchase_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "recipt"
        Me.Text = "recipt"
        Me.billing_panel.ResumeLayout(False)
        Me.billing_panel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cart1DataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents purchase_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents billing_panel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents quality As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents amount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Cart1DataDataSet As Cart1DataDataSet
    Friend WithEvents CartBindingSource As BindingSource
    Friend WithEvents CartTableAdapter As Cart1DataDataSetTableAdapters.cartTableAdapter
    Friend WithEvents CartIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
