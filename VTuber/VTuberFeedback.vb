Imports Microsoft.Web.WebView2.Core

Public Class VTuberFeedback
    Private Sub VTuberFeedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted
        Dim opts As New CoreWebView2EnvironmentOptions With {.AdditionalBrowserArguments = "--enable-features=msWebViewBrowserHitTransparent"}
        CoreWebView2Environment.CreateAsync(Nothing, Nothing, opts)
    End Sub
End Class