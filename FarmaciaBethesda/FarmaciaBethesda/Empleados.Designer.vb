﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TbVerify = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TbNumero = New System.Windows.Forms.TextBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtEditar = New System.Windows.Forms.Button()
        Me.BtEliminar = New System.Windows.Forms.Button()
        Me.BtNuevo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Btbuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbbuscar = New System.Windows.Forms.ComboBox()
        Me.tbbuscar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TbVerify)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TbNumero)
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
        Me.GroupBox1.Size = New System.Drawing.Size(387, 581)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Pink
        Me.Label12.Location = New System.Drawing.Point(2, 262)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 22)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Verificar Contraseña:"
        '
        'TbVerify
        '
        Me.TbVerify.Location = New System.Drawing.Point(208, 265)
        Me.TbVerify.Name = "TbVerify"
        Me.TbVerify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbVerify.Size = New System.Drawing.Size(168, 20)
        Me.TbVerify.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Pink
        Me.Label11.Location = New System.Drawing.Point(1, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(205, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Número de Teléfono: "
        '
        'TbNumero
        '
        Me.TbNumero.Location = New System.Drawing.Point(207, 395)
        Me.TbNumero.Name = "TbNumero"
        Me.TbNumero.Size = New System.Drawing.Size(168, 20)
        Me.TbNumero.TabIndex = 22
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(5, 499)
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
        Me.RdVendedor.Location = New System.Drawing.Point(207, 465)
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
        Me.RdAdmin.Location = New System.Drawing.Point(207, 438)
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
        Me.Label8.Location = New System.Drawing.Point(1, 366)
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
        Me.Label7.Location = New System.Drawing.Point(1, 288)
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
        Me.Label6.Location = New System.Drawing.Point(1, 340)
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
        Me.Label5.Location = New System.Drawing.Point(1, 314)
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
        Me.Label4.Location = New System.Drawing.Point(1, 436)
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
        Me.BtGuardar.Location = New System.Drawing.Point(199, 499)
        Me.BtGuardar.Name = "BtGuardar"
        Me.BtGuardar.Size = New System.Drawing.Size(168, 36)
        Me.BtGuardar.TabIndex = 11
        Me.BtGuardar.Text = "Guardar"
        Me.BtGuardar.UseVisualStyleBackColor = False
        '
        'BtExaminar
        '
        Me.BtExaminar.Location = New System.Drawing.Point(178, 166)
        Me.BtExaminar.Name = "BtExaminar"
        Me.BtExaminar.Size = New System.Drawing.Size(75, 23)
        Me.BtExaminar.TabIndex = 10
        Me.BtExaminar.Text = "Examinar"
        Me.BtExaminar.UseVisualStyleBackColor = True
        '
        'PbEmpleado
        '
        Me.PbEmpleado.BackColor = System.Drawing.Color.Pink
        Me.PbEmpleado.Location = New System.Drawing.Point(275, 69)
        Me.PbEmpleado.Name = "PbEmpleado"
        Me.PbEmpleado.Size = New System.Drawing.Size(77, 106)
        Me.PbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEmpleado.TabIndex = 9
        Me.PbEmpleado.TabStop = False
        '
        'TbEmail
        '
        Me.TbEmail.Location = New System.Drawing.Point(207, 369)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.Size = New System.Drawing.Size(168, 20)
        Me.TbEmail.TabIndex = 5
        '
        'TbCui
        '
        Me.TbCui.Location = New System.Drawing.Point(207, 343)
        Me.TbCui.MaxLength = 13
        Me.TbCui.Name = "TbCui"
        Me.TbCui.Size = New System.Drawing.Size(168, 20)
        Me.TbCui.TabIndex = 4
        '
        'TbNombre
        '
        Me.TbNombre.Location = New System.Drawing.Point(207, 317)
        Me.TbNombre.Name = "TbNombre"
        Me.TbNombre.Size = New System.Drawing.Size(168, 20)
        Me.TbNombre.TabIndex = 3
        '
        'TbPuesto
        '
        Me.TbPuesto.Location = New System.Drawing.Point(207, 291)
        Me.TbPuesto.Name = "TbPuesto"
        Me.TbPuesto.Size = New System.Drawing.Size(168, 20)
        Me.TbPuesto.TabIndex = 2
        '
        'TbPassword
        '
        Me.TbPassword.Location = New System.Drawing.Point(208, 239)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TbPassword.Size = New System.Drawing.Size(168, 20)
        Me.TbPassword.TabIndex = 1
        '
        'TbUserName
        '
        Me.TbUserName.Location = New System.Drawing.Point(208, 213)
        Me.TbUserName.Name = "TbUserName"
        Me.TbUserName.Size = New System.Drawing.Size(168, 20)
        Me.TbUserName.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 134)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'DTGempleados
        '
        Me.DTGempleados.AllowUserToAddRows = False
        Me.DTGempleados.AllowUserToDeleteRows = False
        Me.DTGempleados.BackgroundColor = System.Drawing.Color.Pink
        Me.DTGempleados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DTGempleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGempleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DTGempleados.ColumnHeadersHeight = 30
        Me.DTGempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DTGempleados.EnableHeadersVisualStyles = False
        Me.DTGempleados.GridColor = System.Drawing.Color.PaleVioletRed
        Me.DTGempleados.Location = New System.Drawing.Point(12, 137)
        Me.DTGempleados.Name = "DTGempleados"
        Me.DTGempleados.ReadOnly = True
        Me.DTGempleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTGempleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Pink
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PaleVioletRed
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DTGempleados.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DTGempleados.Size = New System.Drawing.Size(517, 345)
        Me.DTGempleados.TabIndex = 1
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
        Me.BtEditar.Location = New System.Drawing.Point(12, 488)
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
        Me.BtEliminar.Location = New System.Drawing.Point(234, 488)
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
        Me.BtNuevo.Location = New System.Drawing.Point(123, 488)
        Me.BtNuevo.Name = "BtNuevo"
        Me.BtNuevo.Size = New System.Drawing.Size(105, 34)
        Me.BtNuevo.TabIndex = 10
        Me.BtNuevo.Text = "Nuevo"
        Me.BtNuevo.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Info
        Me.Button1.Location = New System.Drawing.Point(327, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 50)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Mostrar Todos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(10, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 20)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Buscar por:"
        '
        'Btbuscar
        '
        Me.Btbuscar.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btbuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btbuscar.ForeColor = System.Drawing.SystemColors.Info
        Me.Btbuscar.Location = New System.Drawing.Point(234, 69)
        Me.Btbuscar.Name = "Btbuscar"
        Me.Btbuscar.Size = New System.Drawing.Size(87, 50)
        Me.Btbuscar.TabIndex = 63
        Me.Btbuscar.Text = "Buscar"
        Me.Btbuscar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(10, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 62
        Me.Label14.Text = "Buscar:"
        '
        'cbbuscar
        '
        Me.cbbuscar.FormattingEnabled = True
        Me.cbbuscar.Items.AddRange(New Object() {"Tipo", "Nombre", "Puesto", "CUI", "Email", "Telefono"})
        Me.cbbuscar.Location = New System.Drawing.Point(107, 98)
        Me.cbbuscar.Name = "cbbuscar"
        Me.cbbuscar.Size = New System.Drawing.Size(121, 21)
        Me.cbbuscar.TabIndex = 61
        '
        'tbbuscar
        '
        Me.tbbuscar.Location = New System.Drawing.Point(107, 69)
        Me.tbbuscar.Name = "tbbuscar"
        Me.tbbuscar.Size = New System.Drawing.Size(121, 20)
        Me.tbbuscar.TabIndex = 60
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(929, 529)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Btbuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbbuscar)
        Me.Controls.Add(Me.tbbuscar)
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
    Friend WithEvents Label11 As Label
    Friend WithEvents TbNumero As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TbVerify As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Btbuscar As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents cbbuscar As ComboBox
    Friend WithEvents tbbuscar As TextBox
End Class
