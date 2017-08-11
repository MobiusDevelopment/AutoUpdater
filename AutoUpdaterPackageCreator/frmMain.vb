Imports System.IO
Imports System.IO.Compression
Imports System.Security.Cryptography

Public Class frmMain
    Dim messageTitle As String = "Package Creator"
    Dim pakFolderName As String = "zips"
    Dim pakExtension As String = ".zip"

    Private Sub btnSourceSelect_Click(sender As Object, e As EventArgs) Handles btnSourceSelect.Click
        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = Application.StartupPath
        If DialogResult.OK = dialog.ShowDialog() Then
            'Check if folder is empty
            Dim myDir As DirectoryInfo = New DirectoryInfo(dialog.SelectedPath)
            If Not myDir.EnumerateFiles().Any() And Not myDir.EnumerateDirectories().Any() Then
                MsgBox("Folder is empty!", MsgBoxStyle.Information, messageTitle)
                Exit Sub
            End If
            txtSource.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub btnOutputSelect_Click(sender As Object, e As EventArgs) Handles btnOutputSelect.Click
        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = Application.StartupPath
        If DialogResult.OK = dialog.ShowDialog() Then
            'Check if folder is empty
            Dim myDir As DirectoryInfo = New DirectoryInfo(dialog.SelectedPath)
            If myDir.EnumerateFiles().Any() Or myDir.EnumerateDirectories().Any() Then
                MsgBox("Folder is not empty!", MsgBoxStyle.Information, messageTitle)
                Exit Sub
            End If
            txtOutput.Text = dialog.SelectedPath
        End If
    End Sub

    Private Sub txtVersion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVersion.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'backspace
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'numbers
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'Check for empty values
        If txtSource.Text = "" Then
            MsgBox("Source folder is not set!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If
        If txtOutput.Text = "" Then
            MsgBox("Output folder is not set!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If
        If txtVersion.Text = "" Then
            MsgBox("Version is not set!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If

        'Check if folders exist
        If (Not Directory.Exists(txtSource.Text)) Then
            MsgBox("Folder " + txtSource.Text + " not found!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If
        If (Not Directory.Exists(txtOutput.Text)) Then
            MsgBox("Folder " + txtOutput.Text + " not found!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If

        'Check if source folder is empty
        Dim mySourceDir As DirectoryInfo = New DirectoryInfo(txtSource.Text)
        If Not mySourceDir.EnumerateFiles().Any() And Not mySourceDir.EnumerateDirectories().Any() Then
            MsgBox("Source folder is empty!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If
        'Check if output folder is empty
        Dim myOutputDir As DirectoryInfo = New DirectoryInfo(txtOutput.Text)
        If myOutputDir.EnumerateFiles().Any() Or myOutputDir.EnumerateDirectories().Any() Then
            MsgBox("Output folder is not empty!", MsgBoxStyle.Information, messageTitle)
            Exit Sub
        End If

        'Lock controls
        txtSource.TabStop = False
        txtOutput.TabStop = False
        txtVersion.TabStop = False
        txtSource.Enabled = False
        txtOutput.Enabled = False
        txtVersion.Enabled = False
        btnSourceSelect.Enabled = False
        btnOutputSelect.Enabled = False
        btnGenerate.Enabled = False

        Call New Action(AddressOf generatefiles).BeginInvoke(Nothing, Me)
    End Sub

    Private Sub generatefiles()
        'Replace unessasary "\" from end of folder paths
        Dim mySourcePath As String = txtSource.Text
        Dim myOutputPath As String = txtOutput.Text
        If Mid(txtSource.Text, txtSource.Text.Length, 1).Equals("\") Then
            mySourcePath = Mid(txtSource.Text, 1, txtSource.Text.Length - 1)
        End If
        If Mid(txtOutput.Text, txtOutput.Text.Length, 1).Equals("\") Then
            myOutputPath = Mid(txtOutput.Text, 1, txtOutput.Text.Length - 1)
        End If

        'Create version.ini file
        Using outputFile As StreamWriter = New StreamWriter(myOutputPath + "\version.txt", False, System.Text.Encoding.Unicode)
            outputFile.Write(txtVersion.Text)
            outputFile.Close()
        End Using
        'Generate the list of package files
        Dim myFileList As List(Of String) = getFilesRecursive(mySourcePath)

        'Set the progressbar maximum
        MyProgressBar.Maximum = myFileList.Count + 1
        MyProgressBar.Value = 1

        'Create filelist.ini file
        Using outputFile As StreamWriter = New StreamWriter(myOutputPath + "\filelist.txt", False, System.Text.Encoding.Unicode)
            For Each path In myFileList
                outputFile.WriteLine(getFileHash(path) + vbTab + getRelativePath(mySourcePath, path))
            Next
            outputFile.Close()
        End Using

        'Create seperate zip files
        Dim relativePath As String
        Dim outputPath As String
        Dim fileCounter As Integer = 1
        For Each path In myFileList
            'Increase file counter by 1
            fileCounter = fileCounter + 1

            'Check if output path exists
            relativePath = getRelativePath(mySourcePath, path)
            If relativePath.Contains("\") Then
                outputPath = myOutputPath + "\" + pakFolderName + "\" + Mid(relativePath, 1, relativePath.LastIndexOf("\"))
            Else
                outputPath = myOutputPath + "\" + pakFolderName
            End If
            If (Not Directory.Exists(outputPath)) Then
                Directory.CreateDirectory(outputPath)
            End If

            'Create the zip file
            Using zipArchive As ZipArchive = ZipFile.Open(myOutputPath + "\" + pakFolderName + "\" + relativePath + pakExtension, ZipArchiveMode.Create)
                MyProgressBar.Value = fileCounter
                zipArchive.CreateEntryFromFile(path, relativePath)
            End Using
        Next

        'Unlock controls
        txtSource.TabStop = True
        txtOutput.TabStop = True
        txtVersion.TabStop = True
        txtSource.Enabled = True
        txtOutput.Enabled = True
        txtVersion.Enabled = True
        btnSourceSelect.Enabled = True
        btnOutputSelect.Enabled = True
        btnGenerate.Enabled = True

        'Finish message
        MsgBox("Operation has completed!", MsgBoxStyle.Information, messageTitle)
        'Reset progress bar
        MyProgressBar.Value = 0
    End Sub

    Private Function getFilesRecursive(ByVal initial As String) As List(Of String)
        Dim result As New List(Of String) 'This list stores the results
        Dim stack As New Stack(Of String) 'This stack stores the directories to process
        stack.Push(initial) 'Add the initial directory

        'Continue processing for each stacked directory
        Do While (stack.Count > 0)
            Dim dir As String = stack.Pop 'Get top directory string
            Try
                result.AddRange(Directory.GetFiles(dir, "*.*")) 'Add all immediate file paths

                'Loop through all subdirectories and add them to the stack
                Dim directoryName As String
                For Each directoryName In Directory.GetDirectories(dir)
                    stack.Push(directoryName)
                Next
            Catch ex As Exception
                'Empty
            End Try
        Loop

        Return result
    End Function

    Private Function getRelativePath(sourcePath As String, fullPath As String) As String
        sourcePath += "\"
        Return Mid(fullPath, sourcePath.Length + 1, (fullPath.Length - sourcePath.Length) + 1)
    End Function

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
End Class
