Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class DiagnosisForm
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
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, date_of_diagnosis, diagnosis, treatment_recommendation From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientDiagnosisInformationReport.DataSource = sqlDt
    End Sub

    Private Sub resetTable()
        Try
            PATIENTID.Text = ""
            PatientFirstName.Text = ""
            PatientLastName.Text = ""
            DateOfDiagnosis.Text = ""
            PatientdDiagnosis.Text = ""
            TreatmentRecommendation.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PatientdDiagnosis.TextChanged

    End Sub

    Private Sub TreatmentRecommendation_TextChanged(sender As Object, e As EventArgs) Handles TreatmentRecommendation.TextChanged

    End Sub

    Private Sub AddRecordButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeleteDiagnosisButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DiagnosisForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDiagnosisInformationReport.CellContentClick

    End Sub

    Private Sub SearchPatient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchPatient.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("   Convert(patient_id, 'System.String') like '%" & SearchPatient.Text & "%'")
                PatientDiagnosisInformationReport.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub

    Private Sub PatientDiagnosisInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDiagnosisInformationReport.CellClick
        Try

            PATIENTID.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(0).Value.ToString
            PatientFirstName.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(1).Value.ToString
            PatientLastName.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(2).Value.ToString
            DateOfDiagnosis.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(3).Value.ToString
            PatientdDiagnosis.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(4).Value.ToString
            TreatmentRecommendation.Text = PatientDiagnosisInformationReport.SelectedRows(0).Cells(5).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set patient_id = @Patientid, date_of_diagnosis=@Dod, diagnosis=@Diagnosis, treatment_recommendation=@TreatmentRecommendation where patient_id=@Patientid"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@Patientid", PATIENTID.Text)
            .Parameters.AddWithValue("@Dod", DateOfDiagnosis.Text)
            .Parameters.AddWithValue("@Diagnosis", PatientdDiagnosis.Text)
            .Parameters.AddWithValue("@TreatmentRecommendation", TreatmentRecommendation.Text)
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Diagnosis Submitted Successfully")
        resetTable()
    End Sub

    Private Sub ResetFormButton_Click(sender As Object, e As EventArgs) Handles ResetFormButton.Click
        resetTable()
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
End Class