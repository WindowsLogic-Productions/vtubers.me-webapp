Imports Microsoft.Web.WebView2

Public Class VTuberMain
#Region "Load Settings"
    Private Sub VTuberMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.Update_Settings()
    End Sub
#End Region
    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        WebView21.GoBack()
    End Sub

    Private Sub ForwardButton_Click(sender As Object, e As EventArgs)
        WebView21.GoForward()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs)
        WebView21.Reload()
    End Sub


End Class
