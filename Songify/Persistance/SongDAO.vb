Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Function ReadAll(path As String)
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Songs ORDER BY IdSong")
        For Each aux In col
            s = New Song(aux(1).ToString)
            s.SetName(aux(2).ToString)
            s.SetAlbum(aux(3).ToString)
            s.SetLength(aux(4))
            Me.Songs.Add(s)
        Next
        Return Songs
    End Function

    Public Sub Read(ByRef s As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE IdSong='" & s.getIdSong() & "';")
        For Each aux In col
            s.SetName(aux(2).ToString)
            s.SetAlbum(aux(3).ToString)
            s.SetLength(aux(4))
        Next
    End Sub

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Songs ([sName],Album,length) VALUES ('" & s.GetName() & "','" & s.GetAlbum() & "','" & s.getLength() & "');")
    End Function
    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Songs SET sName='" & s.GetName() & "' ,Album='" & s.GetAlbum() & "' ,length='" & s.getLength() & "'WHERE IdSong=" & s.getIdSong() & ";")
    End Function
    Public Function Delete(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Songs WHERE IdSong=" & s.getIdSong() & ";")
    End Function
    Public Function Query2(path As String)
        Dim name As String
        Dim names As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker(path).Read("SELECT DISTINCT s.sName, count(s.sName) FROM songs s, playbacks p WHERE (p.song=s.IdSong) GROUP BY s.sName ORDER BY count(s.sName);")
        For Each aux In col
            name = aux(1).ToString
            names.Add(name)
        Next
        Return names
    End Function

    Public Function Query4(path As String)
        Dim names As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker(path).Read("SELECT us.uName , SUM(s.length) FROM users us, playbacks p, songs s WHERE(us.Email=p.user and p.song = s.IdSong) GROUP BY us.uName ORDER BY SUM(s.length) desc;")
        Dim name As String
        For Each aux In col
            name = aux(1).ToString
            names.Add(name)
        Next
        Return names
    End Function

End Class
