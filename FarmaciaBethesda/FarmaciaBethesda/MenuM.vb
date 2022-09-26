Public Class MenuM
    Dim usertoken = Login.tokenusertype

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Close()
        Login.Show()
        Login.tokenusertype = ""
        Login.iduser = ""
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

    Private Sub TbMarcas_Click(sender As Object, e As EventArgs) Handles BtMarcas.Click
        Me.Hide()
        Marcas.Show()
    End Sub

    Private Sub TbDistrib_Click(sender As Object, e As EventArgs) Handles BtDistrib.Click
        Me.Hide()
        Distribuidoras.Show()
    End Sub

    Private Sub BtVender_Click(sender As Object, e As EventArgs) Handles BtVender.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub MenuM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usertoken = "Vendedor" Then
            BtInventario.Enabled = False
            BtUsuarios.Enabled = False
            BtDistrib.Enabled = False
            BtMarcas.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        VistaVentas.Show()
    End Sub
End Class