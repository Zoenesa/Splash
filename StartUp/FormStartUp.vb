Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Threading
Imports System.Xml

Public Class FormStartUp

    ' Threading
    Private Shared ms_frmSplash As FormStartUp = Nothing
    Private Shared ms_oThread As Thread = Nothing

    ' Fade in and out.
    Private m_dblOpacityIncrement As Double = 0.05
    Private m_dblOpacityDecrement As Double = 0.08
    Private Const TIMER_INTERVAL As Integer = 50

    ' Status and progress bar
    Private m_sStatus As String
    Private m_sTimeRemaining As String
    Private m_dblCompletionFraction As Double = 0.0
    Private m_rProgress As Rectangle

    ' Progress smoothing
    Private m_dblLastCompletionFraction As Double = 0.0
    Private m_dblPBIncrementPerTimerInterval As Double = 0.015

    ' Self-calibration support
    Private m_iIndex As Integer = 1
    Private m_iActualTicks As Integer = 0
    Private m_alPreviousCompletionFraction As ArrayList
    Private m_alActualTimes As New ArrayList()
    Private m_dtStart As DateTime
    Private m_bFirstLaunch As Boolean = False
    Private m_bDTSet As Boolean = False

    Shared Sub New()
        ms_frmSplash = Nothing
        ms_oThread = Nothing
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.Opacity = 0.0
        UpdateTimer.Interval = TIMER_INTERVAL
        UpdateTimer.Start()
    End Sub

    Public Shared Sub ShowSplashScreen()
        ' Make sure it's only launched once.
        If Not (ms_frmSplash Is Nothing) Then
            Return
        End If
        ms_oThread = New Thread(New ThreadStart(AddressOf FormStartUp.ShowForm))
        ms_oThread.IsBackground = True
        ms_oThread.SetApartmentState(ApartmentState.STA)
        ms_oThread.Start()
        While ms_frmSplash Is Nothing OrElse ms_frmSplash.IsHandleCreated = False
            System.Threading.Thread.Sleep(TIMER_INTERVAL)
        End While
    End Sub

    Public Shared Sub CloseForm()
        If Not (ms_frmSplash Is Nothing) AndAlso ms_frmSplash.IsDisposed = False Then
            ' Make it start going away.
            ms_frmSplash.m_dblOpacityIncrement = -ms_frmSplash.m_dblOpacityDecrement
        End If
        ms_oThread = Nothing
        ' we don't need these any more.
        ms_frmSplash = Nothing
    End Sub

    Public Shared Sub SetStatus(newStatus As String)
        SetStatus(newStatus, True)
    End Sub

    Public Shared Sub SetStatus(newStatus As String, setReference As Boolean)
        If ms_frmSplash Is Nothing Then
            Return
        End If
        ms_frmSplash.m_sStatus = newStatus
        If setReference Then
            ms_frmSplash.SetReferenceInternal()
        End If
    End Sub

    Public Shared Sub SetReferencePoint()
        If ms_frmSplash Is Nothing Then
            Return
        End If
        ms_frmSplash.SetReferenceInternal()

    End Sub

    Private Shared Sub ShowForm()
        ms_frmSplash = New FormStartUp()
        Application.Run(ms_frmSplash)
    End Sub

    Private Sub SetReferenceInternal()
        If m_bDTSet = False Then
            m_bDTSet = True
            m_dtStart = DateTime.Now
            ReadIncrements()
        End If
        Dim dblMilliseconds As Double = ElapsedMilliSeconds()
        m_alActualTimes.Add(dblMilliseconds)
        m_dblLastCompletionFraction = m_dblCompletionFraction
        If Not (m_alPreviousCompletionFraction Is Nothing) AndAlso m_iIndex < m_alPreviousCompletionFraction.Count Then
            m_dblCompletionFraction = DirectCast(m_alPreviousCompletionFraction(System.Math.Max(System.Threading.Interlocked.Increment(m_iIndex), m_iIndex - 1)), Double)
        Else
            m_dblCompletionFraction = If((m_iIndex > 0), 1, 0)
        End If
    End Sub

    Private Function ElapsedMilliSeconds() As Double
        Dim ts As TimeSpan = DateTime.Now - m_dtStart
        Return ts.TotalMilliseconds
    End Function

    Private Sub ReadIncrements()
        Dim sPBIncrementPerTimerInterval As String = SplashScreenXMLStorage.Interval
        Dim dblResult As Double

        If [Double].TryParse(sPBIncrementPerTimerInterval, System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, dblResult) = True Then
            m_dblPBIncrementPerTimerInterval = dblResult
        Else
            m_dblPBIncrementPerTimerInterval = 0.0015
        End If

        Dim sPBPreviousPctComplete As String = SplashScreenXMLStorage.Percents

        If sPBPreviousPctComplete <> "" Then
            Dim aTimes As String() = sPBPreviousPctComplete.Split(Nothing)
            m_alPreviousCompletionFraction = New ArrayList()

            Dim i As Integer = 0
            While i < aTimes.Length
                Dim dblVal As Double
                If [Double].TryParse(aTimes(i), System.Globalization.NumberStyles.Float, System.Globalization.NumberFormatInfo.InvariantInfo, dblVal) = True Then
                    m_alPreviousCompletionFraction.Add(dblVal)
                Else
                    m_alPreviousCompletionFraction.Add(1.0)
                End If
                System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
            End While
        Else
            m_bFirstLaunch = True
            m_sTimeRemaining = ""
        End If
    End Sub

    Private Sub StoreIncrements()
        Dim sPercent As String = ""
        Dim dblElapsedMilliseconds As Double = ElapsedMilliSeconds()
        Dim i As Integer = 0
        While i < m_alActualTimes.Count
            sPercent += (DirectCast(m_alActualTimes(i), Double) / dblElapsedMilliseconds).ToString("0.####", System.Globalization.NumberFormatInfo.InvariantInfo) + " "
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        SplashScreenXMLStorage.Percents = sPercent

        m_dblPBIncrementPerTimerInterval = 1.0 / CDbl(m_iActualTicks)

        SplashScreenXMLStorage.Interval = m_dblPBIncrementPerTimerInterval.ToString("#.000000", System.Globalization.NumberFormatInfo.InvariantInfo)
    End Sub

    Public Shared Function GetSplashScreen() As FormStartUp
        Return ms_frmSplash
    End Function

    Private Sub CekInisialKonpig()

    End Sub

    Private Sub CekInisialKonektor()

    End Sub

    Private Function CekInisialFolder() As Boolean
        Dim flag As Boolean


        Return flag
    End Function

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        Me.lblStatus.Text = Me.m_sStatus
        If (Me.m_dblOpacityIncrement > 0) Then
            Me.m_iActualTicks += 1
            If (MyBase.Opacity < 1) Then
                MyBase.Opacity = (MyBase.Opacity + Me.m_dblOpacityIncrement)
            End If
        ElseIf (MyBase.Opacity > 0) Then
            MyBase.Opacity = (MyBase.Opacity + Me.m_dblOpacityIncrement)
        Else
            Me.StoreIncrements()
            Me.UpdateTimer.Stop()
            MyBase.Close()
        End If
        If (Not Me.m_bFirstLaunch AndAlso (Me.m_dblLastCompletionFraction < Me.m_dblCompletionFraction)) Then
            Me.m_dblLastCompletionFraction = (Me.m_dblLastCompletionFraction + Me.m_dblPBIncrementPerTimerInterval)
            Dim width As Integer = CInt(Math.Floor(CDbl((Me.pnlStatus.ClientRectangle.Width * Me.m_dblLastCompletionFraction))))
            Dim height As Integer = Me.pnlStatus.ClientRectangle.Height
            Dim x As Integer = Me.pnlStatus.ClientRectangle.X
            Dim y As Integer = Me.pnlStatus.ClientRectangle.Y
            If ((width > 0) AndAlso (height > 0)) Then
                Me.m_rProgress = New Rectangle(x, y, width, height)
                If Not Me.pnlStatus.IsDisposed Then
                    Dim graphics As Graphics = Me.pnlStatus.CreateGraphics
                    Dim brush As New LinearGradientBrush(Me.m_rProgress, Color.FromArgb(58, 96, 151), Color.FromArgb(181, 237, 254), LinearGradientMode.Horizontal)
                    graphics.FillRectangle(brush, Me.m_rProgress)
                    graphics.Dispose()
                End If
                Dim num6 As Integer = (1 + (CInt((50 * ((1 - Me.m_dblLastCompletionFraction) / Me.m_dblPBIncrementPerTimerInterval))) / 1000))
                Me.m_sTimeRemaining = If((num6 = 1), String.Format("1 second remaining", New Object(0 - 1) {}), String.Format("{0} seconds remaining", num6))
            End If
        End If
        Me.lblTimeRemaining.Text = Me.m_sTimeRemaining

    End Sub

    Friend Class SplashScreenXMLStorage
        Private Shared ms_StoredValues As String = "SplashScreen.xml"
        Private Shared ms_DefaultPercents As String = ""
        Private Shared ms_DefaultIncrement As String = ".015"


        ' Get or set the string storing the percentage complete at each checkpoint.
        Public Shared Property Percents() As String
            Get
                Return GetValue("Percents", ms_DefaultPercents)
            End Get
            Set
                SetValue("Percents", Value)
            End Set
        End Property
        ' Get or set how much time passes between updates.
        Public Shared Property Interval() As String
            Get
                Return GetValue("Interval", ms_DefaultIncrement)
            End Get
            Set
                SetValue("Interval", Value)
            End Set
        End Property

        ' Store the file in a location where it can be written with only User rights. (Don't use install directory).
        Private Shared ReadOnly Property StoragePath() As String
            Get
                Return Path.Combine(Application.UserAppDataPath, ms_StoredValues)
            End Get
        End Property

        ' Helper method for getting inner text of named element.
        Private Shared Function GetValue(name As String, defaultValue As String) As String
            If Not File.Exists(StoragePath) Then
                Return defaultValue
            End If

            Try
                Dim docXML As New XmlDocument()
                docXML.Load(StoragePath)
                Dim elValue As XmlElement = TryCast(docXML.DocumentElement.SelectSingleNode(name), XmlElement)
                Return If((elValue Is Nothing), defaultValue, elValue.InnerText)
            Catch
                Return defaultValue
            End Try
        End Function

        ' Helper method for setting inner text of named element.  Creates document if it doesn't exist.
        Public Shared Sub SetValue(name As String, stringValue As String)
            Dim docXML As New XmlDocument()
            Dim elRoot As XmlElement = Nothing
            If Not File.Exists(StoragePath) Then
                elRoot = docXML.CreateElement("root")
                docXML.AppendChild(elRoot)
            Else
                docXML.Load(StoragePath)
                elRoot = docXML.DocumentElement
            End If
            Dim value As XmlElement = TryCast(docXML.DocumentElement.SelectSingleNode(name), XmlElement)
            If value Is Nothing Then
                value = docXML.CreateElement(name)
                elRoot.AppendChild(value)
            End If
            value.InnerText = stringValue
            docXML.Save(StoragePath)
        End Sub
    End Class

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TableLayoutPanel1_DoubleClick(sender As Object, e As EventArgs) Handles TableLayoutPanel1.DoubleClick
        FormStartUp.CloseForm()
    End Sub
End Class