Public Class SettingsPanelUpdates
#Region "Load Settings"
    Private Sub SettingsPanelUpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load update settings.
        If My.Settings.Updates = 1 Then
            EnableUpdates.Checked = True
            UpdateStatus.Image = My.Resources.GoodGradient
        End If

        If My.Settings.Updates = 0 Then
            DisableUpdates.Checked = True
            UpdateStatus.Image = My.Resources.BadGradient
        End If
    End Sub
#End Region
#Region "Update Settings"
    Private Sub EnableUpdates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableUpdates.CheckedChanged
        If EnableUpdates.Checked = True Then
            UpdateStatus.Image = My.Resources.GoodGradient
            My.Settings.Updates = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub DisableUpdates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableUpdates.CheckedChanged
        If DisableUpdates.Checked = True Then
            UpdateStatus.Image = My.Resources.BadGradient
            My.Settings.Updates = 0
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub ManualUpdateButton_Click(sender As Object, e As EventArgs) Handles ManualUpdateButton.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(Variables.vertext)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox("You're on the latest version.", MsgBoxStyle.Information, "Information")
        Else
            'UpdaterPrompt.PostponeButton.Text = "Cancel"
            'UpdaterPrompt.ShowDialog()
            Me.Close()
        End If
    End Sub
#End Region
End Class