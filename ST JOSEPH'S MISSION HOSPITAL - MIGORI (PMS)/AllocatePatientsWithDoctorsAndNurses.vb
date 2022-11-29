Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class AllocatePatientsWithDoctorsAndNurses
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
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, doctor_id, nurse_id, date_of_dn_allocation From st_josephs_mission_hospital_prms.patient_information where doctor_id is null"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientDoctorNurseAllocationInformation.DataSource = sqlDt
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
                NurseID.Items.Add(dID)
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub

    Public Sub resetTable()
        Try
            PatientIDNO.Text = ""
            FirstName.Text = ""
            LastName.Text = ""
            DateOfAllocation.Text = ""
            DoctorID.Text = ""
            NurseID.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AllocatePatientsWithDoctorsAndNurses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        fillDoctorIDCombobox()
        fillNurseIDCombobox()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AllocatePatientButton_Click(sender As Object, e As EventArgs) Handles AllocatePatientButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set patient_id = @Patientid, first_name=@Firstname, last_name=@Lastname, doctor_id=@Doctorid, nurse_id=@Nurseid, date_of_dn_allocation=@Dateofdnallocation where patient_id=@Patientid"

                .CommandType = CommandType.Text

                .Parameters.AddWithValue("@Patientid", PatientIDNO.Text)
                .Parameters.AddWithValue("@Firstname", FirstName.Text)
                .Parameters.AddWithValue("@Lastname", LastName.Text)
                .Parameters.AddWithValue("@Doctorid", DoctorID.Text)
                .Parameters.AddWithValue("@Nurseid", NurseID.Text)
                .Parameters.AddWithValue("@Dateofdnallocation", DateOfAllocation.Text)

            End With

            For Each row As DataGridViewRow In PatientDoctorNurseAllocationInformation.SelectedRows
                PatientDoctorNurseAllocationInformation.Rows.Remove(row)
            Next
            sqlCmd.ExecuteNonQuery()
            sqlConn.Close()

            MessageBox.Show("Patient Allocated Successfully")
            resetTable()
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PatientDoctorNurseAllocationInformation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDoctorNurseAllocationInformation.CellClick
        Try

            PatientIDNO.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(2).Value.ToString
            DoctorID.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(3).Value.ToString
            NurseID.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(4).Value.ToString
            DateOfAllocation.Text = PatientDoctorNurseAllocationInformation.SelectedRows(0).Cells(5).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ResetFormButton_Click(sender As Object, e As EventArgs) Handles ResetFormButton.Click
        resetTable()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        AdminSection.Show()
        Me.Hide()
    End Sub
End Class