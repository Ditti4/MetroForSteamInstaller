﻿Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.Text

Public Class mainwindow

    Dim currentversion As String
    Dim newversion As String
    Dim dlurl As String
    Dim installpath As String
    Dim filestring As String
    Dim first As Integer
    Dim length As Integer
    Dim cookies As New CookieContainer

    Private Sub mainwindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        'Load the Steam install path from the registry
        '
        If Environment.Is64BitOperatingSystem Then
            installpath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", Nothing)
        Else
            installpath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        End If

        If String.IsNullOrEmpty(installpath) Then
            MessageBox.Show("Looks like Steam is not installed. This installer is useless for you then.", "Oops!", MessageBoxButtons.OK)
        End If
        '
        'Get the currently installed Metro for Steam version from resource\menus\steam.menu
        '
        If File.Exists(installpath + "\skins\Metro for Steam\resource\menus\steam.menu") Then
            filestring = File.ReadAllText(installpath + "\skins\Metro for Steam\resource\menus\steam.menu")
            first = filestring.IndexOf("Steam - ") + 8
            length = filestring.IndexOf("""", first) - first
            currentversion = filestring.Substring(first, length)
        Else
            currentversion = "Not installed (yet?)"
            '
            'Make sure the custom.styles file gets copied if the skin isn't installed yet
            '
            overwritecheckbox.Checked = True
        End If
        currentversionlabel.Text = currentversion

        Try
            '
            'Get Metro for Steam deviantart page
            '
            Dim req As HttpWebRequest = WebRequest.Create("http://boneyardbrew.deviantart.com/art/MfS-292419787")
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36"
            req.CookieContainer = cookies
            Dim resp As HttpWebResponse = req.GetResponse
            Dim stream = resp.GetResponseStream
            Dim reader = New System.IO.StreamReader(stream)
            filestring = reader.ReadToEnd
            stream.Close()
            reader.Close()
            '
            'Get newversion from deviantart
            '
            first = filestring.IndexOf("Metro for Steam - ") + 18
            length = filestring.IndexOf(" by Bone", first) - first
            newversion = filestring.Substring(first, length)
            newversionlabel.Text = newversion
            '
            'Get download link from deviantart
            '
            first = filestring.IndexOf("http://www.deviantart.com/download/")
            length = filestring.IndexOf("""", first) - first
            dlurl = filestring.Substring(first, length).Replace("&amp;", "&")
            '
            'Get cookies from previous response
            '
            cookies.Add(resp.Cookies)
        Catch exc As WebException
            MessageBox.Show(exc.Message + exc.ToString, "Oops!", MessageBoxButtons.OK)
        End Try
        '
        'Compare currentversion and newversion, give advice afterwards
        '
        If newversion.Equals(currentversion) Then
            updatenotice.Text = "All good, you alreday have the newest version."
            updatenotice.ForeColor = System.Drawing.Color.FromArgb(130, 186, 0)
        Else
            updatenotice.Text = "Newer version available, you should update."
            updatenotice.ForeColor = System.Drawing.Color.FromArgb(93, 178, 255)
        End If

    End Sub

    Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        Try
            '
            'Status update so the user knows the app didn't crash
            '
            updatenotice.Text = "Working..."
            updatenotice.ForeColor = System.Drawing.Color.FromArgb(93, 178, 255)
            '
            'Let's form the request for the zip download, get the file and save it to the disk
            '
            Dim req As HttpWebRequest = HttpWebRequest.Create(dlurl)
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36"
            req.Referer = "http://boneyardbrew.deviantart.com/art/MfS-292419787"
            req.CookieContainer = cookies
            Dim stream = req.GetResponse.GetResponseStream
            Dim filestream = File.Create("mfs.zip")
            stream.CopyTo(filestream)
            filestream.Close()
            stream.Close()
            '
            'Next: unzipping
            '

        Catch exc As WebException
            MessageBox.Show(exc.Message + exc.ToString, "Oops!", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
