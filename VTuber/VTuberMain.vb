Imports Microsoft.Web.WebView2.Core

Public Class VTuberMain
#Region "Load Settings"
    Private Sub VTuberMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.Update_Settings()


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
        Me.Text = WebView21.CoreWebView2.DocumentTitle & " - VTubers.me"
        Try
            If WebView21.CoreWebView2.DocumentTitle.Length > 25 Then
                Dim source As String = WebView21.CoreWebView2.DocumentTitle
                Dim cutdown As String = source.Substring(0, 25)
                'SysTrayIcon.Text = "Tweeter - " & cutdown & "..."
            Else
                Dim source As String = WebView21.CoreWebView2.DocumentTitle
                'SysTrayIcon.Text = "Tweeter - " & source
            End If
        Catch ex As Exception
            MsgBox("Could not update system tray icon text.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

#End Region


End Class
