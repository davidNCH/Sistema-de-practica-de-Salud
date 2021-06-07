<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personamora
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvtodo = New System.Windows.Forms.DataGrid()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcostomora = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidmora = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lectordni = New System.Windows.Forms.TextBox()
        Me.lectorap = New System.Windows.Forms.TextBox()
        Me.lectornombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidlector = New System.Windows.Forms.TextBox()
        Me.TXTRETRASO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidlibro = New System.Windows.Forms.TextBox()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.libroautor = New System.Windows.Forms.TextBox()
        Me.librotitulo = New System.Windows.Forms.TextBox()
        Me.DTPESTIMADA = New System.Windows.Forms.DateTimePicker()
        Me.dtmfechadevolucion = New System.Windows.Forms.DateTimePicker()
        Me.dtmfechaprestamo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTMULTA = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtbuscardgv = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Print = New System.Drawing.Printing.PrintDocument()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(511, 515)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvtodo
        '
        Me.dgvtodo.BackgroundColor = System.Drawing.Color.Tan
        Me.dgvtodo.CaptionBackColor = System.Drawing.Color.Peru
        Me.dgvtodo.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.DataMember = ""
        Me.dgvtodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvtodo.Location = New System.Drawing.Point(-1, 217)
        Me.dgvtodo.Name = "dgvtodo"
        Me.dgvtodo.PreferredColumnWidth = 94
        Me.dgvtodo.Size = New System.Drawing.Size(1049, 366)
        Me.dgvtodo.TabIndex = 244
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(117, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 16)
        Me.Label13.TabIndex = 273
        Me.Label13.Text = "Datos de la Persona"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(652, 554)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 18)
        Me.Label6.TabIndex = 270
        Me.Label6.Text = "Multa Por Retraso"
        '
        'txtcostomora
        '
        Me.txtcostomora.Location = New System.Drawing.Point(503, 489)
        Me.txtcostomora.Name = "txtcostomora"
        Me.txtcostomora.Size = New System.Drawing.Size(132, 20)
        Me.txtcostomora.TabIndex = 269
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(664, 452)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 18)
        Me.Label9.TabIndex = 265
        Me.Label9.Text = "Fecha De Devolucion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 263
        Me.Label4.Text = "Fecha Prestamo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 262
        Me.Label1.Text = "ID MORA"
        '
        'txtidmora
        '
        Me.txtidmora.Location = New System.Drawing.Point(519, 489)
        Me.txtidmora.Name = "txtidmora"
        Me.txtidmora.Size = New System.Drawing.Size(100, 20)
        Me.txtidmora.TabIndex = 261
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(131, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 18)
        Me.Label12.TabIndex = 281
        Me.Label12.Text = "Dni del lector"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(500, 353)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 18)
        Me.Label8.TabIndex = 280
        Me.Label8.Text = "Apellido del lector"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 353)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 18)
        Me.Label7.TabIndex = 279
        Me.Label7.Text = "Nombre Lector"
        '
        'lectordni
        '
        Me.lectordni.Location = New System.Drawing.Point(109, 485)
        Me.lectordni.Name = "lectordni"
        Me.lectordni.Size = New System.Drawing.Size(115, 20)
        Me.lectordni.TabIndex = 278
        '
        'lectorap
        '
        Me.lectorap.Location = New System.Drawing.Point(475, 383)
        Me.lectorap.Name = "lectorap"
        Me.lectorap.Size = New System.Drawing.Size(185, 20)
        Me.lectorap.TabIndex = 277
        '
        'lectornombre
        '
        Me.lectornombre.Location = New System.Drawing.Point(291, 383)
        Me.lectornombre.Name = "lectornombre"
        Me.lectornombre.Size = New System.Drawing.Size(137, 20)
        Me.lectornombre.TabIndex = 276
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 18)
        Me.Label2.TabIndex = 275
        Me.Label2.Text = "ID  Lector"
        '
        'txtidlector
        '
        Me.txtidlector.Location = New System.Drawing.Point(120, 383)
        Me.txtidlector.Name = "txtidlector"
        Me.txtidlector.Size = New System.Drawing.Size(133, 20)
        Me.txtidlector.TabIndex = 274
        '
        'TXTRETRASO
        '
        Me.TXTRETRASO.Location = New System.Drawing.Point(703, 383)
        Me.TXTRETRASO.Multiline = True
        Me.TXTRETRASO.Name = "TXTRETRASO"
        Me.TXTRETRASO.Size = New System.Drawing.Size(133, 20)
        Me.TXTRETRASO.TabIndex = 282
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(700, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 283
        Me.Label3.Text = "DIAS DE RETRASO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 287
        Me.Label5.Text = "ID LIBRO"
        '
        'txtidlibro
        '
        Me.txtidlibro.Location = New System.Drawing.Point(625, 489)
        Me.txtidlibro.Name = "txtidlibro"
        Me.txtidlibro.Size = New System.Drawing.Size(102, 20)
        Me.txtidlibro.TabIndex = 286
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
        Me.btnmostrartodo.Location = New System.Drawing.Point(534, 132)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 288
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(407, 554)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 18)
        Me.Label16.TabIndex = 292
        Me.Label16.Text = "Autor del libro"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(172, 554)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 18)
        Me.Label17.TabIndex = 291
        Me.Label17.Text = "Nombre del libro"
        '
        'libroautor
        '
        Me.libroautor.Location = New System.Drawing.Point(375, 589)
        Me.libroautor.Name = "libroautor"
        Me.libroautor.Size = New System.Drawing.Size(212, 20)
        Me.libroautor.TabIndex = 290
        '
        'librotitulo
        '
        Me.librotitulo.Location = New System.Drawing.Point(122, 589)
        Me.librotitulo.Name = "librotitulo"
        Me.librotitulo.Size = New System.Drawing.Size(210, 20)
        Me.librotitulo.TabIndex = 289
        '
        'DTPESTIMADA
        '
        Me.DTPESTIMADA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPESTIMADA.Location = New System.Drawing.Point(454, 485)
        Me.DTPESTIMADA.Name = "DTPESTIMADA"
        Me.DTPESTIMADA.Size = New System.Drawing.Size(157, 20)
        Me.DTPESTIMADA.TabIndex = 295
        '
        'dtmfechadevolucion
        '
        Me.dtmfechadevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfechadevolucion.Location = New System.Drawing.Point(692, 482)
        Me.dtmfechadevolucion.Name = "dtmfechadevolucion"
        Me.dtmfechadevolucion.Size = New System.Drawing.Size(95, 20)
        Me.dtmfechadevolucion.TabIndex = 296
        '
        'dtmfechaprestamo
        '
        Me.dtmfechaprestamo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfechaprestamo.Location = New System.Drawing.Point(292, 482)
        Me.dtmfechaprestamo.Name = "dtmfechaprestamo"
        Me.dtmfechaprestamo.Size = New System.Drawing.Size(95, 20)
        Me.dtmfechaprestamo.TabIndex = 297
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(451, 452)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(176, 18)
        Me.Label10.TabIndex = 298
        Me.Label10.Text = "Fecha Entega Acordada"
        '
        'TXTMULTA
        '
        Me.TXTMULTA.Location = New System.Drawing.Point(654, 589)
        Me.TXTMULTA.Name = "TXTMULTA"
        Me.TXTMULTA.Size = New System.Drawing.Size(132, 20)
        Me.TXTMULTA.TabIndex = 299
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(202, 24)
        Me.Label11.TabIndex = 300
        Me.Label11.Text = "PERSONAS MOROSAS"
        '
        'txtbuscardgv
        '
        Me.txtbuscardgv.Location = New System.Drawing.Point(228, 148)
        Me.txtbuscardgv.Name = "txtbuscardgv"
        Me.txtbuscardgv.Size = New System.Drawing.Size(132, 20)
        Me.txtbuscardgv.TabIndex = 301
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(111, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 302
        Me.Label14.Text = "Buscar lector"
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
        Me.Button2.Location = New System.Drawing.Point(394, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 35)
        Me.Button2.TabIndex = 303
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Print
        '
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
        Me.Button3.Location = New System.Drawing.Point(762, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 42)
        Me.Button3.TabIndex = 304
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.apps_printer_15747
        Me.BTNIMPRIMIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNIMPRIMIR.FlatAppearance.BorderSize = 0
        Me.BTNIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(694, 126)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(53, 42)
        Me.BTNIMPRIMIR.TabIndex = 338
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'personamora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.libr
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1047, 635)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvtodo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbuscardgv)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTMULTA)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtmfechaprestamo)
        Me.Controls.Add(Me.dtmfechadevolucion)
        Me.Controls.Add(Me.DTPESTIMADA)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.libroautor)
        Me.Controls.Add(Me.librotitulo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTRETRASO)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lectordni)
        Me.Controls.Add(Me.lectorap)
        Me.Controls.Add(Me.lectornombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidlector)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtidlibro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidmora)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.txtcostomora)
        Me.Name = "personamora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "personamora"
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvtodo As System.Windows.Forms.DataGrid
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcostomora As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidmora As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lectordni As System.Windows.Forms.TextBox
    Friend WithEvents lectorap As System.Windows.Forms.TextBox
    Friend WithEvents lectornombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidlector As System.Windows.Forms.TextBox
    Friend WithEvents TXTRETRASO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtidlibro As System.Windows.Forms.TextBox
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents libroautor As System.Windows.Forms.TextBox
    Friend WithEvents librotitulo As System.Windows.Forms.TextBox
    Friend WithEvents DTPESTIMADA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtmfechadevolucion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtmfechaprestamo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTMULTA As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtbuscardgv As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Print As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
End Class
