Public Class Artist
    Public Property IdArtist As String
    Public Property aName As String
    Public Property country As String
    Public Property image As String
    Public ReadOnly Property arDAO As ArtistDAO
    Public Sub New()
        Me.arDAO = New ArtistDAO
    End Sub
    Public Sub New(id As String)
        Me.arDAO = New ArtistDAO
        Me.IdArtist = id
    End Sub
    Public Sub ReadAllArtists(path As String)
        Me.arDAO.ReadAll(path)
    End Sub
    Public Sub ReadAll()
        Me.arDAO.Read(Me)
    End Sub
    Public Function InsertArtist() As Integer
        Return Me.arDAO.Insert(Me)
    End Function
    Public Function UpdateArtist() As Integer
        Return Me.arDAO.Update(Me)
    End Function
    Public Function DeleteArtist() As Integer
        Return Me.arDAO.Delete(Me)
    End Function
End Class
