Public Class NurseSection
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()
    End Sub

    Private Sub AssignDoctorsAndNursesButton_Click(sender As Object, e As EventArgs) Handles AssignDoctorsAndNursesButton.Click
        BedAndWardAllocationForm.Show()
        Me.Hide()
    End Sub

    Private Sub AssignSurgeriesButton_Click(sender As Object, e As EventArgs) Handles AssignSurgeriesButton.Click
        PatientProgressForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PatientProgressFinalReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PatientDiagnosisReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NurseAllocatedPatientReport.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NurseSurgeryAllocations.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NurseEmergencyAllocations.Show()
        Me.Hide()
    End Sub
End Class