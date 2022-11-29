Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class BedAndWardAllocationForm
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
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, ward_no, bed_no From st_josephs_mission_hospital_prms.patient_information where bed_no is null"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        BedAndWardAllocationInformationReport.DataSource = sqlDt
    End Sub

    Private Sub fillWardNoCombobox()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "select * from st_josephs_mission_hospital_prms.ward_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            While sqlRd.Read
                Dim dID = sqlRd.GetInt64("ward_no")
                WardNO.Items.Add(dID)
            End While

            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
    End Sub


    Private Sub fillBedNoCombobox()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "select * from st_josephs_mission_hospital_prms.bed_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader

            While sqlRd.Read
                Dim dID = sqlRd.GetInt64("bed_no")
                BedNO.Items.Add(dID)
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
            BedNO.Text = ""
            WardNO.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReallocatePatientButton_Click(sender As Object, e As EventArgs) Handles ReallocatePatientButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlCmd.Connection = sqlConn

            With sqlCmd
                .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set patient_id = @Patientid, first_name=@Firstname, last_name=@Lastname, ward_no=@WardNo, bed_no=@BedNo where patient_id=@Patientid"

                .CommandType = CommandType.Text

                .Parameters.AddWithValue("@Patientid", PatientIDNO.Text)
                .Parameters.AddWithValue("@Firstname", FirstName.Text)
                .Parameters.AddWithValue("@Lastname", LastName.Text)
                .Parameters.AddWithValue("@WardNo", WardNO.Text)
                .Parameters.AddWithValue("@BedNo", BedNO.Text)


            End With

            For Each row As DataGridViewRow In BedAndWardAllocationInformationReport.SelectedRows
                BedAndWardAllocationInformationReport.Rows.Remove(row)
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

    Private Sub BedAndWardAllocationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        fillWardNoCombobox()
        fillBedNoCombobox()
    End Sub


    Private Sub BedAndWardAllocationInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BedAndWardAllocationInformationReport.CellClick
        Try

            PatientIDNO.Text = BedAndWardAllocationInformationReport.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = BedAndWardAllocationInformationReport.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = BedAndWardAllocationInformationReport.SelectedRows(0).Cells(2).Value.ToString
            WardNO.Text = BedAndWardAllocationInformationReport.SelectedRows(0).Cells(3).Value.ToString
            BedNO.Text = BedAndWardAllocationInformationReport.SelectedRows(0).Cells(4).Value.ToString
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

    Private Sub WardNO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WardNO.SelectedIndexChanged

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        NurseSection.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class