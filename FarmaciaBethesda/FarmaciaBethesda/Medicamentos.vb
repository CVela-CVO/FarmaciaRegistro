Imports MySql.Data.MySqlClient
Public Class Medicamentos
    Dim direccionimagen As String
    Dim costomedic As String
    Dim preciomedic As String
    Dim existenciasmedic As String
    Dim stringindex As String
    Dim index As Integer
    Dim idmarcacombobox As String
    Dim iddistribcombobox As String
    Sub indexmarca()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT id_marca FROM `marca` WHERE name_marca = '" & ComboBox1.SelectedText & "';"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)

        conn.Close()
    End Sub
    Sub indexdistrib()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT id_distribuidora FROM `distribuidoras` WHERE name_distribuidora = '" + ComboBox2.SelectedText + "';"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        'iddistribcombobox = dt.Rows(0)("id_distribuidora")
        conn.Close()
    End Sub
    Sub cbmarcadata()
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
    End Sub
    Sub cbmdistribdata()
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
    End Sub
    Sub ReadQuery()
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
    End Sub
    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()

        direccionimagen = OpenFileDialog1.FileName
        PbMedicamento.Image = Image.FromFile(direccionimagen, True)
        MessageBox.Show(direccionimagen)
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

    End Sub

    Private Sub NUDcosto_ValueChanged(sender As Object, e As EventArgs) Handles NUDcosto.ValueChanged

        costomedic = "Q" + Convert.ToString(NUDcosto.Value)
    End Sub

    Private Sub DTGmedicamentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmedicamentos.CellContentClick
        Index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DTGmedicamentos.Rows(Index)
        stringindex = selectedrow.Cells(0).Value.ToString
        TbNombre.Text = selectedrow.Cells(1).Value.ToString
        TbObservacion.Text = selectedrow.Cells(5).Value.ToString
        ComboBox1.SelectedItem = selectedrow.Cells(2).Value.ToString
        ComboBox2.SelectedItem = selectedrow.Cells(3).Value.ToString
        NUDprecio.Value = selectedrow.Cells(6).Value
        NUDcosto.Value = selectedrow.Cells(7).Value.ToString
        NUDexistencias.Value = selectedrow.Cells(8).Value.ToString
        direccionimagen = selectedrow.Cells(9).Value.ToString
        DateTimePicker1.Value = selectedrow.Cells(4).Value.ToString

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        idmarcacombobox = Convert.ToString(ComboBox1.SelectedIndex + 1)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        iddistribcombobox = Convert.ToString(ComboBox2.SelectedIndex + 1)

    End Sub

    Private Sub BtNuevo_Click(sender As Object, e As EventArgs) Handles BtNuevo.Click
        If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(TbObservacion.Text) Or
        String.IsNullOrEmpty(direccionimagen) Then
            MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "INSERT INTO medicamento (name_medicamento, id_marca, fechacad_medicamento, obs_medicamento, id_distribuidora, precio_medicamento, costo_medicamento, medica_existencias, img_medicamento) VALUES ('" & TbNombre.Text & "'," & idmarcacombobox & "," & Convert.ToString(DateTimePicker1.Value) & ",'" & TbObservacion.Text & "'," & iddistribcombobox & ",'" & preciomedic & "','" & costomedic & "'," & existenciasmedic & ",'" & direccionimagen & "')"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            conn.Close()
            ReadQuery()

        End If
    End Sub
End Class