Public Class Album
    Public Property IdAlbum As String
    Public Property aName As String
    Public Property releaseDate As String
    Public Property artist As Integer
    Public Property cover As String
    Public ReadOnly Property AlbDAO As AlbumDAO
    Public Sub New()
        Me.AlbDAO = New AlbumDAO
    End Sub
    Public Sub New(id As String)
        Me.AlbDAO = New AlbumDAO
        Me.IdAlbum = id
    End Sub
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
