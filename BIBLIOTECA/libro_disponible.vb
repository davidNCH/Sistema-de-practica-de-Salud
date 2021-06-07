Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class libro_disponible
    Inherits System.Windows.Forms.Form
    'Dim obj As New valida
    ' Dim cn As New SqlConnection("Data Source=SPADOW-PC\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True")
    Dim cn As New SqlConnection("Data Source=.;Initial Catalog=biblioteca;Integrated Security=True")
    ''Private Cn As New SqlConnection("Data Source= DESKTOP-OQMPFF2\SQLEXPRESS ;Initial Catalog=biblioteca;Integrated Security=True")
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
            adaptador.Fill(data, "libros")
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        TXTDISPONIBLE.Enabled = False
        txtbuscardgv.Enabled = True
    End Sub
    Private Sub libro_disponible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmostrartodo.PerformClick()
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM libros", cn)
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
        Dim oclientes As New SqlDataAdapter("SELECT id_libro, titulo,genero,autor,nro_paginas,estado,año_d_edicion,editorial,modo_adquisicion,fecha_adquisicion,disponible from libros where disponible='Si'", cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "libros")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "libros"
        dgvtodo.Visible = True
    End Sub

    Private Sub dgvtodo_Click(sender As Object, e As EventArgs) Handles dgvtodo.Click
        txtlibro.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 0)
        txttitulo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 1)
        txtgenero.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 2)
        txtautor.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 3)
        txtnropag.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 4)
        txtestado.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 5)
        dtpedicion.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 6)
        txteditorial.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 7)
        txtmetodo.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 8)
        dtpadquisicion.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 9)
        TXTDISPONIBLE.Text = dgvtodo.Item(dgvtodo.CurrentRowIndex, 10)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oclientes As New SqlDataAdapter("SELECT id_libro, titulo,genero,autor,nro_paginas,estado,año_d_edicion,editorial,modo_adquisicion,fecha_adquisicion,disponible from libros where titulo like '" & txtbuscardgv.Text & "%'", cn)
        Dim odataset As New DataSet()
        oclientes.Fill(odataset, "libros")
        dgvtodo.DataSource = odataset
        dgvtodo.DataMember = "libros"
        dgvtodo.Visible = True
    End Sub

    Private Sub Print_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Print.PrintPage
        Dim i As Integer ' PARA control de impresion de lectrua
        Dim texto As String  'para recoger todas las letras
        Dim fuente As New Font("Courier New", 8) 'letra q menos consume tinta///determna el fuente a utilizar
        'para el color de letra
        Dim brocha As Brush = Brushes.Black 'determinar el color 
        'absisas y cordinadas para especificar la pagina
        Dim x As Integer = e.MarginBounds.Left = 10 'margen izquierdo siempre se incrementa
        Dim y As Integer = e.MarginBounds.Top = 10 'margen superior
        texto = "                                       LISTA DE LIBROS DISPONIBLES                                      "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight ' estas dos lineas de codigo siempre van juntas cada ves que se ingresa un txto
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "     TITULO                          AUTOR                       GENERO              ESTADO       NUMERO PAGINAS            "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        For i = 0 To dvw.Count - 1 ' devuelve cantdd de regstr de tblas
            'el nro 5 representa el espacio del campo
            stb.Append("    ".ToString.PadLeft(5))
            stb.Append(dvw(i)(1).ToString.PadRight(30)) 'anexar de derecha a izquierda
            stb.Append(dvw(i)(3).ToString.PadRight(30))
            stb.Append(dvw(i)(2).ToString.PadRight(20))
            stb.Append(dvw(i)(5).ToString.PadRight(15))
            stb.Append(dvw(i)(4).ToString.PadRight(52))
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
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT id_libro, titulo,genero,autor,nro_paginas,estado,año_d_edicion,editorial,modo_adquisicion,fecha_adquisicion,disponible from libros where disponible='Si'", cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        cn.Open()
        adaptador.Fill(data, "LIBROS")
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

    Private Sub BTNIMPRIMIR_Click_1(sender As Object, e As EventArgs) Handles BTNIMPRIMIR.Click
        If dvw.Count > 1 Then
            Print.Print()
        Else
            MsgBox("Debe pulsar primero el Botón REPORTE o no hay Registros en la Tabla", MsgBoxStyle.Question)
        End If
    End Sub
End Class