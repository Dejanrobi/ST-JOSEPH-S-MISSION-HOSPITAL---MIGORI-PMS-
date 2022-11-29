<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseSurgeryAllocations
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
        Me.SituationTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.AllocatedSurgeryReport = New System.Windows.Forms.DataGridView()
        Me.DoctorsID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AllocatedSurgeryReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SituationTextBox
        '
        Me.SituationTextBox.Location = New System.Drawing.Point(737, 177)
        Me.SituationTextBox.Name = "SituationTextBox"
        Me.SituationTextBox.ReadOnly = True
        Me.SituationTextBox.Size = New System.Drawing.Size(202, 23)
        Me.SituationTextBox.TabIndex = 99
        Me.SituationTextBox.Text = "SURGERY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(661, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "SITUATION :"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1085, 88)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 97
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(925, 88)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 96
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AllocatedSurgeryReport
        '
        Me.AllocatedSurgeryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllocatedSurgeryReport.Location = New System.Drawing.Point(224, 239)
        Me.AllocatedSurgeryReport.Name = "AllocatedSurgeryReport"
        Me.AllocatedSurgeryReport.RowTemplate.Height = 25
        Me.AllocatedSurgeryReport.Size = New System.Drawing.Size(674, 468)
        Me.AllocatedSurgeryReport.TabIndex = 95
        '
        'DoctorsID
        '
        Me.DoctorsID.Location = New System.Drawing.Point(357, 180)
        Me.DoctorsID.Name = "DoctorsID"
        Me.DoctorsID.Size = New System.Drawing.Size(219, 23)
        Me.DoctorsID.TabIndex = 94
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "SEARCH WITH YOUR ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(425, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 30)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "NURSE'S  ALLOCATED SURGER‪IES"
        '
        'NurseSurgeryAllocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 646)
        Me.Controls.Add(Me.SituationTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AllocatedSurgeryReport)
        Me.Controls.Add(Me.DoctorsID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NurseSurgeryAllocations"
        Me.Text = "NurseSurgeryAllocations"
        CType(Me.AllocatedSurgeryReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SituationTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents AllocatedSurgeryReport As DataGridView
    Friend WithEvents DoctorsID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
