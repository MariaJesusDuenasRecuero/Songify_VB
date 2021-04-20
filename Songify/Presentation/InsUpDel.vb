Public Class InsUpDel
    Public SelectedArtist As Artist
    Public ImageArtist As String
    Private Sub InsUpDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New(SelectedArtist As Artist)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.SelectedArtist = SelectedArtist

    End Sub
    Private Sub insertArtist(sender As Object, e As EventArgs) Handles btn_insertArtists.Click
        Dim ArtistName As String : Dim ArtistCountry As String : Dim ArtistImage As String : Dim ArtistAdded As Artist
        Try
            ArtistName = artnametxt.Text
            ArtistCountry = artcountrytxt.Text
            ArtistImage = ImageArtist
            ArtistAdded = New Artist()
            ArtistAdded.SetName(ArtistName)
            ArtistAdded.SetCountry(ArtistCountry)
            ArtistAdded.SetImage(ArtistImage)
            ArtistAdded.InsertArtist()
        Catch ex As Exception
            MsgBox("Fill the data with properly values", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub updateArtist(sender As Object, e As EventArgs) Handles btn_updateArtists.Click
        Dim ArtistUpdated As Artist : Dim ArtistName As String : Dim ArtistCountry As String : Dim ArtistImage As String
        artnametxt.Text = SelectedArtist.GetName()
        artcountrytxt.Text = SelectedArtist.GetCountry()
        artimagetxt.Text = SelectedArtist.GetImage()
        Try
            ArtistName = artnametxt.Text
            ArtistCountry = artcountrytxt.Text
            ArtistImage = ImageArtist
            ArtistUpdated = New Artist()
            ArtistUpdated.SetName(ArtistName)
            ArtistUpdated.SetCountry(ArtistCountry)
            ArtistUpdated.SetImage(ArtistImage)
            ArtistUpdated.UpdateArtist()
        Catch ex As Exception
            MsgBox("Fill the data with properly values", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub deleteArtist(sender As Object, e As EventArgs) Handles btn_deleteArtists.Click
        artcountrytxt.Enabled = False
        artimagetxt.Enabled = False
        imagebtn.Enabled = False
        Dim ArtistName As String : Dim ArtistAdded As Artist
        Try
            ArtistName = artnametxt.Text
            ArtistAdded = New Artist(ArtistName)
            ArtistAdded.DeleteArtist()
        Catch ex As Exception
            MsgBox("Fill the data with properly values", MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class