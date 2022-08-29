Public Class Medicamentos
    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()
        Dim direccionimagen As String
        direccionimagen = OpenFileDialog1.FileName
        PbMedicamento.Image = Image.FromFile(direccionimagen, True)
        MessageBox.Show(direccionimagen)
    End Sub

    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub
End Class