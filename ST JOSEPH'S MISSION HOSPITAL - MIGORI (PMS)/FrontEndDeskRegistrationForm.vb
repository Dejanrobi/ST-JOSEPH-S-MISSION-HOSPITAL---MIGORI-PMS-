Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class FrontEndDeskRegistrationForm
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
        sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.front_desk_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        FrontDeskInformationReport.DataSource = sqlDt
    End Sub

    Public Sub resetTable()
        Try
            FrontDeskId.Text = ""
            FirstName.Text = ""
            LastName.Text = ""
            Gender.Text = ""
            FrontDeskDOB.Text = ""
            FrontDeskDOR.Text = ""
            Address.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        RegisterStaff.Show()
        Me.Hide()
    End Sub

    Private Sub FrontEndDeskRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub AddRecordButton_Click(sender As Object, e As EventArgs) Handles AddRecordButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into st_josephs_mission_hospital_prms.front_desk_information (front_desk_id, first_name, last_name, dob, gender, home_address, date_registered)
            values('" & FrontDeskId.Text & "','" & FirstName.Text & "','" & LastName.Text & "','" & FrontDeskDOB.Text & "','" & Gender.Text & "','" & Address.Text & "','" & FrontDeskDOR.Text & "')"
            sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.doctor_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Staff Registered Sucessfully")
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
            .CommandText = "Update st_josephs_mission_hospital_prms.front_desk_information set front_desk_id = @FrontDeskId, first_name=@Firstname, last_name=@Lastname, dob=@Dob, gender=@Gender, home_address=@Homeaddress, date_registered=@Dor where front_desk_id=@FrontDeskId"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@FrontDeskId", FrontDeskId.Text)
            .Parameters.AddWithValue("@Firstname", FirstName.Text)
            .Parameters.AddWithValue("@Lastname", LastName.Text)
            .Parameters.AddWithValue("@Dob", FrontDeskDOB.Text)
            .Parameters.AddWithValue("@Gender", Gender.Text)
            .Parameters.AddWithValue("@Homeaddress", Address.Text)
            .Parameters.AddWithValue("@Dor", FrontDeskDOR.Text)
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Data Updated Successfully")
        resetTable()
    End Sub

    Private Sub FrontDeskInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FrontDeskInformationReport.CellClick
        Try

            FrontDeskId.Text = FrontDeskInformationReport.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = FrontDeskInformationReport.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = FrontDeskInformationReport.SelectedRows(0).Cells(2).Value.ToString
            FrontDeskDOB.Text = FrontDeskInformationReport.SelectedRows(0).Cells(3).Value.ToString
            Gender.Text = FrontDeskInformationReport.SelectedRows(0).Cells(4).Value.ToString
            Address.Text = FrontDeskInformationReport.SelectedRows(0).Cells(5).Value.ToString
            FrontDeskDOR.Text = FrontDeskInformationReport.SelectedRows(0).Cells(6).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        sqlConn = New MySqlConnection

        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.front_desk_information where front_desk_id='" & FrontDeskId.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In FrontDeskInformationReport.SelectedRows
                FrontDeskInformationReport.Rows.Remove(row)
            Next
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
        resetTable()
    End Sub

    Private Sub ResetFormButton_Click(sender As Object, e As EventArgs) Handles ResetFormButton.Click
        resetTable()
    End Sub
End Class