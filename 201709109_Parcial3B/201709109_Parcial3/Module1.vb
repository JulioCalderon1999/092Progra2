Module Module1


    Public Const cost_normal = 44
    Public Const cost_3D = 62
    Public Const cost_4DX = 104
    Public tipo_sala(7)
    Public precio_boleto(7)
    Public nit(7)
    Public nombre_pelicula(7)
    Public cantidad_boletos(7)
    Public pago_total(7)


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
            If (nit(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(nit(I), (nombre_pelicula(I)), (cantidad_boletos(I)), (tipo_sala(I)), (pago_total(I)))
            Else
                Continue For
            End If
        Next

    End Sub


    Sub limpiar_vectores()

        Form1.DataGridView1.Rows.Clear()

        vector = 0

        For I = 0 To 6
            '
            nit(vector) = Nothing
            nombre_pelicula(vector) = Nothing
            cantidad_boletos(vector) = Nothing
            tipo_sala(vector) = Nothing
            pago_total(vector) = Nothing
           
        Next I

    End Sub
End Module
