Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class personalactivo
    Inherits System.Windows.Forms.Form
    'Dim obj As New valida
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
            adaptador.Fill(data, "personal")
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        oDataRow = data.Tables("personal").Rows(Fila)
        txtidpersonal.Text = oDataRow("id_personal")
        txtnombrepers.Text = oDataRow("nombre")
        txtapellid.Text = oDataRow("apellidos")
        txtdni.Text = oDataRow("dni")
        cmbsexo.Text = oDataRow("sexo")
        txtdireccion.Text = oDataRow("direccion")
        txtcargo.Text = oDataRow("cargo")
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtbuscar.Enabled = True
        cmbsexo.Enabled = False
        dtmfecha.Enabled = False

    End Sub
    Private Sub personalactivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnmostrartodo.PerformClick()
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM personal", cn)
        btnmostrartodo.PerformClick()
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
        CARGARDATOS()
    End Sub
    Private Sub btnmostrartodo_Click(sender As Object, e As EventArgs) Handles btnmostrartodo.Click
        Dim oclientes As New SqlDataAdapter("SELECT personal.id_personal , personal.nombre as 'nombre' , personal.apellidos as 'Apellidos' ,personal.dni as'DNI', personal.sexo as 'Sexo', personal.direccion as 'Direccion', personal.cargo as'Cargo', j_laboral.id_jornada, j_laboral.hora_ent as'H_Ent', j_laboral.hora_sal as'H_Sal', j_laboral.fecha as 'Fecha' " & _
     " from personal inner join j_laboral on personal.id_personal=j_laboral.id_personal", Cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "personal")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "personal"
        datagridmostrar.Visible = True
    End Sub


    Private Sub datagridmostrar_MouseClick(sender As Object, ne As MouseEventArgs) Handles datagridmostrar.MouseClick
        Dim fecha As String = dtmfecha.Value
        txtidpersonal.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        txtnombrepers.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 1)
        txtapellid.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 2)
        txtdni.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 3)
        cmbsexo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 4)
        txtdireccion.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 5)
        txtcargo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 6)
        txtidjornada.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 7)
        txthoraentra.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 8)
        txthorasale.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 9)
        dtmfecha.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 10)
    End Sub

    'Private Sub datagridmostrar_Navigate(sender As Object, ne As NavigateEventArgs) Handles datagridmostrar.Navigate
    '    Dim fecha As String = dtmfecha.Value
    '    txtidpersonal.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
    '    txtnombrepers.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 1)
    '    txtapellid.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 2)
    '    txtdni.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 3)
    '    cmbsexo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 4)
    '    txtdireccion.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 5)
    '    txtcargo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 6)
    '    txtidjornada.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 7)
    '    txthoraentra.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 8)
    '    txthorasale.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 9)
    '    dtmfecha.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 10)
    'End Sub

    Private Sub bntbuscar_Click(sender As Object, e As EventArgs) Handles bntbuscar.Click
        Dim oclientes As New SqlDataAdapter("SELECT personal.id_personal , personal.nombre as 'nombre' , personal.apellidos as 'Apellidos' ,personal.dni as'DNI', personal.sexo as 'Sexo', personal.direccion as 'Direccion', personal.cargo as'Cargo', j_laboral.id_jornada, j_laboral.hora_ent as'H_Ent', j_laboral.hora_sal as'H_Sal', j_laboral.fecha as 'Fecha' " & _
       " from personal inner join j_laboral on personal.id_personal=j_laboral.id_personal where personal.dni like '" & txtbuscar.Text & "'", Cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "personal")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "personal"
        datagridmostrar.Visible = True
    End Sub

    Private Sub print_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print.PrintPage
        Dim i As Integer ' PARA control de impresion de lectrua
        Dim texto As String  'para recoger todas las letras
        Dim fuente As New Font("Courier New", 8) 'letra q menos consume tinta///determna el fuente a utilizar
        'para el color de letra
        Dim brocha As Brush = Brushes.Black 'determinar el color 
        'absisas y cordinadas para especificar la pagina
        Dim x As Integer = e.MarginBounds.Left = 10 'margen izquierdo siempre se incrementa
        Dim y As Integer = e.MarginBounds.Top = 10 'margen superior
        texto = "                                           LISTA DE PERSONAL QUE LABORA EN LA BIBLIOTECA                                      "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight ' estas dos lineas de codigo siempre van juntas cada ves que se ingresa un txto
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "NOMBRES        APELLIDOS             DNI         SEXO      CARGO                            H.ENTRADA     H.SALIDA       "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        For i = 0 To dvw.Count - 1 ' devuelve cantdd de regstr de tblas
            stb.Append(dvw(i)(1).ToString.PadRight(16)) 'anexar de derecha a izquierda
            stb.Append(dvw(i)(2).ToString.PadRight(20))
            stb.Append(dvw(i)(3).ToString.PadRight(15))
            stb.Append(dvw(i)(4).ToString.PadRight(7))
            stb.Append(dvw(i)(6).ToString.PadRight(38))
            stb.Append(dvw(i)(8).ToString.PadRight(13))
            stb.Append(dvw(i)(9).ToString.PadRight(8))
            texto = stb.ToString
            'dibujar e imprimir
            e.Graphics.DrawString(texto, fuente, brocha, x, y)
            y = y + fuente.GetHeight
            'q la cantidad de caracteres sea igual a cero
            stb.Length = 0
        Next
    End Sub
    Private Sub VISTA_PREVIA_Click(sender As Object, e As EventArgs) Handles vista_previa.Click
        Dim Cmd As New SqlCommand("select getdate()", Cn)
        adaptador = New SqlDataAdapter("SELECT * FROM personalactivo", Cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        Cn.Open()
        adaptador.Fill(data, "personalactivo")
        Cn.Close() 'cierra la conexion con la BD
        dvw = data.Tables(0).DefaultView()
        Dim ppc As New PrintPreviewControl 'vista preliminar
        ppc.Document = Print() 'print es el nombre del objeto
        ppc.Zoom = 1 'zoom tamaño normal
        ppc.Dock = DockStyle.Fill 'bordes de la pagina
        Dim frmprevio As New Form
        With frmprevio
            .Text = "VISTA PREVIA DEL PERSONAL QUE LABORA EN LA BIBLIOTECA"
            .WindowState = FormWindowState.Maximized
            .Controls.Add(ppc)
            .ShowDialog()
        End With
    End Sub
    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles IMPRIMIR.Click
        If dvw.Count > 1 Then
            print.Print()
        Else
            MsgBox("Debe pulsar primero el Botón REPORTE o no hay Registros en la Tabla", MsgBoxStyle.Question)
        End If
    End Sub
End Class