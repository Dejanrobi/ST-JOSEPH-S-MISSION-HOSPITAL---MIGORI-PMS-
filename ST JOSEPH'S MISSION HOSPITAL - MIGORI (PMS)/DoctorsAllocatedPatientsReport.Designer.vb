<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorsAllocatedPatientsReport
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
        Me.DoctorsID = New System.Windows.Forms.TextBox()
        Me.AllocatedPatientsReport = New System.Windows.Forms.DataGridView()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.AllocatedPatientsReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(346, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "YOUR ALLOCATED PATIENTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(286, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SEARCH WITH YOUR ID:"
        '
        'DoctorsID
        '
        Me.DoctorsID.Location = New System.Drawing.Point(426, 104)
        Me.DoctorsID.Name = "DoctorsID"
        Me.DoctorsID.Size = New System.Drawing.Size(219, 23)
        Me.DoctorsID.TabIndex = 2
        '
        'AllocatedPatientsReport
        '
        Me.AllocatedPatientsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllocatedPatientsReport.Location = New System.Drawing.Point(87, 160)
        Me.AllocatedPatientsReport.Name = "AllocatedPatientsReport"
        Me.AllocatedPatientsReport.RowTemplate.Height = 25
        Me.AllocatedPatientsReport.Size = New System.Drawing.Size(872, 468)
        Me.AllocatedPatientsReport.TabIndex = 3
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Red
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Location = New System.Drawing.Point(1115, 66)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(130, 40)
        Me.ExitButton.TabIndex = 83
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(955, 66)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(130, 40)
        Me.BackButton.TabIndex = 82
        Me.BackButton.Text = "BACK"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DoctorsAllocatedPatientsReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 640)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AllocatedPatientsReport)
        Me.Controls.Add(Me.DoctorsID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DoctorsAllocatedPatientsReport"
        Me.Text = "DoctorsAllocatedPatientsReport"
        CType(Me.AllocatedPatientsReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DoctorsID As TextBox
    Friend WithEvents AllocatedPatientsReport As DataGridView
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
End Class
