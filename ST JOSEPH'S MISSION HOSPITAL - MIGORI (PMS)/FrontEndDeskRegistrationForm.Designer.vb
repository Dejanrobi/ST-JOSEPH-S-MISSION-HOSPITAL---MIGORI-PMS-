<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontEndDeskRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.FrontDeskInformationReport = New System.Windows.Forms.DataGridView()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.FrontDeskDOB = New System.Windows.Forms.DateTimePicker()
        Me.FrontDeskDOR = New System.Windows.Forms.DateTimePicker()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.FrontDeskId = New System.Windows.Forms.TextBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddRecordButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchStaffID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.FrontDeskInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(998, 448)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 102
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(998, 388)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 101
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'FrontDeskInformationReport
        '
        Me.FrontDeskInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FrontDeskInformationReport.Location = New System.Drawing.Point(198, 381)
        Me.FrontDeskInformationReport.Name = "FrontDeskInformationReport"
        Me.FrontDeskInformationReport.RowTemplate.Height = 25
        Me.FrontDeskInformationReport.Size = New System.Drawing.Size(606, 214)
        Me.FrontDeskInformationReport.TabIndex = 100
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(998, 273)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(130, 40)
        Me.ResetFormButton.TabIndex = 99
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'FrontDeskDOB
        '
        Me.FrontDeskDOB.CustomFormat = "yyyy-MM-dd"
        Me.FrontDeskDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FrontDeskDOB.Location = New System.Drawing.Point(298, 267)
        Me.FrontDeskDOB.Name = "FrontDeskDOB"
        Me.FrontDeskDOB.Size = New System.Drawing.Size(195, 23)
        Me.FrontDeskDOB.TabIndex = 98
        '
        'FrontDeskDOR
        '
        Me.FrontDeskDOR.CustomFormat = "yyyy-MM-dd"
        Me.FrontDeskDOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FrontDeskDOR.Location = New System.Drawing.Point(616, 217)
        Me.FrontDeskDOR.Name = "FrontDeskDOR"
        Me.FrontDeskDOR.Size = New System.Drawing.Size(188, 23)
        Me.FrontDeskDOR.TabIndex = 97
        '
        'Gender
        '
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.Gender.Location = New System.Drawing.Point(618, 120)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(173, 23)
        Me.Gender.TabIndex = 96
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(616, 171)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(173, 23)
        Me.Address.TabIndex = 95
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(296, 220)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(165, 23)
        Me.LastName.TabIndex = 94
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(296, 171)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(165, 23)
        Me.FirstName.TabIndex = 93
        '
        'FrontDeskId
        '
        Me.FrontDeskId.Location = New System.Drawing.Point(298, 117)
        Me.FrontDeskId.Name = "FrontDeskId"
        Me.FrontDeskId.Size = New System.Drawing.Size(165, 23)
        Me.FrontDeskId.TabIndex = 92
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(998, 223)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(130, 37)
        Me.DeleteButton.TabIndex = 91
        Me.DeleteButton.Text = "DELETE RECORD"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddRecordButton
        '
        Me.AddRecordButton.Location = New System.Drawing.Point(998, 117)
        Me.AddRecordButton.Name = "AddRecordButton"
        Me.AddRecordButton.Size = New System.Drawing.Size(130, 39)
        Me.AddRecordButton.TabIndex = 90
        Me.AddRecordButton.Text = "ADD RECORD"
        Me.AddRecordButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(998, 171)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(130, 38)
        Me.UpdateButton.TabIndex = 89
        Me.UpdateButton.Text = "UPDATE RECORD"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "D . O . R : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(538, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "ADDRESS : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(540, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "GENDER : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "D. O. B :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "LAST NAME : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "FIRST NAME : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(198, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "ID NO : "
        '
        'SearchStaffID
        '
        Me.SearchStaffID.Location = New System.Drawing.Point(492, 46)
        Me.SearchStaffID.Name = "SearchStaffID"
        Me.SearchStaffID.Size = New System.Drawing.Size(175, 23)
        Me.SearchStaffID.TabIndex = 104
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 15)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "SEARCH STAFF BY ID:"
        '
        'FrontEndDeskRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 627)
        Me.Controls.Add(Me.SearchStaffID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.FrontDeskInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.FrontDeskDOB)
        Me.Controls.Add(Me.FrontDeskDOR)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.FrontDeskId)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.AddRecordButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrontEndDeskRegistrationForm"
        Me.Text = "FrontEndDeskRegistrationForm"
        CType(Me.FrontDeskInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents FrontDeskInformationReport As DataGridView
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents FrontDeskDOB As DateTimePicker
    Friend WithEvents FrontDeskDOR As DateTimePicker
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Address As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents FrontDeskId As TextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddRecordButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SearchStaffID As TextBox
    Friend WithEvents Label8 As Label
End Class
