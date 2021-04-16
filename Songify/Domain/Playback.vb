Public Class Playback
    Private Property IdPlay As Integer
    Private Property user As String
    Private Property song As Integer
    Private Property plDate As Date
    Private ReadOnly usrDAO As UserDAO
    Public Sub New()
        Me.usrDAO = New UserDAO
    End Sub
    Public Sub New(id As String)
        Me.usrDAO = New UserDAO
        Me.IdPlay = id
    End Sub
    Public Sub New(id As String, user As String, song As Integer, pldate As Date)
        Me.usrDAO = New UserDAO
        IdPlay = id
        Me.user = user
        Me.song = song
        Me.plDate = pldate
    End Sub
    Public Function GetIdPlay()
        Return IdPlay
    End Function
    Public Function GetUser()
        Return user
    End Function
    Public Function GetSong()
        Return song
    End Function
    Public Function GetPlDate()
        Return plDate
    End Function
    Public Function SetIdPlay(id As Integer)
        IdPlay = id
    End Function
    Public Function SetUser(email As String)
        user = email
    End Function
    Public Function SetSong(song As Integer)
        Me.song = song
    End Function
    Public Function SetPlDate(plDate As Date)
        Me.plDate = plDate
    End Function
    Public Function ReadAllUsers(path As String)
        Return Me.usrDAO.ReadAll(path)
    End Function
    Public Function InsertPlayBack() As Integer
        Return Me.usrDAO.InsertPlayback(Me, "C:\Users\manue\Documents\songify.accdb")
    End Function
End Class
