Imports MySql.Data.MySqlClient

Public Class CRUDRepository

    Dim connection As DBConnection

    Public Sub New()
        Me.connection = DBConnection.getInstance(New MySqlConnection, "localhost", "root", "", "vb")
    End Sub

    Public Function getUser(ByVal username As String) As LoginModel

        Dim query As New MySqlCommand
        Dim login = Nothing

        connection.mysql.Open()
        query.Connection = connection.mysql
        query.CommandText = "SELECT * FROM m_users WHERE username=@USERNAME LIMIT 1"
        query.Prepare()
        query.Parameters.AddWithValue("@USERNAME", username)
        Dim result As MySqlDataReader = query.ExecuteReader()

        While result.Read()
            Console.WriteLine("ID : " & result.GetInt32(0))
            Console.WriteLine("username : " & result.GetString(1))
            Console.WriteLine("hash : " & result.GetString(2))

            login = New LoginModel(result.GetString(0),
                                   result.GetString(1),
                                   result.GetString(2))

        End While

        connection.mysql.Close()

        Return login

    End Function

    Public Function loadAllUser() As DataSet

        Dim query As New MySqlCommand

        connection.mysql.Open()
        query.Connection = connection.mysql
        query.CommandText = "SELECT * FROM m_users"
        query.Prepare()

        Dim adapter As New MySqlDataAdapter(query)
        Dim dataset As New DataSet

        adapter.Fill(dataset, "m_users")

        connection.mysql.Close()

        Return dataset

    End Function

    Public Function saveUSer(ByVal username As String, ByVal password As String) As Integer

        Dim query As New MySqlCommand

        connection.mysql.Open()

        query.Connection = connection.mysql
        query.CommandText = "INSERT INTO `m_users` (`username`, `password`, `active`) VALUES (@USERNAME, @PASSWORD, '1');"
        query.Parameters.AddWithValue("@USERNAME", username)
        query.Parameters.AddWithValue("@PASSWORD", password)
        query.Prepare()

        Dim result As Integer = query.ExecuteNonQuery()

        connection.mysql.Close()

        Return result

    End Function


End Class
