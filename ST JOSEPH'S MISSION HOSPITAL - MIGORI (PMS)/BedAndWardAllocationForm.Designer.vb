<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BedAndWardAllocationForm
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
        Me.ReallocatePatientButton = New System.Windows.Forms.Button()
        Me.PatientIDNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.BedAndWardAllocationInformationReport = New System.Windows.Forms.DataGridView()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WardNO = New System.Windows.Forms.ComboBox()
        Me.BedNO = New System.Windows.Forms.ComboBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.BedAndWardAllocationInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReallocatePatientButton
        '
        Me.ReallocatePatientButton.Location = New System.Drawing.Point(999, 117)
        Me.ReallocatePatientButton.Name = "ReallocatePatientButton"
        Me.ReallocatePatientButton.Size = New System.Drawing.Size(142, 37)
        Me.ReallocatePatientButton.TabIndex = 53
        Me.ReallocatePatientButton.Text = "ALLOCATE PATIENT"
        Me.ReallocatePatientButton.UseVisualStyleBackColor = True
        '
        'PatientIDNO
        '
        Me.PatientIDNO.Location = New System.Drawing.Point(364, 119)
        Me.PatientIDNO.Name = "PatientIDNO"
        Me.PatientIDNO.ReadOnly = True
        Me.PatientIDNO.Size = New System.Drawing.Size(167, 23)
        Me.PatientIDNO.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "PATIENT'S ID : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(560, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "WARD NO : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(560, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "BED NO : "
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(999, 179)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(142, 33)
        Me.ResetFormButton.TabIndex = 58
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'BedAndWardAllocationInformationReport
        '
        Me.BedAndWardAllocationInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedAndWardAllocationInformationReport.Location = New System.Drawing.Point(276, 311)
        Me.BedAndWardAllocationInformationReport.Name = "BedAndWardAllocationInformationReport"
        Me.BedAndWardAllocationInformationReport.RowTemplate.Height = 25
        Me.BedAndWardAllocationInformationReport.Size = New System.Drawing.Size(537, 261)
        Me.BedAndWardAllocationInformationReport.TabIndex = 59
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(364, 178)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(167, 23)
        Me.FirstName.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(276, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "FIRST NAME : "
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(364, 230)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(167, 23)
        Me.LastName.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "LAST NAME :"
        '
        'WardNO
        '
        Me.WardNO.FormattingEnabled = True
        Me.WardNO.Location = New System.Drawing.Point(646, 119)
        Me.WardNO.Name = "WardNO"
        Me.WardNO.Size = New System.Drawing.Size(167, 23)
        Me.WardNO.TabIndex = 64
        '
        'BedNO
        '
        Me.BedNO.FormattingEnabled = True
        Me.BedNO.Location = New System.Drawing.Point(646, 179)
        Me.BedNO.Name = "BedNO"
        Me.BedNO.Size = New System.Drawing.Size(167, 23)
        Me.BedNO.TabIndex = 65
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(999, 368)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(142, 33)
        Me.BackButton.TabIndex = 66
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(999, 424)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(142, 40)
        Me.ExitButton.TabIndex = 67
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BedAndWardAllocationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1321, 572)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.BedNO)
        Me.Controls.Add(Me.WardNO)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BedAndWardAllocationInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ReallocatePatientButton)
        Me.Controls.Add(Me.PatientIDNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BedAndWardAllocationForm"
        Me.Text = "BedAndWardAllocationForm"
        CType(Me.BedAndWardAllocationInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReallocatePatientButton As Button
    Friend WithEvents PatientIDNO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents BedAndWardAllocationInformationReport As DataGridView
    Friend WithEvents FirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents WardNO As ComboBox
    Friend WithEvents BedNO As ComboBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
