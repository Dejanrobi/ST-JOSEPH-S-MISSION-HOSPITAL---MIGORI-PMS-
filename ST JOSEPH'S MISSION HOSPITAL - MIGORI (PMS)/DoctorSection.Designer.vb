<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorSection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DiagnoseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AllocatedPatients = New System.Windows.Forms.Button()
        Me.PatientProgress = New System.Windows.Forms.Button()
        Me.CheckPatientDiagnosis = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AllocatedSurgeries = New System.Windows.Forms.Button()
        Me.AllocatedEmergencies = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(384, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLEASE SELECT THE TASK THAT YOU WANT TO PERFORM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "TASK"
        '
        'DiagnoseButton
        '
        Me.DiagnoseButton.Location = New System.Drawing.Point(172, 233)
        Me.DiagnoseButton.Name = "DiagnoseButton"
        Me.DiagnoseButton.Size = New System.Drawing.Size(202, 38)
        Me.DiagnoseButton.TabIndex = 2
        Me.DiagnoseButton.Text = "DIAGNOSE PATIENT"
        Me.DiagnoseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(582, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "REPORTS"
        '
        'AllocatedPatients
        '
        Me.AllocatedPatients.Location = New System.Drawing.Point(502, 233)
        Me.AllocatedPatients.Name = "AllocatedPatients"
        Me.AllocatedPatients.Size = New System.Drawing.Size(233, 38)
        Me.AllocatedPatients.TabIndex = 4
        Me.AllocatedPatients.Text = "CHECK ALLOCATED PATIENTS"
        Me.AllocatedPatients.UseVisualStyleBackColor = True
        '
        'PatientProgress
        '
        Me.PatientProgress.Location = New System.Drawing.Point(502, 294)
        Me.PatientProgress.Name = "PatientProgress"
        Me.PatientProgress.Size = New System.Drawing.Size(233, 38)
        Me.PatientProgress.TabIndex = 5
        Me.PatientProgress.Text = "CHECK PATIENT PROGRESS"
        Me.PatientProgress.UseVisualStyleBackColor = True
        '
        'CheckPatientDiagnosis
        '
        Me.CheckPatientDiagnosis.Location = New System.Drawing.Point(502, 356)
        Me.CheckPatientDiagnosis.Name = "CheckPatientDiagnosis"
        Me.CheckPatientDiagnosis.Size = New System.Drawing.Size(233, 38)
        Me.CheckPatientDiagnosis.TabIndex = 6
        Me.CheckPatientDiagnosis.Text = "CHECK PATIENT DIAGNOSIS"
        Me.CheckPatientDiagnosis.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1001, 510)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(138, 38)
        Me.BackButton.TabIndex = 7
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(947, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "SPECIAL SITUATIONS"
        '
        'AllocatedSurgeries
        '
        Me.AllocatedSurgeries.Location = New System.Drawing.Point(884, 233)
        Me.AllocatedSurgeries.Name = "AllocatedSurgeries"
        Me.AllocatedSurgeries.Size = New System.Drawing.Size(233, 38)
        Me.AllocatedSurgeries.TabIndex = 9
        Me.AllocatedSurgeries.Text = "CHECK ALLOCATED SURGERIES"
        Me.AllocatedSurgeries.UseVisualStyleBackColor = True
        '
        'AllocatedEmergencies
        '
        Me.AllocatedEmergencies.Location = New System.Drawing.Point(884, 294)
        Me.AllocatedEmergencies.Name = "AllocatedEmergencies"
        Me.AllocatedEmergencies.Size = New System.Drawing.Size(233, 38)
        Me.AllocatedEmergencies.TabIndex = 10
        Me.AllocatedEmergencies.Text = "CHECK ALLOCATED EMERGENCIES"
        Me.AllocatedEmergencies.UseVisualStyleBackColor = True
        '
        'DoctorSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 599)
        Me.Controls.Add(Me.AllocatedEmergencies)
        Me.Controls.Add(Me.AllocatedSurgeries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.CheckPatientDiagnosis)
        Me.Controls.Add(Me.PatientProgress)
        Me.Controls.Add(Me.AllocatedPatients)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DiagnoseButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DoctorSection"
        Me.Text = "DoctorSection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DiagnoseButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents AllocatedPatients As Button
    Friend WithEvents PatientProgress As Button
    Friend WithEvents CheckPatientDiagnosis As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents AllocatedSurgeries As Button
    Friend WithEvents AllocatedEmergencies As Button
End Class
