<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryManagement))
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.new_customer = New System.Windows.Forms.Panel()
        Me.button2 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.textBox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textBox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.new_customer.SuspendLayout()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(30, 208)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(86, 16)
        Me.label4.TabIndex = 108
        Me.label4.Text = "Description"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(68, 147)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 16)
        Me.label1.TabIndex = 107
        Me.label1.Text = "Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(96, 93)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(20, 16)
        Me.label3.TabIndex = 106
        Me.label3.Text = "Id"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.IndianRed
        Me.label2.Location = New System.Drawing.Point(95, 35)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(220, 24)
        Me.label2.TabIndex = 105
        Me.label2.Text = "Category Management"
        '
        'new_customer
        '
        Me.new_customer.BackColor = System.Drawing.Color.Transparent
        Me.new_customer.Controls.Add(Me.button2)
        Me.new_customer.Controls.Add(Me.button1)
        Me.new_customer.Location = New System.Drawing.Point(12, 320)
        Me.new_customer.Name = "new_customer"
        Me.new_customer.Size = New System.Drawing.Size(410, 91)
        Me.new_customer.TabIndex = 111
        '
        'button2
        '
        Me.button2.ActiveBorderThickness = 1
        Me.button2.ActiveCornerRadius = 20
        Me.button2.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.button2.ActiveForecolor = System.Drawing.Color.Transparent
        Me.button2.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.BackgroundImage = CType(resources.GetObject("button2.BackgroundImage"), System.Drawing.Image)
        Me.button2.ButtonText = "Reset"
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.MediumBlue
        Me.button2.IdleBorderThickness = 1
        Me.button2.IdleCornerRadius = 30
        Me.button2.IdleFillColor = System.Drawing.Color.Transparent
        Me.button2.IdleForecolor = System.Drawing.Color.DeepSkyBlue
        Me.button2.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.button2.Location = New System.Drawing.Point(277, 29)
        Me.button2.Margin = New System.Windows.Forms.Padding(5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(98, 41)
        Me.button2.TabIndex = 140
        Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.button1.ButtonText = "Add"
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.button1.IdleBorderThickness = 1
        Me.button1.IdleCornerRadius = 30
        Me.button1.IdleFillColor = System.Drawing.Color.Transparent
        Me.button1.IdleForecolor = System.Drawing.Color.DeepSkyBlue
        Me.button1.IdleLineColor = System.Drawing.Color.DeepSkyBlue
        Me.button1.Location = New System.Drawing.Point(19, 29)
        Me.button1.Margin = New System.Windows.Forms.Padding(5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(98, 41)
        Me.button1.TabIndex = 139
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textBox3
        '
        Me.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textBox3.BackColor = System.Drawing.Color.SeaShell
        Me.textBox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox3.ForeColor = System.Drawing.Color.Black
        Me.textBox3.HintForeColor = System.Drawing.Color.Black
        Me.textBox3.HintText = ""
        Me.textBox3.isPassword = False
        Me.textBox3.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textBox3.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textBox3.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textBox3.LineThickness = 2
        Me.textBox3.Location = New System.Drawing.Point(182, 199)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox3.MaxLength = 32767
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(208, 98)
        Me.textBox3.TabIndex = 154
        Me.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textBox2
        '
        Me.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textBox2.BackColor = System.Drawing.Color.SeaShell
        Me.textBox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox2.ForeColor = System.Drawing.Color.Black
        Me.textBox2.HintForeColor = System.Drawing.Color.Black
        Me.textBox2.HintText = ""
        Me.textBox2.isPassword = False
        Me.textBox2.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textBox2.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textBox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textBox2.LineThickness = 2
        Me.textBox2.Location = New System.Drawing.Point(182, 146)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox2.MaxLength = 32767
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(154, 25)
        Me.textBox2.TabIndex = 153
        Me.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.textBox1.Location = New System.Drawing.Point(182, 93)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textBox1.MaxLength = 32767
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(154, 25)
        Me.textBox1.TabIndex = 152
        Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(416, -4)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuCustomLabel3.TabIndex = 155
        Me.BunifuCustomLabel3.Text = "X"
        '
        'CategoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(440, 437)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.new_customer)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CategoryManagement"
        Me.Text = "CategoryManagement"
        Me.new_customer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents new_customer As Panel
    Friend WithEvents button2 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button1 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents textBox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textBox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
