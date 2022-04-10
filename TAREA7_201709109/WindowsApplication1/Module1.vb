Module Module1
    Public docs = 0.015
    Public Ropa = 0.06
    Public art_no_perecederos = 0.055
    Public art_plastico = 0.045
    Public lociones = 0.02
    Public camion = 50
    Public motocicleta = 15


    Public Nombre(10)
    Public Valor_paquete(10)
    Public Pagoparcial(10)
    Public valor_impuesto(10)
    Public Pago_total(10)
    Public tipo_transporte(10)
    Public tipo_articulo(10)
    Public numero_articulo(10)
    Public peso(10)

    Public total(10)


    Public contador = 0





    Sub Limpiar_Listas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
    End Sub



    Sub Limpiar_Entradas()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.TextBox1.Focus()

    End Sub
End Module
