<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSection
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
        Me.CheckoutPatientButton = New System.Windows.Forms.Button()
        Me.AssignSurgeriesButton = New System.Windows.Forms.Button()
        Me.AssignEmergencyCasesButton = New System.Windows.Forms.Button()
        Me.AssignDoctorsAndNursesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.RegisterStaffButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckoutPatientButton
        '
        Me.CheckoutPatientButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckoutPatientButton.Location = New System.Drawing.Point(557, 375)
        Me.CheckoutPatientButton.Name = "CheckoutPatientButton"
        Me.CheckoutPatientButton.Size = New System.Drawing.Size(258, 40)
        Me.CheckoutPatientButton.TabIndex = 9
        Me.CheckoutPatientButton.Text = "CHECKOUT PATIENT"
        Me.CheckoutPatientButton.UseVisualStyleBackColor = True
        '
        'AssignSurgeriesButton
        '
        Me.AssignSurgeriesButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AssignSurgeriesButton.Location = New System.Drawing.Point(557, 307)
        Me.AssignSurgeriesButton.Name = "AssignSurgeriesButton"
        Me.AssignSurgeriesButton.Size = New System.Drawing.Size(258, 40)
        Me.AssignSurgeriesButton.TabIndex = 8
        Me.AssignSurgeriesButton.Text = "ASSIGN SURGERIES"
        Me.AssignSurgeriesButton.UseVisualStyleBackColor = True
        '
        'AssignEmergencyCasesButton
        '
        Me.AssignEmergencyCasesButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AssignEmergencyCasesButton.Location = New System.Drawing.Point(557, 240)
        Me.AssignEmergencyCasesButton.Name = "AssignEmergencyCasesButton"
        Me.AssignEmergencyCasesButton.Size = New System.Drawing.Size(258, 40)
        Me.AssignEmergencyCasesButton.TabIndex = 7
        Me.AssignEmergencyCasesButton.Text = "ASSIGN EMERGENCY CASES"
        Me.AssignEmergencyCasesButton.UseVisualStyleBackColor = True
        '
        'AssignDoctorsAndNursesButton
        '
        Me.AssignDoctorsAndNursesButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AssignDoctorsAndNursesButton.Location = New System.Drawing.Point(557, 167)
        Me.AssignDoctorsAndNursesButton.Name = "AssignDoctorsAndNursesButton"
        Me.AssignDoctorsAndNursesButton.Size = New System.Drawing.Size(258, 40)
        Me.AssignDoctorsAndNursesButton.TabIndex = 6
        Me.AssignDoctorsAndNursesButton.Text = "ASSIGN DOCTOR'S/NURSES"
        Me.AssignDoctorsAndNursesButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(389, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "PLEASE SELECT THE TASK THAT YOU WANT TO PERFORM"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1038, 492)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(88, 37)
        Me.BackButton.TabIndex = 82
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RegisterStaffButton
        '
        Me.RegisterStaffButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterStaffButton.Location = New System.Drawing.Point(557, 445)
        Me.RegisterStaffButton.Name = "RegisterStaffButton"
        Me.RegisterStaffButton.Size = New System.Drawing.Size(258, 40)
        Me.RegisterStaffButton.TabIndex = 83
        Me.RegisterStaffButton.Text = "REGISTER STAFF"
        Me.RegisterStaffButton.UseVisualStyleBackColor = True
        '
        'AdminSection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 593)
        Me.Controls.Add(Me.RegisterStaffButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckoutPatientButton)
        Me.Controls.Add(Me.AssignSurgeriesButton)
        Me.Controls.Add(Me.AssignEmergencyCasesButton)
        Me.Controls.Add(Me.AssignDoctorsAndNursesButton)
        Me.Name = "AdminSection"
        Me.Text = "AdminSection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckoutPatientButton As Button
    Friend WithEvents AssignSurgeriesButton As Button
    Friend WithEvents AssignEmergencyCasesButton As Button
    Friend WithEvents AssignDoctorsAndNursesButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents RegisterStaffButton As Button
End Class
