<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountsLogin
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
        Me.AccountantSectionPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AccountantSectionUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(624, 359)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(107, 30)
        Me.BackButton.TabIndex = 34
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NurseLoginButton
        '
        Me.NurseLoginButton.Location = New System.Drawing.Point(481, 359)
        Me.NurseLoginButton.Name = "NurseLoginButton"
        Me.NurseLoginButton.Size = New System.Drawing.Size(107, 30)
        Me.NurseLoginButton.TabIndex = 33
        Me.NurseLoginButton.Text = "LOGIN "
        Me.NurseLoginButton.UseVisualStyleBackColor = True
        '
        'AccountantSectionPassword
        '
        Me.AccountantSectionPassword.Location = New System.Drawing.Point(586, 259)
        Me.AccountantSectionPassword.Name = "AccountantSectionPassword"
        Me.AccountantSectionPassword.Size = New System.Drawing.Size(211, 23)
        Me.AccountantSectionPassword.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(481, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Password : "
        '
        'AccountantSectionUsername
        '
        Me.AccountantSectionUsername.Location = New System.Drawing.Point(586, 191)
        Me.AccountantSectionUsername.Name = "AccountantSectionUsername"
        Me.AccountantSectionUsername.Size = New System.Drawing.Size(211, 23)
        Me.AccountantSectionUsername.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(481, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Username : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(426, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(473, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Please Enter Your Accountant's  Username And Password : "
        '
        'AccountsLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 567)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NurseLoginButton)
        Me.Controls.Add(Me.AccountantSectionPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AccountantSectionUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccountsLogin"
        Me.Text = "AccountsLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents NurseLoginButton As Button
    Friend WithEvents AccountantSectionPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AccountantSectionUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
