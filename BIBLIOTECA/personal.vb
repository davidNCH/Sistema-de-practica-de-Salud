Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class personal

    Inherits System.Windows.Forms.Form
    Dim validar As New validacion
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=biblioteca;Integrated Security=True")
    'Private Cn As New SqlConnection("Data Source= DESKTOP-OQMPFF2\SQLEXPRESS ;Initial Catalog=biblioteca;Integrated Security=True")
    Private cmd As New SqlCommand("", Cn)
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
            Cn.Open()
            adaptador.Fill(data, "personal")
            Cn.Close()
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
        txtidpersonal.Enabled = False
        txtnombre.Enabled = True
        txtapellido.Enabled = True
        txtdni.Enabled = True
        cmbsexo.Enabled = True
        txtdireccion.Enabled = True
        txtcargo.Enabled = True
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtidpersonal.Enabled = False
        txtnombre.Enabled = False
        txtapellido.Enabled = False
        txtdni.Enabled = False
        cmbsexo.Enabled = False
        txtdireccion.Enabled = False
        txtcargo.Enabled = False
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
        oDataRow = data.Tables("personal").Rows(Fila)
        txtidpersonal.Text = oDataRow("id_personal")
        txtnombre.Text = oDataRow("nombre")
        txtapellido.Text = oDataRow("apellidos")
        txtdni.Text = oDataRow("dni")
        cmbsexo.Text = oDataRow("sexo")
        txtdireccion.Text = oDataRow("direccion")
        txtcargo.Text = oDataRow("cargo")
    End Sub


    Private Sub libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Cmd As New SqlCommand("select getdate()", Cn)
        adaptador = New SqlDataAdapter("SELECT * FROM personal", Cn)
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
        txtnombre.Focus()
        I = 2
        ACTIVA()
        CUANDOINGRESA()
        BTNGUARDAR.Enabled = True
        NUM = data.Tables("personal").Rows.Count
        NUM = NUM + 1
        NUM2 = data.Tables("personal").Rows.Count
        NUM2 = NUM2 + 1
        txtidpersonal.Text = "P" + NUM.ToString("0000")

    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If I = 1 Then
            If txtidpersonal.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And cmbsexo.Text <> "" And txtdireccion.Text <> "" And txtcargo.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Insert Into personal (id_personal,nombre,apellidos,dni,sexo,direccion,cargo)  Values ('")
                    stb.Append(txtidpersonal.Text)
                    stb.Append("','")
                    stb.Append(txtnombre.Text)
                    stb.Append("','")
                    stb.Append(txtapellido.Text)
                    stb.Append("','")
                    stb.Append(txtdni.Text)
                    stb.Append("','")
                    stb.Append(cmbsexo.Text)
                    stb.Append("','")
                    stb.Append(txtdireccion.Text)
                    stb.Append("','")
                    stb.Append(txtcargo.Text)
                    stb.Append("')")
                    Cn.Open()
                    cmd.CommandText = stb.ToString
                    reg = cmd.ExecuteNonQuery()
                    If reg > 0 Then
                        MsgBox("Los Datos se Grabaron Correctamente", MsgBoxStyle.Information, "Puede continuar")
                        'btnagregarimg.Enabled = False
                    Else
                        Throw New Exception("No se Pudo Guardar los Datos del Libro")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If Cn.State = ConnectionState.Open Then Cn.Close()
                    stb.Length = 0
                    CONTROLA()
                    Fila = 0
                    CARGARDATOS()
                    DESACTIVA()
                    CUANDOLEE()
                    BTNPRIMERO.Focus() ' con con esto
                End Try
            End If
        Else
            If txtidpersonal.Text <> "" And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdni.Text <> "" And cmbsexo.Text <> "" And txtdireccion.Text <> "" And txtcargo.Text <> "" Then
                Try
                    stb.Length = 0
                    stb.Append("Update personal set nombre='")
                    stb.Append(txtnombre.Text)
                    stb.Append("',apellidos='")
                    stb.Append(txtapellido.Text)
                    stb.Append("',dni='")
                    stb.Append(txtdni.Text)
                    stb.Append("',sexo='")
                    stb.Append(cmbsexo.Text)
                    stb.Append("',direccion='")
                    stb.Append(txtdireccion.Text)
                    stb.Append("',cargo='")
                    stb.Append(txtcargo.Text)
                    stb.Append("'WHERE id_personal='")
                    stb.Append(txtidpersonal.Text)
                    stb.Append("'")
                    Cn.Open()
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
                    If Cn.State = ConnectionState.Open Then Cn.Close()
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
        oDataRow = data.Tables("personal").Rows(Fila)
        If MessageBox.Show("Desea Eliminar el Registro", "personal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            oDataRow.Delete()
            Dim oTablaBorrados As DataTable
            oTablaBorrados = data.Tables("personal").GetChanges(DataRowState.Deleted)
            adaptador.Update(oTablaBorrados)
            data.Tables("personal").AcceptChanges()
            BTNPRIMERO.PerformClick()
            Exit Sub
        End If
        CONTROLA()
    End Sub

    Private Sub BTNBUSCAR_Click(sender As Object, e As EventArgs) Handles BTNBUSCAR.Click
        Dim X As Integer
        Fila = 0
        Dim oDataRow As DataRow
        Do While Fila <= (data.Tables("personal").Rows.Count - 1)
            oDataRow = data.Tables("personal").Rows(Fila)
            If TXTBUSCAR.Text = oDataRow("id_personal") Then
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
        BTNPRIMERO.Focus() 'del boton 
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
        If Fila = (data.Tables("personal").Rows.Count - 1) Then
            MessageBox.Show("Ultimo Registro")
        Else
            Fila += 1
            CARGARDATOS()
            ' CALCULA()
        End If
    End Sub

    Private Sub BTNULTIMO_Click(sender As Object, e As EventArgs) Handles BTNULTIMO.Click
        Fila = (data.Tables("personal").Rows.Count - 1)
        CARGARDATOS()
    End Sub

    Private Sub cmbsexo_GotFocus(sender As Object, e As EventArgs) Handles cmbsexo.GotFocus
        cmbsexo.Items.Clear()
        '  cmbsexo.Items.Add("")
        cmbsexo.Items.Add("F")
        cmbsexo.Items.Add("M")
    End Sub
    Private Sub CERRAR_Click(sender As Object, e As EventArgs)
        Hide()
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        validar.letra(txtnombre, e, txtapellido)
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        validar.letra(txtapellido, e, txtdni)
    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress
        validar.numerocombox(txtdni, e, cmbsexo)
    End Sub
   
    Private Sub cmbsexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbsexo.KeyPress
        validar.numrocombox(cmbsexo, e, txtdireccion)
    End Sub

    Private Sub txtdireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdireccion.KeyPress
        validar.mixto(txtdireccion, e, txtcargo)
    End Sub

    Private Sub txtcargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcargo.KeyPress
        validar.letra(txtcargo, e, txtcargo)
    End Sub

    Private Sub TXTBUSCAR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTBUSCAR.KeyPress
        validar.consulta(TXTBUSCAR, e, TXTBUSCAR)
    End Sub

End Class