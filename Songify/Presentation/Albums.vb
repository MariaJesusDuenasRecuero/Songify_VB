

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
        Albums = AlbumDAO.ReadAllAlbums(path)
        For Each album In Albums
            ListBox1.Items.Add(album.GetName())
        Next
        Dim ArtistReader As New Artist
        Artists = ArtistReader.ReadAllArtists(path)
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
        Dim Songs As Collection : Dim SongDAO As Song : Dim AlbumName As String : Dim AlbumDAO As Album : Dim ArtistDAO As Artist : Dim artistname As String : Dim lengthalbum As Integer : Dim lengthtotal As String
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

        lengthtotal = CalcularTiempo(lengthalbum)
        aName.Visible = True
        aName.Text = artistname
        releaseDate.Visible = True
        releaseDate.Text = SelectedAlbum.getReleaseDate()
        Length.Visible = True
        Length.Text = lengthtotal
        img_album.Image = Image.FromFile(SelectedAlbum.GetCover())
        albumnametxt.Text = SelectedAlbum.GetName()
        albumreleaseDatetxt.Text = SelectedAlbum.getReleaseDate()
        albumartisttxt.Text = artistname
        TextBox1.Text = SelectedAlbum.GetCover()
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

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim aName As String : Dim dateR As Date : Dim artistname As String : Dim AlbumAdd As New Album : Dim artistID As Integer
        aName = albumnametxt.Text
        dateR = albumreleaseDatetxt.Text
        artistname = albumartisttxt.Text
        For Each artist In Artists
            If artistname = artist.GetName() Then
                artistID = artist.getIdArtist()
            End If
        Next
        AlbumAdd.SetName(aName)
        AlbumAdd.SetDate(dateR)
        AlbumAdd.SetArtist(artistID)
        Try
            AlbumAdd.InsertAlbum()
            MsgBox("Album added successfully")
            ListBox1.Items.Add(AlbumAdd.GetName())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim aName As String : Dim dateR As Date : Dim artistname As String : Dim cover As String : Dim AlbumUpdate As Album : Dim artistID As Integer
        AlbumUpdate = New Album
        aName = albumnametxt.Text
        dateR = albumreleaseDatetxt.Text
        artistname = albumartisttxt.Text
        cover = TextBox1.Text
        For Each artist In Artists
            If artistname = artist.GetName() Then
                artistID = artist.getIdArtist()
            End If
        Next
        AlbumUpdate.setIdAlbum(SelectedAlbum.GetIdAlbum())
        AlbumUpdate.SetName(aName)
        AlbumUpdate.SetDate(dateR)
        AlbumUpdate.SetArtist(artistID)
        AlbumUpdate.SetCover(cover)
        Try
            AlbumUpdate.UpdateAlbum()
            MsgBox("Album Updated successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim aName As String : Dim AlbumDelete As Album
        AlbumDelete = New Album()
        AlbumDelete.setIdAlbum(SelectedAlbum.GetIdAlbum())
        Try
            AlbumDelete.DeleteAlbum()
            ListBox1.Items.Remove(AlbumDelete.GetName())
            MsgBox("Album deleted successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class