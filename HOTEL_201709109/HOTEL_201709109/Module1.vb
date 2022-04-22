Module Module1
    Public Const cost_sencilla = 250
    Public Const cost_doble = 400
    Public Const Cost_cabaña = 650

    Public tipo_habitacion(7)
    Public sencilla(7)
    Public doble(7)
    Public cabaña(7)
    Public nombre(7)
    Public nit(7)
    Public numero_dias(7)
    Public tipo_pago(7)
    Public efectivo(7)
    Public tarjeta(7)
    Public transferencia(7)
    Public deposito(7)
    Public pago_parcial(7)
    Public pago_total(7)
    Public habitacion(7)





    Public vector As Byte = 0





    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (nombre(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(nombre(I), (habitacion(I)), (nit(I)), (numero_dias(I)), (tipo_pago(I)))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Continue For
            End If
        Next

    End Sub



    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()
    End Sub


End Module
