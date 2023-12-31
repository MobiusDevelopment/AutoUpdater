<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
		Me.lblFileName = New System.Windows.Forms.Label()
		Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
		Me.MyWebBrowser = New System.Windows.Forms.WebBrowser()
		Me.picMinimize = New System.Windows.Forms.PictureBox()
		Me.picClose = New System.Windows.Forms.PictureBox()
		Me.picMinimizeNormal = New System.Windows.Forms.PictureBox()
		Me.picMinimizeOver = New System.Windows.Forms.PictureBox()
		Me.picMinimizeSelected = New System.Windows.Forms.PictureBox()
		Me.picCloseNormal = New System.Windows.Forms.PictureBox()
		Me.picCloseOver = New System.Windows.Forms.PictureBox()
		Me.picCloseSelected = New System.Windows.Forms.PictureBox()
		Me.picStart = New System.Windows.Forms.PictureBox()
		Me.picStartNormal = New System.Windows.Forms.PictureBox()
		Me.picStartOver = New System.Windows.Forms.PictureBox()
		Me.picStartSelected = New System.Windows.Forms.PictureBox()
		Me.picRepair = New System.Windows.Forms.PictureBox()
		Me.picRepairNormal = New System.Windows.Forms.PictureBox()
		Me.picRepairOver = New System.Windows.Forms.PictureBox()
		Me.picRepairSelected = New System.Windows.Forms.PictureBox()
		Me.picLoadingBack = New System.Windows.Forms.PictureBox()
		Me.picLoadingFore = New System.Windows.Forms.PictureBox()
		Me.picLoadingSeperator = New System.Windows.Forms.PictureBox()
		CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picMinimizeNormal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picMinimizeOver, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picMinimizeSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCloseNormal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCloseOver, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCloseSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picStart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picStartNormal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picStartOver, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picStartSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picRepair, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picRepairNormal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picRepairOver, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picRepairSelected, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picLoadingBack, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picLoadingFore, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picLoadingSeperator, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblFileName
		'
		Me.lblFileName.BackColor = System.Drawing.Color.Transparent
		Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
		Me.lblFileName.ForeColor = System.Drawing.Color.BurlyWood
		Me.lblFileName.Location = New System.Drawing.Point(155, 368)
		Me.lblFileName.Name = "lblFileName"
		Me.lblFileName.Size = New System.Drawing.Size(327, 18)
		Me.lblFileName.TabIndex = 3
		'
		'UpdateTimer
		'
		Me.UpdateTimer.Interval = 500
		'
		'MyWebBrowser
		'
		Me.MyWebBrowser.Location = New System.Drawing.Point(27, 50)
		Me.MyWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
		Me.MyWebBrowser.Name = "MyWebBrowser"
		Me.MyWebBrowser.ScriptErrorsSuppressed = True
		Me.MyWebBrowser.ScrollBarsEnabled = False
		Me.MyWebBrowser.Size = New System.Drawing.Size(566, 237)
		Me.MyWebBrowser.TabIndex = 20
		Me.MyWebBrowser.Url = New System.Uri("", System.UriKind.Relative)
		Me.MyWebBrowser.Visible = False
		'
		'picMinimize
		'
		Me.picMinimize.BackColor = System.Drawing.Color.Transparent
		Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picMinimize.Image = CType(resources.GetObject("picMinimize.Image"), System.Drawing.Image)
		Me.picMinimize.Location = New System.Drawing.Point(565, 14)
		Me.picMinimize.Name = "picMinimize"
		Me.picMinimize.Size = New System.Drawing.Size(16, 16)
		Me.picMinimize.TabIndex = 21
		Me.picMinimize.TabStop = False
		'
		'picClose
		'
		Me.picClose.BackColor = System.Drawing.Color.Transparent
		Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
		Me.picClose.Location = New System.Drawing.Point(587, 15)
		Me.picClose.Name = "picClose"
		Me.picClose.Size = New System.Drawing.Size(16, 16)
		Me.picClose.TabIndex = 22
		Me.picClose.TabStop = False
		'
		'picMinimizeNormal
		'
		Me.picMinimizeNormal.BackColor = System.Drawing.Color.Transparent
		Me.picMinimizeNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picMinimizeNormal.Image = CType(resources.GetObject("picMinimizeNormal.Image"), System.Drawing.Image)
		Me.picMinimizeNormal.Location = New System.Drawing.Point(434, 15)
		Me.picMinimizeNormal.Name = "picMinimizeNormal"
		Me.picMinimizeNormal.Size = New System.Drawing.Size(16, 16)
		Me.picMinimizeNormal.TabIndex = 23
		Me.picMinimizeNormal.TabStop = False
		Me.picMinimizeNormal.Visible = False
		'
		'picMinimizeOver
		'
		Me.picMinimizeOver.BackColor = System.Drawing.Color.Transparent
		Me.picMinimizeOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picMinimizeOver.Image = CType(resources.GetObject("picMinimizeOver.Image"), System.Drawing.Image)
		Me.picMinimizeOver.Location = New System.Drawing.Point(450, 15)
		Me.picMinimizeOver.Name = "picMinimizeOver"
		Me.picMinimizeOver.Size = New System.Drawing.Size(16, 16)
		Me.picMinimizeOver.TabIndex = 24
		Me.picMinimizeOver.TabStop = False
		Me.picMinimizeOver.Visible = False
		'
		'picMinimizeSelected
		'
		Me.picMinimizeSelected.BackColor = System.Drawing.Color.Transparent
		Me.picMinimizeSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picMinimizeSelected.Image = CType(resources.GetObject("picMinimizeSelected.Image"), System.Drawing.Image)
		Me.picMinimizeSelected.Location = New System.Drawing.Point(466, 15)
		Me.picMinimizeSelected.Name = "picMinimizeSelected"
		Me.picMinimizeSelected.Size = New System.Drawing.Size(16, 16)
		Me.picMinimizeSelected.TabIndex = 25
		Me.picMinimizeSelected.TabStop = False
		Me.picMinimizeSelected.Visible = False
		'
		'picCloseNormal
		'
		Me.picCloseNormal.BackColor = System.Drawing.Color.Transparent
		Me.picCloseNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picCloseNormal.Image = CType(resources.GetObject("picCloseNormal.Image"), System.Drawing.Image)
		Me.picCloseNormal.Location = New System.Drawing.Point(487, 15)
		Me.picCloseNormal.Name = "picCloseNormal"
		Me.picCloseNormal.Size = New System.Drawing.Size(16, 16)
		Me.picCloseNormal.TabIndex = 26
		Me.picCloseNormal.TabStop = False
		Me.picCloseNormal.Visible = False
		'
		'picCloseOver
		'
		Me.picCloseOver.BackColor = System.Drawing.Color.Transparent
		Me.picCloseOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picCloseOver.Image = CType(resources.GetObject("picCloseOver.Image"), System.Drawing.Image)
		Me.picCloseOver.Location = New System.Drawing.Point(503, 15)
		Me.picCloseOver.Name = "picCloseOver"
		Me.picCloseOver.Size = New System.Drawing.Size(16, 16)
		Me.picCloseOver.TabIndex = 27
		Me.picCloseOver.TabStop = False
		Me.picCloseOver.Visible = False
		'
		'picCloseSelected
		'
		Me.picCloseSelected.BackColor = System.Drawing.Color.Transparent
		Me.picCloseSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picCloseSelected.Image = CType(resources.GetObject("picCloseSelected.Image"), System.Drawing.Image)
		Me.picCloseSelected.Location = New System.Drawing.Point(518, 15)
		Me.picCloseSelected.Name = "picCloseSelected"
		Me.picCloseSelected.Size = New System.Drawing.Size(16, 16)
		Me.picCloseSelected.TabIndex = 28
		Me.picCloseSelected.TabStop = False
		Me.picCloseSelected.Visible = False
		'
		'picStart
		'
		Me.picStart.BackColor = System.Drawing.Color.Transparent
		Me.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picStart.Image = CType(resources.GetObject("picStart.Image"), System.Drawing.Image)
		Me.picStart.Location = New System.Drawing.Point(470, 274)
		Me.picStart.Name = "picStart"
		Me.picStart.Size = New System.Drawing.Size(157, 146)
		Me.picStart.TabIndex = 29
		Me.picStart.TabStop = False
		'
		'picStartNormal
		'
		Me.picStartNormal.BackColor = System.Drawing.Color.Transparent
		Me.picStartNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picStartNormal.Image = CType(resources.GetObject("picStartNormal.Image"), System.Drawing.Image)
		Me.picStartNormal.Location = New System.Drawing.Point(387, 288)
		Me.picStartNormal.Name = "picStartNormal"
		Me.picStartNormal.Size = New System.Drawing.Size(22, 21)
		Me.picStartNormal.TabIndex = 30
		Me.picStartNormal.TabStop = False
		Me.picStartNormal.Visible = False
		'
		'picStartOver
		'
		Me.picStartOver.BackColor = System.Drawing.Color.Transparent
		Me.picStartOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picStartOver.Image = CType(resources.GetObject("picStartOver.Image"), System.Drawing.Image)
		Me.picStartOver.Location = New System.Drawing.Point(413, 288)
		Me.picStartOver.Name = "picStartOver"
		Me.picStartOver.Size = New System.Drawing.Size(22, 21)
		Me.picStartOver.TabIndex = 31
		Me.picStartOver.TabStop = False
		Me.picStartOver.Visible = False
		'
		'picStartSelected
		'
		Me.picStartSelected.BackColor = System.Drawing.Color.Transparent
		Me.picStartSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picStartSelected.Image = CType(resources.GetObject("picStartSelected.Image"), System.Drawing.Image)
		Me.picStartSelected.Location = New System.Drawing.Point(440, 288)
		Me.picStartSelected.Name = "picStartSelected"
		Me.picStartSelected.Size = New System.Drawing.Size(22, 21)
		Me.picStartSelected.TabIndex = 32
		Me.picStartSelected.TabStop = False
		Me.picStartSelected.Visible = False
		'
		'picRepair
		'
		Me.picRepair.BackColor = System.Drawing.Color.Transparent
		Me.picRepair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picRepair.Image = CType(resources.GetObject("picRepair.Image"), System.Drawing.Image)
		Me.picRepair.Location = New System.Drawing.Point(-15, 345)
		Me.picRepair.Name = "picRepair"
		Me.picRepair.Size = New System.Drawing.Size(201, 73)
		Me.picRepair.TabIndex = 33
		Me.picRepair.TabStop = False
		'
		'picRepairNormal
		'
		Me.picRepairNormal.BackColor = System.Drawing.Color.Transparent
		Me.picRepairNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picRepairNormal.Image = CType(resources.GetObject("picRepairNormal.Image"), System.Drawing.Image)
		Me.picRepairNormal.Location = New System.Drawing.Point(25, 289)
		Me.picRepairNormal.Name = "picRepairNormal"
		Me.picRepairNormal.Size = New System.Drawing.Size(27, 27)
		Me.picRepairNormal.TabIndex = 34
		Me.picRepairNormal.TabStop = False
		Me.picRepairNormal.Visible = False
		'
		'picRepairOver
		'
		Me.picRepairOver.BackColor = System.Drawing.Color.Transparent
		Me.picRepairOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picRepairOver.Image = CType(resources.GetObject("picRepairOver.Image"), System.Drawing.Image)
		Me.picRepairOver.Location = New System.Drawing.Point(58, 289)
		Me.picRepairOver.Name = "picRepairOver"
		Me.picRepairOver.Size = New System.Drawing.Size(27, 27)
		Me.picRepairOver.TabIndex = 35
		Me.picRepairOver.TabStop = False
		Me.picRepairOver.Visible = False
		'
		'picRepairSelected
		'
		Me.picRepairSelected.BackColor = System.Drawing.Color.Transparent
		Me.picRepairSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picRepairSelected.Image = CType(resources.GetObject("picRepairSelected.Image"), System.Drawing.Image)
		Me.picRepairSelected.Location = New System.Drawing.Point(91, 289)
		Me.picRepairSelected.Name = "picRepairSelected"
		Me.picRepairSelected.Size = New System.Drawing.Size(27, 27)
		Me.picRepairSelected.TabIndex = 36
		Me.picRepairSelected.TabStop = False
		Me.picRepairSelected.Visible = False
		'
		'picLoadingBack
		'
		Me.picLoadingBack.BackColor = System.Drawing.Color.Transparent
		Me.picLoadingBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picLoadingBack.Image = CType(resources.GetObject("picLoadingBack.Image"), System.Drawing.Image)
		Me.picLoadingBack.Location = New System.Drawing.Point(28, 315)
		Me.picLoadingBack.Name = "picLoadingBack"
		Me.picLoadingBack.Size = New System.Drawing.Size(454, 39)
		Me.picLoadingBack.TabIndex = 37
		Me.picLoadingBack.TabStop = False
		'
		'picLoadingFore
		'
		Me.picLoadingFore.BackColor = System.Drawing.Color.Transparent
		Me.picLoadingFore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picLoadingFore.Image = CType(resources.GetObject("picLoadingFore.Image"), System.Drawing.Image)
		Me.picLoadingFore.Location = New System.Drawing.Point(28, 315)
		Me.picLoadingFore.Name = "picLoadingFore"
		Me.picLoadingFore.Size = New System.Drawing.Size(454, 39)
		Me.picLoadingFore.TabIndex = 38
		Me.picLoadingFore.TabStop = False
		'
		'picLoadingSeperator
		'
		Me.picLoadingSeperator.BackColor = System.Drawing.Color.Transparent
		Me.picLoadingSeperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.picLoadingSeperator.Image = CType(resources.GetObject("picLoadingSeperator.Image"), System.Drawing.Image)
		Me.picLoadingSeperator.Location = New System.Drawing.Point(482, 315)
		Me.picLoadingSeperator.Name = "picLoadingSeperator"
		Me.picLoadingSeperator.Size = New System.Drawing.Size(1, 39)
		Me.picLoadingSeperator.TabIndex = 39
		Me.picLoadingSeperator.TabStop = False
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(620, 419)
		Me.Controls.Add(Me.picLoadingSeperator)
		Me.Controls.Add(Me.picLoadingFore)
		Me.Controls.Add(Me.picLoadingBack)
		Me.Controls.Add(Me.lblFileName)
		Me.Controls.Add(Me.picRepair)
		Me.Controls.Add(Me.picRepairSelected)
		Me.Controls.Add(Me.picRepairOver)
		Me.Controls.Add(Me.picRepairNormal)
		Me.Controls.Add(Me.picStartSelected)
		Me.Controls.Add(Me.picStartOver)
		Me.Controls.Add(Me.picStartNormal)
		Me.Controls.Add(Me.picCloseSelected)
		Me.Controls.Add(Me.picCloseOver)
		Me.Controls.Add(Me.picCloseNormal)
		Me.Controls.Add(Me.picMinimizeSelected)
		Me.Controls.Add(Me.picMinimizeOver)
		Me.Controls.Add(Me.picMinimizeNormal)
		Me.Controls.Add(Me.picClose)
		Me.Controls.Add(Me.picMinimize)
		Me.Controls.Add(Me.MyWebBrowser)
		Me.Controls.Add(Me.picStart)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.ForeColor = System.Drawing.Color.Transparent
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "AutoUpdater"
		CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picMinimizeNormal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picMinimizeOver, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picMinimizeSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCloseNormal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCloseOver, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCloseSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picStart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picStartNormal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picStartOver, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picStartSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picRepair, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picRepairNormal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picRepairOver, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picRepairSelected, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picLoadingBack, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picLoadingFore, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picLoadingSeperator, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents lblFileName As Label
	Friend WithEvents UpdateTimer As Timer
	Friend WithEvents MyWebBrowser As WebBrowser
	Friend WithEvents picMinimize As PictureBox
	Friend WithEvents picClose As PictureBox
	Friend WithEvents picMinimizeNormal As PictureBox
	Friend WithEvents picMinimizeOver As PictureBox
	Friend WithEvents picMinimizeSelected As PictureBox
	Friend WithEvents picCloseNormal As PictureBox
	Friend WithEvents picCloseOver As PictureBox
	Friend WithEvents picCloseSelected As PictureBox
	Friend WithEvents picStart As PictureBox
	Friend WithEvents picStartNormal As PictureBox
	Friend WithEvents picStartOver As PictureBox
	Friend WithEvents picStartSelected As PictureBox
	Friend WithEvents picRepair As PictureBox
	Friend WithEvents picRepairNormal As PictureBox
	Friend WithEvents picRepairOver As PictureBox
	Friend WithEvents picRepairSelected As PictureBox
	Friend WithEvents picLoadingBack As PictureBox
	Friend WithEvents picLoadingFore As PictureBox
	Friend WithEvents picLoadingSeperator As PictureBox
End Class
