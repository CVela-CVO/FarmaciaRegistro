<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RdVendedor = New System.Windows.Forms.RadioButton()
        Me.RdAdmin = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtGuardar = New System.Windows.Forms.Button()
        Me.BtExaminar = New System.Windows.Forms.Button()
        Me.PbEmpleado = New System.Windows.Forms.PictureBox()
        Me.TbEmail = New System.Windows.Forms.TextBox()
        Me.TbCui = New System.Windows.Forms.TextBox()
        Me.TbNombre = New System.Windows.Forms.TextBox()
        Me.TbPuesto = New System.Windows.Forms.TextBox()
        Me.TbPassword = New System.Windows.Forms.TextBox()
        Me.TbUserName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DTGempleados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.BtVolver)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.RdVendedor)
        Me.GroupBox1.Controls.Add(Me.RdAdmin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.BtGuardar)
        Me.GroupBox1.Controls.Add(Me.BtExaminar)
        Me.GroupBox1.Controls.Add(Me.PbEmpleado)
        Me.GroupBox1.Controls.Add(Me.TbEmail)
        Me.GroupBox1.Controls.Add(Me.TbCui)
        Me.GroupBox1.Controls.Add(Me.TbNombre)
        Me.GroupBox1.Controls.Add(Me.TbPuesto)
        Me.GroupBox1.Controls.Add(Me.TbPassword)
        Me.GroupBox1.Controls.Add(Me.TbUserName)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(548, -16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 492)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(6, 433)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(81, 36)
        Me.BtVolver.TabIndex = 11
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Pink
        Me.Label10.Location = New System.Drawing.Point(2, 56)
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
        Me.Label9.Location = New System.Drawing.Point(8, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(253, 22)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Información del empleado"
        '
        'RdVendedor
        '
        Me.RdVendedor.AutoSize = True
        Me.RdVendedor.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdVendedor.ForeColor = System.Drawing.Color.Pink
        Me.RdVendedor.Location = New System.Drawing.Point(200, 406)
        Me.RdVendedor.Name = "RdVendedor"
        Me.RdVendedor.Size = New System.Drawing.Size(90, 21)
        Me.RdVendedor.TabIndex = 19
        Me.RdVendedor.TabStop = True
        Me.RdVendedor.Text = "Vendedor"
        Me.RdVendedor.UseVisualStyleBackColor = True
        '
        'RdAdmin
        '
        Me.RdAdmin.AutoSize = True
        Me.RdAdmin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdAdmin.ForeColor = System.Drawing.Color.Pink
        Me.RdAdmin.Location = New System.Drawing.Point(200, 379)
        Me.RdAdmin.Name = "RdAdmin"
        Me.RdAdmin.Size = New System.Drawing.Size(116, 21)
        Me.RdAdmin.TabIndex = 18
        Me.RdAdmin.TabStop = True
        Me.RdAdmin.Text = "Administrador"
        Me.RdAdmin.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Pink
        Me.Label8.Location = New System.Drawing.Point(2, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Email del usuario:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Pink
        Me.Label7.Location = New System.Drawing.Point(2, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Puesto del usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(2, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CUI del usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Pink
        Me.Label5.Location = New System.Drawing.Point(2, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nombre del usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Pink
        Me.Label4.Location = New System.Drawing.Point(2, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tipo de usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Pink
        Me.Label1.Location = New System.Drawing.Point(2, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Pink
        Me.Label2.Location = New System.Drawing.Point(2, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "UserName:"
        '
        'BtGuardar
        '
        Me.BtGuardar.BackColor = System.Drawing.Color.LightPink
        Me.BtGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtGuardar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtGuardar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtGuardar.Location = New System.Drawing.Point(200, 433)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(168, 36)
        Me.BtGuardar.TabIndex = 11
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = False
        '
        'BtExaminar
        '
        Me.BtExaminar.Location = New System.Drawing.Point(170, 167)
        Me.BtExaminar.Name = "BtExaminar"
        Me.BtExaminar.Size = New System.Drawing.Size(75, 23)
        Me.BtExaminar.TabIndex = 10
        Me.BtExaminar.Text = "Examinar"
        Me.BtExaminar.UseVisualStyleBackColor = True
        '
        'PbEmpleado
        '
        Me.PbEmpleado.BackColor = System.Drawing.Color.Pink
        Me.PbEmpleado.Location = New System.Drawing.Point(267, 70)
        Me.PbEmpleado.Name = "PbEmpleado"
        Me.PbEmpleado.Size = New System.Drawing.Size(77, 106)
        Me.PbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEmpleado.TabIndex = 9
        Me.PbEmpleado.TabStop = False
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(200, 344)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(168, 20)
        Me.TbEmail.TabIndex = 5
        '
        'TbCui
        '
        Me.TbCui.Location = New System.Drawing.Point(200, 318)
        Me.TbCui.MaxLength = 13
        Me.TbCui.Name = "TbCui"
        Me.TbCui.Size = New System.Drawing.Size(168, 20)
        Me.TbCui.TabIndex = 4
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(200, 292)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(168, 20)
        Me.TbNombre.TabIndex = 3
        '
        'TbPuesto
        '
        Me.TbPuesto.Location = New System.Drawing.Point(200, 266)
        Me.TbPuesto.Name = "TbPuesto"
        Me.TbPuesto.Size = New System.Drawing.Size(168, 20)
        Me.TbPuesto.TabIndex = 2
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(200, 240)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(168, 20)
        Me.TbPassword.TabIndex = 1
        '
        'TbUserName
        '
        Me.TbUserName.Location = New System.Drawing.Point(200, 214)
        Me.TbUserName.Name = "TbUserName"
        Me.TbUserName.Size = New System.Drawing.Size(168, 20)
        Me.TbUserName.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(251, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 134)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'DTGempleados
        '
        Me.DTGempleados.BackgroundColor = System.Drawing.Color.Pink
        Me.DTGempleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGempleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGempleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTGempleados.ColumnHeadersHeight = 30
        Me.DTGempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTGempleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DTGempleados.EnableHeadersVisualStyles = False
        Me.DTGempleados.GridColor = System.Drawing.Color.PaleVioletRed
        Me.DTGempleados.Location = New System.Drawing.Point(12, 40)
        Me.DTGempleados.Name = "DTGempleados"
        Me.DTGempleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGempleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DTGempleados.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DTGempleados.Size = New System.Drawing.Size(517, 345)
        Me.DTGempleados.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ejemplo 1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Lista de empleados"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtEditar
        '
        Me.BtEditar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEditar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEditar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEditar.Location = New System.Drawing.Point(12, 391)
        Me.BtEditar.Name = "BtEditar"
        Me.BtEditar.Size = New System.Drawing.Size(105, 34)
        Me.BtEditar.TabIndex = 8
        Me.BtEditar.Text = "Editar"
        Me.BtEditar.UseVisualStyleBackColor = False
        '
        'BtEliminar
        '
        Me.BtEliminar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtEliminar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtEliminar.ForeColor = System.Drawing.SystemColors.Info
        Me.BtEliminar.Location = New System.Drawing.Point(234, 391)
        Me.BtEliminar.Name = "BtEliminar"
        Me.BtEliminar.Size = New System.Drawing.Size(105, 34)
        Me.BtEliminar.TabIndex = 9
        Me.BtEliminar.Text = "Eliminar"
        Me.BtEliminar.UseVisualStyleBackColor = False
        '
        'BtNuevo
        '
        Me.BtNuevo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtNuevo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNuevo.ForeColor = System.Drawing.SystemColors.Info
        Me.BtNuevo.Location = New System.Drawing.Point(123, 391)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(105, 34)
        Me.BtNuevo.TabIndex = 10
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = False
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(920, 464)
        Me.Controls.Add(Me.BtNuevo)
        Me.Controls.Add(Me.BtEliminar)
        Me.Controls.Add(Me.BtEditar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTGempleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de empleados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DTGempleados As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents BtExaminar As Button
    Friend WithEvents PbEmpleado As PictureBox
    Friend WithEvents TbEmail As TextBox
    Friend WithEvents TbCui As TextBox
    Friend WithEvents TbNombre As TextBox
    Friend WithEvents TbPuesto As TextBox
    Friend WithEvents TbPassword As TextBox
    Friend WithEvents TbUserName As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtGuardar As Button
    Friend WithEvents BtEditar As Button
    Friend WithEvents BtEliminar As Button
    Friend WithEvents BtNuevo As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents RdVendedor As RadioButton
    Friend WithEvents RdAdmin As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtVolver As Button
End Class
