Public Class InsUpDel
    Public SelectedArtist As Artist
    Public ImageArtist As String
    Public Artists As Collection
    Public path As String
    Private Sub InsUpDel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        artnametxt.Text = SelectedArtist.GetName()
        artcountrytxt.Text = SelectedArtist.GetCountry()
        artimagetxt.Text = SelectedArtist.GetImage()
        TextBox1.Text = SelectedArtist.GetIdArtist()
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
            ArtistImage = artimagetxt.Text
            ArtistAdded = New Artist()
            ArtistAdded.SetName(ArtistName)
            ArtistAdded.SetCountry(ArtistCountry)
            ArtistAdded.SetImage(ArtistImage)
            ArtistAdded.InsertArtist()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub updateArtist(sender As Object, e As EventArgs) Handles btn_updateArtists.Click
        Dim ArtistUpdated As New Artist : Dim ArtistName As String : Dim ArtistCountry As String : Dim ArtistImage As String : Dim ArtistReader As Artist : Dim counter As Integer
        ArtistReader = New Artist()
        Artists = ArtistReader.ReadAllArtists(path)
        For Each artist In Artists
            counter += 1
        Next
        counter += 1
        Try
            ArtistName = artnametxt.Text
            ArtistCountry = artcountrytxt.Text
            ArtistImage = artimagetxt.Text
            ArtistUpdated = New Artist
            ArtistUpdated.setIdArtist(counter)
            ArtistUpdated.SetName(ArtistName)
            ArtistUpdated.SetCountry(ArtistCountry)
            ArtistUpdated.SetImage(ArtistImage)
            ArtistUpdated.UpdateArtist(path)
            MsgBox("Artist Updated")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
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
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class