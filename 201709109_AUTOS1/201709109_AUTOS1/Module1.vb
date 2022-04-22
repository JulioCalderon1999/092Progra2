Module Module1

    Public Const cost_tipo1 = 500
    Public Const cost_tipo2 = 400
    Public Const cost_tipo3 = 300
    Public Const cost_tipo4 = 200
    Public Const tarifa1 = 3
    Public Const tarifa2 = 4
    Public Const tarifa3 = 5
    Public km_inicial(7)
    Public km_final(7)
    Public km_recorridos(7)
    Public placa(7)
    Public tipo_de_auto(7)
    Public tipo1(7)
    Public tipo2(7)
    Public tipo3(7)
    Public tipo4(7)
    Public pago_por_kilometraje(7)
    Public pago_final(7)
    Public costo_base(7)


    Public vector As Byte = 0

    Sub limpiar_entradas()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.ComboBox1.Text = ""
        Form1.TextBox1.Focus()
    End Sub


    Sub mostrarvectores()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If (placa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(placa(I), (tipo_de_auto(I)), (costo_base(I)), (km_inicial(I)), (km_final(I)), (pago_final(I)), (pago_por_kilometraje(I)))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Continue For
            End If
        Next

    End Sub


    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        vector = 0

        For I = 0 To 6
            '
            km_inicial(vector) = Nothing
            km_final(vector) = Nothing
            km_recorridos(vector) = Nothing
            placa(vector) = Nothing
            tipo_de_auto(vector) = Nothing
            tipo1(vector) = Nothing
            tipo2(vector) = Nothing
            tipo3(vector) = Nothing
            tipo4(vector) = Nothing
            pago_por_kilometraje(vector) = Nothing
            pago_final(vector) = Nothing
            costo_base(vector) = Nothing
        Next I

    End Sub

End Module
