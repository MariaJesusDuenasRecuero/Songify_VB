Public Class Fav_Artist
    Private Property user As String
    Private Property artist As Integer
    Private Property favDate As Date
    Private Sub New(id As String)
        Me.user = id
    End Sub
End Class
