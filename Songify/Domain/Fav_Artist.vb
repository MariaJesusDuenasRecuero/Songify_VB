Public Class Fav_Artist
    Public Property user As String
    Public Property artist As Integer
    Public Property favDate As Date
    Public Sub New(id As String)
        Me.user = id
    End Sub
End Class
