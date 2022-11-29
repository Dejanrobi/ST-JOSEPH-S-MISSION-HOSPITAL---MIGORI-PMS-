<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiagnosisForm
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
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.PATIENTID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateOfDiagnosis = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatientdDiagnosis = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TreatmentRecommendation = New System.Windows.Forms.RichTextBox()
        Me.PatientFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PatientLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.PatientDiagnosisInformationReport = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SearchPatient = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.PatientDiagnosisInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(157, 445)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(159, 38)
        Me.PrevButton.TabIndex = 60
        Me.PrevButton.Text = "SUBMIT DIAGNOSIS"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'PATIENTID
        '
        Me.PATIENTID.Location = New System.Drawing.Point(244, 118)
        Me.PATIENTID.Name = "PATIENTID"
        Me.PATIENTID.ReadOnly = True
        Me.PATIENTID.Size = New System.Drawing.Size(200, 23)
        Me.PATIENTID.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "DATE : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 15)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "PATIENT ID : "
        '
        'DateOfDiagnosis
        '
        Me.DateOfDiagnosis.CustomFormat = "yyyy-MM-dd"
        Me.DateOfDiagnosis.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfDiagnosis.Location = New System.Drawing.Point(244, 239)
        Me.DateOfDiagnosis.Name = "DateOfDiagnosis"
        Me.DateOfDiagnosis.Size = New System.Drawing.Size(200, 23)
        Me.DateOfDiagnosis.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(565, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "DIAGNOSIS : "
        '
        'PatientdDiagnosis
        '
        Me.PatientdDiagnosis.Location = New System.Drawing.Point(647, 117)
        Me.PatientdDiagnosis.Name = "PatientdDiagnosis"
        Me.PatientdDiagnosis.Size = New System.Drawing.Size(477, 157)
        Me.PatientdDiagnosis.TabIndex = 65
        Me.PatientdDiagnosis.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(449, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "TREATMENT RECOMMENDATION : "
        '
        'TreatmentRecommendation
        '
        Me.TreatmentRecommendation.Location = New System.Drawing.Point(647, 305)
        Me.TreatmentRecommendation.Name = "TreatmentRecommendation"
        Me.TreatmentRecommendation.Size = New System.Drawing.Size(477, 200)
        Me.TreatmentRecommendation.TabIndex = 67
        Me.TreatmentRecommendation.Text = ""
        '
        'PatientFirstName
        '
        Me.PatientFirstName.Location = New System.Drawing.Point(244, 157)
        Me.PatientFirstName.Name = "PatientFirstName"
        Me.PatientFirstName.ReadOnly = True
        Me.PatientFirstName.Size = New System.Drawing.Size(200, 23)
        Me.PatientFirstName.TabIndex = 69
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "FIRST NAME : "
        '
        'PatientLastName
        '
        Me.PatientLastName.Location = New System.Drawing.Point(244, 195)
        Me.PatientLastName.Name = "PatientLastName"
        Me.PatientLastName.ReadOnly = True
        Me.PatientLastName.Size = New System.Drawing.Size(200, 23)
        Me.PatientLastName.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "LAST NAME : "
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(355, 444)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(154, 41)
        Me.ResetFormButton.TabIndex = 72
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'PatientDiagnosisInformationReport
        '
        Me.PatientDiagnosisInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDiagnosisInformationReport.Location = New System.Drawing.Point(157, 528)
        Me.PatientDiagnosisInformationReport.Name = "PatientDiagnosisInformationReport"
        Me.PatientDiagnosisInformationReport.RowTemplate.Height = 25
        Me.PatientDiagnosisInformationReport.Size = New System.Drawing.Size(873, 151)
        Me.PatientDiagnosisInformationReport.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 15)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "SEARCH BY ID : "
        '
        'SearchPatient
        '
        Me.SearchPatient.Location = New System.Drawing.Point(534, 32)
        Me.SearchPatient.Name = "SearchPatient"
        Me.SearchPatient.Size = New System.Drawing.Size(197, 23)
        Me.SearchPatient.TabIndex = 75
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1145, 22)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 76
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1045, 22)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(74, 37)
        Me.BackButton.TabIndex = 77
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DiagnosisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 691)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SearchPatient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PatientDiagnosisInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.PatientLastName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PatientFirstName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TreatmentRecommendation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientdDiagnosis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateOfDiagnosis)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.PATIENTID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DiagnosisForm"
        Me.Text = "DiagnosisForm"
        CType(Me.PatientDiagnosisInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrevButton As Button
    Friend WithEvents PATIENTID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateOfDiagnosis As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents PatientdDiagnosis As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TreatmentRecommendation As RichTextBox
    Friend WithEvents PatientFirstName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PatientLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents PatientDiagnosisInformationReport As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents SearchPatient As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
End Class
