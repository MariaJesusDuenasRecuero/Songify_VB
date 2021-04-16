Public Class SongPlayback
    Public Songs As Collection
    Public User As User
    Public EmailUser As String
    Public IdPlay As Integer
    Public SongSelected As Song
    Private Sub Playback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Song.Text = SongSelected.GetName()
    End Sub
    Public Sub New(ByVal email As String, ByVal Song As Song)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EmailUser = email
        SongSelected = Song

    End Sub

    Private Sub PlaySong(sender As Object, e As EventArgs) Handles Play.Click
        Dim Playbacks As Collection : Dim UserDAO As User
        UserDAO = New User()
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
                ProgressBar1.Increment(L - 0.5)
            Next L
        Else
            MsgBox("Error")
        End If
        Play.Image = Nothing
        Play.Image = My.Resources.boton_de_pausa_de_video
        Play.ImageAlign = ContentAlignment.MiddleCenter
        'If ProgressBar1.Value = SongSelected.getLength() Then
        'Play.Image = Nothing
        'Play.Image = My.Resources.jugar1
        'Play.ImageAlign = ContentAlignment.MiddleCenter
        'End If
    End Sub

End Class