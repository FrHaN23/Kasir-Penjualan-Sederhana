Public Class formTesting
    Private Sub formTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = screenHeight
        TextBox2.Text = screenwidth
        Dim res = detectScreen()
        TextBox3.Text = res
        If res >= 3686400 Then
            TextBox1.Location = New Point(0, 0)
            Me.Size = New Point(1370, 800)

        End If
    End Sub
End Class