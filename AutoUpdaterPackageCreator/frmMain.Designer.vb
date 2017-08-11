<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblSource = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtSource = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnSourceSelect = New System.Windows.Forms.Button()
        Me.btnOutputSelect = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.MyProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblSource
        '
        Me.lblSource.AutoSize = True
        Me.lblSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblSource.Location = New System.Drawing.Point(12, 22)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(80, 25)
        Me.lblSource.TabIndex = 0
        Me.lblSource.Text = "Source"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 59)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(76, 25)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'txtSource
        '
        Me.txtSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtSource.Location = New System.Drawing.Point(103, 20)
        Me.txtSource.Name = "txtSource"
        Me.txtSource.Size = New System.Drawing.Size(462, 29)
        Me.txtSource.TabIndex = 1
        '
        'txtOutput
        '
        Me.txtOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(103, 57)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(462, 29)
        Me.txtOutput.TabIndex = 3
        '
        'btnSourceSelect
        '
        Me.btnSourceSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnSourceSelect.Location = New System.Drawing.Point(571, 19)
        Me.btnSourceSelect.Name = "btnSourceSelect"
        Me.btnSourceSelect.Size = New System.Drawing.Size(101, 31)
        Me.btnSourceSelect.TabIndex = 2
        Me.btnSourceSelect.Text = "Select"
        Me.btnSourceSelect.UseVisualStyleBackColor = True
        '
        'btnOutputSelect
        '
        Me.btnOutputSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnOutputSelect.Location = New System.Drawing.Point(571, 56)
        Me.btnOutputSelect.Name = "btnOutputSelect"
        Me.btnOutputSelect.Size = New System.Drawing.Size(101, 31)
        Me.btnOutputSelect.TabIndex = 4
        Me.btnOutputSelect.Text = "Select"
        Me.btnOutputSelect.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(517, 147)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(155, 62)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtVersion
        '
        Me.txtVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.txtVersion.Location = New System.Drawing.Point(103, 103)
        Me.txtVersion.MaxLength = 10
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(58, 29)
        Me.txtVersion.TabIndex = 5
        Me.txtVersion.Text = "1"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(12, 105)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(85, 25)
        Me.lblVersion.TabIndex = 7
        Me.lblVersion.Text = "Version"
        '
        'MyProgressBar
        '
        Me.MyProgressBar.Location = New System.Drawing.Point(17, 147)
        Me.MyProgressBar.Name = "MyProgressBar"
        Me.MyProgressBar.Size = New System.Drawing.Size(490, 62)
        Me.MyProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MyProgressBar.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 227)
        Me.Controls.Add(Me.MyProgressBar)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnOutputSelect)
        Me.Controls.Add(Me.btnSourceSelect)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtSource)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblSource)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdater - Package Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSource As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtSource As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnSourceSelect As Button
    Friend WithEvents btnOutputSelect As Button
    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtVersion As TextBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents MyProgressBar As ProgressBar
End Class
