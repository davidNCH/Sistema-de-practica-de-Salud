Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class libros
    Inherits System.Windows.Forms.Form
    Dim validar As New validacion
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=biblioteca;Integrated Security=True")
    'Private Cn As New SqlConnection("Data Source= DESKTOP-OQMPFF2\SQLEXPRESS ;Initial Catalog=BIBLIOTECA;Integrated Security=True")
    Private cmd As New SqlCommand("", cn)
    Private stb As New StringBuilder()
    Private adaptador As SqlDataAdapter
    Private data As DataSet
    Private Fila As Integer
    Public reg, I As Integer
    Dim dvw As New DataView
    Private pc As String
    Sub CONTROLA()
        Try
            data = New DataSet()
            cn.Open()
            adaptador.Fill(data, "libros")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub ACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = True
            End If
        Next
        txtautor.Enabled = True
        txteditorial.Enabled = True
        txtestado.Enabled = True
        txtgenero.Enabled = True
        txtlibro.Enabled = False
        txtmetodo.Enabled = True
        txtnropag.Enabled = True
        txttitulo.Enabled = True
        dtpadquisicion.Enabled = True
        dtpedicion.Enabled = True
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtautor.Enabled = False
        txteditorial.Enabled = False
        txtestado.Enabled = False
        txtgenero.Enabled = False
        txtlibro.Enabled = False
        txtmetodo.Enabled = False
        txtnropag.Enabled = False
        txttitulo.Enabled = False
        dtpadquisicion.Enabled = False
        dtpedicion.Enabled = False
        GRBCONSULTAR.Visible = False
        DESPLAZAMIENTO.Visible = True
    End Sub
    Sub CUANDOLEE()
        BTNNUEVO.Enabled = True
        BTNCANCELAR.Enabled = False
        BTNCONSULTAR.Enabled = True
        BTNMODIFICAR.Enabled = True
        BTNGUARDAR.Enabled = False
        BTNIMPRIMIR.Enabled = True
        DESPLAZAMIENTO.Enabled = True
    End Sub
    Sub CUANDOINGRESA()
        BTNNUEVO.Enabled = False
        BTNCANCELAR.Enabled = True
        BTNMODIFICAR.Enabled = False
        BTNGUARDAR.Enabled = True
        BTNCONSULTAR.Enabled = False
        BTNIMPRIMIR.Enabled = False
        DESPLAZAMIENTO.Enabled = False
    End Sub
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        Dim fecha As String
        fecha = dtpadquisicion.Value.Date
        oDataRow = data.Tables("libros").Rows(Fila)
        txtautor.Text = oDataRow("autor")
        txteditorial.Text = oDataRow("editorial")
        txtestado.Text = oDataRow("estado")
        txtgenero.Text = oDataRow("genero")
        txtlibro.Text = oDataRow("id_libro")
        txtmetodo.Text = oDataRow("modo_adquisicion")
        txttitulo.Text = oDataRow("titulo")
        fecha = oDataRow("fecha_adquisicion")
        dtpedicion.Text = oDataRow("año_d_edicion")
        txtnropag.Text = oDataRow("nro_paginas")
        txtdisponible.Text = oDataRow("disponible")
    End Sub


    Private Sub libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM libros", cn)
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
        CARGARDATOS()
        DESACTIVA()
        CUANDOLEE()
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        Dim NUM, NUM2 As Integer
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            End If
        Next
        txtlibro.Focus()
        I = 1
        ACTIVA()
        CUANDOINGRESA()
        BTNGUARDAR.Enabled = True
        NUM = data.Tables("libros").Rows.Count
        NUM = NUM + 1
        NUM2 = data.Tables("libros").Rows.Count
        NUM2 = NUM2 + 1
        txtlibro.Text = "L" + NUM.ToString("0000")
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        Dim fecha As String
        fecha = dtpadquisicion.Value.Date
        If I = 1 Then
            If txtautor.Text <> "" And txteditorial.Text <> "" And txtestado.Text <> "" And txtgenero.Text <> "" And txtlibro.Text <> "" And txtmetodo.Text <> "" And txtnropag.Text <> "" And txttitulo.Text <> "" And dtpedicion.Text <> "" And txtdisponible.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Insert Into libros (autor,editorial,estado,genero,id_libro,modo_adquisicion,nro_paginas,titulo,fecha_adquisicion,año_d_edicion,disponible)  Values ('")
                    stb.Append(txtautor.Text)
                    stb.Append("','")
                    stb.Append(txteditorial.Text)
                    stb.Append("','")
                    stb.Append(txtestado.Text)
                    stb.Append("','")
                    stb.Append(txtgenero.Text)
                    stb.Append("','")
                    stb.Append(txtlibro.Text)
                    stb.Append("','")
                    stb.Append(txtmetodo.Text)
                    stb.Append("','")
                    stb.Append(txtnropag.Text)
                    stb.Append("','")
                    stb.Append(txttitulo.Text)
                    stb.Append("','")
                    stb.Append(fecha)
                    stb.Append("','")
                    stb.Append(dtpedicion.Text)
                    stb.Append("','")
                    stb.Append(txtdisponible.text)
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
                    'BTNPRIMERO.Focus() 'ojo con esto
                End Try
            End If
        Else
            If txtautor.Text <> "" And txteditorial.Text <> "" And txtestado.Text <> "" And txtgenero.Text <> "" And txtlibro.Text <> "" And txtmetodo.Text <> "" And txtnropag.Text <> "" And txttitulo.Text <> "" And fecha <> "" And dtpedicion.Text <> "" And txtdisponible.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Update libros set autor='")
                    stb.Append(txtautor.Text)
                    stb.Append("',editorial='")
                    stb.Append(txteditorial.Text)
                    stb.Append("',estado='")
                    stb.Append(txtestado.Text)
                    stb.Append("',genero='")
                    stb.Append(txtgenero.Text)
                    stb.Append("',modo_adquisicion='")
                    stb.Append(txtmetodo.Text)
                    stb.Append("',nro_paginas='")
                    stb.Append(txtnropag.Text)
                    stb.Append("',titulo='")
                    stb.Append(txttitulo.Text)
                    stb.Append("',fecha_adquisicion='")
                    stb.Append(fecha)
                    stb.Append("',año_d_edicion='")
                    stb.Append(dtpedicion.Text)
                    stb.Append("',disponible='")
                    stb.Append(txtdisponible.Text)
                    stb.Append("'WHERE id_libro='")
                    stb.Append(txtlibro.Text)
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
    End Sub

    Private Sub BTNCONSULTAR_Click(sender As Object, e As EventArgs) Handles BTNCONSULTAR.Click
        GRBCONSULTAR.Visible = True
        DESPLAZAMIENTO.Visible = False
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim oDataRow As DataRow
        oDataRow = data.Tables("libros").Rows(Fila)
        If MessageBox.Show("Desea Eliminar el Registro", "libros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            oDataRow.Delete()
            Dim oTablaBorrados As DataTable
            oTablaBorrados = data.Tables("libros").GetChanges(DataRowState.Deleted)
            adaptador.Update(oTablaBorrados)
            data.Tables("libros").AcceptChanges()
            BTNPRIMERO.PerformClick()
            Exit Sub
        End If
        CONTROLA()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim X As Integer
        Fila = 0
        Dim oDataRow As DataRow
        Do While Fila <= (data.Tables("libros").Rows.Count - 1)
            oDataRow = data.Tables("libros").Rows(Fila)
            If TXTBUSCAR.Text = oDataRow("id_libro") Then
                X = 1
                CARGARDATOS()
                Exit Do
            End If
            Fila += 1
        Loop
        If X = 0 Then
            MessageBox.Show("No Existe el libro Indicado")
        End If
        GRBCONSULTAR.Visible = False
        'BTNPRIMERO.Focus()
        DESPLAZAMIENTO.Visible = True
    End Sub

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
        If Fila = (data.Tables("libros").Rows.Count - 1) Then
            MessageBox.Show("Ultimo Registro")
        Else
            Fila += 1
            CARGARDATOS()
            ' CALCULA()
        End If
    End Sub

    Private Sub BTNULTIMO_Click(sender As Object, e As EventArgs) Handles BTNULTIMO.Click
        Fila = (data.Tables("libros").Rows.Count - 1)
        CARGARDATOS()
    End Sub

    Private Sub txttitulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttitulo.KeyPress
        validar.letra(txttitulo, e, txtgenero)
    End Sub

    Private Sub txtgenero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtgenero.KeyPress
        validar.letra(txtgenero, e, txtautor)
    End Sub

    Private Sub txtautor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtautor.KeyPress
        validar.letra(txtautor, e, txtmetodo)
    End Sub

    Private Sub txtmetodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmetodo.KeyPress
        validar.letra(txtmetodo, e, txtnropag)
    End Sub

    Private Sub txtnropag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnropag.KeyPress
        validar.numero(txtnropag, e, txtestado)
    End Sub

    Private Sub txtestado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtestado.KeyPress
        validar.letra(txtestado, e, dtpedicion)
    End Sub

    Private Sub dtpedicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpedicion.KeyPress
        validar.fecha(dtpedicion, e, txteditorial)
    End Sub

    Private Sub txteditorial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txteditorial.KeyPress
        validar.mixto(txteditorial, e, txteditorial)
    End Sub
    Private Sub txtdisponible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdisponible.KeyPress
        validar.letra(txtdisponible, e, txtdisponible)
    End Sub
End Class