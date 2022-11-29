Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Google.Protobuf.WellKnownTypes

Public Class AccountsForm

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

    Private Sub resetTable()
        Try
            PatientID.Text = ""
            FirstName.Text = ""
            LastName.Text = ""
            AccountsDate.Text = ""
            DrugsAdministered.Text = ""
            OtherServices.Text = ""
            PatientTotalCost.Text = ""
            PatientAmountPaid.Text = ""
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
        sqlCmd.CommandText = "SELECT patient_id, first_name, last_name, accounts_date, treatment_recommendation, other_services, total_cost, amount_paid, balance From st_josephs_mission_hospital_prms.patient_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        PatientAccountsInformationReport.DataSource = sqlDt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        resetTable()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        SystemSections.Show()
        Me.Hide()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("Are You Sure You Want To Close Down The System?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub PatientAccountsInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PatientAccountsInformationReport.CellClick
        Try

            PatientID.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(0).Value.ToString
            FirstName.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(1).Value.ToString
            LastName.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(2).Value.ToString
            AccountsDate.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(3).Value.ToString
            DrugsAdministered.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(4).Value.ToString
            OtherServices.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(5).Value.ToString
            PatientTotalCost.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(6).Value.ToString
            PatientAmountPaid.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(7).Value.ToString
            PatientBalance.Text = PatientAccountsInformationReport.SelectedRows(0).Cells(8).Value.ToString
            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.patient_information set accounts_date=@AccountsDate, other_services=@OtherServices, total_cost=@TotalCost, amount_paid=@AmountPaid, balance=@Balance where patient_id=@Patientid"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@Patientid", PatientID.Text)
            .Parameters.AddWithValue("@AccountsDate", AccountsDate.Text)
            .Parameters.AddWithValue("@OtherServices", OtherServices.Text)
            .Parameters.AddWithValue("@TotalCost", PatientTotalCost.Text)
            .Parameters.AddWithValue("@AmountPaid", PatientAmountPaid.Text)
            .Parameters.AddWithValue("@Balance", PatientBalance.Text)

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Accounts Information Submitted Successfully")
        resetTable()
    End Sub



    Private Sub PatientTotalCost_Enter(sender As Object, e As EventArgs) Handles PatientTotalCost.Enter
        Dim a, b As Integer
        a = Val(PatientTotalCost.Text)
        b = Val(PatientAmountPaid.Text)

        PatientBalance.Text = a - b
    End Sub

    Private Sub PatientAmountPaid_Enter(sender As Object, e As EventArgs) Handles PatientAmountPaid.Enter
        Dim a, b As Integer
        a = Val(PatientTotalCost.Text)
        b = Val(PatientAmountPaid.Text)

        PatientBalance.Text = a - b
    End Sub
End Class