Public Class Artist
    Private Property IdArtist As String
    Private Property aName As String
    Private Property country As String
    Private Property image As String
    Private ReadOnly Property arDAO As ArtistDAO
    Public Sub New()
        Me.arDAO = New ArtistDAO
    End Sub
    Public Sub New(id As String)
        Me.arDAO = New ArtistDAO
        Me.IdArtist = id
    End Sub
    Public Sub New(id As String, name As String, country As String, image As String)
        Me.arDAO = New ArtistDAO
        IdArtist = id
        aName = name
        Me.country = country
        Me.image = image
    End Sub
    Public Sub ReadArtist()
        Me.arDAO.Read(Me)
    End Sub
    Public Function GetIdArtist()
        Return IdArtist
    End Function
    Public Function GetImage()
        Return image
    End Function
    Public Function GetCountry()
        Return country
    End Function
    Public Function GetName()
        Return aName
    End Function
    Public Function setIdArtist(idArtsit As Integer)
        IdArtist = idArtsit
    End Function
    Public Function SetName(name As String)
        aName = name
    End Function
    Public Function SetImage(image As String)
        Me.image = image
    End Function
    Public Function SetCountry(country As String)
        Me.country = country
    End Function
    Public Function ReadAllArtists(path As String)
        Return Me.arDAO.ReadAll(path)
    End Function
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
