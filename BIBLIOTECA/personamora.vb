Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class personamora
    Inherits System.Windows.Forms.Form
    'Dim obj As New valida
    'Dim cn As New SqlConnection("Data Source=SPADOW-PC\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True")
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
            adaptador.Fill(data, "mora_persona")
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        oDataRow = data.Tables("mora_persona").Rows(Fila)
        txtidmora.Text = oDataRow("id_mora")
        txtidlector.Text = oDataRow("id_libro")
        txtidlibro.Text = oDataRow("id_lector")
        dtmfechaprestamo.Text = oDataRow("fecha_d_prestamo")
        DTPESTIMADA.Text = oDataRow("fecha_d_devolucion")
        dtmfechadevolucion.Text = oDataRow("fecha_mora")
        txtcostomora.Text = oDataRow("costo_mora")
    End Sub
    Sub DESACTIVA()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Enabled = False
            End If
        Next
        txtcostomora.Enabled = False
        txtidlector.Enabled = False
        txtidlibro.Enabled = False
        txtidmora.Enabled = False
        DTPESTIMADA.Enabled = False
        dtmfechaprestamo.Enabled = False
        dtmfechadevolucion.Enabled = False
        txtbuscardgv.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As TimeSpan
        'b.Format = DateTimePickerFormat.Short
        'b.Value = dtmfechadevolucion.Text
        a = dtmfechadevolucion.Value - DTPESTIMADA.Value
        TXTRETRASO.Text = a.Days
        TXTMULTA.Text = (TXTRETRASO.Text * 2) & " Soles"
        If (TXTRETRASO.Text = 1) Then
            TXTRETRASO.Text = "LA ENTREGA ESTA ATRASADA POR " & TXTRETRASO.Text & " DIA"
        Else
            TXTRETRASO.Text = "LA ENTREGA ESTA ATRASADA POR " & TXTRETRASO.Text & " DIAS"
        End If
        'TXTRETRASO.Text = -(Val(TXTRETRASO.Text))
        'MsgBox(TXTRETRASO.Text)

        'TXTRETRASO.Text = "LA ENTREGA ESTA RETRASADA POR " & a.Days() & " DIAS"
    End Sub

    Private Sub personamora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmostrartodo.PerformClick()
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM mora_persona", cn)
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
        Dim oclientes As New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',mora_persona.fecha_d_prestamo as 'Fecha Prestamo',mora_persona.fecha_d_devolucion as 'Fecha Devolucion',mora_persona.fecha_mora as 'Fecha Entrega Estimada',lector.id_lector,libros.id_libro" & _
       " from mora_persona inner join lector on mora_persona.id_lector=lector.id_lector inner join libros on libros.id_libro=mora_persona.id_libro", cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "mora_persona")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "mora_persona"
        dgvtodo.Visible = True
    End Sub
    Private Sub dgvtodo_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvtodo.MouseClick

        txtidlector.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 8)
        lectornombre.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
        lectorap.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
        lectordni.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
        librotitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
        libroautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
        dtmfechaprestamo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 5)
        DTPESTIMADA.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 6)
        dtmfechadevolucion.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 7)
        txtidlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 9)
        Button1.PerformClick()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oclientes As New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',mora_persona.fecha_d_prestamo as 'Fecha Prestamo',mora_persona.fecha_d_devolucion as 'Fecha Devolucion',mora_persona.fecha_mora as 'Fecha Entrega Estimada',lector.id_lector,libros.id_libro" & _
 " from mora_persona inner join lector on mora_persona.id_lector=lector.id_lector inner join libros on libros.id_libro=mora_persona.id_libro where lector.nombre like '" & txtbuscardgv.Text & "%'", cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "mora_persona")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "mora_persona"
        dgvtodo.Visible = True
    End Sub
    Private Sub Print_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles Print.PrintPage
        Dim i As Integer ' PARA control de impresion de lectrua
        Dim texto As String  'para recoger todas las letras
        Dim fuente As New Font("Courier New", 8) 'letra q menos consume tinta///determna el fuente a utilizar
        'para el color de letra
        Dim brocha As Brush = Brushes.Black 'determinar el color 
        'absisas y cordinadas para especificar la pagina
        Dim x As Integer = e.MarginBounds.Left = 10 'margen izquierdo siempre se incrementa
        Dim y As Integer = e.MarginBounds.Top = 10 'margen superior
        texto = "                                       LISTA DE LECTORES MOROSOS                                      "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight ' estas dos lineas de codigo siempre van juntas cada ves que se ingresa un txto
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "            NOMBRES             APELLIDOS             DNI             LIBRO            "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        For i = 0 To dvw.Count - 1 ' devuelve cantdd de regstr de tblas
            'el nro 5 representa el espacio del campo
            stb.Append("    ".ToString.PadLeft(13))
            stb.Append(dvw(i)(0).ToString.PadRight(17)) 'anexar de derecha a izquierda
            stb.Append(dvw(i)(1).ToString.PadRight(21))
            stb.Append(dvw(i)(2).ToString.PadRight(15))
            stb.Append(dvw(i)(3).ToString.PadRight(12))
            'devuelve todas las columnas a imprimir
            texto = stb.ToString
            'dibujar e imprimir
            e.Graphics.DrawString(texto, fuente, brocha, x, y)
            'controlar el interlineado
            y = y + fuente.GetHeight
            'q la cantidad de caracteres sea igual a cero
            stb.Length = 0
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT lector.nombre as 'Nombre lector',lector.apellido as 'Apellido Lector',lector.dni as 'DNI Lector',libros.titulo as 'Titulo libro',libros.autor as 'Autor del Libro',mora_persona.fecha_d_prestamo as 'Fecha Prestamo',mora_persona.fecha_d_devolucion as 'Fecha Devolucion',mora_persona.fecha_mora as 'Fecha Entrega Estimada',lector.id_lector,libros.id_libro" & _
       " from mora_persona inner join lector on mora_persona.id_lector=lector.id_lector inner join libros on libros.id_libro=mora_persona.id_libro", cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        cn.Open()
        adaptador.Fill(data, "mora_persona")
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

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNIMPRIMIR.Click
        If dvw.Count > 1 Then
            Print.Print()
        Else
            MsgBox("Debe pulsar primero el Botón REPORTE o no hay Registros en la Tabla", MsgBoxStyle.Question)
        End If
    End Sub
End Class