Public Class VTuberWidget
    Private Sub VTuberWidget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebView21.Source = New Uri(SettingsPanelGeneral.WidgetText.Text)

        If SettingsPanelGeneral.AutoBox.Checked = True Then
            timer1.start()
        Else

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        WebView21.Reload()
    End Sub
End Class