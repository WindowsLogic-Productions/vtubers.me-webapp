Public Class VTuberProfile
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If TextBox1.Text = Nothing Then
            MsgBox("No profile name has been entered.", MsgBoxStyle.Critical, "Error")
        Else
            My.Settings.ProfileName = TextBox1.Text
            My.Settings.OCA = 1
            My.Settings.Save()
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub VTuberProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If
    End Sub
End Class