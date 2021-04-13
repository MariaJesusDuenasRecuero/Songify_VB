Public Class Album
    Private Property IdAlbum As String
    Private Property aName As String
    Private Property releaseDate As Date
    Private Property artist As Integer
    Private Property cover As String
    Private ReadOnly Property AlbDAO As AlbumDAO
    Public Sub New()
        Me.AlbDAO = New AlbumDAO
    End Sub
    Public Sub New(id As String)
        Me.AlbDAO = New AlbumDAO
        Me.IdAlbum = id
    End Sub
    Public Sub New(id As String, name As String, Rdate As Date, artist As Integer, cover As String)
        Me.AlbDAO = New AlbumDAO
        IdAlbum = id
        aName = name
        releaseDate = Rdate
        Me.artist = artist
        Me.cover = cover
    End Sub
    Public Function GetIdAlbum()
        Return IdAlbum
    End Function
    Public Function getArtist()
        Return artist
    End Function
    Public Function getReleaseDate()
        Return releaseDate
    End Function
    Public Sub ReadAllAlbums(path As String)
        Me.AlbDAO.ReadAll(path)
    End Sub
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
