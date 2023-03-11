<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Billing
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

    Private Const V As String = "Billing"

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.card = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ccv = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.accno = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.datee = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.noc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.quality = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.amount = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Cash = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.totalcash = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.upii = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.upi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.phnumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Name = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.purchase_btn = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PAYMENT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuDatePicker1 = New Bunifu.UI.WinForms.BunifuDatePicker()
        Me.card.SuspendLayout()
        Me.Cash.SuspendLayout()
        Me.upii.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'card
        '
        Me.card.BackColor = System.Drawing.Color.White
        Me.card.Controls.Add(Me.Label10)
        Me.card.Controls.Add(Me.Label9)
        Me.card.Controls.Add(Me.Label8)
        Me.card.Controls.Add(Me.Label7)
        Me.card.Controls.Add(Me.ccv)
        Me.card.Controls.Add(Me.accno)
        Me.card.Controls.Add(Me.datee)
        Me.card.Controls.Add(Me.noc)
        Me.card.Location = New System.Drawing.Point(378, 223)
        Me.card.Name = "card"
        Me.card.Size = New System.Drawing.Size(410, 178)
        Me.card.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(38, 98)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Account No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(224, 100)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Expire Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(224, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 25)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "CVV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(31, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 25)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Name on Card"
        '
        'ccv
        '
        Me.ccv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ccv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ccv.BackColor = System.Drawing.Color.Bisque
        Me.ccv.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ccv.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccv.ForeColor = System.Drawing.Color.Black
        Me.ccv.HintForeColor = System.Drawing.Color.Black
        Me.ccv.HintText = ""
        Me.ccv.isPassword = False
        Me.ccv.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.ccv.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.ccv.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.ccv.LineThickness = 3
        Me.ccv.Location = New System.Drawing.Point(249, 49)
        Me.ccv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ccv.MaxLength = 32767
        Me.ccv.Name = "ccv"
        Me.ccv.Size = New System.Drawing.Size(143, 35)
        Me.ccv.TabIndex = 30
        Me.ccv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'accno
        '
        Me.accno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.accno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.accno.BackColor = System.Drawing.Color.Bisque
        Me.accno.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.accno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.accno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accno.ForeColor = System.Drawing.Color.Black
        Me.accno.HintForeColor = System.Drawing.Color.Black
        Me.accno.HintText = ""
        Me.accno.isPassword = False
        Me.accno.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.accno.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.accno.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.accno.LineThickness = 3
        Me.accno.Location = New System.Drawing.Point(56, 128)
        Me.accno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.accno.MaxLength = 32767
        Me.accno.Name = "accno"
        Me.accno.Size = New System.Drawing.Size(143, 35)
        Me.accno.TabIndex = 29
        Me.accno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'datee
        '
        Me.datee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.datee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.datee.BackColor = System.Drawing.Color.Bisque
        Me.datee.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.datee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.datee.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datee.ForeColor = System.Drawing.Color.Black
        Me.datee.HintForeColor = System.Drawing.Color.Black
        Me.datee.HintText = ""
        Me.datee.isPassword = False
        Me.datee.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.datee.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.datee.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.datee.LineThickness = 3
        Me.datee.Location = New System.Drawing.Point(249, 129)
        Me.datee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datee.MaxLength = 32767
        Me.datee.Name = "datee"
        Me.datee.Size = New System.Drawing.Size(143, 35)
        Me.datee.TabIndex = 28
        Me.datee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'noc
        '
        Me.noc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.noc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.noc.BackColor = System.Drawing.Color.Bisque
        Me.noc.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.noc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.noc.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noc.ForeColor = System.Drawing.Color.Black
        Me.noc.HintForeColor = System.Drawing.Color.Black
        Me.noc.HintText = ""
        Me.noc.isPassword = False
        Me.noc.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.noc.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.noc.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.noc.LineThickness = 3
        Me.noc.Location = New System.Drawing.Point(56, 48)
        Me.noc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.noc.MaxLength = 32767
        Me.noc.Name = "noc"
        Me.noc.Size = New System.Drawing.Size(143, 35)
        Me.noc.TabIndex = 27
        Me.noc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.quality.Location = New System.Drawing.Point(498, 180)
        Me.quality.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.quality.MaxLength = 32767
        Me.quality.Name = "quality"
        Me.quality.Size = New System.Drawing.Size(91, 35)
        Me.quality.TabIndex = 18
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
        Me.amount.Location = New System.Drawing.Point(606, 180)
        Me.amount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.amount.MaxLength = 32767
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(96, 35)
        Me.amount.TabIndex = 19
        Me.amount.Text = "Amount"
        Me.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Cash
        '
        Me.Cash.BackColor = System.Drawing.Color.White
        Me.Cash.Controls.Add(Me.Label11)
        Me.Cash.Controls.Add(Me.totalcash)
        Me.Cash.Location = New System.Drawing.Point(380, 222)
        Me.Cash.Name = "Cash"
        Me.Cash.Size = New System.Drawing.Size(408, 178)
        Me.Cash.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(34, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 25)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Total Cash"
        '
        'totalcash
        '
        Me.totalcash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.totalcash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.totalcash.BackColor = System.Drawing.Color.Bisque
        Me.totalcash.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.totalcash.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalcash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalcash.ForeColor = System.Drawing.Color.Black
        Me.totalcash.HintForeColor = System.Drawing.Color.Black
        Me.totalcash.HintText = ""
        Me.totalcash.isPassword = False
        Me.totalcash.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.totalcash.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.totalcash.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.totalcash.LineThickness = 3
        Me.totalcash.Location = New System.Drawing.Point(48, 47)
        Me.totalcash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalcash.MaxLength = 32767
        Me.totalcash.Name = "totalcash"
        Me.totalcash.Size = New System.Drawing.Size(201, 35)
        Me.totalcash.TabIndex = 27
        Me.totalcash.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'upii
        '
        Me.upii.BackColor = System.Drawing.Color.White
        Me.upii.Controls.Add(Me.Label4)
        Me.upii.Controls.Add(Me.upi)
        Me.upii.Location = New System.Drawing.Point(380, 225)
        Me.upii.Name = "upii"
        Me.upii.Size = New System.Drawing.Size(408, 178)
        Me.upii.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "UPI ID"
        '
        'upi
        '
        Me.upi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.upi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.upi.BackColor = System.Drawing.Color.Bisque
        Me.upi.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.upi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.upi.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upi.ForeColor = System.Drawing.Color.Black
        Me.upi.HintForeColor = System.Drawing.Color.Black
        Me.upi.HintText = ""
        Me.upi.isPassword = False
        Me.upi.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.upi.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.upi.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.upi.LineThickness = 3
        Me.upi.Location = New System.Drawing.Point(48, 47)
        Me.upi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.upi.MaxLength = 32767
        Me.upi.Name = "upi"
        Me.upi.Size = New System.Drawing.Size(201, 35)
        Me.upi.TabIndex = 27
        Me.upi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(90, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 39)
        Me.Panel1.TabIndex = 35
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(230, 6)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(53, 25)
        Me.RadioButton3.TabIndex = 38
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "UPI"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(162, 6)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 25)
        Me.RadioButton2.TabIndex = 37
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cash"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(3, 6)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(158, 25)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Credit/Debit Card"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(10, 7)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(66, 29)
        Me.BunifuCustomLabel11.TabIndex = 38
        Me.BunifuCustomLabel11.Text = "Back"
        '
        'phnumber
        '
        Me.phnumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.phnumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.phnumber.BackColor = System.Drawing.Color.Bisque
        Me.phnumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.phnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.phnumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phnumber.ForeColor = System.Drawing.Color.Black
        Me.phnumber.HintForeColor = System.Drawing.Color.Black
        Me.phnumber.HintText = ""
        Me.phnumber.isPassword = False
        Me.phnumber.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.phnumber.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.phnumber.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.phnumber.LineThickness = 3
        Me.phnumber.Location = New System.Drawing.Point(131, 352)
        Me.phnumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.phnumber.MaxLength = 32767
        Me.phnumber.Name = "phnumber"
        Me.phnumber.Size = New System.Drawing.Size(196, 35)
        Me.phnumber.TabIndex = 42
        Me.phnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Name
        '
        Me.Name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Name.BackColor = System.Drawing.Color.Bisque
        Me.Name.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name.ForeColor = System.Drawing.Color.Black
        Me.Name.HintForeColor = System.Drawing.Color.Black
        Me.Name.HintText = ""
        Me.Name.isPassword = False
        Me.Name.LineFocusedColor = System.Drawing.Color.SandyBrown
        Me.Name.LineIdleColor = System.Drawing.Color.BurlyWood
        Me.Name.LineMouseHoverColor = System.Drawing.Color.SaddleBrown
        Me.Name.LineThickness = 3
        Me.Name.Location = New System.Drawing.Point(131, 272)
        Me.Name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name.MaxLength = 32767
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(196, 35)
        Me.Name.TabIndex = 41
        Me.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'purchase_btn
        '
        Me.purchase_btn.ActiveBorderThickness = 1
        Me.purchase_btn.ActiveCornerRadius = 20
        Me.purchase_btn.ActiveFillColor = System.Drawing.Color.SandyBrown
        Me.purchase_btn.ActiveForecolor = System.Drawing.Color.Black
        Me.purchase_btn.ActiveLineColor = System.Drawing.Color.SandyBrown
        Me.purchase_btn.BackColor = System.Drawing.Color.Transparent
        Me.purchase_btn.BackgroundImage = CType(resources.GetObject("purchase_btn.BackgroundImage"), System.Drawing.Image)
        Me.purchase_btn.ButtonText = "Purchase"
        Me.purchase_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.purchase_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchase_btn.ForeColor = System.Drawing.Color.DarkOrange
        Me.purchase_btn.IdleBorderThickness = 1
        Me.purchase_btn.IdleCornerRadius = 20
        Me.purchase_btn.IdleFillColor = System.Drawing.Color.Transparent
        Me.purchase_btn.IdleForecolor = System.Drawing.Color.Tan
        Me.purchase_btn.IdleLineColor = System.Drawing.Color.Tan
        Me.purchase_btn.Location = New System.Drawing.Point(53, 4)
        Me.purchase_btn.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.purchase_btn.Name = "purchase_btn"
        Me.purchase_btn.Size = New System.Drawing.Size(107, 41)
        Me.purchase_btn.TabIndex = 31
        Me.purchase_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.purchase_btn)
        Me.Panel2.Location = New System.Drawing.Point(316, 405)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 47)
        Me.Panel2.TabIndex = 32
        '
        'PAYMENT
        '
        Me.PAYMENT.AutoSize = True
        Me.PAYMENT.BackColor = System.Drawing.Color.Transparent
        Me.PAYMENT.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.PAYMENT.Location = New System.Drawing.Point(100, 133)
        Me.PAYMENT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PAYMENT.Name = "PAYMENT"
        Me.PAYMENT.Size = New System.Drawing.Size(142, 25)
        Me.PAYMENT.TabIndex = 43
        Me.PAYMENT.Text = "Payment Mode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(383, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 38)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "BILLING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(494, 152)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(602, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Total Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(109, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(100, 323)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 25)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Phone Number"
        '
        'BunifuDatePicker1
        '
        Me.BunifuDatePicker1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDatePicker1.BorderColor = System.Drawing.Color.Silver
        Me.BunifuDatePicker1.BorderRadius = 1
        Me.BunifuDatePicker1.Color = System.Drawing.Color.Silver
        Me.BunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin
        Me.BunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left
        Me.BunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.DisplayWeekNumbers = False
        Me.BunifuDatePicker1.DPHeight = 0
        Me.BunifuDatePicker1.FillDatePicker = False
        Me.BunifuDatePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuDatePicker1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDatePicker1.Icon = CType(resources.GetObject("BunifuDatePicker1.Icon"), System.Drawing.Image)
        Me.BunifuDatePicker1.IconColor = System.Drawing.Color.Gray
        Me.BunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right
        Me.BunifuDatePicker1.LeftTextMargin = 5
        Me.BunifuDatePicker1.Location = New System.Drawing.Point(483, 87)
        Me.BunifuDatePicker1.MinimumSize = New System.Drawing.Size(0, 32)
        Me.BunifuDatePicker1.Name = "BunifuDatePicker1"
        Me.BunifuDatePicker1.Size = New System.Drawing.Size(171, 32)
        Me.BunifuDatePicker1.TabIndex = 49
        Me.BunifuDatePicker1.Visible = False
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(880, 512)
        Me.Controls.Add(Me.BunifuDatePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PAYMENT)
        Me.Controls.Add(Me.phnumber)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.quality)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.upii)
        Me.Controls.Add(Me.card)
        Me.Controls.Add(Me.Cash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None

        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.card.ResumeLayout(False)
        Me.card.PerformLayout()
        Me.Cash.ResumeLayout(False)
        Me.Cash.PerformLayout()
        Me.upii.ResumeLayout(False)
        Me.upii.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents card As Panel
    Friend WithEvents noc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents quality As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents amount As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ccv As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents accno As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents datee As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Cash As Panel
    Friend WithEvents totalcash As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents upii As Panel
    Friend WithEvents upi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents phnumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Name As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents purchase_btn As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PAYMENT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuDatePicker1 As Bunifu.UI.WinForms.BunifuDatePicker
End Class
