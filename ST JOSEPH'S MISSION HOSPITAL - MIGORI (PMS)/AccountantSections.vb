Public Class AccountantSections
    Private Sub RegisterPatientsButton_Click(sender As Object, e As EventArgs) Handles RegisterPatientsButton.Click
        AccountsForm.Show()
        Me.Hide()
    End Sub

    Private Sub PatientDetailsButton_Click(sender As Object, e As EventArgs) Handles PatientDetailsButton.Click
        PatientAccountDetailsReport.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()
    End Sub
End Class