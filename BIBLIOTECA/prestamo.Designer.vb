<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prestamo))
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.btnbuscardgv = New System.Windows.Forms.Button()
        Me.txtbuscardgv = New System.Windows.Forms.TextBox()
        Me.rdnpersonal = New System.Windows.Forms.RadioButton()
        Me.rdnlibro = New System.Windows.Forms.RadioButton()
        Me.rdnlector = New System.Windows.Forms.RadioButton()
        Me.btnmostrartodo = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtfechaentrega = New System.Windows.Forms.TextBox()
        Me.txtfechadevolucion = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.libroautor = New System.Windows.Forms.TextBox()
        Me.librotitulo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.personalap = New System.Windows.Forms.TextBox()
        Me.personalnombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lectordni = New System.Windows.Forms.TextBox()
        Me.lectorap = New System.Windows.Forms.TextBox()
        Me.lectornombre = New System.Windows.Forms.TextBox()
        Me.dgvtodo = New System.Windows.Forms.DataGrid()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtestadodevolucion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtidlibro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtestadoentrega = New System.Windows.Forms.TextBox()
        Me.dtmfechadevolucion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtmfechaprestamo = New System.Windows.Forms.DateTimePicker()
        Me.DESPLAZAMIENTO = New System.Windows.Forms.GroupBox()
        Me.BTNSIGUIENTE = New System.Windows.Forms.Button()
        Me.BTNULTIMO = New System.Windows.Forms.Button()
        Me.BTNANTERIOR = New System.Windows.Forms.Button()
        Me.BTNPRIMERO = New System.Windows.Forms.Button()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidpersonal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidlector = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidprestamo = New System.Windows.Forms.TextBox()
        Me.groupmain = New System.Windows.Forms.GroupBox()
        Me.rdnbuspersonal = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.rdnbuslibro = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.rdnbuslector = New System.Windows.Forms.RadioButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtbuslect = New System.Windows.Forms.TextBox()
        Me.grouplector = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Print = New System.Drawing.Printing.PrintDocument()
        Me.BOLETAA = New System.Drawing.Printing.PrintDocument()
        Me.FECHA = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DESPLAZAMIENTO.SuspendLayout()
        Me.groupmain.SuspendLayout()
        Me.grouplector.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Location = New System.Drawing.Point(11, 59)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(105, 14)
        Me.lblbuscar.TabIndex = 270
        Me.lblbuscar.Text = "Buscar Lector:"
        '
        'btnbuscardgv
        '
        Me.btnbuscardgv.FlatAppearance.BorderSize = 0
        Me.btnbuscardgv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbuscardgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscardgv.Location = New System.Drawing.Point(294, 46)
        Me.btnbuscardgv.Name = "btnbuscardgv"
        Me.btnbuscardgv.Size = New System.Drawing.Size(87, 29)
        Me.btnbuscardgv.TabIndex = 269
        Me.btnbuscardgv.Text = "BUSCAR"
        Me.btnbuscardgv.UseVisualStyleBackColor = True
        '
        'txtbuscardgv
        '
        Me.txtbuscardgv.Location = New System.Drawing.Point(133, 53)
        Me.txtbuscardgv.Name = "txtbuscardgv"
        Me.txtbuscardgv.Size = New System.Drawing.Size(149, 22)
        Me.txtbuscardgv.TabIndex = 268
        '
        'rdnpersonal
        '
        Me.rdnpersonal.AutoSize = True
        Me.rdnpersonal.BackColor = System.Drawing.Color.Transparent
        Me.rdnpersonal.Location = New System.Drawing.Point(856, 113)
        Me.rdnpersonal.Name = "rdnpersonal"
        Me.rdnpersonal.Size = New System.Drawing.Size(14, 13)
        Me.rdnpersonal.TabIndex = 267
        Me.rdnpersonal.UseVisualStyleBackColor = False
        '
        'rdnlibro
        '
        Me.rdnlibro.AutoSize = True
        Me.rdnlibro.BackColor = System.Drawing.Color.Transparent
        Me.rdnlibro.Location = New System.Drawing.Point(651, 105)
        Me.rdnlibro.Name = "rdnlibro"
        Me.rdnlibro.Size = New System.Drawing.Size(14, 13)
        Me.rdnlibro.TabIndex = 266
        Me.rdnlibro.UseVisualStyleBackColor = False
        '
        'rdnlector
        '
        Me.rdnlector.AutoSize = True
        Me.rdnlector.BackColor = System.Drawing.Color.Transparent
        Me.rdnlector.Location = New System.Drawing.Point(402, 109)
        Me.rdnlector.Name = "rdnlector"
        Me.rdnlector.Size = New System.Drawing.Size(14, 13)
        Me.rdnlector.TabIndex = 265
        Me.rdnlector.UseVisualStyleBackColor = False
        '
        'btnmostrartodo
        '
        Me.btnmostrartodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnmostrartodo.FlatAppearance.BorderSize = 0
        Me.btnmostrartodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnmostrartodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmostrartodo.Location = New System.Drawing.Point(999, 451)
        Me.btnmostrartodo.Name = "btnmostrartodo"
        Me.btnmostrartodo.Size = New System.Drawing.Size(112, 27)
        Me.btnmostrartodo.TabIndex = 242
        Me.btnmostrartodo.Text = "MOSTRAR TODO"
        Me.btnmostrartodo.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(770, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(160, 15)
        Me.Label20.TabIndex = 263
        Me.Label20.Text = "DATOS DEL PERSONAL"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(526, 65)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(141, 16)
        Me.Label19.TabIndex = 262
        Me.Label19.Text = "DATOS DEL LIBRO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(307, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 16)
        Me.Label18.TabIndex = 261
        Me.Label18.Text = "DATOS DEL LECTOR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(50, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 16)
        Me.Label13.TabIndex = 260
        Me.Label13.Text = "DATOS DEL PRESTAMO"
        '
        'txtfechaentrega
        '
        Me.txtfechaentrega.Location = New System.Drawing.Point(54, 286)
        Me.txtfechaentrega.Name = "txtfechaentrega"
        Me.txtfechaentrega.Size = New System.Drawing.Size(151, 22)
        Me.txtfechaentrega.TabIndex = 259
        '
        'txtfechadevolucion
        '
        Me.txtfechadevolucion.Location = New System.Drawing.Point(54, 206)
        Me.txtfechadevolucion.Name = "txtfechadevolucion"
        Me.txtfechadevolucion.Size = New System.Drawing.Size(149, 22)
        Me.txtfechadevolucion.TabIndex = 258
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(564, 259)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 14)
        Me.Label16.TabIndex = 257
        Me.Label16.Text = "Autor del libro"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(570, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(119, 14)
        Me.Label17.TabIndex = 256
        Me.Label17.Text = "Titulo del libro"
        '
        'libroautor
        '
        Me.libroautor.Location = New System.Drawing.Point(529, 281)
        Me.libroautor.Multiline = True
        Me.libroautor.Name = "libroautor"
        Me.libroautor.Size = New System.Drawing.Size(180, 27)
        Me.libroautor.TabIndex = 255
        '
        'librotitulo
        '
        Me.librotitulo.Location = New System.Drawing.Point(529, 206)
        Me.librotitulo.Multiline = True
        Me.librotitulo.Name = "librotitulo"
        Me.librotitulo.Size = New System.Drawing.Size(180, 27)
        Me.librotitulo.TabIndex = 254
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(758, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(154, 14)
        Me.Label14.TabIndex = 253
        Me.Label14.Text = "Apellido del personal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(767, 187)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 14)
        Me.Label15.TabIndex = 252
        Me.Label15.Text = "Nombre del personal"
        '
        'personalap
        '
        Me.personalap.Location = New System.Drawing.Point(754, 286)
        Me.personalap.Multiline = True
        Me.personalap.Name = "personalap"
        Me.personalap.Size = New System.Drawing.Size(153, 27)
        Me.personalap.TabIndex = 251
        '
        'personalnombre
        '
        Me.personalnombre.Location = New System.Drawing.Point(760, 204)
        Me.personalnombre.Multiline = True
        Me.personalnombre.Name = "personalnombre"
        Me.personalnombre.Size = New System.Drawing.Size(139, 29)
        Me.personalnombre.TabIndex = 250
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(326, 336)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 14)
        Me.Label12.TabIndex = 249
        Me.Label12.Text = "Dni del lector"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(319, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 14)
        Me.Label8.TabIndex = 248
        Me.Label8.Text = "Apellido del lector"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(326, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 14)
        Me.Label7.TabIndex = 247
        Me.Label7.Text = "Nombre del lector"
        '
        'lectordni
        '
        Me.lectordni.Location = New System.Drawing.Point(301, 353)
        Me.lectordni.Multiline = True
        Me.lectordni.Name = "lectordni"
        Me.lectordni.Size = New System.Drawing.Size(147, 33)
        Me.lectordni.TabIndex = 246
        '
        'lectorap
        '
        Me.lectorap.Location = New System.Drawing.Point(310, 281)
        Me.lectorap.Multiline = True
        Me.lectorap.Name = "lectorap"
        Me.lectorap.Size = New System.Drawing.Size(154, 27)
        Me.lectorap.TabIndex = 245
        '
        'lectornombre
        '
        Me.lectornombre.Location = New System.Drawing.Point(310, 206)
        Me.lectornombre.Multiline = True
        Me.lectornombre.Name = "lectornombre"
        Me.lectornombre.Size = New System.Drawing.Size(142, 27)
        Me.lectornombre.TabIndex = 244
        '
        'dgvtodo
        '
        Me.dgvtodo.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.dgvtodo.CaptionBackColor = System.Drawing.Color.Peru
        Me.dgvtodo.CaptionFont = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvtodo.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvtodo.DataMember = ""
        Me.dgvtodo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgvtodo.Location = New System.Drawing.Point(35, 566)
        Me.dgvtodo.Name = "dgvtodo"
        Me.dgvtodo.ParentRowsBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.dgvtodo.PreferredColumnWidth = 94
        Me.dgvtodo.SelectionBackColor = System.Drawing.SystemColors.InactiveBorder
        Me.dgvtodo.Size = New System.Drawing.Size(1204, 158)
        Me.dgvtodo.TabIndex = 243
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(63, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 14)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "ESTADO DEVOLUCION"
        '
        'txtestadodevolucion
        '
        Me.txtestadodevolucion.Location = New System.Drawing.Point(55, 351)
        Me.txtestadodevolucion.Multiline = True
        Me.txtestadodevolucion.Name = "txtestadodevolucion"
        Me.txtestadodevolucion.Size = New System.Drawing.Size(153, 27)
        Me.txtestadodevolucion.TabIndex = 240
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(568, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 239
        Me.Label5.Text = "ID LIBRO"
        '
        'txtidlibro
        '
        Me.txtidlibro.Location = New System.Drawing.Point(529, 140)
        Me.txtidlibro.Name = "txtidlibro"
        Me.txtidlibro.Size = New System.Drawing.Size(118, 22)
        Me.txtidlibro.TabIndex = 238
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(420, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(268, 24)
        Me.Label11.TabIndex = 237
        Me.Label11.Text = "REGISTRO DE PRESTAMO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(548, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 14)
        Me.Label10.TabIndex = 236
        Me.Label10.Text = "ESTADO DE ENTREGA"
        '
        'txtestadoentrega
        '
        Me.txtestadoentrega.Location = New System.Drawing.Point(529, 359)
        Me.txtestadoentrega.Multiline = True
        Me.txtestadoentrega.Name = "txtestadoentrega"
        Me.txtestadoentrega.Size = New System.Drawing.Size(151, 27)
        Me.txtestadoentrega.TabIndex = 235
        '
        'dtmfechadevolucion
        '
        Me.dtmfechadevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfechadevolucion.Location = New System.Drawing.Point(54, 286)
        Me.dtmfechadevolucion.Name = "dtmfechadevolucion"
        Me.dtmfechadevolucion.Size = New System.Drawing.Size(151, 22)
        Me.dtmfechadevolucion.TabIndex = 234
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 14)
        Me.Label9.TabIndex = 233
        Me.Label9.Text = "FECHA DE DEVOLUCION"
        '
        'dtmfechaprestamo
        '
        Me.dtmfechaprestamo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmfechaprestamo.Location = New System.Drawing.Point(54, 206)
        Me.dtmfechaprestamo.Name = "dtmfechaprestamo"
        Me.dtmfechaprestamo.Size = New System.Drawing.Size(149, 22)
        Me.dtmfechaprestamo.TabIndex = 232
        '
        'DESPLAZAMIENTO
        '
        Me.DESPLAZAMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNSIGUIENTE)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNULTIMO)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNANTERIOR)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNPRIMERO)
        Me.DESPLAZAMIENTO.Location = New System.Drawing.Point(957, 580)
        Me.DESPLAZAMIENTO.Name = "DESPLAZAMIENTO"
        Me.DESPLAZAMIENTO.Size = New System.Drawing.Size(230, 64)
        Me.DESPLAZAMIENTO.TabIndex = 231
        Me.DESPLAZAMIENTO.TabStop = False
        Me.DESPLAZAMIENTO.Text = "DESPLAZAMIENTO"
        Me.DESPLAZAMIENTO.Visible = False
        '
        'BTNSIGUIENTE
        '
        Me.BTNSIGUIENTE.Location = New System.Drawing.Point(122, 22)
        Me.BTNSIGUIENTE.Name = "BTNSIGUIENTE"
        Me.BTNSIGUIENTE.Size = New System.Drawing.Size(44, 26)
        Me.BTNSIGUIENTE.TabIndex = 2
        Me.BTNSIGUIENTE.Text = ">"
        Me.BTNSIGUIENTE.UseVisualStyleBackColor = True
        '
        'BTNULTIMO
        '
        Me.BTNULTIMO.Location = New System.Drawing.Point(175, 22)
        Me.BTNULTIMO.Name = "BTNULTIMO"
        Me.BTNULTIMO.Size = New System.Drawing.Size(44, 26)
        Me.BTNULTIMO.TabIndex = 2
        Me.BTNULTIMO.Text = ">|"
        Me.BTNULTIMO.UseVisualStyleBackColor = True
        '
        'BTNANTERIOR
        '
        Me.BTNANTERIOR.Location = New System.Drawing.Point(75, 22)
        Me.BTNANTERIOR.Name = "BTNANTERIOR"
        Me.BTNANTERIOR.Size = New System.Drawing.Size(44, 26)
        Me.BTNANTERIOR.TabIndex = 1
        Me.BTNANTERIOR.Text = "<"
        Me.BTNANTERIOR.UseVisualStyleBackColor = True
        '
        'BTNPRIMERO
        '
        Me.BTNPRIMERO.Location = New System.Drawing.Point(10, 22)
        Me.BTNPRIMERO.Name = "BTNPRIMERO"
        Me.BTNPRIMERO.Size = New System.Drawing.Size(44, 26)
        Me.BTNPRIMERO.TabIndex = 0
        Me.BTNPRIMERO.Text = "l<"
        Me.BTNPRIMERO.UseVisualStyleBackColor = True
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNIMPRIMIR.FlatAppearance.BorderSize = 0
        Me.BTNIMPRIMIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNIMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(999, 481)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(112, 27)
        Me.BTNIMPRIMIR.TabIndex = 228
        Me.BTNIMPRIMIR.Text = "IMPRIMIR"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = False
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCANCELAR.FlatAppearance.BorderSize = 0
        Me.BTNCANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCELAR.Location = New System.Drawing.Point(892, 484)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(101, 24)
        Me.BTNCANCELAR.TabIndex = 227
        Me.BTNCANCELAR.Text = "CANCELAR GUARDADO"
        Me.BTNCANCELAR.UseVisualStyleBackColor = False
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMODIFICAR.FlatAppearance.BorderSize = 0
        Me.BTNMODIFICAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNMODIFICAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(785, 484)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(101, 24)
        Me.BTNMODIFICAR.TabIndex = 226
        Me.BTNMODIFICAR.Text = "MODIFICAR"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = False
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNGUARDAR.FlatAppearance.BorderSize = 0
        Me.BTNGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGUARDAR.Location = New System.Drawing.Point(892, 451)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(101, 27)
        Me.BTNGUARDAR.TabIndex = 225
        Me.BTNGUARDAR.Text = "GUARDAR"
        Me.BTNGUARDAR.UseVisualStyleBackColor = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNNUEVO.FlatAppearance.BorderSize = 0
        Me.BTNNUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNNUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNNUEVO.Location = New System.Drawing.Point(785, 451)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(101, 27)
        Me.BTNNUEVO.TabIndex = 224
        Me.BTNNUEVO.Text = "NUEVO"
        Me.BTNNUEVO.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 14)
        Me.Label4.TabIndex = 223
        Me.Label4.Text = "FECHA PRESTAMO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(751, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 14)
        Me.Label3.TabIndex = 222
        Me.Label3.Text = "ID PERSONAL"
        '
        'txtidpersonal
        '
        Me.txtidpersonal.Location = New System.Drawing.Point(760, 145)
        Me.txtidpersonal.Name = "txtidpersonal"
        Me.txtidpersonal.Size = New System.Drawing.Size(118, 22)
        Me.txtidpersonal.TabIndex = 221
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 14)
        Me.Label2.TabIndex = 220
        Me.Label2.Text = "ID LECTOR"
        '
        'txtidlector
        '
        Me.txtidlector.Location = New System.Drawing.Point(310, 140)
        Me.txtidlector.Name = "txtidlector"
        Me.txtidlector.Size = New System.Drawing.Size(142, 22)
        Me.txtidlector.TabIndex = 219
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "ID PRESTAMO"
        '
        'txtidprestamo
        '
        Me.txtidprestamo.Location = New System.Drawing.Point(56, 140)
        Me.txtidprestamo.Name = "txtidprestamo"
        Me.txtidprestamo.Size = New System.Drawing.Size(116, 22)
        Me.txtidprestamo.TabIndex = 217
        '
        'groupmain
        '
        Me.groupmain.BackColor = System.Drawing.Color.Transparent
        Me.groupmain.Controls.Add(Me.rdnbuspersonal)
        Me.groupmain.Controls.Add(Me.btnbuscardgv)
        Me.groupmain.Controls.Add(Me.Label25)
        Me.groupmain.Controls.Add(Me.rdnbuslibro)
        Me.groupmain.Controls.Add(Me.lblbuscar)
        Me.groupmain.Controls.Add(Me.Label22)
        Me.groupmain.Controls.Add(Me.rdnbuslector)
        Me.groupmain.Controls.Add(Me.txtbuscardgv)
        Me.groupmain.Controls.Add(Me.Label24)
        Me.groupmain.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupmain.Location = New System.Drawing.Point(35, 460)
        Me.groupmain.Name = "groupmain"
        Me.groupmain.Size = New System.Drawing.Size(413, 83)
        Me.groupmain.TabIndex = 271
        Me.groupmain.TabStop = False
        Me.groupmain.Text = "Buscar"
        '
        'rdnbuspersonal
        '
        Me.rdnbuspersonal.AutoSize = True
        Me.rdnbuspersonal.Location = New System.Drawing.Point(342, 15)
        Me.rdnbuspersonal.Name = "rdnbuspersonal"
        Me.rdnbuspersonal.Size = New System.Drawing.Size(14, 13)
        Me.rdnbuspersonal.TabIndex = 277
        Me.rdnbuspersonal.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(263, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 14)
        Me.Label25.TabIndex = 273
        Me.Label25.Text = "Personal"
        '
        'rdnbuslibro
        '
        Me.rdnbuslibro.AutoSize = True
        Me.rdnbuslibro.Location = New System.Drawing.Point(209, 15)
        Me.rdnbuslibro.Name = "rdnbuslibro"
        Me.rdnbuslibro.Size = New System.Drawing.Size(14, 13)
        Me.rdnbuslibro.TabIndex = 276
        Me.rdnbuslibro.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(167, 15)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 14)
        Me.Label22.TabIndex = 274
        Me.Label22.Text = "Libro"
        '
        'rdnbuslector
        '
        Me.rdnbuslector.AutoSize = True
        Me.rdnbuslector.Location = New System.Drawing.Point(113, 15)
        Me.rdnbuslector.Name = "rdnbuslector"
        Me.rdnbuslector.Size = New System.Drawing.Size(14, 13)
        Me.rdnbuslector.TabIndex = 275
        Me.rdnbuslector.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(64, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 14)
        Me.Label24.TabIndex = 272
        Me.Label24.Text = "Lector"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(114, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 274
        Me.Button1.Text = "BUSCAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(20, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 275
        Me.Label21.Text = " Lector:"
        '
        'txtbuslect
        '
        Me.txtbuslect.Location = New System.Drawing.Point(101, 16)
        Me.txtbuslect.Name = "txtbuslect"
        Me.txtbuslect.Size = New System.Drawing.Size(149, 22)
        Me.txtbuslect.TabIndex = 273
        '
        'grouplector
        '
        Me.grouplector.BackColor = System.Drawing.Color.Transparent
        Me.grouplector.Controls.Add(Me.Label21)
        Me.grouplector.Controls.Add(Me.txtbuslect)
        Me.grouplector.Controls.Add(Me.Button1)
        Me.grouplector.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grouplector.Location = New System.Drawing.Point(468, 459)
        Me.grouplector.Name = "grouplector"
        Me.grouplector.Size = New System.Drawing.Size(279, 84)
        Me.grouplector.TabIndex = 276
        Me.grouplector.TabStop = False
        Me.grouplector.Text = "Buscar"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.apps_printer_15747
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Yu Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(824, 372)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(53, 42)
        Me.Button2.TabIndex = 342
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.Button3.Location = New System.Drawing.Point(892, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 42)
        Me.Button3.TabIndex = 341
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Print
        '
        '
        'BOLETAA
        '
        '
        'FECHA
        '
        Me.FECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FECHA.Location = New System.Drawing.Point(412, 580)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(97, 22)
        Me.FECHA.TabIndex = 344
        '
        'prestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1246, 726)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.grouplector)
        Me.Controls.Add(Me.groupmain)
        Me.Controls.Add(Me.rdnpersonal)
        Me.Controls.Add(Me.rdnlibro)
        Me.Controls.Add(Me.rdnlector)
        Me.Controls.Add(Me.btnmostrartodo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtfechaentrega)
        Me.Controls.Add(Me.txtfechadevolucion)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.libroautor)
        Me.Controls.Add(Me.librotitulo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.personalap)
        Me.Controls.Add(Me.personalnombre)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lectordni)
        Me.Controls.Add(Me.lectorap)
        Me.Controls.Add(Me.lectornombre)
        Me.Controls.Add(Me.dgvtodo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtestadodevolucion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtidlibro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtestadoentrega)
        Me.Controls.Add(Me.dtmfechadevolucion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtmfechaprestamo)
        Me.Controls.Add(Me.DESPLAZAMIENTO)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtidpersonal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtidlector)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtidprestamo)
        Me.Controls.Add(Me.FECHA)
        Me.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "prestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "prestamo"
        CType(Me.dgvtodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DESPLAZAMIENTO.ResumeLayout(False)
        Me.groupmain.ResumeLayout(False)
        Me.groupmain.PerformLayout()
        Me.grouplector.ResumeLayout(False)
        Me.grouplector.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbuscar As System.Windows.Forms.Label
    Friend WithEvents btnbuscardgv As System.Windows.Forms.Button
    Friend WithEvents txtbuscardgv As System.Windows.Forms.TextBox
    Friend WithEvents rdnpersonal As System.Windows.Forms.RadioButton
    Friend WithEvents rdnlibro As System.Windows.Forms.RadioButton
    Friend WithEvents rdnlector As System.Windows.Forms.RadioButton
    Friend WithEvents btnmostrartodo As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtfechaentrega As System.Windows.Forms.TextBox
    Friend WithEvents txtfechadevolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents libroautor As System.Windows.Forms.TextBox
    Friend WithEvents librotitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents personalap As System.Windows.Forms.TextBox
    Friend WithEvents personalnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lectordni As System.Windows.Forms.TextBox
    Friend WithEvents lectorap As System.Windows.Forms.TextBox
    Friend WithEvents lectornombre As System.Windows.Forms.TextBox
    Friend WithEvents dgvtodo As System.Windows.Forms.DataGrid
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtestadodevolucion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtidlibro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtestadoentrega As System.Windows.Forms.TextBox
    Friend WithEvents dtmfechadevolucion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtmfechaprestamo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DESPLAZAMIENTO As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSIGUIENTE As System.Windows.Forms.Button
    Friend WithEvents BTNULTIMO As System.Windows.Forms.Button
    Friend WithEvents BTNANTERIOR As System.Windows.Forms.Button
    Private WithEvents BTNPRIMERO As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtidpersonal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidlector As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidprestamo As System.Windows.Forms.TextBox
    Friend WithEvents groupmain As System.Windows.Forms.GroupBox
    Friend WithEvents rdnbuspersonal As System.Windows.Forms.RadioButton
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents rdnbuslibro As System.Windows.Forms.RadioButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents rdnbuslector As System.Windows.Forms.RadioButton
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtbuslect As System.Windows.Forms.TextBox
    Friend WithEvents grouplector As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Print As System.Drawing.Printing.PrintDocument
    Friend WithEvents BOLETAA As System.Drawing.Printing.PrintDocument
    Friend WithEvents FECHA As System.Windows.Forms.DateTimePicker
End Class
