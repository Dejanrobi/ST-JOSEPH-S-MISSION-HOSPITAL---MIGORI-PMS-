Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Data

Public Class DoctorsLogin

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "7944@dejanROBI"
    Dim database As String = "st_josephs_mission_hospital_prms"
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()
    End Sub

    Private Sub DoctorLoginButton_Click(sender As Object, e As EventArgs) Handles DoctorLoginButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
           "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * from st_josephs_mission_hospital_prms.doctor_section_login where doctor_username='" + DoctorSectionUsername.Text + "' and doctor_password='" + DoctorSectionPassword.Text + "'"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()

        If (sqlDt.Rows.Count > 0) Then
            DoctorSection.Show()
            Me.Hide()
            MessageBox.Show("Login Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            DoctorSectionPassword.Text = ""
            DoctorSectionUsername.Text = ""
            sqlDt.Clear()
        Else
            MessageBox.Show("Username or password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class