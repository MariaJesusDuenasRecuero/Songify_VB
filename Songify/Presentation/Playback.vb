Public Class Playback
    Private Sub Playback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SongDAO As SongDAO : Dim Songs As Collection
        SongDAO = New SongDAO()
        Songs = SongDAO.ReadAll("C:\songify.accdb")
        For Each song In Songs
            ListBox1.Items.Add(song.sName)
        Next
    End Sub

    Private Sub PlaySong(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class