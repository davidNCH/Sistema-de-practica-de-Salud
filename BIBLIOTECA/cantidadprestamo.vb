Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class cantidadprestamo
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
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        Dim idpre, idlect, idper, fechapre, fechadevo, idlibr, estadopre, estadodevo As String
        oDataRow = data.Tables("prestamo").Rows(Fila)
        idpre = oDataRow("id_prestamo")
        idlect = oDataRow("id_lector")
        idper = oDataRow("id_personal")
        fechapre = oDataRow("fech_prestamo")
        fechadevo = oDataRow("fech_devolucion")
        idlibr = oDataRow("id_libro")
        estadopre = oDataRow("estado_prestamo")
        estadodevo = oDataRow("estado_devolucion")
    End Sub
    Private Sub cantidadprestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contar As New SqlDataAdapter("Select count(*) from prestamo ", cn)
        Dim data As New DataSet()
        contar.Fill(data, "prestamo")
        datagridmostrar.DataSource = data
        datagridmostrar.DataMember = "prestamo"
        cantiprestamo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        If RadioButton1.Checked = True Then
            datagridmostrar.DataSource = Nothing
            Dim oprestamo As New SqlDataAdapter("SELECT * from prestamo ", cn)
            Dim odataset As New DataSet()
            oprestamo.Fill(odataset, "prestamo")
            datagridmostrar.DataSource = odataset
            datagridmostrar.DataMember = "prestamo"
            Try
                cantiprestamo.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)        
            Catch ex As Exception
                MsgBox("No Hay Libros Prestados")
            End Try
        End If
        btnmostrartodo.PerformClick()
    End Sub
    Private Sub btnmostrartodo_Click(sender As Object, e As EventArgs) Handles btnmostrartodo.Click
        Dim olibro As New SqlDataAdapter("SELECT * from prestamo", Cn)
        Dim odataset As New DataSet()
        olibro.Fill(odataset, "prestamo")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "prestamo"
        datagridmostrar.Visible = True
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim olibro As New SqlDataAdapter("SELECT prestamo.id_prestamo, libros.id_libro,libros.titulo  from prestamo inner join libros on prestamo.id_libro=libros.id_libro where id_libro" & txtbuscar.Text, Cn)
        Dim odataset As New DataSet()
        olibro.Fill(odataset, "prestamo")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "prestamo"
        datagridmostrar.Visible = True
    End Sub
 
    Private Sub print_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles print.PrintPage
        Dim i As Integer
        Dim texto As String
        Dim fuente As New Font("Courier New", 8)
        'para el color de letra
        Dim brocha As Brush = Brushes.Black
        Dim x As Integer = e.MarginBounds.Left = 10
        Dim y As Integer = e.MarginBounds.Top = 10
        texto = "                                           LISTA DE PRESTAMOS DE LIBROS DE LA BIBLIOTECA                                      "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "ID-PRE   ID-LECTOR     ID-PERSNAL     FECHA-PRE    FECHA-DEVO   ID-LIBR    ESTADO-ENTRG     ESTADO-DEVOL  "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        For i = 0 To dvw.Count - 1
            stb.Append(dvw(i)(0).ToString.PadRight(11))
            stb.Append(dvw(i)(1).ToString.PadRight(13))
            stb.Append(dvw(i)(2).ToString.PadRight(13))
            stb.Append(dvw(i)(3).ToString.PadRight(14))
            stb.Append(dvw(i)(4).ToString.PadRight(14))
            stb.Append(dvw(i)(5).ToString.PadRight(14))
            stb.Append(dvw(i)(6).ToString.PadRight(14))
            stb.Append(dvw(i)(7).ToString.PadRight(16))
            texto = stb.ToString
            e.Graphics.DrawString(texto, fuente, brocha, x, y)
            y = y + fuente.GetHeight
            stb.Length = 0
        Next
    End Sub
    Private Sub VISTA_PREVIA_Click(sender As Object, e As EventArgs) Handles vista_previa.Click
        Dim Cmd As New SqlCommand("select getdate()", Cn)
        adaptador = New SqlDataAdapter("SELECT * FROM prestamo", Cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        Cn.Open()
        adaptador.Fill(data, "prestamo")
        cn.Close()
        dvw = data.Tables(0).DefaultView()
        Dim ppc As New PrintPreviewControl 'vista preliminar
        ppc.Document = print() '
        ppc.Zoom = 1 'zoom tamaño normal
        ppc.Dock = DockStyle.Fill 'bordes de la pagina
        Dim frmprevio As New Form
        With frmprevio
            .Text = "VISTA PREVIA DEL PERSONA QUE LABORA EN LA BIBLIOTECA"
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