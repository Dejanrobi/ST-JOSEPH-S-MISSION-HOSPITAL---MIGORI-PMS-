<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WardRegistrationForm
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
        Me.DeleteWardButton = New System.Windows.Forms.Button()
        Me.AddWardButton = New System.Windows.Forms.Button()
        Me.UpdateWardButton = New System.Windows.Forms.Button()
        Me.WardNO = New System.Windows.Forms.TextBox()
        Me.NoOfBeds = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.WardInformationReport = New System.Windows.Forms.DataGridView()
        CType(Me.WardInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteWardButton
        '
        Me.DeleteWardButton.Location = New System.Drawing.Point(868, 197)
        Me.DeleteWardButton.Name = "DeleteWardButton"
        Me.DeleteWardButton.Size = New System.Drawing.Size(117, 34)
        Me.DeleteWardButton.TabIndex = 55
        Me.DeleteWardButton.Text = "DELETE WARD"
        Me.DeleteWardButton.UseVisualStyleBackColor = True
        '
        'AddWardButton
        '
        Me.AddWardButton.Location = New System.Drawing.Point(868, 96)
        Me.AddWardButton.Name = "AddWardButton"
        Me.AddWardButton.Size = New System.Drawing.Size(117, 34)
        Me.AddWardButton.TabIndex = 54
        Me.AddWardButton.Text = "ADD WARD"
        Me.AddWardButton.UseVisualStyleBackColor = True
        '
        'UpdateWardButton
        '
        Me.UpdateWardButton.Location = New System.Drawing.Point(868, 150)
        Me.UpdateWardButton.Name = "UpdateWardButton"
        Me.UpdateWardButton.Size = New System.Drawing.Size(117, 31)
        Me.UpdateWardButton.TabIndex = 53
        Me.UpdateWardButton.Text = "UPDATE WARD"
        Me.UpdateWardButton.UseVisualStyleBackColor = True
        '
        'WardNO
        '
        Me.WardNO.Location = New System.Drawing.Point(430, 101)
        Me.WardNO.Name = "WardNO"
        Me.WardNO.Size = New System.Drawing.Size(167, 23)
        Me.WardNO.TabIndex = 52
        '
        'NoOfBeds
        '
        Me.NoOfBeds.Location = New System.Drawing.Point(430, 158)
        Me.NoOfBeds.Name = "NoOfBeds"
        Me.NoOfBeds.Size = New System.Drawing.Size(167, 23)
        Me.NoOfBeds.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "NO OF BEDS : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "WARD NO : "
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(868, 251)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(117, 35)
        Me.ResetFormButton.TabIndex = 56
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'WardInformationReport
        '
        Me.WardInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WardInformationReport.Location = New System.Drawing.Point(344, 251)
        Me.WardInformationReport.Name = "WardInformationReport"
        Me.WardInformationReport.RowTemplate.Height = 25
        Me.WardInformationReport.Size = New System.Drawing.Size(336, 324)
        Me.WardInformationReport.TabIndex = 57
        '
        'WardRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 674)
        Me.Controls.Add(Me.WardInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.DeleteWardButton)
        Me.Controls.Add(Me.AddWardButton)
        Me.Controls.Add(Me.UpdateWardButton)
        Me.Controls.Add(Me.WardNO)
        Me.Controls.Add(Me.NoOfBeds)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WardRegistrationForm"
        Me.Text = "WardRegistrationForm"
        CType(Me.WardInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DeleteWardButton As Button
    Friend WithEvents AddWardButton As Button
    Friend WithEvents UpdateWardButton As Button
    Friend WithEvents WardNO As TextBox
    Friend WithEvents NoOfBeds As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents WardInformationReport As DataGridView
End Class
