<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cart))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuLabel8 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel7 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel6 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel5 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel4 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel3 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel2 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Textbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.delete_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.update_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Textbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.purchase_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuLabel9 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.add_btt = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.quality = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.amount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DataGridView1 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuLabel10 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.Textbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CartDataDataSet = New Mini_Project.CartDataDataSet()
        Me.CartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CartTableAdapter = New Mini_Project.CartDataDataSetTableAdapters.cartTableAdapter()
        Me.CartIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Noto Sans", 14.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(12, 9)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(77, 26)
        Me.BunifuCustomLabel11.TabIndex = 43
        Me.BunifuCustomLabel11.Text = "<- BACK"
        '
        'BunifuLabel8
        '
        Me.BunifuLabel8.AllowParentOverrides = False
        Me.BunifuLabel8.AutoEllipsis = False
        Me.BunifuLabel8.CursorType = Nothing
        Me.BunifuLabel8.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel8.Location = New System.Drawing.Point(133, 100)
        Me.BunifuLabel8.Name = "BunifuLabel8"
        Me.BunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel8.Size = New System.Drawing.Size(8, 28)
        Me.BunifuLabel8.TabIndex = 41
        Me.BunifuLabel8.Text = ":"
        Me.BunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel7
        '
        Me.BunifuLabel7.AllowParentOverrides = False
        Me.BunifuLabel7.AutoEllipsis = False
        Me.BunifuLabel7.CursorType = Nothing
        Me.BunifuLabel7.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel7.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel7.Location = New System.Drawing.Point(133, 323)
        Me.BunifuLabel7.Name = "BunifuLabel7"
        Me.BunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel7.Size = New System.Drawing.Size(8, 28)
        Me.BunifuLabel7.TabIndex = 40
        Me.BunifuLabel7.Text = ":"
        Me.BunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel6
        '
        Me.BunifuLabel6.AllowParentOverrides = False
        Me.BunifuLabel6.AutoEllipsis = False
        Me.BunifuLabel6.CursorType = Nothing
        Me.BunifuLabel6.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel6.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel6.Location = New System.Drawing.Point(133, 154)
        Me.BunifuLabel6.Name = "BunifuLabel6"
        Me.BunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel6.Size = New System.Drawing.Size(8, 28)
        Me.BunifuLabel6.TabIndex = 39
        Me.BunifuLabel6.Text = ":"
        Me.BunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel5
        '
        Me.BunifuLabel5.AllowParentOverrides = False
        Me.BunifuLabel5.AutoEllipsis = False
        Me.BunifuLabel5.CursorType = Nothing
        Me.BunifuLabel5.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel5.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel5.Location = New System.Drawing.Point(133, 208)
        Me.BunifuLabel5.Name = "BunifuLabel5"
        Me.BunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel5.Size = New System.Drawing.Size(8, 28)
        Me.BunifuLabel5.TabIndex = 38
        Me.BunifuLabel5.Text = ":"
        Me.BunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel4
        '
        Me.BunifuLabel4.AllowParentOverrides = False
        Me.BunifuLabel4.AutoEllipsis = False
        Me.BunifuLabel4.CursorType = Nothing
        Me.BunifuLabel4.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel4.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel4.Location = New System.Drawing.Point(21, 323)
        Me.BunifuLabel4.Name = "BunifuLabel4"
        Me.BunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel4.Size = New System.Drawing.Size(79, 28)
        Me.BunifuLabel4.TabIndex = 37
        Me.BunifuLabel4.Text = "Amount"
        Me.BunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel3
        '
        Me.BunifuLabel3.AllowParentOverrides = False
        Me.BunifuLabel3.AutoEllipsis = False
        Me.BunifuLabel3.CursorType = Nothing
        Me.BunifuLabel3.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel3.Location = New System.Drawing.Point(21, 208)
        Me.BunifuLabel3.Name = "BunifuLabel3"
        Me.BunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel3.Size = New System.Drawing.Size(77, 28)
        Me.BunifuLabel3.TabIndex = 36
        Me.BunifuLabel3.Text = "Product"
        Me.BunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel2
        '
        Me.BunifuLabel2.AllowParentOverrides = False
        Me.BunifuLabel2.AutoEllipsis = False
        Me.BunifuLabel2.CursorType = Nothing
        Me.BunifuLabel2.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel2.Location = New System.Drawing.Point(21, 154)
        Me.BunifuLabel2.Name = "BunifuLabel2"
        Me.BunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel2.Size = New System.Drawing.Size(87, 28)
        Me.BunifuLabel2.TabIndex = 35
        Me.BunifuLabel2.Text = "Quantity"
        Me.BunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel1.Location = New System.Drawing.Point(21, 100)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(21, 28)
        Me.BunifuLabel1.TabIndex = 34
        Me.BunifuLabel1.Text = "ID"
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Textbox4
        '
        Me.Textbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox4.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "amt", True))
        Me.Textbox4.Enabled = False
        Me.Textbox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Textbox4.HintForeColor = System.Drawing.Color.Black
        Me.Textbox4.HintText = ""
        Me.Textbox4.isPassword = False
        Me.Textbox4.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox4.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox4.LineThickness = 3
        Me.Textbox4.Location = New System.Drawing.Point(183, 316)
        Me.Textbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox4.MaxLength = 32767
        Me.Textbox4.Name = "Textbox4"
        Me.Textbox4.Size = New System.Drawing.Size(120, 35)
        Me.Textbox4.TabIndex = 33
        Me.Textbox4.Text = "Amount"
        Me.Textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Textbox2
        '
        Me.Textbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox2.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "quantity", True))
        Me.Textbox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox2.ForeColor = System.Drawing.Color.Black
        Me.Textbox2.HintForeColor = System.Drawing.Color.Black
        Me.Textbox2.HintText = ""
        Me.Textbox2.isPassword = False
        Me.Textbox2.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox2.LineThickness = 3
        Me.Textbox2.Location = New System.Drawing.Point(183, 147)
        Me.Textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox2.MaxLength = 32767
        Me.Textbox2.Name = "Textbox2"
        Me.Textbox2.Size = New System.Drawing.Size(120, 35)
        Me.Textbox2.TabIndex = 32
        Me.Textbox2.Text = "Quantity"
        Me.Textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'delete_btn
        '
        Me.delete_btn.ActiveBorderThickness = 1
        Me.delete_btn.ActiveCornerRadius = 20
        Me.delete_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete_btn.ActiveForecolor = System.Drawing.Color.White
        Me.delete_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.delete_btn.BackColor = System.Drawing.Color.IndianRed
        Me.delete_btn.BackgroundImage = CType(resources.GetObject("delete_btn.BackgroundImage"), System.Drawing.Image)
        Me.delete_btn.ButtonText = "Delete"
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.IdleBorderThickness = 1
        Me.delete_btn.IdleCornerRadius = 20
        Me.delete_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.delete_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.delete_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.delete_btn.Location = New System.Drawing.Point(334, 16)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(107, 41)
        Me.delete_btn.TabIndex = 15
        Me.delete_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'update_btn
        '
        Me.update_btn.ActiveBorderThickness = 1
        Me.update_btn.ActiveCornerRadius = 20
        Me.update_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.update_btn.ActiveForecolor = System.Drawing.Color.White
        Me.update_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.update_btn.BackColor = System.Drawing.Color.IndianRed
        Me.update_btn.BackgroundImage = CType(resources.GetObject("update_btn.BackgroundImage"), System.Drawing.Image)
        Me.update_btn.ButtonText = "Update"
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.IdleBorderThickness = 1
        Me.update_btn.IdleCornerRadius = 20
        Me.update_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.update_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.update_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.update_btn.Location = New System.Drawing.Point(184, 16)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(107, 41)
        Me.update_btn.TabIndex = 14
        Me.update_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textbox3
        '
        Me.Textbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox3.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "product", True))
        Me.Textbox3.Enabled = False
        Me.Textbox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox3.ForeColor = System.Drawing.Color.Black
        Me.Textbox3.HintForeColor = System.Drawing.Color.Black
        Me.Textbox3.HintText = ""
        Me.Textbox3.isPassword = False
        Me.Textbox3.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox3.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox3.LineThickness = 3
        Me.Textbox3.Location = New System.Drawing.Point(183, 201)
        Me.Textbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox3.MaxLength = 32767
        Me.Textbox3.Name = "Textbox3"
        Me.Textbox3.Size = New System.Drawing.Size(120, 35)
        Me.Textbox3.TabIndex = 31
        Me.Textbox3.Text = "Product"
        Me.Textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'purchase_btn
        '
        Me.purchase_btn.ActiveBorderThickness = 1
        Me.purchase_btn.ActiveCornerRadius = 20
        Me.purchase_btn.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.purchase_btn.ActiveForecolor = System.Drawing.Color.White
        Me.purchase_btn.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.purchase_btn.BackColor = System.Drawing.Color.IndianRed
        Me.purchase_btn.BackgroundImage = CType(resources.GetObject("purchase_btn.BackgroundImage"), System.Drawing.Image)
        Me.purchase_btn.ButtonText = "Purchase"
        Me.purchase_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchase_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_btn.ForeColor = System.Drawing.Color.White
        Me.purchase_btn.IdleBorderThickness = 1
        Me.purchase_btn.IdleCornerRadius = 20
        Me.purchase_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.purchase_btn.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.purchase_btn.IdleLineColor = System.Drawing.Color.LightGray
        Me.purchase_btn.Location = New System.Drawing.Point(485, 16)
        Me.purchase_btn.Margin = New System.Windows.Forms.Padding(5)
        Me.purchase_btn.Name = "purchase_btn"
        Me.purchase_btn.Size = New System.Drawing.Size(107, 41)
        Me.purchase_btn.TabIndex = 13
        Me.purchase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuLabel9
        '
        Me.BunifuLabel9.AllowParentOverrides = False
        Me.BunifuLabel9.AutoEllipsis = False
        Me.BunifuLabel9.CursorType = Nothing
        Me.BunifuLabel9.Font = New System.Drawing.Font("Noto Sans", 21.75!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuLabel9.ForeColor = System.Drawing.Color.White
        Me.BunifuLabel9.Location = New System.Drawing.Point(375, -4)
        Me.BunifuLabel9.Name = "BunifuLabel9"
        Me.BunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel9.Size = New System.Drawing.Size(55, 39)
        Me.BunifuLabel9.TabIndex = 42
        Me.BunifuLabel9.Text = "Cart"
        Me.BunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.IndianRed
        Me.Panel2.Controls.Add(Me.delete_btn)
        Me.Panel2.Controls.Add(Me.update_btn)
        Me.Panel2.Controls.Add(Me.purchase_btn)
        Me.Panel2.Controls.Add(Me.add_btt)
        Me.Panel2.Location = New System.Drawing.Point(113, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 74)
        Me.Panel2.TabIndex = 30
        '
        'add_btt
        '
        Me.add_btt.ActiveBorderThickness = 1
        Me.add_btt.ActiveCornerRadius = 20
        Me.add_btt.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_btt.ActiveForecolor = System.Drawing.Color.White
        Me.add_btt.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.add_btt.BackColor = System.Drawing.Color.IndianRed
        Me.add_btt.BackgroundImage = CType(resources.GetObject("add_btt.BackgroundImage"), System.Drawing.Image)
        Me.add_btt.ButtonText = "Add"
        Me.add_btt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_btt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btt.ForeColor = System.Drawing.Color.White
        Me.add_btt.IdleBorderThickness = 1
        Me.add_btt.IdleCornerRadius = 20
        Me.add_btt.IdleFillColor = System.Drawing.Color.Transparent
        Me.add_btt.IdleForecolor = System.Drawing.Color.WhiteSmoke
        Me.add_btt.IdleLineColor = System.Drawing.Color.LightGray
        Me.add_btt.Location = New System.Drawing.Point(31, 16)
        Me.add_btt.Margin = New System.Windows.Forms.Padding(5)
        Me.add_btt.Name = "add_btt"
        Me.add_btt.Size = New System.Drawing.Size(107, 41)
        Me.add_btt.TabIndex = 12
        Me.add_btt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.IndianRed
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Total"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.LightGray
        Me.BunifuThinButton21.Location = New System.Drawing.Point(5, 5)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(107, 41)
        Me.BunifuThinButton21.TabIndex = 0
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.quality)
        Me.Panel1.Controls.Add(Me.amount)
        Me.Panel1.Location = New System.Drawing.Point(394, 438)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 57)
        Me.Panel1.TabIndex = 29
        '
        'quality
        '
        Me.quality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.quality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.quality.BackColor = System.Drawing.Color.Gainsboro
        Me.quality.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.quality.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quality.Enabled = False
        Me.quality.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quality.ForeColor = System.Drawing.Color.Black
        Me.quality.HintForeColor = System.Drawing.Color.Black
        Me.quality.HintText = ""
        Me.quality.isPassword = False
        Me.quality.LineFocusedColor = System.Drawing.Color.DimGray
        Me.quality.LineIdleColor = System.Drawing.Color.Gray
        Me.quality.LineMouseHoverColor = System.Drawing.Color.Black
        Me.quality.LineThickness = 3
        Me.quality.Location = New System.Drawing.Point(121, 11)
        Me.quality.Margin = New System.Windows.Forms.Padding(4)
        Me.quality.MaxLength = 32767
        Me.quality.Name = "quality"
        Me.quality.Size = New System.Drawing.Size(120, 35)
        Me.quality.TabIndex = 8
        Me.quality.Text = "Quantity"
        Me.quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'amount
        '
        Me.amount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.amount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.amount.BackColor = System.Drawing.Color.Gainsboro
        Me.amount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.amount.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amount.Enabled = False
        Me.amount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount.ForeColor = System.Drawing.Color.Black
        Me.amount.HintForeColor = System.Drawing.Color.Empty
        Me.amount.HintText = ""
        Me.amount.isPassword = False
        Me.amount.LineFocusedColor = System.Drawing.Color.DimGray
        Me.amount.LineIdleColor = System.Drawing.Color.Gray
        Me.amount.LineMouseHoverColor = System.Drawing.Color.Black
        Me.amount.LineThickness = 3
        Me.amount.Location = New System.Drawing.Point(272, 11)
        Me.amount.Margin = New System.Windows.Forms.Padding(4)
        Me.amount.MaxLength = 32767
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(125, 35)
        Me.amount.TabIndex = 9
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowCustomTheming = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CartIdDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.AmtDataGridViewTextBoxColumn})
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.Maroon
        Me.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon
        Me.DataGridView1.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.CurrentTheme.Name = Nothing
        Me.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.DataSource = Me.CartBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.Maroon
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(336, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(458, 226)
        Me.DataGridView1.TabIndex = 28
        Me.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon
        '
        'Textbox1
        '
        Me.Textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox1.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "cart_Id", True))
        Me.Textbox1.Enabled = False
        Me.Textbox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox1.ForeColor = System.Drawing.Color.Black
        Me.Textbox1.HintForeColor = System.Drawing.Color.Black
        Me.Textbox1.HintText = ""
        Me.Textbox1.isPassword = False
        Me.Textbox1.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox1.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox1.LineThickness = 3
        Me.Textbox1.Location = New System.Drawing.Point(183, 93)
        Me.Textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox1.MaxLength = 32767
        Me.Textbox1.Name = "Textbox1"
        Me.Textbox1.Size = New System.Drawing.Size(120, 35)
        Me.Textbox1.TabIndex = 27
        Me.Textbox1.Text = "Cart ID"
        Me.Textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(36, 263)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 28)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Price"
        '
        'BunifuLabel10
        '
        Me.BunifuLabel10.AllowParentOverrides = False
        Me.BunifuLabel10.AutoEllipsis = False
        Me.BunifuLabel10.CursorType = Nothing
        Me.BunifuLabel10.Font = New System.Drawing.Font("MV Boli", 15.75!)
        Me.BunifuLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuLabel10.Location = New System.Drawing.Point(133, 263)
        Me.BunifuLabel10.Name = "BunifuLabel10"
        Me.BunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel10.Size = New System.Drawing.Size(8, 28)
        Me.BunifuLabel10.TabIndex = 45
        Me.BunifuLabel10.Text = ":"
        Me.BunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.BunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Textbox5
        '
        Me.Textbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Textbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Textbox5.BackColor = System.Drawing.Color.Gainsboro
        Me.Textbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Textbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Textbox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CartBindingSource, "price", True))
        Me.Textbox5.Enabled = False
        Me.Textbox5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textbox5.ForeColor = System.Drawing.Color.Black
        Me.Textbox5.HintForeColor = System.Drawing.Color.Black
        Me.Textbox5.HintText = ""
        Me.Textbox5.isPassword = False
        Me.Textbox5.LineFocusedColor = System.Drawing.Color.DimGray
        Me.Textbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.Textbox5.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Textbox5.LineThickness = 3
        Me.Textbox5.Location = New System.Drawing.Point(183, 255)
        Me.Textbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.Textbox5.MaxLength = 32767
        Me.Textbox5.Name = "Textbox5"
        Me.Textbox5.Size = New System.Drawing.Size(120, 35)
        Me.Textbox5.TabIndex = 44
        Me.Textbox5.Text = "Price"
        Me.Textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CartDataDataSet
        '
        Me.CartDataDataSet.DataSetName = "CartDataDataSet"
        Me.CartDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CartBindingSource
        '
        Me.CartBindingSource.DataMember = "cart"
        Me.CartBindingSource.DataSource = Me.CartDataDataSet
        '
        'CartTableAdapter
        '
        Me.CartTableAdapter.ClearBeforeFill = True
        '
        'CartIdDataGridViewTextBoxColumn
        '
        Me.CartIdDataGridViewTextBoxColumn.DataPropertyName = "cart_Id"
        Me.CartIdDataGridViewTextBoxColumn.HeaderText = "Cart ID"
        Me.CartIdDataGridViewTextBoxColumn.Name = "CartIdDataGridViewTextBoxColumn"
        Me.CartIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'AmtDataGridViewTextBoxColumn
        '
        Me.AmtDataGridViewTextBoxColumn.DataPropertyName = "amt"
        Me.AmtDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmtDataGridViewTextBoxColumn.Name = "AmtDataGridViewTextBoxColumn"
        '
        'cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 495)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuLabel10)
        Me.Controls.Add(Me.Textbox5)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.BunifuLabel8)
        Me.Controls.Add(Me.BunifuLabel7)
        Me.Controls.Add(Me.BunifuLabel6)
        Me.Controls.Add(Me.BunifuLabel5)
        Me.Controls.Add(Me.BunifuLabel4)
        Me.Controls.Add(Me.BunifuLabel3)
        Me.Controls.Add(Me.BunifuLabel2)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.Textbox4)
        Me.Controls.Add(Me.Textbox2)
        Me.Controls.Add(Me.Textbox3)
        Me.Controls.Add(Me.BunifuLabel9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Textbox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cart"
        Me.Text = "cart"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuLabel8 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel7 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel6 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel5 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel4 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel3 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel2 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Textbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents delete_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents update_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Textbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents purchase_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuLabel9 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents add_btt As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents quality As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents amount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DataGridView1 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents BunifuLabel10 As Bunifu.UI.WinForms.BunifuLabel
    Friend WithEvents Textbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CartDataDataSet As CartDataDataSet
    Friend WithEvents CartBindingSource As BindingSource
    Friend WithEvents CartTableAdapter As CartDataDataSetTableAdapters.cartTableAdapter
    Friend WithEvents CartIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
