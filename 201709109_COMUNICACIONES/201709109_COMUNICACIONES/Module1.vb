Imports System.Math
Module Module1
    Public Tablet(7) As String
    Public Drone(7) As String
    Public Celular(7) As String
    Public Televisor(7) As String
    Public nombre(7) As String
    Public sueldo(7) As Double
    Public comision(7) As Double
    Public articulo(7) As String
    Public venta(7) As Double
    Public bono(7) As Double
    Public Sueldofinal(7) As Double


    Public vector As Byte = 0


    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Add(nombre(vector), (articulo(vector)), (comision(vector)), (bono(vector)), (sueldo(vector)), (Sueldofinal(vector)))

    End Sub


    Sub limpiardatos()
        Form1.TextBox1.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.SelectedIndex = -1
        Form1.ComboBox2.SelectedIndex = -1
        Form1.TextBox1.Focus()

    End Sub


    Sub limpiargrid()
        Form1.DataGridView1.Rows.Clear()
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
