Public Class Artist
    Private Property IdArtist As String
    Private Property aName As String
    Private Property country As String
    Private Property image As String
    Private ReadOnly Property arDAO As ArtistDAO
    Private User As String
    Private favDate As Date
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
    Public Sub New(user As String, IdArtist As Integer, favDate As Date)
        Me.arDAO = arDAO
        Me.User = user
        Me.IdArtist = IdArtist
        Me.favDate = favDate
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
    Public Function GetUser()
        Return User
    End Function
    Public Function GetFavDate()
        Return favDate
    End Function
    Public Function SetUser(user As String)
        Me.User = user
    End Function
    Public Function SetFavDate(favDate As Date)
        Me.favDate = favDate
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
    Public Function ReadAllFavArtists(path As String)
        Return Me.arDAO.ReadAllFavArtists(path)
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
    Public Function InsertFav_Artist() As Integer
        Return Me.arDAO.InsertFav(Me)
    End Function
    Public Function DeleteFav_Artist() As Integer
        Return Me.arDAO.DeleteFav_Artist(Me)
    End Function
    Public Function UpdateArtist() As Integer
        Return Me.arDAO.Update(Me)
    End Function
    Public Function DeleteArtist() As Integer
        Return Me.arDAO.Delete(Me)
    End Function

    Public Function Query1(path As String)
        Return Me.arDAO.Query1(path)
    End Function
    Public Function Query2(path As String, country As String)
        Return Me.arDAO.Query2(path, country)
    End Function
    Public Function Query3(path As String, Date1 As Date, Date2 As Date, Email As String)
        Return Me.arDAO.Query3(path, Date1, Date2, Email)
    End Function
    Public Function Query5(path As String, Email As String)
        Return Me.arDAO.Query5(path, Email)
    End Function
End Class
