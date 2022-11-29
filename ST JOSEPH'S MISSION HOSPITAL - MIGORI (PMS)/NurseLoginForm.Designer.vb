<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseLoginForm
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
        Me.NurseLoginButton = New System.Windows.Forms.Button()
        Me.NurseSectionPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NurseSectionUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(573, 385)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(107, 30)
        Me.BackButton.TabIndex = 27
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NurseLoginButton
        '
        Me.NurseLoginButton.Location = New System.Drawing.Point(430, 385)
        Me.NurseLoginButton.Name = "NurseLoginButton"
        Me.NurseLoginButton.Size = New System.Drawing.Size(107, 30)
        Me.NurseLoginButton.TabIndex = 26
        Me.NurseLoginButton.Text = "LOGIN "
        Me.NurseLoginButton.UseVisualStyleBackColor = True
        '
        'NurseSectionPassword
        '
        Me.NurseSectionPassword.Location = New System.Drawing.Point(525, 263)
        Me.NurseSectionPassword.Name = "NurseSectionPassword"
        Me.NurseSectionPassword.Size = New System.Drawing.Size(211, 23)
        Me.NurseSectionPassword.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(420, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Password : "
        '
        'NurseSectionUsername
        '
        Me.NurseSectionUsername.Location = New System.Drawing.Point(525, 207)
        Me.NurseSectionUsername.Name = "NurseSectionUsername"
        Me.NurseSectionUsername.Size = New System.Drawing.Size(211, 23)
        Me.NurseSectionUsername.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(420, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(421, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Please Enter Your Nurse's Username And Password : "
        '
        'NurseLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 550)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NurseLoginButton)
        Me.Controls.Add(Me.NurseSectionPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NurseSectionUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NurseLoginForm"
        Me.Text = "NurseLoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents NurseLoginButton As Button
    Friend WithEvents NurseSectionPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NurseSectionUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
