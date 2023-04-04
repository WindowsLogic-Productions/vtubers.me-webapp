Public Class SettingsPanel
    Private Sub GeneralSettingsButton_Click(sender As Object, e As EventArgs) Handles GeneralSettingsButton.Click
        SettingsPanelGeneral.Show()
        Me.Close()
    End Sub
End Class