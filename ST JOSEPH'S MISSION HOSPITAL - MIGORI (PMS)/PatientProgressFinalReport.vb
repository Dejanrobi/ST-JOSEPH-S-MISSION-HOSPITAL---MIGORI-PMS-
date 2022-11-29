﻿Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class PatientProgressFinalReport

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
        DoctorSection.Show()
        Me.Hide()
    End Sub

    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT patient_id,first_name, last_name, patient_progress From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientProgressReport.DataSource = sqlDt
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PatientProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub PatientProgressReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientProgressReport.CellClick
        Try

            PatientID.Text = PatientProgressReport.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = PatientProgressReport.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = PatientProgressReport.SelectedRows(0).Cells(2).Value.ToString
            ProgressTextBox.Text = PatientProgressReport.SelectedRows(0).Cells(3).Value.ToString


            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PatientProgressReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientProgressReport.CellContentClick

    End Sub
End Class