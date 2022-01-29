Public Class Form1

    Const precioazucar As Double = 2.0
    Const precioarroz As Double = 1.75
    Const preciofrijol As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagosinIVA As Double = 0
    Dim valorIVA As Double = 0
    Dim pagoconIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        'ESTO CODIGO KEYPRESS SOLO ACEPTA NUMEROS´
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub precioazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        'lo relacionado con el boton de aceptar' 
        pagosinIVA = (Val((TextBox1.Text * precioazucar) + (TextBox2.Text * preciofrijol) + (TextBox3.Text * precioarroz)))


        valorIVA = pagosinIVA * IVA
        pagoconIVA = valorIVA + pagosinIVA
        descuento = System.Math.Round((pagoconIVA * 0.025), 2)
        pagofinal = pagoconIVA - descuento
        TextBox4.Text = pagosinIVA
        TextBox5.Text = valorIVA
        TextBox6.Text = pagoconIVA
        TextBox7.Text = descuento
        TextBox8.Text = pagofinal


    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()






    End Sub

    Private Sub lblR1_Click(sender As Object, e As EventArgs) Handles lblR1.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub lblR3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblR2_Click(sender As Object, e As EventArgs) Handles lblR2.Click

    End Sub

    Private Sub lblR4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        End

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

