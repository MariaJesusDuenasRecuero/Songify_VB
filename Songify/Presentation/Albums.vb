Public Class Albums
    Public Albums As Collection
    Public SelectedAlbum As Album
    Public Artists As Collection
    Private Sub Albums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        releaseDate.Text = ""
        releaseDate.Visible = False
        Length.Text = ""
        Length.Visible = False
        Dim AlbumDAO As AlbumDAO
        AlbumDAO = New AlbumDAO()
        Albums = AlbumDAO.ReadAll("C:\songify.accdb")
        For Each album In Albums
            ListBox1.Items.Add(album.aName)
        Next

    End Sub
    Private Sub loadData(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Dim Songs As Collection : Dim SongDAO As SongDAO : Dim AlbumName As String : Dim AlbumDAO As AlbumDAO : Dim ArtistDAO As ArtistDAO : Dim artistname As String : Dim lengthalbum As Integer : Dim lengthtotal As String
        lengthalbum = 0
        SongDAO = New SongDAO()
        Songs = SongDAO.ReadAll("C:\songify.accdb")
        AlbumName = ListBox1.SelectedItem
        For Each album In Albums
            If album.aName = AlbumName Then
                SelectedAlbum = album
            End If
        Next
        For Each song In Songs
            If song.Album = SelectedAlbum.GetIdAlbum() Then
                ListBox2.Items.Add(song.sName)
                lengthalbum = lengthalbum + song.length
            End If
        Next
        ArtistDAO = New ArtistDAO()
        Artists = ArtistDAO.ReadAll("C:\songify.accdb")
        For Each artist In Artists
            If artist.IdArtist = SelectedAlbum.getArtist() Then
                artistname = artist.aName
            End If
        Next
        lengthtotal = CalcularTiempo(lengthalbum)
        aName.Visible = True
        aName.Text = artistname
        releaseDate.Visible = True
        releaseDate.Text = SelectedAlbum.getReleaseDate()
        Length.Visible = True
        Length.Text = lengthtotal
    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow
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