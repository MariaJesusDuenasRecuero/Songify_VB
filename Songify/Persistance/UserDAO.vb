Public Class UserDAO
    Public ReadOnly Property Users As Collection

    Public Sub New()
        Me.Users = New Collection

    End Sub

    Public Function ReadAll(path As String) As Object
        Dim usr As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Users ORDER BY Email")
        For Each aux In col
            usr = New User(aux(1).ToString)
            usr.SetName(aux(2).ToString)
            usr.SetSurname(aux(3).ToString)
            usr.SetBirthdate(CDate(aux(4)))
            Me.Users.Add(usr)
        Next
        Return Users
    End Function
    Public Function ReadAllPlaybacks(path As String) As Object
        Dim pl As User : Dim Playbacks As New Collection
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Playbacks ORDER BY IdPlay")
        For Each aux In col
            pl = New User(aux(1).ToString)
            pl.setEmail(aux(2).ToString)
            pl.SetSong(CInt(aux(3)))
            pl.SetPlDate(CDate(aux(4)))
            Playbacks.Add(pl)
        Next
        Return Playbacks
    End Function
    Public Function Insert(ByVal usr As User) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Users (Email,uName,uSurname,birthdate) VALUES ('" & usr.GetEmail() & "','" & usr.GetName() & "','" & usr.GetSurname() & "','" & usr.GetBirthdate() & "');")
    End Function

    Public Function InsertPlayback(ByVal user As User) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Playbacks ([user],song,plDate) VALUES ('" & user.GetEmail() & "','" & user.GetSong() & "','" & user.GetPlDate() & "');")
    End Function
    Public Function Update(ByVal usr As User) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Users SET uName='" & usr.GetName() & "' ,uSurname='" & usr.GetSurname() & "' ,birthdate='" & usr.GetBirthdate() & "'WHERE Email='" & usr.GetEmail() & "';")
    End Function
    Public Function Delete(ByVal usr As User) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Users WHERE Email='" & usr.GetEmail() & "';")
    End Function

End Class
