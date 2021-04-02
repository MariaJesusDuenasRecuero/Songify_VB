Public Class DBBroker

    Private Shared _Instance As DBBroker
    Private Shared connection As OleDb.OleDbConnection
    Private Shared connectionString As String

    Private Sub New() 'si tengo un condtructor publico en singleton MAL
        DBBroker.connection = New OleDb.OleDbConnection(DBBroker.connectionString)
    End Sub

    Public Shared Function GetBroker() As DBBroker
        If DBBroker._Instance Is Nothing Then
            DBBroker._Instance = New DBBroker
        End If
        Return DBBroker._Instance
    End Function

    Public Shared Function GetBroker(path As String) As DBBroker
        DBBroker.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & path 'mirar esto el path es la ruta del archivo
        DBBroker.connection = New OleDb.OleDbConnection(DBBroker.connectionString) 'devulve DBBroker
        Return DBBroker.GetBroker
    End Function

    Public Function Read(sql As String) As Collection
        Dim result As New Collection 'collection of colection 
        Dim row As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Connect()
        reader = com.ExecuteReader
        While reader.Read 'si tengo algo que leer haz:
            row = New Collection
            For i = 0 To reader.FieldCount - 1
                row.Add(reader(i).ToString)
            Next
            result.Add(row)
        End While
        Disconnect()
        Return result
    End Function

    Public Function Change(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, DBBroker.connection)
        Dim result As Integer
        Connect()
        result = com.ExecuteNonQuery
        Disconnect()
        Return result
    End Function

    Private Sub Connect()
        If DBBroker.connection.State = ConnectionState.Closed Then
            DBBroker.connection.Open()
        End If
    End Sub

    Private Sub Disconnect()
        If DBBroker.connection.State = ConnectionState.Open Then
            DBBroker.connection.Close()
        End If
    End Sub

End Class
