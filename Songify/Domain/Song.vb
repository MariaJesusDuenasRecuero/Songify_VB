Public Class Song
    Private Property IdSong As Integer
    Private Property sName As String
    Private Property Album As Integer
    Private Property length As Integer
    Private sDAO As SongDAO
    Public Sub New()
        Me.sDAO = New SongDAO
    End Sub
    Public Sub New(id As Integer)
        Me.sDAO = New SongDAO
        Me.IdSong = id
    End Sub
    Public Function GetAlbum() As Integer
        Return Album
    End Function
    Public Function GetName() As String
        Return sName
    End Function
    Public Function GetSLength() As Integer
        Return length
    End Function
    Public Function getIdSong() As Integer
        Return IdSong
    End Function
    Public Function getLength() As Integer
        Return length
    End Function
    Public Function setIdSong(id As Integer) As Integer
        IdSong = id
    End Function
    Public Function SetName(name As String) As String
        sName = name
    End Function
    Public Function SetAlbum(album As Integer) As Integer
        Me.Album = album
    End Function
    Public Function SetLength(length As Integer) As Integer
        Me.length = length
    End Function
    Public Function ReadAllSongs(path As String) As Object
        Return Me.sDAO.ReadAll(path)
    End Function
    Public Function InsertSong() As Integer
        Return Me.sDAO.Insert(Me)
    End Function
    Public Function UpdateSong() As Integer
        Return Me.sDAO.Update(Me)
    End Function
    Public Function DeleteSong() As Integer
        Return Me.sDAO.Delete(Me)
    End Function
    Public Function Query2(path As String) As Object
        Return Me.sDAO.Query2(path)
    End Function
    Public Function Query4(path As String) As Object
        Return Me.sDAO.Query4(path)
    End Function
End Class
