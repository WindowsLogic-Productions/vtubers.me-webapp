Public Class SettingsPanel
    Private Sub GeneralSettingsButton_Click(sender As Object, e As EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Close()
    End Sub

    Private Sub PersonaliseSettingsButton_Click(sender As Object, e As EventArgs) Handles PersonaliseSettingsButton.Click
        SettingsPanelPersonalise.Show()
        Me.Close()
    End Sub
End Class