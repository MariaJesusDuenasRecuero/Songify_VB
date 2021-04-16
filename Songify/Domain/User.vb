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
    Public Function GetEmail()
        Return Email
    End Function
    Public Function SetName(name As String)
        uName = name
    End Function
    Public Function SetSurname(surname As String)
        uSurname = surname
    End Function
    Public Function GetName()
        Return uName
    End Function
    Public Function GetSurname()
        Return uSurname
    End Function
    Public Function GetBirthdate()
        Return birthdate
    End Function
    Public Function SetBirthdate(birthdate As Date)
        Me.birthdate = birthdate
    End Function
    Public Function ReadAllUsers(path As String)
        Return Me.usrDAO.ReadAll(path)
    End Function
    Public Function ReadAllPlaybacks(path As String)
        Return Me.usrDAO.ReadAllPlaybacks(path)
    End Function
    Public Function ReadUser()
        Return Me.usrDAO.Read(Me)
    End Function
    Public Function InsertUser(path As String) As Integer
        Return Me.usrDAO.Insert(Me, path)
    End Function
    Public Function UpdateUser(path As String) As Integer
        Return Me.usrDAO.Update(Me, path)
    End Function
    Public Function DeleteUser(path As String) As Integer
        Return Me.usrDAO.Delete(Me, path)
    End Function

End Class
