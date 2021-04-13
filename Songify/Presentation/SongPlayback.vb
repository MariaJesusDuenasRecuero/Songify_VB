Public Class SongPlayback
    Public Songs As Collection
    Public User As User
    Public EmailUser As String
    Public IdPlay As Integer
    Public SongSelected As Song
    Private Sub Playback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(ByVal email As String, ByVal Song As Song)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EmailUser = email
        SongSelected = Song

    End Sub

    Private Sub PlaySong(sender As Object, e As EventArgs) Handles Play.Click
        Dim Playbacks As Collection : Dim UserDAO As UserDAO
        UserDAO = New UserDAO()
        Playbacks = UserDAO.ReadAllPlaybacks("C:\songify.accdb")
        For Each playback In Playbacks
            IdPlay += 1
        Next
        ProgressBar1.Value = 0
        Dim PlayBackSong As Playback
        If SongSelected IsNot Nothing Then
            IdPlay += 1
            PlayBackSong = New Playback(IdPlay)
            PlayBackSong.SetUser(EmailUser)
            PlayBackSong.SetSong(SongSelected.getIdSong())
            PlayBackSong.SetPlDate(Date.Today)
            PlayBackSong.InsertPlayBack()
            For L As Double = 0.0 To SongSelected.getLength()
                ProgressBar1.Increment(L)
            Next L
        Else
            MsgBox("Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New MainWindow(EmailUser)
        f2.Show()
        Me.Hide()
    End Sub
End Class