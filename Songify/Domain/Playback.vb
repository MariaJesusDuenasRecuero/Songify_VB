Public Class Playback
    Public Property IdPlay As Integer
    Public Property user As String
    Public Property song As Integer
    Public Property plDate As Date
    Public ReadOnly usrDAO As UserDAO
    Public Sub New()
        Me.usrDAO = New UserDAO
    End Sub
    Public Sub New(id As String)
        Me.usrDAO = New UserDAO
        Me.IdPlay = id
    End Sub
    Public Function ReadAllUsers(path As String)
        Return Me.usrDAO.ReadAll(path)
    End Function
    'Public Function InsertUser() As Integer
    'Return Me.usrDAO.InsertPlayback(Me, "C:\songify.accdb")
    'End Function
End Class
