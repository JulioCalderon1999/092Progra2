Imports System.Math
Module Module1
    Public carne(8) As Double
    Public nombre(8) As String
    Public idioma(8) As String
    Public dias(8) As String
    Public fecha(8) As String
    Public horas(8) As Double
    Public descuento1(8) As Double
    Public descuento2(8) As Double
    Public pagoparcial(8) As Double
    Public pagototal(8) As Double
    Public tipodepago(8) As String
    Public Sabado(8) As String
    Public Domingo(8) As String

    Public vector As Byte = 0


    Sub mostrarvectores()

        Form1.DataGridView1.Rows.Add(carne(vector), nombre(vector), idioma(vector), (horas(vector)), tipodepago(vector), pagoparcial(vector), descuento1(vector), descuento2(vector), pagototal(vector), Sabado(vector), Domingo(vector))

    End Sub

    Sub limpiargrid()
        Form1.DataGridView1.Rows.Clear()
    End Sub


    Sub limpiardatos()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Focus()

    End Sub

    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiardatos()
            limpiargrid()
        End If
    End Sub


End Module
