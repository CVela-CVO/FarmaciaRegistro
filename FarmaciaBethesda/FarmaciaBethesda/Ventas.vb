Public Class Ventas
    Private Sub BtVolver_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtCliente_Click(sender As Object, e As EventArgs) Handles BtCliente.Click

        BuscarCliente.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarProductos.Show()

    End Sub
End Class