Public Class MenuM
    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        End
    End Sub

    Private Sub BtUsuarios_Click(sender As Object, e As EventArgs) Handles BtUsuarios.Click
        Me.Hide()
        Empleados.Show()

    End Sub

    Private Sub BtInventario_Click(sender As Object, e As EventArgs) Handles BtInventario.Click
        Me.Hide()
        Medicamentos.Show()

    End Sub

    Private Sub TbMarcas_Click(sender As Object, e As EventArgs) Handles TbMarcas.Click
        Me.Hide()
        Marcas.Show()

    End Sub

    Private Sub TbDistrib_Click(sender As Object, e As EventArgs) Handles TbDistrib.Click
        Me.Hide()
        Distribuidoras.Show()

    End Sub

    Private Sub BtVender_Click(sender As Object, e As EventArgs) Handles BtVender.Click
        Me.Hide()
        Ventas.Show()

    End Sub
End Class