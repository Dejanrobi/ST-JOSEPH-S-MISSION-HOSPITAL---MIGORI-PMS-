<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientAccountDetailsReport
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
        Me.SearchPatientByID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PatientAccountsInformationReport = New System.Windows.Forms.DataGridView()
        CType(Me.PatientAccountsInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(862, 61)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 86
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(970, 59)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 85
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SearchPatientByID
        '
        Me.SearchPatientByID.Location = New System.Drawing.Point(505, 69)
        Me.SearchPatientByID.Name = "SearchPatientByID"
        Me.SearchPatientByID.Size = New System.Drawing.Size(175, 23)
        Me.SearchPatientByID.TabIndex = 84
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "SEARCH PATIENT BY ID :"
        '
        'PatientAccountsInformationReport
        '
        Me.PatientAccountsInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientAccountsInformationReport.Location = New System.Drawing.Point(112, 150)
        Me.PatientAccountsInformationReport.Name = "PatientAccountsInformationReport"
        Me.PatientAccountsInformationReport.RowTemplate.Height = 25
        Me.PatientAccountsInformationReport.Size = New System.Drawing.Size(1029, 452)
        Me.PatientAccountsInformationReport.TabIndex = 87
        '
        'PatientAccountDetailsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 614)
        Me.Controls.Add(Me.PatientAccountsInformationReport)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SearchPatientByID)
        Me.Controls.Add(Me.Label7)
        Me.Name = "PatientAccountDetailsReport"
        Me.Text = "PatientAccountDetailsReport"
        CType(Me.PatientAccountsInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SearchPatientByID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PatientAccountsInformationReport As DataGridView
End Class
