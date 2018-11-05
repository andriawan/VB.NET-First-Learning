<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(12, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(35, 13)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Name"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(71, 12)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.AutoSize = True
        Me.txtPassword.Location = New System.Drawing.Point(12, 53)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(53, 13)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(71, 53)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(408, 20)
        Me.TextBoxPassword.TabIndex = 3
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(71, 89)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLogin.TabIndex = 4
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 450)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "Form1"
        Me.Text = "Test CRUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents txtPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
End Class
