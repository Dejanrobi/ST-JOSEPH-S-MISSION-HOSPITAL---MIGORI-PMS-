<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientDiagnosisReport
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
        Me.DiagnosisTextBox = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PatientID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PatientDiagnosisFinal = New System.Windows.Forms.DataGridView()
        Me.SearchPatientsID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TreatmentRecommendation = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PatientDiagnosisFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DiagnosisTextBox
        '
        Me.DiagnosisTextBox.Location = New System.Drawing.Point(786, 178)
        Me.DiagnosisTextBox.Name = "DiagnosisTextBox"
        Me.DiagnosisTextBox.ReadOnly = True
        Me.DiagnosisTextBox.Size = New System.Drawing.Size(383, 181)
        Me.DiagnosisTextBox.TabIndex = 111
        Me.DiagnosisTextBox.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(662, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 15)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "PATIENT DIAGNOSIS:"
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(218, 281)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(199, 23)
        Me.LastName.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "LAST NAME:"
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(218, 233)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(199, 23)
        Me.FirstName.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "FIRST NAME:"
        '
        'PatientID
        '
        Me.PatientID.Location = New System.Drawing.Point(218, 182)
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Size = New System.Drawing.Size(199, 23)
        Me.PatientID.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "PATIENT ID:"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1039, 93)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 103
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(879, 93)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 102
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PatientDiagnosisFinal
        '
        Me.PatientDiagnosisFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDiagnosisFinal.Location = New System.Drawing.Point(137, 375)
        Me.PatientDiagnosisFinal.Name = "PatientDiagnosisFinal"
        Me.PatientDiagnosisFinal.RowTemplate.Height = 25
        Me.PatientDiagnosisFinal.Size = New System.Drawing.Size(419, 285)
        Me.PatientDiagnosisFinal.TabIndex = 101
        '
        'SearchPatientsID
        '
        Me.SearchPatientsID.Location = New System.Drawing.Point(510, 110)
        Me.SearchPatientsID.Name = "SearchPatientsID"
        Me.SearchPatientsID.Size = New System.Drawing.Size(219, 23)
        Me.SearchPatientsID.TabIndex = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "SEARCH PATIENTS ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(470, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 30)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "PATIENT DIAGNOSIS REPORT"
        '
        'TreatmentRecommendation
        '
        Me.TreatmentRecommendation.Location = New System.Drawing.Point(786, 388)
        Me.TreatmentRecommendation.Name = "TreatmentRecommendation"
        Me.TreatmentRecommendation.ReadOnly = True
        Me.TreatmentRecommendation.Size = New System.Drawing.Size(383, 181)
        Me.TreatmentRecommendation.TabIndex = 113
        Me.TreatmentRecommendation.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(588, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 15)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "TREATMENT RECOMMENDATION:"
        '
        'PatientDiagnosisReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 697)
        Me.Controls.Add(Me.TreatmentRecommendation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DiagnosisTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PatientDiagnosisFinal)
        Me.Controls.Add(Me.SearchPatientsID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientDiagnosisReport"
        Me.Text = "PatientDiagnosisReport"
        CType(Me.PatientDiagnosisFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DiagnosisTextBox As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PatientID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents PatientDiagnosisFinal As DataGridView
    Friend WithEvents SearchPatientsID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TreatmentRecommendation As RichTextBox
    Friend WithEvents Label7 As Label
End Class
