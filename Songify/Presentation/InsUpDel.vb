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
    Public Sub New(SelectedArtist As Artist, path As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.SelectedArtist = SelectedArtist
        Me.path = path

    End Sub
    Private Sub insertArtist(sender As Object, e As EventArgs) Handles btn_insertArtists.Click
        Dim ArtistName As String : Dim ArtistCountry As String : Dim ArtistImage As String : Dim ArtistAdded As Artist : Dim ArtistReader = New Artist() : Dim count As Integer
        Artists = ArtistReader.ReadAllArtists(path)
        For Each artist In Artists
            count += 1
        Next
        count += 1
        Try
            ArtistName = artnametxt.Text
            ArtistCountry = artcountrytxt.Text
            ArtistImage = artimagetxt.Text
            ArtistAdded = New Artist()
            ArtistAdded.setIdArtist(count)
            ArtistAdded.SetName(ArtistName)
            ArtistAdded.SetCountry(ArtistCountry)
            ArtistAdded.SetImage(ArtistImage)
            ArtistAdded.InsertArtist(path)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
    Private Sub updateArtist(sender As Object, e As EventArgs) Handles btn_updateArtists.Click
        Dim ArtistUpdated As New Artist : Dim ArtistName As String : Dim ArtistCountry As String : Dim ArtistImage As String : Dim ArtistReader As Artist
        ArtistReader = New Artist()
        Artists = ArtistReader.ReadAllArtists(path)
        ArtistUpdated.setIdArtist(6)
        ArtistUpdated.ReadArtist()
        If ArtistUpdated.GetName() = artnametxt.Text Then
            MsgBox("You're not changing a thing", "Custom Error")
        ElseIf ArtistUpdated.GetCountry() = artcountrytxt.Text Then
            MsgBox("You're not changing a thing", "Custom Error")
        Else
            ArtistName = artnametxt.Text
            ArtistCountry = artcountrytxt.Text
            ArtistImage = artimagetxt.Text
            ArtistUpdated.SetName(ArtistName)
            ArtistUpdated.SetCountry(ArtistCountry)
            ArtistUpdated.SetImage(ArtistImage)
        End If
        ArtistUpdated.UpdateArtist(path)
        MsgBox("Artist Updated")
    End Sub
    Private Sub deleteArtist(sender As Object, e As EventArgs) Handles btn_deleteArtists.Click
        Dim ArtistAdded As Artist
        Try
            ArtistAdded = New Artist()
            ArtistAdded.setIdArtist(TextBox1.Text)
            ArtistAdded.DeleteArtist(path)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub
End Class