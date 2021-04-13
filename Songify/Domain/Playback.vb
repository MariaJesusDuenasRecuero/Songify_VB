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
    Public Function ReadAllUsers(path As String)
        Return Me.usrDAO.ReadAll(path)
    End Function
    Public Function InsertPlayBack() As Integer
        Return Me.usrDAO.InsertPlayback(Me, "C:\songify.accdb")
    End Function
End Class
