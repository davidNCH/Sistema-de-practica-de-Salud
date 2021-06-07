<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libros
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
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.dtpedicion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txteditorial = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtestado = New System.Windows.Forms.TextBox()
        Me.dtpadquisicion = New System.Windows.Forms.DateTimePicker()
        Me.txtmetodo = New System.Windows.Forms.TextBox()
        Me.DESPLAZAMIENTO = New System.Windows.Forms.GroupBox()
        Me.BTNSIGUIENTE = New System.Windows.Forms.Button()
        Me.BTNULTIMO = New System.Windows.Forms.Button()
        Me.BTNANTERIOR = New System.Windows.Forms.Button()
        Me.BTNPRIMERO = New System.Windows.Forms.Button()
        Me.GRBCONSULTAR = New System.Windows.Forms.GroupBox()
        Me.BTNBUSCAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNCONSULTAR = New System.Windows.Forms.Button()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
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
        Me.txtdisponible = New System.Windows.Forms.TextBox()
        Me.DESPLAZAMIENTO.SuspendLayout()
        Me.GRBCONSULTAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Location = New System.Drawing.Point(31, 24)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(103, 20)
        Me.TXTBUSCAR.TabIndex = 0
        '
        'dtpedicion
        '
        Me.dtpedicion.Location = New System.Drawing.Point(78, 291)
        Me.dtpedicion.Name = "dtpedicion"
        Me.dtpedicion.Size = New System.Drawing.Size(100, 20)
        Me.dtpedicion.TabIndex = 151
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Consolas", 17.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(324, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(246, 27)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "REGISTRO DE LIBROS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 149
        Me.Label10.Text = "EDITORIAL"
        '
        'txteditorial
        '
        Me.txteditorial.Location = New System.Drawing.Point(202, 291)
        Me.txteditorial.Name = "txteditorial"
        Me.txteditorial.Size = New System.Drawing.Size(151, 20)
        Me.txteditorial.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 258)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 18)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "AÑO DE EDICION"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(728, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "ESTADO"
        '
        'txtestado
        '
        Me.txtestado.Location = New System.Drawing.Point(678, 189)
        Me.txtestado.Name = "txtestado"
        Me.txtestado.Size = New System.Drawing.Size(162, 20)
        Me.txtestado.TabIndex = 145
        '
        'dtpadquisicion
        '
        Me.dtpadquisicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpadquisicion.Location = New System.Drawing.Point(334, 191)
        Me.dtpadquisicion.Name = "dtpadquisicion"
        Me.dtpadquisicion.Size = New System.Drawing.Size(99, 20)
        Me.dtpadquisicion.TabIndex = 144
        '
        'txtmetodo
        '
        Me.txtmetodo.Location = New System.Drawing.Point(64, 189)
        Me.txtmetodo.Multiline = True
        Me.txtmetodo.Name = "txtmetodo"
        Me.txtmetodo.Size = New System.Drawing.Size(150, 22)
        Me.txtmetodo.TabIndex = 143
        '
        'DESPLAZAMIENTO
        '
        Me.DESPLAZAMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNSIGUIENTE)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNULTIMO)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNANTERIOR)
        Me.DESPLAZAMIENTO.Controls.Add(Me.BTNPRIMERO)
        Me.DESPLAZAMIENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESPLAZAMIENTO.Location = New System.Drawing.Point(424, 386)
        Me.DESPLAZAMIENTO.Name = "DESPLAZAMIENTO"
        Me.DESPLAZAMIENTO.Size = New System.Drawing.Size(197, 59)
        Me.DESPLAZAMIENTO.TabIndex = 142
        Me.DESPLAZAMIENTO.TabStop = False
        Me.DESPLAZAMIENTO.Text = "DESPLAZAMIENTO"
        '
        'BTNSIGUIENTE
        '
        Me.BTNSIGUIENTE.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources._64491
        Me.BTNSIGUIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSIGUIENTE.FlatAppearance.BorderSize = 0
        Me.BTNSIGUIENTE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNSIGUIENTE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNSIGUIENTE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNSIGUIENTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSIGUIENTE.ForeColor = System.Drawing.Color.Transparent
        Me.BTNSIGUIENTE.Location = New System.Drawing.Point(105, 20)
        Me.BTNSIGUIENTE.Name = "BTNSIGUIENTE"
        Me.BTNSIGUIENTE.Size = New System.Drawing.Size(38, 24)
        Me.BTNSIGUIENTE.TabIndex = 2
        Me.BTNSIGUIENTE.UseVisualStyleBackColor = True
        '
        'BTNULTIMO
        '
        Me.BTNULTIMO.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources._108528
        Me.BTNULTIMO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNULTIMO.FlatAppearance.BorderSize = 0
        Me.BTNULTIMO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNULTIMO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNULTIMO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNULTIMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNULTIMO.ForeColor = System.Drawing.Color.Transparent
        Me.BTNULTIMO.Location = New System.Drawing.Point(150, 20)
        Me.BTNULTIMO.Name = "BTNULTIMO"
        Me.BTNULTIMO.Size = New System.Drawing.Size(38, 24)
        Me.BTNULTIMO.TabIndex = 2
        Me.BTNULTIMO.UseVisualStyleBackColor = True
        '
        'BTNANTERIOR
        '
        Me.BTNANTERIOR.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources._108524
        Me.BTNANTERIOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNANTERIOR.FlatAppearance.BorderSize = 0
        Me.BTNANTERIOR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNANTERIOR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNANTERIOR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNANTERIOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNANTERIOR.ForeColor = System.Drawing.Color.Transparent
        Me.BTNANTERIOR.Location = New System.Drawing.Point(64, 20)
        Me.BTNANTERIOR.Name = "BTNANTERIOR"
        Me.BTNANTERIOR.Size = New System.Drawing.Size(38, 24)
        Me.BTNANTERIOR.TabIndex = 1
        Me.BTNANTERIOR.UseVisualStyleBackColor = True
        '
        'BTNPRIMERO
        '
        Me.BTNPRIMERO.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources._45206
        Me.BTNPRIMERO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNPRIMERO.FlatAppearance.BorderSize = 0
        Me.BTNPRIMERO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BTNPRIMERO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTNPRIMERO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTNPRIMERO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPRIMERO.ForeColor = System.Drawing.Color.Transparent
        Me.BTNPRIMERO.Location = New System.Drawing.Point(9, 20)
        Me.BTNPRIMERO.Name = "BTNPRIMERO"
        Me.BTNPRIMERO.Size = New System.Drawing.Size(38, 24)
        Me.BTNPRIMERO.TabIndex = 0
        Me.BTNPRIMERO.UseVisualStyleBackColor = True
        '
        'GRBCONSULTAR
        '
        Me.GRBCONSULTAR.BackColor = System.Drawing.Color.Transparent
        Me.GRBCONSULTAR.Controls.Add(Me.BTNBUSCAR)
        Me.GRBCONSULTAR.Controls.Add(Me.TXTBUSCAR)
        Me.GRBCONSULTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBCONSULTAR.Location = New System.Drawing.Point(627, 386)
        Me.GRBCONSULTAR.Name = "GRBCONSULTAR"
        Me.GRBCONSULTAR.Size = New System.Drawing.Size(157, 98)
        Me.GRBCONSULTAR.TabIndex = 141
        Me.GRBCONSULTAR.TabStop = False
        Me.GRBCONSULTAR.Text = "CONSULTA"
        Me.GRBCONSULTAR.Visible = False
        '
        'BTNBUSCAR
        '
        Me.BTNBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNBUSCAR.Location = New System.Drawing.Point(45, 50)
        Me.BTNBUSCAR.Name = "BTNBUSCAR"
        Me.BTNBUSCAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNBUSCAR.TabIndex = 1
        Me.BTNBUSCAR.Text = "BUSCAR"
        Me.BTNBUSCAR.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.FlatAppearance.BorderSize = 0
        Me.BTNELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(329, 386)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNELIMINAR.TabIndex = 139
        Me.BTNELIMINAR.Text = "ELIMINAR"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'BTNCONSULTAR
        '
        Me.BTNCONSULTAR.FlatAppearance.BorderSize = 0
        Me.BTNCONSULTAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCONSULTAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCONSULTAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCONSULTAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCONSULTAR.Location = New System.Drawing.Point(236, 417)
        Me.BTNCONSULTAR.Name = "BTNCONSULTAR"
        Me.BTNCONSULTAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNCONSULTAR.TabIndex = 138
        Me.BTNCONSULTAR.Text = "CONSULTAR"
        Me.BTNCONSULTAR.UseVisualStyleBackColor = True
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.FlatAppearance.BorderSize = 0
        Me.BTNIMPRIMIR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNIMPRIMIR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNIMPRIMIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNIMPRIMIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(236, 386)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(87, 25)
        Me.BTNIMPRIMIR.TabIndex = 137
        Me.BTNIMPRIMIR.Text = "IMPRIMIR"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.FlatAppearance.BorderSize = 0
        Me.BTNCANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(141, 417)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNCANCELAR.TabIndex = 136
        Me.BTNCANCELAR.Text = "CANCELAR"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.FlatAppearance.BorderSize = 0
        Me.BTNMODIFICAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMODIFICAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNMODIFICAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNMODIFICAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(44, 417)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNMODIFICAR.TabIndex = 135
        Me.BTNMODIFICAR.Text = "MODIFICAR"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.FlatAppearance.BorderSize = 0
        Me.BTNGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(141, 386)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(87, 25)
        Me.BTNGUARDAR.TabIndex = 134
        Me.BTNGUARDAR.Text = "GUARDAR"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.FlatAppearance.BorderSize = 0
        Me.BTNNUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNNUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNNUEVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(44, 386)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(87, 25)
        Me.BTNNUEVO.TabIndex = 133
        Me.BTNNUEVO.Text = "NUEVO"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(536, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "NRO PAGINAS"
        '
        'txtnropag
        '
        Me.txtnropag.Location = New System.Drawing.Point(534, 191)
        Me.txtnropag.Name = "txtnropag"
        Me.txtnropag.Size = New System.Drawing.Size(92, 20)
        Me.txtnropag.TabIndex = 131
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 18)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "FECHA ADQUICION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 18)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "METODO ADQUICION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(734, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 18)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "AUTOR"
        '
        'txtautor
        '
        Me.txtautor.Location = New System.Drawing.Point(667, 111)
        Me.txtautor.Name = "txtautor"
        Me.txtautor.Size = New System.Drawing.Size(177, 20)
        Me.txtautor.TabIndex = 127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(477, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "GENERO"
        '
        'txtgenero
        '
        Me.txtgenero.Location = New System.Drawing.Point(424, 111)
        Me.txtgenero.Name = "txtgenero"
        Me.txtgenero.Size = New System.Drawing.Size(175, 20)
        Me.txtgenero.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(252, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "TITULO"
        '
        'txttitulo
        '
        Me.txttitulo.Location = New System.Drawing.Point(202, 111)
        Me.txttitulo.Name = "txttitulo"
        Me.txttitulo.Size = New System.Drawing.Size(175, 20)
        Me.txttitulo.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "ID LIBRO"
        '
        'txtlibro
        '
        Me.txtlibro.Location = New System.Drawing.Point(68, 111)
        Me.txtlibro.Name = "txtlibro"
        Me.txtlibro.Size = New System.Drawing.Size(100, 20)
        Me.txtlibro.TabIndex = 121
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(405, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 155
        Me.Label12.Text = "DISPONIBLE"
        '
        'txtdisponible
        '
        Me.txtdisponible.Location = New System.Drawing.Point(400, 291)
        Me.txtdisponible.Name = "txtdisponible"
        Me.txtdisponible.Size = New System.Drawing.Size(82, 20)
        Me.txtdisponible.TabIndex = 154
        '
        'libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BIBLIOTECA.My.Resources.Resources.ind
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(866, 508)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtdisponible)
        Me.Controls.Add(Me.dtpedicion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txteditorial)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtestado)
        Me.Controls.Add(Me.dtpadquisicion)
        Me.Controls.Add(Me.txtmetodo)
        Me.Controls.Add(Me.DESPLAZAMIENTO)
        Me.Controls.Add(Me.GRBCONSULTAR)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNCONSULTAR)
        Me.Controls.Add(Me.BTNIMPRIMIR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.BTNMODIFICAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNNUEVO)
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
        Me.Name = "libros"
        Me.Text = "libros"
        Me.DESPLAZAMIENTO.ResumeLayout(False)
        Me.GRBCONSULTAR.ResumeLayout(False)
        Me.GRBCONSULTAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXTBUSCAR As System.Windows.Forms.TextBox
    Friend WithEvents dtpedicion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txteditorial As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtestado As System.Windows.Forms.TextBox
    Friend WithEvents dtpadquisicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtmetodo As System.Windows.Forms.TextBox
    Friend WithEvents DESPLAZAMIENTO As System.Windows.Forms.GroupBox
    Friend WithEvents BTNSIGUIENTE As System.Windows.Forms.Button
    Friend WithEvents BTNULTIMO As System.Windows.Forms.Button
    Friend WithEvents BTNANTERIOR As System.Windows.Forms.Button
    Private WithEvents BTNPRIMERO As System.Windows.Forms.Button
    Friend WithEvents GRBCONSULTAR As System.Windows.Forms.GroupBox
    Friend WithEvents BTNBUSCAR As System.Windows.Forms.Button
    Friend WithEvents BTNELIMINAR As System.Windows.Forms.Button
    Friend WithEvents BTNCONSULTAR As System.Windows.Forms.Button
    Friend WithEvents BTNIMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents BTNCANCELAR As System.Windows.Forms.Button
    Friend WithEvents BTNMODIFICAR As System.Windows.Forms.Button
    Friend WithEvents BTNGUARDAR As System.Windows.Forms.Button
    Friend WithEvents BTNNUEVO As System.Windows.Forms.Button
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
    Friend WithEvents txtdisponible As System.Windows.Forms.TextBox
End Class
