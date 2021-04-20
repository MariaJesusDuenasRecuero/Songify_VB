Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Function ReadAll(path As String)
        Dim ar As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Artists ORDER BY IdArtist")
        For Each aux In col
            ar = New Artist(aux(1).ToString)
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
            ar.SetImage(aux(4).ToString)
            Me.Artists.Add(ar)
        Next
        Return Artists
    End Function

    Public Function ReadAllFavArtists(path As String)
        Dim ar As Fav_Artist
        Dim fa As New Collection
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Fav_Artists ORDER BY user")
        For Each aux In col
            ar = New Fav_Artist(aux(1).ToString)
            ar.SetArtist(aux(2).ToString)
            ar.SetFavDate(aux(3).ToString)
            fa.Add(ar)
        Next
        Return fa
    End Function

    Public Sub Read(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE IdArtist='" & ar.GetIdArtist() & "';")
        For Each aux In col
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
            ar.SetImage(aux(4).ToString)
        Next
    End Sub

    Public Function InsertFav(ByVal s As Fav_Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Fav_Artists VALUES ('" & s.GetUser() & "', '" & s.GetArtist() & "', '" & s.GetFavDate() & "');")
    End Function
    Public Function Insert(ByVal ar As Artist, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("INSERT INTO Artists VALUES ('" & ar.GetIdArtist() & "', '" & ar.GetName() & "', '" & ar.GetCountry() & "', '" & ar.GetImage() & "');")
    End Function
    Public Function Update(ByVal ar As Artist, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("UPDATE Artists SET aName='" & ar.GetName() & "' SET country='" & ar.GetCountry() & "' SET image='" & ar.GetImage() & "' WHERE IdArtist='" & ar.GetIdArtist() & "';")
    End Function
    Public Function Delete(ByVal ar As Artist, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE IdArtist='" & ar.GetIdArtist() & "';")
    End Function
End Class