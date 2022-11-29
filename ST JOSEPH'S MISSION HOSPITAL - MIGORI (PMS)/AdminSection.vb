Public Class AdminSection
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()


    End Sub

    Private Sub AssignDoctorsAndNursesButton_Click(sender As Object, e As EventArgs) Handles AssignDoctorsAndNursesButton.Click
        AllocatePatientsWithDoctorsAndNurses.Show()
        Me.Hide()
    End Sub

    Private Sub CheckoutPatientButton_Click(sender As Object, e As EventArgs) Handles CheckoutPatientButton.Click
        CheckoutPatient.Show()
        Me.Hide()
    End Sub

    Private Sub AssignEmergencyCasesButton_Click(sender As Object, e As EventArgs) Handles AssignEmergencyCasesButton.Click
        AssignEmergencies.Show()
        Me.Hide()
    End Sub

    Private Sub AssignSurgeriesButton_Click(sender As Object, e As EventArgs) Handles AssignSurgeriesButton.Click
        AssignSurgery.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterStaffButton_Click(sender As Object, e As EventArgs) Handles RegisterStaffButton.Click
        RegisterStaff.Show()
        Me.Hide()
    End Sub
End Class