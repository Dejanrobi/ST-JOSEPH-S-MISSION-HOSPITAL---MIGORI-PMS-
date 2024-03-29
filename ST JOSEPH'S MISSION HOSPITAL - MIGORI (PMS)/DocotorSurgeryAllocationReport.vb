﻿Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class DocotorSurgeryAllocationReport
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

    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, situation, doctor_id From st_josephs_mission_hospital_prms.patient_information where situation='" + SituationTextBox.Text + "'"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        AllocatedSurgeryReport.DataSource = sqlDt
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        DoctorSection.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DocotorSurgeryAllocationReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DoctorsID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DoctorsID.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("   Convert(doctor_id, 'System.String') like '%" & DoctorsID.Text & "%'")
                AllocatedSurgeryReport.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub
End Class