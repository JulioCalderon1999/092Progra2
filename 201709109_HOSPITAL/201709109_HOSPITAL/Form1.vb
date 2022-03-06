Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        If vector <= 5 Then
            If TextBox1.Text <> "" Then
                nombre(vector) = TextBox1.Text
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox1.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text <> "")) Then
                nit(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar nit")
                TextBox2.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text <> "")) Then
                honorarios(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar honorarios")
                TextBox3.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox4.Text) And Val(TextBox4.Text <> "")) Then
                numero_dias(vector) = Val(TextBox4.Text)
            Else
                MsgBox("Error, ingresar numero de dias")
                TextBox4.Focus() : Exit Sub
            End If


            Select Case ComboBox2.SelectedIndex
                Case 0
                    costohabitacion(vector) = 350 * numero_dias(vector)
                Case 1
                    costohabitacion(vector) = 250 * numero_dias(vector)
                Case 2
                    costohabitacion(vector) = 150 * numero_dias(vector)
                Case Else
                    MsgBox("Error, no se seleciono ninguna habitación")
                    TextBox1.Focus()
            End Select

            pagoparcial(vector) = honorarios(vector) + costohabitacion(vector)

            Select Case ComboBox1.SelectedIndex
                Case 0
                    descuento(vector) = pagoparcial(vector) * 0.15
                Case Not descuento(vector) = 0
                Case 1
                    descuento(vector) = pagoparcial(vector) * 0.15
                Case Not descuento(vector) = 0
                Case 2
                    Cargo(vector) = pagoparcial(vector) * 0.08
                Case Not Cargo(vector) = 0
                Case 3
                    Cargo(vector) = pagoparcial(vector) * 0.05
                Case Not Cargo(vector) = 0
                Case Else
                    MsgBox("Error, por favor seleccionar tipo de pago")
                    TextBox1.Focus() : Exit Sub

            End Select

            tipodepago(vector) = ComboBox1.Text
            costohabitacion(vector) = Val(ComboBox2.Text)
            pagototal(vector) = pagoparcial(vector) + Cargo(vector) - descuento(vector)
            mostrarvectores()
            vector = vector + 1
        End If
        If vector = 6 Then
            MsgBox("Almacenamiento lleno")

        End If









    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

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

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        salir()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpiargrid()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        limpiardatos()
    End Sub
End Class
