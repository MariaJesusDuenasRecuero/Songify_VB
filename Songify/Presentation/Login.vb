
Public Class Login

    Public user As User
    Public fileName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ofdPath_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPath.FileOk
        Me.ofdPath.InitialDirectory = Application.StartupPath
    End Sub
    Private Sub btn_selectDB_Click(sender As Object, e As EventArgs) Handles btn_selectDB.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            btn_connect.Enabled = True
            fileName = ofdPath.FileName
            btn_connect.Enabled = True

        End If
    End Sub


    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        btn_login.Enabled = True
        btn_signUp.Enabled = True
        txt_email.Enabled = True

    End Sub



    ' Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
    ' query = "SELECT Email FROM USER WHERE Email='&txt_email.Text'"

    'If query.HasRows = True Then
    'MsgBox("acept", MsgBoxStyle.Information, "Allow to Access")
    'clean_focus()
    'Dim f2 As New MainWindow
    'f2.Show()
    'Me.Hide()
    'Else
    'MsgBox("Incorrect Email, please try again", MsgBoxStyle.Critical, "Warning")



    ' End If

    ' End Sub

    Private Sub clean_focus()
        txt_email.Clear()
        txt_email.Focus()

    End Sub



    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        Dim f2 As New SignUp
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_background_Click(sender As Object, e As EventArgs) Handles lbl_background.Click

    End Sub
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim Users As Collection : Dim useremail As String : Dim UserDAO As UserDAO : Dim f2 As New MainWindow : Dim iguales As Boolean
        iguales = False
        UserDAO = New UserDAO()
        Users = UserDAO.ReadAll("C:\songify.accdb")
        For Each user In Users
            useremail = user.Email
            If user.Email = txt_email.Text Then
                iguales = True
                Exit For
            End If
        Next
        If iguales = True Then
            MsgBox("Welcome to our application", MsgBoxStyle.OkOnly, "Allow to Access")
            f2.Show()
            Me.Hide()
        Else
            MsgBox("This user isn't in out DataBase", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub
End Class
