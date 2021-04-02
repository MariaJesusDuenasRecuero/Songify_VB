Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Sub ReadAll(path As String)
        Dim s As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Songs ORDER BY IdSong")
        For Each aux In col
            s = New Song(aux(1).ToString)
            s.sName = aux(2).ToString
            s.length = aux(3).ToString
            Me.Songs.Add(s)
        Next
    End Sub

    Public Sub Read(ByRef s As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE IdSong='" & s.IdSong & "';")
        For Each aux In col
            s.sName = aux(2).ToString
        Next
    End Sub

    Public Function Insert(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Songs VALUES ('" & s.IdSong & "', '" & s.sName & "', '" & s.length & "', '" & s.Album & "');")
    End Function
    Public Function Update(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Songs SET sName='" & s.sName & "' SET length='" & s.length & "' SET Album='" & s.Album & "' WHERE IdSong='" & s.IdSong & "';")
    End Function
    Public Function Delete(ByVal s As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Songs WHERE IdSong='" & s.IdSong & "';")
    End Function


End Class
