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
    Public Sub ReadAllUsers(path As String)
        Me.usrDAO.ReadAll(path)
    End Sub
    Public Sub ReadUser()
        Me.usrDAO.Read(Me)
    End Sub
    Public Function InsertUser() As Integer
        Return Me.usrDAO.Insert(Me, "C:\songify.accdb")
    End Function
    Public Function UpdateUser() As Integer
        Return Me.usrDAO.Update(Me, "C:\songify.accdb")
    End Function
    Public Function DeleteUser() As Integer
        Return Me.usrDAO.Delete(, "C:\songify.accdb")
    End Function


End Class
