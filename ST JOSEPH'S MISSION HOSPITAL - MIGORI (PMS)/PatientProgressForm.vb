Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class PatientProgressForm
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
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, date_of_progress, patient_progress From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientProgressInformationReport.DataSource = sqlDt
    End Sub

    Private Sub resetTable()
        Try
            PATIENTID.Text = ""
            PatientFirstName.Text = ""
            PatientLastName.Text = ""
            DateOfProgress.Text = ""
            PatientProgress.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PatientProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub ResetFormButton_Click(sender As Object, e As EventArgs) Handles ResetFormButton.Click
        resetTable()
    End Sub

    Private Sub SearchPatientProgress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchPatientProgress.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("first_name like '%{0}'", SearchPatientProgress.Text)
                PatientProgressInformationReport.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub

    Private Sub PatientProgressInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientProgressInformationReport.CellClick
        Try

            PATIENTID.Text = PatientProgressInformationReport.SelectedRows(0).Cells(0).Value.ToString
            PatientFirstName.Text = PatientProgressInformationReport.SelectedRows(0).Cells(1).Value.ToString
            PatientLastName.Text = PatientProgressInformationReport.SelectedRows(0).Cells(2).Value.ToString
            DateOfProgress.Text = PatientProgressInformationReport.SelectedRows(0).Cells(3).Value.ToString
            PatientProgress.Text = PatientProgressInformationReport.SelectedRows(0).Cells(4).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddProgressButton_Click(sender As Object, e As EventArgs) Handles AddProgressButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set patient_id = @Patientid, date_of_progress=@Dop, patient_progress=@PatientProgress where patient_id=@Patientid"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@Patientid", PATIENTID.Text)
            .Parameters.AddWithValue("@Dop", DateOfProgress.Text)
            .Parameters.AddWithValue("@PatientProgress", PatientProgress.Text)

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Progress Submitted Successfully")
        resetTable()
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