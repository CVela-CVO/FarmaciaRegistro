Imports MySql.Data.MySqlClient
Public Class Distribuidoras
    Dim index As Integer
    Dim iddeptoscombobox As String
    Dim stringindex As String
    Sub cleartxt()
        TbNombre.Clear()
        TbDireccion.Clear()
        TbNumero.Clear()
        stringindex = ""
        iddeptoscombobox = ""
    End Sub
    Sub guardardatos()
        Try
            indexdepto()
            If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbDireccion.Text) Or
            String.IsNullOrEmpty(TbNumero.Text) Then
                MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "INSERT INTO distribuidoras (name_distribuidora, id_departamento, dir_distribuidora, num_distribuidora) VALUES ('" & TbNombre.Text & "'," & iddeptoscombobox & ",'" & TbDireccion.Text & "','" & TbNumero.Text & "');"
                da = New MySqlDataAdapter(sQuery, conn)
                dt = New DataTable
                da.Fill(dt)
                conn.Close()
                ReadQuery()
                cleartxt()
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub indexdepto()
        Try
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "SELECT id_departamento FROM departamentos WHERE nombre_depto = '" & CbDpto.Text & "'"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            iddeptoscombobox = dt.Rows(0)("id_departamento").ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cbdeptodata()
        Try
            Dim comando As MySqlCommand = New MySqlCommand()
            Dim tabla As DataTable = New DataTable()
            Dim conexion As MySqlConnection = New MySqlConnection()
            conexion.ConnectionString = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = "SELECT nombre_depto FROM `departamentos`"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            CbDpto.DataSource = tabla
            CbDpto.DisplayMember = "departamentos"
            CbDpto.ValueMember = "nombre_depto"
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ReadQuery()
        Try
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "SELECT m.`id_distribuidora` as 'ID', m.`name_distribuidora` as 'Nombre', ma.`nombre_depto` as 'depto', m.`num_distribuidora` as 'numero', m.`dir_distribuidora` as 'direccion'FROM distribuidoras m INNER JOIN departamentos ma ON m.id_departamento = ma.id_departamento;"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            DTGmarcas.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub DTGmarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmarcas.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Distribuidoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadQuery()
            cbdeptodata()
        Catch EX As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        Try
            indexdepto()
            If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbNumero.Text) Or
            String.IsNullOrEmpty(TbDireccion.Text) Then
                MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "UPDATE distribuidoras SET name_distribuidora='" & TbNombre.Text & "',id_departamento=" & iddeptoscombobox & ",`dir_distribuidora`='" & TbDireccion.Text & "',num_distribuidora='" & TbNumero.Text & "' WHERE 1"
                da = New MySqlDataAdapter(sQuery, conn)
                dt = New DataTable
                da.Fill(dt)
                conn.Close()
                ReadQuery()
                cleartxt()
            End If
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        guardardatos()

    End Sub

    Private Sub BtEliminar_Click(sender As Object, e As EventArgs) Handles BtEliminar.Click
        Try
            If String.IsNullOrEmpty(stringindex) Then
                MessageBox.Show("Seleccione una fila de la tabla para eliminarla correctamente", "Error de tabla", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "DELETE FROM distribuidoras WHERE id_distribuidora =" & stringindex
                da = New MySqlDataAdapter(sQuery, conn)
                dt = New DataTable
                da.Fill(dt)
                conn.Close()
                ReadQuery()
                cleartxt()
            End If
        Catch EX As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Try
            guardardatos()
        Catch EX As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DTGmarcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmarcas.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DTGmarcas.Rows(index)
        stringindex = selectedrow.Cells(0).Value.ToString
        TbNombre.Text = selectedrow.Cells(1).Value.ToString
        CbDpto.SelectedItem = selectedrow.Cells(2).Value.ToString
        TbDireccion.Text = selectedrow.Cells(3).Value.ToString
        TbNumero.Text = selectedrow.Cells(4).Value.ToString
    End Sub
End Class