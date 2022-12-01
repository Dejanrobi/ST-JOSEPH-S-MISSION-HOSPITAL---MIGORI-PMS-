Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class WardRegistrationForm
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
        sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.ward_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        WardInformationReport.DataSource = sqlDt
    End Sub

    Public Sub resetTable()
        Try
            WardNO.Text = ""
            NoOfBeds.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BedNo_TextChanged(sender As Object, e As EventArgs) Handles NoOfBeds.TextChanged

    End Sub

    Private Sub WardRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub UpdateWardButton_Click(sender As Object, e As EventArgs) Handles UpdateWardButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
           "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.ward_information set ward_no= @WardNo, number_of_beds=@NoOfBeds where ward_no=@WardNo"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@WardNo", WardNO.Text)
            .Parameters.AddWithValue("@NoOfBeds", NoOfBeds.Text)

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Data Updated Successfully")
        resetTable()
    End Sub

    Private Sub AddWardButton_Click(sender As Object, e As EventArgs) Handles AddWardButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into st_josephs_mission_hospital_prms.ward_information (ward_no, number_of_beds)
            values('" & WardNO.Text & "','" & NoOfBeds.Text & "')"
            sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.ward_information"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Record Saved Sucessfully")
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            sqlConn.Dispose()
        End Try

        updateTable()
        resetTable()
    End Sub

    Private Sub WardInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles WardInformationReport.CellClick
        Try

            WardNO.Text = WardInformationReport.SelectedRows(0).Cells(0).Value.ToString
            NoOfBeds.Text = WardInformationReport.SelectedRows(0).Cells(1).Value.ToString


            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteWardButton_Click(sender As Object, e As EventArgs) Handles DeleteWardButton.Click
        sqlConn = New MySqlConnection

        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.ward_information where ward_no='" & WardNO.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In WardInformationReport.SelectedRows
                WardInformationReport.Rows.Remove(row)
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