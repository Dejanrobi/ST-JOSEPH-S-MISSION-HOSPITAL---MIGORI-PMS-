Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class AssignSurgery

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

    Public Sub resetTable()
        Try
            PatientId.Text = ""
            FirstName.Text = ""
            LastName.Text = ""
            DoctorID.Text = ""
            NurseId.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name,situation, doctor_id, nurse_id From st_josephs_mission_hospital_prms.patient_information where situation='" + PatientSituation.Text + "' and doctor_id is null"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        SurgeryAllocationReport.DataSource = sqlDt
    End Sub

    Private Sub fillDoctorIDCombobox()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "select * from st_josephs_mission_hospital_prms.doctor_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            While sqlRd.Read
                Dim dID = sqlRd.GetInt64("doctor_id")
                DoctorID.Items.Add(dID)
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Private Sub fillNurseIDCombobox()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "select * from st_josephs_mission_hospital_prms.nurse_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            While sqlRd.Read
                Dim dID = sqlRd.GetInt64("nurse_id")
                NurseId.Items.Add(dID)
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdminSection.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AssignSurgery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        fillNurseIDCombobox()
        fillDoctorIDCombobox()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set  doctor_id=@Doctorid, nurse_id=@Nurseid where patient_id='" + PatientId.Text + "'"

                .CommandType = CommandType.Text


                .Parameters.AddWithValue("@Doctorid", DoctorID.Text)
                .Parameters.AddWithValue("@Nurseid", NurseId.Text)


            End With

            For Each row As DataGridViewRow In SurgeryAllocationReport.SelectedRows
                SurgeryAllocationReport.Rows.Remove(row)
            Next
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

            MessageBox.Show("Surgery Assigned Successfully")
            resetTable()
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SurgeryAllocationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SurgeryAllocationReport.CellClick
        Try

            PatientId.Text = SurgeryAllocationReport.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = SurgeryAllocationReport.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = SurgeryAllocationReport.SelectedRows(0).Cells(2).Value.ToString
            DoctorID.Text = SurgeryAllocationReport.SelectedRows(0).Cells(4).Value.ToString
            NurseId.Text = SurgeryAllocationReport.SelectedRows(0).Cells(5).Value.ToString


            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class