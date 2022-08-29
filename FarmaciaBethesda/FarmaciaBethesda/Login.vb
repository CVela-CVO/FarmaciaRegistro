Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
    Dim nuevaclave As String
    Public tokenusertype As String
    Sub gettypeuser()
        Dim comando As MySqlCommand = New MySqlCommand()
        Dim cadenaConexion = "server=localhost;database=compuxela;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT `usertype` FROM `usuarios` WHERE `username` = '" & TbUsuario.Text & "' AND `userpass` = '" & nuevaclave & "';"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        tokenusertype = dt.Items(0).ToString
        conn.Close()
    End Sub
    Private Sub BtLogout_Click(sender As Object, e As EventArgs) Handles BtLogout.Click
        End
    End Sub

    Private Sub BtLogin_Click(sender As Object, e As EventArgs) Handles BtLogin.Click
        Dim codigo As New UnicodeEncoding()
        Dim md5 As New MD5CryptoServiceProvider()
        Dim clave As String
        clave = TbContraseña.Text
        Dim Hash() As Byte = md5.ComputeHash(codigo.GetBytes(clave))
        nuevaclave = Convert.ToBase64String(Hash)
        Dim cadenaConexion = "server=localhost;database=compuxela;userid=root;password="
        Dim conn As New MySqlConnection(cadenaConexion)
        conn.Open()
        Dim leer As MySqlDataReader
        Dim codigo2 As MySqlCommand
        codigo2 = New MySqlCommand()
        codigo2.Connection = conn
        codigo2.CommandText = "SELECT * FROM `usuarios` WHERE username = '" & TbUsuario.Text & "' and userpass = '" & nuevaclave & "'"
        leer = codigo2.ExecuteReader()
        If leer.Read() Then
            gettypeuser()
            Me.Hide()
            MenuM.Show()
        Else
            MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
        conn.Close()
        TbUsuario.Clear()
        TbContraseña.Clear()

    End Sub
End Class
