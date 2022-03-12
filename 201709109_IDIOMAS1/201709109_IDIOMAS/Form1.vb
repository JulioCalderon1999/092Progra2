Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        salir()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If vector <= 7 Then


            If Val(TextBox1.Text <> "") Then
                carne(vector) = TextBox1.Text
            Else
                MsgBox("Error, ingresar carné por favor")
                TextBox1.Focus() : Exit Sub
            End If


            If TextBox2.Text <> "" Then
                nombre(vector) = TextBox2.Text
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox2.Focus() : Exit Sub
            End If


            If TextBox3.Text <> "" Then
                horas(vector) = TextBox3.Text
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox3.Focus() : Exit Sub
            End If


            Select Case ComboBox1.SelectedIndex
                Case 0
                    idioma(vector) = 150 * horas(vector)
                Case 1
                    idioma(vector) = 80 * horas(vector)
                Case 2
                    idioma(vector) = 125 * horas(vector)
                Case Else
                    MsgBox("Error, no seleccionó ningun idioma")
                    TextBox1.Focus()

            End Select


            pagoparcial(vector) = idioma(vector)

            Select Case ComboBox2.SelectedIndex
                Case 0
                    descuento1(vector) = pagoparcial(vector) * 0.02
                Case Not descuento1(vector) = 0

                Case 1
                    descuento1(vector) = pagoparcial(vector) * 0.015
                Case Not descuento1(vector) = 0
                Case Else
                    MsgBox("Error, por favor seleccionar tipo de pago")

            End Select




            If CheckBox1.Checked = False And CheckBox2.Checked = False Then
                MsgBox("Seleccionar los dias de curso")
            End If

            If CheckBox1.Checked = True And CheckBox2.Checked = True Then
                descuento2(vector) = pagoparcial(vector) * 0.05

            Else
                descuento2(vector) = 0
            End If




            idioma(vector) = (ComboBox1.Text)
            tipodepago(vector) = ComboBox2.Text
            pagototal(vector) = pagoparcial(vector) - descuento1(vector) - descuento2(vector)
            Sabado(vector) = CheckBox1.Checked
            Domingo(vector) = CheckBox2.Checked

            mostrarvectores()
            vector = vector + 1







        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiargrid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        limpiardatos()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
