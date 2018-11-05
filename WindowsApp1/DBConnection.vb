Imports MySql.Data.MySqlClient

Public Class DBConnection

    Private Shared singleton As DBConnection
    Dim MysqlConn As MySqlConnection
    Private serverAddress As String
    Private user As String
    Private password As String
    Private database As String

    Private Sub New(ByRef connection As MySqlConnection,
                   ByVal server As String, ByVal user As String,
                   ByVal password As String, ByVal database As String)

        MysqlConn = connection
        Me.serverAddress = server
        Me.user = user
        Me.password = password
        Me.database = database

        MysqlConn.ConnectionString = "server=" & Me.serverAddress & ";" _
            & "user id=" & Me.user & ";" _
            & "password=" & Me.password & ";" _
            & "database=" & Me.database

        Try
            MysqlConn.Open()
            Console.WriteLine("Connection Successfully opened")
            MysqlConn.Close()
        Catch ex As Exception
            Console.WriteLine("Cannot connect to database: " & ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Public Shared Function getInstance(ByRef connection As MySqlConnection,
                   ByVal server As String, ByVal user As String,
                   ByVal password As String, ByVal database As String) As DBConnection

        If (singleton Is Nothing) Then
            singleton = New DBConnection(connection, server, user, password, database)
        End If

        Return singleton

    End Function

End Class
