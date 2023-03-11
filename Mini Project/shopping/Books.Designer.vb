<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Books))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btntotal = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnclear = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbobooktype = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cbobuyer = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.lbltotal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtbooks = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.address = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.email = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.phnumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.fname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btntotal)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 534)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(494, 142)
        Me.Panel1.TabIndex = 69
        '
        'btntotal
        '
        Me.btntotal.ActiveBorderThickness = 1
        Me.btntotal.ActiveCornerRadius = 20
        Me.btntotal.ActiveFillColor = System.Drawing.Color.LightCoral
        Me.btntotal.ActiveForecolor = System.Drawing.Color.White
        Me.btntotal.ActiveLineColor = System.Drawing.Color.LightCoral
        Me.btntotal.BackColor = System.Drawing.Color.Transparent
        Me.btntotal.BackgroundImage = CType(resources.GetObject("btntotal.BackgroundImage"), System.Drawing.Image)
        Me.btntotal.ButtonText = "Total"
        Me.btntotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntotal.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntotal.ForeColor = System.Drawing.Color.LightCoral
        Me.btntotal.IdleBorderThickness = 1
        Me.btntotal.IdleCornerRadius = 20
        Me.btntotal.IdleFillColor = System.Drawing.Color.MistyRose
        Me.btntotal.IdleForecolor = System.Drawing.Color.LightCoral
        Me.btntotal.IdleLineColor = System.Drawing.Color.LightCoral
        Me.btntotal.Location = New System.Drawing.Point(379, 5)
        Me.btntotal.Margin = New System.Windows.Forms.Padding(5)
        Me.btntotal.Name = "btntotal"
        Me.btntotal.Size = New System.Drawing.Size(114, 45)
        Me.btntotal.TabIndex = 32
        Me.btntotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnclear
        '
        Me.btnclear.ActiveBorderThickness = 1
        Me.btnclear.ActiveCornerRadius = 20
        Me.btnclear.ActiveFillColor = System.Drawing.Color.LightCoral
        Me.btnclear.ActiveForecolor = System.Drawing.Color.White
        Me.btnclear.ActiveLineColor = System.Drawing.Color.LightCoral
        Me.btnclear.BackColor = System.Drawing.Color.Transparent
        Me.btnclear.BackgroundImage = CType(resources.GetObject("btnclear.BackgroundImage"), System.Drawing.Image)
        Me.btnclear.ButtonText = "Clear"
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.LightCoral
        Me.btnclear.IdleBorderThickness = 1
        Me.btnclear.IdleCornerRadius = 20
        Me.btnclear.IdleFillColor = System.Drawing.Color.MistyRose
        Me.btnclear.IdleForecolor = System.Drawing.Color.LightCoral
        Me.btnclear.IdleLineColor = System.Drawing.Color.LightCoral
        Me.btnclear.Location = New System.Drawing.Point(346, 85)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(5)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(147, 45)
        Me.btnclear.TabIndex = 12
        Me.btnclear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.ActiveBorderThickness = 1
        Me.Button1.ActiveCornerRadius = 20
        Me.Button1.ActiveFillColor = System.Drawing.Color.LightCoral
        Me.Button1.ActiveForecolor = System.Drawing.Color.White
        Me.Button1.ActiveLineColor = System.Drawing.Color.LightCoral
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ButtonText = "Purchase"
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightCoral
        Me.Button1.IdleBorderThickness = 1
        Me.Button1.IdleCornerRadius = 20
        Me.Button1.IdleFillColor = System.Drawing.Color.MistyRose
        Me.Button1.IdleForecolor = System.Drawing.Color.LightCoral
        Me.Button1.IdleLineColor = System.Drawing.Color.LightCoral
        Me.Button1.Location = New System.Drawing.Point(5, 85)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 45)
        Me.Button1.TabIndex = 11
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(208, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 31)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Books"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Handwriting", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Back"
        '
        'cbobooktype
        '
        Me.cbobooktype.BackColor = System.Drawing.Color.Transparent
        Me.cbobooktype.BackgroundColor = System.Drawing.Color.White
        Me.cbobooktype.BorderColor = System.Drawing.Color.Silver
        Me.cbobooktype.BorderRadius = 1
        Me.cbobooktype.Color = System.Drawing.Color.Silver
        Me.cbobooktype.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cbobooktype.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbobooktype.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cbobooktype.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbobooktype.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbobooktype.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cbobooktype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbobooktype.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cbobooktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobooktype.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbobooktype.FillDropDown = True
        Me.cbobooktype.FillIndicator = False
        Me.cbobooktype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbobooktype.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbobooktype.ForeColor = System.Drawing.Color.Black
        Me.cbobooktype.FormattingEnabled = True
        Me.cbobooktype.Icon = Nothing
        Me.cbobooktype.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbobooktype.IndicatorColor = System.Drawing.Color.DarkGray
        Me.cbobooktype.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbobooktype.IndicatorThickness = 2
        Me.cbobooktype.IsDropdownOpened = False
        Me.cbobooktype.ItemBackColor = System.Drawing.Color.White
        Me.cbobooktype.ItemBorderColor = System.Drawing.Color.White
        Me.cbobooktype.ItemForeColor = System.Drawing.Color.Black
        Me.cbobooktype.ItemHeight = 26
        Me.cbobooktype.ItemHighLightColor = System.Drawing.Color.LightCoral
        Me.cbobooktype.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cbobooktype.ItemTopMargin = 3
        Me.cbobooktype.Location = New System.Drawing.Point(248, 60)
        Me.cbobooktype.Name = "cbobooktype"
        Me.cbobooktype.Size = New System.Drawing.Size(248, 32)
        Me.cbobooktype.TabIndex = 78
        Me.cbobooktype.Text = Nothing
        Me.cbobooktype.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbobooktype.TextLeftMargin = 5
        '
        'cbobuyer
        '
        Me.cbobuyer.BackColor = System.Drawing.Color.Transparent
        Me.cbobuyer.BackgroundColor = System.Drawing.Color.White
        Me.cbobuyer.BorderColor = System.Drawing.Color.Silver
        Me.cbobuyer.BorderRadius = 1
        Me.cbobuyer.Color = System.Drawing.Color.Silver
        Me.cbobuyer.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cbobuyer.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbobuyer.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cbobuyer.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbobuyer.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbobuyer.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cbobuyer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbobuyer.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cbobuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbobuyer.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbobuyer.FillDropDown = True
        Me.cbobuyer.FillIndicator = False
        Me.cbobuyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbobuyer.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbobuyer.ForeColor = System.Drawing.Color.Black
        Me.cbobuyer.FormattingEnabled = True
        Me.cbobuyer.Icon = Nothing
        Me.cbobuyer.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbobuyer.IndicatorColor = System.Drawing.Color.DarkGray
        Me.cbobuyer.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbobuyer.IndicatorThickness = 2
        Me.cbobuyer.IsDropdownOpened = False
        Me.cbobuyer.ItemBackColor = System.Drawing.Color.White
        Me.cbobuyer.ItemBorderColor = System.Drawing.Color.White
        Me.cbobuyer.ItemForeColor = System.Drawing.Color.Black
        Me.cbobuyer.ItemHeight = 26
        Me.cbobuyer.ItemHighLightColor = System.Drawing.Color.LightCoral
        Me.cbobuyer.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cbobuyer.ItemTopMargin = 3
        Me.cbobuyer.Location = New System.Drawing.Point(248, 112)
        Me.cbobuyer.Name = "cbobuyer"
        Me.cbobuyer.Size = New System.Drawing.Size(248, 32)
        Me.cbobuyer.TabIndex = 76
        Me.cbobuyer.Text = Nothing
        Me.cbobuyer.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbobuyer.TextLeftMargin = 5
        '
        'lbltotal
        '
        Me.lbltotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.lbltotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.lbltotal.BackColor = System.Drawing.Color.MistyRose
        Me.lbltotal.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lbltotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbltotal.Enabled = False
        Me.lbltotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Silver
        Me.lbltotal.HintForeColor = System.Drawing.Color.Black
        Me.lbltotal.HintText = ""
        Me.lbltotal.isPassword = False
        Me.lbltotal.LineFocusedColor = System.Drawing.Color.Red
        Me.lbltotal.LineIdleColor = System.Drawing.Color.LightCoral
        Me.lbltotal.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.lbltotal.LineThickness = 3
        Me.lbltotal.Location = New System.Drawing.Point(249, 212)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lbltotal.MaxLength = 32767
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(248, 35)
        Me.lbltotal.TabIndex = 70
        Me.lbltotal.Text = "Total Price"
        Me.lbltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtbooks
        '
        Me.txtbooks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtbooks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtbooks.BackColor = System.Drawing.Color.MistyRose
        Me.txtbooks.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtbooks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbooks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbooks.ForeColor = System.Drawing.Color.Silver
        Me.txtbooks.HintForeColor = System.Drawing.Color.Black
        Me.txtbooks.HintText = ""
        Me.txtbooks.isPassword = False
        Me.txtbooks.LineFocusedColor = System.Drawing.Color.Red
        Me.txtbooks.LineIdleColor = System.Drawing.Color.LightCoral
        Me.txtbooks.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.txtbooks.LineThickness = 3
        Me.txtbooks.Location = New System.Drawing.Point(249, 156)
        Me.txtbooks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbooks.MaxLength = 32767
        Me.txtbooks.Name = "txtbooks"
        Me.txtbooks.Size = New System.Drawing.Size(248, 35)
        Me.txtbooks.TabIndex = 75
        Me.txtbooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 24)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "BOOK TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 24)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "BUYER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 24)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "NUMBER OF BOOKS"
        '
        'address
        '
        Me.address.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.address.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.address.BackColor = System.Drawing.Color.MistyRose
        Me.address.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.address.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.Silver
        Me.address.HintForeColor = System.Drawing.Color.Black
        Me.address.HintText = ""
        Me.address.isPassword = False
        Me.address.LineFocusedColor = System.Drawing.Color.Red
        Me.address.LineIdleColor = System.Drawing.Color.LightCoral
        Me.address.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.address.LineThickness = 3
        Me.address.Location = New System.Drawing.Point(249, 492)
        Me.address.Margin = New System.Windows.Forms.Padding(4)
        Me.address.MaxLength = 32767
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(248, 35)
        Me.address.TabIndex = 89
        Me.address.Text = "Address"
        Me.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'email
        '
        Me.email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.email.BackColor = System.Drawing.Color.MistyRose
        Me.email.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.email.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Silver
        Me.email.HintForeColor = System.Drawing.Color.Black
        Me.email.HintText = ""
        Me.email.isPassword = False
        Me.email.LineFocusedColor = System.Drawing.Color.Red
        Me.email.LineIdleColor = System.Drawing.Color.LightCoral
        Me.email.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.email.LineThickness = 3
        Me.email.Location = New System.Drawing.Point(249, 436)
        Me.email.Margin = New System.Windows.Forms.Padding(4)
        Me.email.MaxLength = 32767
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(248, 35)
        Me.email.TabIndex = 88
        Me.email.Text = "Email"
        Me.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'phnumber
        '
        Me.phnumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.phnumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.phnumber.BackColor = System.Drawing.Color.MistyRose
        Me.phnumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.phnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phnumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phnumber.ForeColor = System.Drawing.Color.Silver
        Me.phnumber.HintForeColor = System.Drawing.Color.Black
        Me.phnumber.HintText = ""
        Me.phnumber.isPassword = False
        Me.phnumber.LineFocusedColor = System.Drawing.Color.Red
        Me.phnumber.LineIdleColor = System.Drawing.Color.LightCoral
        Me.phnumber.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.phnumber.LineThickness = 3
        Me.phnumber.Location = New System.Drawing.Point(249, 380)
        Me.phnumber.Margin = New System.Windows.Forms.Padding(4)
        Me.phnumber.MaxLength = 32767
        Me.phnumber.Name = "phnumber"
        Me.phnumber.Size = New System.Drawing.Size(248, 35)
        Me.phnumber.TabIndex = 87
        Me.phnumber.Text = "Ph Number"
        Me.phnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lname
        '
        Me.lname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.lname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.lname.BackColor = System.Drawing.Color.MistyRose
        Me.lname.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.lname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.ForeColor = System.Drawing.Color.Silver
        Me.lname.HintForeColor = System.Drawing.Color.Black
        Me.lname.HintText = ""
        Me.lname.isPassword = False
        Me.lname.LineFocusedColor = System.Drawing.Color.Red
        Me.lname.LineIdleColor = System.Drawing.Color.LightCoral
        Me.lname.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.lname.LineThickness = 3
        Me.lname.Location = New System.Drawing.Point(249, 324)
        Me.lname.Margin = New System.Windows.Forms.Padding(4)
        Me.lname.MaxLength = 32767
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(248, 35)
        Me.lname.TabIndex = 80
        Me.lname.Text = "Last Name"
        Me.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fname
        '
        Me.fname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.fname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.fname.BackColor = System.Drawing.Color.MistyRose
        Me.fname.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.fname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.Color.Silver
        Me.fname.HintForeColor = System.Drawing.Color.Black
        Me.fname.HintText = ""
        Me.fname.isPassword = False
        Me.fname.LineFocusedColor = System.Drawing.Color.Red
        Me.fname.LineIdleColor = System.Drawing.Color.LightCoral
        Me.fname.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.fname.LineThickness = 3
        Me.fname.Location = New System.Drawing.Point(249, 268)
        Me.fname.Margin = New System.Windows.Forms.Padding(4)
        Me.fname.MaxLength = 32767
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(248, 35)
        Me.fname.TabIndex = 81
        Me.fname.Text = "Name"
        Me.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 24)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 24)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Phone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(12, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 24)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(12, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 24)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(12, 443)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 24)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Email"
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(518, 684)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.phnumber)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbobooktype)
        Me.Controls.Add(Me.cbobuyer)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.txtbooks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Books"
        Me.Text = "Books"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btntotal As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnclear As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Button1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbobooktype As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cbobuyer As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents lbltotal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtbooks As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents address As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents email As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents phnumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents fname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
