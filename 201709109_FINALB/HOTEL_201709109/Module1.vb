Module Module1
    Public Const cost_estandar = 250
    Public Const cost_Aire_acondicionado = 290
    Public Const Cost_Jacuzzi = 370

    Public tipo_habitacion(7)
    Public Estandar(7)
    Public Aire_acondicionado(7)
    Public Jacuzzi(7)
    Public nombre(7)
    Public nit(7)
    Public numero_personas(7)
    Public pago_parcial(7)
    Public pago_total(7)
    Public habitacion(7)





    Public vector As Byte = 0


    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (nombre(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(nombre(I), (nit(I)), (numero_personas(I)), (tipo_habitacion(I)), (pago_total(I)))
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
        Form1.TextBox1.Focus()
    End Sub


    Sub limpiar_vectores()
        Form1.DataGridView1.Rows.Clear()

        vector = 0

        For I = 0 To 6

            nombre(I) = Nothing
            nit(I) = Nothing
            numero_personas(I) = Nothing
            tipo_habitacion(I) = Nothing
            Estandar(I) = Nothing
            Aire_acondicionado(I) = Nothing
            Jacuzzi(I) = Nothing
            pago_parcial(I) = Nothing
            pago_total(I) = Nothing
        Next I
    End Sub

End Module
