Public Class Empleados
    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()
        Dim direccionimagen As String
        direccionimagen = OpenFileDialog1.FileName
        PbEmpleado.Image = Image.FromFile(direccionimagen, True)
        MessageBox.Show(direccionimagen)
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class