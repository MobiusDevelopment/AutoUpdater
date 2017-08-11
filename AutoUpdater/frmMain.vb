Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Public Class frmMain
    Dim gameServerIP = "127.0.0.1"
    Dim baseURL As String = "http://127.0.0.1/updater/" 'Where the files are saved
    Dim versionFileURL As String = baseURL + "version.txt"
    Dim fileListURL As String = baseURL + "filelist.txt"
    Dim downloadFolderName As String = "$Patch$"
    Dim pakFolderName As String = "zips"
    Dim pakExtension As String = ".zip"
    Dim enableBrowser As Boolean = True
    Dim enableBrowserScrollbars As Boolean = False
    Dim browserURL As String = "http://127.0.0.1/news/"
    Dim launcherLocalVersion As Integer = 0
    Dim launcherWebVersion As Integer = 0
    Dim myStartupPath As String
    Dim myFileName As String
    Dim progressBarCounter As Integer
    Dim progressBarCounterMax As Integer
    Dim progressText As String
    Dim updating = False
    'For debugging
    Dim disableSelfUpdates As Boolean = False

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set transparent form background
        Me.TransparencyKey = Me.BackColor

        'Get application startup path
        Dim myPath As String = Application.StartupPath
        myStartupPath = myPath + "\"
        myFileName = Path.GetFileName(Application.ExecutablePath)

        'Self-update check
        If myFileName.EndsWith("_") Then
            Threading.Thread.Sleep(2000) 'Try to delay 2 seconds
            Dim parentPath As String = Mid(myPath, 1, myPath.LastIndexOf("\"))
            Dim parentPathFileName As String = Mid(myFileName, 1, myFileName.Length - 1)
            File.Copy(myStartupPath + myFileName, parentPath + "\" + parentPathFileName, True)
            Shell(parentPath + "\" + parentPathFileName, vbNormalFocus)
            End
        End If

        'Check if we have access over http
        If enableBrowser And checkAddress(browserURL) Then
            MyWebBrowser.ScrollBarsEnabled = enableBrowserScrollbars
            MyWebBrowser.Visible = True
            MyWebBrowser.Navigate(New Uri(browserURL))
        End If
        If Not checkAddress(versionFileURL) Then
            btnCheck.Enabled = False
            Exit Sub 'offline mode
        End If

        'Get launcher local version
        If File.Exists("version.ini") Then
            Using fileReader As StreamReader = New StreamReader("version.ini")
                launcherLocalVersion = Integer.Parse(fileReader.ReadLine)
            End Using
        End If

        'Get launcher web version
        Dim client As WebClient = New WebClient()
        Dim webReader As StreamReader = New StreamReader(client.OpenRead(versionFileURL))
        Dim iVersion As String = webReader.ReadLine
        If iVersion.Length > 0 Then
            launcherWebVersion = Integer.Parse(iVersion)
        End If
        webReader.Close()

        'Update if necessary
        If (launcherLocalVersion < launcherWebVersion) Then
            'Disable buttons
            btnStart.Enabled = False
            btnCheck.Enabled = False
            lblFileName.Text = ""
            UpdateTimer.Enabled = True
            Call New Action(AddressOf updateFromWeb).BeginInvoke(Nothing, Me)
        End If
    End Sub

    Private Function checkAddress(ByVal URL As String) As Boolean
        Dim req As WebRequest
        req = WebRequest.Create(URL)
        Dim resp As WebResponse
        Try
            resp = req.GetResponse()
            resp.Close()
            req = Nothing
            Return True
        Catch ex As Exception
            req = Nothing
            Return False
        End Try
    End Function

    Private Sub updateFromWeb()
        updating = True

        'Get info from web
        Dim myFileList As New List(Of String)
        Dim client As WebClient = New WebClient()
        Dim webReader As StreamReader = New StreamReader(client.OpenRead(fileListURL))
        While (webReader.Peek() <> -1)
            myFileList.Add(webReader.ReadLine())
        End While
        webReader.Close()

        'Initialize progrss bar
        'Set the progressbar maximum
        progressBarInit(myFileList.Count)

        'Check if download folder exists
        If (Directory.Exists(myStartupPath + downloadFolderName)) Then
            Directory.Delete(myStartupPath + downloadFolderName, True)
        End If
        Directory.CreateDirectory(myStartupPath + downloadFolderName)

        'Update files
        Dim fileHash As String
        Dim fileName As String
        For Each fileInfo In myFileList
            'Split info
            fileHash = fileInfo.Split(vbTab)(0)
            fileName = Regex.Replace(fileInfo.Split(vbTab)(1), "[^\u0020-\u007E]+", String.Empty) 'Use regex to remove non ASCII characters

            'Check for self update
            If fileName.ToLower.Equals(myFileName.ToLower) Then
                If disableSelfUpdates = False And (Not getFileHash(myStartupPath + fileName).Equals(fileHash)) Then
                    myFileName = fileName 'in case of case sensitivity
                    startSelfUpdate()
                    Exit Sub
                End If
                Continue For
            End If

            'Update progress bar
            'Threading.Thread.Sleep(100)
            progressBarInc()
            progressText = "Checking: " + fileName

            'Check if file exists
            If (File.Exists(myStartupPath + fileName)) Then
                'No need to update if hash is correct
                If getFileHash(myStartupPath + fileName).Equals(fileHash) Then
                    Continue For
                End If
            End If

            'Check if file exists
            Dim downloadedFileName As String
            If fileName.Contains("\") Then
                downloadedFileName = myStartupPath + downloadFolderName + "\" + Mid(fileName, fileName.LastIndexOf("\") + 1, fileName.Length) + ".tmp"
            Else
                downloadedFileName = myStartupPath + downloadFolderName + "\" + fileName + ".tmp"
            End If
            Dim webResponse As HttpWebResponse
            Dim webRequest As HttpWebRequest
            Try 'Check if the file exists
                webRequest = Net.WebRequest.Create(baseURL + pakFolderName + "/" + fileName.Replace("\", "/") + pakExtension)
                webResponse = webRequest.GetResponse
            Catch ex As Exception
                'could not be found on the server (network delay maybe)
                Continue For
            End Try

            'Change label to downloading
            'Threading.Thread.Sleep(100)
            progressText = "Downloading: " + fileName

            'Download the zip file
            Dim writeStream As New FileStream(downloadedFileName, FileMode.Create)
            Dim nRead As Integer
            Do
                Dim readBytes(4095) As Byte
                Dim bytesread As Integer = webResponse.GetResponseStream.Read(readBytes, 0, 4096)
                nRead += bytesread
                If bytesread = 0 Then Exit Do
                writeStream.Write(readBytes, 0, bytesread)
            Loop
            webResponse.GetResponseStream.Close()
            writeStream.Close()

            'Extract the file
            If fileName.Contains("\") Then
                Dim fileFolderPath As String = myStartupPath + Mid(fileName, 1, fileName.LastIndexOf("\"))
                If (Not Directory.Exists(fileFolderPath)) Then
                    Directory.CreateDirectory(fileFolderPath)
                End If
            End If
            'Delete older file
            Dim fileExists As Boolean = False 'used this boolean because File.Exists may lock the file
            If File.Exists(myStartupPath + fileName) Then
                fileExists = True
            End If
            If fileExists Then
                File.Delete(myStartupPath + fileName)
            End If

            ZipFile.ExtractToDirectory(downloadedFileName, myStartupPath)

            'Delete the downloaded file
            File.Delete(downloadedFileName)
        Next

        'Remove download folder
        Directory.Delete(myStartupPath + downloadFolderName, True)

        'Update version.ini
        Using outputFile As StreamWriter = New StreamWriter(myStartupPath + "version.ini", False, System.Text.Encoding.Unicode)
            outputFile.Write(launcherWebVersion.ToString)
            outputFile.Close()
        End Using

        'Finish message
        'Threading.Thread.Sleep(100)
        progressText = "Your files are up to date."

        updating = False
    End Sub

    Private Sub startSelfUpdate()
        'Download the zip file
        Dim downloadedFileName = myStartupPath + downloadFolderName + "\" + myFileName + ".tmp"
        Dim webResponse As HttpWebResponse
        Dim webRequest As HttpWebRequest
        Try 'Check if the file exists
            webRequest = Net.WebRequest.Create(baseURL + pakFolderName + "/" + myFileName + pakExtension)
            webResponse = webRequest.GetResponse
        Catch ex As Exception
            'could not be found on the server (network delay maybe)
            Exit Sub
        End Try
        Dim writeStream As New FileStream(downloadedFileName, FileMode.Create)
        Dim nRead As Integer
        Do
            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = webResponse.GetResponseStream.Read(readBytes, 0, 4096)
            nRead += bytesread
            If bytesread = 0 Then Exit Do
            writeStream.Write(readBytes, 0, bytesread)
        Loop
        webResponse.GetResponseStream.Close()
        writeStream.Close()

        'Extract the file
        ZipFile.ExtractToDirectory(downloadedFileName, myStartupPath + downloadFolderName)

        'Rename the new launcher
        My.Computer.FileSystem.RenameFile(myStartupPath + downloadFolderName + "\" + myFileName, myFileName + "_")
        'Run the new launcher
        Shell(downloadFolderName + "\" + myFileName + "_", vbMinimizedNoFocus)
        'Close this launcher
        End
    End Sub

    Private Function getFileHash(ByVal fileName As String)
        Dim hash = SHA256.Create() 'Initializes a SHA-256 hash object
        Dim hashValue() As Byte

        'Read the file
        Dim fileStream As FileStream = File.OpenRead(fileName)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        fileStream.Close()

        'The array of bytes is converted into hexadecimal string
        Dim hashHex As String = ""
        Dim counter As Integer
        For counter = 0 To hashValue.Length - 1
            hashHex += hashValue(counter).ToString("X2") 'Convert each byte in hexadecimal
        Next counter

        'Hash is returned in lowercase
        Return hashHex.ToLower
    End Function

    'Make form dragable
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        'If updating Then Exit Sub
        If e.Button = MouseButtons.Left Then
            drag = True
            mouseX = Cursor.Position.X - Me.Left
            mouseY = Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    'Progress bar subs
    Private Sub progressBarInit(count As Integer)
        progressBarCounter = 0
        progressBarCounterMax = count
    End Sub

    Private Sub progressBarInc()
        progressBarCounter = progressBarCounter + 1
    End Sub

    'Minimize from taskbar click
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim CP As CreateParams = MyBase.CreateParams
            CP.Style = &HA0000
            Return CP
        End Get
    End Property

    'Button "Start"
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If updating Then Exit Sub
        Try
            Shell("system\l2.bin IP=" + gameServerIP, vbNormalFocus)
        Catch ex As Exception
            MsgBox("L2.bin not found! Try checking your files.", MsgBoxStyle.Critical, "Auto Updater")
            Exit Sub
        End Try
        End
    End Sub

    'Button "Check Files"
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If updating Then Exit Sub

        'Connectivity check
        If checkAddress(versionFileURL) Then
            'Disable buttons
            btnStart.Enabled = False
            btnCheck.Enabled = False
            lblFileName.Text = ""
            UpdateTimer.Enabled = True
            Call New Action(AddressOf updateFromWeb).BeginInvoke(Nothing, Me)
        Else
            MsgBox("Cannot reach the server!", MsgBoxStyle.Critical, "Auto Updater")
        End If
    End Sub

    'On unexpected form close
    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    'Button "X" - Close
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If updating Then
            Dim result As Integer = MessageBox.Show("Exit while updating?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            End If
        End If
        End
    End Sub

    'Button "_" - Minimize
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub UpdateTimer_Tick(sender As Object, e As EventArgs) Handles UpdateTimer.Tick
        If progressBarCounterMax > 0 Then
            MyProgressBar.Maximum = progressBarCounterMax
        End If
        If MyProgressBar.Maximum > 0 Then
            MyProgressBar.Value = progressBarCounter
        End If

        'update info text
        lblFileName.Text = progressText

        're-enable buttons check
        If Not updating Then
            btnCheck.Enabled = True
            btnStart.Enabled = True
        End If
    End Sub
End Class
