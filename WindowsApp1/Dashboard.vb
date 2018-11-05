Imports hasher = BCrypt.Net.BCrypt

Public Class Dashboard

    Dim repo As New CRUDRepository

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        exLabel.Text = "Selamat Datang " & SessionState.getName & ", Jabatan :" _
            & SessionState.getRole

        loadTable()

    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim pass As String = hasher.HashPassword(TextBoxPassword.Text)

        Dim result As Integer = repo.saveUSer(TextBoxUsername.Text, pass)

        If result = 1 Then
            MessageBox.Show("Data berhasil diinput")
            loadTable()
        Else
            MessageBox.Show("Data gagal diinput")
        End If

        Console.WriteLine(result)

    End Sub

    Public Sub loadTable()
        Dim data As DataSet = repo.loadAllUser()
        DataGridUser.DataSource = data.Tables("m_users")
    End Sub
End Class