Module Module1
    Public Const psofa = 250.99
    Public Const pindividual = 150.99
    Public Const pdoble = 200.99

    Public Const pcuero = 75
    Public Const pcuerina = 45.99

    Public tamaño(8)
    Public material(8)
    Public precio(8)
    Public numeroventa(8)
    Public preciomanoobra(8)
    Public preciocosto(8)
    Public precioventa(8)


    Public contador = 0



    Sub Limpiar_Entradas()
        Form1.ComboBox1.Text = ""
        Form1.ComboBox2.Text = ""
        Form1.ComboBox1.Focus()

    End Sub


    Sub Limpiar_Listas()
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()

    End Sub

End Module
