Imports System.ComponentModel
Imports System.Runtime.Remoting
Imports System.Windows.Forms.Layout

Public Class tic_tac

    Private Sub Tic_tac(sender As Object, e As EventArgs) Handles MyBase.Load

        ' add event to all buttons inside the panel2
        For Each c As Control In Panel2.Controls

            If c.GetType() = GetType(Button) Then

                AddHandler c.Click, AddressOf btn_Click

            End If

        Next

    End Sub

    Dim XorO As Integer = 0
    ' create button event
    Private Sub btn_Click(sender As Object, e As EventArgs)

        Dim btn As Button = sender

        ' we will clear buttons text later
        If btn.Text.Equals("") Then

            If XorO Mod 2 = 0 Then

                btn.Text = "X"
                btn.ForeColor = Color.Red
                Label1.Text = "[O] Turn"
                getTheWinner()

            Else
                btn.Text = "O"
                btn.ForeColor = Color.Blue
                Label1.Text = "[X] Turn"
                getTheWinner()
            End If

            XorO += 1

        End If

    End Sub

    Dim win As Boolean = False

    Public Overrides Property AllowDrop As Boolean
        Get
            Return MyBase.AllowDrop
        End Get
        Set(value As Boolean)
            MyBase.AllowDrop = value
        End Set
    End Property

    Public Overrides Property Anchor As AnchorStyles
        Get
            Return MyBase.Anchor
        End Get
        Set(value As AnchorStyles)
            MyBase.Anchor = value
        End Set
    End Property

    Public Overrides Property AutoScrollOffset As Point
        Get
            Return MyBase.AutoScrollOffset
        End Get
        Set(value As Point)
            MyBase.AutoScrollOffset = value
        End Set
    End Property

    Public Overrides ReadOnly Property LayoutEngine As LayoutEngine
        Get
            Return MyBase.LayoutEngine
        End Get
    End Property

    Public Overrides Property BackgroundImage As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    Public Overrides Property BackgroundImageLayout As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    Protected Overrides ReadOnly Property CanRaiseEvents As Boolean
        Get
            Return MyBase.CanRaiseEvents
        End Get
    End Property

    Public Overrides Property ContextMenu As ContextMenu
        Get
            Return MyBase.ContextMenu
        End Get
        Set(value As ContextMenu)
            MyBase.ContextMenu = value
        End Set
    End Property

    Public Overrides Property ContextMenuStrip As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            MyBase.ContextMenuStrip = value
        End Set
    End Property

    Public Overrides Property Cursor As Cursor
        Get
            Return MyBase.Cursor
        End Get
        Set(value As Cursor)
            MyBase.Cursor = value
        End Set
    End Property

    Protected Overrides ReadOnly Property DefaultCursor As Cursor
        Get
            Return MyBase.DefaultCursor
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultMargin As Padding
        Get
            Return MyBase.DefaultMargin
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultMaximumSize As Size
        Get
            Return MyBase.DefaultMaximumSize
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultMinimumSize As Size
        Get
            Return MyBase.DefaultMinimumSize
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultPadding As Padding
        Get
            Return MyBase.DefaultPadding
        End Get
    End Property

    Public Overrides Property Dock As DockStyle
        Get
            Return MyBase.Dock
        End Get
        Set(value As DockStyle)
            MyBase.Dock = value
        End Set
    End Property

    Protected Overrides Property DoubleBuffered As Boolean
        Get
            Return MyBase.DoubleBuffered
        End Get
        Set(value As Boolean)
            MyBase.DoubleBuffered = value
        End Set
    End Property

    Public Overrides ReadOnly Property Focused As Boolean
        Get
            Return MyBase.Focused
        End Get
    End Property

    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property

    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property

    Public Overrides Property RightToLeft As RightToLeft
        Get
            Return MyBase.RightToLeft
        End Get
        Set(value As RightToLeft)
            MyBase.RightToLeft = value
        End Set
    End Property

    Protected Overrides ReadOnly Property ScaleChildren As Boolean
        Get
            Return MyBase.ScaleChildren
        End Get
    End Property

    Public Overrides Property Site As ISite
        Get
            Return MyBase.Site
        End Get
        Set(value As ISite)
            MyBase.Site = value
        End Set
    End Property

    Protected Overrides ReadOnly Property ShowKeyboardCues As Boolean
        Get
            Return MyBase.ShowKeyboardCues
        End Get
    End Property

    Protected Overrides ReadOnly Property ShowFocusCues As Boolean
        Get
            Return MyBase.ShowFocusCues
        End Get
    End Property

    Protected Overrides Property ImeModeBase As ImeMode
        Get
            Return MyBase.ImeModeBase
        End Get
        Set(value As ImeMode)
            MyBase.ImeModeBase = value
        End Set
    End Property

    Public Overrides ReadOnly Property DisplayRectangle As Rectangle
        Get
            Return MyBase.DisplayRectangle
        End Get
    End Property

    Public Overrides Property BindingContext As BindingContext
        Get
            Return MyBase.BindingContext
        End Get
        Set(value As BindingContext)
            MyBase.BindingContext = value
        End Set
    End Property

    Protected Overrides ReadOnly Property CanEnableIme As Boolean
        Get
            Return MyBase.CanEnableIme
        End Get
    End Property

    Public Overrides Property AutoScaleBaseSize As Size
        Get
            Return MyBase.AutoScaleBaseSize
        End Get
        Set(value As Size)
            MyBase.AutoScaleBaseSize = value
        End Set
    End Property

    Public Overrides Property AutoScroll As Boolean
        Get
            Return MyBase.AutoScroll
        End Get
        Set(value As Boolean)
            MyBase.AutoScroll = value
        End Set
    End Property

    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property

    Public Overrides Property AutoValidate As AutoValidate
        Get
            Return MyBase.AutoValidate
        End Get
        Set(value As AutoValidate)
            MyBase.AutoValidate = value
        End Set
    End Property

    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
        End Set
    End Property

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Return MyBase.CreateParams
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultImeMode As ImeMode
        Get
            Return MyBase.DefaultImeMode
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultSize As Size
        Get
            Return MyBase.DefaultSize
        End Get
    End Property

    Public Overrides Property MaximumSize As Size
        Get
            Return MyBase.MaximumSize
        End Get
        Set(value As Size)
            MyBase.MaximumSize = value
        End Set
    End Property

    Public Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = value
        End Set
    End Property

    Public Overrides Property RightToLeftLayout As Boolean
        Get
            Return MyBase.RightToLeftLayout
        End Get
        Set(value As Boolean)
            MyBase.RightToLeftLayout = value
        End Set
    End Property

    Protected Overrides ReadOnly Property ShowWithoutActivation As Boolean
        Get
            Return MyBase.ShowWithoutActivation
        End Get
    End Property

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    ' create a function to get the winner
    Private Sub getTheWinner()

        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button2.Text) AndAlso Button1.Text.Equals(Button3.Text) Then
            win = True
            winEffect(Button1, Button2, Button3)
        End If

        If Not Button4.Text.Equals("") AndAlso Button4.Text.Equals(Button5.Text) AndAlso Button4.Text.Equals(Button6.Text) Then
            win = True
            winEffect(Button4, Button5, Button6)
        End If

        If Not Button7.Text.Equals("") AndAlso Button7.Text.Equals(Button8.Text) AndAlso Button7.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button7, Button8, Button9)
        End If

        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button4.Text) AndAlso Button1.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button1, Button4, Button7)
        End If

        If Not Button2.Text.Equals("") AndAlso Button2.Text.Equals(Button5.Text) AndAlso Button2.Text.Equals(Button8.Text) Then
            win = True
            winEffect(Button2, Button5, Button8)
        End If

        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button6.Text) AndAlso Button3.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button3, Button6, Button9)
        End If

        If Not Button1.Text.Equals("") AndAlso Button1.Text.Equals(Button5.Text) AndAlso Button1.Text.Equals(Button9.Text) Then
            win = True
            winEffect(Button1, Button5, Button9)
        End If

        If Not Button3.Text.Equals("") AndAlso Button3.Text.Equals(Button5.Text) AndAlso Button3.Text.Equals(Button7.Text) Then
            win = True
            winEffect(Button3, Button5, Button7)
        End If

        ' if no one win later
        ' 9 buttons with X or O mean 9 char = no button is empty
        If allbuttonsTextLength() = 9 AndAlso win = False Then

            Label1.Text = "NO Winner"

        End If

    End Sub

    Function allbuttonsTextLength() As Integer

        Dim btnsTxtLength As Integer = 0

        For Each c As Control In Panel2.Controls

            If c.GetType() = GetType(Button) Then

                btnsTxtLength += c.Text.Length

            End If

        Next

        Return btnsTxtLength

    End Function

    Private Sub winEffect(ByVal b1 As Button, ByVal b2 As Button, ByVal b3 As Button)

        b1.BackColor = Color.Red
        b2.BackColor = Color.Red
        b3.BackColor = Color.Red

        b1.ForeColor = Color.White
        b2.ForeColor = Color.White
        b3.ForeColor = Color.White

        Label1.Text = b1.Text + " Win"

    End Sub



    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click

        XorO = 0
        win = False
        Label1.Text = "Play"
        For Each c As Control In Panel2.Controls

            If c.GetType() = GetType(Button) Then

                c.BackColor = Color.White
                c.Text = ""

            End If

        Next
    End Sub

    Private Sub BunifuCustomLabel3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles BunifuCustomLabel3.MouseDoubleClick
        Me.Hide()
        Homepage.Show()


    End Sub

    Private Sub BunifuCustomLabel3_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.MouseEnter
        BunifuCustomLabel3.ForeColor = Color.OrangeRed
    End Sub

    Private Sub BunifuCustomLabel3_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.MouseLeave
        BunifuCustomLabel3.ForeColor = Color.DimGray
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

    Public Overrides Function InitializeLifetimeService() As Object
        Return MyBase.InitializeLifetimeService()
    End Function

    Public Overrides Function CreateObjRef(requestedType As Type) As ObjRef
        Return MyBase.CreateObjRef(requestedType)
    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Protected Overrides Function GetService(service As Type) As Object
        Return MyBase.GetService(service)
    End Function

    Protected Overrides Function GetAccessibilityObjectById(objectId As Integer) As AccessibleObject
        Return MyBase.GetAccessibilityObjectById(objectId)
    End Function

    Public Overrides Function GetPreferredSize(proposedSize As Size) As Size
        Return MyBase.GetPreferredSize(proposedSize)
    End Function

    Protected Overrides Function CreateAccessibilityInstance() As AccessibleObject
        Return MyBase.CreateAccessibilityInstance()
    End Function

    Protected Overrides Sub DestroyHandle()
        MyBase.DestroyHandle()
    End Sub

    Protected Overrides Sub InitLayout()
        MyBase.InitLayout()
    End Sub

    Protected Overrides Function IsInputChar(charCode As Char) As Boolean
        Return MyBase.IsInputChar(charCode)
    End Function

    Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub NotifyInvalidate(invalidatedArea As Rectangle)
        MyBase.NotifyInvalidate(invalidatedArea)
    End Sub

    Protected Overrides Sub OnAutoSizeChanged(e As EventArgs)
        MyBase.OnAutoSizeChanged(e)
    End Sub

    Protected Overrides Sub OnBackColorChanged(e As EventArgs)
        MyBase.OnBackColorChanged(e)
    End Sub

    Protected Overrides Sub OnBindingContextChanged(e As EventArgs)
        MyBase.OnBindingContextChanged(e)
    End Sub

    Protected Overrides Sub OnCausesValidationChanged(e As EventArgs)
        MyBase.OnCausesValidationChanged(e)
    End Sub

    Protected Overrides Sub OnContextMenuChanged(e As EventArgs)
        MyBase.OnContextMenuChanged(e)
    End Sub

    Protected Overrides Sub OnContextMenuStripChanged(e As EventArgs)
        MyBase.OnContextMenuStripChanged(e)
    End Sub

    Protected Overrides Sub OnCursorChanged(e As EventArgs)
        MyBase.OnCursorChanged(e)
    End Sub

    Protected Overrides Sub OnDockChanged(e As EventArgs)
        MyBase.OnDockChanged(e)
    End Sub

    Protected Overrides Sub OnForeColorChanged(e As EventArgs)
        MyBase.OnForeColorChanged(e)
    End Sub

    Protected Overrides Sub OnNotifyMessage(m As Message)
        MyBase.OnNotifyMessage(m)
    End Sub

    Protected Overrides Sub OnParentBackColorChanged(e As EventArgs)
        MyBase.OnParentBackColorChanged(e)
    End Sub

    Protected Overrides Sub OnParentBackgroundImageChanged(e As EventArgs)
        MyBase.OnParentBackgroundImageChanged(e)
    End Sub

    Protected Overrides Sub OnParentBindingContextChanged(e As EventArgs)
        MyBase.OnParentBindingContextChanged(e)
    End Sub

    Protected Overrides Sub OnParentCursorChanged(e As EventArgs)
        MyBase.OnParentCursorChanged(e)
    End Sub

    Protected Overrides Sub OnParentEnabledChanged(e As EventArgs)
        MyBase.OnParentEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnParentFontChanged(e As EventArgs)
        MyBase.OnParentFontChanged(e)
    End Sub

    Protected Overrides Sub OnParentForeColorChanged(e As EventArgs)
        MyBase.OnParentForeColorChanged(e)
    End Sub

    Protected Overrides Sub OnParentRightToLeftChanged(e As EventArgs)
        MyBase.OnParentRightToLeftChanged(e)
    End Sub

    Protected Overrides Sub OnParentVisibleChanged(e As EventArgs)
        MyBase.OnParentVisibleChanged(e)
    End Sub

    Protected Overrides Sub OnPrint(e As PaintEventArgs)
        MyBase.OnPrint(e)
    End Sub

    Protected Overrides Sub OnTabIndexChanged(e As EventArgs)
        MyBase.OnTabIndexChanged(e)
    End Sub

    Protected Overrides Sub OnTabStopChanged(e As EventArgs)
        MyBase.OnTabStopChanged(e)
    End Sub

    Protected Overrides Sub OnClick(e As EventArgs)
        MyBase.OnClick(e)
    End Sub

    Protected Overrides Sub OnClientSizeChanged(e As EventArgs)
        MyBase.OnClientSizeChanged(e)
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        MyBase.OnControlAdded(e)
    End Sub

    Protected Overrides Sub OnControlRemoved(e As ControlEventArgs)
        MyBase.OnControlRemoved(e)
    End Sub

    Protected Overrides Sub OnLocationChanged(e As EventArgs)
        MyBase.OnLocationChanged(e)
    End Sub

    Protected Overrides Sub OnDoubleClick(e As EventArgs)
        MyBase.OnDoubleClick(e)
    End Sub

    Protected Overrides Sub OnDragEnter(drgevent As DragEventArgs)
        MyBase.OnDragEnter(drgevent)
    End Sub

    Protected Overrides Sub OnDragOver(drgevent As DragEventArgs)
        MyBase.OnDragOver(drgevent)
    End Sub

    Protected Overrides Sub OnDragLeave(e As EventArgs)
        MyBase.OnDragLeave(e)
    End Sub

    Protected Overrides Sub OnDragDrop(drgevent As DragEventArgs)
        MyBase.OnDragDrop(drgevent)
    End Sub

    Protected Overrides Sub OnGiveFeedback(gfbevent As GiveFeedbackEventArgs)
        MyBase.OnGiveFeedback(gfbevent)
    End Sub

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
    End Sub

    Protected Overrides Sub OnHelpRequested(hevent As HelpEventArgs)
        MyBase.OnHelpRequested(hevent)
    End Sub

    Protected Overrides Sub OnInvalidated(e As InvalidateEventArgs)
        MyBase.OnInvalidated(e)
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
    End Sub

    Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
        MyBase.OnKeyPress(e)
    End Sub

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
        MyBase.OnKeyUp(e)
    End Sub

    Protected Overrides Sub OnLeave(e As EventArgs)
        MyBase.OnLeave(e)
    End Sub

    Protected Overrides Sub OnLostFocus(e As EventArgs)
        MyBase.OnLostFocus(e)
    End Sub

    Protected Overrides Sub OnMarginChanged(e As EventArgs)
        MyBase.OnMarginChanged(e)
    End Sub

    Protected Overrides Sub OnMouseDoubleClick(e As MouseEventArgs)
        MyBase.OnMouseDoubleClick(e)
    End Sub

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)
    End Sub

    Protected Overrides Sub OnMouseCaptureChanged(e As EventArgs)
        MyBase.OnMouseCaptureChanged(e)
    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
    End Sub

    Protected Overrides Sub OnDpiChangedBeforeParent(e As EventArgs)
        MyBase.OnDpiChangedBeforeParent(e)
    End Sub

    Protected Overrides Sub OnDpiChangedAfterParent(e As EventArgs)
        MyBase.OnDpiChangedAfterParent(e)
    End Sub

    Protected Overrides Sub OnMouseHover(e As EventArgs)
        MyBase.OnMouseHover(e)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMove(e As EventArgs)
        MyBase.OnMove(e)
    End Sub

    Protected Overrides Sub OnQueryContinueDrag(qcdevent As QueryContinueDragEventArgs)
        MyBase.OnQueryContinueDrag(qcdevent)
    End Sub

    Protected Overrides Sub OnRegionChanged(e As EventArgs)
        MyBase.OnRegionChanged(e)
    End Sub

    Protected Overrides Sub OnPreviewKeyDown(e As PreviewKeyDownEventArgs)
        MyBase.OnPreviewKeyDown(e)
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)
    End Sub

    Protected Overrides Sub OnChangeUICues(e As UICuesEventArgs)
        MyBase.OnChangeUICues(e)
    End Sub

    Protected Overrides Sub OnSystemColorsChanged(e As EventArgs)
        MyBase.OnSystemColorsChanged(e)
    End Sub

    Protected Overrides Sub OnValidating(e As CancelEventArgs)
        MyBase.OnValidating(e)
    End Sub

    Protected Overrides Sub OnValidated(e As EventArgs)
        MyBase.OnValidated(e)
    End Sub

    Protected Overrides Sub RescaleConstantsForDpi(deviceDpiOld As Integer, deviceDpiNew As Integer)
        MyBase.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew)
    End Sub

    Public Overrides Function PreProcessMessage(ByRef msg As Message) As Boolean
        Return MyBase.PreProcessMessage(msg)
    End Function

    Protected Overrides Function ProcessKeyEventArgs(ByRef m As Message) As Boolean
        Return MyBase.ProcessKeyEventArgs(m)
    End Function

    Protected Overrides Function ProcessKeyMessage(ByRef m As Message) As Boolean
        Return MyBase.ProcessKeyMessage(m)
    End Function

    Public Overrides Sub ResetBackColor()
        MyBase.ResetBackColor()
    End Sub

    Public Overrides Sub ResetCursor()
        MyBase.ResetCursor()
    End Sub

    Public Overrides Sub ResetFont()
        MyBase.ResetFont()
    End Sub

    Public Overrides Sub ResetForeColor()
        MyBase.ResetForeColor()
    End Sub

    Public Overrides Sub ResetRightToLeft()
        MyBase.ResetRightToLeft()
    End Sub

    Public Overrides Sub Refresh()
        MyBase.Refresh()
    End Sub

    Public Overrides Sub ResetText()
        MyBase.ResetText()
    End Sub

    Protected Overrides Function SizeFromClientSize(clientSize As Size) As Size
        Return MyBase.SizeFromClientSize(clientSize)
    End Function

    Protected Overrides Sub OnImeModeChanged(e As EventArgs)
        MyBase.OnImeModeChanged(e)
    End Sub

    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)
    End Sub

    Protected Overrides Sub OnRightToLeftChanged(e As EventArgs)
        MyBase.OnRightToLeftChanged(e)
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        MyBase.OnPaintBackground(e)
    End Sub

    Protected Overrides Sub OnPaddingChanged(e As EventArgs)
        MyBase.OnPaddingChanged(e)
    End Sub

    Protected Overrides Function ScrollToControl(activeControl As Control) As Point
        Return MyBase.ScrollToControl(activeControl)
    End Function

    Protected Overrides Sub OnScroll(se As ScrollEventArgs)
        MyBase.OnScroll(se)
    End Sub

    Protected Overrides Sub OnAutoValidateChanged(e As EventArgs)
        MyBase.OnAutoValidateChanged(e)
    End Sub

    Protected Overrides Sub OnParentChanged(e As EventArgs)
        MyBase.OnParentChanged(e)
    End Sub

    Protected Overrides Sub SetVisibleCore(value As Boolean)
        MyBase.SetVisibleCore(value)
    End Sub

    Protected Overrides Sub AdjustFormScrollbars(displayScrollbars As Boolean)
        MyBase.AdjustFormScrollbars(displayScrollbars)
    End Sub

    Protected Overrides Function CreateControlsInstance() As Control.ControlCollection
        Return MyBase.CreateControlsInstance()
    End Function

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
    End Sub

    Protected Overrides Sub DefWndProc(ByRef m As Message)
        MyBase.DefWndProc(m)
    End Sub

    Protected Overrides Function ProcessMnemonic(charCode As Char) As Boolean
        Return MyBase.ProcessMnemonic(charCode)
    End Function

    Protected Overrides Sub OnActivated(e As EventArgs)
        MyBase.OnActivated(e)
    End Sub

    Protected Overrides Sub OnBackgroundImageChanged(e As EventArgs)
        MyBase.OnBackgroundImageChanged(e)
    End Sub

    Protected Overrides Sub OnBackgroundImageLayoutChanged(e As EventArgs)
        MyBase.OnBackgroundImageLayoutChanged(e)
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
    End Sub

    Protected Overrides Sub OnClosed(e As EventArgs)
        MyBase.OnClosed(e)
    End Sub

    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        MyBase.OnFormClosed(e)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
    End Sub

    Protected Overrides Sub OnDeactivate(e As EventArgs)
        MyBase.OnDeactivate(e)
    End Sub

    Protected Overrides Sub OnEnabledChanged(e As EventArgs)
        MyBase.OnEnabledChanged(e)
    End Sub

    Protected Overrides Sub OnEnter(e As EventArgs)
        MyBase.OnEnter(e)
    End Sub

    Protected Overrides Sub OnFontChanged(e As EventArgs)
        MyBase.OnFontChanged(e)
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
    End Sub

    Protected Overrides Sub OnHandleDestroyed(e As EventArgs)
        MyBase.OnHandleDestroyed(e)
    End Sub

    Protected Overrides Sub OnHelpButtonClicked(e As CancelEventArgs)
        MyBase.OnHelpButtonClicked(e)
    End Sub

    Protected Overrides Sub OnLayout(levent As LayoutEventArgs)
        MyBase.OnLayout(levent)
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
    End Sub

    Protected Overrides Sub OnMaximizedBoundsChanged(e As EventArgs)
        MyBase.OnMaximizedBoundsChanged(e)
    End Sub

    Protected Overrides Sub OnMaximumSizeChanged(e As EventArgs)
        MyBase.OnMaximumSizeChanged(e)
    End Sub

    Protected Overrides Sub OnMinimumSizeChanged(e As EventArgs)
        MyBase.OnMinimumSizeChanged(e)
    End Sub

    Protected Overrides Sub OnInputLanguageChanged(e As InputLanguageChangedEventArgs)
        MyBase.OnInputLanguageChanged(e)
    End Sub

    Protected Overrides Sub OnInputLanguageChanging(e As InputLanguageChangingEventArgs)
        MyBase.OnInputLanguageChanging(e)
    End Sub

    Protected Overrides Sub OnVisibleChanged(e As EventArgs)
        MyBase.OnVisibleChanged(e)
    End Sub

    Protected Overrides Sub OnMdiChildActivate(e As EventArgs)
        MyBase.OnMdiChildActivate(e)
    End Sub

    Protected Overrides Sub OnMenuStart(e As EventArgs)
        MyBase.OnMenuStart(e)
    End Sub

    Protected Overrides Sub OnMenuComplete(e As EventArgs)
        MyBase.OnMenuComplete(e)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
    End Sub

    Protected Overrides Sub OnDpiChanged(e As DpiChangedEventArgs)
        MyBase.OnDpiChanged(e)
    End Sub

    Protected Overrides Function OnGetDpiScaledSize(deviceDpiOld As Integer, deviceDpiNew As Integer, ByRef desiredSize As Size) As Boolean
        Return MyBase.OnGetDpiScaledSize(deviceDpiOld, deviceDpiNew, desiredSize)
    End Function

    Protected Overrides Sub OnRightToLeftLayoutChanged(e As EventArgs)
        MyBase.OnRightToLeftLayoutChanged(e)
    End Sub

    Protected Overrides Sub OnShown(e As EventArgs)
        MyBase.OnShown(e)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean
        Return MyBase.ProcessDialogKey(keyData)
    End Function

    Protected Overrides Function ProcessDialogChar(charCode As Char) As Boolean
        Return MyBase.ProcessDialogChar(charCode)
    End Function

    Protected Overrides Function ProcessKeyPreview(ByRef m As Message) As Boolean
        Return MyBase.ProcessKeyPreview(m)
    End Function

    Protected Overrides Function ProcessTabKey(forward As Boolean) As Boolean
        Return MyBase.ProcessTabKey(forward)
    End Function

    Protected Overrides Sub [Select](directed As Boolean, forward As Boolean)
        MyBase.Select(directed, forward)
    End Sub

    Protected Overrides Sub ScaleCore(x As Single, y As Single)
        MyBase.ScaleCore(x, y)
    End Sub

    Protected Overrides Function GetScaledBounds(bounds As Rectangle, factor As SizeF, specified As BoundsSpecified) As Rectangle
        Return MyBase.GetScaledBounds(bounds, factor, specified)
    End Function

    Protected Overrides Sub ScaleControl(factor As SizeF, specified As BoundsSpecified)
        MyBase.ScaleControl(factor, specified)
    End Sub

    Protected Overrides Sub SetBoundsCore(x As Integer, y As Integer, width As Integer, height As Integer, specified As BoundsSpecified)
        MyBase.SetBoundsCore(x, y, width, height, specified)
    End Sub

    Protected Overrides Sub SetClientSizeCore(x As Integer, y As Integer)
        MyBase.SetClientSizeCore(x, y)
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Protected Overrides Sub UpdateDefaultButton()
        MyBase.UpdateDefaultButton()
    End Sub

    Protected Overrides Sub OnResizeBegin(e As EventArgs)
        MyBase.OnResizeBegin(e)
    End Sub

    Protected Overrides Sub OnResizeEnd(e As EventArgs)
        MyBase.OnResizeEnd(e)
    End Sub

    Protected Overrides Sub OnStyleChanged(e As EventArgs)
        MyBase.OnStyleChanged(e)
    End Sub

    Public Overrides Function ValidateChildren() As Boolean
        Return MyBase.ValidateChildren()
    End Function

    Public Overrides Function ValidateChildren(validationConstraints As ValidationConstraints) As Boolean
        Return MyBase.ValidateChildren(validationConstraints)
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
    End Sub


End Class