Public Class validacion
    Public Sub numero(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 47 And a <= 57 Or a = 8 Or a = 45 Or a = 58 Or a = 6) Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub numerocombox(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As ComboBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 48 And a <= 57 Or a = 8 Or a = 6) Then
                e.Handled = True
            End If
            End If
    End Sub
    Public Sub numrocombox(ByVal entrada As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            '  If Not (a >= 47 And a <= 57 Or a = 8 Or a = 45 Or a = 58 Or a = 6) Then
            e.Handled = True
            'End If
        End If
    End Sub

    Public Sub letra(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA  VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 65 And a <= 90 Or a >= 97 And a <= 122 Or a >= 200 And a <= 250 Or a = 8 Or a = 32 Or a = 46) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub telefono(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As GroupBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 46 And a <= 57 Or a = 8 Or a = 45) Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub mixto(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 48 And a <= 57 Or a >= 65 And a <= 90 Or a >= 97 And a <= 122 Or a >= 200 And a <= 250 Or a = 8 Or a = 32 Or a = 45 Or a = 46) Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub consulta(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 48 And a <= 57 Or a >= 65 And a <= 90 Or a >= 97 And a <= 122 Or a = 8 Or a = 32) Then
                e.Handled = True
            End If
        End If
    End Sub
    'solo para fecha 
    Public Sub fecha(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As TextBox)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 47 And a <= 57 Or a = 8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub fechatext(ByVal entrada As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As DateTimePicker)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a = 8 Or a >= 65 And a <= 90 Or a >= 97 And a <= 122) Then
                e.Handled = True
            End If
        End If
    End Sub
    Public Sub fechas(ByVal entrada As DateTimePicker, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByRef salida As DateTimePicker)
        Dim a As Integer
        a = Asc(e.KeyChar)
        If a = 13 Then
            If entrada.Text = "" Then
                MsgBox("CASILLA VACIO, INGRESE UN DATO")
                entrada.Focus()
            Else
                salida.Focus()
            End If
        Else
            If Not (a >= 47 And a <= 57 Or a = 8) Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
