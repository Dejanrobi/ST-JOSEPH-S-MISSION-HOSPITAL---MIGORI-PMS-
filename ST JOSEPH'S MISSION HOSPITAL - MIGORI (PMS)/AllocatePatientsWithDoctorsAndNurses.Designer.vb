<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllocatePatientsWithDoctorsAndNurses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatientIDNO = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateOfAllocation = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DoctorID = New System.Windows.Forms.ComboBox()
        Me.NurseID = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AllocatePatientButton = New System.Windows.Forms.Button()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.PatientDoctorNurseAllocationInformation = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.PatientDoctorNurseAllocationInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT ID : "
        '
        'PatientIDNO
        '
        Me.PatientIDNO.Location = New System.Drawing.Point(272, 119)
        Me.PatientIDNO.Name = "PatientIDNO"
        Me.PatientIDNO.ReadOnly = True
        Me.PatientIDNO.Size = New System.Drawing.Size(171, 23)
        Me.PatientIDNO.TabIndex = 1
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(272, 162)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(171, 23)
        Me.FirstName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "FIRST NAME :"
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(272, 208)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(171, 23)
        Me.LastName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "LAST NAME :"
        '
        'DateOfAllocation
        '
        Me.DateOfAllocation.CustomFormat = "yyyy-MM-dd"
        Me.DateOfAllocation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfAllocation.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DateOfAllocation.Location = New System.Drawing.Point(272, 259)
        Me.DateOfAllocation.Name = "DateOfAllocation"
        Me.DateOfAllocation.Size = New System.Drawing.Size(171, 23)
        Me.DateOfAllocation.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DATE : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(516, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "DOCTOR'S ID :"
        '
        'DoctorID
        '
        Me.DoctorID.FormattingEnabled = True
        Me.DoctorID.Location = New System.Drawing.Point(604, 119)
        Me.DoctorID.Name = "DoctorID"
        Me.DoctorID.Size = New System.Drawing.Size(173, 23)
        Me.DoctorID.TabIndex = 9
        '
        'NurseID
        '
        Me.NurseID.FormattingEnabled = True
        Me.NurseID.Location = New System.Drawing.Point(604, 162)
        Me.NurseID.Name = "NurseID"
        Me.NurseID.Size = New System.Drawing.Size(173, 23)
        Me.NurseID.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(516, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "NURSE'S ID :"
        '
        'AllocatePatientButton
        '
        Me.AllocatePatientButton.Location = New System.Drawing.Point(980, 115)
        Me.AllocatePatientButton.Name = "AllocatePatientButton"
        Me.AllocatePatientButton.Size = New System.Drawing.Size(128, 42)
        Me.AllocatePatientButton.TabIndex = 12
        Me.AllocatePatientButton.Text = "ALLOCATE PATIENT"
        Me.AllocatePatientButton.UseVisualStyleBackColor = True
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(980, 196)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(128, 42)
        Me.ResetFormButton.TabIndex = 13
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'PatientDoctorNurseAllocationInformation
        '
        Me.PatientDoctorNurseAllocationInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDoctorNurseAllocationInformation.Location = New System.Drawing.Point(197, 401)
        Me.PatientDoctorNurseAllocationInformation.Name = "PatientDoctorNurseAllocationInformation"
        Me.PatientDoctorNurseAllocationInformation.RowTemplate.Height = 25
        Me.PatientDoctorNurseAllocationInformation.Size = New System.Drawing.Size(685, 199)
        Me.PatientDoctorNurseAllocationInformation.TabIndex = 14
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(980, 38)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(128, 37)
        Me.BackButton.TabIndex = 83
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1125, 38)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 40)
        Me.ExitButton.TabIndex = 82
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'AllocatePatientsWithDoctorsAndNurses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 602)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PatientDoctorNurseAllocationInformation)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.AllocatePatientButton)
        Me.Controls.Add(Me.NurseID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DoctorID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateOfAllocation)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PatientIDNO)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AllocatePatientsWithDoctorsAndNurses"
        Me.Text = "AllocatePatientsWithDoctorsAndNurses"
        CType(Me.PatientDoctorNurseAllocationInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PatientIDNO As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateOfAllocation As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DoctorID As ComboBox
    Friend WithEvents NurseID As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AllocatePatientButton As Button
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents PatientDoctorNurseAllocationInformation As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
