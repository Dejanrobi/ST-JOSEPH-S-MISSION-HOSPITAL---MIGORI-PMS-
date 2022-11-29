<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontEndDeskLogin
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
        Me.AdminLoginButton = New System.Windows.Forms.Button()
        Me.FrontDeskSectionPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FrontDeskSectionUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(562, 369)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(107, 30)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AdminLoginButton
        '
        Me.AdminLoginButton.Location = New System.Drawing.Point(419, 369)
        Me.AdminLoginButton.Name = "AdminLoginButton"
        Me.AdminLoginButton.Size = New System.Drawing.Size(107, 30)
        Me.AdminLoginButton.TabIndex = 12
        Me.AdminLoginButton.Text = "LOGIN "
        Me.AdminLoginButton.UseVisualStyleBackColor = True
        '
        'FrontDeskSectionPassword
        '
        Me.FrontDeskSectionPassword.Location = New System.Drawing.Point(522, 271)
        Me.FrontDeskSectionPassword.Name = "FrontDeskSectionPassword"
        Me.FrontDeskSectionPassword.Size = New System.Drawing.Size(211, 23)
        Me.FrontDeskSectionPassword.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(417, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password : "
        '
        'FrontDeskSectionUsername
        '
        Me.FrontDeskSectionUsername.Location = New System.Drawing.Point(522, 209)
        Me.FrontDeskSectionUsername.Name = "FrontDeskSectionUsername"
        Me.FrontDeskSectionUsername.Size = New System.Drawing.Size(211, 23)
        Me.FrontDeskSectionUsername.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(417, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(316, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Please Enter Your Front-End Desk's  Section's Username And Password : "
        '
        'FrontEndDeskLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 544)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AdminLoginButton)
        Me.Controls.Add(Me.FrontDeskSectionPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FrontDeskSectionUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrontEndDeskLogin"
        Me.Text = "FrontEndDeskLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents AdminLoginButton As Button
    Friend WithEvents FrontDeskSectionPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents FrontDeskSectionUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
