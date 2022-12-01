Public Class FrontDeskSection
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterPatientsButton_Click(sender As Object, e As EventArgs) Handles RegisterPatientsButton.Click
        PatientRegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub PatientDetailsButton_Click(sender As Object, e As EventArgs) Handles PatientDetailsButton.Click
        PatientDetailsReport.Show()
        Me.Hide()
    End Sub

    Private Sub FrontDeskSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class