<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Forgotpassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forgotpassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConfPassword = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ConfPassword)
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.Username)
        Me.Panel1.ForeColor = System.Drawing.Color.LightCoral
        Me.Panel1.Location = New System.Drawing.Point(11, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 342)
        Me.Panel1.TabIndex = 24
        '
        'ConfPassword
        '
        Me.ConfPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.ConfPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.ConfPassword.BackColor = System.Drawing.Color.MistyRose
        Me.ConfPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ConfPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ConfPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfPassword.ForeColor = System.Drawing.Color.Silver
        Me.ConfPassword.HintForeColor = System.Drawing.Color.Empty
        Me.ConfPassword.HintText = ""
        Me.ConfPassword.isPassword = False
        Me.ConfPassword.LineFocusedColor = System.Drawing.Color.Red
        Me.ConfPassword.LineIdleColor = System.Drawing.Color.LightCoral
        Me.ConfPassword.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.ConfPassword.LineThickness = 3
        Me.ConfPassword.Location = New System.Drawing.Point(5, 181)
        Me.ConfPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.ConfPassword.MaxLength = 32767
        Me.ConfPassword.Name = "ConfPassword"
        Me.ConfPassword.Size = New System.Drawing.Size(279, 33)
        Me.ConfPassword.TabIndex = 1
        Me.ConfPassword.Text = "Confirm Password"
        Me.ConfPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.LightCoral
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.LightCoral
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Register"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.LightCoral
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Snow
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.LightCoral
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.LightCoral
        Me.BunifuThinButton21.Location = New System.Drawing.Point(45, 259)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(181, 45)
        Me.BunifuThinButton21.TabIndex = 9
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(18, 20)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(250, 36)
        Me.BunifuCustomLabel1.TabIndex = 3
        Me.BunifuCustomLabel1.Text = "Password Recovery"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(5, 221)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Password.BackColor = System.Drawing.Color.MistyRose
        Me.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.Silver
        Me.Password.HintForeColor = System.Drawing.Color.Empty
        Me.Password.HintText = ""
        Me.Password.isPassword = False
        Me.Password.LineFocusedColor = System.Drawing.Color.Red
        Me.Password.LineIdleColor = System.Drawing.Color.LightCoral
        Me.Password.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.Password.LineThickness = 3
        Me.Password.Location = New System.Drawing.Point(5, 140)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.MaxLength = 32767
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(279, 33)
        Me.Password.TabIndex = 1
        Me.Password.Text = "New Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Username
        '
        Me.Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.Username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.Username.BackColor = System.Drawing.Color.MistyRose
        Me.Username.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.Silver
        Me.Username.HintForeColor = System.Drawing.Color.Black
        Me.Username.HintText = ""
        Me.Username.isPassword = False
        Me.Username.LineFocusedColor = System.Drawing.Color.Red
        Me.Username.LineIdleColor = System.Drawing.Color.LightCoral
        Me.Username.LineMouseHoverColor = System.Drawing.Color.OrangeRed
        Me.Username.LineThickness = 3
        Me.Username.Location = New System.Drawing.Point(5, 97)
        Me.Username.Margin = New System.Windows.Forms.Padding(4)
        Me.Username.MaxLength = 32767
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(279, 35)
        Me.Username.TabIndex = 0
        Me.Username.Text = "Username"
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 40
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.LightCoral
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(284, -1)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuCustomLabel3.TabIndex = 26
        Me.BunifuCustomLabel3.Text = "X"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.LightCoral
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(50, 48)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(230, 33)
        Me.BunifuCustomLabel2.TabIndex = 25
        Me.BunifuCustomLabel2.Text = "Mini Virtual Center"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel8)
        Me.Panel2.Controls.Add(Me.BunifuCustomLabel7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 531)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 27)
        Me.Panel2.TabIndex = 27
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(264, 1)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(47, 19)
        Me.BunifuCustomLabel8.TabIndex = 8
        Me.BunifuCustomLabel8.Text = "Help?"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.LightCoral
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(5, 3)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(80, 19)
        Me.BunifuCustomLabel7.TabIndex = 7
        Me.BunifuCustomLabel7.Text = "User Login"
        '
        'Forgotpassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 558)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Forgotpassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "forgotpassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ConfPassword As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
