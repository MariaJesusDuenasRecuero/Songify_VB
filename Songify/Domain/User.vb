Public Class User
    Public Property Email As String
    Public Property uName As String
    Public Property uSurname As String
    Public Property birthdate As Date
    Public ReadOnly Property usrDAO As UserDAO

    Public Sub New()
        Me.usrDAO = New UserDAO
    End Sub
    Public Sub New(id As String)
        Me.usrDAO = New UserDAO
        Me.Email = id
    End Sub
    Public Function ReadAllUsers(path As String)
        Return Me.usrDAO.ReadAll(path)
    End Function
    Public Function ReadUser()
        Return Me.usrDAO.Read(Me)
    End Function
    Public Function InsertUser() As Integer
        Return Me.usrDAO.Insert(Me, "C:\songify.accdb")
    End Function
    Public Function UpdateUser() As Integer
        Return Me.usrDAO.Update(Me, "C:\songify.accdb")
    End Function
    Public Function DeleteUser() As Integer
        Return Me.usrDAO.Delete(Me, "C:\songify.accdb")
    End Function


End Class
