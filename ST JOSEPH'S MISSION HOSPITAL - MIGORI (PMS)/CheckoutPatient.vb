Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class CheckoutPatient

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim dv As DataView

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "7944@dejanROBI"
    Dim database As String = "st_josephs_mission_hospital_prms"

    Private Sub resetTable()
        Try
            PatientId.Text = ""
            PatientsFirstName.Text = ""
            PatientsLastName.Text = ""
            AmountPaid.Text = ""
            PatientBalance.Text = ""


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub updateTable()
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT patient_id,first_name, last_name,total_cost, amount_paid, balance From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientClearanceData.DataSource = sqlDt
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

    Private Sub CheckoutPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TotalBill.TextChanged

    End Sub

    Private Sub PatientClearanceData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientClearanceData.CellClick
        Try

            PatientId.Text = PatientClearanceData.SelectedRows(0).Cells(0).Value.ToString
            PatientsFirstName.Text = PatientClearanceData.SelectedRows(0).Cells(1).Value.ToString
            PatientsLastName.Text = PatientClearanceData.SelectedRows(0).Cells(2).Value.ToString
            TotalBill.Text = PatientClearanceData.SelectedRows(0).Cells(3).Value.ToString
            AmountPaid.Text = PatientClearanceData.SelectedRows(0).Cells(4).Value.ToString
            PatientBalance.Text = PatientClearanceData.SelectedRows(0).Cells(5).Value.ToString

            With sqlCmd
                .Parameters.Clear()
            End With

            SearchPatientBox.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchPatientBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SearchPatientBox.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then

                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("first_name like '%{0}'", SearchPatientBox.Text)
                PatientClearanceData.DataSource = dv.ToTable
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        With sqlCmd
            .Parameters.Clear()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqlConn = New MySqlConnection

        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.patient_information where patient_id='" & PatientId.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Patient Cleared Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In PatientClearanceData.SelectedRows
                PatientClearanceData.Rows.Remove(row)
            Next
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try
        resetTable()
    End Sub


End Class