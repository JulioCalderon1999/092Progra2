Public Class Form1

    Private Sub SALIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALIRToolStripMenuItem.Click
        If MsgBox(" ¿ Desea salir del programa ? ", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINARToolStripMenuItem.Click
        Dim I As Byte

        nit(vector) = Nothing
        nombre_pelicula(vector) = Nothing
        cantidad_boletos(vector) = Nothing
        tipo_sala(vector) = Nothing
        pago_total(vector) = Nothing

        For I = vector To 6

            nit(I) = nit(I + 1)
            nombre_pelicula(I) = nombre_pelicula(I + 1)
            cantidad_boletos(I) = cantidad_boletos(I + 1)
            tipo_sala(I) = tipo_sala(I + 1)
            pago_total(I) = pago_total(vector)
            
        Next I
        MsgBox("Registro Eliminado exitosamente")

        nit(vector) = Nothing
        nombre_pelicula(vector) = Nothing
        cantidad_boletos(vector) = Nothing
        tipo_sala(vector) = Nothing
        pago_total(vector) = Nothing

        vector = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrarvectores()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vectores()

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False

        Dim I As Byte
        I = 0
        While (I <= 6) And Not (existe)

            If (nit(I) = Val(TextBox4.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = nombre_pelicula(I)
            TextBox2.Text = nit(I)
            TextBox3.Text = cantidad_boletos(I)
            ComboBox1.Text = tipo_sala(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(nit(I), (nombre_pelicula(I)), (cantidad_boletos(I)), (tipo_sala(I)), (pago_total(I)))

            vector = I
        Else
            MsgBox("Carnet no encontrado")
            TextBox4.Focus()
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTUALIZARToolStripMenuItem.Click

        nombre_pelicula(vector) = (TextBox1.Text)
        nit(vector) = (TextBox2.Text)
        cantidad_boletos(vector) = Val(TextBox3.Text)
        tipo_sala(vector) = ComboBox1.Text


        MsgBox("Registro actualizado correctamente en los vectores")

        vector = 6
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        If vector <= 6 Then

            If Val(TextBox1.Text <> "") Then
                nombre_pelicula(vector) = Val(TextBox1.Text)
            Else
                MsgBox("Error, ingresar nombre de la pelicula")
                TextBox1.Focus() : Exit Sub
            End If
            If Val(TextBox2.Text <> "") Then
                nit(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar NIT")
                TextBox2.Focus() : Exit Sub
            End If


            If Val(TextBox3.Text <> "") Then
                cantidad_boletos(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar nombre de la pelicula")
                TextBox1.Focus() : Exit Sub
            End If



             Select ComboBox1.SelectedIndex
                Case 0
                    pago_total(vector) = Val(TextBox3.Text) * cost_normal
                Case 1
                    pago_total(vector) = Val(TextBox3.Text) * cost_3D
                Case 2
                    pago_total(vector) = Val(TextBox3.Text) * cost_4DX
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo de sala")
                    TextBox1.Focus()
            End Select


            nombre_pelicula(vector) = TextBox1.Text
            nit(vector) = TextBox2.Text
            cantidad_boletos(vector) = TextBox3.Text
            tipo_sala(vector) = ComboBox1.Text
            vector = vector + 1
            limpiar_entradas()


            If vector = 7 Then
                MsgBox("Almacenamiento lleno")

            End If

        End If

    End Sub
End Class
