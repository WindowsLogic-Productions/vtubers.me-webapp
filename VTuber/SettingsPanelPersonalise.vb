Public Class SettingsPanelPersonalise

#Region "Hub Background"
    Private Sub CB1Box_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB1Box.Click
        If RB1Box.Checked = True Then
            CB1Button.Enabled = True
            HUCSwitch.Checked = False
            HDBSwitch.Checked = False
            Try
                HubBackgroundPicture.Load(My.Settings.CB1)
                VTuberMain.HubBackground.Load(My.Settings.CB1)
                My.Settings.DHBHUC = 2
                My.Settings.Save()
            Catch ex As Exception

            End Try
        End If

        If RB1Box.Checked = False Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            HubBackgroundPicture.Image = Nothing
            My.Settings.Save()
        End If
    End Sub

    Private Sub CB1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB1Button.Click
        OpenFileDialog1.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            HubBackgroundPicture.Load(OpenFileDialog1.FileName)
            My.Settings.CB1 = OpenFileDialog1.FileName
            VTuberMain.HubBackground.Load(My.Settings.CB1)
            MsgBox("To confirm your background, choose default, then custom again.")
            My.Settings.Save()
        End If
    End Sub

    Private Sub HDBSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HDBSwitch.CheckedChanged
        If HDBSwitch.Checked = True Then
            My.Settings.DHBHUC = 0
            CB1Button.Enabled = False
            RB1Box.Checked = False
            HubBackgroundPicture.Image = My.Resources.WLPBackground
            VTuberMain.HubBackground.Image = My.Resources.WLPBackground
            My.Settings.Save()
        End If
    End Sub

    Private Sub HUCSwitch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HUCSwitch.CheckedChanged
        If HUCSwitch.Checked = True Then
            My.Settings.DHBHUC = 1
            CB1Button.Enabled = False
            RB1Box.Checked = False
            HubBackgroundPicture.Image = Nothing
            VTuberMain.HubBackground.Image = Nothing
            My.Settings.Save()
        End If
    End Sub

    Private Sub SettingsPanelPersonalise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Background settings.
        If My.Settings.DHBHUC = 0 Then
            HDBSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 1 Then
            HUCSwitch.Checked = True
        End If

        If My.Settings.DHBHUC = 2 Then
            RB1Box.Checked = True
            HubBackgroundPicture.Load(My.Settings.CB1)
        End If

        'Load custom colour.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
            CCEBox.Checked = True
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SettingsPanel.Show()
        Me.Close()
    End Sub
#End Region
#Region "Colour Settings"
    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CCEBox.CheckedChanged
        If CCEBox.Checked = True Then
            CustomColourButton.Enabled = True
            My.Settings.CCE = 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CustomColourButton.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.CustomColour = ColorDialog1.Color
            Me.BackColor = My.Settings.CustomColour
            VTuberMain.Panel1.BackColor = My.Settings.CustomColour
            My.Settings.Save()
        End If
    End Sub
#End Region

End Class