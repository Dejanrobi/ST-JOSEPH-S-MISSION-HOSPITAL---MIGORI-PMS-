<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientProgressFinalReport
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.PatientProgressReport = New System.Windows.Forms.DataGridView()
        Me.SearchPatientsID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatientID = New System.Windows.Forms.TextBox()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressTextBox = New System.Windows.Forms.RichTextBox()
        CType(Me.PatientProgressReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1092, 68)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 89
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(932, 68)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 88
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'PatientProgressReport
        '
        Me.PatientProgressReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientProgressReport.Location = New System.Drawing.Point(329, 357)
        Me.PatientProgressReport.Name = "PatientProgressReport"
        Me.PatientProgressReport.RowTemplate.Height = 25
        Me.PatientProgressReport.Size = New System.Drawing.Size(610, 285)
        Me.PatientProgressReport.TabIndex = 87
        '
        'SearchPatientsID
        '
        Me.SearchPatientsID.Location = New System.Drawing.Point(563, 85)
        Me.SearchPatientsID.Name = "SearchPatientsID"
        Me.SearchPatientsID.Size = New System.Drawing.Size(219, 23)
        Me.SearchPatientsID.TabIndex = 86
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(423, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 15)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "SEARCH PATIENTS ID: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(552, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 30)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "PATIENT PROGRESS REPORT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "PATIENT ID:"
        '
        'PatientID
        '
        Me.PatientID.Location = New System.Drawing.Point(410, 156)
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Size = New System.Drawing.Size(199, 23)
        Me.PatientID.TabIndex = 91
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(410, 207)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(199, 23)
        Me.FirstName.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(329, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "FIRST NAME:"
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(410, 255)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(199, 23)
        Me.LastName.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(329, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "LAST NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(715, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "PATIENT PROGRESS:"
        '
        'ProgressTextBox
        '
        Me.ProgressTextBox.Location = New System.Drawing.Point(839, 153)
        Me.ProgressTextBox.Name = "ProgressTextBox"
        Me.ProgressTextBox.ReadOnly = True
        Me.ProgressTextBox.Size = New System.Drawing.Size(383, 181)
        Me.ProgressTextBox.TabIndex = 97
        Me.ProgressTextBox.Text = ""
        '
        'PatientProgressFinalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 649)
        Me.Controls.Add(Me.ProgressTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PatientProgressReport)
        Me.Controls.Add(Me.SearchPatientsID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PatientProgressFinalReport"
        Me.Text = "PatientProgress"
        CType(Me.PatientProgressReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents PatientProgressReport As DataGridView
    Friend WithEvents SearchPatientsID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PatientID As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ProgressTextBox As RichTextBox
End Class
