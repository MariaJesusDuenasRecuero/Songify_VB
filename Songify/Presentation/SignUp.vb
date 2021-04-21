Imports System.Data
Imports System.Data.OleDb
Public Class SignUp
    Public path As String
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
    Public Sub New(path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.path = path
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
        Dim name As String : Dim surname As String : Dim email As String : Dim birthdate As Date : Dim u As User : Dim valido As Boolean : Dim formatEmail As String : Dim FechaFormato As String
        'formatEmail = "^[\w-\.]+@\cancionify\+$"
        valido = True
        Try
            If txt_name.Text = "" Then
                MessageBox.Show("Please introduce a valid value")
                valido = False
            End If
            name = txt_name.Text
            If txt_surname.Text = "" Then
                MessageBox.Show("Please introduce a valid value")
                valido = False
            End If
            surname = txt_surname.Text
            If txt_email.Text = "" Then
                MessageBox.Show("Please introduce a valid value")
                valido = False
                'ElseIf txt_email.Text <> Format(txt_email.Text, formatEmail) Then
                'valido = True
                'Else
                'valido = False
            End If


            email = txt_email.Text
            If (email.Contains("@gmail.com") Or email.Contains("@hotmail.com") Or email.Contains("@hotmail.es") Or email.Contains("@cancionify.com")) Then
                valido = True
            Else
                valido = False
                MsgBox("Please introduce a correct format of the email", MsgBoxStyle.OkOnly, "Warning")
            End If


            If txt_birthdate.Text = "" Then
                MessageBox.Show("Please introduce a valid value")
                valido = False
            End If
            birthdate = txt_birthdate.Text
            If valido = True Then
                u = New User(email)
                u.SetName(name)
                u.SetSurname(surname)
                u.SetBirthdate(birthdate)
                u.InsertUser(path)
                MsgBox("Registered user", MsgBoxStyle.OkOnly, "Information")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub


End Class