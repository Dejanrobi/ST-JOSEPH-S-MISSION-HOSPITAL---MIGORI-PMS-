<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignSurgery
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PatientSituation = New System.Windows.Forms.TextBox()
        Me.SurgeryAllocationReport = New System.Windows.Forms.DataGridView()
        Me.NurseId = New System.Windows.Forms.ComboBox()
        Me.DoctorID = New System.Windows.Forms.ComboBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.PatientId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SurgeryAllocationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(987, 42)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 101
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1100, 42)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 100
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PatientSituation
        '
        Me.PatientSituation.Location = New System.Drawing.Point(658, 139)
        Me.PatientSituation.Name = "PatientSituation"
        Me.PatientSituation.ReadOnly = True
        Me.PatientSituation.Size = New System.Drawing.Size(200, 23)
        Me.PatientSituation.TabIndex = 99
        Me.PatientSituation.Text = "SURGERY"
        '
        'SurgeryAllocationReport
        '
        Me.SurgeryAllocationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SurgeryAllocationReport.Location = New System.Drawing.Point(232, 364)
        Me.SurgeryAllocationReport.Name = "SurgeryAllocationReport"
        Me.SurgeryAllocationReport.RowTemplate.Height = 25
        Me.SurgeryAllocationReport.Size = New System.Drawing.Size(609, 185)
        Me.SurgeryAllocationReport.TabIndex = 98
        '
        'NurseId
        '
        Me.NurseId.FormattingEnabled = True
        Me.NurseId.Location = New System.Drawing.Point(658, 256)
        Me.NurseId.Name = "NurseId"
        Me.NurseId.Size = New System.Drawing.Size(200, 23)
        Me.NurseId.TabIndex = 96
        '
        'DoctorID
        '
        Me.DoctorID.FormattingEnabled = True
        Me.DoctorID.Location = New System.Drawing.Point(658, 194)
        Me.DoctorID.Name = "DoctorID"
        Me.DoctorID.Size = New System.Drawing.Size(200, 23)
        Me.DoctorID.TabIndex = 95
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(336, 251)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(200, 23)
        Me.LastName.TabIndex = 94
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(336, 194)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(200, 23)
        Me.FirstName.TabIndex = 93
        '
        'PatientId
        '
        Me.PatientId.Location = New System.Drawing.Point(336, 134)
        Me.PatientId.Name = "PatientId"
        Me.PatientId.ReadOnly = True
        Me.PatientId.Size = New System.Drawing.Size(200, 23)
        Me.PatientId.TabIndex = 92
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "NURSE ID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "DOCTOR ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "SITUTATION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "LAST NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "FIRST NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "PATIENT ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(987, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 40)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "ASSIGN SURGERY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AssignSurgery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 569)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PatientSituation)
        Me.Controls.Add(Me.SurgeryAllocationReport)
        Me.Controls.Add(Me.NurseId)
        Me.Controls.Add(Me.DoctorID)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.PatientId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AssignSurgery"
        Me.Text = "AssignSurgery"
        CType(Me.SurgeryAllocationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PatientSituation As TextBox
    Friend WithEvents SurgeryAllocationReport As DataGridView
    Friend WithEvents NurseId As ComboBox
    Friend WithEvents DoctorID As ComboBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents PatientId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
