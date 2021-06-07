<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class personalactivo
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
        Me.datagridmostrar = New System.Windows.Forms.DataGrid()
        Me.txtidjornada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbsexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bntbuscar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtcargo = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtapellid = New System.Windows.Forms.TextBox()
        Me.txtnombrepers = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidpersonal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.vista_previa = New System.Windows.Forms.Button()
        Me.IMPRIMIR = New System.Windows.Forms.Button()
        Me.print = New System.Drawing.Printing.PrintDocument()
        Me.txthorasale = New System.Windows.Forms.TextBox()
        Me.txthoraentra = New System.Windows.Forms.TextBox()
        Me.dtmfecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridmostrar
        '
        Me.datagridmostrar.BackgroundColor = System.Drawing.Color.Tan
        Me.datagridmostrar.CaptionBackColor = System.Drawing.Color.Peru
        Me.datagridmostrar.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridmostrar.DataMember = ""
        Me.datagridmostrar.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.datagridmostrar.Location = New System.Drawing.Point(12, 178)
        Me.datagridmostrar.Name = "datagridmostrar"
        Me.datagridmostrar.PreferredColumnWidth = 94
        Me.datagridmostrar.Size = New System.Drawing.Size(948, 324)
        Me.datagridmostrar.TabIndex = 391
        '
        'txtidjornada
        '
        Me.txtidjornada.Location = New System.Drawing.Point(729, 308)
        Me.txtidjornada.Name = "txtidjornada"
        Me.txtidjornada.Size = New System.Drawing.Size(69, 20)
        Me.txtidjornada.TabIndex = 395
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(716, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 18)
        Me.Label6.TabIndex = 394
        Me.Label6.Text = "ID Jornada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(439, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 18)
        Me.Label5.TabIndex = 393
        Me.Label5.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(270, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 392
        Me.Label1.Text = "Hora Salida"
        '
        'cmbsexo
        '
        Me.cmbsexo.FormattingEnabled = True
        Me.cmbsexo.Location = New System.Drawing.Point(108, 306)
        Me.cmbsexo.Name = "cmbsexo"
        Me.cmbsexo.Size = New System.Drawing.Size(51, 21)
        Me.cmbsexo.TabIndex = 390
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(392, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 24)
        Me.Label11.TabIndex = 389
        Me.Label11.Text = "PERSONALES ACTIVOS"
        '
        'bntbuscar
        '
        Me.bntbuscar.BackColor = System.Drawing.Color.Gainsboro
        Me.bntbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bntbuscar.FlatAppearance.BorderSize = 0
        Me.bntbuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.bntbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bntbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bntbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntbuscar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntbuscar.Location = New System.Drawing.Point(406, 122)
        Me.bntbuscar.Name = "bntbuscar"
        Me.bntbuscar.Size = New System.Drawing.Size(99, 35)
        Me.bntbuscar.TabIndex = 388
        Me.bntbuscar.Text = "Buscar"
        Me.bntbuscar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(83, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 18)
        Me.Label14.TabIndex = 387
        Me.Label14.Text = "Buscar lector"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(234, 130)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(132, 20)
        Me.txtbuscar.TabIndex = 386
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(522, 271)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 18)
        Me.Label16.TabIndex = 385
        Me.Label16.Text = "Cargo"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(250, 271)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 18)
        Me.Label17.TabIndex = 384
        Me.Label17.Text = "Direccion"
        '
        'txtcargo
        '
        Me.txtcargo.Location = New System.Drawing.Point(441, 306)
        Me.txtcargo.Name = "txtcargo"
        Me.txtcargo.Size = New System.Drawing.Size(212, 20)
        Me.txtcargo.TabIndex = 383
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(200, 306)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(210, 20)
        Me.txtdireccion.TabIndex = 382
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(772, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 380
        Me.Label3.Text = "DNI"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(729, 226)
        Me.txtdni.Multiline = True
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(113, 20)
        Me.txtdni.TabIndex = 379
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(119, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 18)
        Me.Label12.TabIndex = 378
        Me.Label12.Text = "Sexo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 377
        Me.Label8.Text = "Apellidos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(295, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 18)
        Me.Label7.TabIndex = 376
        Me.Label7.Text = "Nombre Personal"
        '
        'txtapellid
        '
        Me.txtapellid.Location = New System.Drawing.Point(483, 225)
        Me.txtapellid.Name = "txtapellid"
        Me.txtapellid.Size = New System.Drawing.Size(206, 20)
        Me.txtapellid.TabIndex = 375
        '
        'txtnombrepers
        '
        Me.txtnombrepers.Location = New System.Drawing.Point(277, 225)
        Me.txtnombrepers.Name = "txtnombrepers"
        Me.txtnombrepers.Size = New System.Drawing.Size(165, 20)
        Me.txtnombrepers.TabIndex = 374
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 373
        Me.Label2.Text = "ID  Personal"
        '
        'txtidpersonal
        '
        Me.txtidpersonal.Location = New System.Drawing.Point(122, 225)
        Me.txtidpersonal.Name = "txtidpersonal"
        Me.txtidpersonal.Size = New System.Drawing.Size(93, 20)
        Me.txtidpersonal.TabIndex = 372
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 371
        Me.Label4.Text = "Hora Entrada"
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
        Me.btnmostrartodo.Location = New System.Drawing.Point(525, 122)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(107, 35)
        Me.btnmostrartodo.TabIndex = 381
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
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
        Me.vista_previa.Location = New System.Drawing.Point(805, 103)
        Me.vista_previa.Name = "vista_previa"
        Me.vista_previa.Size = New System.Drawing.Size(37, 35)
        Me.vista_previa.TabIndex = 396
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
        Me.IMPRIMIR.Location = New System.Drawing.Point(738, 104)
        Me.IMPRIMIR.Name = "IMPRIMIR"
        Me.IMPRIMIR.Size = New System.Drawing.Size(35, 35)
        Me.IMPRIMIR.TabIndex = 397
        Me.IMPRIMIR.UseVisualStyleBackColor = False
        '
        'txthorasale
        '
        Me.txthorasale.Location = New System.Drawing.Point(273, 389)
        Me.txthorasale.Name = "txthorasale"
        Me.txthorasale.Size = New System.Drawing.Size(66, 20)
        Me.txthorasale.TabIndex = 400
        '
        'txthoraentra
        '
        Me.txthoraentra.Location = New System.Drawing.Point(122, 386)
        Me.txthoraentra.Name = "txthoraentra"
        Me.txthoraentra.Size = New System.Drawing.Size(57, 20)
        Me.txthoraentra.TabIndex = 399
        '
        'dtmfecha
        '
        Me.dtmfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfecha.Location = New System.Drawing.Point(415, 386)
        Me.dtmfecha.Name = "dtmfecha"
        Me.dtmfecha.Size = New System.Drawing.Size(90, 20)
        Me.dtmfecha.TabIndex = 398
        '
        'personalactivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 540)
        Me.Controls.Add(Me.datagridmostrar)
        Me.Controls.Add(Me.txthorasale)
        Me.Controls.Add(Me.txthoraentra)
        Me.Controls.Add(Me.dtmfecha)
        Me.Controls.Add(Me.IMPRIMIR)
        Me.Controls.Add(Me.vista_previa)
        Me.Controls.Add(Me.txtidjornada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbsexo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bntbuscar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtcargo)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtapellid)
        Me.Controls.Add(Me.txtnombrepers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidpersonal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Name = "personalactivo"
        Me.Text = "personalactivo"
        CType(Me.datagridmostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridmostrar As System.Windows.Forms.DataGrid
    Friend WithEvents vista_previa As System.Windows.Forms.Button
    Friend WithEvents txtidjornada As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbsexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bntbuscar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtcargo As System.Windows.Forms.TextBox
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtapellid As System.Windows.Forms.TextBox
    Friend WithEvents txtnombrepers As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidpersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents print As System.Drawing.Printing.PrintDocument
    Friend WithEvents txthorasale As System.Windows.Forms.TextBox
    Friend WithEvents txthoraentra As System.Windows.Forms.TextBox
    Friend WithEvents dtmfecha As System.Windows.Forms.DateTimePicker
End Class
