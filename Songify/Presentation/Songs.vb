Public Class Songs
    Public Songs As Collection
    Public SongSelected As Song
    Private Sub Songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SongDAO As SongDAO
        songName.Text = ""
        songName.Visible = False
        AlbumSong.Text = ""
        AlbumSong.Visible = False
        SongLength.Text = ""
        SongLength.Visible = False
        SongDAO = New SongDAO()
        Songs = SongDAO.ReadAll("C:\songify.accdb")
        For Each song In Songs
            ListBox1.Items.Add(song.sName)
        Next
    End Sub
    Private Sub SelectSong(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Albums As Collection : Dim AlbumDAO As AlbumDAO : Dim SelectedSong As String : Dim AlbumName As String : Dim SLength As String
        AlbumDAO = New AlbumDAO()
        Albums = AlbumDAO.ReadAll("C:\songify.accdb")
        SelectedSong = ListBox1.SelectedItem
        For Each song In Songs
            If SelectedSong = song.sName Then
                SongSelected = song
            End If
        Next
        For Each album In Albums
            If SongSelected.Album = album.IdAlbum Then
                AlbumName = album.aName
            End If
        Next
        SLength = CalcularTiempo(SongSelected.length)
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
        Dim f2 As New MainWindow
        f2.Show()
        Me.Hide()
    End Sub
End Class