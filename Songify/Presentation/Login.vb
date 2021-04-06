
Imports System.Data
Imports System.Data.OleDb



Public Class Login
    Dim connection As New OleDbConnection
    Dim command As New OleDbCommand
    Dim adapter As New OleDbDataAdapter
    Dim reader As OleDbDataReader
    Dim query As String
    Private user As User

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.ConnectionString = "ProviderMicrosoft.ACE.OLEDB.12.0;Data Source=C:\Users\Usuario\Downloads\songify.accdb"
            connection.Open()

        Catch ex As Exception
            MsgBox("Error. Can not connect with the databases", MsgBoxStyle.Critical, "Advertencia")

        End Try

    End Sub



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        query = "SELECT Email FROM USER WHERE Email='&txt_email.Text'"
        command = New OleDbCommand(query, connection)
        adapter.SelectCommand = command
        reader = command.ExecuteReader
        If reader.HasRows = True Then
            MsgBox("acept", MsgBoxStyle.Information, "Allow to Access")
            clean_focus()
            Dim f2 As New MainWindow
            f2.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Email, please try again", MsgBoxStyle.Critical, "Warning")



        End If

    End Sub

    Private Sub clean_focus()
        txt_email.Clear()
        txt_email.Focus()

    End Sub



    Private Sub btn_signUp_Click(sender As Object, e As EventArgs) Handles btn_signUp.Click
        Dim f2 As New SignUp
        f2.Show()
        Me.Hide()
    End Sub
End Class
