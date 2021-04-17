﻿Public Class Songs
    Public SongsCollection As Collection
    Public SongSelected As Song
    Public EmailUser As String
    Public User As User
    Public IdPlay As Integer
    Public path As String
    Private Sub Songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SongDAO As Song
        songNametxt.Text = ""
        songNametxt.Visible = False
        AlbumSongtxt.Text = ""
        AlbumSongtxt.Visible = False
        SongLengthtxt.Text = ""
        SongLengthtxt.Visible = False
        historytxt.Visible = False
        Label2.Text = ""
        Label2.Visible = False
        EmailLog.Text = EmailUser
        SongDAO = New Song()
        SongsCollection = SongDAO.ReadAllSongs(path)
        For Each song In SongsCollection
            ListBox1.Items.Add(song.GetName())
        Next
        ListBox2.Items.Add("User" & "\" & "Date")
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
        Dim Albums As Collection : Dim AlbumDAO As Album : Dim SelectedSong As String : Dim AlbumName As String : Dim SLength As String : Dim userDAO As New User() : Dim playbacks As Collection
        AlbumDAO = New Album()
        Albums = AlbumDAO.ReadAllAlbums(path)
        SelectedSong = ListBox1.SelectedItem
        playbacks = userDAO.ReadAllPlaybacks(path)
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
                ListBox2.Items.Add(playback.GetUser() & "\" & playback.getPlDate())
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
        historytxt.Visible = True
        Label2.Text = SongSelected.GetName()
        Label2.Visible = True
    End Sub
    Private Sub PlaySong(sender As Object, e As EventArgs) Handles Play.Click
        Dim Playbacks As Collection : Dim UserDAO As User
        UserDAO = New User()
        Playbacks = UserDAO.ReadAllPlaybacks(path)
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
            For L As Integer = 0 To SongSelected.getLength() * 100
                ProgressBar1.Increment(L)
            Next L
        Else
            MsgBox("Error")
        End If
        'If ProgressBar1.Value = SongSelected.getLength() Then
        'Play.Image = Nothing
        'Play.Image = My.Resources.jugar1
        'Play.ImageAlign = ContentAlignment.MiddleCenter
        'End If
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
    Private Function CalcularTiempo(length As Integer)
        Dim horas As Integer : Dim minutos As Integer : Dim segundos As Integer : Dim horatotal As String
        horas = Math.Floor(length / 3600)
        minutos = Math.Floor((length - horas * 3600) / 60)
        segundos = length - (horas * 3600 + minutos * 60)
        horatotal = horas & ":" & minutos & ":" & segundos
        Return horatotal
    End Function
    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow(EmailUser, path)
        f2.Show()
        Me.Hide()
    End Sub


End Class