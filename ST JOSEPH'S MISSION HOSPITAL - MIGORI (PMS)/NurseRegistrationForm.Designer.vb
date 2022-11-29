<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseRegistrationForm
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
        Me.NurseDOB = New System.Windows.Forms.DateTimePicker()
        Me.NurseDOR = New System.Windows.Forms.DateTimePicker()
        Me.NurseGender = New System.Windows.Forms.ComboBox()
        Me.NurseAddress = New System.Windows.Forms.TextBox()
        Me.NurseLastName = New System.Windows.Forms.TextBox()
        Me.NurseFirstName = New System.Windows.Forms.TextBox()
        Me.NurseIDNO = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.AddRecordButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.NursesInformation = New System.Windows.Forms.DataGridView()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.NursesInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NurseDOB
        '
        Me.NurseDOB.CustomFormat = "yyyy-MM-dd"
        Me.NurseDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.NurseDOB.Location = New System.Drawing.Point(310, 262)
        Me.NurseDOB.Name = "NurseDOB"
        Me.NurseDOB.Size = New System.Drawing.Size(195, 23)
        Me.NurseDOB.TabIndex = 52
        '
        'NurseDOR
        '
        Me.NurseDOR.CustomFormat = "yyyy-MM-dd"
        Me.NurseDOR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.NurseDOR.Location = New System.Drawing.Point(630, 211)
        Me.NurseDOR.Name = "NurseDOR"
        Me.NurseDOR.Size = New System.Drawing.Size(188, 23)
        Me.NurseDOR.TabIndex = 51
        '
        'NurseGender
        '
        Me.NurseGender.FormattingEnabled = True
        Me.NurseGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.NurseGender.Location = New System.Drawing.Point(630, 119)
        Me.NurseGender.Name = "NurseGender"
        Me.NurseGender.Size = New System.Drawing.Size(173, 23)
        Me.NurseGender.TabIndex = 50
        '
        'NurseAddress
        '
        Me.NurseAddress.Location = New System.Drawing.Point(630, 165)
        Me.NurseAddress.Name = "NurseAddress"
        Me.NurseAddress.Size = New System.Drawing.Size(173, 23)
        Me.NurseAddress.TabIndex = 49
        '
        'NurseLastName
        '
        Me.NurseLastName.Location = New System.Drawing.Point(310, 214)
        Me.NurseLastName.Name = "NurseLastName"
        Me.NurseLastName.Size = New System.Drawing.Size(165, 23)
        Me.NurseLastName.TabIndex = 48
        '
        'NurseFirstName
        '
        Me.NurseFirstName.Location = New System.Drawing.Point(310, 165)
        Me.NurseFirstName.Name = "NurseFirstName"
        Me.NurseFirstName.Size = New System.Drawing.Size(165, 23)
        Me.NurseFirstName.TabIndex = 47
        '
        'NurseIDNO
        '
        Me.NurseIDNO.Location = New System.Drawing.Point(310, 116)
        Me.NurseIDNO.Name = "NurseIDNO"
        Me.NurseIDNO.Size = New System.Drawing.Size(165, 23)
        Me.NurseIDNO.TabIndex = 46
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(1067, 179)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(137, 34)
        Me.UpdateButton.TabIndex = 45
        Me.UpdateButton.Text = "UPDATE RECORD"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'AddRecordButton
        '
        Me.AddRecordButton.Location = New System.Drawing.Point(1067, 118)
        Me.AddRecordButton.Name = "AddRecordButton"
        Me.AddRecordButton.Size = New System.Drawing.Size(137, 33)
        Me.AddRecordButton.TabIndex = 44
        Me.AddRecordButton.Text = "ADD RECORD"
        Me.AddRecordButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(1067, 287)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(137, 37)
        Me.ResetButton.TabIndex = 43
        Me.ResetButton.Text = "RESET FORM"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "D . O . R : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(552, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 15)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "ADDRESS : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(552, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "GENDER : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "D. O. B :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "LAST NAME : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "FIRST NAME : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID NO : "
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(1067, 235)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(137, 34)
        Me.DeleteButton.TabIndex = 53
        Me.DeleteButton.Text = "DELETE RECORD"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'NursesInformation
        '
        Me.NursesInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NursesInformation.Location = New System.Drawing.Point(212, 351)
        Me.NursesInformation.Name = "NursesInformation"
        Me.NursesInformation.RowTemplate.Height = 25
        Me.NursesInformation.Size = New System.Drawing.Size(618, 194)
        Me.NursesInformation.TabIndex = 54
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1067, 398)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(137, 37)
        Me.BackButton.TabIndex = 55
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1067, 458)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(137, 40)
        Me.ExitButton.TabIndex = 80
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'NurseRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 573)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NursesInformation)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.NurseDOB)
        Me.Controls.Add(Me.NurseDOR)
        Me.Controls.Add(Me.NurseGender)
        Me.Controls.Add(Me.NurseAddress)
        Me.Controls.Add(Me.NurseLastName)
        Me.Controls.Add(Me.NurseFirstName)
        Me.Controls.Add(Me.NurseIDNO)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.AddRecordButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NurseRegistrationForm"
        Me.Text = "NurseRegistrationForm"
        CType(Me.NursesInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NurseDOB As DateTimePicker
    Friend WithEvents NurseDOR As DateTimePicker
    Friend WithEvents NurseGender As ComboBox
    Friend WithEvents NurseAddress As TextBox
    Friend WithEvents NurseLastName As TextBox
    Friend WithEvents NurseFirstName As TextBox
    Friend WithEvents NurseIDNO As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents AddRecordButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents NursesInformation As DataGridView
    Friend WithEvents BackButton As Button
    Friend WithEvents ExitButton As Button
End Class
