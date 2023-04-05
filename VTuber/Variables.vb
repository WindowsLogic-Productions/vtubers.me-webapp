Public Class Variables
#Region "Shared Variables"
    Public Shared ver As String = My.Application.Info.Version.ToString & " (April 2023)"
    Public Shared user As String = System.Windows.Forms.SystemInformation.UserName
    Public Shared appname As String = "Tweeter"
    Public Shared vertext As String = "http://u.windowslogic.co.uk/Updates/VTUBER/VTUBER.txt"
    Public Shared setup As String = "http://u.windowslogic.co.uk/Updates/VTUBER/VTuber%20Setup.exe"

    Public Shared Sub ParseVariables(input As Label)
        input.Text = input.Text.Replace("%ver%", Variables.ver).Replace("%user%", Variables.user).Replace("%appname%", Variables.appname)
    End Sub
#End Region
#Region "Updater"
    Public Shared Sub Update_Settings()
        If My.Settings.Updates = 0 Then
            Try
                Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(vertext)
                Dim response As System.Net.HttpWebResponse = request.GetResponse()
                Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
                Dim newestversion As String = sr.ReadToEnd()
                Dim currentversion As String = Application.ProductVersion
                If newestversion.Contains(currentversion) Then

                Else
                    UpdaterPrompt.ShowDialog()
                End If

            Catch
                MsgBox("There is no connection to the update server.", MsgBoxStyle.Critical, "Error")
            End Try
        End If

        If My.Settings.Updates = 1 Then

        End If
    End Sub
#End Region
End Class
