Imports MySql.Data.MySqlClient
Public Class Factura
    Dim ID = VistaVentas.numero
    Dim cliente = VistaVentas.cliente
    Dim NIT = VistaVentas.nit
    Dim direccion = VistaVentas.direccion
    Dim telefono = VistaVentas.telefono
    Dim serie = VistaVentas.serie
    Dim fecha = VistaVentas.fecha
    Dim vendedor = VistaVentas.vendedor
    Dim total = VistaVentas.total
    Sub tablaproductos()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT d.medicamento_cantidad as 'Cantidad', m.name_medicamento as 'Medicamento', ROUND(((m.precio_medicamento * d.medicamento_cantidad) * 1.12), 2) as 'SubTotal' FROM detalle_pedidos d INNER JOIN medicamento m ON d.id_medicamento = m.id_medicamento WHERE id_pedido = " & ID & ";"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idfactura.Text = ID
        namecliente.Text = cliente
        nitcliente.Text = NIT
        dircliente.Text = direccion
        telcliente.Text = telefono
        seriepedido.Text = serie
        datepedido.Text = fecha
        lavelvendedor.Text = vendedor
        tbtotal.Text = total
        tablaproductos()
    End Sub
End Class