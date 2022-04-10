Imports System.Math
Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If
        Valor_paquete(contador) = TextBox3.Text
        Nombre(contador) = TextBox1.Text
        peso(contador) = Val(TextBox2.Text)


        If contador < 10 Then
            numero_articulo(contador) = contador + 1
            tipo_articulo(contador) = ComboBox1.SelectedItem
            tipo_transporte(contador) = ComboBox2.SelectedItem


            Select Case tipo_articulo(contador)
                Case "Documentos"
                    Select Case tipo_transporte(contador)
                        Case "Camion"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * docs
                            Pagoparcial(contador) = Val(TextBox3.Text) + camion
                        Case "Motocicleta"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * docs
                            Pagoparcial(contador) = Val(TextBox3.Text) + motocicleta
                    End Select
                Case "Ropa"
                    Select Case tipo_transporte(contador)
                        Case "Camion"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * Ropa
                            Pagoparcial(contador) = Val(TextBox3.Text) + camion
                        Case "Motocicleta"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * Ropa
                            Pagoparcial(contador) = Val(TextBox3.Text) + motocicleta
                    End Select
                Case "Articulos no perecederos"
                    Select Case tipo_transporte(contador)
                        Case "Camion"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * art_no_perecederos
                            Pagoparcial(contador) = Val(TextBox3.Text) + camion
                        Case "Motocicleta"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * art_no_perecederos
                            Pagoparcial(contador) = Val(TextBox3.Text) + motocicleta
                    End Select
                Case "Articulos de plastico"
                    Select Case tipo_transporte(contador)
                        Case "Camion"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * art_plastico
                            Pagoparcial(contador) = Val(TextBox3.Text) + camion
                        Case "Motocicleta"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * art_plastico
                            Pagoparcial(contador) = Val(TextBox3.Text) + motocicleta
                    End Select
                Case "Lociones"
                    Select Case tipo_transporte(contador)
                        Case "Camion"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * lociones
                            Pagoparcial(contador) = Val(TextBox3.Text) + camion
                        Case "Motocicleta"
                            valor_impuesto(contador) = (Val(TextBox3.Text)) * lociones
                            Pagoparcial(contador) = Val(TextBox3.Text) + motocicleta
                    End Select

            End Select

            Pago_total(contador) = Pagoparcial(contador) + valor_impuesto(contador)

            ListBox1.Items.Add(Nombre(contador))
            ListBox2.Items.Add(peso(contador))
            ListBox3.Items.Add(Valor_paquete(contador))
            ListBox4.Items.Add(Round(Pagoparcial(contador), 2))
            ListBox5.Items.Add(Round(valor_impuesto(contador), 2))
            ListBox6.Items.Add(Round(Pago_total(contador), 2))



       

            contador = contador + 1



        Else
            MsgBox("se ha llegado al limite de registros")

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            'Llamada al procedimiento que limpia entradas y limpia listas
            Limpiar_Entradas()
            Limpiar_Listas()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Limpiar_Entradas()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Limpiar_Listas()
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim K As Byte
        Dim R1 As Byte = 0
        Dim R2 As Byte = 0
        Dim R3 As Byte = 0
        Dim R4 As Byte = 0

        For K = 0 To 9
            If (tipo_articulo(K) = "Articulos de plastico") Then
                R1 = R1 + 1
            End If
            If (tipo_articulo(K) = "Ropa") Then
                R2 = R2 + 1
            End If


            If tipo_articulo(10) = "Lociones" Then
                R3 = R3 + Val(ListBox1.Items.Item(R3))
            End If
        If tipo_articulo(10) = "Ropa" Then
            R4 = R4 + Val(ListBox1.Items.Item(R4))
        End If

        Next K
        TextBox5.Text = Str(R1)
        TextBox6.Text = Str(R2)
        TextBox4.Text = Str(R3)
        TextBox7.Text = Str(R4)
    End Sub
End Class
