<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorRegistrationForm
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
        Me.DoctorDOB = New System.Windows.Forms.DateTimePicker()
        Me.DoctorDOR = New System.Windows.Forms.DateTimePicker()
        Me.DoctorGender = New System.Windows.Forms.ComboBox()
        Me.DoctorAddress = New System.Windows.Forms.TextBox()
        Me.DoctorLastName = New System.Windows.Forms.TextBox()
        Me.DoctorFirstName = New System.Windows.Forms.TextBox()
        Me.DoctorIDNO = New System.Windows.Forms.TextBox()
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
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.DoctorsInformationReport = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorsInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DoctorDOB
        '
        Me.DoctorDOB.CustomFormat = "yyyy-MM-dd"
        Me.DoctorDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DoctorDOB.Location = New System.Drawing.Point(288, 239)
        Me.DoctorDOB.Name = "DoctorDOB"
        Me.DoctorDOB.Size = New System.Drawing.Size(195, 23)
        Me.DoctorDOB.TabIndex = 35
        '
        'DoctorDOR
        '
        Me.DoctorDOR.CustomFormat = "yyyy-MM-dd"
        Me.DoctorDOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DoctorDOR.Location = New System.Drawing.Point(608, 196)
        Me.DoctorDOR.Name = "DoctorDOR"
        Me.DoctorDOR.Size = New System.Drawing.Size(188, 23)
        Me.DoctorDOR.TabIndex = 34
        '
        'DoctorGender
        '
        Me.DoctorGender.FormattingEnabled = True
        Me.DoctorGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.DoctorGender.Location = New System.Drawing.Point(608, 111)
        Me.DoctorGender.Name = "DoctorGender"
        Me.DoctorGender.Size = New System.Drawing.Size(173, 23)
        Me.DoctorGender.TabIndex = 33
        '
        'DoctorAddress
        '
        Me.DoctorAddress.Location = New System.Drawing.Point(608, 154)
        Me.DoctorAddress.Name = "DoctorAddress"
        Me.DoctorAddress.Size = New System.Drawing.Size(173, 23)
        Me.DoctorAddress.TabIndex = 32
        '
        'DoctorLastName
        '
        Me.DoctorLastName.Location = New System.Drawing.Point(288, 199)
        Me.DoctorLastName.Name = "DoctorLastName"
        Me.DoctorLastName.Size = New System.Drawing.Size(165, 23)
        Me.DoctorLastName.TabIndex = 31
        '
        'DoctorFirstName
        '
        Me.DoctorFirstName.Location = New System.Drawing.Point(288, 154)
        Me.DoctorFirstName.Name = "DoctorFirstName"
        Me.DoctorFirstName.Size = New System.Drawing.Size(165, 23)
        Me.DoctorFirstName.TabIndex = 30
        '
        'DoctorIDNO
        '
        Me.DoctorIDNO.Location = New System.Drawing.Point(288, 108)
        Me.DoctorIDNO.Name = "DoctorIDNO"
        Me.DoctorIDNO.Size = New System.Drawing.Size(165, 23)
        Me.DoctorIDNO.TabIndex = 29
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(1016, 206)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(130, 37)
        Me.DeleteButton.TabIndex = 28
        Me.DeleteButton.Text = "DELETE RECORD"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'AddRecordButton
        '
        Me.AddRecordButton.Location = New System.Drawing.Point(1016, 106)
        Me.AddRecordButton.Name = "AddRecordButton"
        Me.AddRecordButton.Size = New System.Drawing.Size(130, 39)
        Me.AddRecordButton.TabIndex = 27
        Me.AddRecordButton.Text = "ADD RECORD"
        Me.AddRecordButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(1016, 156)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(130, 38)
        Me.UpdateButton.TabIndex = 26
        Me.UpdateButton.Text = "UPDATE RECORD"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(530, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "D . O . R : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(530, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ADDRESS : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(530, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "GENDER : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "D. O. B :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "LAST NAME : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "FIRST NAME : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID NO : "
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(1016, 249)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(130, 40)
        Me.ResetFormButton.TabIndex = 36
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'DoctorsInformationReport
        '
        Me.DoctorsInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorsInformationReport.Location = New System.Drawing.Point(188, 354)
        Me.DoctorsInformationReport.Name = "DoctorsInformationReport"
        Me.DoctorsInformationReport.RowTemplate.Height = 25
        Me.DoctorsInformationReport.Size = New System.Drawing.Size(608, 194)
        Me.DoctorsInformationReport.TabIndex = 37
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1016, 354)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 38
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1016, 414)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 81
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DoctorRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 591)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DoctorsInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.DoctorDOB)
        Me.Controls.Add(Me.DoctorDOR)
        Me.Controls.Add(Me.DoctorGender)
        Me.Controls.Add(Me.DoctorAddress)
        Me.Controls.Add(Me.DoctorLastName)
        Me.Controls.Add(Me.DoctorFirstName)
        Me.Controls.Add(Me.DoctorIDNO)
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
        Me.Name = "DoctorRegistrationForm"
        Me.Text = "Doctor's Registration"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorsInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DoctorDOB As DateTimePicker
    Friend WithEvents DoctorDOR As DateTimePicker
    Friend WithEvents DoctorGender As ComboBox
    Friend WithEvents DoctorAddress As TextBox
    Friend WithEvents DoctorLastName As TextBox
    Friend WithEvents DoctorFirstName As TextBox
    Friend WithEvents DoctorIDNO As TextBox
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
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents DoctorsInformationReport As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
