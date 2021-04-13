Public Class Song
    Private Property IdSong As String
    Private Property sName As String
    Private Property Album As Integer
    Private Property length As Integer
    Private ReadOnly Property sDAO As SongDAO

    Public Sub New()
        Me.sDAO = New SongDAO
    End Sub
    Public Sub New(id As String)
        Me.sDAO = New SongDAO
        Me.IdSong = id
    End Sub
    Public Sub New(id As String, name As String, album As Integer, length As Integer)
        Me.sDAO = New SongDAO
        IdSong = id
        sName = name
        Me.Album = album
        Me.length = length
    End Sub
    Public Function GetAlbum()
        Return Album
    End Function
    Public Function GetSLength()
        Return length
    End Function
    Public Function getIdSong()
        Return IdSong
    End Function
    Public Function getLength()
        Return length
    End Function
    Public Sub ReadAllSongs(path As String)
        Me.sDAO.ReadAll(path)
    End Sub
    Public Sub ReadSong()
        Me.sDAO.Read(Me)
    End Sub
    Public Function InsertSong() As Integer
        Return Me.sDAO.Insert(Me)
    End Function
    Public Function UpdateSong() As Integer
        Return Me.sDAO.Update(Me)
    End Function
    Public Function DeleteSong() As Integer
        Return Me.sDAO.Delete(Me)
    End Function

End Class
