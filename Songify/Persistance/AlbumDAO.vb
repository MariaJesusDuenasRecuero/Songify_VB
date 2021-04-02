Public Class AlbumDAO
    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim a As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Albums ORDER BY IdAlbum")
        For Each aux In col
            a = New Album(aux(1).ToString)
            a.aName = aux(2).ToString
            a.releaseDate = aux(3).ToString
            a.artist = aux(4).ToString
            a.cover = aux(5).ToString
            Me.Albums.Add(a)
        Next
    End Sub

    Public Sub Read(ByRef a As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Albums WHERE IdAlbum='" & a.IdAlbum & "';")
        For Each aux In col
            a.aName = aux(2).ToString
            a.releaseDate = aux(3).ToString
            a.artist = aux(4).ToString
            a.cover = aux(5).ToString
        Next
    End Sub

    Public Function Insert(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Albums VALUES ('" & a.IdAlbum & "', '" & a.aName & "', '" & a.releaseDate & "', '" & a.artist & "', '" & a.cover & "');")
    End Function
    Public Function Update(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Albums SET aName='" & a.aName & "' SET releaseDate='" & a.releaseDate & "' SET artist='" & a.artist & "' SET cover='" & a.cover & "'WHERE IdAlbum='" & a.IdAlbum & "';")
    End Function
    Public Function Delete(ByVal a As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Albums WHERE IdAlbum='" & a.IdAlbum & "';")
    End Function


End Class
