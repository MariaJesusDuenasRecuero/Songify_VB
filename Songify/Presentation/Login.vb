
Public Class Login

    Public user As User
    Public fileName As String
    Public Users As Collection

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


    Private Sub clean_focus(Sender As Object, e As EventArgs) Handles txt_email.Enter
        txt_email.Clear()

    End Sub



    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        Dim f2 As New SignUp
        f2.Show()
        Me.Hide()
    End Sub


    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim useremail As String : Dim UserDAO As UserDAO : Dim iguales As Boolean
        iguales = False
        UserDAO = New UserDAO()
        Users = UserDAO.ReadAll("C:\songify.accdb")
        For Each user In Users
            useremail = user.GetEmail()
            If user.GetEmail() = txt_email.Text Then
                iguales = True
                Exit For
            End If
        Next
        If iguales = True Then
            MsgBox("Welcome to our application", MsgBoxStyle.OkOnly, "Allow to Access")
            Dim f2 As New MainWindow(txt_email.Text)
            'lbl_warning.Enabled = False
            f2.Show()
            Me.Hide()
        Else
            MsgBox("This user isn't in out DataBase", MsgBoxStyle.OkOnly, "Error")
            'lbl_warning.Enabled = True
        End If

        If txt_email.Text = "" Then
            MsgBox("Please introduce an email", MsgBoxStyle.OkOnly, "Warning")
            'lbl_warning.Enabled = True




        End If


    End Sub
    Private Sub lbl_background_Click(sender As Object, e As EventArgs) Handles lbl_background.Click

    End Sub
End Class
