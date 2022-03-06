Imports System.Math
Module Module1
    Public nombre(6) As String
    Public nit(6) As Integer
    Public honorarios(6) As Double
    Public numero_dias(6) As String
    Public tipodepago(6) As String
    Public costohabitacion(6) As Double
    Public pagoparcial(6) As Double
    Public descuento(6) As Double
    Public Cargo(6) As Double
    Public pagototal(6) As Double
    Public vector As Byte = 0




    Sub mostrarvectores()
        'esta funcion debe de terminar con () dos parentesis' 

        Form1.DataGridView1.Rows.Add(nombre(vector), (nit(vector)), str(honorarios(vector)), str(numero_dias(vector)), costohabitacion(vector), tipodepago(vector), str(Round(pagoparcial(vector), 2)), str(Round(descuento(vector), 2)), str(Round(Cargo(vector), 2)), str(Round(pagototal(vector), 2)))

    End Sub


    Sub limpiargrid()
        Form1.DataGridView1.Rows.Clear()
    End Sub

    Sub limpiardatos()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
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


