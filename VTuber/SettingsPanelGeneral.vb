Public Class SettingsPanelGeneral
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub

    Private Sub SettingsPanelGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

        'Load System Tray Minimise settings.
        If My.Settings.SysTrayMinimise = 0 Then
            SysTrayMinimiseBox.Checked = False
        Else
            SysTrayMinimiseBox.Checked = True
        End If

        'Load Full Screen settings.
        If My.Settings.Fullscreen = 0 Then
            FullScreenBox.Checked = False
        Else
            FullScreenBox.Checked = True
        End If

        'Load Startup settings.
        If My.Settings.Startup = 0 Then
            NothingButton.Checked = True
        End If

        If My.Settings.Startup = 1 Then
            SystemTrayButton.Checked = True
        End If

        If My.Settings.Startup = 2 Then
            SettingsPanelButton.Checked = True
        End If

        'Load profile settings.
        If My.Settings.OCA = 0 Then
            GPText.Text = "No Profile Username Set"
        Else
            GPText.Text = My.Settings.ProfileName
            GPSetButton.Enabled = False
        End If

        'Load System Tray Minimising settings.
        If My.Settings.SysTrayMinimise = 0 Then
            SysTrayMinimiseBox.Checked = True
        End If

        If My.Settings.SysTrayMinimise = 1 Then
            SysTrayMinimiseBox.Checked = False
        End If
    End Sub
#Region "VTubers.me"
    Private Sub SysTrayMinimiseBox_CheckedChanged(sender As Object, e As EventArgs) Handles SysTrayMinimiseBox.CheckedChanged
        If SysTrayMinimiseBox.Checked = False Then
            My.Settings.SysTrayMinimise = 0
        End If

        If SysTrayMinimiseBox.Checked = True Then
            My.Settings.SysTrayMinimise = 1
        End If
    End Sub

    Private Sub FullScreenBox_CheckedChanged(sender As Object, e As EventArgs) Handles FullScreenBox.CheckedChanged
        If FullScreenBox.Checked = False Then
            My.Settings.Fullscreen = 0
            VTuberMain.WindowState = FormWindowState.Normal
            VTuberMain.FormBorderStyle = FormBorderStyle.Sizable
        End If

        If FullScreenBox.Checked = True Then
            My.Settings.Fullscreen = 1
            VTuberMain.FormBorderStyle = FormBorderStyle.None
            VTuberMain.WindowState = FormWindowState.Maximized
        End If
    End Sub
#End Region
#Region "Start-Up"
    Private Sub NothingButton_CheckedChanged(sender As Object, e As EventArgs) Handles NothingButton.CheckedChanged
        If NothingButton.Checked = True Then
            My.Settings.Startup = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub SystemTrayButton_CheckedChanged(sender As Object, e As EventArgs) Handles SystemTrayButton.CheckedChanged
        If SystemTrayButton.Checked = True Then
            My.Settings.Startup = 1
            My.Settings.Save()
        End If
    End Sub

    Private Sub SettingsPanelButton_CheckedChanged(sender As Object, e As EventArgs) Handles SettingsPanelButton.CheckedChanged
        If SettingsPanelButton.Checked = True Then
            My.Settings.Startup = 2
            My.Settings.Save()
        End If
    End Sub
#End Region
#Region "Profile"
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles GPText.TextChanged
        GPSetButton.Enabled = True
    End Sub

    Private Sub GPSetButton_Click(sender As Object, e As EventArgs) Handles GPSetButton.Click
        If GPText.Text = Nothing Then
            MsgBox("No VTubers.me profile username has been entered.", MsgBoxStyle.Critical, "Error")
        Else
            My.Settings.ProfileName = GPText.Text()
            My.Settings.OCA = 1
            My.Settings.Save()
            GPSetButton.Enabled = False
            GPSetLabel.Visible = True
            VTuberMain.Profile_TSM.Enabled = True
        End If

    End Sub


#End Region
#Region "OBS Widget"
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.WidgetText.Text = "https://vtubers.me/search/posts?q=ENVtuber"
    End Sub

    Private Sub WidgetButton_Click(sender As Object, e As EventArgs) Handles WidgetButton.Click
        VTuberWidget.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.WidgetText.Text = "https://vtubers.me/search/posts?q=vTuber"
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.WidgetText.Text = "https://vtubers.me/search/posts?q=PNGtuber"
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Me.WidgetText.Text = "https://vtubers.me/search/posts?q=VtuberSupport"
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.WidgetText.Text = "https://vtubers.me/search/posts?q=VtuberUprising"
    End Sub
#End Region
End Class