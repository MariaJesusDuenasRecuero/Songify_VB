Public Class SignUp
    Private Sub btn_loginSignUp_Click(sender As Object, e As EventArgs) Handles btn_loginSignUp.Click
        Dim f2 As New Login
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim f2 As New Login
        f2.Show()
        Me.Hide()
    End Sub
End Class