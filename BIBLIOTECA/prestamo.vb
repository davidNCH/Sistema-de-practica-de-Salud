Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class prestamo
    Inherits System.Windows.Forms.Form
    'Dim obj As New valida
    ' Dim cn As New SqlConnection("Data Source=SPADOW-PC\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True")
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=biblioteca;Integrated Security=True")
    'Private Cn As New SqlConnection("Data Source= DESKTOP-OQMPFF2\SQLEXPRESS ;Initial Catalog=biblioteca;Integrated Security=True")
    Private cmd As New SqlCommand("", Cn)
    Private stb As New StringBuilder()
    Private adaptador As SqlDataAdapter
    Private data As DataSet
    Private Fila As Integer
    Public reg, I, nroreg As Integer
    Dim dvw As New DataView
    Private pc As String
    Dim CLI As String
    Dim obj As New validacion
    Sub CONTROLA()
        Try
            data = New DataSet()
            Cn.Open()
            adaptador.Fill(data, "prestamo")
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ACTIVA()
        Dim X As Control
        For Each X In Controls
            dtmfechadevolucion.Enabled = True
            dtmfechaprestamo.Enabled = True
            txtestadodevolucion.Enabled = True

        Next
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtidprestamo.Enabled = False
        txtidlector.Enabled = False
        txtidpersonal.Enabled = False
        txtidlibro.Enabled = False
        dtmfechaprestamo.Enabled = False
        dtmfechadevolucion.Enabled = False
        txtestadoentrega.Enabled = False
        txtestadodevolucion.Enabled = False
        'GRBCONSULTAR.Visible = False
        DESPLAZAMIENTO.Visible = True
        grouplector.Visible = True
        groupmain.Visible = False
    End Sub
    Sub CUANDOLEE()
        BTNNUEVO.Enabled = True
        BTNCANCELAR.Enabled = False
        'BTNCONSULTAR.Enabled = True
        BTNMODIFICAR.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNIMPRIMIR.Enabled = True
        DESPLAZAMIENTO.Enabled = True
        btnmostrartodo.Visible = True
        '  btnseleccionar.Visible = False
        txtfechadevolucion.Visible = True
        txtfechaentrega.Visible = True
        'btncanceladgv.Visible = False
        rdnlector.Visible = False
        rdnlibro.Visible = False
        rdnpersonal.Visible = False
        grouplector.Visible = True
        groupmain.Visible = False
    End Sub
    Sub CUANDOINGRESA()
        BTNNUEVO.Enabled = False
        BTNCANCELAR.Enabled = True
        BTNMODIFICAR.Enabled = False
        BTNGUARDAR.Enabled = True

        BTNIMPRIMIR.Enabled = False
        DESPLAZAMIENTO.Enabled = False
        btnmostrartodo.Visible = False
        txtfechadevolucion.Visible = False
        txtfechaentrega.Visible = False
        'btnseleccionar.Visible = True
        ' btncanceladgv.Visible = True
        rdnlector.Visible = True
        rdnlibro.Visible = True
        rdnpersonal.Visible = True
        dtmfechaprestamo.Enabled = True
        dtmfechadevolucion.Enabled = True
        txtestadoentrega.Enabled = True
        txtestadodevolucion.Enabled = True
        rdnlector.Checked = False
        rdnlibro.Checked = False
        rdnpersonal.Checked = False
        grouplector.Visible = False
        groupmain.Visible = True
    End Sub
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        Dim HR As Timer
        oDataRow = data.Tables("prestamo").Rows(Fila)
        txtidprestamo.Text = oDataRow("id_prestamo")
        txtidlector.Text = oDataRow("id_lector")
        txtidpersonal.Text = oDataRow("id_personal")
        txtidlibro.Text = oDataRow("id_libro")
        dtmfechaprestamo.Text = oDataRow("fech_prestamo")
        dtmfechadevolucion.Text = oDataRow("fech_devolucion")
        txtestadoentrega.Text = oDataRow("estado_prestamo")
        txtestadodevolucion.Text = oDataRow("estado_devolucion")
    End Sub
    Private Sub libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rdnbuslector.PerformClick()
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM prestamo", cn)
        'btnmostrartodo.PerformClick()
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        CONTROLA()
        dvw = data.Tables(0).DefaultView()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            End If
        Next
        Fila = 0
        DESACTIVA()
        CUANDOLEE()
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        dgvtodo.DataSource = Nothing
        Dim NUM, NUM2 As Integer
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            End If
        Next
        txtidprestamo.Focus()
        I = 1
        ACTIVA()
        CUANDOINGRESA()
        BTNGUARDAR.Enabled = True
        NUM = data.Tables("prestamo").Rows.Count
        NUM = NUM + 1
        NUM2 = data.Tables("prestamo").Rows.Count
        NUM2 = NUM2 + 1
        txtidprestamo.Text = "PR" + NUM.ToString("000")
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If I = 1 Then
            If txtidprestamo.Text <> "" And txtidlector.Text <> "" And txtidpersonal.Text <> "" And txtidlibro.Text <> "" And txtestadoentrega.Text <> "" And txtestadodevolucion.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Insert Into prestamo (id_prestamo,id_lector,id_personal,fech_prestamo,fech_devolucion,id_libro,estado_prestamo,estado_devolucion )  Values ('")
                    stb.Append(txtidprestamo.Text)
                    stb.Append("','")
                    stb.Append(txtidlector.Text)
                    stb.Append("','")
                    stb.Append(txtidpersonal.Text)
                    stb.Append("','")
                    stb.Append(dtmfechaprestamo.Text)
                    stb.Append("','")
                    stb.Append(dtmfechadevolucion.Text)
                    stb.Append("','")
                    stb.Append(txtidlibro.Text)
                    stb.Append("','")
                    stb.Append(txtestadoentrega.Text)
                    stb.Append("','")
                    stb.Append(txtestadodevolucion.Text)
                    stb.Append("')")
                    cn.Open()
                    cmd.CommandText = stb.ToString
                    reg = cmd.ExecuteNonQuery()
                    If reg > 0 Then
                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
                        ' btnagregarimg.Enabled = False
                    Else
                        Throw New Exception("No se Pudo Guardar los Datos del Libro")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If cn.State = ConnectionState.Open Then cn.Close()
                    stb.Length = 0
                    CONTROLA()
                    Fila = 0
                    CARGARDATOS()
                    DESACTIVA()
                    CUANDOLEE()
                    'BTNPRIMERO.Focus()
                End Try
            Else
                MsgBox("Error falta ingresar datos")
            End If
        Else
            If txtidprestamo.Text <> "" And txtidlector.Text <> "" And txtidpersonal.Text <> "" And txtidlibro.Text <> "" And dtmfechaprestamo.Value <> "" And dtmfechadevolucion.Value <> "" And txtestadoentrega.Text <> "" And txtestadodevolucion.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Update prestamo set fech_prestamo='")
                    stb.Append(dtmfechaprestamo.Text)
                    stb.Append("',fech_devolucion='")
                    stb.Append(dtmfechadevolucion.Text)
                    stb.Append("',estado_entrega='")
                    stb.Append(txtestadoentrega.Text)
                    stb.Append("',estado_devolucion='")
                    stb.Append(txtestadodevolucion.Text)
                    stb.Append("',id_lector='")
                    stb.Append(txtidlector.Text)
                    stb.Append("',id_personal='")
                    stb.Append(txtidpersonal.Text)
                    stb.Append("',id_libro='")
                    stb.Append(txtidlibro.Text)
                    stb.Append("'WHERE id_prestamo='")
                    stb.Append(txtidprestamo.Text)
                    stb.Append("'")
                    cn.Open()
                    cmd.CommandText = stb.ToString
                    reg = cmd.ExecuteNonQuery()
                    If reg > 0 Then
                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
                    Else
                        Throw New Exception("No se Pudo Guardar los Datos del Libro")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If cn.State = ConnectionState.Open Then cn.Close()
                    stb.Length = 0
                    CONTROLA()
                    Fila = 0
                    CARGARDATOS()
                    DESACTIVA()
                    CUANDOLEE()
                    BTNPRIMERO.Focus()
                End Try
            End If
        End If
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        I = 2
        ACTIVA()
        CUANDOINGRESA()
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Fila = 0
        CARGARDATOS()
        DESACTIVA()
        CUANDOLEE()
        dgvtodo.DataSource = Nothing

    End Sub

    'Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
    '    Dim oDataRow As DataRow
    '    oDataRow = data.Tables("prestamo").Rows(Fila)
    '    If MessageBox.Show("Desea Eliminar el Registro", "prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
    '        oDataRow.Delete()
    '        Dim oTablaBorrados As DataTable
    '        oTablaBorrados = data.Tables("prestamo").GetChanges(DataRowState.Deleted)
    '        adaptador.Update(oTablaBorrados)
    '        data.Tables("prestamo").AcceptChanges()
    '        BTNPRIMERO.PerformClick()
    '        Exit Sub
    '    End If
    '    CONTROLA()

    '    'Dim j As Integer
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 0) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 1) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 2) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 3) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 4) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 5) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 6) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 7) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 8) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 9) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 10) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 11) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 12) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 13) = ""
    '    'dgvtodo.Item(dgvtodo.CurrentRowIndex, 14) = ""
    '    'For j = dgvtodo.CurrentRowIndex To 13
    '    '    dgvtodo.Item(j, 0) = dgvtodo.Item(j + 1, 0)
    '    '    dgvtodo.Item(j, 1) = dgvtodo.Item(j + 1, 1)
    '    '    dgvtodo.Item(j, 2) = dgvtodo.Item(j + 1, 2)
    '    '    dgvtodo.Item(j, 3) = dgvtodo.Item(j + 1, 3)
    '    '    dgvtodo.Item(j, 4) = dgvtodo.Item(j + 1, 4)
    '    '    dgvtodo.Item(j, 5) = dgvtodo.Item(j + 1, 5)
    '    '    dgvtodo.Item(j, 6) = dgvtodo.Item(j + 1, 6)
    '    '    dgvtodo.Item(j, 7) = dgvtodo.Item(j + 1, 7)
    '    '    dgvtodo.Item(j, 8) = dgvtodo.Item(j + 1, 8)
    '    '    dgvtodo.Item(j, 9) = dgvtodo.Item(j + 1, 9)
    '    '    dgvtodo.Item(j, 10) = dgvtodo.Item(j + 1, 10)
    '    '    dgvtodo.Item(j, 11) = dgvtodo.Item(j + 1, 11)
    '    '    dgvtodo.Item(j, 12) = dgvtodo.Item(j + 1, 12)
    '    '    dgvtodo.Item(j, 13) = dgvtodo.Item(j + 1, 13)
    '    '    dgvtodo.Item(j, 14) = dgvtodo.Item(j + 1, 14)
    '    'Next
    '    'nroreg = nroreg - 1
    '    'If nroreg < 0 Then
    '    '    nroreg = 0
    '    '    BTNELIMINAR.Enabled = False
    '    'End If
    '    'btnmostrartodo.PerformClick()
    'End Sub

    Private Sub BTNPRIMERO_Click(sender As Object, e As EventArgs) Handles BTNPRIMERO.Click
        Fila = 0
        CARGARDATOS()
    End Sub

    Private Sub BTNANTERIOR_Click(sender As Object, e As EventArgs) Handles BTNANTERIOR.Click
        If Fila = 0 Then
            MessageBox.Show("Primer Registro")
        Else
            Fila -= 1
            CARGARDATOS()

        End If
    End Sub

    Private Sub BTNSIGUIENTE_Click(sender As Object, e As EventArgs) Handles BTNSIGUIENTE.Click
        If Fila = (data.Tables("prestamo").Rows.Count - 1) Then
            MessageBox.Show("Ultimo Registro")
        Else
            Fila += 1
            CARGARDATOS()
            ' CALCULA()
        End If
    End Sub

    Private Sub BTNULTIMO_Click(sender As Object, e As EventArgs) Handles BTNULTIMO.Click
        Fila = (data.Tables("prestamo").Rows.Count - 1)
        CARGARDATOS()
    End Sub

    Private Sub btnexaminar_Click(sender As Object, e As EventArgs) Handles btnmostrartodo.Click
        Dim oclientes As New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',personal.nombre as 'Nombre Personal',personal.apellidos as 'Apellido Personal',prestamo.fech_prestamo as 'Fecha Prestamo',prestamo.fech_devolucion as 'Fecha Devolucion',prestamo.estado_prestamo as 'Estado Prestamo',prestamo.estado_devolucion as 'Estado Devolucion',prestamo.id_prestamo,prestamo.id_lector,prestamo.id_personal,prestamo.id_libro" & _
        " from prestamo inner join lector on prestamo.id_lector=lector.id_lector inner join libros on prestamo.id_libro=libros.id_libro inner join personal on prestamo.id_personal=personal.id_personal", cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "prestamo")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "prestamo"
        dgvtodo.Visible = True
    End Sub

    Private Sub dgvtodo_Click(sender As Object, e As EventArgs) Handles dgvtodo.Click
        If rdnlector.Checked = True Then
            txtidlector.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            lectornombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            lectorap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
            lectordni.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
        End If
        If rdnlibro.Checked = True Then
            txtidlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            librotitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            libroautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
        End If
        If rdnpersonal.Checked = True Then
            txtidpersonal.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            personalnombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            personalap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
        End If
    End Sub

    Private Sub dgv2_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvtodo.CurrentCellChanged
        Try
            If (btnmostrartodo.Visible = True) Then
                lectornombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
                lectorap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
                lectordni.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
                librotitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
                libroautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
                personalnombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 5)
                personalap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 6)
                txtfechadevolucion.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 7)
                txtfechaentrega.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 8)
                txtestadoentrega.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 9)
                txtestadodevolucion.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 10)
                txtidprestamo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 11)
                txtidlector.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 12)
                txtidpersonal.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 13)
                txtidlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 14)
                'CLI = dgv2.Item(dgv2.CurrentRowIndex, 0)
                'dgv2.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub rdnlector_Click(sender As Object, e As EventArgs) Handles rdnlector.Click
        lblbuscar.Text = "Buscar lector :"
        rdnbuslector.Checked = True
        txtbuscardgv.Text = ""
        If rdnlector.Checked = True Then
            dgvtodo.DataSource = Nothing
            Dim oclector As New SqlDataAdapter("SELECT id_lector,nombre,apellido,sexo,dni,ocupacion,fecha_nacimiento,fecha_inscripcion from lector ", cn)
            Dim odataset As New DataSet()
            oclector.Fill(odataset, "lector")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "lector"
        End If
    End Sub
    Private Sub rdnlibro_Click(sender As Object, e As EventArgs) Handles rdnlibro.Click
        lblbuscar.Text = "Buscar libro: "
        rdnbuslibro.Checked = True
        txtbuscardgv.Text = ""
        If rdnlibro.Checked = True Then
            dgvtodo.DataSource = Nothing
            Dim oclector As New SqlDataAdapter("SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion,editorial,modo_adquisicion,fecha_adquisicion from libros ", cn)
            Dim odataset As New DataSet()
            oclector.Fill(odataset, "libros")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "libros"
        End If
    End Sub
    Private Sub rdnpersonal_Click(sender As Object, e As EventArgs) Handles rdnpersonal.Click
        lblbuscar.Text = "Buscar personal :"
        rdnbuspersonal.Checked = True
        txtbuscardgv.Text = ""
        If rdnpersonal.Checked = True Then
            dgvtodo.DataSource = Nothing
            Dim oclector As New SqlDataAdapter("SELECT id_personal,nombre,apellidos,dni,sexo,direccion,cargo from personal ", cn)
            Dim odataset As New DataSet()
            oclector.Fill(odataset, "personal")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "personal"
        End If
    End Sub

    Private Sub btnbuscardgv_Click(sender As Object, e As EventArgs) Handles btnbuscardgv.Click
        If rdnbuslector.Checked = True Then
            Dim oclientes As New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',personal.nombre as 'Nombre Personal',personal.apellidos as 'Apellido Personal',prestamo.fech_prestamo as 'Fecha Prestamo',prestamo.fech_devolucion as 'Fecha Devolucion',prestamo.estado_prestamo as 'Estado Prestamo',prestamo.estado_devolucion as 'Estado Devolucion',prestamo.id_prestamo,prestamo.id_lector,prestamo.id_personal,prestamo.id_libro" & _
