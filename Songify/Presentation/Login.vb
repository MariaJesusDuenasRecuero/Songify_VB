
Public Class Login

    Public user As User
    Public fileName As String
    Public Users As Collection
    Public r As New Globalization.CultureInfo("es-ES")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        System.Threading.Thread.CurrentThread.CurrentCulture = r
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
        Dim AlbumDAO As New Album()
        Try
            AlbumDAO.ReadAllAlbums(ofdPath.FileName)
            MessageBox.Show("Database has been read!", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Incorrect database, choose another one", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        btn_login.Enabled = True
        btn_signUp.Enabled = True
        txt_email.Enabled = True

    End Sub


    Private Sub clean_focus(Sender As Object, e As EventArgs) Handles txt_email.Enter
        txt_email.Clear()

    End Sub



    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        Dim f2 As New SignUp(fileName)
        f2.Show()
        Me.Hide()
        btn_login.Enabled = True
        btn_signUp.Enabled = True
        txt_email.Enabled = True
    End Sub


    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim useremail As String : Dim UserDAO As User : Dim iguales As Boolean : Dim email As String : Dim valido As Boolean

        iguales = False
        UserDAO = New User()
        valido = False
        Users = UserDAO.ReadAllUsers(fileName)


        email = txt_email.Text
        For Each user In Users
            If user.GetEmail() = email Then
                iguales = True
            End If
        Next
        If (email.Contains("@gmail.com") Or email.Contains("@hotmail.com") Or email.Contains("@hotmail.es") Or email.Contains("@cancionify.com")) Then
            valido = True
        Else
            valido = False
        End If


        If iguales = True And valido = True Then
            MsgBox("Welcome to our application", MsgBoxStyle.OkOnly, "Allow to Access")
            Dim f2 As New MainWindow(txt_email.Text, fileName)

            f2.Show()
            Me.Hide()
        ElseIf valido = False Then
            MsgBox("Please introduce a correct format of the email", MsgBoxStyle.OkOnly, "Warning")
        Else
            MsgBox("This user isn't in our DataBase", MsgBoxStyle.OkOnly, "Error")
        End If

        Try
            txt_email.Text = ""
        Catch ex As Exception
            MsgBox("Please introduce an email", MsgBoxStyle.OkOnly, "Warning")
        End Try



    End Sub

End Class
