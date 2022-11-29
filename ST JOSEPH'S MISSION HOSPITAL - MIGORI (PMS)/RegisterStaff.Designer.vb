<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStaff
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
        Me.RegisterFrontDesk = New System.Windows.Forms.Button()
        Me.RegisterNurses = New System.Windows.Forms.Button()
        Me.RegisterDoctors = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(382, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "PLEASE SELECT THE STAFF THAT YOU WANT TO REGISTER"
        '
        'RegisterFrontDesk
        '
        Me.RegisterFrontDesk.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterFrontDesk.Location = New System.Drawing.Point(505, 395)
        Me.RegisterFrontDesk.Name = "RegisterFrontDesk"
        Me.RegisterFrontDesk.Size = New System.Drawing.Size(270, 40)
        Me.RegisterFrontDesk.TabIndex = 14
        Me.RegisterFrontDesk.Text = "REGISTER FRONT-END DESK STAFF"
        Me.RegisterFrontDesk.UseVisualStyleBackColor = True
        '
        'RegisterNurses
        '
        Me.RegisterNurses.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterNurses.Location = New System.Drawing.Point(505, 290)
        Me.RegisterNurses.Name = "RegisterNurses"
        Me.RegisterNurses.Size = New System.Drawing.Size(270, 40)
        Me.RegisterNurses.TabIndex = 13
        Me.RegisterNurses.Text = "REGISTER NURSES"
        Me.RegisterNurses.UseVisualStyleBackColor = True
        '
        'RegisterDoctors
        '
        Me.RegisterDoctors.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterDoctors.Location = New System.Drawing.Point(505, 192)
        Me.RegisterDoctors.Name = "RegisterDoctors"
        Me.RegisterDoctors.Size = New System.Drawing.Size(270, 40)
        Me.RegisterDoctors.TabIndex = 12
        Me.RegisterDoctors.Text = "REGISTER DOCTORS"
        Me.RegisterDoctors.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(980, 451)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(87, 35)
        Me.BackButton.TabIndex = 16
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'RegisterStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1288, 550)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RegisterFrontDesk)
        Me.Controls.Add(Me.RegisterNurses)
        Me.Controls.Add(Me.RegisterDoctors)
        Me.Name = "RegisterStaff"
        Me.Text = "RegisterStaff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RegisterFrontDesk As Button
    Friend WithEvents RegisterNurses As Button
    Friend WithEvents RegisterDoctors As Button
    Friend WithEvents BackButton As Button
End Class
