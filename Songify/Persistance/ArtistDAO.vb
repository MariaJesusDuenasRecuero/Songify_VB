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
            ar = New Fav_Artist(aux(1))
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
    Public Function Insert(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Artists ([aName],country,[image]) VALUES ('" & ar.GetName() & "','" & ar.GetCountry() & "','" & ar.GetImage() & "');")
    End Function
    Public Function Update(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Artists SET aName='" & ar.GetName() & "' ,country='" & ar.GetCountry() & "' ,[image]='" & ar.GetImage() & "'WHERE IdArtist=" & ar.GetIdArtist() & ";")
    End Function
    Public Function Delete(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE IdArtist=" & ar.GetIdArtist() & ";")
    End Function
    Public Function DeleteFav_Artist(ByVal ar As Fav_Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Fav_Artists WHERE artist=" & ar.GetArtist() & ";")
    End Function
    Public Function Query1(path As String)
        Dim name As String
        Dim names As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker(path).Read("SELECT DISTINCT c.aName, count(c.aName) FROM songs s, playbacks p, albums a, artists c WHERE (p.song=s.IdSong AND s.album=a.IdAlbum AND a.artist=c.IdArtist) GROUP BY c.aName ORDER BY count(c.aName);")
        Dim aName As String
        For Each aux In col
            name = aux(1).ToString
            names.Add(name)
        Next
        Return names
    End Function

    Public Function Query2(path As String, country As String)
        Dim name As String
        Dim names As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker(path).Read("SELECT DISTINCT c.aName, count(c.aName) FROM songs s, playbacks p, albums a, artists c WHERE (p.song=s.IdSong AND s.album=a.IdAlbum AND a.artist=c.IdArtist AND c.country = '" & country & "') GROUP BY c.aName ORDER BY count(c.aName);")
        For Each aux In col
            name = aux(1).ToString
            names.Add(name)
        Next
        Return names
    End Function
    Public Function Query3(path As String, Date1 As Date, Date2 As Date, Email As String)
        Dim name As String
        Dim names As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker(path).Read("SELECT DISTINCT c.aName , COUNT(c.aName) FROM songs s, playbacks p, albums a, artists c, users u WHERE (p.song = s.IdSong AND s.album = a.IdAlbum AND a.artist = c.IdArtist AND p.plDate BETWEEN #" & Date1 & "# AND #" & Date2 & "# AND p.user = u.Email AND u.Email = '" & Email & "') GROUP BY c.aName ORDER BY count(c.aName) desc")
        For Each aux In col
            name = aux(1).ToString
            names.Add(name)
        Next
        Return names
    End Function
    Public Function Query5(path As String, Email As String)
        Dim time As New Collection : Dim consulta As String
        consulta = "SELECT u.Email, SUM(s.length) FROM fav_artists fav, songs s, users u, playbacks p, artists ar, albums al WHERE (s.Album = al.IdAlbum AND al.artist = ar.IdArtist AND fav.artist = ar.IdArtist AND fav.user = u.Email AND s.IdSong = p.song AND u.Email='" & Email & "') GROUP BY u.Email ORDER BY SUM(s.length) asc;"
        Dim col As Collection = DBBroker.GetBroker(path).Read(consulta)
        For Each aux In col
            time.Add(aux(2))
        Next
        Return time
    End Function
End Class