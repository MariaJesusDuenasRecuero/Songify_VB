Public Class Song
    Private Property IdSong As String
    Private Property sName As String
    Private Property Album As Integer
    Private Property length As Integer
    Private sDAO As SongDAO
    Public Sub New()
        Me.sDAO = New SongDAO
    End Sub
    Public Sub New(id As String)
        Me.sDAO = New SongDAO
        Me.IdSong = id
    End Sub
    Public Function GetAlbum()
        Return Album
    End Function
    Public Function GetName()
        Return sName
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
    Public Function setIdSong(id As Integer)
        IdSong = id
    End Function
    Public Function SetName(name As String)
        sName = name
    End Function
    Public Function SetAlbum(album As Integer)
        Me.Album = album
    End Function
    Public Function SetLength(length As Integer)
        Me.length = length
    End Function
    Public Function ReadAllSongs(path As String)
        Return Me.sDAO.ReadAll(path)
    End Function
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
    Public Function Query2(path As String)
        Return Me.sDAO.Query2(path)
    End Function
    Public Function Query4(path As String)
        Return Me.sDAO.Query4(path)
    End Function
End Class
