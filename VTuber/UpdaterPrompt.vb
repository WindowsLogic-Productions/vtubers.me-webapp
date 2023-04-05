Public Class UpdaterPrompt
    Private Sub UpdaterPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load parent settings.
        PictureBox1.Parent = PictureBox2
        Label1.Parent = PictureBox2

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Process.Start("https://github.com/windowslogic/vtubers.me-webapp/releases")
        Me.Close()
    End Sub

    Private Sub PostponeButton_Click(sender As Object, e As EventArgs) Handles PostponeButton.Click
        Me.Close()
    End Sub
End Class