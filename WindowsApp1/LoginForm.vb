Imports hasher = BCrypt.Net.BCrypt

Public Class LoginForm

    Dim login As New CRUDRepository

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim Userlogin As LoginModel = login.getUser(TextBoxName.Text)

        If hasher.Verify(TextBoxPassword.Text, Userlogin.HashPassword) Then
            SessionState.setName(TextBoxName.Text)
            SessionState.setLoggedIn(True)
            SessionState.setRole("Admin")
            Dashboard.Show()
        Else
            MessageBox.Show("User not valid & not authenticated")
        End If

    End Sub
End Class
