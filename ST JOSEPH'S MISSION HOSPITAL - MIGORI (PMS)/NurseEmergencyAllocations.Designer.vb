<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseEmergencyAllocations
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
        Me.AllocatedEmergencyReport = New System.Windows.Forms.DataGridView()
        Me.DoctorsID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AllocatedEmergencyReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SituationTextBox
        '
        Me.SituationTextBox.Location = New System.Drawing.Point(732, 183)
        Me.SituationTextBox.Name = "SituationTextBox"
        Me.SituationTextBox.ReadOnly = True
        Me.SituationTextBox.Size = New System.Drawing.Size(202, 23)
        Me.SituationTextBox.TabIndex = 107
        Me.SituationTextBox.Text = "EMERGENCY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(656, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "SITUATION :"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1080, 94)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 105
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(920, 94)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 104
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AllocatedEmergencyReport
        '
        Me.AllocatedEmergencyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllocatedEmergencyReport.Location = New System.Drawing.Point(219, 245)
        Me.AllocatedEmergencyReport.Name = "AllocatedEmergencyReport"
        Me.AllocatedEmergencyReport.RowTemplate.Height = 25
        Me.AllocatedEmergencyReport.Size = New System.Drawing.Size(674, 468)
        Me.AllocatedEmergencyReport.TabIndex = 103
        '
        'DoctorsID
        '
        Me.DoctorsID.Location = New System.Drawing.Point(352, 186)
        Me.DoctorsID.Name = "DoctorsID"
        Me.DoctorsID.Size = New System.Drawing.Size(219, 23)
        Me.DoctorsID.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "SEARCH WITH YOUR ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(420, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 30)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "NURSE ALLOCATED EMERGENCIES"
        '
        'NurseEmergencyAllocations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 649)
        Me.Controls.Add(Me.SituationTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AllocatedEmergencyReport)
        Me.Controls.Add(Me.DoctorsID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NurseEmergencyAllocations"
        Me.Text = "NurseEmergencyAllocations"
        CType(Me.AllocatedEmergencyReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SituationTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents AllocatedEmergencyReport As DataGridView
    Friend WithEvents DoctorsID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
