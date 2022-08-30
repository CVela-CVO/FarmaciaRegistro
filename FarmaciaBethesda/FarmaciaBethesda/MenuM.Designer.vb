<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtSalir = New System.Windows.Forms.Button()
        Me.BtVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtInventario = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtVender = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtUsuarios = New System.Windows.Forms.Button()
        Me.BtMarcas = New System.Windows.Forms.Button()
        Me.BtDistrib = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox1.Controls.Add(Me.BtSalir)
        Me.GroupBox1.Controls.Add(Me.BtVolver)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(-7, -12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 481)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'BtSalir
        '
        Me.BtSalir.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtSalir.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSalir.ForeColor = System.Drawing.SystemColors.Info
        Me.BtSalir.Location = New System.Drawing.Point(21, 223)
        Me.BtSalir.Name = "BtSalir"
        Me.BtSalir.Size = New System.Drawing.Size(105, 34)
        Me.BtSalir.TabIndex = 6
        Me.BtSalir.Text = "Salir"
        Me.BtSalir.UseVisualStyleBackColor = False
        '
        'BtVolver
        '
        Me.BtVolver.BackColor = System.Drawing.Color.PaleVioletRed
        Me.BtVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVolver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVolver.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVolver.Location = New System.Drawing.Point(19, 137)
        Me.BtVolver.Name = "BtVolver"
        Me.BtVolver.Size = New System.Drawing.Size(105, 34)
        Me.BtVolver.TabIndex = 5
        Me.BtVolver.Text = "Volver"
        Me.BtVolver.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtInventario
        '
        Me.BtInventario.BackColor = System.Drawing.Color.Pink
        Me.BtInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtInventario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtInventario.ForeColor = System.Drawing.SystemColors.Info
        Me.BtInventario.Location = New System.Drawing.Point(149, 45)
        Me.BtInventario.Name = "BtInventario"
        Me.BtInventario.Size = New System.Drawing.Size(133, 48)
        Me.BtInventario.TabIndex = 7
        Me.BtInventario.Text = "Inventario"
        Me.BtInventario.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label2.Location = New System.Drawing.Point(145, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Administrador"
        '
        'BtVender
        '
        Me.BtVender.BackColor = System.Drawing.Color.Pink
        Me.BtVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtVender.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtVender.ForeColor = System.Drawing.SystemColors.Info
        Me.BtVender.Location = New System.Drawing.Point(149, 189)
        Me.BtVender.Name = "BtVender"
        Me.BtVender.Size = New System.Drawing.Size(133, 56)
        Me.BtVender.TabIndex = 9
        Me.BtVender.Text = "Vender"
        Me.BtVender.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.PaleVioletRed
        Me.Label1.Location = New System.Drawing.Point(145, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Vendedor"
        '
        'BtUsuarios
        '
        Me.BtUsuarios.BackColor = System.Drawing.Color.Pink
        Me.BtUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtUsuarios.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtUsuarios.ForeColor = System.Drawing.SystemColors.Info
        Me.BtUsuarios.Location = New System.Drawing.Point(292, 45)
        Me.BtUsuarios.Name = "BtUsuarios"
        Me.BtUsuarios.Size = New System.Drawing.Size(157, 48)
        Me.BtUsuarios.TabIndex = 11
        Me.BtUsuarios.Text = "Añadir usuario"
        Me.BtUsuarios.UseVisualStyleBackColor = False
        '
        'BtMarcas
        '
        Me.BtMarcas.BackColor = System.Drawing.Color.Pink
        Me.BtMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtMarcas.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtMarcas.ForeColor = System.Drawing.SystemColors.Info
        Me.BtMarcas.Location = New System.Drawing.Point(149, 102)
        Me.BtMarcas.Name = "BtMarcas"
        Me.BtMarcas.Size = New System.Drawing.Size(133, 48)
        Me.BtMarcas.TabIndex = 12
        Me.BtMarcas.Text = "Marcas"
        Me.BtMarcas.UseVisualStyleBackColor = False
        '
        'BtDistrib
        '
        Me.BtDistrib.BackColor = System.Drawing.Color.Pink
        Me.BtDistrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtDistrib.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDistrib.ForeColor = System.Drawing.SystemColors.Info
        Me.BtDistrib.Location = New System.Drawing.Point(292, 102)
        Me.BtDistrib.Name = "BtDistrib"
        Me.BtDistrib.Size = New System.Drawing.Size(157, 48)
        Me.BtDistrib.TabIndex = 13
        Me.BtDistrib.Text = "Distribuidoras"
        Me.BtDistrib.UseVisualStyleBackColor = False
        '
        'MenuM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(461, 261)
        Me.Controls.Add(Me.BtDistrib)
        Me.Controls.Add(Me.BtMarcas)
        Me.Controls.Add(Me.BtUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtVender)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtInventario)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtVolver As Button
    Friend WithEvents BtSalir As Button
    Friend WithEvents BtInventario As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BtVender As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtUsuarios As Button
    Friend WithEvents BtMarcas As Button
    Friend WithEvents BtDistrib As Button
End Class
