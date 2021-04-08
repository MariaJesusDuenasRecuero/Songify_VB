Imports System.Data
Imports System.Data.OleDb
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

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtname_Clear(sender As Object, e As EventArgs) Handles txt_name.Enter
        txt_name.Clear()
    End Sub
    Private Sub txtsurname_Clear(sender As Object, e As EventArgs) Handles txt_surname.Enter
        txt_surname.Clear()
    End Sub
    Private Sub txtemail_Clear(sender As Object, e As EventArgs) Handles txt_email.Enter
        txt_email.Clear()
    End Sub
    Private Sub txtbirthdate_Clear(sender As Object, e As EventArgs) Handles txt_birthdate.Enter
        txt_birthdate.Clear()
    End Sub

    Private Sub SignUpClick(sender As Object, e As EventArgs) Handles btn_loginSignUp.Click
        Dim name As String : Dim surname As String : Dim email As String : Dim birthdate As Date : Dim u As User
        Try
            name = txt_name.Text
            surname = txt_surname.Text
            email = txt_email.Text
            birthdate = txt_birthdate.Text
            u = New User(email)
            u.uName = name
            u.uSurname = surname
            u.birthdate = birthdate
            u.InsertUser()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub lbl_background_Click(sender As Object, e As EventArgs) Handles lbl_background.Click

    End Sub
End Class