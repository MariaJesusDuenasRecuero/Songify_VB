Public Class User
    Private Property Email As String
    Private Property uName As String
    Private Property uSurname As String
    Private Property birthdate As Date
    Private ReadOnly Property usrDAO As UserDAO

    Public Sub New()
        Me.usrDAO = New UserDAO
    End Sub
    Public Sub New(id As String)
        Me.usrDAO = New UserDAO
        Me.Email = id
    End Sub
    Public Sub New(id As String, name As String, surname As String, bhirthdate As Date)
        Me.usrDAO = New UserDAO
        Email = id
        uName = name
        uSurname = surname
        Me.birthdate = birthdate
    End Sub
    Public Function GetEmail()
        Return Email
    End Function
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
