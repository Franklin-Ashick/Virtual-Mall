<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Car_home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Car_home))
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalCarDataSet = New Mini_Project.RentalCarDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.search = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.management = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.new_car = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.new_cust = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.rental = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.CarTableAdapter = New Mini_Project.RentalCarDataSetTableAdapters.carTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalCarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "car"
        Me.CarBindingSource.DataSource = Me.RentalCarDataSetBindingSource
        '
        'RentalCarDataSetBindingSource
        '
        Me.RentalCarDataSetBindingSource.DataSource = Me.RentalCarDataSet
        Me.RentalCarDataSetBindingSource.Position = 0
        '
        'RentalCarDataSet
        '
        Me.RentalCarDataSet.DataSetName = "RentalCarDataSet"
        Me.RentalCarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.management)
        Me.Panel1.Controls.Add(Me.new_car)
        Me.Panel1.Controls.Add(Me.new_cust)
        Me.Panel1.Controls.Add(Me.rental)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(189, 485)
        Me.Panel1.TabIndex = 9
        '
        'search
        '
        Me.search.ActiveBorderThickness = 1
        Me.search.ActiveCornerRadius = 20
        Me.search.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.search.ActiveForecolor = System.Drawing.Color.Transparent
        Me.search.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.search.BackColor = System.Drawing.Color.Transparent
        Me.search.BackgroundImage = CType(resources.GetObject("search.BackgroundImage"), System.Drawing.Image)
        Me.search.ButtonText = "Search"
        Me.search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.MediumBlue
        Me.search.IdleBorderThickness = 1
        Me.search.IdleCornerRadius = 30
        Me.search.IdleFillColor = System.Drawing.Color.Transparent
        Me.search.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.search.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.search.Location = New System.Drawing.Point(1, 334)
        Me.search.Margin = New System.Windows.Forms.Padding(5)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(181, 41)
        Me.search.TabIndex = 11
        Me.search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'management
        '
        Me.management.ActiveBorderThickness = 1
        Me.management.ActiveCornerRadius = 20
        Me.management.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.management.ActiveForecolor = System.Drawing.Color.Transparent
        Me.management.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.management.BackColor = System.Drawing.Color.Transparent
        Me.management.BackgroundImage = CType(resources.GetObject("management.BackgroundImage"), System.Drawing.Image)
        Me.management.ButtonText = "Management"
        Me.management.Cursor = System.Windows.Forms.Cursors.Hand
        Me.management.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.management.ForeColor = System.Drawing.Color.MediumBlue
        Me.management.IdleBorderThickness = 1
        Me.management.IdleCornerRadius = 30
        Me.management.IdleFillColor = System.Drawing.Color.Transparent
        Me.management.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.management.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.management.Location = New System.Drawing.Point(1, 277)
        Me.management.Margin = New System.Windows.Forms.Padding(5)
        Me.management.Name = "management"
        Me.management.Size = New System.Drawing.Size(181, 41)
        Me.management.TabIndex = 10
        Me.management.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'new_car
        '
        Me.new_car.ActiveBorderThickness = 1
        Me.new_car.ActiveCornerRadius = 20
        Me.new_car.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.new_car.ActiveForecolor = System.Drawing.Color.Transparent
        Me.new_car.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.new_car.BackColor = System.Drawing.Color.Transparent
        Me.new_car.BackgroundImage = CType(resources.GetObject("new_car.BackgroundImage"), System.Drawing.Image)
        Me.new_car.ButtonText = "New Car"
        Me.new_car.Cursor = System.Windows.Forms.Cursors.Hand
        Me.new_car.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_car.ForeColor = System.Drawing.Color.MediumBlue
        Me.new_car.IdleBorderThickness = 1
        Me.new_car.IdleCornerRadius = 30
        Me.new_car.IdleFillColor = System.Drawing.Color.Transparent
        Me.new_car.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.new_car.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.new_car.Location = New System.Drawing.Point(1, 220)
        Me.new_car.Margin = New System.Windows.Forms.Padding(5)
        Me.new_car.Name = "new_car"
        Me.new_car.Size = New System.Drawing.Size(181, 41)
        Me.new_car.TabIndex = 9
        Me.new_car.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'new_cust
        '
        Me.new_cust.ActiveBorderThickness = 1
        Me.new_cust.ActiveCornerRadius = 20
        Me.new_cust.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.new_cust.ActiveForecolor = System.Drawing.Color.Transparent
        Me.new_cust.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.new_cust.BackColor = System.Drawing.Color.Transparent
        Me.new_cust.BackgroundImage = CType(resources.GetObject("new_cust.BackgroundImage"), System.Drawing.Image)
        Me.new_cust.ButtonText = "New Customer"
        Me.new_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.new_cust.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_cust.ForeColor = System.Drawing.Color.MediumBlue
        Me.new_cust.IdleBorderThickness = 1
        Me.new_cust.IdleCornerRadius = 30
        Me.new_cust.IdleFillColor = System.Drawing.Color.Transparent
        Me.new_cust.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.new_cust.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.new_cust.Location = New System.Drawing.Point(1, 163)
        Me.new_cust.Margin = New System.Windows.Forms.Padding(5)
        Me.new_cust.Name = "new_cust"
        Me.new_cust.Size = New System.Drawing.Size(181, 41)
        Me.new_cust.TabIndex = 8
        Me.new_cust.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rental
        '
        Me.rental.ActiveBorderThickness = 1
        Me.rental.ActiveCornerRadius = 20
        Me.rental.ActiveFillColor = System.Drawing.Color.MidnightBlue
        Me.rental.ActiveForecolor = System.Drawing.Color.Transparent
        Me.rental.ActiveLineColor = System.Drawing.Color.MidnightBlue
        Me.rental.BackColor = System.Drawing.Color.Transparent
        Me.rental.BackgroundImage = CType(resources.GetObject("rental.BackgroundImage"), System.Drawing.Image)
        Me.rental.ButtonText = "Rental Car"
        Me.rental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rental.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rental.ForeColor = System.Drawing.Color.MediumBlue
        Me.rental.IdleBorderThickness = 1
        Me.rental.IdleCornerRadius = 30
        Me.rental.IdleFillColor = System.Drawing.Color.Transparent
        Me.rental.IdleForecolor = System.Drawing.Color.MidnightBlue
        Me.rental.IdleLineColor = System.Drawing.Color.MidnightBlue
        Me.rental.Location = New System.Drawing.Point(1, 106)
        Me.rental.Margin = New System.Windows.Forms.Padding(5)
        Me.rental.Name = "rental"
        Me.rental.Size = New System.Drawing.Size(181, 41)
        Me.rental.TabIndex = 7
        Me.rental.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(231, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 93)
        Me.Panel2.TabIndex = 10
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.Firebrick
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(815, -2)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(28, 31)
        Me.BunifuCustomLabel3.TabIndex = 156
        Me.BunifuCustomLabel3.Text = "X"
        '
        'Car_home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(838, 485)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Car_home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car_home"
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalCarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents search As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents management As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents new_car As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents new_cust As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents rental As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents RentalCarDataSetBindingSource As BindingSource
    Friend WithEvents RentalCarDataSet As RentalCarDataSet
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As RentalCarDataSetTableAdapters.carTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
