<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BedRegistrationForm
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
        Me.BedNo = New System.Windows.Forms.TextBox()
        Me.DeleteBedButton = New System.Windows.Forms.Button()
        Me.AddBedButton = New System.Windows.Forms.Button()
        Me.UpdateBedButton = New System.Windows.Forms.Button()
        Me.ResetFormButton = New System.Windows.Forms.Button()
        Me.BedInformationReport = New System.Windows.Forms.DataGridView()
        Me.WardNO = New System.Windows.Forms.ComboBox()
        CType(Me.BedInformationReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WARD NO : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BED NO : "
        '
        'BedNo
        '
        Me.BedNo.Location = New System.Drawing.Point(428, 72)
        Me.BedNo.Name = "BedNo"
        Me.BedNo.Size = New System.Drawing.Size(167, 23)
        Me.BedNo.TabIndex = 2
        '
        'DeleteBedButton
        '
        Me.DeleteBedButton.Location = New System.Drawing.Point(984, 186)
        Me.DeleteBedButton.Name = "DeleteBedButton"
        Me.DeleteBedButton.Size = New System.Drawing.Size(121, 32)
        Me.DeleteBedButton.TabIndex = 48
        Me.DeleteBedButton.Text = "DELETE BED"
        Me.DeleteBedButton.UseVisualStyleBackColor = True
        '
        'AddBedButton
        '
        Me.AddBedButton.Location = New System.Drawing.Point(984, 75)
        Me.AddBedButton.Name = "AddBedButton"
        Me.AddBedButton.Size = New System.Drawing.Size(121, 34)
        Me.AddBedButton.TabIndex = 47
        Me.AddBedButton.Text = "ADD BED"
        Me.AddBedButton.UseVisualStyleBackColor = True
        '
        'UpdateBedButton
        '
        Me.UpdateBedButton.Location = New System.Drawing.Point(984, 123)
        Me.UpdateBedButton.Name = "UpdateBedButton"
        Me.UpdateBedButton.Size = New System.Drawing.Size(121, 34)
        Me.UpdateBedButton.TabIndex = 46
        Me.UpdateBedButton.Text = "UPDATE BED"
        Me.UpdateBedButton.UseVisualStyleBackColor = True
        '
        'ResetFormButton
        '
        Me.ResetFormButton.Location = New System.Drawing.Point(984, 242)
        Me.ResetFormButton.Name = "ResetFormButton"
        Me.ResetFormButton.Size = New System.Drawing.Size(121, 30)
        Me.ResetFormButton.TabIndex = 49
        Me.ResetFormButton.Text = "RESET FORM"
        Me.ResetFormButton.UseVisualStyleBackColor = True
        '
        'BedInformationReport
        '
        Me.BedInformationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedInformationReport.Location = New System.Drawing.Point(342, 280)
        Me.BedInformationReport.Name = "BedInformationReport"
        Me.BedInformationReport.RowTemplate.Height = 25
        Me.BedInformationReport.Size = New System.Drawing.Size(211, 284)
        Me.BedInformationReport.TabIndex = 50
        '
        'WardNO
        '
        Me.WardNO.FormattingEnabled = True
        Me.WardNO.Location = New System.Drawing.Point(428, 115)
        Me.WardNO.Name = "WardNO"
        Me.WardNO.Size = New System.Drawing.Size(167, 23)
        Me.WardNO.TabIndex = 51
        '
        'BedRegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 576)
        Me.Controls.Add(Me.WardNO)
        Me.Controls.Add(Me.BedInformationReport)
        Me.Controls.Add(Me.ResetFormButton)
        Me.Controls.Add(Me.DeleteBedButton)
        Me.Controls.Add(Me.AddBedButton)
        Me.Controls.Add(Me.UpdateBedButton)
        Me.Controls.Add(Me.BedNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BedRegistrationForm"
        Me.Text = "BedRegistrationForm"
        CType(Me.BedInformationReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BedNo As TextBox
    Friend WithEvents DeleteBedButton As Button
    Friend WithEvents AddBedButton As Button
    Friend WithEvents UpdateBedButton As Button
    Friend WithEvents ResetFormButton As Button
    Friend WithEvents BedInformationReport As DataGridView
    Friend WithEvents WardNO As ComboBox
End Class
