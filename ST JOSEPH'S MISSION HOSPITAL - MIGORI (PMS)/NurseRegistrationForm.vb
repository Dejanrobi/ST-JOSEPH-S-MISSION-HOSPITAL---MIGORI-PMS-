﻿Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class NurseRegistrationForm

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

    Private bitmap As Bitmap


    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.nurse_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        NursesInformation.DataSource = sqlDt
    End Sub

    Public Sub resetTable()
        Try
            NurseIDNO.Text = ""
            NurseFirstName.Text = ""
            NurseLastName.Text = ""
            NurseGender.Text = ""
            NurseDOR.Text = ""
            NurseDOB.Text = ""
            NurseAddress.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NurseRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AddRecordButton_Click(sender As Object, e As EventArgs) Handles AddRecordButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into st_josephs_mission_hospital_prms.nurse_information (nurse_id, first_name, last_name, dob, gender, home_address, date_registered)
            values('" & NurseIDNO.Text & "','" & NurseFirstName.Text & "','" & NurseLastName.Text & "','" & NurseDOB.Text & "','" & NurseGender.Text & "','" & NurseAddress.Text & "','" & NurseDOR.Text & "')"
            sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.nurse_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Record Saved Sucessfully")
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        updateTable()
        resetTable()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
           "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.nurse_information set nurse_id = @Nurseid, first_name=@Firstname, last_name=@Lastname, dob=@Dob, gender=@Gender, home_address=@Homeaddress, date_registered=@Dor where nurse_id=@Nurseid"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@Nurseid", NurseIDNO.Text)
            .Parameters.AddWithValue("@Firstname", NurseFirstName.Text)
            .Parameters.AddWithValue("@Lastname", NurseLastName.Text)
            .Parameters.AddWithValue("@Dob", NurseDOB.Text)
            .Parameters.AddWithValue("@Gender", NurseGender.Text)
            .Parameters.AddWithValue("@Homeaddress", NurseAddress.Text)
            .Parameters.AddWithValue("@Dor", NurseDOR.Text)
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Data Updated Successfully")
        resetTable()
    End Sub

    Private Sub NursesInformation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles NursesInformation.CellClick
        Try

            NurseIDNO.Text = NursesInformation.SelectedRows(0).Cells(0).Value.ToString
            NurseFirstName.Text = NursesInformation.SelectedRows(0).Cells(1).Value.ToString
            NurseLastName.Text = NursesInformation.SelectedRows(0).Cells(2).Value.ToString
            NurseDOB.Text = NursesInformation.SelectedRows(0).Cells(3).Value.ToString
            NurseGender.Text = NursesInformation.SelectedRows(0).Cells(4).Value.ToString
            NurseAddress.Text = NursesInformation.SelectedRows(0).Cells(5).Value.ToString
            NurseDOR.Text = NursesInformation.SelectedRows(0).Cells(6).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        sqlConn = New MySqlConnection

        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.nurse_information where nurse_id='" & NurseIDNO.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In NursesInformation.SelectedRows
                NursesInformation.Rows.Remove(row)
            Next
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
        resetTable()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        resetTable()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RegisterStaff.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub SearchNurseID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchNurseID.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("   Convert(nurse_id, 'System.String') like '%" & SearchNurseID.Text & "%'")
                NursesInformation.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub
End Class