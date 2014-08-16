Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net

Public Class mainwindow

    Dim currentversion As String
    Dim newversion As String
    Dim dlurl As String
    Dim installpath As String
    Dim filestring As String
    Dim first As Integer
    Dim length As Integer

    Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        updatenotice.Text = "Wurkz"
    End Sub

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
        End If
        currentversionlabel.Text = currentversion

        Try
            Dim req As HttpWebRequest = WebRequest.Create("http://boneyardbrew.deviantart.com/art/MfS-292419787")
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2049.0 Safari/537.36"
            Dim stream = req.GetResponse.GetResponseStream
            Dim reader = New System.IO.StreamReader(stream)
            filestring = reader.ReadToEnd
            stream.Close()
            reader.Close()
            first = filestring.IndexOf("Metro for Steam - ") + 18
            length = filestring.IndexOf(" by Bone", first) - first
            newversion = filestring.Substring(first, length)
            newversionlabel.Text = newversion
        Catch exc As WebException
            MessageBox.Show(exc.Message + exc.ToString, "Oops!", MessageBoxButtons.OK)
        End Try
    End Sub
End Class
