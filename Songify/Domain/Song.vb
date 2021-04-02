Public Class Song
    Public Property IdSong As String
    Public Property sName As String
    Public Property Album As Integer
    Public Property length As Integer
    Public ReadOnly Property sDAO As SongDAO

    Public Sub New()
        Me.sDAO = New SongDAO
    End Sub
    Public Sub New(id As String)
        Me.sDAO = New SongDAO
        Me.IdSong = id
    End Sub
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
