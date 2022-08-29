Public Class Distribuidoras
    Private Sub BtVolver_Click(sender As Object, e As EventArgs) Handles BtVolver.Click
        Me.Hide()
        MenuM.Show()

    End Sub

    Private Sub PbMarca_Click(sender As Object, e As EventArgs) Handles PbDistribuidoras.Click

    End Sub

    Private Sub BtExaminar_Click(sender As Object, e As EventArgs) Handles BtExaminar.Click
        OpenFileDialog1.ShowDialog()
        Dim direccionimagen As String
        direccionimagen = OpenFileDialog1.FileName
        PbDistribuidoras.Image = Image.FromFile(direccionimagen, True)
        MessageBox.Show(direccionimagen)
    End Sub
End Class