Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class PatientDiagnosisReport
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
        sqlCmd.CommandText = "SELECT patient_id,first_name, last_name, diagnosis, treatment_recommendation From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientDiagnosisFinal.DataSource = sqlDt
    End Sub
    Private Sub PatientDiagnosisReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        Me.WindowState = FormWindowState.Maximized
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

    Private Sub PatientDiagnosisFinal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientDiagnosisFinal.CellClick
        Try

            PatientID.Text = PatientDiagnosisFinal.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = PatientDiagnosisFinal.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = PatientDiagnosisFinal.SelectedRows(0).Cells(2).Value.ToString
            DiagnosisTextBox.Text = PatientDiagnosisFinal.SelectedRows(0).Cells(3).Value.ToString
            TreatmentRecommendation.Text = PatientDiagnosisFinal.SelectedRows(0).Cells(4).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchPatientsID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchPatientsID.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("   Convert(patient_id, 'System.String') like '%" & SearchPatientsID.Text & "%'")
                PatientDiagnosisFinal.DataSource = dv.ToTable
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub
End Class