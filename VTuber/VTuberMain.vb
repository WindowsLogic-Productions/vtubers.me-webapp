Public Class VTuberMain
#Region "Load Settings"
    Private Sub VTuberMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.Update_Settings()
    End Sub

    Private Sub Back_TSB_Click(sender As Object, e As EventArgs) Handles Back_TSB.Click
        WebView21.GoBack()
    End Sub

    Private Sub Forward_TSB_Click(sender As Object, e As EventArgs) Handles Forward_TSB.Click
        WebView21.GoForward()
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
        WebView21.CoreWebView2.Navigate("https://vtubers.me/notifications")
    End Sub

    Private Sub ExploreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExploreToolStripMenuItem.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/explore")
    End Sub

    Private Sub Lists_TSM_Click(sender As Object, e As EventArgs) Handles Lists_TSM.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/trending")
    End Sub

    Private Sub Mentions_TSM_Click(sender As Object, e As EventArgs) Handles Mentions_TSM.Click
        WebView21.CoreWebView2.Navigate("https://vtubers.me/mentions")
    End Sub

    Private Sub About_TSM_Click(sender As Object, e As EventArgs) Handles About_TSM.Click
        MsgBox("VTubers.me Web App " & My.Application.Info.Version.ToString & vbNewLine & My.Application.Info.Copyright)
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
        Process.Start("https://windowslogic.co.uk/feedback.php")
    End Sub

    Private Sub Exit_TSM_Click(sender As Object, e As EventArgs) Handles Exit_TSM.Click
        End
    End Sub
#End Region
#Region "Tool Bar"

#End Region


End Class
