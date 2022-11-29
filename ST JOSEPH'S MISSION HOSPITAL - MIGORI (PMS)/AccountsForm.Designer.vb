<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsForm
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
        Me.PatientID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.TextBox()
        Me.LastName = New System.Windows.Forms.TextBox()
        Me.PatientTotalCost = New System.Windows.Forms.TextBox()
        Me.PatientAccountsInformationReport = New System.Windows.Forms.DataGridView()
        Me.DrugsAdministered = New System.Windows.Forms.RichTextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.SearchPatientByID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AccountsDate = New System.Windows.Forms.DateTimePicker()
        Me.PatientAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PatientBalance = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.OtherServices = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PatientAccountsInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PatientID
        '
        Me.PatientID.Location = New System.Drawing.Point(294, 149)
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Size = New System.Drawing.Size(175, 23)
        Me.PatientID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PATIENT ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DRUGS ADMINISTERED"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DATE : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "LAST NAME :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "FIRST NAME :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(622, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOTAL COST :"
        '
        'FirstName
        '
        Me.FirstName.Location = New System.Drawing.Point(294, 195)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        Me.FirstName.Size = New System.Drawing.Size(175, 23)
        Me.FirstName.TabIndex = 7
        '
        'LastName
        '
        Me.LastName.Location = New System.Drawing.Point(294, 242)
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        Me.LastName.Size = New System.Drawing.Size(175, 23)
        Me.LastName.TabIndex = 8
        '
        'PatientTotalCost
        '
        Me.PatientTotalCost.Location = New System.Drawing.Point(728, 389)
        Me.PatientTotalCost.Name = "PatientTotalCost"
        Me.PatientTotalCost.Size = New System.Drawing.Size(175, 23)
        Me.PatientTotalCost.TabIndex = 10
        '
        'PatientAccountsInformationReport
        '
        Me.PatientAccountsInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientAccountsInformationReport.Location = New System.Drawing.Point(211, 515)
        Me.PatientAccountsInformationReport.Name = "PatientAccountsInformationReport"
        Me.PatientAccountsInformationReport.RowTemplate.Height = 25
        Me.PatientAccountsInformationReport.Size = New System.Drawing.Size(838, 165)
        Me.PatientAccountsInformationReport.TabIndex = 11
        '
        'DrugsAdministered
        '
        Me.DrugsAdministered.Location = New System.Drawing.Point(731, 152)
        Me.DrugsAdministered.Name = "DrugsAdministered"
        Me.DrugsAdministered.ReadOnly = True
        Me.DrugsAdministered.Size = New System.Drawing.Size(287, 96)
        Me.DrugsAdministered.TabIndex = 12
        Me.DrugsAdministered.Text = ""
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(294, 354)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(108, 36)
        Me.SubmitButton.TabIndex = 13
        Me.SubmitButton.Text = "SUBMIT "
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(428, 354)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(131, 38)
        Me.ResetButton.TabIndex = 14
        Me.ResetButton.Text = "RESET FORM"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'SearchPatientByID
        '
        Me.SearchPatientByID.Location = New System.Drawing.Point(586, 39)
        Me.SearchPatientByID.Name = "SearchPatientByID"
        Me.SearchPatientByID.Size = New System.Drawing.Size(175, 23)
        Me.SearchPatientByID.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(437, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SEARCH PATIENT BY ID :"
        '
        'AccountsDate
        '
        Me.AccountsDate.CustomFormat = "yyyy-MM-dd"
        Me.AccountsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.AccountsDate.Location = New System.Drawing.Point(294, 280)
        Me.AccountsDate.Name = "AccountsDate"
        Me.AccountsDate.Size = New System.Drawing.Size(175, 23)
        Me.AccountsDate.TabIndex = 17
        '
        'PatientAmountPaid
        '
        Me.PatientAmountPaid.Location = New System.Drawing.Point(728, 430)
        Me.PatientAmountPaid.Name = "PatientAmountPaid"
        Me.PatientAmountPaid.Size = New System.Drawing.Size(175, 23)
        Me.PatientAmountPaid.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(622, 433)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "AMOUNT PAID :"
        '
        'PatientBalance
        '
        Me.PatientBalance.Location = New System.Drawing.Point(728, 471)
        Me.PatientBalance.Name = "PatientBalance"
        Me.PatientBalance.ReadOnly = True
        Me.PatientBalance.Size = New System.Drawing.Size(175, 23)
        Me.PatientBalance.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(622, 474)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "BALANCE :"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1166, 29)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 80
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1058, 31)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 82
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'OtherServices
        '
        Me.OtherServices.Location = New System.Drawing.Point(731, 271)
        Me.OtherServices.Name = "OtherServices"
        Me.OtherServices.Size = New System.Drawing.Size(287, 96)
        Me.OtherServices.TabIndex = 84
        Me.OtherServices.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(586, 274)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "OTHER SERVICES:"
        '
        'AccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 692)
        Me.Controls.Add(Me.OtherServices)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PatientBalance)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PatientAmountPaid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.AccountsDate)
        Me.Controls.Add(Me.SearchPatientByID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.DrugsAdministered)
        Me.Controls.Add(Me.PatientAccountsInformationReport)
        Me.Controls.Add(Me.PatientTotalCost)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PatientID)
        Me.Name = "AccountsForm"
        Me.Text = "AccountsForm"
        CType(Me.PatientAccountsInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstName As TextBox
    Friend WithEvents LastName As TextBox
    Friend WithEvents PatientTotalCost As TextBox
    Friend WithEvents PatientAccountsInformationReport As DataGridView
    Friend WithEvents DrugsAdministered As RichTextBox
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents SearchPatientByID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents AccountsDate As DateTimePicker
    Friend WithEvents PatientAmountPaid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PatientBalance As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents OtherServices As RichTextBox
    Friend WithEvents Label10 As Label
End Class