" from prestamo inner join lector on prestamo.id_lector=lector.id_lector inner join libros on prestamo.id_libro=libros.id_libro inner join personal on prestamo.id_personal=personal.id_personal where lector.nombre like '" & txtbuscardgv.Text & "%'", cn)
            'dgvtodo.DataMember = "Prestamo"
            Dim odataset As New DataSet()
            oclientes.Fill(odataset, "prestamo")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "prestamo"
        End If
        If rdnbuslibro.Checked = True Then
            Dim oclientes As New SqlDataAdapter("SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion as 'Año de edicion',editorial,modo_adquisicion,fecha_adquisicion from libros where titulo like'" & txtbuscardgv.Text & "%'", cn)
            'dgvtodo.DataMember = "Prestamo"
            Dim odataset As New DataSet()
            oclientes.Fill(odataset, "libros")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "libros"
        End If
        If rdnbuspersonal.Checked = True Then
            Dim oclientes As New SqlDataAdapter("SELECT id_personal,nombre,apellidos,dni,sexo,direccion,cargo from personal where nombre like '" & txtbuscardgv.Text & "%'", cn)
            'dgvtodo.DataMember = "Prestamo"
            Dim odataset As New DataSet()
            oclientes.Fill(odataset, "personal")
            dgvtodo.DataSource = odataset
            dgvtodo.DataMember = "personal"
        End If
    End Sub

    Private Sub txtbuscardgv_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuscardgv.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnbuscardgv.PerformClick()
        End If
    End Sub
    Private Sub dtmfechaprestamo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtmfechaprestamo.KeyPress
        obj.fechas(dtmfechaprestamo, e, dtmfechadevolucion)
    End Sub
    Private Sub dtmfechadevolucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtmfechadevolucion.KeyPress
        obj.fechas(dtmfechadevolucion, e, dtmfechaprestamo)
    End Sub

    Private Sub txtestadodevolucion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestadodevolucion.KeyPress
        obj.mixto(txtestadodevolucion, e, txtestadoentrega)
    End Sub

    Private Sub txtestadoentrega_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestadoentrega.KeyPress
        obj.mixto(txtestadoentrega, e, txtestadoentrega)
    End Sub

    Private Sub dgvtodo_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvtodo.MouseClick
        If rdnlector.Checked = True Then
            txtidlector.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            lectornombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            lectorap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
            lectordni.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
        End If
        If rdnlibro.Checked = True Then
            txtidlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            librotitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            libroautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
        End If
        If rdnpersonal.Checked = True Then
            txtidpersonal.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            personalnombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            personalap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
        End If
    End Sub

    Private Sub dgvtodo_Navigate(sender As Object, ne As NavigateEventArgs) Handles dgvtodo.Navigate
        If rdnlector.Checked = True Then
            txtidlector.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            lectornombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            lectorap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
            lectordni.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
        End If
        If rdnlibro.Checked = True Then
            txtidlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            librotitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            libroautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
        End If
        If rdnpersonal.Checked = True Then
            txtidpersonal.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
            personalnombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
            personalap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
        End If
    End Sub

    Private Sub rdnbuslector_Click(sender As Object, e As EventArgs) Handles rdnbuslector.Click
        lblbuscar.Text = "Buscar lector :"
    End Sub

    Private Sub rdnbuslibro_Click(sender As Object, e As EventArgs) Handles rdnbuslibro.Click
        lblbuscar.Text = "Buscar libro: "
    End Sub
    Private Sub rdnbuspersonal_Click(sender As Object, e As EventArgs) Handles rdnbuspersonal.Click
        lblbuscar.Text = "Buscar personal :"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim oclientes As New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',personal.nombre as 'Nombre Personal',personal.apellidos as 'Apellido Personal',prestamo.fech_prestamo as 'Fecha Prestamo',prestamo.fech_devolucion as 'Fecha Devolucion',prestamo.estado_prestamo as 'Estado Prestamo',prestamo.estado_devolucion as 'Estado Devolucion',prestamo.id_prestamo,prestamo.id_lector,prestamo.id_personal,prestamo.id_libro" & _
