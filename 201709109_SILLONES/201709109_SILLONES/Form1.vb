Imports System.Math
Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If



        If contador < 8 Then
            numeroventa(contador) = contador + 1
            tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem




            Select Case tamaño(contador)
                Case "Sofa"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = psofa
                            preciocosto(contador) = 8 * pcuero + preciomanoobra(contador)
                        Case "Cuerina"
                            preciomanoobra(contador) = psofa
                            preciocosto(contador) = 8 * pcuerina + preciomanoobra(contador)
                            'calculo'
                    End Select
                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = pindividual
                            preciocosto(contador) = 3.5 * pcuero + preciomanoobra(contador)
                        Case "Cuerina"
                            preciomanoobra(contador) = psofa
                            preciocosto(contador) = 3.5 * pcuerina + preciomanoobra(contador)
                            'calculo'
                    End Select

                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            preciomanoobra(contador) = pdoble
                            preciocosto(contador) = 6 * pcuero + preciomanoobra(contador)
                        Case "Cuerina"
                            preciomanoobra(contador) = pdoble
                            preciocosto(contador) = 6 * pcuerina + preciomanoobra(contador)
                            'calculo'
                    End Select
            End Select

            precioventa(contador) = (preciocosto(contador) * 0.65) + preciocosto(contador)


            ListBox1.Items.Add(Str(numeroventa(contador)))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(Round(preciomanoobra(contador), 2))
            ListBox5.Items.Add(Round(preciocosto(contador), 2))
            ListBox6.Items.Add(Round(precioventa(contador), 2))

            contador = contador + 1


        Else
            MsgBox("se ha llegado al limite de registros")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Limpiar_Entradas()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Limpiar_Listas()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Mensaje de Salida") = vbYes) Then
            End
        Else
            'Llamada al procedimiento que limpia entradas y limpia listas
            Limpiar_Entradas()
            Limpiar_Listas()
        End If

    End Sub

End Class
