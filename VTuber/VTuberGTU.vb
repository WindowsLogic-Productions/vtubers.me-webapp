Public Class VTuberGTU
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            MsgBox("No username has been entered.", MsgBoxStyle.Critical, "Error")
        Else
            VTuberMain.WebView21.CoreWebView2.Navigate("https://vtubers.me/" & TextBox1.Text)
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub VTuberGTU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class