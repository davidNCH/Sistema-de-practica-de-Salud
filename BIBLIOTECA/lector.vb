Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class lector

    Inherits System.Windows.Forms.Form
    Dim validar As New validacion
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=biblioteca;Integrated Security=True")
    'Private Cn As New SqlConnection("Data Source= DESKTOP-OQMPFF2\SQLEXPRESS ;Initial Catalog=biblioteca;Integrated Security=True")
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
            adaptador.Fill(data, "lector")
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
        txtnombre.Enabled = True
        txtap.Enabled = True
        txtdni.Enabled = True
        txtidlector.Enabled = False
        txtocupacion.Enabled = True
        dtfechanaci.Enabled = True
        dtpinscripcion.Enabled = True
        cbxsexo.Enabled = True
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtnombre.Enabled = False
        txtap.Enabled = False
        txtdni.Enabled = False
        txtidlector.Enabled = False
        txtocupacion.Enabled = False
        dtfechanaci.Enabled = False
        dtpinscripcion.Enabled = False
        cbxsexo.Enabled = False
        GRBCONSULTAR.Visible = False
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
        oDataRow = data.Tables("lector").Rows(Fila)
        txtap.Text = oDataRow("apellido")
        txtdni.Text = oDataRow("dni")
        txtidlector.Text = oDataRow("id_lector")
        txtnombre.Text = oDataRow("nombre")
        txtocupacion.Text = oDataRow("ocupacion")
        cbxsexo.Text = oDataRow("sexo")
        dtfechanaci.Text = oDataRow("fecha_nacimiento")
        dtpinscripcion.Text = oDataRow("fecha_inscripcion")
    End Sub
    Private Sub lector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM lector", cn)
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
        txtidlector.Focus()
        I = 1
        ACTIVA()
        CUANDOINGRESA()
        BTNGUARDAR.Enabled = True
        NUM = data.Tables("lector").Rows.Count
        NUM = NUM + 1
        NUM2 = data.Tables("lector").Rows.Count
        NUM2 = NUM2 + 1
        txtidlector.Text = "LE" + NUM.ToString("000")
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If I = 1 Then
            If txtap.Text <> "" And txtdni.Text <> "" And txtidlector.Text <> "" And txtnombre.Text <> "" And txtocupacion.Text <> "" And cbxsexo.Text <> "" And dtfechanaci.Text <> "" And dtpinscripcion.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Insert Into lector (apellido,dni,id_lector,nombre,ocupacion,sexo,fecha_nacimiento,fecha_inscripcion)  Values ('")
                    stb.Append(txtap.Text)
                    stb.Append("','")
                    stb.Append(txtdni.Text)
                    stb.Append("','")
                    stb.Append(txtidlector.Text)
                    stb.Append("','")
                    stb.Append(txtnombre.Text)
                    stb.Append("','")
                    stb.Append(txtocupacion.Text)
                    stb.Append("','")
                    stb.Append(cbxsexo.Text)
                    stb.Append("','")
                    stb.Append(dtfechanaci.Text)
                    stb.Append("','")
                    stb.Append(dtpinscripcion.Text)
                    stb.Append("')")
                    cn.Open()
                    cmd.CommandText = stb.ToString
                    reg = cmd.ExecuteNonQuery()
                    If reg > 0 Then
                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
                        ' btnagregarimg.Enabled = False
                    Else
                        Throw New Exception("No se Pudo Guardar los Datos del Lector")
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
            End If
        Else
            If txtnombre.Text <> "" And txtap.Text <> "" And txtdni.Text <> "" And dtpinscripcion.Text <> "" And dtfechanaci.Text <> "" And txtocupacion.Text <> "" And cbxsexo.Text <> "" And txtidlector.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Update lector set nombre='")
                    stb.Append(txtnombre.Text)
                    stb.Append("',apellido='")
                    stb.Append(txtap.Text)
                    stb.Append("',dni='")
                    stb.Append(txtdni.Text)
                    stb.Append("',fecha_inscripcion='")
                    stb.Append(dtpinscripcion.Text)
                    stb.Append("',fecha_nacimiento='")
                    stb.Append(dtfechanaci.Text)
                    stb.Append("',ocupacion='")
                    stb.Append(txtocupacion.Text)
                    stb.Append("',sexo='")
                    stb.Append(cbxsexo.Text)
                    stb.Append("'WHERE id_lector='")
                    stb.Append(txtidlector.Text)
                    stb.Append("'")
                    cn.Open()
                    cmd.CommandText = stb.ToString
                    reg = cmd.ExecuteNonQuery()
                    If reg > 0 Then
                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
                    Else
                        Throw New Exception("No se Pudo Guardar los Datos del obrero")
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

    Private Sub BTNPRIMERO_Click(sender As Object, e As EventArgs) Handles BTNPRIMERO.Click
        Fila = 0
        CARGARDATOS()
    End Sub

    Private Sub BTNMODIFICAR_Click(sender As Object, e As EventArgs) Handles BTNMODIFICAR.Click
        I = 2
        ACTIVA()
        CUANDOINGRESA()
    End Sub

    Private Sub BTNCONSULTAR_Click(sender As Object, e As EventArgs) Handles BTNCONSULTAR.Click
        GRBCONSULTAR.Visible = True
        DESPLAZAMIENTO.Visible = False
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Fila = 0
        CARGARDATOS()
        DESACTIVA()
        CUANDOLEE()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim oDataRow As DataRow
        oDataRow = data.Tables("lector").Rows(Fila)
        If MessageBox.Show("Desea Eliminar el Registro", "lector", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            oDataRow.Delete()
            Dim oTablaBorrados As DataTable
            oTablaBorrados = data.Tables("lector").GetChanges(DataRowState.Deleted)
            adaptador.Update(oTablaBorrados)
            data.Tables("lector").AcceptChanges()
            BTNPRIMERO.PerformClick()
            Exit Sub
        End If
        CONTROLA()
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
        If Fila = (data.Tables("lector").Rows.Count - 1) Then
            MessageBox.Show("Ultimo Registro")
        Else
            Fila += 1
            CARGARDATOS()
            ' CALCULA()
        End If
    End Sub

    Private Sub BTNULTIMO_Click(sender As Object, e As EventArgs) Handles BTNULTIMO.Click
        Fila = (data.Tables("lector").Rows.Count - 1)
        CARGARDATOS()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim X As Integer
        Fila = 0
        Dim oDataRow As DataRow
        Do While Fila <= (data.Tables("lector").Rows.Count - 1)
            oDataRow = data.Tables("lector").Rows(Fila)
            If TXTBUSCAR.Text = oDataRow("id_lector") Then
                X = 1
                CARGARDATOS()
                Exit Do
            End If
            Fila += 1
        Loop
        If X = 0 Then
            MessageBox.Show("No Existe el lector Indicado")
        End If
        GRBCONSULTAR.Visible = False
        'BTNPRIMERO.Focus()
        DESPLAZAMIENTO.Visible = True
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.letra(txtnombre, e, txtap)
    End Sub

    Private Sub txtap_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.letra(txtap, e, txtdni)
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.numerocombox(txtdni, e, cbxsexo)
    End Sub
    Private Sub cbxsexo_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.numrocombox(cbxsexo, e, txtocupacion)

    End Sub
    Private Sub txtocupacion_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.fechatext(txtocupacion, e, dtfechanaci)
    End Sub

    Private Sub dtfechanaci_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.fechas(dtfechanaci, e, dtpinscripcion)
    End Sub

    Private Sub dtpinscripcion_KeyPress(sender As Object, e As KeyPressEventArgs)
        validar.fechas(dtpinscripcion, e, dtpinscripcion)
    End Sub


End Class