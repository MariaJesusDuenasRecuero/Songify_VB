Imports System.IO
Imports System.Net

Public Class Albums
    Public Albums As Collection
    Public SelectedAlbum As Album
    Public Artists As Collection
    Public EmailUser As String
    Public path As String
    Private Sub Albums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        releaseDate.Text = ""
        releaseDate.Visible = False
        Length.Text = ""
        Length.Visible = False
        EmailLog.Text = EmailUser
        Dim AlbumDAO As Album
        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums("C:\Users\manue\Documents\songify.accdb")
        For Each album In Albums
            ListBox1.Items.Add(album.GetName())
        Next

    End Sub
    Public Sub New(EmailUser As String, path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.EmailUser = EmailUser
        Me.path = path
    End Sub
    Private Sub loadData(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Dim Songs As Collection : Dim SongDAO As Song : Dim AlbumName As String : Dim AlbumDAO As Album : Dim ArtistDAO As Artist : Dim artistname As String : Dim lengthalbum As Integer : Dim lengthtotal As String : Dim wc As New WebClient()
        lengthalbum = 0
        SongDAO = New Song()
        Songs = SongDAO.ReadAllSongs(path)
        AlbumName = ListBox1.SelectedItem
        For Each album In Albums
            If album.GetName() = AlbumName Then
                SelectedAlbum = album
            End If
        Next
        For Each song In Songs
            If song.GetAlbum() = SelectedAlbum.GetIdAlbum() Then
                ListBox2.Items.Add(song.GetName())
                lengthalbum = lengthalbum + song.GetLength()
            End If
        Next
        ArtistDAO = New Artist()
        Artists = ArtistDAO.ReadAllArtists(path)
        For Each artist In Artists
            If artist.GetIdArtist() = SelectedAlbum.getArtist() Then
                artistname = artist.GetName()
            End If
        Next
        Dim datos As Byte() = wc.DownloadData(SelectedAlbum.GetCover())
        Dim ms As New MemoryStream(datos)
        lengthtotal = CalcularTiempo(lengthalbum)
        aName.Visible = True
        aName.Text = artistname
        releaseDate.Visible = True
        releaseDate.Text = SelectedAlbum.getReleaseDate()
        Length.Visible = True
        Length.Text = lengthtotal
        img_album.Image = Image.FromStream(ms)

    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub
    Public Function CalcularTiempo(length As Integer)
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = Math.Floor(length / 3600)
        minutos = Math.Floor((length - horas * 3600) / 60)
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function
End Class