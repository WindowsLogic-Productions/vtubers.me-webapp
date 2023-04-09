Public Class VTuberWhatsNew
    Private Sub VTuberWhatsNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load colour settings.
        If My.Settings.CCE = 1 Then
            Me.BackColor = My.Settings.CustomColour
        End If

    End Sub
End Class