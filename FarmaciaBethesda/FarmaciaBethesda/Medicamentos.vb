Imports MySql.Data.MySqlClient
Public Class Medicamentos
    Dim direccionimagen As String
    Dim costomedic As String
    Dim preciomedic As String
    Dim existenciasmedic As String
    Dim stringindex As String
    Dim index As Integer
    Dim idmarcacombobox As String
    Dim fechasql As String
    Dim iddistribcombobox As String
    Dim columnabuscar As String
    Dim datobuscar As String
    Dim stringbuscar As String
    Dim direccionfinal As String
    Dim direccionproduc As String = "C:\xampp\htdocs\php_bethesda\ImgFarmacia\Productos\"
    Sub cleartxt()
        TbNombre.Clear()
        TbObservacion.Clear()
        NUDcosto.Value = 0.1
        NUDexistencias.Value = 0.1
        NUDprecio.Value = 0.1
        DateTimePicker1.Refresh()
        direccionimagen = ""
        PbMedicamento.Image = Nothing
        costomedic = ""
        preciomedic = ""
        existenciasmedic = ""
        stringindex = ""
        idmarcacombobox = ""
        iddistribcombobox = ""
        idmarcacombobox = ""
        fechasql = ""
    End Sub
    Sub designbuscar()

        If cbbuscar.Text = "Nombre" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE m.name_medicamento LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Marca" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE ma.name_marca LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf cbbuscar.Text = "Distribuidora" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE di.name_distribuidora LIKE "
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
    Sub dateformato()
        fechasql = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
    End Sub
    Sub guardardatos()
        Try
            indexmarca()
            indexdistrib()
            dateformato()
            If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbObservacion.Text) Or
            String.IsNullOrEmpty(direccionimagen) Then
                MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "INSERT INTO medicamento (name_medicamento, id_marca, fechacad_medicamento, obs_medicamento, id_distribuidora, precio_medicamento, costo_medicamento, medica_existencias, img_medicamento) VALUES ('" & TbNombre.Text & "'," & idmarcacombobox & ",'" & fechasql & "','" & TbObservacion.Text & "'," & iddistribcombobox & ",'" & Convert.ToString(NUDprecio.Value) & "','" & Convert.ToString(NUDcosto.Value) & "','" & Convert.ToString(NUDexistencias.Value) & "','" & direccionfinal & "');"
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
    Sub indexmarca()
        Try
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "SELECT id_marca FROM marca WHERE name_marca = '" & ComboBox1.Text & "'"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            idmarcacombobox = dt.Rows(0)("id_marca").ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub indexdistrib()
        Try
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "SELECT id_distribuidora FROM distribuidoras WHERE name_distribuidora = '" + ComboBox2.Text + "'"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            iddistribcombobox = dt.Rows(0)("id_distribuidora").ToString
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cbmarcadata()
        Try
            Dim comando As MySqlCommand = New MySqlCommand()
            Dim tabla As DataTable = New DataTable()
            Dim conexion As MySqlConnection = New MySqlConnection()
            conexion.ConnectionString = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = "SELECT name_marca FROM `marca`"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            ComboBox1.DataSource = tabla
            ComboBox1.DisplayMember = "marca"
            ComboBox1.ValueMember = "name_marca"
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cbmdistribdata()
        Try
            Dim comando As MySqlCommand = New MySqlCommand()
            Dim tabla As DataTable = New DataTable()
            Dim conexion As MySqlConnection = New MySqlConnection()
            conexion.ConnectionString = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
            comando.CommandText = "SELECT name_distribuidora FROM `distribuidoras`"
            Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            ComboBox2.DataSource = tabla
            ComboBox2.DisplayMember = "distribuidoras"
            ComboBox2.ValueMember = "name_distribuidora"
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
            Dim sQuery = "SELECT m.`id_medicamento` as 'ID', m.`name_medicamento` as 'Nombre', ma.`name_marca` as 'Marca', di.`name_distribuidora` as 'Distribuidora' ,m.`fechacad_medicamento` as 'Fecha de Caducidad', m.`obs_medicamento` as 'Observación', m.`precio_medicamento` as 'Precio',m.`costo_medicamento` as 'Costo',m.`medica_existencias` as 'Existencias' , m.`img_medicamento` as 'Imagen' FROM medicamento m INNER JOIN marca ma ON m.id_marca = ma.id_marca INNER JOIN distribuidoras di ON m.id_distribuidora = di.id_distribuidora;"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            DTGmedicamentos.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        Try
            OpenFileDialog1.ShowDialog()
            direccionimagen = OpenFileDialog1.FileName

            direccionfinal = direccionimagen.Replace("C:\xampp\htdocs\php_bethesda\ImgFarmacia\Productos\", "")
            PbMedicamento.Image = Image.FromFile(direccionimagen, True)

        Catch ex As Exception
            MessageBox.Show("Hubo un error al incorporar la ruta o formato de la imagen al programa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()
    End Sub

    Private Sub Medicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadQuery()
        cbmarcadata()
        cbmdistribdata()
    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click

        indexmarca()
        indexdistrib()
        dateformato()
        If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbObservacion.Text) Or
            String.IsNullOrEmpty(direccionimagen) Then
            MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "UPDATE medicamento SET name_medicamento='" & TbNombre.Text & "',id_marca=" & idmarcacombobox & ",fechacad_medicamento='" & fechasql & "',obs_medicamento='" & TbObservacion.Text & "',id_distribuidora = " & iddistribcombobox & ",precio_medicamento='" & Convert.ToString(NUDprecio.Value) & "',costo_medicamento='" & Convert.ToString(NUDprecio.Value) & "',medica_existencias='" & Convert.ToString(NUDexistencias.Value) & "',img_medicamento='" & direccionfinal & "' WHERE id_medicamento=" & stringindex
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            conn.Close()
            ReadQuery()
            cleartxt()
        End If

    End Sub
    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        guardardatos()
    End Sub

    Private Sub DTGmedicamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmedicamentos.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow

        selectedrow = DTGmedicamentos.Rows(index)
        stringindex = selectedrow.Cells(0).Value.ToString
        TbNombre.Text = selectedrow.Cells(1).Value.ToString
        TbObservacion.Text = selectedrow.Cells(5).Value.ToString
        ComboBox1.SelectedItem = selectedrow.Cells(2).Value.ToString
        ComboBox2.SelectedItem = selectedrow.Cells(3).Value.ToString
        NUDprecio.Value = selectedrow.Cells(6).Value
        NUDcosto.Value = selectedrow.Cells(7).Value.ToString
        NUDexistencias.Value = selectedrow.Cells(8).Value.ToString
        direccionfinal = selectedrow.Cells(9).Value.ToString
        direccionimagen = direccionproduc & direccionfinal
        PbMedicamento.Image = Image.FromFile(direccionimagen, True)
        DateTimePicker1.Value = selectedrow.Cells(4).Value.ToString
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
                Dim sQuery = "DELETE FROM medicamento WHERE id_medicamento =" & stringindex
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
        guardardatos()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbbuscar.TextChanged

    End Sub

    Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles Btbuscar.Click
        designbuscar()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT m.`id_medicamento` as 'ID', m.`name_medicamento` as 'Nombre', ma.`name_marca` as 'Marca', di.`name_distribuidora` as 'Distribuidora' ,m.`fechacad_medicamento` as 'Fecha de Caducidad', m.`obs_medicamento` as 'Observación', m.`precio_medicamento` as 'Precio',m.`costo_medicamento` as 'Costo',m.`medica_existencias` as 'Existencias' , m.`img_medicamento` as 'Imagen' FROM medicamento m INNER JOIN marca ma ON m.id_marca = ma.id_marca INNER JOIN distribuidoras di ON m.id_distribuidora = di.id_distribuidora" + columnabuscar + datobuscar + ";"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DTGmedicamentos.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReadQuery()
        tbbuscar.Clear()
    End Sub
End Class