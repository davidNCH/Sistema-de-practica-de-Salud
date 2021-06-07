<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cantidadlibros
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
        Me.cantiotros = New System.Windows.Forms.TextBox()
        Me.canticomprado = New System.Windows.Forms.TextBox()
        Me.cantidonado = New System.Windows.Forms.TextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.lbnoespecificado = New System.Windows.Forms.RadioButton()
        Me.lbcomprado = New System.Windows.Forms.RadioButton()
        Me.lbdonado = New System.Windows.Forms.RadioButton()
        Me.datagridmostrar = New System.Windows.Forms.DataGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.vista_previa = New System.Windows.Forms.Button()
        Me.IMPRIMIR = New System.Windows.Forms.Button()
        Me.print = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalibro = New System.Windows.Forms.TextBox()
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cantiotros
        '
        Me.cantiotros.Location = New System.Drawing.Point(573, 135)
        Me.cantiotros.Name = "cantiotros"
        Me.cantiotros.Size = New System.Drawing.Size(76, 20)
        Me.cantiotros.TabIndex = 358
        '
        'canticomprado
        '
        Me.canticomprado.Location = New System.Drawing.Point(348, 135)
        Me.canticomprado.Name = "canticomprado"
        Me.canticomprado.Size = New System.Drawing.Size(76, 20)
        Me.canticomprado.TabIndex = 357
        '
        'cantidonado
        '
        Me.cantidonado.Location = New System.Drawing.Point(117, 144)
        Me.cantidonado.Name = "cantidonado"
        Me.cantidonado.Size = New System.Drawing.Size(76, 20)
        Me.cantidonado.TabIndex = 356
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.BorderSize = 0
        Me.btnbuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.Location = New System.Drawing.Point(423, 218)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(99, 35)
        Me.btnbuscar.TabIndex = 355
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(114, 226)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 18)
        Me.Label14.TabIndex = 354
        Me.Label14.Text = "Buscar Libro  :"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(248, 226)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(156, 20)
        Me.txtbuscar.TabIndex = 353
        '
        'btnmostrartodo
        '
        Me.btnmostrartodo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnmostrartodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmostrartodo.FlatAppearance.BorderSize = 0
        Me.btnmostrartodo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnmostrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrartodo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrartodo.Location = New System.Drawing.Point(542, 218)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 352
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'lbnoespecificado
        '
        Me.lbnoespecificado.AutoSize = True
        Me.lbnoespecificado.Location = New System.Drawing.Point(604, 106)
        Me.lbnoespecificado.Name = "lbnoespecificado"
        Me.lbnoespecificado.Size = New System.Drawing.Size(14, 13)
        Me.lbnoespecificado.TabIndex = 351
        Me.lbnoespecificado.TabStop = True
        Me.lbnoespecificado.UseVisualStyleBackColor = True
        '
        'lbcomprado
        '
        Me.lbcomprado.AutoSize = True
        Me.lbcomprado.Location = New System.Drawing.Point(379, 106)
        Me.lbcomprado.Name = "lbcomprado"
        Me.lbcomprado.Size = New System.Drawing.Size(14, 13)
        Me.lbcomprado.TabIndex = 350
        Me.lbcomprado.TabStop = True
        Me.lbcomprado.UseVisualStyleBackColor = True
        '
        'lbdonado
        '
        Me.lbdonado.AutoSize = True
        Me.lbdonado.Location = New System.Drawing.Point(150, 115)
        Me.lbdonado.Name = "lbdonado"
        Me.lbdonado.Size = New System.Drawing.Size(14, 13)
        Me.lbdonado.TabIndex = 349
        Me.lbdonado.TabStop = True
        Me.lbdonado.UseVisualStyleBackColor = True
        '
        'datagridmostrar
        '
        Me.datagridmostrar.BackgroundColor = System.Drawing.Color.Tan
        Me.datagridmostrar.CaptionBackColor = System.Drawing.Color.Peru
        Me.datagridmostrar.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridmostrar.DataMember = ""
        Me.datagridmostrar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridmostrar.Location = New System.Drawing.Point(40, 300)
        Me.datagridmostrar.Name = "datagridmostrar"
        Me.datagridmostrar.PreferredColumnWidth = 94
        Me.datagridmostrar.Size = New System.Drawing.Size(901, 165)
        Me.datagridmostrar.TabIndex = 348
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(539, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 18)
        Me.Label4.TabIndex = 347
        Me.Label4.Text = "Libros N Especificado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(324, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 346
        Me.Label3.Text = "Libros Comprados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 345
        Me.Label2.Text = "Libros Donado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(335, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 24)
        Me.Label11.TabIndex = 344
        Me.Label11.Text = "CANTIDAD DE LIBROS"
        '
        'vista_previa
        '
        Me.vista_previa.BackColor = System.Drawing.Color.Transparent
        Me.vista_previa.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.actions_document_print_preview_15786
        Me.vista_previa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vista_previa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vista_previa.FlatAppearance.BorderSize = 0
        Me.vista_previa.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.vista_previa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.vista_previa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.vista_previa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vista_previa.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vista_previa.Location = New System.Drawing.Point(800, 218)
        Me.vista_previa.Name = "vista_previa"
        Me.vista_previa.Size = New System.Drawing.Size(37, 35)
        Me.vista_previa.TabIndex = 371
        Me.vista_previa.UseVisualStyleBackColor = False
        '
        'IMPRIMIR
        '
        Me.IMPRIMIR.BackColor = System.Drawing.Color.Transparent
        Me.IMPRIMIR.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.apps_printer_15747
        Me.IMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IMPRIMIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMPRIMIR.FlatAppearance.BorderSize = 0
        Me.IMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IMPRIMIR.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMPRIMIR.ForeColor = System.Drawing.Color.Transparent
        Me.IMPRIMIR.Location = New System.Drawing.Point(710, 218)
        Me.IMPRIMIR.Name = "IMPRIMIR"
        Me.IMPRIMIR.Size = New System.Drawing.Size(53, 42)
        Me.IMPRIMIR.TabIndex = 372
        Me.IMPRIMIR.UseVisualStyleBackColor = False
        '
        'print
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(746, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "Total Libro "
        '
        'totalibro
        '
        Me.totalibro.Location = New System.Drawing.Point(761, 135)
        Me.totalibro.Name = "totalibro"
        Me.totalibro.Size = New System.Drawing.Size(76, 20)
        Me.totalibro.TabIndex = 375
        '
        'cantidadlibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 545)
        Me.Controls.Add(Me.totalibro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IMPRIMIR)
        Me.Controls.Add(Me.vista_previa)
        Me.Controls.Add(Me.cantiotros)
        Me.Controls.Add(Me.canticomprado)
        Me.Controls.Add(Me.cantidonado)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.lbnoespecificado)
        Me.Controls.Add(Me.lbcomprado)
        Me.Controls.Add(Me.lbdonado)
        Me.Controls.Add(Me.datagridmostrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Name = "cantidadlibros"
        Me.Text = "cantidadlibros"
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cantiotros As System.Windows.Forms.TextBox
    Friend WithEvents canticomprado As System.Windows.Forms.TextBox
    Friend WithEvents cantidonado As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents lbnoespecificado As System.Windows.Forms.RadioButton
    Friend WithEvents lbcomprado As System.Windows.Forms.RadioButton
    Friend WithEvents lbdonado As System.Windows.Forms.RadioButton
    Friend WithEvents datagridmostrar As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents vista_previa As System.Windows.Forms.Button
    Friend WithEvents IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents print As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalibro As System.Windows.Forms.TextBox
End Class
