Public Class LoginModel
    Private _username As String
    Private _hashPassword As String
    Private _id As Integer

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property HashPassword As String
        Get
            Return _hashPassword
        End Get
        Set(value As String)
            _hashPassword = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal username As String, ByVal hash As String)
        Me.Id = id
        Me.Username = username
        Me.HashPassword = hash
    End Sub

End Class
