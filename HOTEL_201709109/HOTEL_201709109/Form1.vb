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
            If (IsNumeric(TextBox2.Text) And Val(TextBox2.Text <> "")) Then
                nit(vector) = Val(TextBox2.Text)
            Else
                MsgBox("Error, ingresar NIT")
                TextBox2.Focus() : Exit Sub
            End If
            If (IsNumeric(TextBox3.Text) And Val(TextBox3.Text <> "")) Then
                numero_dias(vector) = Val(TextBox3.Text)
            Else
                MsgBox("Error, ingresar el numero de dias")
                TextBox2.Focus() : Exit Sub
            End If


            numero_dias(vector) = TextBox2.Text


            Select Case ComboBox1.SelectedIndex
                Case 0
                    sencilla(vector) = cost_sencilla
                Case 1
                    doble(vector) = cost_doble
                Case 2
                    cabaña(vector) = Cost_cabaña

                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select

            tipo_habitacion(vector) = ComboBox1.Text


            Select Case ComboBox1.SelectedIndex
                Case 0
                    habitacion(vector) = sencilla
                Case 1
                    habitacion(vector) = doble
                Case 2
                    habitacion(vector) = cabaña
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select



            Select Case ComboBox2.SelectedIndex
                Case 0
                    pago_parcial(vector) = Val((tipo_habitacion(vector)) - (0.15 * Val(tipo_habitacion(vector)))) * Val(numero_dias(vector))
                Case 1
                    pago_parcial(vector) = Val((tipo_habitacion(vector)) + (0.03 * Val(tipo_habitacion(vector)))) * Val(numero_dias(vector))
                Case 2
                    pago_parcial(vector) = Val((tipo_habitacion(vector))) * Val(numero_dias(vector))
                Case 3
                    pago_parcial(vector) = Val((tipo_habitacion(vector))) * Val(numero_dias(vector))
                Case Else
                    MsgBox("Error, no se seleciono ningun tipo")
                    TextBox1.Focus()
            End Select



            Select Case ComboBox2.SelectedIndex
                Case 0
                    tipo_pago(vector) = efectivo
                Case 1
                    tipo_pago(vector) = tarjeta
                Case 2
                    tipo_pago(vector) = transferencia
                Case 3
                    tipo_pago(vector) = deposito
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
        numero_dias(vector) = Nothing
        tipo_habitacion(vector) = Nothing
        sencilla(vector) = Nothing
        doble(vector) = Nothing
        cabaña(vector) = Nothing
        tipo_pago(vector) = Nothing
        efectivo(vector) = Nothing
        tarjeta(vector) = Nothing
        transferencia(vector) = Nothing
        deposito(vector) = Nothing
        pago_parcial(vector) = Nothing
        pago_total(vector) = Nothing

        For I = vector To 6

            nombre(I) = nombre(I + 1)
            nit(I) = nit(I + 1)
            numero_dias(I) = numero_dias(I + 1)
            tipo_habitacion(I) = tipo_habitacion(I + 1)
            sencilla(I) = sencilla(vector)
            doble(I) = doble(I + 1)
            cabaña(I) = cabaña(I + 1)
            tipo_pago(I) = tipo_pago(I + 1)
            efectivo(I) = efectivo(I + 1)
            tarjeta(I) = tarjeta(I + 1)
            transferencia(I) = transferencia(I + 1)
            deposito(I) = deposito(I + 1)
            pago_parcial(I) = pago_parcial(I + 1)
            pago_parcial(I) = pago_parcial(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")

        nombre(vector) = Nothing
        nit(vector) = Nothing
        numero_dias(vector) = Nothing
        tipo_habitacion(vector) = Nothing
        sencilla(vector) = Nothing
        doble(vector) = Nothing
        cabaña(vector) = Nothing
        tipo_pago(vector) = Nothing
        efectivo(vector) = Nothing
        tarjeta(vector) = Nothing
        transferencia(vector) = Nothing
        deposito(vector) = Nothing
        pago_parcial(vector) = Nothing
        pago_total(vector) = Nothing
        vector = I
        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click



        Form1.DataGridView1.Rows.Clear()

        vector = 0

        For I = 0 To 6

            nombre(I) = Nothing
            nit(I) = Nothing
            numero_dias(I) = Nothing
            tipo_habitacion(I) = Nothing
            sencilla(I) = Nothing
            doble(I) = Nothing
            cabaña(I) = Nothing
            tipo_pago(I) = Nothing
            efectivo(I) = Nothing
            tarjeta(I) = Nothing
            transferencia(I) = Nothing
            deposito(I) = Nothing
            pago_parcial(I) = Nothing
            pago_total(I) = Nothing
        Next I
    End Sub
End Class
