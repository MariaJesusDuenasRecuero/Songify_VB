Public Class Album
    Private Property IdAlbum As Integer
    Private Property aName As String
    Private Property releaseDate As Date
    Private Property artist As Integer
    Private Property cover As String
    Private ReadOnly Property AlbDAO As AlbumDAO
    Public Sub New()
        Me.AlbDAO = New AlbumDAO
    End Sub
    Public Sub New(id As Integer)
        Me.AlbDAO = New AlbumDAO
        Me.IdAlbum = id
    End Sub
    Public Sub New(id As Integer, name As String, Rdate As Date, artist As Integer, cover As String)
        Me.AlbDAO = New AlbumDAO
        IdAlbum = id
        aName = name
        releaseDate = Rdate
        Me.artist = artist
        Me.cover = cover
    End Sub
    Public Function GetIdAlbum() As Integer
        Return IdAlbum
    End Function
    Public Function getArtist() As Integer
        Return artist
    End Function
    Public Function getReleaseDate() As Date
        Return releaseDate
    End Function
    Public Function GetName() As String
        Return aName
    End Function
    Public Function GetCover() As String
        Return cover
    End Function
    Public Function setIdAlbum(Id As Integer) As Integer
        IdAlbum = Id
    End Function
    Public Function SetName(name As String) As String
        aName = name
    End Function
    Public Function SetDate(RDate As Date) As Date
        releaseDate = RDate
    End Function
    Public Function SetArtist(nartist As Integer) As Integer
        artist = nartist
    End Function
    Public Function SetCover(cover As String) As String
        Me.cover = cover
    End Function
    Public Function ReadAllAlbums(path As String) As Object
        Return Me.AlbDAO.ReadAll(path)
    End Function
    Public Sub ReadAlbum()
        Me.AlbDAO.Read(Me)
    End Sub
    Public Function InsertAlbum() As Integer
        Return Me.AlbDAO.Insert(Me)
    End Function
    Public Function UpdateAlbum() As Integer
        Return Me.AlbDAO.Update(Me)
    End Function
    Public Function DeleteAlbum() As Integer
        Return Me.AlbDAO.Delete(Me)
    End Function
End Class
