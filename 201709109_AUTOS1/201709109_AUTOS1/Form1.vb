Public Class Form1

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If vector <= 6 Then

            If (IsNumeric(TextBox1.Text) And Val(TextBox1.Text <> "")) Then
                placa(vector) = Val(TextBox1.Text)
            Else
                MsgBox("Error, ingresar placa")
                TextBox1.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text <> "")) Then
                km_inicial(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar kilometraje inicial")
                TextBox2.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text <> "")) Then
                km_final(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar kilometraje final")
                TextBox2.Focus() : Exit Sub
            End If


            km_recorridos(vector) = (Val(km_final(vector)) - Val(km_inicial(vector)))
            TextBox4.Text = km_recorridos(vector)


            If Val(km_recorridos(vector)) <= 50 Then
                pago_por_kilometraje(vector) = km_recorridos(vector) * tarifa1
            End If
            If Val(km_recorridos(vector)) <= 70 And Val(TextBox4.Text) > 50 Then
                pago_por_kilometraje(vector) = km_recorridos(vector) * tarifa2
            End If
            If Val(km_recorridos(vector)) > 70 Then
                pago_por_kilometraje(vector) = km_recorridos(vector) * tarifa3
            End If





            Select Case ComboBox1.SelectedIndex
                Case 0
                    pago_final(vector) = Val(pago_por_kilometraje(vector)) + cost_tipo1
                Case 1
                    pago_final(vector) = Val(pago_por_kilometraje(vector)) + cost_tipo2
                Case 2
                    pago_final(vector) = Val(pago_por_kilometraje(vector)) + cost_tipo3
                Case 3
                    pago_final(vector) = Val(pago_por_kilometraje(vector)) + cost_tipo4
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select




            Select Case ComboBox1.SelectedIndex
                Case 0
                    costo_base(vector) = cost_tipo1
                Case 1
                    costo_base(vector) = cost_tipo2
                Case 2
                    costo_base(vector) = cost_tipo3
                Case 3
                    costo_base(vector) = cost_tipo4
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select


            tipo_de_auto(vector) = ComboBox1.Text
            vector = vector + 1
            limpiar_entradas()
        End If
        If vector = 7 Then
            MsgBox("Almacenamiento lleno")

        End If



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.Text = km_recorridos(vector)
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrarvectores()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim existe As Boolean = False

        Dim I As Byte
        I = 0
        While (I <= 6) And Not (existe)
            
            If (placa(I) = Val(TextBox5.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Str(placa(I))
            TextBox2.Text = Str(km_inicial(I))
            TextBox3.Text = Str(km_final(I))
            TextBox4.Text = Str(km_recorridos(I))
            ComboBox1.Text = tipo_de_auto(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(placa(I), (tipo_de_auto(I)), (costo_base(I)), (km_inicial(I)), (km_final(I)), (pago_final(I)), (pago_por_kilometraje(I)))

            vector = I
        Else
            MsgBox("Carnet no encontrado")
            TextBox5.Focus()
        End If


    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarToolStripMenuItem.Click
        placa(vector) = Val(TextBox1.Text)
        tipo_de_auto(vector) = ComboBox1.Text
        km_inicial(vector) = Val(TextBox2.Text)
        km_final(vector) = Val(TextBox3.Text)
        km_recorridos(vector) = Val(TextBox4.Text)


        MsgBox("Registro actualizado correctamente en los vectores")
        
        vector = 6

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim I As Byte

        km_inicial(vector) = Nothing
        km_final(vector) = Nothing
        km_recorridos(vector) = Nothing
        placa(vector) = Nothing
        tipo_de_auto(vector) = Nothing
        tipo1(vector) = Nothing
        tipo2(vector) = Nothing
        tipo3(vector) = Nothing
        tipo4(vector) = Nothing
        pago_por_kilometraje(vector) = Nothing
        pago_final(vector) = Nothing
        costo_base(vector) = Nothing

        For I = vector To 6

            km_inicial(I) = km_inicial(I + 1)
            km_final(I) = km_final(I + 1)
            km_recorridos(I) = km_recorridos(I + 1)
            placa(I) = placa(I + 1)
            tipo_de_auto(I) = tipo_de_auto(vector)
            tipo1(I) = tipo1(I + 1)
            tipo2(I) = tipo2(I + 1)
            tipo3(I) = tipo3(I + 1)
            tipo4(I) = tipo4(I + 1)
            tipo1(I) = tipo1(I + 1)
            pago_por_kilometraje(I) = pago_por_kilometraje(I + 1)
            pago_final(I) = pago_final(I + 1)
            costo_base(I) = costo_base(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        km_inicial(vector) = Nothing
        km_final(vector) = Nothing
        km_recorridos(vector) = Nothing
        placa(vector) = Nothing
        tipo_de_auto(vector) = Nothing
        tipo1(vector) = Nothing
        tipo2(vector) = Nothing
        tipo3(vector) = Nothing
        tipo4(vector) = Nothing
        pago_por_kilometraje(vector) = Nothing
        pago_final(vector) = Nothing
        costo_base(vector) = Nothing

        vector = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox(" ¿ Desea salir del programa ? ", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        End If

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub
End Class
