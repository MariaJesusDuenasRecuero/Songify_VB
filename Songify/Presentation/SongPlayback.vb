Public Class SongPlayback
    Public Songs As Collection
    Public User As User
    Public EmailUser As String
    Public IdPlay = 5
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
        ProgressBar1.Value = 0
        Dim PlayBack As Playback
        If SongSelected IsNot Nothing Then
            PlayBack = New Playback(IdPlay)
            PlayBack.SetUser(User.GetEmail())
            PlayBack.SetSong(SongSelected.getIdSong())
            PlayBack.SetPlDate(Date.Today)
            IdPlay += 1
            PlayBack.InsertPlayBack()
            For L As Double = 0.0 To SongSelected.getLength()
                ProgressBar1.Increment(L)
            Next L
        Else
            MsgBox("Error")
        End If
    End Sub


End Class