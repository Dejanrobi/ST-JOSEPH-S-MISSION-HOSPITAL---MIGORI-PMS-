<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountantSections
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
        Me.PatientDetailsButton = New System.Windows.Forms.Button()
        Me.RegisterPatientsButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PatientDetailsButton
        '
        Me.PatientDetailsButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PatientDetailsButton.Location = New System.Drawing.Point(485, 402)
        Me.PatientDetailsButton.Name = "PatientDetailsButton"
        Me.PatientDetailsButton.Size = New System.Drawing.Size(311, 40)
        Me.PatientDetailsButton.TabIndex = 23
        Me.PatientDetailsButton.Text = "CHECK PATIENT ACCOUNTS DETAILS"
        Me.PatientDetailsButton.UseVisualStyleBackColor = True
        '
        'RegisterPatientsButton
        '
        Me.RegisterPatientsButton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RegisterPatientsButton.Location = New System.Drawing.Point(485, 308)
        Me.RegisterPatientsButton.Name = "RegisterPatientsButton"
        Me.RegisterPatientsButton.Size = New System.Drawing.Size(311, 40)
        Me.RegisterPatientsButton.TabIndex = 22
        Me.RegisterPatientsButton.Text = "ADD PATIENT BILLS"
        Me.RegisterPatientsButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(1058, 580)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(100, 40)
        Me.BackButton.TabIndex = 21
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(371, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(582, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "PLEASE SELECT THE TASK THAT YOU WANT TO PERFORM"
        '
        'AccountantSections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 746)
        Me.Controls.Add(Me.PatientDetailsButton)
        Me.Controls.Add(Me.RegisterPatientsButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccountantSections"
        Me.Text = "AccountantSections"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PatientDetailsButton As Button
    Friend WithEvents RegisterPatientsButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
End Class
