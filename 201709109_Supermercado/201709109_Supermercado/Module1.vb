Imports System.Math
Module Module1

    Public nombre(6) As String
    Public cantidadpacks(6) As Integer
    Public pagoparcial(6) As Double
    Public descuento(6) As Double
    Public pagototal(6) As Double
    
    Public tipopack(6) As String
    Public preciounitario(6) As Double


    Public Const pjugos = 8.5
    Public Const pfrituras = 11.2
    Public Const pgalletas = 4.25
    Public Const pbaterias = 15

    Public stockjugos(6) As Integer
    Public stockfrituras(6) As Integer
    Public stockgalletas(6) As Integer
    Public stockbaterias(6) As Integer
    Public stockpack(6) As Integer


    Public vector As Byte = 0


    Sub mostrarvectores()
        'esta funcion debe de terminar con () dos parentesis' 

        Form1.DataGridView1.Rows.Add(nombre(vector), Str(cantidadpacks(vector)), preciounitario(vector), Str(tipopack(vector)), descuento(vector), pagototal(vector), stockpack(vector))



    End Sub




    Sub limpiardatos()
        Form1.TextBox1.Clear()
        Form1.ComboBox1.SelectedIndex = -1
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
