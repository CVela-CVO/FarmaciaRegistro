Imports MySql.Data.MySqlClient
Public Class BuscarProductos
    Dim columnabuscar As String
    Dim datobuscar As String
    Dim stringbuscar As String
    Dim Index As Integer
    Public idmedicamento As String
    Public varname As String
    Public varexistencias As String
    Public varcompra As String
    Public varventa As String
    Dim existencias As String
    Sub designbuscar()
        If ComboBox1.Text = "Nombre" Then
            columnabuscar = " WHERE m.name_medicamento LIKE "
            datobuscar = "'" + TextBox1.Text + "%" + "'" + " AND " + "m.medica_existencias > 0 "
        ElseIf ComboBox1.Text = "Distribuidora" And TextBox1.Text <> "" Then
            columnabuscar = " WHERE dis.name_distribuidora LIKE "
            datobuscar = "'" + TextBox1.Text + "%" + "'" + +" AND " + "m.medica_existencias > 0 "
        ElseIf ComboBox1.Text = "Marca" And TextBox1.Text <> "" Then
            columnabuscar = " WHERE ma.name_marca LIKE "
            datobuscar = "'" + TextBox1.Text + "%" + "'" + " AND " + "m.medica_existencias > 0 "
        ElseIf ComboBox1.Text = "" Then
            columnabuscar = " WHERE "
            datobuscar = "m.medica_existencias > 0 "
        ElseIf ComboBox1.Text <> "" And TextBox1.Text = "" Then
            MessageBox.Show("Debe ingresar un dato a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles Btbuscar.Click
        designbuscar()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT m.id_medicamento as 'ID', m.name_medicamento as 'Nombre',m.precio_medicamento as 'Precio',m.medica_existencias as 'Existencia', m.img_medicamento as 'Fotografía' ,ma.name_marca as 'Marca', ma.ico_marca as 'Logotipo de Marca', m.fechacad_medicamento as 'Fecha de Caducidad', m.obs_medicamento as 'Observación', dis.name_distribuidora as 'Distribuidora', dis.dir_distribuidora as 'Dirección de Distribuidora', dis.num_distribuidora as 'Teléfono de Distribuidora', m.costo_medicamento as 'Costo' FROM medicamento m INNER JOIN distribuidoras dis ON m.id_distribuidora = dis.id_distribuidora INNER JOIN marca ma ON m.id_marca = ma.id_marca" + columnabuscar + datobuscar + ";"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(Index)
        idmedicamento = selectedrow.Cells(0).Value.ToString
        varname = selectedrow.Cells(1).Value.ToString
        varcompra = selectedrow.Cells(12).Value.ToString
        varventa = selectedrow.Cells(2).Value.ToString
        varexistencias = selectedrow.Cells(3).Value.ToString
        Ventas.setarticulo(idmedicamento, varname, varcompra, varventa, varexistencias)
        Me.Hide()
    End Sub
End Class