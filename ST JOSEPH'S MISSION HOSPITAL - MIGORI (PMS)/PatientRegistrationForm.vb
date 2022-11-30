Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class PatientRegistrationForm

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

    Private Sub resetTable()
        Try
            PatientIDNO.Text = ""
            PatientAddress.Text = ""
            PatientDOB.Text = ""
            PatientDOR.Text = ""
            PatientFirstName.Text = ""
            PatientGender.Text = ""
            PatientLastName.Text = ""
            PatientSituation.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT patient_id,first_name, last_name, dob, gender, home_address, dor, situation From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientInformationReport.DataSource = sqlDt
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PatientRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub AddRecordButton_Click(sender As Object, e As EventArgs) Handles AddRecordButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into st_josephs_mission_hospital_prms.patient_information (patient_id, first_name, last_name, dob, gender, home_address, dor, situation)
            values('" & PatientIDNO.Text & "','" & PatientFirstName.Text & "','" & PatientLastName.Text & "','" & PatientDOB.Text & "','" & PatientGender.Text & "','" & PatientAddress.Text & "','" & PatientDOR.Text & "','" & PatientSituation.Text & "')"
            sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.patient_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Saved")
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        updateTable()
        resetTable()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        resetTable()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set patient_id = @Patientid, first_name=@Firstname, last_name=@Lastname, dob=@Dob, gender=@Gender, home_address=@Homeaddress, dor=@Dor, situation=@PatientSituation where patient_id=@Patientid"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@Patientid", PatientIDNO.Text)
            .Parameters.AddWithValue("@Firstname", PatientFirstName.Text)
            .Parameters.AddWithValue("@Lastname", PatientLastName.Text)
            .Parameters.AddWithValue("@Dob", PatientDOB.Text)
            .Parameters.AddWithValue("@Gender", PatientGender.Text)
            .Parameters.AddWithValue("@Homeaddress", PatientAddress.Text)
            .Parameters.AddWithValue("@Dor", PatientDOR.Text)
            .Parameters.AddWithValue("@PatientSituation", PatientSituation.Text)
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Data Updated Successfully")
        resetTable()
    End Sub

    Private Sub PatientInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientInformationReport.CellClick
        Try

            PatientIDNO.Text = PatientInformationReport.SelectedRows(0).Cells(0).Value.ToString
            PatientFirstName.Text = PatientInformationReport.SelectedRows(0).Cells(1).Value.ToString
            PatientLastName.Text = PatientInformationReport.SelectedRows(0).Cells(2).Value.ToString
            PatientDOB.Text = PatientInformationReport.SelectedRows(0).Cells(3).Value.ToString
            PatientGender.Text = PatientInformationReport.SelectedRows(0).Cells(4).Value.ToString
            PatientAddress.Text = PatientInformationReport.SelectedRows(0).Cells(5).Value.ToString
            PatientDOR.Text = PatientInformationReport.SelectedRows(0).Cells(6).Value.ToString
            PatientSituation.Text = PatientInformationReport.SelectedRows(0).Cells(7).Value.ToString

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
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.patient_information where patient_id='" & PatientIDNO.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In PatientInformationReport.SelectedRows
                PatientInformationReport.Rows.Remove(row)
            Next
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
        resetTable()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub searchPatientTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles searchPatientTextBox.KeyPress


        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("first_name like '%{0}'", searchPatientTextBox.Text)
                PatientInformationReport.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        FrontDeskSection.Show()
        Me.Hide()
    End Sub

    Private Sub searchPatientTextBox_TextChanged(sender As Object, e As EventArgs) Handles searchPatientTextBox.TextChanged

    End Sub

    Private Sub PatientInformationReport_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientInformationReport.CellContentClick

    End Sub
End Class
