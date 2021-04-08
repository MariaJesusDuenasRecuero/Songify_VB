Public Class Artists
    Public SelectedArtist As Artist
    Public Artists As Collection
    Private Sub Artists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aName.Text = ""
        aName.Visible = False
        country.Text = ""
        country.Visible = False
        Dim ArtistDAO As ArtistDAO
        ArtistDAO = New ArtistDAO()
        Artists = ArtistDAO.ReadAll("C:\songify.accdb")
        For Each artist In Artists
            ListBox1.Items.Add(artist.aName)
        Next



    End Sub

    Private Sub loadData(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Dim Albums As Collection : Dim AlbumDAO As AlbumDAO : Dim ArtistName As String
        AlbumDAO = New AlbumDAO()
        Albums = AlbumDAO.ReadAll("C:\songify.accdb")
        ArtistName = ListBox1.SelectedItem
        For Each artist In Artists
            If artist.aName = ArtistName Then
                SelectedArtist = artist
            End If
        Next
        For Each album In Albums
            If SelectedArtist.IdArtist = album.artist Then
                ListBox2.Items.Add(album.aName)
            End If
        Next
        aName.Visible = True
        aName.Text = SelectedArtist.aName
        country.Visible = True
        country.Text = SelectedArtist.country
    End Sub

    Private Sub BackBtn(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow
        f2.Show()
        Me.Hide()
    End Sub
End Class