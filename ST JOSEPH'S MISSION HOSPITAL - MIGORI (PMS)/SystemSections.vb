Public Class SystemSections
    Private Sub AdminButton_Click(sender As Object, e As EventArgs) Handles AdminButton.Click
        AdminSectionUsernameAndPassword.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub FrontEndDeskStaffButton_Click(sender As Object, e As EventArgs) Handles FrontEndDeskStaffButton.Click
        FrontEndDeskLogin.Show()
        Me.Hide()
    End Sub

    Private Sub DoctorSectionButton_Click(sender As Object, e As EventArgs) Handles DoctorSectionButton.Click
        DoctorsLogin.Show()
        Me.Hide()
    End Sub

    Private Sub NurseSectionButton_Click(sender As Object, e As EventArgs) Handles NurseSectionButton.Click
        NurseLoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub AccountsSectionButton_Click(sender As Object, e As EventArgs) Handles AccountsSectionButton.Click
        AccountsLogin.Show()
        Me.Hide()
    End Sub
End Class