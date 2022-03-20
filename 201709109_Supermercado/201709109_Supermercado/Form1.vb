Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If vector <= 5 Then

            If TextBox1.Text <> "" Then
                nombre(vector) = TextBox1.Text
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox1.Focus() : Exit Sub
            End If


            If TextBox2.Text <> "" Then
                cantidadpacks(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox2.Focus() : Exit Sub
            End If





            Select Case ComboBox1.SelectedIndex
                Case 0
                    tipopack(vector) = 8.5 * Val(TextBox2.Text)
                    preciounitario(vector) = pjugos
                    stockpack(vector) = 100 - Val(TextBox2.Text)

                Case 1
                    tipopack(vector) = 11.2 * Val(TextBox2.Text)
                    preciounitario(vector) = pfrituras
                    stockpack(vector) = 100 - Val(TextBox2.Text)
                Case 2
                    tipopack(vector) = 4.25 * Val(TextBox2.Text)
                    preciounitario(vector) = pgalletas
                    stockpack(vector) = 100 - Val(TextBox2.Text)
                Case 3
                    tipopack(vector) = 15 * Val(TextBox2.Text)
                    preciounitario(vector) = pbaterias
                    stockpack(vector) = 100 - Val(TextBox2.Text)
                Case Else
                    MsgBox("Error, no seleccionó ningun tipo de pack")
                    TextBox1.Focus()
            End Select




            If cantidadpacks(vector) > 10 Then
                descuento(vector) = tipopack(vector) * 0.1

            ElseIf cantidadpacks(vector) <= 3 Then
                descuento(vector) = tipopack(vector) * 0.03
            Else
                descuento(vector) = tipopack(vector) * 0.05
            End If






            pagototal(vector) = tipopack(vector) - descuento(vector)
            mostrarvectores()
            vector = vector + 1

        End If

        If vector = 6 Then
            MsgBox("Almacenamiento lleno")

        End If


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        salir()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiargrid()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpiardatos()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
