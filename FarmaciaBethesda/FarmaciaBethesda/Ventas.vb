Public Class Ventas
    Public Sub setArticulo(ByVal idarticulo As String, ByVal nombre As String)

        Me.TbProducto.Text = nombre
    End Sub
    Private Sub BtVolver_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtCliente_Click(sender As Object, e As EventArgs)

        BuscarCliente.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarProductos.Show()

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class