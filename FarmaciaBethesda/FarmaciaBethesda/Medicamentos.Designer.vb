<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicamentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Medicamentos))
        Me.DTGmedicamentos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.NUDexistencias = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NUDprecio = New System.Windows.Forms.NumericUpDown()
        Me.NUDcosto = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtExaminar = New System.Windows.Forms.Button()
        Me.PbMedicamento = New System.Windows.Forms.PictureBox()
        Me.TbObservacion = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Btbuscar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbbuscar = New System.Windows.Forms.ComboBox()
        Me.tbbuscar = New System.Windows.Forms.TextBox()
        CType(Me.DTGmedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDexistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDprecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDcosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbMedicamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DTGmedicamentos
        '
        Me.DTGmedicamentos.AllowUserToAddRows = False
        Me.DTGmedicamentos.AllowUserToDeleteRows = False
        Me.DTGmedicamentos.BackgroundColor = System.Drawing.Color.Pink
        Me.DTGmedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGmedicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGmedicamentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DTGmedicamentos.ColumnHeadersHeight = 30
        Me.DTGmedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTGmedicamentos.EnableHeadersVisualStyles = False
        Me.DTGmedicamentos.GridColor = System.Drawing.Color.PaleVioletRed
        Me.DTGmedicamentos.Location = New System.Drawing.Point(12, 109)
        Me.DTGmedicamentos.Name = "DTGmedicamentos"
        Me.DTGmedicamentos.ReadOnly = True
        Me.DTGmedicamentos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGmedicamentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.DTGmedicamentos.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DTGmedicamentos.Size = New System.Drawing.Size(517, 345)
        Me.DTGmedicamentos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lista de medicamentos"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.BtVolver)
        Me.GroupBox1.Controls.Add(Me.NUDexistencias)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.NUDprecio)
        Me.GroupBox1.Controls.Add(Me.NUDcosto)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtGuardar)
        Me.GroupBox1.Controls.Add(Me.BtExaminar)
        Me.GroupBox1.Controls.Add(Me.PbMedicamento)
        Me.GroupBox1.Controls.Add(Me.TbObservacion)
        Me.GroupBox1.Controls.Add(Me.TbNombre)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(550, -15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 535)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(199, 342)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 29
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(199, 264)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(5, 465)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(81, 34)
        Me.BtVolver.TabIndex = 27
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = False
        '
        'NUDexistencias
        '
        Me.NUDexistencias.Location = New System.Drawing.Point(199, 421)
        Me.NUDexistencias.Name = "NUDexistencias"
        Me.NUDexistencias.Size = New System.Drawing.Size(168, 20)
        Me.NUDexistencias.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Pink
        Me.Label11.Location = New System.Drawing.Point(1, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 22)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Existencias:"
        '
        'NUDprecio
        '
        Me.NUDprecio.DecimalPlaces = 2
        Me.NUDprecio.Location = New System.Drawing.Point(199, 395)
        Me.NUDprecio.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.NUDprecio.Name = "NUDprecio"
        Me.NUDprecio.Size = New System.Drawing.Size(168, 20)
        Me.NUDprecio.TabIndex = 24
        Me.NUDprecio.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'NUDcosto
        '
        Me.NUDcosto.DecimalPlaces = 2
        Me.NUDcosto.Location = New System.Drawing.Point(199, 369)
        Me.NUDcosto.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.NUDcosto.Name = "NUDcosto"
        Me.NUDcosto.Size = New System.Drawing.Size(168, 20)
        Me.NUDcosto.TabIndex = 23
        Me.NUDcosto.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(199, 290)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 20)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Pink
        Me.Label10.Location = New System.Drawing.Point(1, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Fotografía:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Location = New System.Drawing.Point(1, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(288, 22)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Información del medicamento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Pink
        Me.Label8.Location = New System.Drawing.Point(1, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Costo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Pink
        Me.Label7.Location = New System.Drawing.Point(1, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Caducidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(1, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Distribuidora:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Pink
        Me.Label5.Location = New System.Drawing.Point(1, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Observación:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Pink
        Me.Label4.Location = New System.Drawing.Point(1, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Pink
        Me.Label1.Location = New System.Drawing.Point(1, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Pink
        Me.Label2.Location = New System.Drawing.Point(1, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre:"
        '
        'BtGuardar
        '
        Me.BtGuardar.BackColor = System.Drawing.Color.LightPink
        Me.BtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtGuardar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtGuardar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtGuardar.Location = New System.Drawing.Point(199, 457)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(168, 36)
        Me.BtGuardar.TabIndex = 11
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = False
        '
        'BtExaminar
        '
        Me.BtExaminar.Location = New System.Drawing.Point(105, 191)
        Me.BtExaminar.Name = "BtExaminar"
        Me.BtExaminar.Size = New System.Drawing.Size(75, 23)
        Me.BtExaminar.TabIndex = 10
        Me.BtExaminar.Text = "Examinar"
        Me.BtExaminar.UseVisualStyleBackColor = True
        '
        'PbMedicamento
        '
        Me.PbMedicamento.BackColor = System.Drawing.Color.Pink
        Me.PbMedicamento.Location = New System.Drawing.Point(199, 92)
        Me.PbMedicamento.Name = "PbMedicamento"
        Me.PbMedicamento.Size = New System.Drawing.Size(147, 106)
        Me.PbMedicamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbMedicamento.TabIndex = 9
        Me.PbMedicamento.TabStop = False
        '
        'TbObservacion
        '
        Me.TbObservacion.Location = New System.Drawing.Point(199, 316)
        Me.TbObservacion.Name = "TbObservacion"
        Me.TbObservacion.Size = New System.Drawing.Size(168, 20)
        Me.TbObservacion.TabIndex = 3
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(199, 238)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(168, 20)
        Me.TbNombre.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(188, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(171, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BtEditar
        '
        Me.BtEditar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEditar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEditar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEditar.Location = New System.Drawing.Point(12, 468)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(105, 34)
        Me.BtEditar.TabIndex = 27
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = False
        '
        'BtNuevo
        '
        Me.BtNuevo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNuevo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.BtNuevo.Location = New System.Drawing.Point(128, 468)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(105, 34)
        Me.BtNuevo.TabIndex = 28
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = False
        '
        'BtEliminar
        '
        Me.BtEliminar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEliminar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEliminar.Location = New System.Drawing.Point(250, 468)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(105, 34)
        Me.BtEliminar.TabIndex = 29
        Me.BtEliminar.Text = "Eliminar"
        Me.BtEliminar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(325, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 50)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(8, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Buscar por:"
        '
        'Btbuscar
        '
        Me.Btbuscar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btbuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btbuscar.ForeColor = System.Drawing.SystemColors.Info
        Me.Btbuscar.Location = New System.Drawing.Point(232, 51)
        Me.Btbuscar.Name = "Btbuscar"
        Me.Btbuscar.Size = New System.Drawing.Size(87, 50)
        Me.Btbuscar.TabIndex = 57
        Me.Btbuscar.Text = "Buscar"
        Me.Btbuscar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(8, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 20)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Buscar:"
        '
        'cbbuscar
        '
        Me.cbbuscar.FormattingEnabled = True
        Me.cbbuscar.Items.AddRange(New Object() {"Nombre", "Marca", "Distribuidora"})
        Me.cbbuscar.Location = New System.Drawing.Point(105, 80)
        Me.cbbuscar.Name = "cbbuscar"
        Me.cbbuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbbuscar.TabIndex = 55
        '
        'tbbuscar
        '
        Me.tbbuscar.Location = New System.Drawing.Point(105, 51)
        Me.tbbuscar.Name = "tbbuscar"
        Me.tbbuscar.Size = New System.Drawing.Size(121, 20)
        Me.tbbuscar.TabIndex = 54
        '
        'Medicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(921, 514)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Btbuscar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbbuscar)
        Me.Controls.Add(Me.tbbuscar)
        Me.Controls.Add(Me.BtEliminar)
        Me.Controls.Add(Me.BtNuevo)
        Me.Controls.Add(Me.BtEditar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTGmedicamentos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Medicamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicamentos"
        CType(Me.DTGmedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDexistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDprecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDcosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbMedicamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTGmedicamentos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NUDexistencias As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents NUDprecio As NumericUpDown
    Friend WithEvents NUDcosto As NumericUpDown
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtExaminar As Button
    Friend WithEvents PbMedicamento As PictureBox
    Friend WithEvents TbObservacion As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtNuevo As Button
    Friend WithEvents BtEliminar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtVolver As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Btbuscar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents cbbuscar As ComboBox
    Friend WithEvents tbbuscar As TextBox
End Class
