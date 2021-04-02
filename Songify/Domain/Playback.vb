Public Class Playback
    Public Property IdPlay As Integer
    Public Property user As String
    Public Property song As Integer
    Public Property plDate As Date

    Public Sub New(id As String)
        Me.IdPlay = id
    End Sub
End Class
