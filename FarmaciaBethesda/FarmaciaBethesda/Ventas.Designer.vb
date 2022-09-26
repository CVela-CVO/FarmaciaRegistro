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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbID = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TbExistencias = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TbVenta = New System.Windows.Forms.TextBox()
        Me.TbCompra = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUDcant = New System.Windows.Forms.NumericUpDown()
        Me.TbProd = New System.Windows.Forms.TextBox()
        Me.BtAgregar = New System.Windows.Forms.Button()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.BtProd = New System.Windows.Forms.Button()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.BtLimpiar = New System.Windows.Forms.Button()
        Me.Subtotal = New System.Windows.Forms.ListBox()
        Me.Cantidad = New System.Windows.Forms.ListBox()
        Me.Productos = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btcambiar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TbSerie = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbcel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbdir = New System.Windows.Forms.TextBox()
        Me.BtRegClientes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbNit = New System.Windows.Forms.TextBox()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.vectorid = New System.Windows.Forms.ListBox()
        Me.restavector = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NUDcant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TbID)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.TbExistencias)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TbVenta)
        Me.GroupBox1.Controls.Add(Me.TbCompra)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NUDcant)
        Me.GroupBox1.Controls.Add(Me.TbProd)
        Me.GroupBox1.Controls.Add(Me.BtAgregar)
        Me.GroupBox1.Controls.Add(Me.TbTotal)
        Me.GroupBox1.Controls.Add(Me.BtProd)
        Me.GroupBox1.Controls.Add(Me.BtVolver)
        Me.GroupBox1.Controls.Add(Me.BtLimpiar)
        Me.GroupBox1.Controls.Add(Me.Subtotal)
        Me.GroupBox1.Controls.Add(Me.Cantidad)
        Me.GroupBox1.Controls.Add(Me.Productos)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1006, 437)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturación"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(79, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 22)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "ID: "
        '
        'TbID
        '
        Me.TbID.Location = New System.Drawing.Point(124, 17)
        Me.TbID.Name = "TbID"
        Me.TbID.ReadOnly = True
        Me.TbID.Size = New System.Drawing.Size(27, 23)
        Me.TbID.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Info
        Me.Label16.Location = New System.Drawing.Point(330, 127)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 22)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "SubTotal: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Info
        Me.Label15.Location = New System.Drawing.Point(174, 127)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 22)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Producto: "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Info
        Me.Label14.Location = New System.Drawing.Point(17, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 22)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Cantidad: "
        '
        'TbExistencias
        '
        Me.TbExistencias.Location = New System.Drawing.Point(815, 46)
        Me.TbExistencias.Name = "TbExistencias"
        Me.TbExistencias.ReadOnly = True
        Me.TbExistencias.Size = New System.Drawing.Size(142, 23)
        Me.TbExistencias.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Info
        Me.Label13.Location = New System.Drawing.Point(705, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Existencias: "
        '
        'TbVenta
        '
        Me.TbVenta.Location = New System.Drawing.Point(557, 73)
        Me.TbVenta.Name = "TbVenta"
        Me.TbVenta.ReadOnly = True
        Me.TbVenta.Size = New System.Drawing.Size(142, 23)
        Me.TbVenta.TabIndex = 50
        '
        'TbCompra
        '
        Me.TbCompra.Location = New System.Drawing.Point(557, 46)
        Me.TbCompra.Name = "TbCompra"
        Me.TbCompra.ReadOnly = True
        Me.TbCompra.Size = New System.Drawing.Size(142, 23)
        Me.TbCompra.TabIndex = 49
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Info
        Me.Label11.Location = New System.Drawing.Point(405, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(140, 22)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Precio Venta: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Info
        Me.Label12.Location = New System.Drawing.Point(405, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 22)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Precio Compra: "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Pink
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(272, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 23)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(511, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 22)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Total: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(9, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 22)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Cantidad: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Info
        Me.Label4.Location = New System.Drawing.Point(8, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Producto : "
        '
        'NUDcant
        '
        Me.NUDcant.Location = New System.Drawing.Point(124, 74)
        Me.NUDcant.Name = "NUDcant"
        Me.NUDcant.Size = New System.Drawing.Size(142, 23)
        Me.NUDcant.TabIndex = 37
        '
        'TbProd
        '
        Me.TbProd.Location = New System.Drawing.Point(124, 46)
        Me.TbProd.Name = "TbProd"
        Me.TbProd.ReadOnly = True
        Me.TbProd.Size = New System.Drawing.Size(142, 23)
        Me.TbProd.TabIndex = 36
        '
        'BtAgregar
        '
        Me.BtAgregar.BackColor = System.Drawing.Color.Pink
        Me.BtAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtAgregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAgregar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtAgregar.Location = New System.Drawing.Point(709, 75)
        Me.BtAgregar.Name = "BtAgregar"
        Me.BtAgregar.Size = New System.Drawing.Size(248, 39)
        Me.BtAgregar.TabIndex = 34
        Me.BtAgregar.Text = "Agregar producto"
        Me.BtAgregar.UseVisualStyleBackColor = False
        '
        'TbTotal
        '
        Me.TbTotal.Location = New System.Drawing.Point(578, 393)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.ReadOnly = True
        Me.TbTotal.Size = New System.Drawing.Size(100, 23)
        Me.TbTotal.TabIndex = 33
        '
        'BtProd
        '
        Me.BtProd.BackColor = System.Drawing.Color.Pink
        Me.BtProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtProd.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtProd.ForeColor = System.Drawing.SystemColors.Info
        Me.BtProd.Location = New System.Drawing.Point(684, 284)
        Me.BtProd.Name = "BtProd"
        Me.BtProd.Size = New System.Drawing.Size(302, 76)
        Me.BtProd.TabIndex = 32
        Me.BtProd.Text = "Registrar Venta"
        Me.BtProd.UseVisualStyleBackColor = False
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(684, 366)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(302, 50)
        Me.BtVolver.TabIndex = 31
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = False
        '
        'BtLimpiar
        '
        Me.BtLimpiar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtLimpiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtLimpiar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtLimpiar.Location = New System.Drawing.Point(684, 224)
        Me.BtLimpiar.Name = "BtLimpiar"
        Me.BtLimpiar.Size = New System.Drawing.Size(302, 50)
        Me.BtLimpiar.TabIndex = 30
        Me.BtLimpiar.Text = "Limpiar datos"
        Me.BtLimpiar.UseVisualStyleBackColor = False
        '
        'Subtotal
        '
        Me.Subtotal.FormattingEnabled = True
        Me.Subtotal.ItemHeight = 17
        Me.Subtotal.Location = New System.Drawing.Point(334, 157)
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.Size = New System.Drawing.Size(171, 259)
        Me.Subtotal.TabIndex = 2
        '
        'Cantidad
        '
        Me.Cantidad.FormattingEnabled = True
        Me.Cantidad.ItemHeight = 17
        Me.Cantidad.Location = New System.Drawing.Point(19, 157)
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Size = New System.Drawing.Size(153, 259)
        Me.Cantidad.TabIndex = 1
        '
        'Productos
        '
        Me.Productos.FormattingEnabled = True
        Me.Productos.ItemHeight = 17
        Me.Productos.Location = New System.Drawing.Point(178, 157)
        Me.Productos.Name = "Productos"
        Me.Productos.Size = New System.Drawing.Size(150, 259)
        Me.Productos.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btcambiar)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TbSerie)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.DTPFecha)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbcel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tbdir)
        Me.GroupBox2.Controls.Add(Me.BtRegClientes)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TbNit)
        Me.GroupBox2.Controls.Add(Me.TbName)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(799, 175)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'btcambiar
        '
        Me.btcambiar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.btcambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcambiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcambiar.ForeColor = System.Drawing.SystemColors.Info
        Me.btcambiar.Location = New System.Drawing.Point(396, 120)
        Me.btcambiar.Name = "btcambiar"
        Me.btcambiar.Size = New System.Drawing.Size(382, 34)
        Me.btcambiar.TabIndex = 52
        Me.btcambiar.Text = "Cambiar Cliente"
        Me.btcambiar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Info
        Me.Label10.Location = New System.Drawing.Point(392, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 22)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Serie del Pedido: "
        '
        'TbSerie
        '
        Me.TbSerie.Location = New System.Drawing.Point(578, 51)
        Me.TbSerie.Name = "TbSerie"
        Me.TbSerie.Size = New System.Drawing.Size(200, 23)
        Me.TbSerie.TabIndex = 50
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 138)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(139, 21)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "Consumidor Final"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DTPFecha
        '
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecha.Location = New System.Drawing.Point(578, 20)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(200, 23)
        Me.DTPFecha.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Info
        Me.Label9.Location = New System.Drawing.Point(392, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 22)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Fecha de Venta: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Info
        Me.Label8.Location = New System.Drawing.Point(6, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 22)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Teléfono: "
        '
        'tbcel
        '
        Me.tbcel.Location = New System.Drawing.Point(121, 109)
        Me.tbcel.MaxLength = 8
        Me.tbcel.Name = "tbcel"
        Me.tbcel.Size = New System.Drawing.Size(158, 23)
        Me.tbcel.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Dirección:  "
        '
        'tbdir
        '
        Me.tbdir.Location = New System.Drawing.Point(121, 80)
        Me.tbdir.Name = "tbdir"
        Me.tbdir.Size = New System.Drawing.Size(158, 23)
        Me.tbdir.TabIndex = 42
        '
        'BtRegClientes
        '
        Me.BtRegClientes.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtRegClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRegClientes.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtRegClientes.ForeColor = System.Drawing.SystemColors.Info
        Me.BtRegClientes.Location = New System.Drawing.Point(396, 80)
        Me.BtRegClientes.Name = "BtRegClientes"
        Me.BtRegClientes.Size = New System.Drawing.Size(382, 34)
        Me.BtRegClientes.TabIndex = 38
        Me.BtRegClientes.Text = "Confirmar Cliente"
        Me.BtRegClientes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 22)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "NIT: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(6, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Nombre: "
        '
        'TbNit
        '
        Me.TbNit.Location = New System.Drawing.Point(121, 51)
        Me.TbNit.MaxLength = 10
        Me.TbNit.Name = "TbNit"
        Me.TbNit.Size = New System.Drawing.Size(158, 23)
        Me.TbNit.TabIndex = 38
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(121, 19)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(261, 23)
        Me.TbName.TabIndex = 38
        '
        'vectorid
        '
        Me.vectorid.FormattingEnabled = True
        Me.vectorid.Location = New System.Drawing.Point(954, 30)
        Me.vectorid.Name = "vectorid"
        Me.vectorid.Size = New System.Drawing.Size(13, 17)
        Me.vectorid.TabIndex = 2
        Me.vectorid.Visible = False
        '
        'restavector
        '
        Me.restavector.FormattingEnabled = True
        Me.restavector.Location = New System.Drawing.Point(973, 30)
        Me.restavector.Name = "restavector"
        Me.restavector.Size = New System.Drawing.Size(13, 17)
        Me.restavector.TabIndex = 3
        Me.restavector.Visible = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(1032, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.restavector)
        Me.Controls.Add(Me.vectorid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NUDcant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Subtotal As ListBox
    Friend WithEvents Cantidad As ListBox
    Friend WithEvents Productos As ListBox
    Friend WithEvents NUDcant As NumericUpDown
    Friend WithEvents TbProd As TextBox
    Friend WithEvents BtAgregar As Button
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents BtProd As Button
    Friend WithEvents BtVolver As Button
    Friend WithEvents BtLimpiar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TbNit As TextBox
    Friend WithEvents TbName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtRegClientes As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TbExistencias As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TbVenta As TextBox
    Friend WithEvents TbCompra As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TbSerie As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents DTPFecha As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbcel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbdir As TextBox
    Friend WithEvents vectorid As ListBox
    Friend WithEvents restavector As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TbID As TextBox
    Friend WithEvents btcambiar As Button
End Class
