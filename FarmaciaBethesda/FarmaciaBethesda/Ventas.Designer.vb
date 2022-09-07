<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtRegistr = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbSubtot = New System.Windows.Forms.ListBox()
        Me.LbCant = New System.Windows.Forms.ListBox()
        Me.LbProd = New System.Windows.Forms.ListBox()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.BtAceptar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtFactura = New System.Windows.Forms.Button()
        Me.BtEli = New System.Windows.Forms.Button()
        Me.Btbuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPfin = New System.Windows.Forms.DateTimePicker()
        Me.DTPinicio = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtDelete = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TbProducto = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(618, 695)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.BtVolver)
        Me.TabPage1.Controls.Add(Me.BtAgregar)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.DateTimePicker1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(610, 669)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Mantenimiento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox2.Controls.Add(Me.TbProducto)
        Me.GroupBox2.Controls.Add(Me.BtRegistr)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LbSubtot)
        Me.GroupBox2.Controls.Add(Me.LbCant)
        Me.GroupBox2.Controls.Add(Me.LbProd)
        Me.GroupBox2.Location = New System.Drawing.Point(-16, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(662, 333)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'BtRegistr
        '
        Me.BtRegistr.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRegistr.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRegistr.ForeColor = System.Drawing.SystemColors.Info
        Me.BtRegistr.Location = New System.Drawing.Point(32, 191)
        Me.BtRegistr.Name = "BtRegistr"
        Me.BtRegistr.Size = New System.Drawing.Size(216, 34)
        Me.BtRegistr.TabIndex = 52
        Me.BtRegistr.Text = "Registrar productos"
        Me.BtRegistr.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(32, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 31)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Buscar Producto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Pink
        Me.Label7.Location = New System.Drawing.Point(266, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 22)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Producto:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(32, 165)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 20)
        Me.TextBox4.TabIndex = 3
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(391, 205)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(171, 20)
        Me.NumericUpDown1.TabIndex = 53
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(266, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 22)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Monto:"
        '
        'LbSubtot
        '
        Me.LbSubtot.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSubtot.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.LbSubtot.FormattingEnabled = True
        Me.LbSubtot.ItemHeight = 17
        Me.LbSubtot.Location = New System.Drawing.Point(418, 19)
        Me.LbSubtot.Name = "LbSubtot"
        Me.LbSubtot.Size = New System.Drawing.Size(187, 140)
        Me.LbSubtot.TabIndex = 2
        '
        'LbCant
        '
        Me.LbCant.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCant.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.LbCant.FormattingEnabled = True
        Me.LbCant.ItemHeight = 17
        Me.LbCant.Location = New System.Drawing.Point(225, 19)
        Me.LbCant.Name = "LbCant"
        Me.LbCant.Size = New System.Drawing.Size(187, 140)
        Me.LbCant.TabIndex = 1
        '
        'LbProd
        '
        Me.LbProd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbProd.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.LbProd.FormattingEnabled = True
        Me.LbProd.ItemHeight = 17
        Me.LbProd.Location = New System.Drawing.Point(32, 19)
        Me.LbProd.Name = "LbProd"
        Me.LbProd.Size = New System.Drawing.Size(187, 140)
        Me.LbProd.TabIndex = 0
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(127, 337)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(105, 34)
        Me.BtVolver.TabIndex = 50
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = False
        '
        'BtAgregar
        '
        Me.BtAgregar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAgregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAgregar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtAgregar.Location = New System.Drawing.Point(16, 337)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(105, 34)
        Me.BtAgregar.TabIndex = 35
        Me.BtAgregar.Text = "Agregar"
        Me.BtAgregar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label10.Location = New System.Drawing.Point(12, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(161, 22)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Serie del pedido:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label9.Location = New System.Drawing.Point(16, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 22)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Usuario:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(141, 147)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(171, 21)
        Me.ComboBox2.TabIndex = 47
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(141, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 20)
        Me.DateTimePicker1.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label8.Location = New System.Drawing.Point(16, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 22)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Fecha:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 22)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Numero:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(179, 194)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(171, 20)
        Me.TextBox8.TabIndex = 39
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(141, 92)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(171, 20)
        Me.TextBox3.TabIndex = 38
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(141, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(171, 20)
        Me.TextBox2.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label4.Location = New System.Drawing.Point(16, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 22)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Nit:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Cliente:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(141, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(171, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(-8, -1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Pedido"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.BtEliminar)
        Me.GroupBox1.Controls.Add(Me.BtAceptar)
        Me.GroupBox1.Location = New System.Drawing.Point(430, -23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 442)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtEliminar
        '
        Me.BtEliminar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEliminar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEliminar.Location = New System.Drawing.Point(11, 320)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(105, 34)
        Me.BtEliminar.TabIndex = 53
        Me.BtEliminar.Text = "Eliminar"
        Me.BtEliminar.UseVisualStyleBackColor = False
        '
        'BtAceptar
        '
        Me.BtAceptar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAceptar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAceptar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtAceptar.Location = New System.Drawing.Point(11, 360)
        Me.BtAceptar.Name = "BtAceptar"
        Me.BtAceptar.Size = New System.Drawing.Size(105, 34)
        Me.BtAceptar.TabIndex = 31
        Me.BtAceptar.Text = "Aceptar"
        Me.BtAceptar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightPink
        Me.TabPage2.Controls.Add(Me.BtFactura)
        Me.TabPage2.Controls.Add(Me.BtEli)
        Me.TabPage2.Controls.Add(Me.Btbuscar)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DTPfin)
        Me.TabPage2.Controls.Add(Me.DTPinicio)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(610, 669)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Listado"
        '
        'BtFactura
        '
        Me.BtFactura.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtFactura.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtFactura.ForeColor = System.Drawing.SystemColors.Info
        Me.BtFactura.Location = New System.Drawing.Point(157, 270)
        Me.BtFactura.Name = "BtFactura"
        Me.BtFactura.Size = New System.Drawing.Size(105, 34)
        Me.BtFactura.TabIndex = 34
        Me.BtFactura.Text = "Factura"
        Me.BtFactura.UseVisualStyleBackColor = False
        '
        'BtEli
        '
        Me.BtEli.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEli.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEli.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEli.Location = New System.Drawing.Point(34, 270)
        Me.BtEli.Name = "BtEli"
        Me.BtEli.Size = New System.Drawing.Size(105, 34)
        Me.BtEli.TabIndex = 33
        Me.BtEli.Text = "Eliminar"
        Me.BtEli.UseVisualStyleBackColor = False
        '
        'Btbuscar
        '
        Me.Btbuscar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btbuscar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btbuscar.ForeColor = System.Drawing.SystemColors.Info
        Me.Btbuscar.Location = New System.Drawing.Point(390, 22)
        Me.Btbuscar.Name = "Btbuscar"
        Me.Btbuscar.Size = New System.Drawing.Size(105, 34)
        Me.Btbuscar.TabIndex = 32
        Me.Btbuscar.Text = "Buscar"
        Me.Btbuscar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Info
        Me.Label11.Location = New System.Drawing.Point(30, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 22)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Fecha fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(30, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fecha inicio"
        '
        'DTPfin
        '
        Me.DTPfin.Location = New System.Drawing.Point(184, 50)
        Me.DTPfin.Name = "DTPfin"
        Me.DTPfin.Size = New System.Drawing.Size(200, 20)
        Me.DTPfin.TabIndex = 2
        '
        'DTPinicio
        '
        Me.DTPinicio.Location = New System.Drawing.Point(184, 22)
        Me.DTPinicio.Name = "DTPinicio"
        Me.DTPinicio.Size = New System.Drawing.Size(200, 20)
        Me.DTPinicio.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(529, 167)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.LightPink
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TextBox9)
        Me.TabPage3.Controls.Add(Me.TextBox7)
        Me.TabPage3.Controls.Add(Me.TextBox6)
        Me.TabPage3.Controls.Add(Me.TextBox5)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.BtDelete)
        Me.TabPage3.Controls.Add(Me.BtNuevo)
        Me.TabPage3.Controls.Add(Me.BtEditar)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(610, 669)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Clientes"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label16.Location = New System.Drawing.Point(6, 383)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 22)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Dirección:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label15.Location = New System.Drawing.Point(6, 357)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(199, 22)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Numero de telefono:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label14.Location = New System.Drawing.Point(6, 331)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 22)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "NIT:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label13.Location = New System.Drawing.Point(6, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 22)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Nombre:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(206, 387)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(216, 20)
        Me.TextBox9.TabIndex = 36
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(206, 361)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(216, 20)
        Me.TextBox7.TabIndex = 35
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(206, 335)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(216, 20)
        Me.TextBox6.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(206, 309)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 20)
        Me.TextBox5.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Info
        Me.Label12.Location = New System.Drawing.Point(29, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 22)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Lista de clientes"
        '
        'BtDelete
        '
        Me.BtDelete.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDelete.ForeColor = System.Drawing.SystemColors.Info
        Me.BtDelete.Location = New System.Drawing.Point(255, 249)
        Me.BtDelete.Name = "BtDelete"
        Me.BtDelete.Size = New System.Drawing.Size(105, 34)
        Me.BtDelete.TabIndex = 31
        Me.BtDelete.Text = "Eliminar"
        Me.BtDelete.UseVisualStyleBackColor = False
        '
        'BtNuevo
        '
        Me.BtNuevo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNuevo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.BtNuevo.Location = New System.Drawing.Point(144, 249)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(105, 34)
        Me.BtNuevo.TabIndex = 30
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = False
        '
        'BtEditar
        '
        Me.BtEditar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEditar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEditar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEditar.Location = New System.Drawing.Point(33, 249)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(105, 34)
        Me.BtEditar.TabIndex = 29
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(33, 56)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(549, 187)
        Me.DataGridView2.TabIndex = 0
        '
        'TbProducto
        '
        Me.TbProducto.Location = New System.Drawing.Point(391, 176)
        Me.TbProducto.Name = "TbProducto"
        Me.TbProducto.Size = New System.Drawing.Size(171, 20)
        Me.TbProducto.TabIndex = 55
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(651, 711)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtVolver As Button
    Friend WithEvents BtAgregar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtRegistr As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents LbSubtot As ListBox
    Friend WithEvents LbCant As ListBox
    Friend WithEvents LbProd As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtEliminar As Button
    Friend WithEvents BtAceptar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DTPfin As DateTimePicker
    Friend WithEvents DTPinicio As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtFactura As Button
    Friend WithEvents BtEli As Button
    Friend WithEvents Btbuscar As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtNuevo As Button
    Friend WithEvents BtDelete As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TbProducto As TextBox
End Class
