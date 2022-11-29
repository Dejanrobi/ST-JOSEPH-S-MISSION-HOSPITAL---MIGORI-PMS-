<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckoutPatient
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
        Me.SearchPatientBox = New System.Windows.Forms.TextBox()
        Me.PatientClearanceData = New System.Windows.Forms.DataGridView()
        Me.PatientId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PatientsFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PatientsLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AmountPaid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PatientBalance = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TotalBill = New System.Windows.Forms.TextBox()
        CType(Me.PatientClearanceData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(367, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SEARCH PATIENT BY ID :"
        '
        'SearchPatientBox
        '
        Me.SearchPatientBox.Location = New System.Drawing.Point(520, 46)
        Me.SearchPatientBox.Name = "SearchPatientBox"
        Me.SearchPatientBox.Size = New System.Drawing.Size(177, 23)
        Me.SearchPatientBox.TabIndex = 1
        '
        'PatientClearanceData
        '
        Me.PatientClearanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientClearanceData.Location = New System.Drawing.Point(210, 379)
        Me.PatientClearanceData.Name = "PatientClearanceData"
        Me.PatientClearanceData.RowTemplate.Height = 25
        Me.PatientClearanceData.Size = New System.Drawing.Size(646, 154)
        Me.PatientClearanceData.TabIndex = 2
        '
        'PatientId
        '
        Me.PatientId.Location = New System.Drawing.Point(299, 170)
        Me.PatientId.Name = "PatientId"
        Me.PatientId.ReadOnly = True
        Me.PatientId.Size = New System.Drawing.Size(177, 23)
        Me.PatientId.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PATIENT ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FIRST NAME:"
        '
        'PatientsFirstName
        '
        Me.PatientsFirstName.Location = New System.Drawing.Point(299, 215)
        Me.PatientsFirstName.Name = "PatientsFirstName"
        Me.PatientsFirstName.ReadOnly = True
        Me.PatientsFirstName.Size = New System.Drawing.Size(177, 23)
        Me.PatientsFirstName.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "LAST NAME:"
        '
        'PatientsLastName
        '
        Me.PatientsLastName.Location = New System.Drawing.Point(299, 258)
        Me.PatientsLastName.Name = "PatientsLastName"
        Me.PatientsLastName.ReadOnly = True
        Me.PatientsLastName.Size = New System.Drawing.Size(177, 23)
        Me.PatientsLastName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "AMOUNT PAID:"
        '
        'AmountPaid
        '
        Me.AmountPaid.Location = New System.Drawing.Point(606, 215)
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.ReadOnly = True
        Me.AmountPaid.Size = New System.Drawing.Size(177, 23)
        Me.AmountPaid.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(520, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "BALANCE :"
        '
        'PatientBalance
        '
        Me.PatientBalance.Location = New System.Drawing.Point(606, 261)
        Me.PatientBalance.Name = "PatientBalance"
        Me.PatientBalance.ReadOnly = True
        Me.PatientBalance.Size = New System.Drawing.Size(177, 23)
        Me.PatientBalance.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(964, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "CLEAR PATIENT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(964, 29)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 83
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1077, 29)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 82
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(520, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "TOTAL BILL:"
        '
        'TotalBill
        '
        Me.TotalBill.Location = New System.Drawing.Point(606, 170)
        Me.TotalBill.Name = "TotalBill"
        Me.TotalBill.ReadOnly = True
        Me.TotalBill.Size = New System.Drawing.Size(177, 23)
        Me.TotalBill.TabIndex = 84
        '
        'CheckoutPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 560)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalBill)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PatientBalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AmountPaid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PatientsLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PatientsFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PatientId)
        Me.Controls.Add(Me.PatientClearanceData)
        Me.Controls.Add(Me.SearchPatientBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckoutPatient"
        Me.Text = "CheckoutPatient"
        CType(Me.PatientClearanceData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SearchPatientBox As TextBox
    Friend WithEvents PatientClearanceData As DataGridView
    Friend WithEvents PatientId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PatientsFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PatientsLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AmountPaid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PatientBalance As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TotalBill As TextBox
End Class
