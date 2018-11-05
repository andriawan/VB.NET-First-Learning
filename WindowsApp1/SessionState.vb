Public Class SessionState

    Private Shared loggedIn As Boolean = False
    Private Shared role As String
    Private Shared name As String

    Public Shared Sub setLoggedIn(ByVal state As Boolean)
        loggedIn = state
    End Sub

    Public Shared Function getLoggedIn() As Boolean
        Return loggedIn
    End Function

    Public Shared Sub setRole(ByVal roleUser As String)
        role = roleUser
    End Sub

    Public Shared Function getRole() As String
        Return role
    End Function

    Public Shared Sub setName(ByVal nameUser As String)
        name = nameUser
    End Sub

    Public Shared Function getName() As String
        Return name
    End Function

End Class
