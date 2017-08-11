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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.MyProgressBar = New System.Windows.Forms.ProgressBar()
        Me.UpdateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MyWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'lblFileName
        '
        Me.lblFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblFileName.ForeColor = System.Drawing.Color.Black
        Me.lblFileName.Location = New System.Drawing.Point(16, 362)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(449, 17)
        Me.lblFileName.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnStart.Location = New System.Drawing.Point(472, 315)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(134, 71)
        Me.btnStart.TabIndex = 15
        Me.btnStart.TabStop = False
        Me.btnStart.Text = "Play Now"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnCheck.Location = New System.Drawing.Point(13, 392)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(78, 23)
        Me.btnCheck.TabIndex = 16
        Me.btnCheck.TabStop = False
        Me.btnCheck.Text = "File Repair"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnMinimize
        '
        Me.btnMinimize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnMinimize.Location = New System.Drawing.Point(544, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 28)
        Me.btnMinimize.TabIndex = 17
        Me.btnMinimize.TabStop = False
        Me.btnMinimize.Text = "_"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnClose.Location = New System.Drawing.Point(578, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(28, 28)
        Me.btnClose.TabIndex = 18
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'MyProgressBar
        '
        Me.MyProgressBar.Location = New System.Drawing.Point(15, 316)
        Me.MyProgressBar.Maximum = 0
        Me.MyProgressBar.Name = "MyProgressBar"
        Me.MyProgressBar.Size = New System.Drawing.Size(451, 37)
        Me.MyProgressBar.TabIndex = 19
        '
        'UpdateTimer
        '
        Me.UpdateTimer.Interval = 500
        '
        'MyWebBrowser
        '
        Me.MyWebBrowser.Location = New System.Drawing.Point(17, 49)
        Me.MyWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.MyWebBrowser.Name = "MyWebBrowser"
        Me.MyWebBrowser.ScriptErrorsSuppressed = True
        Me.MyWebBrowser.ScrollBarsEnabled = False
        Me.MyWebBrowser.Size = New System.Drawing.Size(587, 240)
        Me.MyWebBrowser.TabIndex = 20
        Me.MyWebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        Me.MyWebBrowser.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.BackgroundImage = Global.AutoUpdater.My.Resources.Resources.background_full
        Me.ClientSize = New System.Drawing.Size(620, 419)
        Me.Controls.Add(Me.MyWebBrowser)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.MyProgressBar)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnStart)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdater"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFileName As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents MyProgressBar As ProgressBar
    Friend WithEvents UpdateTimer As Timer
    Friend WithEvents MyWebBrowser As WebBrowser
End Class
