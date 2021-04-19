Public Class Fav_Artist
    Private Property user As String
    Private Property artist As Integer
    Private Property favDate As Date

    Private ReadOnly arDAO As ArtistDAO
    Public Sub New(id As String)
        Me.arDAO = New ArtistDAO
        Me.user = id
    End Sub

    Public Function GetUser()
        Return user
    End Function
    Public Function GetArtist()
        Return artist
    End Function
    Public Function GetFavDate()
        Return favDate
    End Function
    Public Function SetUser(user As String)
        Me.user = user
    End Function
    Public Function SetArtist(artist As Integer)
        Me.artist = artist
    End Function
    Public Function SetFavDate(favDate As Date)
        Me.favDate = favDate
    End Function
    Public Function ReadAllFavArtists(path As String)
        Return Me.arDAO.ReadAll(path)
    End Function
    Public Function InsertFav_Artist() As Integer
        Return Me.arDAO.InsertFav(Me)
    End Function
End Class
