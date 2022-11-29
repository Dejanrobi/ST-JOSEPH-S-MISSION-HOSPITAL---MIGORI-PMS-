Public Class DoctorSection
    Private Sub DiagnoseButton_Click(sender As Object, e As EventArgs) Handles DiagnoseButton.Click
        DiagnosisForm.Show()
        Me.Hide()
    End Sub

    Private Sub AllocatedPatients_Click(sender As Object, e As EventArgs) Handles AllocatedPatients.Click
        DoctorsAllocatedPatientsReport.Show()
        Me.Hide()
    End Sub

    Private Sub PatientProgress_Click(sender As Object, e As EventArgs) Handles PatientProgress.Click
        PatientProgressFinalReport.Show()
        Me.Hide()
    End Sub

    Private Sub CheckPatientDiagnosis_Click(sender As Object, e As EventArgs) Handles CheckPatientDiagnosis.Click
        PatientDiagnosisReport.Show()
        Me.Hide()
    End Sub

    Private Sub AllocatedSurgeries_Click(sender As Object, e As EventArgs) Handles AllocatedSurgeries.Click
        DocotorSurgeryAllocationReport.Show()
        Me.Hide()
    End Sub

    Private Sub AllocatedEmergencies_Click(sender As Object, e As EventArgs) Handles AllocatedEmergencies.Click
        DoctorEmergencyAllocation.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()

    End Sub
End Class