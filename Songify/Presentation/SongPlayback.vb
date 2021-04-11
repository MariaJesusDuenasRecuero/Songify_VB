Public Class SongPlayback
    Public Songs As Collection
    Private Sub Playback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SongDAO As SongDAO
        SongDAO = New SongDAO()
        Songs = SongDAO.ReadAll("C:\songify.accdb")
        For Each song In Songs
            ListBox1.Items.Add(song.sName)
        Next
    End Sub

    Private Sub PlaySong(sender As Object, e As EventArgs) Handles Play.Click
        ProgressBar1.Value = 0
        Dim SelectedSong As String : Dim SongSelected As Song
        SelectedSong = ListBox1.SelectedItem
        For Each song In Songs
            If SelectedSong = song.sName Then
                SongSelected = song
            End If
        Next
        For L As Double = 0.0 To SongSelected.length
            ProgressBar1.Increment(L)
        Next L
    End Sub


End Class