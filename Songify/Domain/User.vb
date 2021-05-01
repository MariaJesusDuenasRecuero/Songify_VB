Public Class User
    Private Property Email As String
    Private Property uName As String
    Private Property uSurname As String
    Private Property birthdate As Date
    Private Property idPlay As Integer
    Private Property plDate As Date
    Private Song As Integer
    Private ReadOnly Property usrDAO As UserDAO

    Public Sub New()
        Me.usrDAO = New UserDAO
    End Sub
    Public Sub New(id As String)
        Me.usrDAO = New UserDAO
        Me.Email = id
    End Sub
    Public Sub New(idPlay As Integer, Email As String, Song As Integer, plDate As Date)
        Me.idPlay = idPlay
        Me.Email = Email
        Me.Song = Song
        Me.plDate = plDate
    End Sub
    Public Function GetEmail()
        Return Email
    End Function
    Public Function setEmail(Email As String)
        Me.Email = Email
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
    Public Function GetIdPlay()
        Return idPlay
    End Function
    Public Function GetSong()
        Return Song
    End Function
    Public Function GetPlDate()
        Return plDate
    End Function
    Public Function SetIdPlay(id As Integer)
        idPlay = id
    End Function
    Public Function SetSong(song As Integer)
        Me.Song = song
    End Function
    Public Function SetPlDate(plDate As Date)
        Me.plDate = plDate
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
    Public Function InsertUser() As Integer
        Return Me.usrDAO.Insert(Me)
    End Function
    Public Function UpdateUser() As Integer
        Return Me.usrDAO.Update(Me)
    End Function
    Public Function DeleteUser() As Integer
        Return Me.usrDAO.Delete(Me)
    End Function
    Public Function InsertPlayBack() As Integer
        Return Me.usrDAO.InsertPlayback(Me)
    End Function

End Class
