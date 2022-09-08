Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim consumer As Boolean = True
    Dim cont As Integer = 0
    Dim namecliente, nitcliente, dircliente, telefonocliente, seriepedido As String
    Dim fechasql As String
    Dim idpedido As String
    Dim iduser = Login.iduser
    Sub getidpedido()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "SELECT id_pedido FROM pedidos WHERE serie_pedido = '" & seriepedido & "';"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        idpedido = dt.Rows(0)("id_pedido").ToString
        conn.Close()
    End Sub
    Sub insertarventa()
        dateformato()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery = "INSERT INTO pedidos (name_cliente, nit_cliente, num_cliente, dir_cliente, fecha_pedido, id_user, serie_pedido, total_pedido) VALUES ('" & namecliente & "','" & nitcliente & "','" & telefonocliente & "','" & dircliente & "','" & fechasql & "'," & iduser & ",'" & seriepedido & "','" & TbTotal.Text & "');"
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()
    End Sub
    Sub insertardetalleventa()
        getidpedido()
        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
        Dim conn As New MySqlConnection(cadenaConexion)
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        conn.Open()
        Dim sQuery As String = ""
        For i = 0 To Productos.Items.Count - 1 Step 1
            sQuery = sQuery + "INSERT INTO detalle_pedidos (id_pedido, id_medicamento, medicamento_cantidad) VALUES (" & idpedido & "," & vectorid.Items(i) & "," & Convert.ToString(Cantidad.Items(i)) & ");" + vbCrLf + "UPDATE medicamento SET medica_existencias= " & restavector.Items(i) & " WHERE id_medicamento = " & vectorid.Items(i) & ";"
        Next
        da = New MySqlDataAdapter(sQuery, conn)
        dt = New DataTable
        da.Fill(dt)
        conn.Close()
    End Sub
    Sub cleartxt()
        tbcel.Clear()
        TbName.Clear()
        tbcompra.Clear()
        tbdir.Clear()
        tbexistencias.Clear()
        tbid.Clear()
        TbNit.Clear()
        TbProd.Clear()
        tbserie.Clear()
        TbTotal.Clear()
        TbVenta.Clear()
        NUDcant.Value = 0
        CheckBox1.Checked = False
        consumer = True
        tbcel.Enabled = True
        TbName.Enabled = True
        tbdir.Enabled = True
        TbNit.Enabled = True
        Cantidad.Items.Clear()
        Productos.Items.Clear()
        Subtotal.Items.Clear()
        vectorid.Items.Clear()
        restavector.Items.Clear()
        dtpfecha.Value = DateTime.Today
        cont = 0
        namecliente = Nothing
        nitcliente = Nothing
        dircliente = Nothing
        telefonocliente = Nothing
        seriepedido = Nothing
        fechasql = Nothing
        idpedido = Nothing
    End Sub
    Sub dateformato()
        fechasql = dtpfecha.Value.Year & "-" & dtpfecha.Value.Month & "-" & dtpfecha.Value.Day
    End Sub
    Public Sub setarticulo(par0, par1, par2, par3, par4)
        tbid.Text = par0
        TbProd.Text = par1
        TbCompra.Text = par2
        TbVenta.Text = par3
        TbExistencias.Text = par4
    End Sub
    Private Sub BtVolver_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        BuscarProductos.Show()

    End Sub


    Private Sub BtRegClientes_Click(sender As Object, e As EventArgs) Handles BtRegClientes.Click
        If consumer = True Then
            If String.IsNullOrEmpty(TbName.Text) Or String.IsNullOrEmpty(TbNit.Text) Or String.IsNullOrEmpty(tbdir.Text) Or String.IsNullOrEmpty(tbcel.Text) Or String.IsNullOrEmpty(tbserie.Text) Then
                MessageBox.Show("Si el cliente no es consumidor final, debe ingresar todos sus datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                namecliente = TbName.Text
                nitcliente = TbNit.Text
                dircliente = tbdir.Text
                telefonocliente = tbcel.Text
                seriepedido = tbserie.Text
                TbNit.Enabled = False
                TbName.Enabled = False
                tbdir.Enabled = False
                tbcel.Enabled = False
            End If
        ElseIf consumer = False Then
            namecliente = "Consumidor Final"
            nitcliente = "Ninguno"
            dircliente = "Ninguno"
            telefonocliente = "Ninguno"
            seriepedido = tbserie.Text
            TbNit.Enabled = False
            TbName.Enabled = False
            tbdir.Enabled = False
            tbcel.Enabled = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            consumer = False
            TbName.Text = ""
            TbNit.Text = ""
            tbdir.Text = ""
            tbcel.Text = ""
            TbNit.Enabled = False
            TbName.Enabled = False
            tbdir.Enabled = False
            tbcel.Enabled = False
        ElseIf CheckBox1.Checked = False Then
            consumer = True
            TbNit.Enabled = True
            TbName.Enabled = True
            tbdir.Enabled = True
            tbcel.Enabled = True
        End If
    End Sub

    Private Sub TbNit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNit.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) < 58 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 45 Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarProductos.Show()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        Dim long1, long3 As Integer
        Dim varn As String
        Dim suma As Double
        Dim intg As Integer = 0
        Dim resta As Integer
        long1 = Productos.Items.Count
        long3 = Subtotal.Items.Count
        resta = CInt(TbExistencias.Text) - NUDcant.Value
        If String.IsNullOrEmpty(namecliente) Or String.IsNullOrEmpty(nitcliente) Or String.IsNullOrEmpty(dircliente) Or String.IsNullOrEmpty(telefonocliente) Or String.IsNullOrEmpty(seriepedido) Then
            MessageBox.Show("No es posible ingresar productos sin haber confirmado al cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf String.IsNullOrEmpty(tbid.Text) Or String.IsNullOrEmpty(TbProd.Text) Or String.IsNullOrEmpty(TbVenta.Text) Or String.IsNullOrEmpty(TbCompra.Text) Or String.IsNullOrEmpty(TbExistencias.Text) Then
            MessageBox.Show("Debe ingresar un producto valido. Procure no dejar espacios en blanco y buscar su existencia en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf NUDcant.Value = 0 Then
            MessageBox.Show("Debe ingresar un número válido de productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf NUDcant.Value > CInt(TbExistencias.Text) Then

            MessageBox.Show("No hay suficiente existencia para el producto a ingresar. En total, se pueden vender solamente " + CStr(resta) + " productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            varn = Convert.ToString((CDbl(NUDcant.Value) * CDbl(TbVenta.Text)) * 1.12)
            Productos.Items.Add(TbProd.Text)
            Cantidad.Items.Add(NUDcant.Value)
            Subtotal.Items.Add(varn)
            For i = 0 To Subtotal.Items.Count - 1 Step 1
                suma += Subtotal.Items(cont)
            Next
            restavector.Items.Add(Convert.ToString(resta))
            TbTotal.Text = CStr(suma)
            vectorid.Items.Add(CInt(tbid.Text))
            cont += 1
            TbProd.Clear()
            TbVenta.Clear()
            tbid.Clear()
            tbcompra.Clear()
            tbexistencias.Clear()
            NUDcant.Value = 0
            BtAgregar.Focus()
        End If
    End Sub

    Private Sub BtProd_Click(sender As Object, e As EventArgs) Handles BtProd.Click
        If Cantidad.Items.Count = 0 Then
            MessageBox.Show("No hay productos a registrar en la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            insertarventa()
            insertardetalleventa()
            MessageBox.Show("La venta se registró exitosamente. Revise el listado de ventas para obtener la factura.", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cleartxt()
        End If
    End Sub

    Private Sub BtLimpiar_Click(sender As Object, e As EventArgs) Handles BtLimpiar.Click
        cleartxt()
    End Sub
End Class