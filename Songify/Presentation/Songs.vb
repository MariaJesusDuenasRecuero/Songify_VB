Public Class Songs
    Public Songs As Collection
    Public SongSelected As Song
    Public EmailUser As String
    Public User As User
    Public IdPlay As Integer
    Private email As String

    Private Sub Songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SongDAO As Song
        songName.Text = ""
        songName.Visible = False
        AlbumSong.Text = ""
        AlbumSong.Visible = False
        SongLength.Text = ""
        SongLength.Visible = False
        EmailLog.Text = EmailUser
        SongDAO = New Song()
        Songs = SongDAO.ReadAllSongs("C:\songify.accdb")
        For Each Song In Songs
            ListBox1.Items.Add(Song.GetName())
        Next
    End Sub
    Public Sub New(ByVal email As String, ByVal Song As Song)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EmailUser = email
        SongSelected = Song

    End Sub

    Public Sub New(email As String)
        Me.email = email
    End Sub

    Private Sub SelectSong(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim SelectedSong As String : Dim AlbumName As String : Dim SLength As String
        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums("C:\songify.accdb")
        SelectedSong = ListBox1.SelectedItem
        For Each Song In Songs
            If SelectedSong = Song.GetName() Then
                SongSelected = Song
            End If
        Next
        For Each album In Albums
            If SongSelected.GetAlbum() = album.GetIdAlbum() Then
                AlbumName = album.GetName()
            End If
        Next
        SLength = CalcularTiempo(SongSelected.GetSLength())
        songName.Text = SelectedSong
        songName.Visible = True
        AlbumSong.Text = AlbumName
        AlbumSong.Visible = True
        SongLength.Text = SLength
        SongLength.Visible = True
    End Sub
    Public Function CalcularTiempo(length As Integer)
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = Math.Floor(length / 3600)
        minutos = Math.Floor((length - horas * 3600) / 60)
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function
    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser)
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub Playback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Songtxt.Text = SongSelected.GetName()
    End Sub
End Class