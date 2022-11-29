<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemSections
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
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.FrontEndDeskStaffButton = New System.Windows.Forms.Button()
        Me.DoctorSectionButton = New System.Windows.Forms.Button()
        Me.NurseSectionButton = New System.Windows.Forms.Button()
        Me.AccountsSectionButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(362, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(616, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PLEASE SELECT THE SECTION YOU WANT TO ACCESS:"
        '
        'AdminButton
        '
        Me.AdminButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AdminButton.Location = New System.Drawing.Point(518, 169)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(258, 40)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "ADMIN"
        Me.AdminButton.UseVisualStyleBackColor = True
        '
        'FrontEndDeskStaffButton
        '
        Me.FrontEndDeskStaffButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FrontEndDeskStaffButton.Location = New System.Drawing.Point(518, 244)
        Me.FrontEndDeskStaffButton.Name = "FrontEndDeskStaffButton"
        Me.FrontEndDeskStaffButton.Size = New System.Drawing.Size(258, 40)
        Me.FrontEndDeskStaffButton.TabIndex = 2
        Me.FrontEndDeskStaffButton.Text = "FRONT-END DESK STAFF"
        Me.FrontEndDeskStaffButton.UseVisualStyleBackColor = True
        '
        'DoctorSectionButton
        '
        Me.DoctorSectionButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DoctorSectionButton.Location = New System.Drawing.Point(518, 313)
        Me.DoctorSectionButton.Name = "DoctorSectionButton"
        Me.DoctorSectionButton.Size = New System.Drawing.Size(258, 40)
        Me.DoctorSectionButton.TabIndex = 3
        Me.DoctorSectionButton.Text = "DOCTOR'S SECTION"
        Me.DoctorSectionButton.UseVisualStyleBackColor = True
        '
        'NurseSectionButton
        '
        Me.NurseSectionButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NurseSectionButton.Location = New System.Drawing.Point(518, 388)
        Me.NurseSectionButton.Name = "NurseSectionButton"
        Me.NurseSectionButton.Size = New System.Drawing.Size(258, 40)
        Me.NurseSectionButton.TabIndex = 4
        Me.NurseSectionButton.Text = "NURSE'S SECTION"
        Me.NurseSectionButton.UseVisualStyleBackColor = True
        '
        'AccountsSectionButton
        '
        Me.AccountsSectionButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AccountsSectionButton.Location = New System.Drawing.Point(518, 465)
        Me.AccountsSectionButton.Name = "AccountsSectionButton"
        Me.AccountsSectionButton.Size = New System.Drawing.Size(258, 40)
        Me.AccountsSectionButton.TabIndex = 5
        Me.AccountsSectionButton.Text = "ACCOUNTS SECTION"
        Me.AccountsSectionButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(991, 465)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 40)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'SystemSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 554)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AccountsSectionButton)
        Me.Controls.Add(Me.NurseSectionButton)
        Me.Controls.Add(Me.DoctorSectionButton)
        Me.Controls.Add(Me.FrontEndDeskStaffButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SystemSections"
        Me.Text = "SystemSections"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AdminButton As Button
    Friend WithEvents FrontEndDeskStaffButton As Button
    Friend WithEvents DoctorSectionButton As Button
    Friend WithEvents NurseSectionButton As Button
    Friend WithEvents AccountsSectionButton As Button
    Friend WithEvents ExitButton As Button
End Class
