Public Class tartupForm
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Pbar.Value = Pbar.Value + 1
        If Pbar.Value >= 100 Then
            Timer1.Stop()
            SystemSections.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class