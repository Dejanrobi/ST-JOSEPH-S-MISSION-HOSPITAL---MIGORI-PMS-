<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorsLogin
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
        Me.DoctorLoginButton = New System.Windows.Forms.Button()
        Me.DoctorSectionPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DoctorSectionUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(575, 364)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(107, 30)
        Me.BackButton.TabIndex = 20
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DoctorLoginButton
        '
        Me.DoctorLoginButton.Location = New System.Drawing.Point(432, 364)
        Me.DoctorLoginButton.Name = "DoctorLoginButton"
        Me.DoctorLoginButton.Size = New System.Drawing.Size(107, 30)
        Me.DoctorLoginButton.TabIndex = 19
        Me.DoctorLoginButton.Text = "LOGIN "
        Me.DoctorLoginButton.UseVisualStyleBackColor = True
        '
        'DoctorSectionPassword
        '
        Me.DoctorSectionPassword.Location = New System.Drawing.Point(530, 264)
        Me.DoctorSectionPassword.Name = "DoctorSectionPassword"
        Me.DoctorSectionPassword.Size = New System.Drawing.Size(211, 23)
        Me.DoctorSectionPassword.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(425, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Password : "
        '
        'DoctorSectionUsername
        '
        Me.DoctorSectionUsername.Location = New System.Drawing.Point(530, 208)
        Me.DoctorSectionUsername.Name = "DoctorSectionUsername"
        Me.DoctorSectionUsername.Size = New System.Drawing.Size(211, 23)
        Me.DoctorSectionUsername.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(425, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(384, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please Enter Your Doctor's Username And Password : "
        '
        'DoctorsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 567)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.DoctorLoginButton)
        Me.Controls.Add(Me.DoctorSectionPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DoctorSectionUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DoctorsLogin"
        Me.Text = "DoctorsLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents DoctorLoginButton As Button
    Friend WithEvents DoctorSectionPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DoctorSectionUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
