Public Class Form1
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Visible = True
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 10) Then
            Label1.Text = "Reading Modules.."
        ElseIf (ProgressBar1.Value = 20) Then
            Label1.Text = "Turning on modules.."
        ElseIf (ProgressBar1.Value = 40) Then
            Label1.Text = "Starting modules..."
        ElseIf (ProgressBar1.Value = 60) Then
            Label1.Text = "Loading Modules..."
        ElseIf (ProgressBar1.Value = 80) Then
            Label1.Text = "Done Loading Modules..."
        ElseIf (ProgressBar1.Value = 100) Then
            frmLogin.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
