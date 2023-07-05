Imports Microsoft.Web.WebView2.Core

Public Class VTuberMain
#Region "Load Settings"
    Private Sub VTuberMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

        'Background settings.
        If My.Settings.DHBHUC = 0 Then
            HubBackground.Image = My.Resources.WLPBackground
        End If

        If My.Settings.DHBHUC = 1 Then
            HubBackground.Image = Nothing
        End If

        If My.Settings.DHBHUC = 2 Then
            HubBackground.Load(My.Settings.CB1)
        End If

        'Load colour settings.
        ToolStrip1.BackColor = Color.FromArgb(200, Color.White)

        If My.Settings.CCE = 1 Then
            Panel1.BackColor = My.Settings.CustomColour
        End If

        'Load update settings.
        Variables.Update_Settings()

        'Load start-up settings.
        If My.Settings.Startup = 0 Then

        End If

        If My.Settings.Startup = 1 Then
            WindowState = FormWindowState.Minimized
            Me.Visible = False
            SysTrayIcon.Visible = True
            SysTrayIcon.ShowBalloonTip(1, "VTubers.me Web App - Notification", "VTubers.me Web App is now running in the background.", ToolTipIcon.Info)
        End If

        If My.Settings.Startup = 2 Then
            SettingsPanel.Show()
        End If

        'Load parent settings.
        ToolStrip1.Parent = HubBackground
        WebView21.Parent = HubBackground

    End Sub
#End Region
#Region "Tool Bar"
    Private Sub Back_TSB_Click(sender As Object, e As EventArgs) Handles Back_TSB.Click
        If WebView21.CanGoBack() Then
            WebView21.GoBack()
        End If
    End Sub

    Private Sub Forward_TSB_Click(sender As Object, e As EventArgs) Handles Forward_TSB.Click
        If WebView21.CanGoForward() Then
            WebView21.GoForward()
        End If
    End Sub

    Private Sub Refresh_TSB_Click(sender As Object, e As EventArgs) Handles Refresh_TSB.Click
        WebView21.Reload()
    End Sub

    Private Sub Home_TSB_Click(sender As Object, e As EventArgs) Handles Home_TSB.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/home")
    End Sub

    Private Sub Notification_TSB_Click(sender As Object, e As EventArgs) Handles Notification_TSB.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/notifications")
    End Sub

    Private Sub Messages_TSB_Click(sender As Object, e As EventArgs) Handles Messages_TSB.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/chats")
    End Sub

    Private Sub ExploreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExploreToolStripMenuItem.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/search")
    End Sub

    Private Sub Lists_TSM_Click(sender As Object, e As EventArgs) Handles Lists_TSM.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/trending")
    End Sub

    Private Sub Mentions_TSM_Click(sender As Object, e As EventArgs) Handles Mentions_TSM.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/mentions")
    End Sub

    Private Sub About_TSM_Click(sender As Object, e As EventArgs) Handles About_TSM.Click
        VTuberAbout.ShowDialog()
    End Sub

    Private Sub TwitterSettings_TSM_Click(sender As Object, e As EventArgs) Handles TwitterSettings_TSM.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/settings")
    End Sub

    Private Sub AboutTwitterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutTwitterToolStripMenuItem1.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/about_us")
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem1.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/logout")
    End Sub

    Private Sub SendFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendFeedbackToolStripMenuItem.Click
        VTuberFeedback.ShowDialog()
    End Sub

    Private Sub Exit_TSM_Click(sender As Object, e As EventArgs) Handles Exit_TSM.Click
        End
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newwindow As New VTuberMain
        newwindow.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Me.Text = WebView21.CoreWebView2.DocumentTitle & " - VTubers.me"
        Catch
        End Try

        Try
            If Me.Text.Contains("1" Or "2" Or "3" Or "4" Or "5" Or "6" Or "7" Or "8" Or "9" Or "10") Then
                Me.Icon = My.Resources.vtubers_notif
                Me.SysTrayIcon.Icon = My.Resources.vtubers_notif
            ElseIf WebView21.CoreWebView2.Source = "https://vtubers.me/notifications" Then
                Me.Icon = My.Resources.vtubers
                Me.SysTrayIcon.Icon = My.Resources.vtubers
            End If
        Catch
        End Try

        Try
            If WebView21.CoreWebView2.DocumentTitle.Length > 25 Then
                Dim source As String = WebView21.CoreWebView2.DocumentTitle
                Dim cutdown As String = source.Substring(0, 25)
                SysTrayIcon.Text = "VTubers.me - " & cutdown & "..."
            Else
                Dim source As String = WebView21.CoreWebView2.DocumentTitle
                SysTrayIcon.Text = "VTubers.me - " & source
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "System Tray Icon"
    Private Sub SysTrayIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SysTrayIcon.MouseDoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VTuberMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If My.Settings.SysTrayMinimise = 1 Then
            If WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                SysTrayIcon.Visible = True
                SysTrayIcon.ShowBalloonTip(1, "VTubers.me Web App - Notification", "VTubers.me Web App is now running in the background.", ToolTipIcon.Info)
                GC.Collect()
            End If
        ElseIf My.Settings.SysTrayMinimise = 0 Then
            GC.Collect()
        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Restore_TMO.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            SysTrayIcon.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Exit_TMO.Click
        Me.Close()
    End Sub

    Private Sub TweetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TweetToolStripMenuItem.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/post")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Text.Contains("1") Then
            Me.Icon = My.Resources.vtubers_notif
            Me.SysTrayIcon.Icon = My.Resources.vtubers_notif
            SysTrayIcon.ShowBalloonTip(1, "VTubers.me Web App - Notification", "You have unread notifications.", ToolTipIcon.Info)
        ElseIf WebView21.CoreWebView2.Source.ToString = "https://vtubers.me/notifications" Then
            Me.Icon = My.Resources.vtubers
            Me.SysTrayIcon.Icon = My.Resources.vtubers
        End If
    End Sub

    Private Sub WhatsNew_TSM_Click(sender As Object, e As EventArgs) Handles WhatsNew_TSM.Click
        VTuberWhatsNew.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        VTuberWidget.Show()
    End Sub

    Private Sub SettingsPanel_TSM_Click(sender As Object, e As EventArgs) Handles SettingsPanel_TSM.Click
        SettingsPanel.Show()
    End Sub

    Private Sub Profile_TSM_Click(sender As Object, e As EventArgs) Handles Profile_TSM.Click
        If My.Settings.OCA = 0 Then
            VTuberProfile.ShowDialog()
        Else
            WebView21.CoreWebView2.Navigate("https://vtubers.me/" & My.Settings.ProfileName)
        End If
    End Sub

    Private Sub GoToUser_TSM_Click(sender As Object, e As EventArgs) Handles GoToUser_TSM.Click
        VTuberGTU.ShowDialog()
    End Sub
#End Region
End Class