" from prestamo inner join lector on prestamo.id_lector=lector.id_lector inner join libros on prestamo.id_libro=libros.id_libro inner join personal on prestamo.id_personal=personal.id_personal where lector.nombre like '" & txtbuslect.Text & "%'", cn)
        'dgvtodo.DataMember = "Prestamo"
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "prestamo")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "prestamo"
    End Sub

    Private Sub txtbuslect_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbuslect.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
    Private Sub Print_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles Print.PrintPage
    '    Dim i As Integer
    '    Dim texto As String
    '    Dim fuente As New Font("Courier New", 8)

    '    Dim brocha As Brush = Brushes.Black

    '    Dim x As Integer = e.MarginBounds.Left = 10
    '    Dim y As Integer = e.MarginBounds.Top = 10
    '    texto = "                                      BOLETA DE RECIBO LIBRERIA GAAAA                                  "
    '    e.Graphics.DrawString(texto, fuente, brocha, x, y)
    '    y = y + fuente.GetHeight
    '    stb.Length = 0
    '    texto = "---------------------------------------------------------------------------------------------------------------------------"
    '    e.Graphics.DrawString(texto, fuente, brocha, x, y)
    '    y = y + fuente.GetHeight
    '    stb.Length = 0
    '    texto = "  DNI lECTOR          TITULO LIB                   FECHA PRES.        FECHA DEV.      NOMBRE PERS.     APELLIDO PERS            "
    '    e.Graphics.DrawString(texto, fuente, brocha, x, y)
    '    y = y + fuente.GetHeight
    '    stb.Length = 0
    '    texto = "---------------------------------------------------------------------------------------------------------------------------"
    '    e.Graphics.DrawString(texto, fuente, brocha, x, y)
    '    y = y + fuente.GetHeight
    '    stb.Length = 0
    '    For i = 0 To dvw.Count - 1

    '        stb.Append("    ".ToString.PadLeft(1))
    '        stb.Append(dvw(i)(0).ToString.PadRight(12))
    '        stb.Append(dvw(i)(1).ToString.PadRight(34))
    '        stb.Append(dvw(i)(2).ToString.PadRight(19))
    '        stb.Append(dvw(i)(3).ToString.PadRight(17))
    '        stb.Append(dvw(i)(4).ToString.PadRight(15))
    '        stb.Append(dvw(i)(5).ToString.PadRight(15))
    '        texto = stb.ToString
    '        e.Graphics.DrawString(texto, fuente, brocha, x, y)
    '        y = y + fuente.GetHeight
    '        stb.Length = 0
    '    Next
        Dim i As Integer
        Dim texto As String
        Dim fuente As New Font("courier new", 12)
        Dim brocha As Brush = Brushes.Black
        Dim x As Integer = e.MarginBounds.Left = 30
        Dim y As Integer = e.MarginBounds.Top = 5
        texto = "                                 BOLETA   DE   RECIBO                                   "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 30
        stb.Length = 0
        Dim asfuente1 As New Font("courier new", 9)
        texto = "                    LIBRERIA    PONY DE LAS VEGAS                 Nº: " + txtidprestamo.Text
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 18
        texto = "                   DE: LAS PALOMAS PERDIDAS       "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 18
        texto = "                   DIRECCION: AV.LAS MALVINAS Nº 201    "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 25
        texto = " SEÑOR(A) : " + lectornombre.Text + "  " + lectorap.Text
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 30
        texto = " DNI : " + lectordni.Text
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 30
        texto = " FECHA : " + FECHA.Value
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 30

        texto = "------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        texto = "                               DESCRIPCION  "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + 40
        texto = "------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        texto = "   TITULO LIB                  FECHA PRES.        FECHA DEV.       NOMBRE PERS.          "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0

        'If (lectornombre.Text) Then

        stb.Append(" ".ToString.PadLeft(1))
        stb.Append(librotitulo.Text.PadRight(30))
        stb.Append(dtmfechaprestamo.Text.PadRight(19))
        stb.Append(dtmfechadevolucion.Text.PadRight(17))
        stb.Append(personalnombre.Text.PadRight(12))
        texto = stb.ToString
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        'End If


    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT lector.dni , libros.titulo , prestamo.fech_prestamo, prestamo.fech_devolucion, personal.nombre,personal.apellidos from prestamo inner join lector on lector.id_lector=prestamo.id_lector inner join libros on libros.id_libro=prestamo.id_libro inner join personal on personal.id_personal=prestamo.id_personal ", cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        cn.Open()
        adaptador.Fill(data, "prestamo")
        cn.Close()
        dvw = data.Tables(0).DefaultView()
        Dim ppc As New PrintPreviewControl 'vista preliminar
        ppc.Document = Print() 'print es el nombre del objeto
        ppc.Zoom = 1 'zoom tamaño normal
        ppc.Dock = DockStyle.Fill 'bordes de la pagina
        Dim frmprevio As New Form
        With frmprevio
            .Text = "VISTA PREVIA DEL REPORTE"
            .WindowState = FormWindowState.Maximized
            .Controls.Add(ppc)
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dvw.Count > 1 Then
            BOLETAA.Print()
        Else
            MsgBox("Debe pulsar primero el Botón REPORTE o no hay Registros en la Tabla", MsgBoxStyle.Question)
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles BOLETAA.PrintPage

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs)
        BOLETAA.Print()
    End Sub
End Class