Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Public Class cantidadlibros
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
    Sub CARGARDATOS()
        Dim autor, editorial, estado, genero, libro, metodo, titulo, edicion, nropag As String
        Dim oDataRow As DataRow
        Dim fecha As String
        oDataRow = data.Tables("libros").Rows(Fila)
        autor = oDataRow("autor")
        editorial = oDataRow("editorial")
        estado = oDataRow("estado")
        genero = oDataRow("genero")
        libro = oDataRow("id_libro")
        metodo = oDataRow("modo_adquisicion")
        titulo = oDataRow("titulo")
        fecha = oDataRow("fecha_adquisicion")
        edicion = oDataRow("año_d_edicion")
        nropag = oDataRow("nro_paginas")
    End Sub
    Private Sub cantidadlibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contardonado As New SqlDataAdapter("Select count(*) from libros ", Cn)
        Dim dataa As New DataSet()
        contardonado.Fill(dataa, "libros")
        'cantidonado.Text = contardonado
        datagridmostrar.DataSource = dataa
        datagridmostrar.DataMember = "libros"
        totalibro.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        Dim Cmd As New SqlCommand("select getdate()", Cn)
        adaptador = New SqlDataAdapter("SELECT * FROM libros", Cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        CONTROLA()
        dvw = data.Tables(0).DefaultView()
        Fila = 0
        btnmostrartodo.PerformClick()
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        buscar()
    End Sub
    Private Sub btnmostrartodo_Click(sender As Object, e As EventArgs) Handles btnmostrartodo.Click
        btodo()
    End Sub
    Sub buscar()
        Dim olibro As New SqlDataAdapter("SELECT id_libro,titulo , genero ,autor ,nro_paginas  , estado, año_d_edicion , editorial , modo_adquisicion , fecha_adquisicion from libros where titulo like'%" & txtbuscar.Text & "%'", Cn)
        Dim odataset As New DataSet()
        olibro.Fill(odataset, "libros")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "libros"
        datagridmostrar.Enabled = True
    End Sub
    Sub btodo()
        Dim olibro As New SqlDataAdapter("SELECT * from libros ", Cn)
        Dim odataset As New DataSet()
        olibro.Fill(odataset, "libros")
        datagridmostrar.DataSource = odataset
        datagridmostrar.DataMember = "libros"
        datagridmostrar.Enabled = True
    End Sub


    Private Sub lbdonado_Click(sender As Object, e As EventArgs) Handles lbdonado.Click
        Dim contardonado As New SqlDataAdapter("Select count(*) from libros where modo_adquisicion='Donado'", cn)
        Dim data As New DataSet()
        contardonado.Fill(data, "libros")
        'cantidonado.Text = contardonado
        datagridmostrar.DataSource = data
        datagridmostrar.DataMember = "libros"
        cantidonado.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        If lbdonado.Checked = True Then
            datagridmostrar.DataSource = Nothing
            'Dim oclector As New SqlDataAdapter("SELECT id_personal,nombre,apellidos,dni,sexo,direccion,cargo from personal ", Cn)
            Dim olibro As New SqlDataAdapter("SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion as 'Año de edicion',editorial,modo_adquisicion,fecha_adquisicion from libros where modo_adquisicion='Donado'", cn)
            Dim odataset As New DataSet()
            olibro.Fill(odataset, "libros")
            datagridmostrar.DataSource = odataset
            datagridmostrar.DataMember = "libros"

            Dim autor, editorial, estado, genero, libro, metodo, titulo, edicion, nropag, fecha As String
            ' If lbdonado.Checked = True Then
            autor = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
            editorial = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 1)
            estado = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 2)
            genero = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 3)
            libro = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 4)
            metodo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 5)
            titulo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 6)
            edicion = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 7)
            nropag = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 8)
            fecha = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 9)
        End If
    End Sub
    Private Sub lbcomprado_Click(sender As Object, e As EventArgs) Handles lbcomprado.Click
        Dim contardonado As New SqlDataAdapter("Select count(*) from libros where modo_adquisicion='Comprado'", cn)
        Dim data As New DataSet()
        contardonado.Fill(data, "libros")
        'cantidonado.Text = contardonado
        datagridmostrar.DataSource = data
        datagridmostrar.DataMember = "libros"
        canticomprado.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        If lbcomprado.Checked = True Then
            datagridmostrar.DataSource = Nothing
            'Dim oclector As New SqlDataAdapter("SELECT id_personal,nombre,apellidos,dni,sexo,direccion,cargo from personal ", Cn)
            Dim olibro As New SqlDataAdapter("SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion as 'Año de edicion',editorial,modo_adquisicion,fecha_adquisicion from libros where modo_adquisicion='Comprado'", cn)
            Dim odataset As New DataSet()
            olibro.Fill(odataset, "libros")
            datagridmostrar.DataSource = odataset
            datagridmostrar.DataMember = "libros"
            Try
                Dim autor, editorial, estado, genero, libro, metodo, titulo, edicion, nropag, fecha As String
                autor = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
                editorial = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 1)
                estado = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 2)
                genero = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 3)
                libro = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 4)
                metodo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 5)
                titulo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 6)
                edicion = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 7)
                nropag = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 8)
                fecha = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 9)
            Catch ex As Exception
                MsgBox("No Se Pudo Encontrar Ningun Libro Comprado")
            End Try
        End If
    End Sub
    Private Sub lbnoespecificado_Click(sender As Object, e As EventArgs) Handles lbnoespecificado.Click
        Dim contardonado As New SqlDataAdapter("Select count(*) from libros where modo_adquisicion='Otros'", cn)
        Dim data As New DataSet()
        contardonado.Fill(data, "libros")
        'cantidonado.Text = contardonado
        datagridmostrar.DataSource = data
        datagridmostrar.DataMember = "libros"
        cantiotros.Text = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
        If lbnoespecificado.Checked = True Then
            datagridmostrar.DataSource = Nothing
            'Dim oclector As New SqlDataAdapter("SELECT id_personal,nombre,apellidos,dni,sexo,direccion,cargo from personal ", Cn)
            Dim olibro As New SqlDataAdapter("SELECT id_libro,titulo,genero,autor,nro_paginas,estado,año_d_edicion as 'Año de edicion',editorial,modo_adquisicion,fecha_adquisicion from libros where modo_adquisicion='Otros'", cn)
            Dim odataset As New DataSet()
            olibro.Fill(odataset, "libros")
            datagridmostrar.DataSource = odataset
            datagridmostrar.DataMember = "libros"
            Try
                Dim autor, editorial, estado, genero, libro, metodo, titulo, edicion, nropag, fecha As String
                autor = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 0)
                editorial = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 1)
                estado = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 2)
                genero = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 3)
                libro = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 4)
                metodo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 5)
                titulo = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 6)
                edicion = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 7)
                nropag = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 8)
                fecha = datagridmostrar.Item(datagridmostrar.CurrentRowIndex, 9)
            Catch ex As Exception
                MsgBox("NO Se Encontro Nada")
            End Try  
        End If
    End Sub


    Private Sub print_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles print.PrintPage
        Dim i As Integer ' PARA control de impresion de lectrua
        Dim texto As String  'para recoger todas las letras
        Dim fuente As New Font("Courier New", 8) 'letra q menos consume tinta///determna el fuente a utilizar
        'para el color de letra
        Dim brocha As Brush = Brushes.Black 'determinar el color 
        'absisas y cordinadas para especificar la pagina
        Dim x As Integer = e.MarginBounds.Left = 10 'margen izquierdo siempre se incrementa
        Dim y As Integer = e.MarginBounds.Top = 10 'margen superior
        texto = "                                       LIBROS QUE FUERON DONADOS/COMPRADOS                                      "
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight ' estas dos lineas de codigo siempre van juntas cada ves que se ingresa un txto
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "TITULO                      GENERO           AUTOR                  ESTADO         EDITORIAL     FORMA DE ADQUISICION"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        texto = "---------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString(texto, fuente, brocha, x, y)
        y = y + fuente.GetHeight
        stb.Length = 0
        For i = 0 To dvw.Count - 1 ' devuelve cantdd de regstr de tblas
            'el nro 5 representa el espacio del campo  'anexar de derecha a izquierda
            stb.Append(dvw(i)(1).ToString.PadRight(29))
            stb.Append(dvw(i)(2).ToString.PadRight(14))
            stb.Append(dvw(i)(3).ToString.PadRight(25))
            stb.Append(dvw(i)(5).ToString.PadRight(14))
            stb.Append(dvw(i)(7).ToString.PadRight(20))
            stb.Append(dvw(i)(8).ToString.PadRight(0))
    
            
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
    Private Sub VISTA_PREVIA_Click(sender As Object, e As EventArgs) Handles vista_previa.Click
        Dim Cmd As New SqlCommand("select getdate()", Cn)
        adaptador = New SqlDataAdapter("SELECT * FROM libroad", cn)
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        data = New DataSet()
        Cn.Open()
        adaptador.Fill(data, "libroad")
        Cn.Close() 'cierra la conexion con la BD
        dvw = data.Tables(0).DefaultView()
        Dim ppc As New PrintPreviewControl 'vista preliminar
        ppc.Document = Print() 'print es el nombre del objeto
        ppc.Zoom = 1 'zoom tamaño normal
        ppc.Dock = DockStyle.Fill 'bordes de la pagina
        Dim frmprevio As New Form
        With frmprevio
            .Text = "LIBROS QUE FUERON DONADOS/COMPRADOS"
            .WindowState = FormWindowState.Maximized
            .Controls.Add(ppc)
            .ShowDialog()
        End With
    End Sub

    Private Sub IMPRIMIR_Click(sender As Object, e As EventArgs) Handles IMPRIMIR.Click
        If dvw.Count > 1 Then
            print.Print()
        Else
            MsgBox("Debe pulsar primero el Botón REPORTE o no hay Registros en la Tabla", MsgBoxStyle.Question)
        End If
    End Sub

  
End Class