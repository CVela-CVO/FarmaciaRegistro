Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
    Dim nuevaclave As String
    Public tokenusertype As String

    Private Sub BtLogout_Click(sender As Object, e As EventArgs) Handles BtLogout.Click
        End
    End Sub

    Private Sub BtLogin_Click(sender As Object, e As EventArgs) Handles BtLogin.Click
        Me.Hide()
        MenuM.Show()


    End Sub
End Class
