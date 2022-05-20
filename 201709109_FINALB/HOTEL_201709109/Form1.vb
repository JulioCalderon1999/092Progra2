Public Class Form1

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CALCULARToolStripMenuItem.Click
        If vector <= 6 Then
            If Val(TextBox1.Text <> "") Then
                nombre(vector) = Val(TextBox1.Text)
            Else
                MsgBox("Error, ingresar nombre")
                TextBox1.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text <> "")) Then
                nit(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar NIT")
                TextBox2.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text <> "")) Then
                numero_personas(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar el numero de personas")
                TextBox2.Focus() : Exit Sub
            End If


            numero_personas(vector) = TextBox2.Text


            Select Case ComboBox1.SelectedIndex
                Case 0
                    pago_total(vector) = cost_estandar
                Case 1
                    pago_total(vector) = cost_Aire_acondicionado
                Case 2
                    pago_total(vector) = Cost_Jacuzzi

                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select

            tipo_habitacion(vector) = ComboBox1.Text


            Select Case ComboBox1.SelectedIndex
                Case 0
                    habitacion(vector) = Estandar
                Case 1
                    habitacion(vector) = Aire_acondicionado
                Case 2
                    habitacion(vector) = Jacuzzi
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select



            nit(vector) = TextBox3.Text




        End If
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrarvectores()

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ELIMINARToolStripMenuItem.Click

        Dim I As Byte

        nombre(vector) = Nothing
        nit(vector) = Nothing
        numero_personas(vector) = Nothing
        tipo_habitacion(vector) = Nothing
        Estandar(vector) = Nothing
        Aire_acondicionado(vector) = Nothing
        Jacuzzi(vector) = Nothing
        pago_parcial(vector) = Nothing
        pago_total(vector) = Nothing

        For I = vector To 6

            nombre(I) = nombre(I + 1)
            nit(I) = nit(I + 1)
            numero_personas(I) = numero_personas(I + 1)
            tipo_habitacion(I) = tipo_habitacion(I + 1)
            Estandar(I) = Estandar(vector)
            Aire_acondicionado(I) = Aire_acondicionado(I + 1)
            Jacuzzi(I) = Jacuzzi(I + 1)
            pago_parcial(I) = pago_parcial(I + 1)
            pago_parcial(I) = pago_parcial(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        nombre(vector) = Nothing
        nit(vector) = Nothing
        numero_personas(vector) = Nothing
        tipo_habitacion(vector) = Nothing
        Estandar(vector) = Nothing
        Aire_acondicionado(vector) = Nothing
        Jacuzzi(vector) = Nothing
        pago_parcial(vector) = Nothing
        pago_total(vector) = Nothing
        vector = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click

        limpiar_entradas()

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False

        Dim I As Byte
        I = 0
        While (I <= 6) And Not (existe)

            If (nombre(I) = Val(TextBox1.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")

            TextBox1.Text = Str(nombre(I))
            TextBox3.Text = Str(nit(I))
            TextBox2.Text = Str(numero_personas(I))
            ComboBox1.Text = tipo_habitacion(I)

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(nombre(I), (nit(I)), (numero_personas(I)), (tipo_habitacion(I)), (pago_total(I)))
            vector = I
        Else
            MsgBox("Dato no encontrado")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        nombre(vector) = Val(TextBox1.Text)
        tipo_habitacion(vector) = ComboBox1.Text
        nit(vector) = Val(TextBox3.Text)
        numero_personas(vector) = Val(TextBox2.Text)

        MsgBox("Registro actualizado correctamente")

        vector = 6
    End Sub
End Class
