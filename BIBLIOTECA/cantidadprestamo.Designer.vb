<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cantidadprestamo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cantiprestamo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.datagridmostrar = New System.Windows.Forms.DataGrid()
        Me.print = New System.Drawing.Printing.PrintDocument()
        Me.IMPRIMIR = New System.Windows.Forms.Button()
        Me.vista_previa = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 18)
        Me.Label1.TabIndex = 389
        Me.Label1.Text = " N°"
        '
        'cantiprestamo
        '
        Me.cantiprestamo.Location = New System.Drawing.Point(370, 73)
        Me.cantiprestamo.Name = "cantiprestamo"
        Me.cantiprestamo.Size = New System.Drawing.Size(75, 20)
        Me.cantiprestamo.TabIndex = 388
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(274, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(346, 24)
        Me.Label11.TabIndex = 387
        Me.Label11.Text = "CANTIDAD DE LIBROS PRESTADOS"
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
        Me.btnbuscar.Location = New System.Drawing.Point(407, 147)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(99, 35)
        Me.btnbuscar.TabIndex = 384
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(98, 155)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 18)
        Me.Label14.TabIndex = 383
        Me.Label14.Text = "Buscar Libro  :"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(245, 155)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(156, 20)
        Me.txtbuscar.TabIndex = 382
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
        Me.btnmostrartodo.Location = New System.Drawing.Point(526, 147)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 381
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'datagridmostrar
        '
        Me.datagridmostrar.BackgroundColor = System.Drawing.Color.Tan
        Me.datagridmostrar.CaptionBackColor = System.Drawing.Color.Peru
        Me.datagridmostrar.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridmostrar.DataMember = ""
        Me.datagridmostrar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridmostrar.Location = New System.Drawing.Point(12, 201)
        Me.datagridmostrar.Name = "datagridmostrar"
        Me.datagridmostrar.PreferredColumnWidth = 94
        Me.datagridmostrar.Size = New System.Drawing.Size(877, 268)
        Me.datagridmostrar.TabIndex = 380
        '
        'print
        '
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
        Me.IMPRIMIR.Location = New System.Drawing.Point(653, 148)
        Me.IMPRIMIR.Name = "IMPRIMIR"
        Me.IMPRIMIR.Size = New System.Drawing.Size(35, 35)
        Me.IMPRIMIR.TabIndex = 390
        Me.IMPRIMIR.UseVisualStyleBackColor = False
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
        Me.vista_previa.Location = New System.Drawing.Point(703, 147)
        Me.vista_previa.Name = "vista_previa"
        Me.vista_previa.Size = New System.Drawing.Size(37, 35)
        Me.vista_previa.TabIndex = 385
        Me.vista_previa.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(506, 73)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButton1.TabIndex = 392
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'cantidadprestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 527)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.IMPRIMIR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cantiprestamo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.vista_previa)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.datagridmostrar)
        Me.Name = "cantidadprestamo"
        Me.Text = "cantidadprestamo"
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cantiprestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents vista_previa As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents datagridmostrar As System.Windows.Forms.DataGrid
    Friend WithEvents IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents print As System.Drawing.Printing.PrintDocument
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
