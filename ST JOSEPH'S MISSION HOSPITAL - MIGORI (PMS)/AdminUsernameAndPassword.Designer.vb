<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminSectionUsernameAndPassword
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AdminSectionUsername = New System.Windows.Forms.TextBox()
        Me.AdminSectionPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AdminLoginButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(410, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(523, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Enter Admin The Section's Username And Password : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(473, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username : "
        '
        'AdminSectionUsername
        '
        Me.AdminSectionUsername.Location = New System.Drawing.Point(578, 216)
        Me.AdminSectionUsername.Name = "AdminSectionUsername"
        Me.AdminSectionUsername.Size = New System.Drawing.Size(211, 23)
        Me.AdminSectionUsername.TabIndex = 2
        '
        'AdminSectionPassword
        '
        Me.AdminSectionPassword.Location = New System.Drawing.Point(578, 272)
        Me.AdminSectionPassword.Name = "AdminSectionPassword"
        Me.AdminSectionPassword.Size = New System.Drawing.Size(211, 23)
        Me.AdminSectionPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(473, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password : "
        '
        'AdminLoginButton
        '
        Me.AdminLoginButton.Location = New System.Drawing.Point(476, 356)
        Me.AdminLoginButton.Name = "AdminLoginButton"
        Me.AdminLoginButton.Size = New System.Drawing.Size(107, 30)
        Me.AdminLoginButton.TabIndex = 5
        Me.AdminLoginButton.Text = "LOGIN "
        Me.AdminLoginButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(619, 356)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(107, 30)
        Me.BackButton.TabIndex = 6
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'AdminSectionUsernameAndPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 584)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AdminLoginButton)
        Me.Controls.Add(Me.AdminSectionPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AdminSectionUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminSectionUsernameAndPassword"
        Me.Text = "AdminSectionUsernameAndPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AdminSectionUsername As TextBox
    Friend WithEvents AdminSectionPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AdminLoginButton As Button
    Friend WithEvents BackButton As Button
End Class
