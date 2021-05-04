Public Class AlbumDAO
    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Function ReadAll(path As String) As Object
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Albums ORDER BY IdAlbum")
        For Each aux In col
            a = New Album(CInt(aux(1).ToString), aux(2).ToString, CDate(aux(3).ToString), CInt(aux(4).ToString), aux(5).ToString)
            Me.Albums.Add(a)
        Next
        Return Albums
    End Function

    Public Sub Read(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Albums WHERE IdAlbum='" & a.GetIdAlbum() & "';")
        For Each aux In col
            a.SetName(aux(2).ToString)
            a.SetDate(CDate(aux(3).ToString))
            a.SetArtist(CInt(aux(4).ToString))
            a.SetCover(aux(5).ToString)
        Next
    End Sub

    Public Function Insert(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Albums ([aName],releaseDate,artist,[cover]) VALUES ('" & a.GetName() & "','" & a.getReleaseDate() & "','" & a.getArtist() & "','" & a.GetCover() & "');")

    End Function
    Public Function Update(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Albums SET aName='" & a.GetName() & "' ,releaseDate='" & a.getReleaseDate() & "' ,artist='" & a.getArtist() & "' ,[cover]='" & a.GetCover() & "'WHERE IdAlbum=" & a.GetIdAlbum() & ";")
    End Function
    Public Function Delete(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Albums WHERE IdAlbum=" & a.GetIdAlbum() & ";")
    End Function


End Class
