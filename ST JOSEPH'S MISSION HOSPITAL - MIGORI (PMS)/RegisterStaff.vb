Public Class RegisterStaff
    Private Sub RegisterDoctors_Click(sender As Object, e As EventArgs) Handles RegisterDoctors.Click
        DoctorRegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterNurses_Click(sender As Object, e As EventArgs) Handles RegisterNurses.Click
        NurseRegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdminSection.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterFrontDesk_Click(sender As Object, e As EventArgs) Handles RegisterFrontDesk.Click
        FrontEndDeskRegistrationForm.Show()
        Me.Hide()
    End Sub

    Private Sub RegisterStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class