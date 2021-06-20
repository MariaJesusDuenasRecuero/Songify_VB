Public Class Songs
    Public SongsCollection As Collection
    Public SongSelected As Song
    Public EmailUser As String
    Public User As User
    Public IdPlay As Integer
    Public path As String
    Public Albums As Collection

    Private Sub Songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Michi.Enabled = False
        songNametxt.Text = ""
        songNametxt.Visible = False
        AlbumSongtxt.Text = ""
        AlbumSongtxt.Visible = False
        SongLengthtxt.Text = ""
        SongLengthtxt.Visible = False
        btn_update.Enabled = False
        EmailLog.Text = EmailUser

        loadSongs()
        ListBox2.Items.Add("User" & "\" & "Date")
        Dim AlbumReader As New Album
        Albums = CType(AlbumReader.ReadAllAlbums(path), Collection)
        Play.Enabled = False
    End Sub

    Public Sub New(email As String, path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        EmailUser = email
        Me.path = path
    End Sub

    Private Sub SelectSong(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        ListBox2.Items.Clear()
        ListBox2.Items.Add("User" & "\" & "Date")
        Play.Enabled = True
        btn_update.Enabled = True
        Dim Song As Song : Dim album As Album : Dim playback As User : Dim aName As String
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim SelectedSong As String : Dim AlbumName As String : Dim SLength As String : Dim userDAO As New User() : Dim playbacks As Collection
        AlbumDAO = New Album()
        Albums = CType(AlbumDAO.ReadAllAlbums(path), Collection)
        SelectedSong = CStr(ListBox1.SelectedItem)
        If SelectedSong IsNot Nothing Then
            playbacks = CType(userDAO.ReadAllPlaybacks(path), Collection)
            For Each Song In SongsCollection
                If SelectedSong = Song.GetName() Then
                    SongSelected = Song
                End If
            Next
            For Each album In Albums
                If SongSelected.GetAlbum() = album.GetIdAlbum() Then
                    AlbumName = album.GetName()
                End If
            Next
            For Each playback In playbacks
                If playback.GetSong() = SongSelected.getIdSong() Then
                    ListBox2.Items.Add(playback.GetEmail() & "\" & playback.GetPlDate())
                End If
            Next
            SLength = CalcularTiempo(SongSelected.GetSLength())
            songNametxt.Text = SelectedSong
            songNametxt.Visible = True
            AlbumSongtxt.Text = AlbumName
            AlbumSongtxt.Visible = True
            SongLengthtxt.Text = SLength
            SongLengthtxt.Visible = True
            Play.Image = My.Resources.jugar1
            songnametxtbox.Text = SongSelected.GetName()
            songalbumtxtbox.Text = AlbumName
            songlengthtxtbox.Text = CStr(SongSelected.GetSLength())
        Else
            MsgBox("You didn't select a song")
        End If

    End Sub
    Private Sub PlaySong(sender As Object, e As EventArgs) Handles Play.Click
        ProgressBar1.Value = 0
        Dim PlayBackSong As User
        If SongSelected IsNot Nothing Then
            PlayBackSong = New User()
            PlayBackSong.setEmail(EmailUser)
            PlayBackSong.SetSong(SongSelected.getIdSong())
            PlayBackSong.SetPlDate(Date.Today())
            Michi.Enabled = True

            Try
                PlayBackSong.InsertPlayBack()
                ListBox2.Items.Add(PlayBackSong.GetEmail() & "\" & PlayBackSong.GetPlDate())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            For L As Integer = 0 To SongSelected.getLength() * 100
                ProgressBar1.Increment(L)
            Next L
        Else
            MsgBox("Error")
        End If
    End Sub
    Private Sub btnPlay(sender As Object, e As EventArgs) Handles Play.MouseHover
        Play.Image = Nothing
        Play.Image = My.Resources.jugar1
        Play.ImageAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Sub btnPause(sender As Object, e As EventArgs) Handles Play.MouseLeave
        Play.Image = Nothing
        Play.Image = My.Resources.boton_de_pausa_de_video
        Play.ImageAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Function CalcularTiempo(length As Integer) As String
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = CInt(Math.Floor(length / 3600))
        minutos = CInt(Math.Floor((length - horas * 3600) / 60))
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function
    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Play.Enabled = False
        Dim sName As String : Dim albumName As String : Dim length As Integer : Dim SongAdd As New Song : Dim IdAlbum As Integer : Dim album As Album
        Try
            sName = songnametxtbox.Text
            albumName = songalbumtxtbox.Text
            length = CInt(songlengthtxtbox.Text)
            SongAdd.SetName(sName)
            For Each album In Albums
                If albumName = album.GetName() Then
                    IdAlbum = album.GetIdAlbum()
                End If
            Next
            If (sName = "" Or albumName = "" Or CStr(length) = "") Then
                MessageBox.Show("There is blank space in the register please try again")
            Else
                If (length >= 0) Then
                    SongAdd.SetAlbum(IdAlbum)
                    SongAdd.SetLength(length)
                    Try
                        SongAdd.InsertSong()
                        MsgBox("Song added")
                        loadSongs()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("You can't add a negative length!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Play.Enabled = False
        Dim sName As String : Dim albumName As String : Dim length As Integer : Dim SongUpdate As Song : Dim IdAlbum As Integer : Dim album As Album : Dim albumCorrect As Boolean = False
        SongUpdate = New Song
        sName = songnametxtbox.Text
        albumName = songalbumtxtbox.Text
        Try
            length = CInt(songlengthtxtbox.Text)
            For Each album In Albums
                If albumName = album.GetName() Then
                    IdAlbum = album.GetIdAlbum()
                    albumCorrect = True
                End If
            Next
            If (sName = "" Or albumName = "" Or CStr(length) = "") Then
                MessageBox.Show("There is blank space in the register please try again")
            Else
                If (length >= 0) Then
                    SongUpdate.setIdSong(SongSelected.getIdSong())
                    SongUpdate.SetName(sName)
                    SongUpdate.SetAlbum(IdAlbum)
                    SongUpdate.SetLength(length)
                    Try
                        If (albumCorrect = True) Then

                            SongUpdate.UpdateSong()
                            loadSongs()
                            MsgBox("Song updated successfully")
                        Else
                            MsgBox("The album wasn't added in our database")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Else
                    MsgBox("You can't update with a negative length!")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Play.Enabled = False
        Dim SongDelete As Song
        SongDelete = New Song()
        Try
            If SongSelected IsNot Nothing Then
                SongDelete.setIdSong(SongSelected.getIdSong())
                SongDelete.DeleteSong()
                MsgBox("Song deleted successfully")
                loadSongs()
            Else
                MsgBox("You must select the song to delete")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub loadSongs()
        ListBox1.Items.Clear()
        Dim song As Song
        Dim SongDAO = New Song()
        SongsCollection = CType(SongDAO.ReadAllSongs(path), Collection)
        For Each song In SongsCollection
            ListBox1.Items.Add(song.GetName())
        Next
    End Sub
    Private Sub CleanBtn_Click(sender As Object, e As EventArgs) Handles CleanBtn.Click
        songnametxtbox.Text = ""
        songalbumtxtbox.Text = ""
        songlengthtxtbox.Text = ""
    End Sub

End Class