<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientProgressForm
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
        Me.PatientLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PatientFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PatientProgress = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateOfProgress = New System.Windows.Forms.DateTimePicker()
        Me.PATIENTID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.AddProgressButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchPatientProgress = New System.Windows.Forms.TextBox()
        Me.PatientProgressInformationReport = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.PatientProgressInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientLastName
        '
        Me.PatientLastName.Location = New System.Drawing.Point(266, 206)
        Me.PatientLastName.Name = "PatientLastName"
        Me.PatientLastName.ReadOnly = True
        Me.PatientLastName.Size = New System.Drawing.Size(200, 23)
        Me.PatientLastName.TabIndex = 86
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "LAST NAME : "
        '
        'PatientFirstName
        '
        Me.PatientFirstName.Location = New System.Drawing.Point(266, 154)
        Me.PatientFirstName.Name = "PatientFirstName"
        Me.PatientFirstName.ReadOnly = True
        Me.PatientFirstName.Size = New System.Drawing.Size(200, 23)
        Me.PatientFirstName.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(179, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "FIRST NAME : "
        '
        'PatientProgress
        '
        Me.PatientProgress.Location = New System.Drawing.Point(618, 103)
        Me.PatientProgress.Name = "PatientProgress"
        Me.PatientProgress.Size = New System.Drawing.Size(477, 179)
        Me.PatientProgress.TabIndex = 80
        Me.PatientProgress.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(536, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "PROGRESS : "
        '
        'DateOfProgress
        '
        Me.DateOfProgress.CustomFormat = "yyyy-MM-dd"
        Me.DateOfProgress.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfProgress.Location = New System.Drawing.Point(266, 259)
        Me.DateOfProgress.Name = "DateOfProgress"
        Me.DateOfProgress.Size = New System.Drawing.Size(200, 23)
        Me.DateOfProgress.TabIndex = 78
        '
        'PATIENTID
        '
        Me.PATIENTID.Location = New System.Drawing.Point(266, 103)
        Me.PATIENTID.Name = "PATIENTID"
        Me.PATIENTID.ReadOnly = True
        Me.PATIENTID.Size = New System.Drawing.Size(200, 23)
        Me.PATIENTID.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "DATE : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "PATIENT ID : "
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(618, 350)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(138, 38)
        Me.ResetFormButton.TabIndex = 90
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'AddProgressButton
        '
        Me.AddProgressButton.Location = New System.Drawing.Point(438, 350)
        Me.AddProgressButton.Name = "AddProgressButton"
        Me.AddProgressButton.Size = New System.Drawing.Size(138, 38)
        Me.AddProgressButton.TabIndex = 88
        Me.AddProgressButton.Text = "SUBMIT PROGRESS"
        Me.AddProgressButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(438, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "SEARCH BY ID : "
        '
        'SearchPatientProgress
        '
        Me.SearchPatientProgress.Location = New System.Drawing.Point(548, 40)
        Me.SearchPatientProgress.Name = "SearchPatientProgress"
        Me.SearchPatientProgress.Size = New System.Drawing.Size(180, 23)
        Me.SearchPatientProgress.TabIndex = 92
        '
        'PatientProgressInformationReport
        '
        Me.PatientProgressInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientProgressInformationReport.Location = New System.Drawing.Point(179, 406)
        Me.PatientProgressInformationReport.Name = "PatientProgressInformationReport"
        Me.PatientProgressInformationReport.RowTemplate.Height = 25
        Me.PatientProgressInformationReport.Size = New System.Drawing.Size(704, 177)
        Me.PatientProgressInformationReport.TabIndex = 93
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1086, 406)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(142, 33)
        Me.BackButton.TabIndex = 94
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1086, 456)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(142, 40)
        Me.ExitButton.TabIndex = 95
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PatientProgressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 585)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PatientProgressInformationReport)
        Me.Controls.Add(Me.SearchPatientProgress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.AddProgressButton)
        Me.Controls.Add(Me.PatientLastName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PatientFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PatientProgress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateOfProgress)
        Me.Controls.Add(Me.PATIENTID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientProgressForm"
        Me.Text = "PatientProgressForm"
        CType(Me.PatientProgressInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PatientFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PatientProgress As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateOfProgress As DateTimePicker
    Friend WithEvents PATIENTID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents AddProgressButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SearchPatientProgress As TextBox
    Friend WithEvents PatientProgressInformationReport As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
