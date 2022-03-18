Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If vector <= 6 Then


            If Val(TextBox1.Text <> "") Then
                nombre(vector) = TextBox1.Text
            Else
                MsgBox("Error, ingresar nombre por favor")
                TextBox1.Focus() : Exit Sub
            End If


            End If



         Select ComboBox1.SelectedIndex
            Case 0
                venta(vector) = 375
            Case 1
                venta(vector) = 560
            Case 2
                venta(vector) = 1450
            Case 3
                venta(vector) = 3250
            Case Else
              

        End Select



        Select Case ComboBox2.SelectedIndex
            Case 0
                comision(vector) = Val(TextBox3.Text) * 0.03
            Case 1
                comision(vector) = Val(TextBox3.Text) * 0.04
            Case 2
                comision(vector) = Val(TextBox3.Text) * 0.05
            Case Else
              

        End Select
        articulo(vector) = ComboBox1.Text
        bono(vector) = (venta(vector) * 0.055)
        sueldo(vector) = TextBox3.Text
        Sueldofinal(vector) = bono(vector) + comision(vector) + sueldo(vector)
        mostrarvectores()
        vector = vector + 1

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        limpiargrid()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpiardatos()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        salir()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
