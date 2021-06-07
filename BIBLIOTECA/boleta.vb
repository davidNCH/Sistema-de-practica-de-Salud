Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.IO

Public Class boleta
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
            adaptador.Fill(data, "boleta")
            Cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CARGARDATOS()
        Dim oDataRow As DataRow
        Dim dni, librot, fprestamo, fdevolucion, namepersonal, apersonal As String

        oDataRow = data.Tables("mora_persona").Rows(Fila)
        dni = oDataRow("dni")
        librot = oDataRow("titulo")
        fprestamo = oDataRow("fech_prestamo")
        fdevolucion = oDataRow("fech_devolucion")
        namepersonal = oDataRow("nombre")
        apersonal = oDataRow("apellidos")
    End Sub
    Private Sub boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnmostrartodo.PerformClick()
        Dim Cmd As New SqlCommand("select getdate()", cn)
        adaptador = New SqlDataAdapter("SELECT * FROM boleta", cn)
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
        CARGARDATOS()
    End Sub

    Private Sub btnmostrartodo_Click(sender As Object, e As EventArgs) Handles btnmostrartodo.Click

    End Sub
End Class