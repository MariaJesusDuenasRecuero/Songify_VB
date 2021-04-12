Imports System.IO
Imports System.Net

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
            lsb_artist.Items.Add(artist.aName)
        Next



    End Sub

    Private Sub loadData(sender As Object, e As EventArgs) Handles lsb_artist.SelectedIndexChanged
        lst_album.Items.Clear()
        Dim Albums As Collection : Dim AlbumDAO As AlbumDAO : Dim ArtistName As String : Dim wc As New WebClient()

        AlbumDAO = New AlbumDAO()
        Albums = AlbumDAO.ReadAll("C:\songify.accdb")
        ArtistName = lsb_artist.SelectedItem
        For Each artist In Artists
            If artist.aName = ArtistName Then
                SelectedArtist = artist
            End If
        Next
        For Each album In Albums
            If SelectedArtist.IdArtist = album.artist Then
                lst_album.Items.Add(album.aName)
            End If
        Next

        Dim datos As Byte() = wc.DownloadData(SelectedArtist.image)
        Dim ms As New MemoryStream(datos)
        aName.Visible = True
        aName.Text = SelectedArtist.aName
        country.Visible = True
        country.Text = SelectedArtist.country
        im_artists.Image = Image.FromStream(ms)
    End Sub

    Private Sub BtnBack(sender As Object, e As EventArgs) Handles GoBackBtn.Click
        Dim f2 As New MainWindow
        f2.Show()
        Me.Hide()
    End Sub

End Class