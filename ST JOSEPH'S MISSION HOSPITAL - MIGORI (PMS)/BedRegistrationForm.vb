Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class BedRegistrationForm

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
        sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.bed_information"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        BedInformationReport.DataSource = sqlDt
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

    Public Sub resetTable()
        Try
            BedNo.Text = ""
            WardNO.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BedRegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        fillWardNoCombobox()
    End Sub

    Private Sub AddBedButton_Click(sender As Object, e As EventArgs) Handles AddBedButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "insert into st_josephs_mission_hospital_prms.bed_information (bed_no, ward_no)
            values('" & BedNo.Text & "','" & WardNO.Text & "')"
            sqlCmd.CommandText = "SELECT * From st_josephs_mission_hospital_prms.bed_information"

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

    Private Sub UpdateBedButton_Click(sender As Object, e As EventArgs) Handles UpdateBedButton.Click
        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
           "password  = " + password + ";" + "database =" + database

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "Update st_josephs_mission_hospital_prms.bed_information set bed_no=@BedNo, ward_no= @WardNo where bed_no=@BedNo"

            .CommandType = CommandType.Text

            .Parameters.AddWithValue("@BedNo", BedNo.Text)
            .Parameters.AddWithValue("@WardNo", WardNO.Text)


        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
        MessageBox.Show("Data Updated Successfully")
        resetTable()
    End Sub

    Private Sub BedInformationReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BedInformationReport.CellClick
        Try
            BedNo.Text = BedInformationReport.SelectedRows(0).Cells(0).Value.ToString
            WardNO.Text = BedInformationReport.SelectedRows(0).Cells(1).Value.ToString
            With sqlCmd
                .Parameters.Clear()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DeleteBedButton_Click(sender As Object, e As EventArgs) Handles DeleteBedButton.Click
        sqlConn = New MySqlConnection

        sqlConn.ConnectionString = "server  = " + server + ";" + "user id=" + username + ";" +
            "password  = " + password + ";" + "database =" + database

        Try
            sqlConn.Open()
            sqlQuery = "Delete from st_josephs_mission_hospital_prms.bed_information where bed_no='" & BedNo.Text & "'"

            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")
            sqlConn.Close()

            For Each row As DataGridViewRow In BedInformationReport.SelectedRows
                BedInformationReport.Rows.Remove(row)
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