Imports MySql.Data.MySqlClient

Public Class DBConnection

    Private Shared singleton As DBConnection
    Public mysql As MySqlConnection
    Private serverAddress As String
    Private user As String
    Private database As String
    Private password As String

    Private Sub New(ByRef connection As MySqlConnection,
                   ByVal server As String, ByVal user As String,
                   ByVal password As String, ByVal database As String)

        mysql = connection
        Me.serverAddress = server
        Me.user = user
        Me.password = password
        Me.database = database

        mysql.ConnectionString = "server=" & Me.serverAddress & ";" _
            & "user id=" & Me.user & ";" _
            & "password=" & Me.password & ";" _
            & "database=" & Me.database

        Try
            mysql.Open()
            Console.WriteLine("Mysql Connection Successfully opened")
            mysql.Close()
        Catch ex As Exception
            Console.WriteLine("Cannot connect to database: " & ex.Message)
        Finally
            mysql.Dispose()
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
