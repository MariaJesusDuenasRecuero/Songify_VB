Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim f2 As New MainWindow
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        Dim f2 As New SignUp
        f2.Show()
        Me.Hide()
    End Sub
End Class
