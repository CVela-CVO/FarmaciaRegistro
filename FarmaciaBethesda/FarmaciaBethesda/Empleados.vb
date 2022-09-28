Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Empleados
    Dim nuevaclave As String
    Dim direccionimagen As String
    Dim tipouser As String
    Dim index As Integer
    Dim direcciontemporal As String
    Dim stringindex As String
    Dim columnabuscar As String
    Dim datobuscar As String
    Dim stringbuscar As String
    Sub cadenanueva()
        Dim nuevacadena() As Char
        nuevacadena = direccionimagen.ToCharArray()
        For i = 0 To nuevacadena.Length - 1 Step 1
            If nuevacadena(i) = "\" Then
                direcciontemporal = direcciontemporal & "\\"
            Else
                direcciontemporal = direcciontemporal & nuevacadena(i)
            End If
        Next
    End Sub
    Sub cleartxt()
        TbNombre.Clear()
        TbCui.Clear()
        TbEmail.Clear()
        TbNumero.Clear()
        TbPassword.Clear()
        TbPuesto.Clear()
        TbUserName.Clear()
        TbVerify.Clear()
        direccionimagen = ""
        PbEmpleado.Image = Nothing
        nuevaclave = ""
        tipouser = ""
        stringindex = ""
        RdAdmin.Checked = False
        RdAdmin.Checked = False
    End Sub
    Sub designbuscar()

        If cbbuscar.Text = "Tipo" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE usertype LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Nombre" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE nombre_user LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Puesto" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE puesto_usuario LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "CUI" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE CUI_usuario LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Email" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE correo_usuario LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Telefono" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE num_usuario LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "" And tbbuscar.Text = "" Then
            columnabuscar = ""
            datobuscar = ""
        ElseIf cbbuscar.Text <> "" And tbbuscar.Text = "" Then
            MessageBox.Show("Debe ingresar un dato a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbbuscar.Text = "" And tbbuscar.Text <> "" Then
            MessageBox.Show("Debe seleccionar la categoría del dato a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Sub obtenertipo()
        If RdAdmin.Checked = True Then
            tipouser = "Administrador"
        ElseIf RdVendedor.Checked = True Then
            tipouser = "Vendedor"
        End If
    End Sub
    Sub encriptacion()
        Dim codigo As New UnicodeEncoding()
        Dim md5 As New MD5CryptoServiceProvider()
        Dim clave As String
        clave = TbPassword.Text
        Dim Hash() As Byte = md5.ComputeHash(codigo.GetBytes(clave))
        nuevaclave = Convert.ToBase64String(Hash)
    End Sub

    Sub guardardatos()

        obtenertipo()
        If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbCui.Text) Or
        String.IsNullOrEmpty(direccionimagen) Or String.IsNullOrEmpty(TbEmail.Text) Or String.IsNullOrEmpty(TbPassword.Text) Or
        String.IsNullOrEmpty(TbPassword.Text) Or String.IsNullOrEmpty(TbPuesto.Text) Or String.IsNullOrEmpty(tipouser) Or String.IsNullOrEmpty(TbVerify.Text) Then
            MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim regexPattern As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
            Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
            Dim result As Boolean = emailRegEx.IsMatch(TbEmail.Text)
            If Not result Then
                MessageBox.Show("Ingrese un correo válido", "Verificación de Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If result Then
                If TbPassword.Text <> TbVerify.Text Then
                    MessageBox.Show("La contraseña que ingresó, no coincide con la verificción", "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    encriptacion()
                    Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                    Dim conn As New MySqlConnection(cadenaConexion)
                    Dim da As MySqlDataAdapter
                    Dim dt As DataTable
                    conn.Open()

                    Dim sQuery = "INSERT INTO usuarios (username, userpass, usertype, nombre_user, CUI_usuario, num_usuario, puesto_usuario, correo_usuario, img_usuario) VALUES ('" & TbUserName.Text & "','" & nuevaclave & "','" & tipouser & "','" & TbNombre.Text & "','" & TbCui.Text & "','" & TbNumero.Text & "','" & TbPuesto.Text & "','" & TbEmail.Text & "','" & direcciontemporal & "');"
                    da = New MySqlDataAdapter(sQuery, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    conn.Close()
                    ReadQuery()
                    cleartxt()
                End If
            End If
        End If

    End Sub
    Sub ReadQuery()

        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT id_user as 'ID', nombre_user as 'Nombre', CUI_usuario as 'CUI', num_usuario as 'Teléfono', puesto_usuario as 'Puesto', correo_usuario as 'Email', username as 'UserName', userpass as 'Contraseña Encriptada', usertype as 'Tipo de Usuario', img_usuario as 'Imagen' FROM usuarios;"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DTGempleados.DataSource = dt
        conn.Close()

    End Sub
    Sub updatedata()

        obtenertipo()
        If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbCui.Text) Or
        String.IsNullOrEmpty(direccionimagen) Or String.IsNullOrEmpty(TbEmail.Text) Or String.IsNullOrEmpty(TbPassword.Text) Or
        String.IsNullOrEmpty(TbPassword.Text) Or String.IsNullOrEmpty(TbPuesto.Text) Or String.IsNullOrEmpty(tipouser) Or String.IsNullOrEmpty(TbVerify.Text) Then
            MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim regexPattern As String = "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$"
            Dim emailRegEx As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(regexPattern)
            Dim result As Boolean = emailRegEx.IsMatch(TbEmail.Text)
            If Not result Then
                MessageBox.Show("Ingrese un correo válido", "Verificación de Email", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation)
            End If
            If result Then
                If TbPassword.Text <> TbVerify.Text Then
                    MessageBox.Show("La contraseña que ingresó, no coincide con la verificación", "Verificación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    encriptacion()
                    Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                    Dim conn As New MySqlConnection(cadenaConexion)
                    Dim da As MySqlDataAdapter
                    Dim dt As DataTable
                    conn.Open()

                    Dim sQuery = "UPDATE usuarios SET username='" & TbUserName.Text & "',
                            userpass='" & nuevaclave & "',usertype='" & tipouser & "',
                            nombre_user='" & TbNombre.Text & "',CUI_usuario='" & TbCui.Text & "',
                            num_usuario='" & TbNumero.Text & "',puesto_usuario='" & TbPuesto.Text & "',
                            correo_usuario='" & TbEmail.Text & "',img_usuario='" & direcciontemporal & "' 
                            WHERE id_user=" & stringindex
                    da = New MySqlDataAdapter(sQuery, conn)
                    dt = New DataTable
                    da.Fill(dt)
                    conn.Close()
                    ReadQuery()
                    cleartxt()
                End If
            End If
        End If

    End Sub
    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        Try
            OpenFileDialog1.ShowDialog()
            direccionimagen = OpenFileDialog1.FileName
            cadenanueva()

            PbEmpleado.Image = Image.FromFile(direccionimagen, True)

        Catch ex As Exception
            MessageBox.Show("Hubo un error al incorporar la ruta o formato de la imagen al programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadQuery()
    End Sub

    Private Sub DTGempleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGempleados.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DTGempleados.Rows(index)
        stringindex = selectedrow.Cells(0).Value.ToString
        TbNombre.Text = selectedrow.Cells(1).Value.ToString
        TbCui.Text = selectedrow.Cells(2).Value.ToString
        TbNumero.Text = selectedrow.Cells(3).Value.ToString
        TbPuesto.Text = selectedrow.Cells(4).Value.ToString
        TbEmail.Text = selectedrow.Cells(5).Value.ToString
        TbUserName.Text = selectedrow.Cells(6).Value.ToString
        TbPassword.Text = ""
        TbVerify.Text = ""
        If selectedrow.Cells(8).Value.ToString = "Administrador" Then
            RdAdmin.Checked = True
            RdVendedor.Checked = False
        ElseIf selectedrow.Cells(8).Value.ToString = "Vendedor" Then
            RdAdmin.Checked = False
            RdVendedor.Checked = True
        End If
        direccionimagen = selectedrow.Cells(9).Value.ToString

        PbEmpleado.Image = Image.FromFile(direccionimagen, True)
    End Sub

    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click

        If String.IsNullOrEmpty(stringindex) Then
            MessageBox.Show("Seleccione una fila de la tabla para eliminarla correctamente", "Error de tabla", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "DELETE FROM usuarios WHERE id_user =" & stringindex
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            conn.Close()
            ReadQuery()
            cleartxt()
        End If

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        updatedata()
    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        guardardatos()
    End Sub

    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        guardardatos()
    End Sub

    Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles Btbuscar.Click
        designbuscar()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT id_user as 'ID', nombre_user as 'Nombre', CUI_usuario as 'CUI', num_usuario as 'Teléfono', puesto_usuario as 'Puesto', correo_usuario as 'Email', username as 'UserName', userpass as 'Contraseña Encriptada', usertype as 'Tipo de Usuario', img_usuario as 'Imagen' FROM usuarios" + columnabuscar + datobuscar + ";"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DTGempleados.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadQuery()
        tbbuscar.Clear()
    End Sub
End Class