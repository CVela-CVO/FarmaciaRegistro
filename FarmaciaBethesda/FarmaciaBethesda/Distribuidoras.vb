Imports MySql.Data.MySqlClient
Public Class Distribuidoras
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
        comando.CommandText = "SELECT nombre_depto FROM `departamentos`"
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
        adaptador.Fill(tabla)
        CbDpto.DataSource = tabla
        CbDpto.DisplayMember = "departamentos"
        CbDpto.ValueMember = "nombre_depto"
        conexion.Close()
    End Sub


    Private Sub PbMarca_Click(sender As Object, e As EventArgs) Handles PbDistribuidoras.Click

    End Sub

    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()
        Dim direccionimagen As String
        direccionimagen = OpenFileDialog1.FileName
        PbDistribuidoras.Image = Image.FromFile(direccionimagen, True)
        MessageBox.Show(direccionimagen)
    End Sub

    Private Sub Distribuidoras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DTGmarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmarcas.CellContentClick
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
        direccionimagen = selectedrow.Cells(9).Value.ToString
        DateTimePicker1.Value = selectedrow.Cells(4).Value.ToString
    End Sub
End Class