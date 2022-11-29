<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AssignEmergencies
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PatientId = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.DoctorID = New System.Windows.Forms.ComboBox()
        Me.NurseId = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmergencyAllocationReport = New System.Windows.Forms.DataGridView()
        Me.PatientSituation = New System.Windows.Forms.TextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.EmergencyAllocationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FIRST NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LAST NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(562, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SITUTATION:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(562, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "DOCTOR ID:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(562, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NURSE ID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PatientId
        '
        Me.PatientId.Location = New System.Drawing.Point(318, 93)
        Me.PatientId.Name = "PatientId"
        Me.PatientId.ReadOnly = True
        Me.PatientId.Size = New System.Drawing.Size(200, 23)
        Me.PatientId.TabIndex = 6
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(318, 155)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(200, 23)
        Me.FirstName.TabIndex = 7
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(318, 222)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(200, 23)
        Me.LastName.TabIndex = 8
        '
        'DoctorID
        '
        Me.DoctorID.FormattingEnabled = True
        Me.DoctorID.Location = New System.Drawing.Point(640, 155)
        Me.DoctorID.Name = "DoctorID"
        Me.DoctorID.Size = New System.Drawing.Size(200, 23)
        Me.DoctorID.TabIndex = 10
        '
        'NurseId
        '
        Me.NurseId.FormattingEnabled = True
        Me.NurseId.Location = New System.Drawing.Point(640, 227)
        Me.NurseId.Name = "NurseId"
        Me.NurseId.Size = New System.Drawing.Size(200, 23)
        Me.NurseId.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(968, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 40)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "ASSIGN EMERGENCY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EmergencyAllocationReport
        '
        Me.EmergencyAllocationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmergencyAllocationReport.Location = New System.Drawing.Point(216, 361)
        Me.EmergencyAllocationReport.Name = "EmergencyAllocationReport"
        Me.EmergencyAllocationReport.RowTemplate.Height = 25
        Me.EmergencyAllocationReport.Size = New System.Drawing.Size(624, 227)
        Me.EmergencyAllocationReport.TabIndex = 13
        '
        'PatientSituation
        '
        Me.PatientSituation.Location = New System.Drawing.Point(640, 98)
        Me.PatientSituation.Name = "PatientSituation"
        Me.PatientSituation.ReadOnly = True
        Me.PatientSituation.Size = New System.Drawing.Size(200, 23)
        Me.PatientSituation.TabIndex = 14
        Me.PatientSituation.Text = "EMERGENCY"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(968, 26)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 85
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1081, 26)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 84
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'AssignEmergencies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 590)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PatientSituation)
        Me.Controls.Add(Me.EmergencyAllocationReport)
        Me.Controls.Add(Me.Button1)
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
        Me.Name = "AssignEmergencies"
        Me.Text = "AssignEmergencies"
        CType(Me.EmergencyAllocationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PatientId As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents DoctorID As ComboBox
    Friend WithEvents NurseId As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EmergencyAllocationReport As DataGridView
    Friend WithEvents PatientSituation As TextBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
