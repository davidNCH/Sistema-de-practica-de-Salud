<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libro_disponible
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
        Me.dgvtodo = New System.Windows.Forms.DataGrid()
        Me.dtpedicion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txteditorial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.dtpadquisicion = New System.Windows.Forms.DateTimePicker()
        Me.txtmetodo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnropag = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtautor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtgenero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txttitulo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlibro = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTDISPONIBLE = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbuscardgv = New System.Windows.Forms.TextBox()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.Print = New System.Drawing.Printing.PrintDocument()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvtodo
        '
        Me.dgvtodo.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvtodo.CaptionBackColor = System.Drawing.Color.Peru
        Me.dgvtodo.CaptionFont = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.DataMember = ""
        Me.dgvtodo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvtodo.Location = New System.Drawing.Point(-1, 182)
        Me.dgvtodo.Name = "dgvtodo"
        Me.dgvtodo.PreferredColumnWidth = 94
        Me.dgvtodo.Size = New System.Drawing.Size(1013, 328)
        Me.dgvtodo.TabIndex = 245
        '
        'dtpedicion
        '
        Me.dtpedicion.Location = New System.Drawing.Point(61, 472)
        Me.dtpedicion.Name = "dtpedicion"
        Me.dtpedicion.Size = New System.Drawing.Size(100, 20)
        Me.dtpedicion.TabIndex = 266
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 17.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(278, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(389, 27)
        Me.Label11.TabIndex = 265
        Me.Label11.Text = "REPORTE DE LIBROS DISPONIBLES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 264
        Me.Label10.Text = "EDITORIAL"
        '
        'txteditorial
        '
        Me.txteditorial.Location = New System.Drawing.Point(196, 472)
        Me.txteditorial.Name = "txteditorial"
        Me.txteditorial.Size = New System.Drawing.Size(151, 20)
        Me.txteditorial.TabIndex = 263
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(58, 439)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 262
        Me.Label9.Text = "AÑO DE EDICION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(678, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 261
        Me.Label8.Text = "ESTADO"
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(628, 390)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(162, 20)
        Me.txtestado.TabIndex = 260
        '
        'dtpadquisicion
        '
        Me.dtpadquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpadquisicion.Location = New System.Drawing.Point(246, 392)
        Me.dtpadquisicion.Name = "dtpadquisicion"
        Me.dtpadquisicion.Size = New System.Drawing.Size(137, 20)
        Me.dtpadquisicion.TabIndex = 259
        '
        'txtmetodo
        '
        Me.txtmetodo.Location = New System.Drawing.Point(14, 390)
        Me.txtmetodo.Multiline = True
        Me.txtmetodo.Name = "txtmetodo"
        Me.txtmetodo.Size = New System.Drawing.Size(150, 22)
        Me.txtmetodo.TabIndex = 258
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(486, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 257
        Me.Label7.Text = "NRO PAGINAS"
        '
        'txtnropag
        '
        Me.txtnropag.Location = New System.Drawing.Point(484, 392)
        Me.txtnropag.Name = "txtnropag"
        Me.txtnropag.Size = New System.Drawing.Size(92, 20)
        Me.txtnropag.TabIndex = 256
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(243, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 18)
        Me.Label6.TabIndex = 255
        Me.Label6.Text = "FECHA ADQUICION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 18)
        Me.Label5.TabIndex = 254
        Me.Label5.Text = "METODO ADQUICION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(730, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 253
        Me.Label4.Text = "AUTOR"
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(663, 366)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(177, 20)
        Me.txtautor.TabIndex = 252
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(473, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "GENERO"
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(420, 366)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(175, 20)
        Me.txtgenero.TabIndex = 250
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "TITULO"
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(198, 366)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(175, 20)
        Me.txttitulo.TabIndex = 248
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 247
        Me.Label1.Text = "ID LIBRO"
        '
        'txtlibro
        '
        Me.txtlibro.Location = New System.Drawing.Point(64, 366)
        Me.txtlibro.Name = "txtlibro"
        Me.txtlibro.Size = New System.Drawing.Size(100, 20)
        Me.txtlibro.TabIndex = 246
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(373, 439)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 268
        Me.Label12.Text = "DISPONIBLE"
        '
        'TXTDISPONIBLE
        '
        Me.TXTDISPONIBLE.Location = New System.Drawing.Point(376, 472)
        Me.TXTDISPONIBLE.Name = "TXTDISPONIBLE"
        Me.TXTDISPONIBLE.Size = New System.Drawing.Size(151, 20)
        Me.TXTDISPONIBLE.TabIndex = 267
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(220, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 307
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(61, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 18)
        Me.Label14.TabIndex = 306
        Me.Label14.Text = "Buscar Libro"
        '
        'txtbuscardgv
        '
        Me.txtbuscardgv.Location = New System.Drawing.Point(64, 125)
        Me.txtbuscardgv.Name = "txtbuscardgv"
        Me.txtbuscardgv.Size = New System.Drawing.Size(132, 20)
        Me.txtbuscardgv.TabIndex = 305
        '
        'btnmostrartodo
        '
        Me.btnmostrartodo.BackColor = System.Drawing.Color.Gainsboro
        Me.btnmostrartodo.FlatAppearance.BorderSize = 0
        Me.btnmostrartodo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnmostrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrartodo.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmostrartodo.Location = New System.Drawing.Point(339, 117)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 304
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'Print
        '
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.apps_printer_15747
        Me.BTNIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIMPRIMIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNIMPRIMIR.FlatAppearance.BorderSize = 0
        Me.BTNIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(663, 118)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(53, 42)
        Me.BTNIMPRIMIR.TabIndex = 342
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.actions_document_print_preview_15786
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(778, 117)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 42)
        Me.Button3.TabIndex = 341
        Me.Button3.UseVisualStyleBackColor = False
        '
        'libro_disponible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 508)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvtodo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbuscardgv)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTDISPONIBLE)
        Me.Controls.Add(Me.dtpedicion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txteditorial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.dtpadquisicion)
        Me.Controls.Add(Me.txtmetodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtnropag)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtautor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtgenero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txttitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtlibro)
        Me.Name = "libro_disponible"
        Me.Text = "libro_disponible"
        CType(Me.dgvtodo,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents dgvtodo As System.Windows.Forms.DataGrid
    Friend WithEvents dtpedicion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txteditorial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents dtpadquisicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmetodo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnropag As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtautor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtgenero As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlibro As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TXTDISPONIBLE As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbuscardgv As System.Windows.Forms.TextBox
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents Print As System.Drawing.Printing.PrintDocument
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
