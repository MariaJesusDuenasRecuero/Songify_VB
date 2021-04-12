Public Class UserDAO
    Public ReadOnly Property Users As Collection

    Public Sub New()
        Me.Users = New Collection
    End Sub

    Public Function ReadAll(path As String)
        Dim usr As User
        Dim col, aux As Collection
        col = DBBroker.GetBroker(path).Read("SELECT * FROM Users ORDER BY Email")
        For Each aux In col
            usr = New User(aux(1).ToString)
            usr.uName = aux(2).ToString
            usr.uSurname = aux(3).ToString
            usr.birthdate = aux(4)
            Me.Users.Add(usr)
        Next
        Return Users
    End Function

    Public Function Read(ByRef usr As User)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Users WHERE Email='" & usr.Email & "';")
        For Each aux In col
            usr.uName = aux(2).ToString
            usr.uSurname = aux(3).ToString
            usr.birthdate = aux(4)
        Next
        Return usr
    End Function
    Public Function Insert(ByVal usr As User, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("INSERT INTO Users VALUES ('" & usr.Email & "', '" & usr.uName & "', '" & usr.uSurname & "', '" & usr.birthdate & "' );")
    End Function
    Public Function Update(ByVal usr As User, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("UPDATE Users SET uName='" & usr.uName & "' SET uSurname='" & usr.uSurname & "' SET birthdate='" & usr.birthdate & "'WHERE Email='" & usr.Email & "';")
    End Function
    Public Function Delete(ByVal usr As User, path As String) As Integer
        DBBroker.GetBroker(path)
        Return DBBroker.GetBroker.Change("DELETE FROM Users WHERE Email='" & usr.Email & "';")
    End Function

End Class
