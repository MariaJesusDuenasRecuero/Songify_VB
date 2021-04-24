Public Class Artists
    Public SelectedArtist As Artist
    Public Artists As Collection
    Public EmailUser As String
    Public path As String
    Public FavArtists As Collection
    Private Sub Artists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        country.Text = ""
        country.Visible = False
        EmailLog.Text = EmailUser
        unFavButton.Enabled = False
        Dim ArtistDAO As Artist
        ArtistDAO = New Artist()
        Artists = ArtistDAO.ReadAllArtists(path)
        loadArtists()
        btnFav.Enabled = False
        Dim ArtistReader As New Fav_Artist
        FavArtists = ArtistReader.ReadAllFavArtists(path)
        For Each fav_artist In FavArtists
            If fav_artist.GetUser() = EmailUser Then
                For Each artist In Artists
                    If fav_artist.getArtist() = artist.getIdArtist() Then
                        lsb_favArtist.Items.Add(artist.getName())
                    End If
                Next
            End If
        Next
    End Sub
    Public Sub loadArtists()
        lsb_artist.Items.Clear()
        For Each artist In Artists
            lsb_artist.Items.Add(artist.GetName())
        Next
    End Sub
    Public Sub New(EmailUser As String, path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.EmailUser = EmailUser
        Me.path = path
    End Sub

    Private Sub loadData(sender As Object, e As EventArgs) Handles lsb_artist.SelectedIndexChanged
        lst_album.Items.Clear()
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim ArtistName As String
        btnFav.Enabled = True
        unFavButton.Enabled = False
        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums(path)
        ArtistName = lsb_artist.SelectedItem
        If ArtistName IsNot Nothing Then
            For Each artist In Artists
                If artist.GetName() = ArtistName Then
                    SelectedArtist = artist
                End If
            Next
            For Each album In Albums
                If SelectedArtist.GetIdArtist() = album.GetArtist() Then
                    lst_album.Items.Add(album.GetName())
                End If
            Next

            aName.Visible = True
            aName.Text = SelectedArtist.GetName()
            country.Visible = True
            country.Text = SelectedArtist.GetCountry()
            im_artists.Image = Image.FromFile(SelectedArtist.GetImage())
            artistnametxt.Text = SelectedArtist.GetName()
            artistcountrytxt.Text = SelectedArtist.GetCountry
            artistimgtxt.Text = SelectedArtist.GetImage()
            btnFav.Enabled = True
        Else
            MsgBox("You didn't select an artist, select one", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Private Sub loadFavArtists(sender As Object, e As EventArgs) Handles lsb_favArtist.SelectedIndexChanged
        lst_album.Items.Clear()
        btnFav.Enabled = False
        unFavButton.Enabled = True
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim ArtistName As String
        Dim ArtistReader As New Fav_Artist : Dim FavArtists As Collection
        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums(path)
        ArtistName = lsb_favArtist.SelectedItem
        If ArtistName IsNot Nothing Then
            FavArtists = ArtistReader.ReadAllFavArtists(path)
            For Each artist In Artists
                If artist.GetName() = ArtistName Then
                    SelectedArtist = artist
                End If
            Next
            For Each album In Albums
                If SelectedArtist.GetIdArtist() = album.GetArtist() Then
                    lst_album.Items.Add(album.GetName())
                End If
            Next

            aName.Visible = True
            aName.Text = SelectedArtist.GetName()
            country.Visible = True
            country.Text = SelectedArtist.GetCountry()
            im_artists.Image = Image.FromFile(SelectedArtist.GetImage())
        Else
            MsgBox("You didn't select an artist, select one", MsgBoxStyle.OkOnly, "Warning")
        End If

    End Sub

    Private Sub CovertArtistToFav(sender As Object, e As EventArgs) Handles btnFav.Click
        Dim ArtistsCollection As Collection : Dim Selected_Artist As String : Dim ArtistDAO As Artist : Dim repetidos As Boolean = False
        ArtistDAO = New Artist()
        ArtistsCollection = ArtistDAO.ReadAllArtists(path)
        Selected_Artist = lsb_favArtist.SelectedItem
        loadArtists()
        Try
            For Each Artist In ArtistsCollection
                If Selected_Artist = Artist.GetName() Then
                    SelectedArtist = Artist
                End If
            Next
            For Each fav_Artist In FavArtists
                If fav_Artist.getArtist() = SelectedArtist.GetIdArtist() And fav_Artist.getUser() = EmailUser Then
                    repetidos = True
                End If
            Next
            If repetidos = False Then
                Dim FavArtist As Fav_Artist
                FavArtist = New Fav_Artist()
                FavArtist.SetUser(EmailUser)
                FavArtist.SetArtist(SelectedArtist.GetIdArtist())
                FavArtist.SetFavDate(Date.Today())
                FavArtist.InsertFav_Artist()
                lsb_favArtist.Items.Add(SelectedArtist.GetName())
                MsgBox("Artist added to favorites")
            Else
                MsgBox("You have this artist in favorites")
            End If
        Catch ex As Exception
            MsgBox("Select an artist", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub UnFavArtist(sender As Object, e As EventArgs) Handles unFavButton.Click
        Dim FavArtistsCollection As Collection : Dim Selected_Artist As String : Dim ArtistDAO As Artist
        ArtistDAO = New Artist()
        FavArtistsCollection = ArtistDAO.ReadAllArtists(path)
        Selected_Artist = lsb_favArtist.SelectedItem
        For Each Artist In FavArtistsCollection
            If Selected_Artist = Artist.GetName() Then
                SelectedArtist = Artist
            End If
        Next
        Dim FavArtist As Fav_Artist
        FavArtist = New Fav_Artist()
        FavArtist.SetArtist(SelectedArtist.GetIdArtist())
        FavArtist.DeleteFav_Artist()
        lsb_favArtist.Items.Remove(SelectedArtist.GetName())
        MsgBox("Artist removed from favorites")
    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim aName As String : Dim country As String : Dim image As String : Dim ArtistAdd As New Artist
        aName = artistnametxt.Text
        country = artistcountrytxt.Text
        image = artistimgtxt.Text
        ArtistAdd.SetName(aName)
        ArtistAdd.SetCountry(country)
        ArtistAdd.SetImage(image)
        ArtistAdd.InsertArtist()
        MsgBox("Artist added")
        loadArtists()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim aName As String : Dim country As String : Dim image As String : Dim ArtistUpdate As Artist
        ArtistUpdate = New Artist
        aName = artistnametxt.Text
        country = artistcountrytxt.Text
        image = artistimgtxt.Text
        ArtistUpdate.setIdArtist(SelectedArtist.GetIdArtist())
        ArtistUpdate.SetName(aName)
        ArtistUpdate.SetCountry(country)
        ArtistUpdate.SetImage(image)
        Try
            ArtistUpdate.UpdateArtist()
            loadArtists()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim ArtistDelete As Artist
        ArtistDelete = New Artist()
        ArtistDelete.setIdArtist(SelectedArtist.GetIdArtist())
        Try
            ArtistDelete.DeleteArtist()
            loadArtists()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class