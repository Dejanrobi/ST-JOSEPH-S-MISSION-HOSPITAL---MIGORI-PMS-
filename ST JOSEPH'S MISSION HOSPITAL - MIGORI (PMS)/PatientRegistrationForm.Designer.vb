<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PatientRegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.AddRecordButton = New System.Windows.Forms.Button()
        Me.PatientIDNO = New System.Windows.Forms.TextBox()
        Me.PatientFirstName = New System.Windows.Forms.TextBox()
        Me.PatientLastName = New System.Windows.Forms.TextBox()
        Me.PatientAddress = New System.Windows.Forms.TextBox()
        Me.PatientGender = New System.Windows.Forms.ComboBox()
        Me.PatientDOR = New System.Windows.Forms.DateTimePicker()
        Me.PatientDOB = New System.Windows.Forms.DateTimePicker()
        Me.PatientInformationReport = New System.Windows.Forms.DataGridView()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.searchPatientTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PatientSituation = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(195, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID NO : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LAST NAME : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(195, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "D. O. B :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(537, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "GENDER : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(537, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ADDRESS : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(537, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "D . O . R : "
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(931, 280)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(138, 37)
        Me.DeleteButton.TabIndex = 7
        Me.DeleteButton.Text = "DELETE "
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddRecordButton
        '
        Me.AddRecordButton.Location = New System.Drawing.Point(931, 122)
        Me.AddRecordButton.Name = "AddRecordButton"
        Me.AddRecordButton.Size = New System.Drawing.Size(138, 37)
        Me.AddRecordButton.TabIndex = 8
        Me.AddRecordButton.Text = "ADD RECORD"
        Me.AddRecordButton.UseVisualStyleBackColor = True
        '
        'PatientIDNO
        '
        Me.PatientIDNO.Location = New System.Drawing.Point(295, 126)
        Me.PatientIDNO.Name = "PatientIDNO"
        Me.PatientIDNO.Size = New System.Drawing.Size(165, 23)
        Me.PatientIDNO.TabIndex = 10
        '
        'PatientFirstName
        '
        Me.PatientFirstName.Location = New System.Drawing.Point(295, 172)
        Me.PatientFirstName.Name = "PatientFirstName"
        Me.PatientFirstName.Size = New System.Drawing.Size(165, 23)
        Me.PatientFirstName.TabIndex = 11
        '
        'PatientLastName
        '
        Me.PatientLastName.Location = New System.Drawing.Point(295, 217)
        Me.PatientLastName.Name = "PatientLastName"
        Me.PatientLastName.Size = New System.Drawing.Size(165, 23)
        Me.PatientLastName.TabIndex = 12
        '
        'PatientAddress
        '
        Me.PatientAddress.Location = New System.Drawing.Point(615, 172)
        Me.PatientAddress.Name = "PatientAddress"
        Me.PatientAddress.Size = New System.Drawing.Size(173, 23)
        Me.PatientAddress.TabIndex = 14
        '
        'PatientGender
        '
        Me.PatientGender.FormattingEnabled = True
        Me.PatientGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.PatientGender.Location = New System.Drawing.Point(615, 129)
        Me.PatientGender.Name = "PatientGender"
        Me.PatientGender.Size = New System.Drawing.Size(173, 23)
        Me.PatientGender.TabIndex = 16
        '
        'PatientDOR
        '
        Me.PatientDOR.CustomFormat = "yyyy-MM-dd"
        Me.PatientDOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PatientDOR.Location = New System.Drawing.Point(615, 214)
        Me.PatientDOR.Name = "PatientDOR"
        Me.PatientDOR.Size = New System.Drawing.Size(188, 23)
        Me.PatientDOR.TabIndex = 17
        '
        'PatientDOB
        '
        Me.PatientDOB.CustomFormat = "yyyy-MM-dd"
        Me.PatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PatientDOB.Location = New System.Drawing.Point(295, 257)
        Me.PatientDOB.Name = "PatientDOB"
        Me.PatientDOB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PatientDOB.Size = New System.Drawing.Size(195, 23)
        Me.PatientDOB.TabIndex = 18
        '
        'PatientInformationReport
        '
        Me.PatientInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientInformationReport.Location = New System.Drawing.Point(195, 357)
        Me.PatientInformationReport.Name = "PatientInformationReport"
        Me.PatientInformationReport.RowTemplate.Height = 25
        Me.PatientInformationReport.Size = New System.Drawing.Size(779, 179)
        Me.PatientInformationReport.TabIndex = 19
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(931, 220)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(138, 39)
        Me.ResetButton.TabIndex = 20
        Me.ResetButton.Text = "RESET"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(931, 172)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(138, 34)
        Me.UpdateButton.TabIndex = 21
        Me.UpdateButton.Text = "UPDATE"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'searchPatientTextBox
        '
        Me.searchPatientTextBox.Location = New System.Drawing.Point(539, 33)
        Me.searchPatientTextBox.Name = "searchPatientTextBox"
        Me.searchPatientTextBox.Size = New System.Drawing.Size(212, 23)
        Me.searchPatientTextBox.TabIndex = 78
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 15)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "SEARCH PATIENT ID : "
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1139, 23)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 79
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1036, 25)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 81
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PatientSituation
        '
        Me.PatientSituation.FormattingEnabled = True
        Me.PatientSituation.Items.AddRange(New Object() {"EMERGENCY", "SURGERY", "NORMAL"})
        Me.PatientSituation.Location = New System.Drawing.Point(615, 263)
        Me.PatientSituation.Name = "PatientSituation"
        Me.PatientSituation.Size = New System.Drawing.Size(173, 23)
        Me.PatientSituation.TabIndex = 83
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(537, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "SITUATION:"
        '
        'PatientRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 551)
        Me.Controls.Add(Me.PatientSituation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.searchPatientTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.PatientInformationReport)
        Me.Controls.Add(Me.PatientDOB)
        Me.Controls.Add(Me.PatientDOR)
        Me.Controls.Add(Me.PatientGender)
        Me.Controls.Add(Me.PatientAddress)
        Me.Controls.Add(Me.PatientLastName)
        Me.Controls.Add(Me.PatientFirstName)
        Me.Controls.Add(Me.PatientIDNO)
        Me.Controls.Add(Me.AddRecordButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientRegistrationForm"
        Me.Text = "Patient's Registration"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddRecordButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PatientDOB As DateTimePicker
    Friend WithEvents PatientDOR As DateTimePicker
    Friend WithEvents PatientGender As ComboBox
    Friend WithEvents PatientAddress As TextBox
    Friend WithEvents PatientLastName As TextBox
    Friend WithEvents PatientFirstName As TextBox
    Friend WithEvents PatientIDNO As TextBox
    Friend WithEvents PatientInformationReport As DataGridView
    Friend WithEvents ResetButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents searchPatientTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents PatientSituation As ComboBox
    Friend WithEvents Label9 As Label
End Class
