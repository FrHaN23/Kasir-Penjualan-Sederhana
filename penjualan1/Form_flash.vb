Public Class Form_flash
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Form_flash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            form_login.Show()

        End If
    End Sub
End Class