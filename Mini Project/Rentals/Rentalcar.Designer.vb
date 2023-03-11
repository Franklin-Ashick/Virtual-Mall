<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rentalcar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rentalcar))
        Me.rental_car = New System.Windows.Forms.Panel()
        Me.button2 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.button1 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.textbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.rental_car.SuspendLayout()
        Me.SuspendLayout()
        '
        'rental_car
        '
        Me.rental_car.BackColor = System.Drawing.Color.Transparent
        Me.rental_car.Controls.Add(Me.button2)
        Me.rental_car.Controls.Add(Me.button1)
        Me.rental_car.Location = New System.Drawing.Point(30, 351)
        Me.rental_car.Name = "rental_car"
        Me.rental_car.Size = New System.Drawing.Size(309, 60)
        Me.rental_car.TabIndex = 14
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
        Me.button2.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.button2.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.button2.Location = New System.Drawing.Point(184, 14)
        Me.button2.Margin = New System.Windows.Forms.Padding(5)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(98, 41)
        Me.button2.TabIndex = 124
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
        Me.button1.ButtonText = "Save"
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.button1.IdleBorderThickness = 1
        Me.button1.IdleCornerRadius = 30
        Me.button1.IdleFillColor = System.Drawing.Color.Transparent
        Me.button1.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.button1.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.button1.Location = New System.Drawing.Point(28, 16)
        Me.button1.Margin = New System.Windows.Forms.Padding(5)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(98, 41)
        Me.button1.TabIndex = 118
        Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(27, 315)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(98, 16)
        Me.label6.TabIndex = 129
        Me.label6.Text = "Total Amount"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(36, 257)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(89, 16)
        Me.label5.TabIndex = 128
        Me.label5.Text = "Return Date"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(46, 200)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(79, 16)
        Me.label4.TabIndex = 127
        Me.label4.Text = "From Date"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 139)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(117, 16)
        Me.label1.TabIndex = 126
        Me.label1.Text = "Customer Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(49, 83)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(76, 16)
        Me.label3.TabIndex = 125
        Me.label3.Text = "Car Name"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.label2.Location = New System.Drawing.Point(115, 19)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(141, 24)
        Me.label2.TabIndex = 124
        Me.label2.Text = "Car On Rental"
        '
        'textbox2
        '
        Me.textbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox2.BackColor = System.Drawing.Color.SeaShell
        Me.textbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox2.ForeColor = System.Drawing.Color.Black
        Me.textbox2.HintForeColor = System.Drawing.Color.Black
        Me.textbox2.HintText = ""
        Me.textbox2.isPassword = False
        Me.textbox2.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox2.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox2.LineThickness = 3
        Me.textbox2.Location = New System.Drawing.Point(155, 120)
        Me.textbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox2.MaxLength = 32767
        Me.textbox2.Name = "textbox2"
        Me.textbox2.Size = New System.Drawing.Size(202, 29)
        Me.textbox2.TabIndex = 130
        Me.textbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox5
        '
        Me.textbox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox5.BackColor = System.Drawing.Color.SeaShell
        Me.textbox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.textbox5.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox5.ForeColor = System.Drawing.Color.Black
        Me.textbox5.HintForeColor = System.Drawing.Color.Empty
        Me.textbox5.HintText = ""
        Me.textbox5.isPassword = False
        Me.textbox5.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox5.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox5.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox5.LineThickness = 3
        Me.textbox5.Location = New System.Drawing.Point(155, 302)
        Me.textbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox5.MaxLength = 32767
        Me.textbox5.Name = "textbox5"
        Me.textbox5.Size = New System.Drawing.Size(202, 29)
        Me.textbox5.TabIndex = 133
        Me.textbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox1
        '
        Me.textbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox1.BackColor = System.Drawing.Color.SeaShell
        Me.textbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox1.ForeColor = System.Drawing.Color.Black
        Me.textbox1.HintForeColor = System.Drawing.Color.Black
        Me.textbox1.HintText = ""
        Me.textbox1.isPassword = False
        Me.textbox1.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox1.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox1.LineThickness = 3
        Me.textbox1.Location = New System.Drawing.Point(155, 64)
        Me.textbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox1.MaxLength = 32767
        Me.textbox1.Name = "textbox1"
        Me.textbox1.Size = New System.Drawing.Size(202, 29)
        Me.textbox1.TabIndex = 131
        Me.textbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox4
        '
        Me.textbox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox4.BackColor = System.Drawing.Color.SeaShell
        Me.textbox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.textbox4.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox4.ForeColor = System.Drawing.Color.Black
        Me.textbox4.HintForeColor = System.Drawing.Color.Empty
        Me.textbox4.HintText = ""
        Me.textbox4.isPassword = False
        Me.textbox4.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox4.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox4.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox4.LineThickness = 3
        Me.textbox4.Location = New System.Drawing.Point(155, 240)
        Me.textbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox4.MaxLength = 32767
        Me.textbox4.Name = "textbox4"
        Me.textbox4.Size = New System.Drawing.Size(202, 29)
        Me.textbox4.TabIndex = 134
        Me.textbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'textbox3
        '
        Me.textbox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.textbox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.textbox3.BackColor = System.Drawing.Color.SeaShell
        Me.textbox3.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.textbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textbox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox3.ForeColor = System.Drawing.Color.Black
        Me.textbox3.HintForeColor = System.Drawing.Color.Black
        Me.textbox3.HintText = ""
        Me.textbox3.isPassword = False
        Me.textbox3.LineFocusedColor = System.Drawing.Color.MidnightBlue
        Me.textbox3.LineIdleColor = System.Drawing.Color.DeepSkyBlue
        Me.textbox3.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.textbox3.LineThickness = 3
        Me.textbox3.Location = New System.Drawing.Point(155, 181)
        Me.textbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.textbox3.MaxLength = 32767
        Me.textbox3.Name = "textbox3"
        Me.textbox3.Size = New System.Drawing.Size(202, 29)
        Me.textbox3.TabIndex = 132
        Me.textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(368, -3)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuCustomLabel3.TabIndex = 156
        Me.BunifuCustomLabel3.Text = "X"
        '
        'Rentalcar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(391, 447)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textbox2)
        Me.Controls.Add(Me.textbox5)
        Me.Controls.Add(Me.textbox1)
        Me.Controls.Add(Me.textbox4)
        Me.Controls.Add(Me.textbox3)
        Me.Controls.Add(Me.rental_car)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rentalcar"
        Me.Text = "Rentalcar"
        Me.rental_car.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rental_car As Panel
    Friend WithEvents button2 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents button1 As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents textbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents textbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
