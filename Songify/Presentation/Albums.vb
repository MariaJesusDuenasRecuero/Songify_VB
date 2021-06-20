

Public Class Albums
    Public Albums As Collection
    Public SelectedAlbum As Album
    Public Artists As Collection
    Public EmailUser As String
    Public path As String
    Public cover As String
    Private Sub Albums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        releaseDate.Text = ""
        releaseDate.Visible = False
        Length.Text = ""
        Length.Visible = False
        EmailLog.Text = EmailUser
        btn_delete.Enabled = False
        btn_update.Enabled = False
        loadAlbums()
        Dim ArtistReader As New Artist
        Artists = CType(ArtistReader.ReadAllArtists(path), Collection)
    End Sub
    Public Sub loadAlbums()
        Dim AlbumDAO As Album
        AlbumDAO = New Album() : Dim album As New Album()
        Albums = CType(AlbumDAO.ReadAllAlbums(path), Collection)
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
    Private Sub ofdPath_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdPath.FileOk
        Me.ofdPath.InitialDirectory = Application.StartupPath
    End Sub
    Private Sub btn_selectDB_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            If (ofdPath.FileName.Contains(".jpg") Or ofdPath.FileName.Contains(".png")) Then
                cover = ofdPath.FileName
                MsgBox("Operation successful")
            Else
                MsgBox("It isn't an appropiate image format")
            End If
        End If
    End Sub
    Private Sub loadData(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim album As Album : Dim song As Song : Dim artist As Artist
        ListBox2.Items.Clear()
        btn_delete.Enabled = True
        btn_update.Enabled = True
        Dim Songs As Collection : Dim SongDAO As Song : Dim AlbumName As String : Dim AlbumDAO As Album : Dim ArtistDAO As Artist : Dim artistname As String : Dim lengthalbum As Integer : Dim lengthtotal As String
        lengthalbum = 0
        SongDAO = New Song()
        Songs = CType(SongDAO.ReadAllSongs(path), Collection)
        AlbumName = CStr(ListBox1.SelectedItem)
        If AlbumName IsNot Nothing Then
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
            Artists = CType(ArtistDAO.ReadAllArtists(path), Collection)
            For Each artist In Artists
                If artist.GetIdArtist() = SelectedAlbum.getArtist() Then
                    artistname = artist.GetName()
                End If
            Next
            lengthtotal = CalcularTiempo(lengthalbum)
            aName.Visible = True
            aName.Text = artistname
            releaseDate.Visible = True
            releaseDate.Text = CStr(SelectedAlbum.getReleaseDate())
            Length.Visible = True
            Length.Text = lengthtotal
            Try
                img_album.Image = Image.FromFile(SelectedAlbum.GetCover())
            Catch ex As Exception
                MsgBox("The image from this artist has been changed or deleted")
            End Try

            albumnametxt.Text = SelectedAlbum.GetName()
            albumreleaseDatetxt.Text = CStr(SelectedAlbum.getReleaseDate())
            albumartisttxt.Text = artistname
        Else
            MsgBox("You didn't select an album")
        End If

    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub
    Public Function CalcularTiempo(length As Integer) As String
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = CInt(Math.Floor(length / 3600))
        minutos = CInt(Math.Floor((length - horas * 3600) / 60))
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim artist As Artist : Dim album As Album
        Dim aName As String : Dim dateR As Date : Dim artistname As String : Dim AlbumAdd As New Album : Dim artistID As Integer : Dim iguales As Boolean = False
        Try
            aName = albumnametxt.Text
            dateR = CDate(albumreleaseDatetxt.Text)
            artistname = albumartisttxt.Text
            For Each artist In Artists
                If artistname = artist.GetName() Then
                    artistID = artist.getIdArtist()
                End If
            Next
            For Each album In Albums
                If album.GetName() = aName Then
                    iguales = True
                End If
            Next
            If iguales = False Then
                If (aName = "" Or dateR = Nothing Or artistname = "") Then
                    MessageBox.Show("There is blank space in the register (name, releaseDate, artist, cover) please try again")
                Else
                    AlbumAdd.SetName(aName)
                    AlbumAdd.SetDate(dateR)
                    AlbumAdd.SetArtist(artistID)
                    AlbumAdd.SetCover(cover)
                    Try
                        AlbumAdd.InsertAlbum()
                        MsgBox("Album added successfully")
                        loadAlbums()
                        cover = ""
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MsgBox("This album is already in the database")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim artist As Artist
        Dim aName As String : Dim dateR As Date : Dim artistname As String : Dim AlbumUpdate As Album : Dim artistID As Integer
        AlbumUpdate = New Album
        Try
            aName = albumnametxt.Text
            dateR = CDate(albumreleaseDatetxt.Text)
            artistname = albumartisttxt.Text
            For Each artist In Artists
                If artistname = artist.GetName() Then
                    artistID = artist.getIdArtist()
                End If
            Next
            If (aName = "" Or dateR = Nothing Or artistname = "") Then
                MessageBox.Show("There is blank space in the register please try again")
            Else
                AlbumUpdate.setIdAlbum(SelectedAlbum.GetIdAlbum())
                AlbumUpdate.SetName(aName)
                AlbumUpdate.SetDate(dateR)
                AlbumUpdate.SetArtist(artistID)
                AlbumUpdate.SetCover(cover)
                Try
                    Try
                        AlbumUpdate.UpdateAlbum()
                        MsgBox("Album Updated successfully")
                        loadAlbums()
                        cover = ""
                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
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
            MsgBox("Album deleted successfully")
            albumnametxt.Text = ""
            albumartisttxt.Text = ""
            albumreleaseDatetxt.Text = ""
            img_album.Image = My.Resources.imagenDefault
            loadAlbums()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CleanBtn_Click(sender As Object, e As EventArgs) Handles CleanBtn.Click
        albumnametxt.Text = ""
        albumartisttxt.Text = ""
        albumreleaseDatetxt.Text = ""
        img_album.Image = My.Resources.imagenDefault
    End Sub

End Class