Public Class Artists
    Public SelectedArtist As Artist
    Public Artists As Collection
    Public EmailUser As String
    Public path As String
    Public FavArtists As Collection
    Public imageartist As String
    Private Sub ofdPath_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPath.FileOk
        Me.ofdPath.InitialDirectory = Application.StartupPath
    End Sub
    Private Sub btn_selectImage_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            If (ofdPath.FileName.Contains(".jpg") Or ofdPath.FileName.Contains(".png")) Then
                imageartist = ofdPath.FileName
                MsgBox("Operation successful")
            Else
                MsgBox("It isn't an appropiate image format")
            End If
        End If
    End Sub
    Private Sub Artists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        country.Text = ""
        country.Visible = False
        EmailLog.Text = EmailUser
        unFavButton.Enabled = False
        btn_update.Enabled = False
        loadArtists()
        favArtistsload()
        btnFav.Enabled = False
    End Sub
    Public Sub loadArtists()
        Dim ArtistDAO As Artist
        ArtistDAO = New Artist()
        Artists = CType(ArtistDAO.ReadAllArtists(path), Collection)
        lsb_artist.Items.Clear()
        Dim artist As Artist
        For Each artist In Artists
            lsb_artist.Items.Add(artist.GetName())
        Next
    End Sub

    Public Sub favArtistsload()
        lsb_favArtist.Items.Clear()
        Dim idartists As New Collection : Dim artist As Artist
        Dim ArtistReader As New Artist
        FavArtists = CType(ArtistReader.ReadAllFavArtists(path), Collection)
        For Each artist In FavArtists
            If artist.GetUser() = EmailUser Then
                idartists.Add(artist.GetIdArtist())
            End If
        Next
        For Each artist In Artists
            For Each IdArtist In idartists
                If artist.GetIdArtist().Equals(IdArtist) Then
                    lsb_favArtist.Items.Add(artist.GetName())
                End If
            Next
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
        btn_update.Enabled = True
        lst_album.Items.Clear()
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim ArtistName As String : Dim artist As Artist : Dim album As Album
        btnFav.Enabled = True
        unFavButton.Enabled = False
        AlbumDAO = New Album()
        Albums = CType(AlbumDAO.ReadAllAlbums(path), Collection)
        ArtistName = CStr(lsb_artist.SelectedItem)
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
            Try
                im_artists.Image = Image.FromFile(SelectedArtist.GetImage())
            Catch ex As Exception
                MsgBox("The image from this artist has been changed or deleted")
            End Try
            artistnametxt.Text = SelectedArtist.GetName()
            artistcountrytxt.Text = SelectedArtist.GetCountry()
            btnFav.Enabled = True
        Else
            MsgBox("You didn't select an artist, select one", MsgBoxStyle.OkOnly, "Warning")
        End If
    End Sub

    Private Sub loadFavArtists(sender As Object, e As EventArgs) Handles lsb_favArtist.SelectedIndexChanged

        btn_update.Enabled = True
        lst_album.Items.Clear()
        unFavButton.Enabled = True
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim ArtistName As String : Dim artist As Artist : Dim album As Album
        btnFav.Enabled = False
        AlbumDAO = New Album()
        Albums = CType(AlbumDAO.ReadAllAlbums(path), Collection)
        ArtistName = CStr(lsb_favArtist.SelectedItem)
        If ArtistName IsNot Nothing Then
            For Each artist In Artists
                If artist.GetName() = ArtistName Then
                    SelectedArtist = artist
                End If
            Next
            For Each album In Albums
                If SelectedArtist.GetIdArtist() = album.getArtist() Then
                    lst_album.Items.Add(album.GetName())
                End If
            Next

            aName.Visible = True
            aName.Text = SelectedArtist.GetName()
            country.Visible = True
            country.Text = SelectedArtist.GetCountry()
            Try
                im_artists.Image = Image.FromFile(SelectedArtist.GetImage())
            Catch ex As Exception
                MsgBox("The image from this artist has been changed or deleted")
            End Try
            artistnametxt.Text = SelectedArtist.GetName()
            artistcountrytxt.Text = SelectedArtist.GetCountry()
        Else
            MsgBox("You didn't select an artist, select one", MsgBoxStyle.OkOnly, "Warning")
        End If

    End Sub

    Private Sub CovertArtistToFav(sender As Object, e As EventArgs) Handles btnFav.Click
        Dim ArtistsCollection As Collection : Dim Selected_Artist As String : Dim ArtistDAO As Artist : Dim repetidos As Boolean = False : Dim Artist As Artist
        ArtistDAO = New Artist()
        ArtistsCollection = CType(ArtistDAO.ReadAllArtists(path), Collection)
        Selected_Artist = CStr(lsb_artist.SelectedItem)
        Try
            For Each Artist In ArtistsCollection
                If Selected_Artist = Artist.GetName() Then
                    SelectedArtist = Artist
                End If
            Next
            For Each artist In FavArtists
                If artist.getIdArtist() = SelectedArtist.GetIdArtist() And artist.getUser() = EmailUser Then
                    repetidos = True
                End If
            Next
            If repetidos = False Then
                Dim FavArtist As Artist
                FavArtist = New Artist()
                FavArtist.SetUser(EmailUser)
                FavArtist.setIdArtist(SelectedArtist.GetIdArtist())
                FavArtist.SetFavDate(Date.Today())
                FavArtist.InsertFav_Artist()
                MsgBox("Artist added to favorites")
                favArtistsload()
            Else
                MsgBox("You have this artist in favorites")
            End If
        Catch ex As Exception
            MsgBox("Select an artist", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub UnFavArtist(sender As Object, e As EventArgs) Handles unFavButton.Click
        Dim FavArtistsCollection As Collection : Dim Selected_Artist As String : Dim ArtistDAO As Artist : Dim Artist As Artist
        ArtistDAO = New Artist()
        FavArtistsCollection = CType(ArtistDAO.ReadAllArtists(path), Collection)
        Selected_Artist = CStr(lsb_favArtist.SelectedItem)
        For Each Artist In FavArtistsCollection
            If Selected_Artist = Artist.GetName() Then
                SelectedArtist = Artist
            End If
        Next
        Dim FavArtist As Artist
        FavArtist = New Artist()
        FavArtist.setIdArtist(SelectedArtist.GetIdArtist())
        FavArtist.DeleteFav_Artist()
        MsgBox("Artist removed from favorites")
        favArtistsload()
        If (lsb_favArtist.Items.Count = 0) Then
            unFavButton.Enabled = False
        End If
    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim aName As String : Dim country As String : Dim ArtistAdd As New Artist : Dim iguales As Boolean = False : Dim artist As Artist
        Try
            aName = artistnametxt.Text
            country = artistcountrytxt.Text
            For Each artist In Artists
                If artist.getName() = aName Then
                    iguales = True
                End If
            Next
            If iguales = False Then
                If (aName = "" Or country = "" Or imageartist = "") Then
                    MessageBox.Show("There is blank space in the register please try again")
                Else
                    ArtistAdd.SetName(aName)
                    ArtistAdd.SetCountry(country)
                    ArtistAdd.SetImage(imageartist)
                    Try
                        ArtistAdd.InsertArtist()
                        MsgBox("Artist added")
                        loadArtists()
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                End If
            Else
                MsgBox("This artist is already in the database")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim aName As String : Dim country As String : Dim ArtistUpdate As Artist
        ArtistUpdate = New Artist
        aName = artistnametxt.Text
        country = artistcountrytxt.Text
        ArtistUpdate.setIdArtist(SelectedArtist.GetIdArtist())
        ArtistUpdate.SetName(aName)
        ArtistUpdate.SetCountry(country)
        ArtistUpdate.SetImage(imageartist)

        If (aName = "" Or country = "" Or imageartist = "") Then
            MessageBox.Show("There is blank space in the register please try again")
        Else
            Try
                ArtistUpdate.UpdateArtist()
                MsgBox("Artist updated successfully")
                loadArtists()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim ArtistDelete As Artist
        ArtistDelete = New Artist()
        Try
            If SelectedArtist IsNot Nothing Then
                ArtistDelete.setIdArtist(SelectedArtist.GetIdArtist())
                ArtistDelete.DeleteArtist()
                MsgBox("Artist deleted successfully")
                loadArtists()
                artistnametxt.Text = ""
                artistcountrytxt.Text = ""
                im_artists.Image.Dispose()
                im_artists.Image = My.Resources.imagenDefault
            Else
                MsgBox("You must select an artist to delete")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CleanBtn_Click(sender As Object, e As EventArgs) Handles CleanBtn.Click
        artistnametxt.Text = ""
        artistcountrytxt.Text = ""
        im_artists.Image.Dispose()
        im_artists.Image = My.Resources.imagenDefault
    End Sub
End Class