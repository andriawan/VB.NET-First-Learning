Imports hasher = BCrypt.Net.BCrypt

Public Class Form1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DBConnection.getInstance(New MySql.Data.MySqlClient.MySqlConnection,
                                 "localhost", "root", "", "vb")

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        MessageBox.Show("hello " & hasher.HashPassword("test"))
        Console.WriteLine("hash 123456 : " & hasher.HashPassword("123456"))
    End Sub

End Class
