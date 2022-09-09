Imports MySql.Data.MySqlClient
Public Class VistaVentas
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
    Dim varfechasql As String
    Public numero, serie, cliente, nit, telefono, direccion, fecha, vendedor, total As String
    Sub ReadQuery()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT p.id_pedido as 'ID', p.serie_pedido as 'Serie', p.name_cliente as 'Cliente', p.nit_cliente as 'NIT', p.num_cliente as 'Telefono del Cliente', p.dir_cliente as 'Dirección', p.fecha_pedido as 'Fecha del Pedido', u.nombre_user as 'Vendedor',  p.total_pedido as 'Total de Venta' FROM pedidos p INNER JOIN usuarios u ON p.id_user = u.id_user;"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrEmpty(numero) Then
                MessageBox.Show("Seleccione una fila de la tabla para eliminarla correctamente", "Error de tabla", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "DELETE FROM pedidos WHERE id_pedido =" & numero & ";" & "DELETE FROM detalle_pedidos WHERE id_pedido =" & numero & ";"
                da = New MySqlDataAdapter(sQuery, conn)
                dt = New DataTable
                da.Fill(dt)
                conn.Close()
                ReadQuery()
            End If
        Catch EX As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtProd_Click(sender As Object, e As EventArgs) Handles BtProd.Click
        Me.Hide()
        MenuM.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(numero) Then
            MessageBox.Show("Debe seleccionar una fila de la tabla para mostrar su factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Factura.Show()
        End If
    End Sub

    Private Sub VistaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadQuery()
    End Sub

    Sub fechasql()
        If DTPfecha.Value.Month / 10 < 1 And DTPfecha.Value.Day / 10 > 1 Then
            varfechasql = DTPfecha.Value.Year & "-0" & DTPfecha.Value.Month & "-" & DTPfecha.Value.Day
        ElseIf DTPfecha.Value.Day / 10 < 1 And DTPfecha.Value.Month / 10 > 1 Then
            varfechasql = DTPfecha.Value.Year & "-" & DTPfecha.Value.Month & "-0" & DTPfecha.Value.Day
        ElseIf DTPfecha.Value.Day / 10 < 1 And DTPfecha.Value.Month / 10 < 1 Then
            varfechasql = DTPfecha.Value.Year & "-0" & DTPfecha.Value.Month & "-0" & DTPfecha.Value.Day
        Else
            varfechasql = DTPfecha.Value.Year & "-0" & DTPfecha.Value.Month & "-" & DTPfecha.Value.Day
        End If
    End Sub
    Sub designbuscar()
        fechasql()
        If ComboBox1.Text = "Fecha" Then
            columnabuscar = " WHERE p.fecha_pedido LIKE "
            datobuscar = "'" + varfechasql + "%" + "'"
        ElseIf ComboBox1.Text = "Serie" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE p.serie_pedido LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf ComboBox1.Text = "Vendedor" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE u.nombre_user LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf ComboBox1.Text = "NIT" And tbbuscar.Text <> "" Then
            columnabuscar = " WHERE p.nit_cliente LIKE "
            datobuscar = "'" + tbbuscar.Text + "%" + "'"
        ElseIf ComboBox1.Text = "" And tbbuscar.Text = "" Then
            columnabuscar = ""
            datobuscar = ""
        ElseIf ComboBox1.Text <> "" And tbbuscar.Text = "" Then
            MessageBox.Show("Debe ingresar un dato a buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ComboBox1.Text = "" And tbbuscar.Text <> "" Then
            MessageBox.Show("Debe seleccionar la categoría del dato a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            tbbuscar.Enabled = False
            DTPfecha.Enabled = True
        Else
            tbbuscar.Enabled = True
            DTPfecha.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ReadQuery()
        tbbuscar.Clear()
    End Sub

    Private Sub Btbuscar_Click(sender As Object, e As EventArgs) Handles Btbuscar.Click
        designbuscar()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT p.id_pedido as 'ID', p.serie_pedido as 'Serie', p.name_cliente as 'Cliente', p.nit_cliente as 'NIT', p.num_cliente as 'Telefono del Cliente', p.dir_cliente as 'Dirección', p.fecha_pedido as 'Fecha del Pedido', u.nombre_user as 'Vendedor',  p.total_pedido as 'Total de Venta' FROM pedidos p INNER JOIN usuarios u ON p.id_user = u.id_user" + columnabuscar + datobuscar + ";"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DataGridView1.Rows(Index)
        numero = selectedrow.Cells(0).Value.ToString
        serie = selectedrow.Cells(1).Value.ToString
        cliente = selectedrow.Cells(2).Value.ToString
        nit = selectedrow.Cells(3).Value.ToString
        telefono = selectedrow.Cells(4).Value.ToString
        direccion = selectedrow.Cells(5).Value.ToString
        fecha = selectedrow.Cells(6).Value.ToString
        vendedor = selectedrow.Cells(7).Value.ToString
        total = selectedrow.Cells(8).Value.ToString

    End Sub
End Class