<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namecliente = New System.Windows.Forms.Label()
        Me.nitcliente = New System.Windows.Forms.Label()
        Me.telcliente = New System.Windows.Forms.Label()
        Me.dircliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbtotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datepedido = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.seriepedido = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idfactura = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lavelvendedor = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightPink
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(434, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(140, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Farmacia ""Bethesda"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(21, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Facturar a Cliente: "
        '
        'namecliente
        '
        Me.namecliente.AutoSize = True
        Me.namecliente.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namecliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.namecliente.Location = New System.Drawing.Point(138, 60)
        Me.namecliente.Name = "namecliente"
        Me.namecliente.Size = New System.Drawing.Size(76, 28)
        Me.namecliente.TabIndex = 3
        Me.namecliente.Text = "Label1"
        '
        'nitcliente
        '
        Me.nitcliente.AutoSize = True
        Me.nitcliente.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nitcliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nitcliente.Location = New System.Drawing.Point(138, 88)
        Me.nitcliente.Name = "nitcliente"
        Me.nitcliente.Size = New System.Drawing.Size(76, 28)
        Me.nitcliente.TabIndex = 4
        Me.nitcliente.Text = "Label2"
        '
        'telcliente
        '
        Me.telcliente.AutoSize = True
        Me.telcliente.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telcliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.telcliente.Location = New System.Drawing.Point(138, 144)
        Me.telcliente.Name = "telcliente"
        Me.telcliente.Size = New System.Drawing.Size(76, 28)
        Me.telcliente.TabIndex = 5
        Me.telcliente.Text = "Label3"
        '
        'dircliente
        '
        Me.dircliente.AutoSize = True
        Me.dircliente.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dircliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dircliente.Location = New System.Drawing.Point(138, 116)
        Me.dircliente.Name = "dircliente"
        Me.dircliente.Size = New System.Drawing.Size(76, 28)
        Me.dircliente.TabIndex = 6
        Me.dircliente.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(21, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(21, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 28)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "NIT: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(23, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Dirección: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(23, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Teléfono: "
        '
        'tbtotal
        '
        Me.tbtotal.Location = New System.Drawing.Point(527, 794)
        Me.tbtotal.Name = "tbtotal"
        Me.tbtotal.ReadOnly = True
        Me.tbtotal.Size = New System.Drawing.Size(100, 20)
        Me.tbtotal.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(416, 790)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 28)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(15, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 28)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Fecha: "
        '
        'datepedido
        '
        Me.datepedido.AutoSize = True
        Me.datepedido.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datepedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.datepedido.Location = New System.Drawing.Point(132, 26)
        Me.datepedido.Name = "datepedido"
        Me.datepedido.Size = New System.Drawing.Size(76, 28)
        Me.datepedido.TabIndex = 14
        Me.datepedido.Text = "Label5"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(15, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 28)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Serie: "
        '
        'seriepedido
        '
        Me.seriepedido.AutoSize = True
        Me.seriepedido.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seriepedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.seriepedido.Location = New System.Drawing.Point(132, 54)
        Me.seriepedido.Name = "seriepedido"
        Me.seriepedido.Size = New System.Drawing.Size(76, 28)
        Me.seriepedido.TabIndex = 16
        Me.seriepedido.Text = "Label6"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(23, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 28)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Documento No.  "
        '
        'idfactura
        '
        Me.idfactura.AutoSize = True
        Me.idfactura.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idfactura.ForeColor = System.Drawing.Color.Red
        Me.idfactura.Location = New System.Drawing.Point(204, 137)
        Me.idfactura.Name = "idfactura"
        Me.idfactura.Size = New System.Drawing.Size(76, 28)
        Me.idfactura.TabIndex = 18
        Me.idfactura.Text = "Label7"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(15, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 28)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Vendedor: "
        '
        'lavelvendedor
        '
        Me.lavelvendedor.AutoSize = True
        Me.lavelvendedor.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lavelvendedor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lavelvendedor.Location = New System.Drawing.Point(132, 82)
        Me.lavelvendedor.Name = "lavelvendedor"
        Me.lavelvendedor.Size = New System.Drawing.Size(76, 28)
        Me.lavelvendedor.TabIndex = 20
        Me.lavelvendedor.Text = "Label8"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.namecliente)
        Me.GroupBox2.Controls.Add(Me.nitcliente)
        Me.GroupBox2.Controls.Add(Me.telcliente)
        Me.GroupBox2.Controls.Add(Me.dircliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 181)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.datepedido)
        Me.GroupBox3.Controls.Add(Me.seriepedido)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lavelvendedor)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(605, 150)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(13, 512)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightPink
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(614, 275)
        Me.DataGridView1.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(18, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(293, 22)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Como anexo de: Clínica Gabriela Arguello"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(18, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 22)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "1681 - 1655"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(18, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(392, 22)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Calle El Transito 7 Avenida Nuevo Progreso, San Marcos"
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(651, 825)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.idfactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents namecliente As Label
    Friend WithEvents nitcliente As Label
    Friend WithEvents telcliente As Label
    Friend WithEvents dircliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbtotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents datepedido As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents seriepedido As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents idfactura As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lavelvendedor As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
