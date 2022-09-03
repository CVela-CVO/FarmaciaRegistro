Imports MySql.Data.MySqlClient
Public Class Marcas
    Dim index As Integer
    Dim idpaisescombobox As String
    Dim stringindex As String
    Dim direccionimagen As String
    Sub cleartxt()
        TbNombre.Clear()
        direccionimagen = ""
        stringindex = ""
    End Sub
    Sub guardardatos()

        indexpaises()
        If String.IsNullOrEmpty(TbNombre.Text) Or String.IsNullOrEmpty(direccionimagen) Then
            MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "INSERT INTO marca (name_marca, id_paises, ico_marca) VALUES ('" & TbNombre.Text & "'," & idpaisescombobox & ",'" & direccionimagen & "');"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            conn.Close()
            ReadQuery()
            cleartxt()
        End If

    End Sub
    Sub indexpaises()

        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
            Dim sQuery = "SELECT id_pais FROM paises WHERE nombre = '" & CbPais.Text & "'"
            da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            idpaisescombobox = dt.Rows(0)("id_pais").ToString
            conn.Close()

    End Sub
    Sub cbpaisdata()

        Dim comando As MySqlCommand = New MySqlCommand()
            Dim tabla As DataTable = New DataTable()
            Dim conexion As MySqlConnection = New MySqlConnection()
            conexion.ConnectionString = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            conexion.Open()
            comando.Connection = conexion
            comando.CommandType = CommandType.Text
        comando.CommandText = "SELECT nombre FROM paises"
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            CbPais.DataSource = tabla
        CbPais.DisplayMember = "paises"
        CbPais.ValueMember = "nombre"
        conexion.Close()

    End Sub
    Sub ReadQuery()

        Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
            Dim conn As New MySqlConnection(cadenaConexion)
            Dim da As MySqlDataAdapter
            Dim dt As DataTable
            conn.Open()
        Dim sQuery = "SELECT m.id_marca as 'ID', m.name_marca as 'Nombre', ma.nombre as 'Pais', m.ico_marca as 'icono' FROM marca m INNER JOIN paises ma ON m.id_paises = ma.id_pais"
        da = New MySqlDataAdapter(sQuery, conn)
            dt = New DataTable
            da.Fill(dt)
            DTGmarcas.DataSource = dt
            conn.Close()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPais.SelectedIndexChanged

    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()
        direccionimagen = OpenFileDialog1.FileName
        PbMarca.Image = Image.FromFile(direccionimagen, True)

    End Sub

    Private Sub Marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadQuery()
        cbpaisdata()
    End Sub

    Private Sub DTGmarcas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmarcas.CellContentClick


    End Sub

    Private Sub BtEditar_Click(sender As Object, e As EventArgs) Handles BtEditar.Click
        Try
            indexpaises()
            If String.IsNullOrEmpty(TbNombre.Text) Then
                MessageBox.Show("No ingresó los datos completos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim cadenaConexion = "server=localhost;database=registrofarmacia;userid=root;password=;port=3306"
                Dim conn As New MySqlConnection(cadenaConexion)
                Dim da As MySqlDataAdapter
                Dim dt As DataTable
                conn.Open()
                Dim sQuery = "UPDATE marca SET name_marca='" & TbNombre.Text & "',id_paises=" & idpaisescombobox & ",`ico_marca`='" & direccionimagen & "' WHERE 1"
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
        Try
            guardardatos()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                Dim sQuery = "DELETE FROM marca WHERE id_marca =" & stringindex
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

    Private Sub BtGuardar_Click(sender As Object, e As EventArgs) Handles BtGuardar.Click
        Try
            guardardatos()
        Catch ex As Exception
            MessageBox.Show("Hubo un error de conexión con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DTGmarcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGmarcas.CellClick
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DTGmarcas.Rows(index)
        stringindex = selectedrow.Cells(0).Value.ToString
        TbNombre.Text = selectedrow.Cells(1).Value.ToString
        CbPais.SelectedItem = selectedrow.Cells(2).Value.ToString
        direccionimagen = selectedrow.Cells(3).Value.ToString
    End Sub
End Class