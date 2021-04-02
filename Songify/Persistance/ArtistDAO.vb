Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim ar As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Artists ORDER BY IdArtist")
        For Each aux In col
            ar = New Artist(aux(1).ToString)
            ar.aName = aux(2).ToString
            ar.country = aux(3).ToString
            ar.image = aux(4).ToString
            Me.Artists.Add(ar)
        Next
    End Sub

    Public Sub Read(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE IdArtist='" & ar.IdArtist & "';")
        For Each aux In col
            ar.aName = aux(2).ToString
            ar.country = aux(2).ToString
            ar.image = aux(3).ToString
        Next
    End Sub

    Public Function Insert(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Artists VALUES ('" & ar.IdArtist & "', '" & ar.aName & "', '" & ar.country & "', '" & ar.image & "');")
    End Function
    Public Function Update(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Artists SET aName='" & ar.aName & "' SET country='" & ar.country & "' SET image='" & ar.image & "' WHERE IdArtist='" & ar.IdArtist & "';")
    End Function
    Public Function Delete(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE IdArtist='" & ar.IdArtist & "';")
    End Function


End Class
